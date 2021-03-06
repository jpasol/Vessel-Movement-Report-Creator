﻿Imports ADODB
Imports Reports
Imports CrystalDecisions.CrystalReports
Imports Crane_Logs_Report_Creator
Imports Vessel_Movement_Report_Creator
Imports System.Collections.ObjectModel
Imports Vessel_Movement_Report_Creator_User_Controls.Model

Public Class VMRClass

    Implements IReports.IReportswSave

    Sub New(Registry As String, Username As String)
        Dim connections As New Connections
        connN4 = connections.N4Connection
        connOP = connections.OPConnection

        vmrVessel = New Vessel(Registry)

        craneLogsReport = New CLRClass(Registry, Username:=Username)
        If craneLogsReport.Exists Then
            craneLogsReport.RetrieveData()
            GetVesselFormalities()
        Else
            MsgBox("Crane Log Report of this Vessel is not yet Created")
        End If

        vmrDetails(VslInfo.registry) = Registry
        RetrieveData()

    End Sub
    Public vmrVessel As Vessel
    Private dsVMR As New dsThroughput
    Private vmrDetails(System.Enum.GetNames(GetType(VslInfo)).Length - 1) As String 'optimized to string instead of property
    Private connN4 As Connection
    Private connOP As Connection
    Private crVMR As Engine.ReportClass
    Public craneLogsReport As CLRClass
    Private Property Refkey As Integer
    Public Function GetvesselMovementReportData() As dsThroughput
        Return dsVMR
    End Function

    Enum FreightKind
        FCL
        MTY
    End Enum
    Enum CtrTyp
        Dry
        Rfr
        FRk
        Tnk
        Opn
    End Enum
    Public Enum VslInfo
        name
        owner
        voy_num
        registry
        berth
        SLGang
        ovt_req
        eta
        ata
        atd
        start_work
        frstcnt_dsc
        lstcnt_dsc
        frstcnt_load
        lstcnt_load
        end_work
        oncall_sv_dv
        regstaff
        opschecker1
        opschecker2
        opsvisor1
        opsvisor2
        opsmngr
        opscnter
        standby
        formalities_start
        formalities_end
    End Enum
    Public Property Details(index As Integer) As String
        Get
            Return vmrDetails(index)
        End Get
        Set(value As String)
            vmrDetails(index) = value
        End Set
    End Property
    Public ReadOnly Property N4Connection As Connection Implements IReportswSave.N4Connection
        Get
            N4Connection = connN4
        End Get
    End Property

    Public ReadOnly Property OPConnection As Connection Implements IReportswSave.OPConnection
        Get
            OPConnection = connOP
        End Get
    End Property
    Public Property ShutoutContainers As ObservableCollection(Of Shutout_Container)
    Public Function CalculateInfo(strFunction As String, Inputs() As String) As Object Implements IReportswSave.CalculateInfo

    End Function

    Public Sub Format(ByRef crReport As Engine.ReportClass) Implements IReportswSave.Format
        Dim tempRow As DataRow
        Dim paramLine As New CrystalDecisions.Shared.ParameterDiscreteValue
        dsVMR.Tables("dtVessel").Clear()
#Region "Create Vessel Details"
        tempRow = dsVMR.Tables("dtVessel").NewRow
        tempRow.ItemArray = vmrDetails
        For count As Integer = 0 To tempRow.ItemArray.Count - 1
            If tempRow(count).ToString.Length = 0 Or
                    IsDBNull(tempRow(count)) Then tempRow(count) = "-"
        Next
        dsVMR.Tables("dtVessel").Rows.Add(tempRow)



#End Region
#Region "Create Containers"
        Dim consolidatedDatatable As New DataTable
        consolidatedDatatable.Merge(dsVMR.dtInboundFCL)
        consolidatedDatatable.Merge(dsVMR.dtInboundMTY)
        consolidatedDatatable.Merge(dsVMR.dtOutboundFCL)
        consolidatedDatatable.Merge(dsVMR.dtOutboundMTY)

        Dim lines As String() = consolidatedDatatable.AsEnumerable.Select(Function(line) line("line_op").ToString).Distinct.ToArray
        dsVMR.Tables("dtLines").Clear()
        CreateLines(lines)
