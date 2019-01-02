Imports ADODB
Imports Reports
Imports CrystalDecisions.CrystalReports
Imports Crane_Logs_Report_Creator

Public Class VMRClass

    Implements IReports.IReportswSave

    Sub New(Registry As String, ByRef N4Connection As Connection, ByRef OPConnection As Connection, Username As String)
        vmrVessel = New Vessel(Registry, N4Connection)

        connN4 = N4Connection
        connOP = OPConnection

        vmrDetails(VslInfo.registry) = Registry
        RetrieveData()

        craneLogsReport = New CLRClass(Registry, N4Connection, OPConnection, Username:=Username)
        If craneLogsReport.Exists Then
            craneLogsReport.RetrieveData()
        End If

    End Sub
    Public vmrVessel As Vessel
    Private vmrDetails(System.Enum.GetNames(GetType(VslInfo)).Length - 1) As String 'optimized to string instead of property
    Private connN4 As Connection
    Private connOP As Connection
    Private crVMR As Engine.ReportClass
    Private dsVMR As dsThroughput
    Private craneLogsReport As CLRClass
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

    Public Function CalculateInfo(strFunction As String, Inputs() As String) As Object Implements IReportswSave.CalculateInfo

    End Function

    Public Sub Format(ByRef crReport As Engine.ReportClass) Implements IReportswSave.Format
        Dim tempRow As DataRow
        Dim Lines() As String
        Dim paramLine As New CrystalDecisions.Shared.ParameterDiscreteValue
        dsVMR = New dsThroughput

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
        '0 = Inbound | 1 = Outbound
        With vmrVessel.Units.Containers
            Lines = .Tables(0).AsEnumerable.Union(.Tables(1).AsEnumerable).Select(Function(line) line("line_op").ToString).Distinct.ToArray
            CreateDT(Lines, .Tables(0), "dtInbound")
            CreateDT(Lines, .Tables(1), "dtOutbound")
        End With



#End Region
        For Each linOP As String In Lines
            dsVMR.Tables("dtLines").Rows.Add(vmrVessel.Registry, linOP)
        Next

        crReport.SetDataSource(dsVMR)

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
                cat = "Import"
            ElseIf dtString = "dtOutbound" Then
                cat = "Export"
            End If
            addDGContainers(cat, lin, dtUnits, dsVMR.Tables("dtDG"))
        Next

    End Sub
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
                                   unit("ctrTyp") = ctrtyp).Count()

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
    Private Sub addTempDG(Line As String, Category As String, item As String, dgClass As Short, dgRows As DataRow(), dtDG As DataTable)
        Dim temprow As DataRow
        Dim ctrtyp As String
        temprow = dtDG.NewRow
        With temprow
            .Item("Line") = Line
            .Item("Category") = Category
            .Item("ISO") = "N/A"
            .Item("Size") = item
            .Item("Class") = dgClass
            For count As Integer = 6 To dtDG.Columns.Count - 1
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
        crViewer.ReportSource = crReport
    End Sub

    Public Sub Save() Implements IReportswSave.Save
        Dim dteSave As Date = Date.Now
        Dim rsSave As New ADODB.Recordset
        With rsSave
            .Open("reports_vmr", OPConnection, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic, CommandTypeEnum.adCmdTable)
            .AddNew()

            .Fields("name").Value = vmrDetails(VslInfo.name)
            .Fields("owner").Value = vmrDetails(VslInfo.owner)
            .Fields("Registry").Value = vmrDetails(VslInfo.registry)
            .Fields("voy_num").Value = vmrDetails(VslInfo.voy_num)
            .Fields("berth").Value = vmrDetails(VslInfo.berth)
            .Fields("SLGang").Value = getDateTime(vmrDetails(VslInfo.SLGang))
            .Fields("ovt_req").Value = getDateTime(vmrDetails(VslInfo.ovt_req))
            .Fields("eta").Value = getDateTime(vmrDetails(VslInfo.eta))
            .Fields("ata").Value = getDateTime(vmrDetails(VslInfo.ata))
            .Fields("atd").Value = getDateTime(vmrDetails(VslInfo.atd))
            .Fields("start_work").Value = getDateTime(vmrDetails(VslInfo.start_work))
            .Fields("frstcnt_dsc").Value = getDateTime(vmrDetails(VslInfo.frstcnt_dsc))
            .Fields("lstcnt_dsc").Value = getDateTime(vmrDetails(VslInfo.lstcnt_dsc))
            .Fields("frstcnt_load").Value = getDateTime(vmrDetails(VslInfo.frstcnt_load))
            .Fields("lstcnt_load").Value = getDateTime(vmrDetails(VslInfo.lstcnt_load))
            .Fields("end_work").Value = getDateTime(vmrDetails(VslInfo.end_work))
            .Fields("oncall_sv_dv").Value = vmrDetails(VslInfo.oncall_sv_dv)
            .Fields("regstaff").Value = vmrDetails(VslInfo.regstaff)
            .Fields("opschecker1").Value = vmrDetails(VslInfo.opschecker1)
            .Fields("opschecker2").Value = vmrDetails(VslInfo.opschecker2)
            .Fields("opsvisor1").Value = vmrDetails(VslInfo.opsvisor1)
            .Fields("opsvisor2").Value = vmrDetails(VslInfo.opsvisor2)
            .Fields("opsmngr").Value = vmrDetails(VslInfo.opscnter)
            .Fields("opscnter").Value = vmrDetails(VslInfo.opscnter)
            .Fields("createdate").Value = dteSave

            .Update()
        End With

        MsgBox("Save Successful!")
    End Sub

    Public Sub RetrieveData() Implements IReportswSave.RetrieveData
        Dim adoRecordset As ADODB.Recordset
        Dim vmrRegistry As String = vmrDetails(VslInfo.registry)
        Dim vmrQuery As String

        If Exist() Then
            vmrQuery = "SELECT *  FROM [opreports].[dbo].[reports_vmr] where registry = '" & vmrRegistry & "'"

            adoRecordset = New ADODB.Recordset
            With adoRecordset
                connOP.Open()
                .Open(vmrQuery, connOP, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic)
                For Each names As String In System.Enum.GetNames(GetType(VslInfo))
                    Dim tempValue = .Fields(names).Value
                    Try
                        vmrDetails(DirectCast(System.Enum.Parse(GetType(VslInfo), names), VslInfo)) = getMilTime(tempValue)
                    Catch ex As Exception
                        vmrDetails(DirectCast(System.Enum.Parse(GetType(VslInfo), names), VslInfo)) = tempValue
                    End Try
                Next
                connOP.Close()

            End With
        Else
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
                vmrDetails(VslInfo.ata) = getMilTime(.ATA)
                vmrDetails(VslInfo.atd) = getMilTime(.ATD)
                vmrDetails(VslInfo.start_work) = getMilTime(.StartWork)
                vmrDetails(VslInfo.lstcnt_dsc) = getMilTime(.LastContainerDischarged)
                vmrDetails(VslInfo.end_work) = getMilTime(.EndWork)
            End With
        End If
    End Sub

    Public Function getDateTime(strMDate As String) As Date
        Return Date.ParseExact(strMDate, "HHmm\H MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture)
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
