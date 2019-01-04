Imports ADODB
Imports Reports
Imports Reports.IReports

Public Class VMRForm

    Sub New(Registry As String, ByRef N4Connection As ADODB.Connection, ByRef OPConnection As ADODB.Connection, Username As String)

        ' This call is required by the designer.
        InitializeComponent()
        clsVMR = New VMRClass(Registry, N4Connection, OPConnection, Username)
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private clsVMR As VMRClass
    Private rptVMR As VMR
    Private Sub frmVMR_Load(sender As Object, e As EventArgs) Handles Me.Load
        With clsVMR

            MsgBox(.Exist())

        End With

        With clsVMR
            mskVessel.Text = .Details(.VslInfo.name)
            mskVoyage.Text = .Details(.VslInfo.voy_num)
            mskRegistry.Text = .Details(.VslInfo.registry)
            mskPier.Text = .Details(.VslInfo.berth)
            mskATA.Text = .Details(.VslInfo.ata)
            mskATD.Text = .Details(.VslInfo.atd)
            mskOpCommenced.Text = .Details(.VslInfo.start_work)
            mskLastDischarged.Text = .Details(.VslInfo.lstcnt_dsc)
            mskTimeComplete.Text = .Details(.VslInfo.end_work).Substring(0, 5) 'HHmmH 
            mskDateComplete.Text = .Details(.VslInfo.end_work).Substring(6, 10) 'MM/dd/YYYY
            mskSLGang.Text = .Details(.VslInfo.SLGang)
            mskOvertime.Text = .Details(.VslInfo.ovt_req)
            mskETA.Text = .Details(.VslInfo.eta)
            mskFirstDischarged.Text = .Details(.VslInfo.frstcnt_dsc)
            mskFirstLoaded.Text = .Details(.VslInfo.frstcnt_load)
            mskLastLoaded.Text = .Details(.VslInfo.lstcnt_load)
            mskRegulars.Text = .Details(.VslInfo.regstaff)
            mskOnCallSV.Text = .Details(.VslInfo.oncall_sv_dv)
            mskChecker1.Text = .Details(.VslInfo.opschecker1)
            mskChecker2.Text = .Details(.VslInfo.opschecker2)
            mskVisor1.Text = .Details(.VslInfo.opsvisor1)
            mskVisor2.Text = .Details(.VslInfo.opsvisor2)
            mskAsstOP.Text = .Details(.VslInfo.opscnter)
            mskOPCenter.Text = .Details(.VslInfo.opscnter)
            mskStandby.Text = .Details(.VslInfo.standby)
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
            .Details(.VslInfo.name) = mskVessel.Text
            .Details(.VslInfo.voy_num) = mskVoyage.Text
            .Details(.VslInfo.registry) = mskRegistry.Text
            .Details(.VslInfo.berth) = mskPier.Text
            .Details(.VslInfo.ata) = mskATA.Text
            .Details(.VslInfo.atd) = mskATD.Text
            .Details(.VslInfo.start_work) = mskOpCommenced.Text
            .Details(.VslInfo.end_work) = mskTimeComplete.Text & " " & mskDateComplete.Text 'HHmmH
            .Details(.VslInfo.SLGang) = mskSLGang.Text
            .Details(.VslInfo.ovt_req) = mskOvertime.Text
            .Details(.VslInfo.eta) = mskETA.Text
            .Details(.VslInfo.frstcnt_dsc) = mskFirstDischarged.Text
            .Details(.VslInfo.lstcnt_dsc) = mskLastDischarged.Text
            .Details(.VslInfo.frstcnt_load) = mskFirstLoaded.Text
            .Details(.VslInfo.lstcnt_load) = mskLastLoaded.Text
            .Details(.VslInfo.regstaff) = mskRegulars.Text
            .Details(.VslInfo.oncall_sv_dv) = mskOnCallSV.Text
            .Details(.VslInfo.opschecker1) = mskChecker1.Text
            .Details(.VslInfo.opschecker2) = mskChecker2.Text
            .Details(.VslInfo.opsvisor1) = mskVisor1.Text
            .Details(.VslInfo.opsvisor2) = mskVisor2.Text
            .Details(.VslInfo.opscnter) = mskAsstOP.Text
            .Details(.VslInfo.opscnter) = mskOPCenter.Text
            .Details(.VslInfo.standby) = mskStandby.Text
        End With
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        With clsVMR.OPConnection
            .Open()
            .BeginTrans()
            Try
                clsVMR.Save()
                .CommitTrans()
                .Close()
            Catch
                MsgBox("Save Unsuccessful")
                .RollbackTrans()
                .Close()
            End Try
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub mskBoxes_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mskBoxes.MaskInputRejected

    End Sub
End Class
