Imports ADODB
Imports Reports
Imports CrystalDecisions.CrystalReports

Public Class VMRClass

    Implements IReports.IReportswSave

    Sub New(Registry As String, ByRef N4Connection As Connection, ByRef OPConnection As Connection)
        vmrVessel = New Vessel(Registry, N4Connection)
        With vmrVessel
            vmrDetails(VslInfo.Name) = vmrVessel.Name
            If .InboundVoyage = .OutboundVoyage Then
                vmrDetails(VslInfo.Voyage) = .InboundVoyage
            Else
                vmrDetails(VslInfo.Voyage) = .InboundVoyage & " - " & .OutboundVoyage
            End If
            vmrDetails(VslInfo.Registry) = .Registry
            vmrDetails(VslInfo.Berth) = .BerthWindow
            vmrDetails(VslInfo.ATA) = getMilTime(.ATA)
            vmrDetails(VslInfo.ATD) = getMilTime(.ATD)
            vmrDetails(VslInfo.StartWork) = getMilTime(.StartWork)
            vmrDetails(VslInfo.LastDsc) = getMilTime(.LastContainerDischarged)
            vmrDetails(VslInfo.EndWorkTime) = getMilTime(.EndWork).ToString.Substring(0, 5) 'HHmmH 
            vmrDetails(VslInfo.EndWorkDate) = getMilTime(.EndWork).ToString.Substring(6, 10) 'MM/dd/YYYY
        End With

        connN4 = N4Connection
        connOP = OPConnection
    End Sub
    Public vmrVessel As Vessel
    Private vmrDetails(System.Enum.GetNames(GetType(VslInfo)).Length - 1) As String
    Private connN4 As Connection
    Private connOP As Connection
    Private crVMR As Engine.ReportClass
    Private dsVMR As dsThroughput
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
        Name
        Owner
        Voyage
        Registry
        Berth
        GangRequest
        Overtime
        ETA
        ATA
        ATD
        StartWork
        FirstDsc
        LastDsc
        FirstLoad
        LastLoad
        EndWorkDate
        EndWorkTime
        Gangs
        RegStaff
        Checker
        OPSvisor
        OPSmngr
        OPScnter
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
            OPConnection = connN4
        End Get
    End Property

    Public Sub CalculateInfo() Implements IReportswSave.CalculateInfo

    End Sub

    Public Sub Format(ByRef crReport As Engine.ReportClass) Implements IReportswSave.Format
        Dim tempRow As DataRow
        Dim Lines() As String
        Dim paramLine As New CrystalDecisions.Shared.ParameterDiscreteValue
        dsVMR = New dsThroughput

#Region "Create Vessel Details"
        tempRow = dsVMR.Tables("dtVessel").NewRow
        tempRow.ItemArray = vmrDetails
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
        For Each lin As String In line
            For Each freight In System.Enum.GetNames(GetType(FreightKind))
                addContainers(lin, freight, dtUnits, dsVMR.Tables(dtString & freight))
            Next
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
    Public Sub Preview(ByRef crReport As CrystalDecisions.CrystalReports.Engine.ReportClass, crViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer) Implements IReportswSave.Preview
        crViewer.ReportSource = crReport
    End Sub

    Public Sub Save(ReportData() As Object) Implements IReportswSave.Save
        'save data here
    End Sub

    Public Sub RetrieveData(Parameter As Object) Implements IReportswSave.RetrieveData
        'retrieve data here
    End Sub

    Public Overridable Function getMilTime(strLDate As String) As String
        Dim dteDate As DateTime

        dteDate = Convert.ToDateTime(strLDate)
        getMilTime = dteDate.ToString("HHmm\H MM/dd/yyyy")
    End Function
End Class