#End Region

    End Sub

    Public Sub CreateUnits()
        '0 = Inbound | 1 = Outbound
        Dim Lines() As String
        With vmrVessel.Units.Containers
            Lines = .Tables(0).AsEnumerable.Union(.Tables(1).AsEnumerable).Select(Function(line) line("line_op").ToString).Distinct.ToArray
            CreateDT(Lines, .Tables(0), "dtInbound")
            CreateDT(Lines, .Tables(1), "dtOutbound")
        End With


        CreateLines(Lines)
    End Sub

    Private Sub CreateLines(lines() As String)
        For Each linOP As String In lines
            dsVMR.Tables("dtLines").Rows.Add(vmrVessel.Registry, linOP)
        Next
    End Sub

    Private Sub GetVesselFormalities()
        On Error Resume Next
        With craneLogsReport.CraneLogsData.BerthingHourDelays.AsEnumerable.Where(Function(row) row("berthdelay") = "VFM")
            Dim delaystart As DateTime = CDate(.Select(Function(row) row("delaystart").ToString).First)
            Dim delayend As DateTime = CDate(.Select(Function(row) row("delayend").ToString).First)

            vmrDetails(VslInfo.formalities_start) = ReportFunctions.GetMilTime(delaystart)
            vmrDetails(VslInfo.formalities_end) = ReportFunctions.GetMilTime(delayend)
        End With
    End Sub

    Private Sub CreateDT(LineOP As String(), dtUnits As DataTable, dtString As String)
        Dim line() As String = LineOP
        Dim cntsize() As Long = {20, 40, 45}
        Dim cat As String = ""

        For Each lin As String In line
            For Each freight In System.Enum.GetNames(GetType(FreightKind))
                addContainers(lin, freight, dtUnits, dsVMR.Tables(dtString & freight))
            Next
            If dtString = "dtInbound" Then
                cat = "IMPRT"
            ElseIf dtString = "dtOutbound" Then
                cat = "EXPRT"
                AddShutoutContainers(lin, dtUnits) 'for export only
            End If
            addDGContainers(cat, lin, dtUnits, dsVMR.Tables("dtDG"))
        Next

    End Sub

    Private Sub AddShutoutContainers(lin As String, dtUnits As DataTable)
        For Each rw As DataRow In dtUnits.AsEnumerable().Where(Function(row) row("line_op").ToString = lin And row("transit_state").ToString.Contains("YARD"))
            dsVMR.dtShutout.AdddtShutoutRow(cntnum:=rw("id"),
                                            Line:=rw("line_op"),
                                            Description:=rw("remark"))
        Next

    End Sub

    Public Sub CreateCMU()
        Dim line As String = vmrVessel.Owner
        Dim consolidatedCraneMoves As New CraneMoves
        For Each crane As Crane In craneLogsReport.Crane
            consolidatedCraneMoves.Merge(crane.Moves)
        Next
        AddSVDMoves(line, consolidatedCraneMoves)
        AddSOBMoves(line, consolidatedCraneMoves)
        AddHatchcoverMoves(line, consolidatedCraneMoves)

    End Sub

    'Friend Sub CancelExisting()
    '    Try
    '        CancelVMR(Refkey)
    '    Catch ex As Exception
    '        MsgBox("Cannot Cancel Existing")
    '        Throw ex
    '    End Try

    'End Sub

    '    Private Sub CancelCMU(refkey As Integer)
    '        Try
    '            Dim cancelCMU As New ADODB.Command
    '            cancelCMU.ActiveConnection = connOP
    '            cancelCMU.CommandText = $"
    'UPDATE [opreports].[dbo].[reports_vmr]
    '   SET [status] = 'VOID'
    ' WHERE vmr_key = {refkey}
    '"
    '            cancelCMU.Execute()
    '        Catch ex As Exception
    '            MsgBox("Cannot Cancel CMU")
    '            Throw ex
    '        End Try
    '    End Sub

    '    Private Sub CancelVMR(refkey As Integer)
    '        Try
    '            Dim cancelVMR As New ADODB.Command
    '            cancelVMR.ActiveConnection = connOP
    '            cancelVMR.CommandText = $"
    'UPDATE [opreports].[dbo].[reports_vmr]
    '   SET [status] = 'VOID'
    ' WHERE vmr_key = {refkey}
    '"
    '            cancelVMR.Execute()
    '        Catch ex As Exception
    '            MsgBox("Cannot Cancel VMR")
    '            Throw ex
    '        End Try
    '    End Sub

    Private Function GetRefkey() As Integer
        Dim refkeyFinder As New ADODB.Command
        refkeyFinder.ActiveConnection = connOP
        refkeyFinder.CommandText = $"SELECT [vmr_key]  FROM [opreports].[dbo].[reports_vmr] where registry = '{vmrVessel.Registry}' and ([status] <> 'VOID' or [status] is null)"

        Try
            Return refkeyFinder.Execute.Fields(0).Value
        Catch ex As Exception
            MsgBox("Cannot Retrieve Refkey")
            Throw ex
        End Try
    End Function

    Private Sub AddHatchcoverMoves(line As String, moves As CraneMoves)
        Dim hatchCoverBays As String
        Dim consolidatedTable As New DataTable
        consolidatedTable.Merge(moves.Hatchcover)
        'consolidatedTable.Merge(moves.Hatchcover1)

        With consolidatedTable.AsEnumerable.Select(Function(row) New Hatchcover(row("baynum"), row("cvrsze20"), row("cvrsze40")))
            With hatchcoverSets(.ToList).AsEnumerable
                Dim bayArray As String() = .Select(Of String)(Function(row) row.bayNumber).Distinct.ToArray
                Dim hatchCoverBoxes As Integer = .Sum(Function(hc) hc.cvrsze20 + hc.cvrsze40)
                hatchCoverBays = String.Join(",", bayArray)

                If hatchCoverBoxes > 0 Then
                    dsVMR.dtCMU.AdddtCMURow(line, "LIFTED", $"{hatchCoverBoxes} HC at Bay {hatchCoverBays} (OPEN/CLOSE)")
                End If
            End With
        End With
    End Sub

    Private Function hatchcoverSets(toList As List(Of Hatchcover)) As List(Of Hatchcover)
        Dim hatchCovers As New List(Of Hatchcover)
        For Each hatchcover As Hatchcover In toList
            If Not hatchCovers.Exists(Function(hc) hc.bayNumber = hatchcover.bayNumber) Then
                hatchCovers.Add(hatchcover)
            End If
        Next
        Return hatchCovers
    End Function

    Private Sub AddSOBMoves(line As String, moves As CraneMoves)
        AddContainerMoves(line, "SHOB", "SOB", moves)
    End Sub

    Private Sub AddSVDMoves(line As String, moves As CraneMoves)
        AddContainerMoves(line, "SHFT", "SVD", moves)
        AddGearboxMoves(line, moves)
    End Sub

    Private Sub AddGearboxMoves(line As String, moves As CraneMoves)
        Dim gearboxBays As String
        Dim gearboxSizes() As Integer = {20, 40}
        For Each size As Integer In gearboxSizes
            Dim consolidatedTable As New DataTable
            consolidatedTable.Merge(moves.Gearbox)
            'consolidatedTable.Merge(moves.Gearbox1)

            With consolidatedTable.AsEnumerable.Where(Function(gbx) gbx($"gbxsze{size}") > 0)
                With .Select(Function(row) New Gearbox(row("baynum"), row("gbxsze20"), row("gbxsze40")))
                    With GearboxSets(.ToList).AsEnumerable
                        Dim bayArray As String() = .Select(Of String)(Function(gbx) gbx.baynum).Distinct.ToArray
                        Dim gearboxes As Integer = .Sum(Function(gbx) gbx.gbxsze20 + gbx.gbxsze40)
                        gearboxBays = String.Join(",", bayArray)

                        If gearboxes > 0 Then
                            dsVMR.dtCMU.AdddtCMURow(line, "SVD", $"{gearboxes}X{size}' GB at Bay {gearboxBays}")
                        End If
                    End With
                End With
            End With
        Next
    End Sub

    Private Function GearboxSets(toList As List(Of Gearbox)) As List(Of Gearbox)
        Dim gearboxes As New List(Of Gearbox)
        For Each gearbox In toList
            If Not gearboxes.Exists(Function(gbx) gbx.baynum = gearbox.baynum) Then
                gearboxes.Add(gearbox)
            End If
        Next
        Return gearboxes
    End Function

    Private Sub GenerateShutoutContainers()

        Me.ShutoutContainers = New ObservableCollection(Of Shutout_Container)(GetvesselMovementReportData.dtShutout.AsEnumerable.
                                                                  Select(Function(ctn) New Shutout_Container With {.ContainerNumber = ctn.cntnum,
                                                                                                                      .Line = ctn.Line,
                                                                                                                      .Reason = ctn.Description}))


    End Sub

    Private Sub AddContainerMoves(line As String, v As String, v1 As String, moves As CraneMoves)
        Dim containerSizes() As Integer = {20, 40, 45}
        Dim freightKinds() As String = {"FCL", "MTY"}
        For Each freight As String In freightKinds
            For Each size As Integer In containerSizes
                With moves.Container.AsEnumerable.Where(Function(row) row("container") = v _
                                                        And row($"cntsze{size}") > 0 _
                                                        And row("freight_kind") = freight)
                    With .Select(Function(ctn) New Container(ctn("move_kind"), freight, size, ctn($"cntsze{size}")))
                        Dim fullFreight As String
                        If freight = "FCL" Then fullFreight = "FULL"
                        If freight = "MTY" Then fullFreight = "EMPTY"
                        For Each container As Container In ContainerSets(.ToList)
                            dsVMR.dtCMU.AdddtCMURow(line, v1, $"{container.Boxes}X{size}' DRY {fullFreight}")
                        Next

                    End With
                End With
            Next
        Next
    End Sub

    Private Function ContainerSets(toList As List(Of Container)) As List(Of Container)
        Dim containers As New List(Of Container)

        For Each container As Container In toList
            If Not containers.Exists(Function(cnt) cnt.Size = container.Size And cnt.Boxes = container.Boxes) Then
                containers.Add(container)
            End If
        Next
        Return containers
    End Function

    Private Sub addContainers(Line As String, Freight As String, dtUnits As DataTable, dtContainer As DataTable)
        Dim tempRow As DataRow
        Dim ctrtyp As String
        Dim cntsze As Integer

        tempRow = dtContainer.NewRow
        With tempRow
            .Item("registry") = vmrVessel.Registry
            .Item("line_op") = Line
            For count As Integer = 2 To dtContainer.Columns.Count - 1
                ctrtyp = dtContainer.Columns(count).ColumnName.Substring(0, 3)
                cntsze = dtContainer.Columns(count).ColumnName.Substring(3, 2)

                .Item(count) = (From unit In dtUnits.AsEnumerable
                                Where unit("nominal_length").ToString.Substring(3, 2) = cntsze And
                                   unit("freight_kind") = Freight And
                                   unit("line_op") = Line And
                                   unit("ctrTyp") = ctrtyp And
                                   (dtContainer.TableName.Contains("dtInbound") Or Not (unit("transit_state").ToString.Contains("YARD")))).Count()

            Next
        End With
        dtContainer.Rows.Add(tempRow)
    End Sub
    Private Sub addDGContainers(Category As String, Line As String, dtUnits As DataTable, dtDG As DataTable)
        Dim dvRows As New DataView
        Dim dgrows() As DataRow
        Dim imdg() As String
        Dim cntsze() As Short

        dvRows.Table = dtUnits
        dvRows.RowFilter = "line_op = '" & Line & "' and hazardous = True"

        dgrows = (From rows As DataRow In dvRows.ToTable.Rows
                  Select rows).ToArray
        'dgrows = dtUnits.AsEnumerable.Where(Function(haz) haz("line_op") = Line And
        'haz("hazardous") = True).Select(Function(row) row).ToArray

        cntsze = dgrows.AsEnumerable.Select(Of Short)(Function(code) code("nominal_length").ToString.Substring(3, 2)).Distinct.ToArray

        For Each item In cntsze
            imdg = dgrows.AsEnumerable.Where(Function(cde) cde("nominal_length").ToString.Substring(3, 2) = item) _
                .Select(Of String)(Function(cls) cls("imdg_types").ToString).Distinct.ToArray

            For Each dgClass As String In imdg
                addTempDG(Line, Category, item, dgClass, dgrows, dtDG)
            Next
        Next


    End Sub
    Private Sub addTempDG(Line As String, Category As String, item As String, dgClass As String, dgRows As DataRow(), dtDG As DataTable)
        Dim temprow As DataRow
        Dim ctrtyp As String
        temprow = dtDG.NewRow
        With temprow
            .Item("Line") = Line
            .Item("Category") = Category
            .Item("ISO") = "N/A"
            .Item("Size") = item
            .Item("Class") = dgClass
            For count As Integer = 5 To dtDG.Columns.Count - 1
                ctrtyp = dtDG.Columns(count).ColumnName
                .Item(count) = (From rows In dgRows.AsEnumerable
                                Where rows("ctrTyp").ToString = ctrtyp And
                                        rows("imdg_types") = dgClass And
                                        rows("nominal_length").ToString.Substring(3, 2) = item).Count()
            Next
            dtDG.Rows.Add(temprow)
        End With
    End Sub
    Public Sub Preview(ByRef crReport As CrystalDecisions.CrystalReports.Engine.ReportClass, crViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer) Implements IReportswSave.Preview
        crViewer.RefreshReport()
        crViewer.Refresh()
    End Sub

    Public Sub Save() Implements IReportswSave.Save
        Try
            Dim refkey As Integer = SaveVMR() 'getRefkey when saving vmr
            SaveCMU(refkey)
            SaveDG(refkey)
            SaveShutout(refkey)
            SaveUnits(refkey)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub SaveShutout(refkey As Integer)
        For Each container As Shutout_Container In ShutoutContainers
            Dim SaveShutout As New ADODB.Command
            SaveShutout.ActiveConnection = OPConnection
            SaveShutout.CommandText = $"
