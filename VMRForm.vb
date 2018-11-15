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
    Private Sub frmVMR_Load(sender As Object, e As EventArgs) Handles Me.Load
        With clsVMR.vmrVessel
            mskVessel.Text = clsVMR.vmrVessel.Name
            If .InboundVoyage = .OutboundVoyage Then
                mskVoyage.Text = .InboundVoyage
            Else
                mskVoyage.Text = .OutboundVoyage
            End If
            mskRegistry.Text = .Registry
            mskPier.Text = .BerthWindow
            mskATA.Text = clsVMR.getMilTime(.ATA)
            mskATD.Text = clsVMR.getMilTime(.ATD)
            mskOpCommenced.Text = clsVMR.getMilTime(.StartWork)
            mskLastDischarged.Text = clsVMR.getMilTime(.LastContainerDischarged)
            mskTimeComplete.Text = clsVMR.getMilTime(.EndWork).ToString.Substring(0, 5) 'HHmmH 
            mskDateComplete.Text = clsVMR.getMilTime(.EndWork).ToString.Substring(6, 10) 'MM/dd/YYYY
        End With
    End Sub
End Class
