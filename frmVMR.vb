Imports ADODB
Imports Reports
Imports Reports.IReports

Public Class frmVMR
    Implements Reports.IReports.IReportswSave

    Sub New(paramID As String, ByRef paramN4 As ADODB.Connection, ByRef paramDB As ADODB.Connection)

        ' This call is required by the designer.
        InitializeComponent()
        CnnN4 = paramN4
        CnnDB = paramDB
        paramReg = paramID
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public strRegistry As String
    Private connN4 As ADODB.Connection
    Private connDB As ADODB.Connection
    Private VMRDetails As DataSet

    Enum ctrTypes
        LD
        MT
        SSV
        NSV
    End Enum
    Enum N4Details
        Vessel
        Inbound
        Outbound
    End Enum
    Enum VesselInfo
        VesselName
        IBVoyage
        OBVoyage
        RegistryNum
        Berth
        ATA
        ATD
        WorkStart
        WorkEnd
        LastContrDisch
    End Enum

    Public Property CnnN4 As Connection Implements IReportswSave.CnnN4
        Get
            CnnN4 = connN4
        End Get
        Set(value As Connection)
            connN4 = value
        End Set
    End Property

    Public Property CnnDB As Connection Implements IReportswSave.CnnDB
        Get
            CnnDB = connDB
        End Get
        Set(value As Connection)
            connDB = value
        End Set
    End Property

    Public Property paramReg As String Implements IReportswSave.Parameter
        Get
            paramReg = strRegistry
        End Get
        Set(value As String)
            strRegistry = value
        End Set
    End Property

    Public Property dsRpt As DataSet Implements IReportswSave.dsRpt
        Get
            dsRpt = VMRDetails
        End Get
        Set(value As DataSet)
            VMRDetails = dsRpt
        End Set
    End Property

    Shared Function FindReports(paramID As String) As Boolean
        'Find reports in op

    End Function

    Private Sub frmVMR_Load(sender As Object, e As EventArgs) Handles Me.Load
        Initialize()
        If FindReports(strRegistry) = True Then
            dsRpt = RetrieveOPData(strRegistry)
        Else
            dsRpt = RetrieveN4Data(strRegistry)
        End If
    End Sub

    Public Function RetrieveN4Data(Parameter As Object) As DataSet Implements IReportswSave.RetrieveN4Data
        Dim strN4Details(2) As String
        Dim datAdapt As New OleDb.OleDbDataAdapter
        Dim rsVMRDetails As New ADODB.Recordset
        Dim dsN4Details As New DataSet
        Dim vslDetails As New DataTable
        Dim ibTable As New DataTable
        Dim obTable As New DataTable
#Region "Retrieve from N4"
        dsN4Details.Tables.Add(vslDetails)
        dsN4Details.Tables.Add(ibTable)
        dsN4Details.Tables.Add(obTable)

        ' Get Vessel Details
        strN4Details(N4Details.Vessel) = "select 'MV '+ vsl.name as 'Vessel Name'
,ib_vyg 'I/B Voyage Number' 
,ob_vyg 'O/B Voyage Number'
,flex_string01 as 'Registry Number'
,flex_string02 as 'Pier Berth (NCT)'
,ata as 'Actual Time of Arrival (ATA)'
,atd as 'Actual Time of Departure (ATD)'
,[start_work] as 'Time Operation Commenced'
,[end_work] as 'Time of Completion'
,[time_discharge_complete] as 'Time of Last Contr. Discharged'


 FROM [apex].[dbo].[vsl_vessel_visit_details] vvd
inner join 
[vsl_vessels] vsl
on vsl.gkey = vvd.vessel_gkey 
inner join
[argo_carrier_visit] acv
on cvcvd_gkey = vvd_gkey
inner join
[argo_visit_details] avd
on cvcvd_gkey = avd.gkey


where acv.id = '" & Parameter & "'"

        'Get I/B Containers
        strN4Details(N4Details.Inbound) = "SELECT unit.[gkey] 
,unit.[id]
,[category]
,[freight_kind]
,acv.[id] as 'Actual I/B'
,acv2.[id] as 'Actual O/B'
,rpt.id 
,BIZU.[ID]