INSERT INTO [opreports].[dbo].[vmr_shutout]
           ([vmr_refkey]
           ,[registry]
           ,[ctrnum]
           ,[line_op]
           ,[notes])
     VALUES
           (
            {refkey}
           ,'{Details(VslInfo.registry)}'
           ,'{container.ContainerNumber}'
           ,'{container.Line}'
           ,'{Replace(container.Reason, "'", "''")}'
)
"
            SaveShutout.Execute()
        Next
    End Sub

    Private Sub SaveDG(refkey As Integer)
        For Each row As dsThroughput.dtDGRow In dsVMR.dtDG
            Dim saveDG As New ADODB.Command
            saveDG.ActiveConnection = OPConnection
            saveDG.CommandText = $"
INSERT INTO [opreports].[dbo].[vmr_dg]
           ([vmr_refkey] 
           ,[line_op]
           ,[cntsze]
           ,[ISO]
           ,[category]
           ,[class]
           ,[Dry]
           ,[Rfr]
           ,[Tnk]
           ,[FRk]
           ,[Opn])
     VALUES
           ({refkey}
           ,'{row.Line}'
           ,{row.Size}
           ,'{row.ISO}'
           ,'{row.Category}'
           ,'{row._Class}'
           ,{row.Dry}
           ,{row.Rfr}
           ,{row.Tnk}
           ,{row.FRk}
           ,{row.Opn}
)
"
            saveDG.Execute()
        Next

    End Sub

    Private Sub SaveUnits(refkey As Integer)
        Dim bounds() As String = {"Inbound", "Outbound"}
        Dim freightKinds() As String = {"FCL", "MTY"}

        For Each bound As String In bounds
            For Each freightKind In freightKinds
                InsertToDatabase(bound, freightKind, refkey)
            Next
        Next
    End Sub

    Friend Sub DeleteExisting()
        Try
            DeleteVMR(Refkey)
        Catch ex As Exception
            MsgBox("Cannot Cancel Existing")
            Throw ex
        End Try
    End Sub

    Private Sub DeleteVMR(refkey As Integer)
        DeleteVMRReport(refkey)
        DeleteChargeables(refkey)
        DeleteDGUnits(refkey)
        DeleteUnits(refkey)
    End Sub

    Private Sub DeleteUnits(refkey As Integer)
        Dim deleteUnits As New ADODB.Command
        deleteUnits.ActiveConnection = OPConnection
        deleteUnits.CommandText = $"
