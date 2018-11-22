Imports ADODB
Imports Reports
Imports Reports.IReports

Public Class VMRForm

    Sub New(Registry As String, ByRef N4Connection As ADODB.Connection, ByRef OPConnection As ADODB.Connection)

        ' This call is required by the designer.
        InitializeComponent()
        clsVMR = New VMRClass(Registry, N4Connection, OPConnection)
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private clsVMR As VMRClass
    Private rptVMR As VMR
    Private Sub frmVMR_Load(sender As Object, e As EventArgs) Handles Me.Load

        With clsVMR
            mskVessel.Text = .Details(.VslInfo.Name)
            mskVoyage.Text = .Details(.VslInfo.Voyage)
            mskRegistry.Text = .Details(.VslInfo.Registry)
            mskPier.Text = .Details(.VslInfo.Berth)
            mskATA.Text = .Details(.VslInfo.ATA)
            mskATD.Text = .Details(.VslInfo.ATD)
            mskOpCommenced.Text = .Details(.VslInfo.StartWork)
            mskLastDischarged.Text = .Details(.VslInfo.LastDsc)
            mskTimeComplete.Text = .Details(.VslInfo.EndWorkTime) 'HHmmH 
            mskDateComplete.Text = .Details(.VslInfo.EndWorkDate) 'MM/dd/YYYY
        End With

    End Sub

    Private Sub tabVMR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabVMR.SelectedIndexChanged
        Dim tabClicked As TabPage = DirectCast(sender, TabControl).SelectedTab
        Select Case tabClicked.Name.ToString
            Case "tabPreview"
                rptVMR = New VMR
                mapDetails()
                clsVMR.Format(rptVMR)
                clsVMR.Preview(rptVMR, CrystalReportViewer1)
        End Select
    End Sub
    Private Sub mapDetails()
        With clsVMR
            .Details(.VslInfo.Name) = mskVessel.Text
            .Details(.VslInfo.Voyage) = mskVoyage.Text
            .Details(.VslInfo.Registry) = mskRegistry.Text
            .Details(.VslInfo.Berth) = mskPier.Text
            .Details(.VslInfo.ATA) = mskATA.Text
            .Details(.VslInfo.ATD) = mskATD.Text
            .Details(.VslInfo.StartWork) = mskOpCommenced.Text
            .Details(.VslInfo.LastDsc) = mskLastDischarged.Text
            .Details(.VslInfo.EndWorkTime) = mskTimeComplete.Text 'HHmmH
            .Details(.VslInfo.EndWorkDate) = mskDateComplete.Text 'MM/dd/YYYY
            .Details(.VslInfo.GangRequest) = mskSLGang.Text
            .Details(.VslInfo.Overtime) = mskOvertime.Text
            .Details(.VslInfo.ETA) = mskETA.Text
            .Details(.VslInfo.FirstDsc) = mskFirstDischarged.Text
            .Details(.VslInfo.LastDsc) = mskLastDischarged.Text
            .Details(.VslInfo.FirstLoad) = mskFirstLoaded.Text
            .Details(.VslInfo.LastLoad) = mskLastLoaded.Text
            .Details(.VslInfo.RegStaff) = mskOnCallSV.Text
            .Details(.VslInfo.Gangs) = mskRegulars.Text
            .Details(.VslInfo.Checker) = mskChecker.Text
            .Details(.VslInfo.OPSvisor) = mskSupervisor.Text
            .Details(.VslInfo.OPSmngr) = mskAsstOP.Text
            .Details(.VslInfo.OPScnter) = mskOPCenter.Text
        End With
    End Sub

End Class
