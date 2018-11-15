Imports ADODB
Imports Reports
Imports CrystalDecisions.CrystalReports

Public Class VMRClass
    Inherits Vessel
    Implements IReports.IReportswSave

    Sub New(Registry As String, ByRef N4Connection As Connection, ByRef OPConnection As Connection)
        MyBase.New(Registry, N4Connection)
        strRegistry = Registry
        connN4 = N4Connection
        connOP = OPConnection
    End Sub
    Public vmrVessel As Vessel
    Public strRegistry As String
    Private connN4 As Connection
    Private connOP As Connection
    Private ibUnits(3, 5, 2) As Long
    Private obUnits(3, 5, 2) As Long
    Private dtVessel As dsThroughput.dtVesselDataTable
    Private dtCMU As dsThroughput.dtCMUDataTable
    Private dtDG As dsThroughput.dtDGDataTable
    Private vmrDetails(System.Enum.GetNames(GetType(VslInfo)).Length) As String
    Enum ContrTyp
        Dry
        Reefer
        FRack
        Tank
        Open
    End Enum
    Enum ContrSze
        Twenty
        Forty
        Fortyfive
    End Enum
    Enum VslInfo
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
    Public Property VMRName As String
        Get
            VMRName = MyBase.Name
        End Get
        Set(value As String)
            vmrDetails(VslInfo.Name) = value
        End Set
    End Property
    Public Property VMROwner As String
        Get
            VMRName = MyBase.Name
        End Get
        Set(value As String)
            vmrDetails(VslInfo.Name) = value
        End Set
    End Property
    Public Property VMRVoyage As String
        Get
            VMRName = MyBase.Name
        End Get
        Set(value As String)
            vmrDetails(VslInfo.Name) = value
        End Set
    End Property
    Public Property VMRRegistry As String
        Get
            VMRName = MyBase.Name
        End Get
        Set(value As String)
            vmrDetails(VslInfo.Name) = value
        End Set
    End Property
    Public Property VMRBerth As String
        Get
            VMRName = MyBase.Name
        End Get
        Set(value As String)
            vmrDetails(VslInfo.Name) = value
        End Set
    End Property
    Public Property VMRGangRequest As String
        Get
            VMRName = MyBase.Name
        End Get
        Set(value As String)
            vmrDetails(VslInfo.Name) = value
        End Set
    End Property
    Public Property VMROvertime As String
        Get
            VmrName = MyBase.Name
        End Get
        Set(value As String)
            vmrDetails(VslInfo.Name) = value
        End Set
    End Property
    Public Property VMREta As String
        Get
            VMRName = MyBase.Name
        End Get
        Set(value As String)
            vmrDetails(VslInfo.Name) = value
        End Set
    End Property
    Public Property VMRAta As String
        Get
            VMRName = MyBase.Name
        End Get
        Set(value As String)
            vmrDetails(VslInfo.Name) = value
        End Set
    End Property
    Public Property VMRAtd As String
        Get
            VMRName = MyBase.Name
        End Get
        Set(value As String)
            vmrDetails(VslInfo.Name) = value
        End Set
    End Property
    Public Property VMRStartwork As String
        Get
            VMRName = MyBase.Name
        End Get
        Set(value As String)
            vmrDetails(VslInfo.Name) = value
        End Set
    End Property
    Public Property VMRFdsc As String
        Get
            VMRName = MyBase.Name
        End Get
        Set(value As String)
            vmrDetails(VslInfo.Name) = value
        End Set
    End Property
    Public Property VMRLdsc As String
        Get
            VMRName = MyBase.Name
        End Get
        Set(value As String)
            vmrDetails(VslInfo.Name) = value
        End Set
    End Property
    Public Property VMRFload As String
        Get
            VMRName = MyBase.Name
        End Get
        Set(value As String)
            vmrDetails(VslInfo.Name) = value
        End Set
    End Property
    Public Property VMRLLoad As String
        Get
            VMRName = MyBase.Name
        End Get
        Set(value As String)
            vmrDetails(VslInfo.Name) = value
        End Set
    End Property
    Public Property VMREndDate As String
        Get
            VMRName = MyBase.Name
        End Get
        Set(value As String)
            vmrDetails(VslInfo.Name) = value
        End Set
    End Property
    Public Property VMREndTime As String
        Get
            VMRName = MyBase.Name
        End Get
        Set(value As String)
            vmrDetails(VslInfo.Name) = value
        End Set
    End Property
    Public Property VMRGangs As String
        Get
            VMRName = MyBase.Name
        End Get
        Set(value As String)
            vmrDetails(VslInfo.Name) = value
        End Set
    End Property
    Public Property VMRRegulars As String
        Get
            VMRName = MyBase.Name
        End Get
        Set(value As String)
            vmrDetails(VslInfo.Name) = value
        End Set
    End Property
    Public Property VMRChecker As String
        Get
            VMRName = MyBase.Name
        End Get
        Set(value As String)
            vmrDetails(VslInfo.Name) = value
        End Set
    End Property
    Public Property VMRSupervisor As String
        Get
            VMRName = MyBase.Name
        End Get
        Set(value As String)
            vmrDetails(VslInfo.Name) = value
        End Set
    End Property
    Public Property VMRManager As String
        Get
            VMRName = MyBase.Name
        End Get
        Set(value As String)
            vmrDetails(VslInfo.Name) = value
        End Set
    End Property
    Public Property VMRCenter As String
        Get
            VMRName = MyBase.Name
        End Get
        Set(value As String)
            vmrDetails(VslInfo.Name) = value
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

    Public Sub Format(ReportData() As Object, crReport As Object) Implements IReportswSave.Format
        Dim tempRow As DataRow
#Region "Create Vessel Details"
        tempRow = dtVessel.NewRow
        With tempRow



        End With
#End Region

    End Sub

    Public Sub Preview(crReport As Object, crViewer As Object) Implements IReportswSave.Preview
        'preview report here
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