DELETE FROM [opreports].[dbo].[vmr_units]
      WHERE vmr_refkey = {refkey}
"
        deleteUnits.Execute()
    End Sub

    Private Sub DeleteDGUnits(refkey As Integer)
        Dim deleteUnits As New ADODB.Command
        deleteUnits.ActiveConnection = OPConnection
        deleteUnits.CommandText = $"
DELETE FROM [opreports].[dbo].[vmr_dg]
      WHERE vmr_refkey = {refkey}
"
        deleteUnits.Execute()
    End Sub

    Private Sub DeleteChargeables(refkey As Integer)
        Dim deleteUnits As New ADODB.Command
        deleteUnits.ActiveConnection = OPConnection
        deleteUnits.CommandText = $"
DELETE FROM [opreports].[dbo].[vmr_cmu]
      WHERE vmr_refkey = {refkey}
"
        deleteUnits.Execute()
    End Sub

    Private Sub DeleteVMRReport(refkey As Integer)
        Dim deleteUnits As New ADODB.Command
        deleteUnits.ActiveConnection = OPConnection
        deleteUnits.CommandText = $"
DELETE FROM [opreports].[dbo].[reports_vmr]
      WHERE vmr_key = {refkey}
"
        deleteUnits.Execute()
    End Sub

    Private Sub InsertToDatabase(bound As String, freightKind As String, refkey As Integer)
        Dim units As DataTable = dsVMR.Tables($"dt{bound}{freightKind}")
        Dim category As String
        Select Case bound
            Case "Inbound"
                category = "IMPRT"
            Case "Outbound"
                category = "EXPRT"
        End Select

        For Each row As DataRow In units.Rows

            Dim unitsInserter As New ADODB.Command
            unitsInserter.ActiveConnection = OPConnection
            unitsInserter.CommandText = $"