FROM [apex].[dbo].[inv_unit] unit 
full outer join 
[inv_unit_fcy_visit] ufv 
on unit.gkey = unit_gkey
full outer join 
[argo_carrier_visit] acv
on [actual_ib_cv] = acv.gkey
full outer join
[argo_carrier_visit] acv2
on [actual_ob_cv] = acv2.gkey
full outer join
[ref_routing_point] rpt
on pod1_gkey = rpt.gkey
INNER JOIN
[REF_BIZUNIT_SCOPED] BIZU
ON LINE_OP = BIZU.GKEY


where acv.[id] = '" & Parameter & "' and rpt.id = 'SFS' "

        'Get O/B Containers
        strN4Details(N4Details.Outbound) = "SELECT unit.[gkey] 
	  ,unit.[id]
      ,[category]
      ,[freight_kind]
      ,acv.[id] as 'Actual I/B'
      ,acv2.[id] as 'Actual O/B'
      ,rpt.id
,BIZU.[ID]
  FROM [apex].[dbo].[inv_unit] unit 
full outer join 
[inv_unit_fcy_visit] ufv 
on unit.gkey = unit_gkey
full outer join 
[argo_carrier_visit] acv
on [actual_ib_cv] = acv.gkey
full outer join
[argo_carrier_visit] acv2
on [actual_ob_cv] = acv2.gkey
full outer join
[ref_routing_point] rpt
on pod1_gkey = rpt.gkey
INNER JOIN
[REF_BIZUNIT_SCOPED] BIZU
ON LINE_OP = BIZU.GKEY


where acv2.[id] = '" & Parameter & "' AND CATEGORY <> 'THRGH'"

        For count As Integer = 0 To 2
            rsVMRDetails.Open(strN4Details(count), CnnN4)
            datAdapt.Fill(dsN4Details.Tables(count), rsVMRDetails)
            rsVMRDetails.Close()
        Next
#End Region
#Region "Populate Controls"
        With dsN4Details.Tables(N4Details.Vessel)
            mskVessel.Text = .Rows(0)(VesselInfo.VesselName)
            If .Rows(0)(VesselInfo.IBVoyage) = .Rows(0)(VesselInfo.OBVoyage) Then
                mskVoyage.Text = .Rows(0)(VesselInfo.IBVoyage)
            Else
                mskVoyage.Text = .Rows(0)(VesselInfo.IBVoyage) & " - " & .Rows(0)(VesselInfo.OBVoyage)
            End If
            mskRegistry.Text = .Rows(0)(VesselInfo.RegistryNum)
            mskPier.Text = .Rows(0)(VesselInfo.Berth)
            mskATA.Text = getMilTime(.Rows(0)(VesselInfo.ATA))
            mskATD.Text = getMilTime(.Rows(0)(VesselInfo.ATD))
            mskLastDischarged.Text = getMilTime(.Rows(0)(VesselInfo.LastContrDisch))
        End With


#End Region
    End Function
    Private Function getMilTime(strLDate As String) As String
        Dim dteDate As DateTime

        dteDate = Convert.ToDateTime(strLDate)
        getMilTime = dteDate.ToString("HHmm\H MM/dd/yyyy")
    End Function

    Public Function CalculateInfo(RetrievedData As Object) As Object() Implements IReportswSave.CalculateInfo
        Dim arrIB(3) As Double
        Dim arrOB(3) As Double
        'Calculate as needed
        arrIB = countUnits(dsRpt.Tables(N4Details.Inbound))
        arrOB = countUnits(dsRpt.Tables(N4Details.Outbound))
    End Function

    Private Function countUnits(paramData As DataTable) As Double()
        'Count Untis
        Dim arrUnits As Double()
        ReDim arrUnits(paramData.Columns.Count)
        For Each dc As DataColumn In paramData.Columns

        Next
    End Function

    Public Sub Format(ReportData() As Object, crReport As Object) Implements IReportswSave.Format
        Throw New NotImplementedException()
    End Sub

    Public Sub Preview(crReport As Object, crViewer As Object) Implements IReportswSave.Preview
        Throw New NotImplementedException()
    End Sub

    Public Sub Save(ReportData() As Object) Implements IReportswSave.Save
        Throw New NotImplementedException()
    End Sub

    Private Sub Initialize() Implements IReportswSave.Initialize
        'Throw New NotImplementedException()
    End Sub

    Public Function RetrieveOPData(Parameter As Object) As DataSet Implements IReportswSave.RetrieveOPData
        Throw New NotImplementedException()
    End Function
End Class
