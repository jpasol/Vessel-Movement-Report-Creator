Imports ADODB
Imports Reports
Imports Reports.IReports
Imports System.Runtime.InteropServices

Public Class VMRForm
#Region "HOTKEY"
    Public Const KEY_ALT As Integer = &H1
    Public Const _HOTKEY As Integer = &H312

    Public Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As IntPtr

    <DllImport("User32.dll")>
    Public Shared Function RegisterHotKey(ByVal hwnd As IntPtr,
                        ByVal id As Integer, ByVal fsModifiers As Integer,
                        ByVal vk As Integer) As Integer
    End Function


    <DllImport("User32.dll")>
    Public Shared Function UnregisterHotKey(ByVal hwnd As IntPtr,
                        ByVal id As Integer) As Integer
    End Function

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = _HOTKEY And GetActiveWindow = Me.Handle Then
            Dim id As IntPtr = m.WParam
            Select Case (id.ToString)
                Case "1"
                    exitForm()
                Case "2"
                    PrevTab()
                Case "3"
                    NextTab()
            End Select
        End If
        MyBase.WndProc(m)
    End Sub 'System wide hotkey event handling
#End Region
    Sub New(Registry As String, ByRef N4Connection As ADODB.Connection, ByRef OPConnection As ADODB.Connection, Username As String)

        ' This call is required by the designer.
        InitializeComponent()
        clsVMR = New VMRClass(Registry, N4Connection, OPConnection, Username)
        ' Add any initialization after the InitializeComponent() call.

        dgvCMU.DataSource = clsVMR.GetvesselMovementReportData.dtCMU

        gearboxesCMU.Table = dgvCMU.DataSource
        hatchcoversCMU.Table = dgvCMU.DataSource
        containersCMU.Table = dgvCMU.DataSource

        containersCMU.RowFilter = "description not like '%GB%' and description not like '%HC%'"
        gearboxesCMU.RowFilter = "description like '%GB%'"
        hatchcoversCMU.RowFilter = "description like '%HC%'"

        dgvCMU.AutoGenerateColumns = False
        dgvGearboxes.AutoGenerateColumns = False
        dgvHatchcovers.AutoGenerateColumns = False
        dgvContainers.AutoGenerateColumns = False

        dgvGearboxes.DataSource = gearboxesCMU
        dgvHatchcovers.DataSource = hatchcoversCMU
        dgvContainers.DataSource = containersCMU

        rptVMR.SetDataSource(clsVMR.GetvesselMovementReportData)
        For Each subReport In rptVMR.Subreports
            subReport.SetDataSource(clsVMR.GetvesselMovementReportData)
        Next
        CrystalReportViewer1.ReportSource = rptVMR


        AddHandler cmdExitPart.Click, AddressOf exitForm
        AddHandler cmdExitFoot.Click, AddressOf exitForm
        AddHandler cmdExitTpt.Click, AddressOf exitForm
        AddHandler cmdExitCMU.Click, AddressOf exitForm

        AddHandler cmdPrevTpt.Click, AddressOf PrevTab
        AddHandler cmdPrevCMU.Click, AddressOf PrevTab
        AddHandler cmdPrevFoot.Click, AddressOf PrevTab

        AddHandler cmdNextPart.Click, AddressOf NextTab
        AddHandler cmdNextPart.Click, AddressOf NextTab
        AddHandler cmdNextCMU.Click, AddressOf NextTab
        AddHandler cmdNextFoot.Click, AddressOf NextTab

    End Sub
    Private gearboxesCMU As New DataView
    Private containersCMU As New DataView
    Private hatchcoversCMU As New DataView
    Private clsVMR As VMRClass
    Private rptVMR As New VMR

    Private Sub frmVMR_Load(sender As Object, e As EventArgs) Handles Me.Load
        With clsVMR
            mskVessel.Text = .Details(.VslInfo.name)
            mskVoyage.Text = .Details(.VslInfo.voy_num)
            mskPrincipal.Text = .Details(.VslInfo.owner)
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
            mskFormStart.Text = .Details(.VslInfo.formalities_start)
            mskFormEnd.Text = .Details(.VslInfo.formalities_end)
        End With

        RegisterHotKey(Me.Handle, 1, 0, Keys.F3)
        RegisterHotKey(Me.Handle, 2, 0, Keys.F10)
        RegisterHotKey(Me.Handle, 3, 0, Keys.F11)
    End Sub

    Private Sub tabVMR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabVMR.SelectedIndexChanged
        Dim tabClicked As TabPage = DirectCast(sender, TabControl).SelectedTab
        Select Case tabClicked.Name.ToString
            Case "tabPreview"
                mapDetails()
                clsVMR.Format(rptVMR)
                clsVMR.Preview(rptVMR, CrystalReportViewer1)
        End Select
    End Sub
    Private Sub mapDetails()
        With clsVMR
            .Details(.VslInfo.name) = mskVessel.Text
            .Details(.VslInfo.voy_num) = mskVoyage.Text
            .Details(.VslInfo.owner) = mskPrincipal.Text
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
            .Details(.VslInfo.formalities_start) = mskFormStart.Text
            .Details(.VslInfo.formalities_end) = mskFormEnd.Text
        End With
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If SaveReport() Then
            PrintReport()
        End If
    End Sub

    Private Sub PrintReport()
        rptVMR.PrintToPrinter(1, False, 0, 0)
    End Sub

    Private Function SaveReport() As Boolean
        Dim isSaved As Boolean = False
        With clsVMR
            With .OPConnection
                Try
                    If clsVMR.Exist Then
                        .Open()
                        .BeginTrans()
                        Dim result = MsgBox("Update?", vbYesNo)
                        If result = vbYes Then
                            clsVMR.CancelExisting()
                            clsVMR.Save()
                            .CommitTrans()
                            MsgBox("Save Successful!")
                            isSaved = True
                        Else
                            .RollbackTrans()
                        End If
                    Else
                        .Open()
                        .BeginTrans()
                        Dim result = MsgBox("Save?", vbYesNo)
                        If result = vbYes Then
                            clsVMR.Save()
                            .CommitTrans()
                            MsgBox("Save Successful!")
                            isSaved = True
                        Else
                            .RollbackTrans()
                        End If
                    End If
                Catch ex As Exception
                    MsgBox("Rolling Back Changes")
                    .RollbackTrans()
                End Try
                .Close()
            End With
        End With
        Return isSaved
    End Function

    Private Sub mskBoxes_KeyDown(sender As Object, e As KeyEventArgs) Handles mskBoxes.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim line = mskOwner.Text
            Dim movekind = cmbMoveKinds.Text
            Dim description = $"{mskBoxes.Text}X{cmbSizes.Text}' {cmbUnits.Text} {cmbFreight.Text}"

            clsVMR.GetvesselMovementReportData.dtCMU.AdddtCMURow(line, movekind, description)
        End If
    End Sub


    Private Sub mskGearbox_KeyDown(sender As Object, e As KeyEventArgs) Handles mskGearbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim line = mskCharge2.Text
            Dim description = $"{mskGearbox.Text}X{cmbSizesGB.Text}' GB AT BAY {mskBayGB.Text}"

            clsVMR.GetvesselMovementReportData.dtCMU.AdddtCMURow(line, "SVD", description)
        End If
    End Sub

    Private Sub mskHatchcovers_KeyDown(sender As Object, e As KeyEventArgs) Handles mskHatchcovers.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim line = mskCharge3.Text
            Dim description = $"{mskHatchcovers.Text} HC AT BAY {mskBayHC.Text}"

            clsVMR.GetvesselMovementReportData.dtCMU.AdddtCMURow(line, "LIFTED", description)
        End If
    End Sub

    Private Sub exitForm()
        Me.Dispose()
    End Sub

    Private Sub NextTab()
        If tabVMR.SelectedIndex < tabVMR.TabCount - 1 Then
            tabVMR.SelectedIndex += 1
        End If
    End Sub

    Private Sub PrevTab()
        If tabVMR.SelectedIndex > 0 Then
            tabVMR.SelectedIndex -= 1
        End If
    End Sub

    Private Sub VMRForm_HandleDestroyed(sender As Object, e As EventArgs) Handles Me.HandleDestroyed
        UnregisterHotKey(Me.Handle, 1)
        UnregisterHotKey(Me.Handle, 2)
        UnregisterHotKey(Me.Handle, 3)
    End Sub

End Class