INSERT INTO [opreports].[dbo].[vmr_units]
           ([vmr_refkey]
           ,[registry]
           ,[line_op]
           ,[category]
           ,[freight_kind]
           ,[Dry20]
           ,[Dry40]
           ,[Dry45]
           ,[Rfr20]
           ,[Rfr40]
           ,[FRk20]
           ,[FRk40]
           ,[Tnk20]
           ,[Opn20]
           ,[Opn40])
     VALUES
           ({refkey}
           ,'{vmrVessel.Registry}'
           ,'{row("line_op")}'
           ,'{category}'
           ,'{freightKind}'
           ,{row("Dry20")}
           ,{row("Dry40")}
           ,{row("Dry45")}
           ,{row("Rfr20")}
           ,{row("Rfr40")}
           ,{row("FRk20")}
           ,{row("FRK40")}
           ,{row("Tnk20")}
           ,{row("Opn20")}
           ,{row("Opn40")}
  )
"
            unitsInserter.Execute()
        Next
    End Sub


    Private Function SaveVMR() As Integer
        Try
            Dim dteSave As Date = Date.Now
            Dim insertVMR As New ADODB.Command
            insertVMR.ActiveConnection = connOP
            insertVMR.CommandText = $"
INSERT INTO [opreports].[dbo].[reports_vmr]
           ([name]
           ,[owner]
           ,[voy_num]
           ,[registry]
           ,[berth]
           ,[SLGang]
           ,[ovt_req]
           ,[eta]
           ,[ata]
           ,[atd]
           ,[start_work]
           ,[frstcnt_dsc]
           ,[lstcnt_dsc]
           ,[frstcnt_load]
           ,[lstcnt_load]
           ,[end_work]
           ,[oncall_sv_dv]
           ,[regstaff]
           ,[standby]
           ,[formalities_start]
           ,[formalities_end]
           ,[opschecker1]
           ,[opschecker2]
           ,[opsvisor1]
           ,[opsvisor2]
           ,[opsmngr]
           ,[opscnter]
           ,[createdate])
    OUTPUT inserted.vmr_key
     VALUES
           ('{vmrDetails(VslInfo.name)}'
           ,'{vmrDetails(VslInfo.owner)}'
           ,'{vmrDetails(VslInfo.voy_num)}'
           ,'{vmrDetails(VslInfo.registry)}'
           ,'{vmrDetails(VslInfo.berth)}'
           ,'{getDateTime(vmrDetails(VslInfo.SLGang))}'
           ,'{getDateTime(vmrDetails(VslInfo.ovt_req))}'
           ,'{getDateTime(vmrDetails(VslInfo.eta))}'
           ,'{getDateTime(vmrDetails(VslInfo.ata))}'
           ,'{getDateTime(vmrDetails(VslInfo.atd))}'
           ,'{getDateTime(vmrDetails(VslInfo.start_work))}'
           ,'{getDateTime(vmrDetails(VslInfo.frstcnt_dsc))}'
           ,'{getDateTime(vmrDetails(VslInfo.lstcnt_dsc))}'
           ,'{getDateTime(vmrDetails(VslInfo.frstcnt_load))}'
           ,'{getDateTime(vmrDetails(VslInfo.lstcnt_load))}'
           ,'{getDateTime(vmrDetails(VslInfo.end_work))}'
           ,{vmrDetails(VslInfo.oncall_sv_dv)}
           ,{vmrDetails(VslInfo.regstaff)}
           ,'{getDateTime(vmrDetails(VslInfo.standby))}'
           ,'{getDateTime(vmrDetails(VslInfo.formalities_start))}'
           ,'{getDateTime(vmrDetails(VslInfo.formalities_end))}'
           ,'{vmrDetails(VslInfo.opschecker1)}'
           ,'{vmrDetails(VslInfo.opschecker2)}'
           ,'{vmrDetails(VslInfo.opsvisor1)}'
           ,'{vmrDetails(VslInfo.opsvisor2)}'
           ,'{vmrDetails(VslInfo.opscnter)}'
           ,'{vmrDetails(VslInfo.opscnter)}'
           ,'{dteSave}'
           )
