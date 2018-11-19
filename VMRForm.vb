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
                clsVMR.Format(rptVMR)
                clsVMR.Preview(rptVMR, CrystalReportViewer1)
        End Select
    End Sub
End Class