"
            Refkey = insertVMR.Execute.Fields("vmr_key").Value
            Return Refkey
        Catch ex As Exception
            MsgBox("Error Saving VMR" & vbNewLine &
               "Error Description: " & ex.Message)
            Throw ex
        End Try
    End Function

    Private Sub SaveCMU(refkey As Integer)
        Try
            For Each row As DataRow In dsVMR.dtCMU.Rows
                Dim insertCMU As New ADODB.Command
                insertCMU.ActiveConnection = connOP
                insertCMU.CommandText = $"
INSERT INTO [opreports].[dbo].[vmr_cmu]
           ([vmr_refkey]
           ,[line]
           ,[move_kind]
           ,[description])
     VALUES
           ({refkey}
           ,'{row("Line")}'
           ,'{row("move_kind")}'
           ,'{Replace(row("description"), "'", "''")}')" ' Double Character '
                insertCMU.Execute()
            Next
        Catch ex As Exception
            MsgBox("Error Saving CMU" & vbNewLine &
                    "Error Description: " & ex.Message)
            Throw ex
        End Try
    End Sub

    Public Sub RetrieveData() Implements IReportswSave.RetrieveData
        If Exist() Then
            RetrieveBySavedData()
        Else
            RetrieveByVessel(vmrVessel)
            CreateUnits()
            CreateCMU()
        End If
        GenerateShutoutContainers()
    End Sub

    Private Sub RetrieveCMU(refkey As Integer)
        Dim chargeableTable As New ADODB.Recordset
        Dim cmuSqlStatement As String = $"
SELECT [line] as Line
      ,[move_kind] as move_kind
      ,[description] as Description
  FROM [opreports].[dbo].[vmr_cmu] where vmr_refkey = {refkey}
"
        connOP.Open()
        chargeableTable.Open(cmuSqlStatement, connOP, Options:=CommandTypeEnum.adCmdText)
        Dim cmuFiller As New OleDb.OleDbDataAdapter
        cmuFiller.Fill(dsVMR.dtCMU, chargeableTable)
        connOP.Close()

    End Sub

    Private Sub RetrieveBySavedData()
        RetrieveVMR()
        RetrieveCMU(Refkey)
        RetrieveDG(Refkey)
        RetrieveSavedUnits()
        RetrieveShutoutContainers()
    End Sub

    Private Sub RetrieveShutoutContainers()
        OPConnection.Open()
        Dim dgShutout As New ADODB.Command
        dgShutout.ActiveConnection = OPConnection
        dgShutout.CommandText = $"
SELECT [ctrnum] 'cntnum'
      ,[line_op] 'Line'
      ,[notes] 'Description' 
  FROM [opreports].[dbo].[vmr_shutout]
	Where vmr_refkey = {Refkey}
"
        Dim tempContainers As ADODB.Recordset = dgShutout.Execute
        Dim adapter As New OleDb.OleDbDataAdapter
        adapter.Fill(dsVMR.dtShutout, tempContainers)
        OPConnection.Close()
    End Sub

    Private Sub RetrieveDG(refkey As Integer)
        OPConnection.Open()
        Dim dgContainers As New ADODB.Command
        dgContainers.ActiveConnection = OPConnection
        dgContainers.CommandText = $"
SELECT [line_op] as 'Line'
      ,[cntsze] as 'Size'
      ,[ISO]
      ,[category] as 'Category'
      ,[class] as 'Class'
      ,[Dry]
      ,[Rfr]
      ,[Tnk]
      ,[FRk]
      ,[Opn]
  FROM [opreports].[dbo].[vmr_dg]
	Where vmr_refkey = {refkey}
"
        Dim tempContainers As ADODB.Recordset = dgContainers.Execute
        Dim adapter As New OleDb.OleDbDataAdapter
        adapter.Fill(dsVMR.dtDG, tempContainers)
        OPConnection.Close()
    End Sub

    Private Sub RetrieveSavedUnits()
        Dim bounds() As String = {"Inbound", "Outbound"}
        Dim freightKinds() As String = {"FCL", "MTY"}

        For Each bound In bounds
            For Each freight In freightKinds
                FillUnits(bound, freight)
            Next
        Next
    End Sub

    Private Sub FillUnits(bound As String, freight As String)
        OPConnection.Open()
        Dim category As String
        Select Case bound
            Case "Inbound"
                category = "IMPRT"
            Case "Outbound"
                category = "EXPRT"
        End Select
        Dim unitRetriever As New ADODB.Command
        unitRetriever.ActiveConnection = OPConnection
        unitRetriever.CommandText = $"
SELECT [registry]
      ,[line_op]
      ,[Dry20]
      ,[Dry40]
      ,[Dry45]
      ,[Rfr20]
      ,[Rfr40]
      ,[FRk20]
      ,[FRk40]
      ,[Tnk20]
      ,[Opn20]
      ,[Opn40]
  FROM [opreports].[dbo].[vmr_units] where category = '{category}' and freight_kind = '{freight}' and vmr_refkey = {Refkey}
"
        Dim adapter As New OleDb.OleDbDataAdapter
        adapter.Fill(dsVMR.Tables($"dt{bound}{freight}"), unitRetriever.Execute)
        OPConnection.Close()
    End Sub

    Private Sub RetrieveVMR()
        Dim vesselMovementReport As New ADODB.Recordset
        connOP.Open()
        With vesselMovementReport
            .Open(Source:=$"
SELECT [vmr_key]
      ,[name]
      ,[owner]
      ,[voy_num]
      ,[registry]
      ,[berth]
      ,[SLGang]
      ,[ovt_req]
      ,[eta]
      ,[ata]
      ,[atd]
      ,[start_work]
      ,[frstcnt_dsc]
      ,[lstcnt_dsc]
      ,[frstcnt_load]
      ,[lstcnt_load]
      ,[end_work]
      ,[oncall_sv_dv]
      ,[regstaff]
      ,[standby]
      ,[formalities_start]
      ,[formalities_end]
      ,[opschecker1]
      ,[opschecker2]
      ,[opsvisor1]
      ,[opsvisor2]
      ,[opsmngr]
      ,[opscnter]
      ,[createdate]
      ,[status]
  FROM [opreports].[dbo].[reports_vmr]
	WHERE registry = '{vmrVessel.Registry}' AND ([status] <> 'VOID' or [status] is null)
    ORDER BY [vmr_key] desc
", ActiveConnection:=connOP,
Options:=CommandTypeEnum.adCmdText)
            For Each names As String In System.Enum.GetNames(GetType(VslInfo))
                Dim tempValue = .Fields(names).Value
                Try
                    vmrDetails(DirectCast(System.Enum.Parse(GetType(VslInfo), names), VslInfo)) = getMilTime(tempValue)
                Catch ex As Exception
                    vmrDetails(DirectCast(System.Enum.Parse(GetType(VslInfo), names), VslInfo)) = ReportFunctions.ParseDBNulltoString(tempValue)
                End Try
            Next
            Refkey = .Fields("vmr_key").Value
            connOP.Close()

        End With
    End Sub

    Private Sub RetrieveByVessel(vmrVessel As Vessel)
        On Error Resume Next
        With vmrVessel
            vmrDetails(VslInfo.name) = .Name
            vmrDetails(VslInfo.owner) = .Owner
            If .InboundVoyage = .OutboundVoyage Then
                vmrDetails(VslInfo.voy_num) = .InboundVoyage
            Else
                vmrDetails(VslInfo.voy_num) = .InboundVoyage & " - " & .OutboundVoyage
            End If
            vmrDetails(VslInfo.registry) = .Registry
            vmrDetails(VslInfo.berth) = .BerthWindow
            vmrDetails(VslInfo.SLGang) = getMilTime(.SLGangRequest)
            vmrDetails(VslInfo.ovt_req) = getMilTime(.OvertimeRequired)
            vmrDetails(VslInfo.eta) = getMilTime(.ETA)
            vmrDetails(VslInfo.ata) = getMilTime(.ATA)
            vmrDetails(VslInfo.atd) = getMilTime(.ATD)
            vmrDetails(VslInfo.start_work) = getMilTime(.StartWork)
            vmrDetails(VslInfo.frstcnt_dsc) = getMilTime(.FirstContainerDischarged)
            vmrDetails(VslInfo.lstcnt_dsc) = getMilTime(.LastContainerDischarged)
            vmrDetails(VslInfo.frstcnt_load) = getMilTime(.FirstContainerLoaded)
            vmrDetails(VslInfo.lstcnt_load) = getMilTime(.LastContainerLoaded)
            vmrDetails(VslInfo.end_work) = getMilTime(.EndWork)
        End With
    End Sub

    Public Function getDateTime(strMDate As String) As Date
        Try
            Return Date.ParseExact(strMDate, "HHmm\H MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture)
        Catch ex As Exception
            Return Date.Parse("Jan 1, 1970")

        End Try
    End Function

    Public Function getMilTime(strLDate As String) As String
        Dim dteDate As DateTime

        dteDate = Convert.ToDateTime(strLDate)
        getMilTime = dteDate.ToString("HHmm\H MM/dd/yyyy")
    End Function
    Public Function Exist() As Boolean Implements IReportswSave.Exists 'removed registry parameters since this can only be used when the class has been instantiated
        Dim adoCommand As New ADODB.Command

        connOP.Open()
        adoCommand.CommandText = "check_vmr"
        adoCommand.CommandType = CommandTypeEnum.adCmdStoredProc
        adoCommand.ActiveConnection = connOP

        adoCommand.Parameters(0).Type = DataTypeEnum.adBoolean
        adoCommand.Parameters(0).Direction = ParameterDirectionEnum.adParamReturnValue

        adoCommand.Parameters.Item("@Registry").Value = vmrVessel.Registry
        adoCommand.Parameters.Item("@Registry").Type = DataTypeEnum.adVarChar
        adoCommand.Parameters.Item("@Registry").Direction = ParameterDirectionEnum.adParamInput

        adoCommand.Execute()
        Dim result As Boolean = IIf(adoCommand.Parameters(0).Value = 1, True, False)
        connOP.Close()
        Return result

    End Function

End Class
