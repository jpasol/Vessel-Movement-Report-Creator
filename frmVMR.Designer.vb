<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVMR
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tabVMR = New System.Windows.Forms.TabControl()
        Me.tabParticulars = New System.Windows.Forms.TabPage()
        Me.mskLastLoaded = New System.Windows.Forms.MaskedTextBox()
        Me.lblLastLoaded = New System.Windows.Forms.Label()
        Me.mskFirstLoaded = New System.Windows.Forms.MaskedTextBox()
        Me.lblFirstLoaded = New System.Windows.Forms.Label()
        Me.mskLastDischarged = New System.Windows.Forms.MaskedTextBox()
        Me.lblLastDischarged = New System.Windows.Forms.Label()
        Me.mskFirstDischarged = New System.Windows.Forms.MaskedTextBox()
        Me.lblFirstDischarged = New System.Windows.Forms.Label()
        Me.mskOpCommenced = New System.Windows.Forms.MaskedTextBox()
        Me.lblOpCommenced = New System.Windows.Forms.Label()
        Me.mskATA = New System.Windows.Forms.MaskedTextBox()
        Me.lblATA = New System.Windows.Forms.Label()
        Me.mskETA = New System.Windows.Forms.MaskedTextBox()
        Me.lblETA = New System.Windows.Forms.Label()
        Me.mskOvertime = New System.Windows.Forms.MaskedTextBox()
        Me.mskSLGang = New System.Windows.Forms.MaskedTextBox()
        Me.mskPier = New System.Windows.Forms.MaskedTextBox()
        Me.mskRegistry = New System.Windows.Forms.MaskedTextBox()
        Me.mskVoyage = New System.Windows.Forms.MaskedTextBox()
        Me.mskVessel = New System.Windows.Forms.MaskedTextBox()
        Me.lblOvertime = New System.Windows.Forms.Label()
        Me.lblSLGang = New System.Windows.Forms.Label()
        Me.lblPier = New System.Windows.Forms.Label()
        Me.lblRegistry = New System.Windows.Forms.Label()
        Me.lblVoyage = New System.Windows.Forms.Label()
        Me.lblVessel = New System.Windows.Forms.Label()
        Me.cmdNextPart = New System.Windows.Forms.Button()
        Me.cmdExitPart = New System.Windows.Forms.Button()
        Me.tabThroughput = New System.Windows.Forms.TabPage()
        Me.mskActualDeparture = New System.Windows.Forms.MaskedTextBox()
        Me.lblActualDeparture = New System.Windows.Forms.Label()
        Me.mskRegulars = New System.Windows.Forms.MaskedTextBox()
        Me.lblRegulars = New System.Windows.Forms.Label()
        Me.mskOnCallSV = New System.Windows.Forms.MaskedTextBox()
        Me.lblOnCallSV = New System.Windows.Forms.Label()
        Me.mskTimeComplete = New System.Windows.Forms.MaskedTextBox()
        Me.lblTimeComplete = New System.Windows.Forms.Label()
        Me.mskDateComplete = New System.Windows.Forms.MaskedTextBox()
        Me.lblDateComplete = New System.Windows.Forms.Label()
        Me.mskGrandTot = New System.Windows.Forms.MaskedTextBox()
        Me.lblGrandTot = New System.Windows.Forms.Label()
        Me.mskTEUs = New System.Windows.Forms.MaskedTextBox()
        Me.lblTEUs = New System.Windows.Forms.Label()
        Me.crThroughput = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.cmdNextTpt = New System.Windows.Forms.Button()
        Me.cmdPrevTpt = New System.Windows.Forms.Button()
        Me.cmdExitTpt = New System.Windows.Forms.Button()
        Me.tabSpecials = New System.Windows.Forms.TabPage()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.spltSpecials = New System.Windows.Forms.SplitContainer()
        Me.lblContainers = New System.Windows.Forms.Label()
        Me.lblGearboxes = New System.Windows.Forms.Label()
        Me.mskContainers = New System.Windows.Forms.MaskedTextBox()
        Me.mskLifted = New System.Windows.Forms.MaskedTextBox()
        Me.lblLifted = New System.Windows.Forms.Label()
        Me.mskGearboxes = New System.Windows.Forms.MaskedTextBox()
        Me.lblSVD = New System.Windows.Forms.Label()
        Me.mskFormalities = New System.Windows.Forms.MaskedTextBox()
        Me.lblFormalities = New System.Windows.Forms.Label()
        Me.mskStandby = New System.Windows.Forms.MaskedTextBox()
        Me.lblStandby = New System.Windows.Forms.Label()
        Me.crDanger = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.cmdNextSpl = New System.Windows.Forms.Button()
        Me.cmdPrevSpl = New System.Windows.Forms.Button()
        Me.cmdExitSpl = New System.Windows.Forms.Button()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.lblManner = New System.Windows.Forms.Label()
        Me.mskOPCenter = New System.Windows.Forms.MaskedTextBox()
        Me.mskManner = New System.Windows.Forms.MaskedTextBox()
        Me.lblOPCenter = New System.Windows.Forms.Label()
        Me.mskAsstOP = New System.Windows.Forms.MaskedTextBox()
        Me.lblAsstOP = New System.Windows.Forms.Label()
        Me.mskSupervisor = New System.Windows.Forms.MaskedTextBox()
        Me.lblSupervisor = New System.Windows.Forms.Label()
        Me.mskChecker = New System.Windows.Forms.MaskedTextBox()
        Me.lblChecker = New System.Windows.Forms.Label()
        Me.cmdNextFoot = New System.Windows.Forms.Button()
        Me.cmdPrevFoot = New System.Windows.Forms.Button()
        Me.cmdExitFoot = New System.Windows.Forms.Button()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.crPreview = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.tabVMR.SuspendLayout()
        Me.tabParticulars.SuspendLayout()
        Me.tabThroughput.SuspendLayout()
        Me.tabSpecials.SuspendLayout()
        CType(Me.spltSpecials, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spltSpecials.Panel1.SuspendLayout()
        Me.spltSpecials.Panel2.SuspendLayout()
        Me.spltSpecials.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabVMR
        '
        Me.tabVMR.Controls.Add(Me.tabParticulars)
        Me.tabVMR.Controls.Add(Me.tabThroughput)
        Me.tabVMR.Controls.Add(Me.tabSpecials)
        Me.tabVMR.Controls.Add(Me.TabPage5)
        Me.tabVMR.Controls.Add(Me.TabPage6)
        Me.tabVMR.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.tabVMR.Location = New System.Drawing.Point(12, 12)
        Me.tabVMR.Name = "tabVMR"
        Me.tabVMR.SelectedIndex = 0
        Me.tabVMR.Size = New System.Drawing.Size(1326, 705)
        Me.tabVMR.TabIndex = 0
        '
        'tabParticulars
        '
        Me.tabParticulars.Controls.Add(Me.mskLastLoaded)
        Me.tabParticulars.Controls.Add(Me.lblLastLoaded)
        Me.tabParticulars.Controls.Add(Me.mskFirstLoaded)
        Me.tabParticulars.Controls.Add(Me.lblFirstLoaded)
        Me.tabParticulars.Controls.Add(Me.mskLastDischarged)
        Me.tabParticulars.Controls.Add(Me.lblLastDischarged)
        Me.tabParticulars.Controls.Add(Me.mskFirstDischarged)
        Me.tabParticulars.Controls.Add(Me.lblFirstDischarged)
        Me.tabParticulars.Controls.Add(Me.mskOpCommenced)
        Me.tabParticulars.Controls.Add(Me.lblOpCommenced)
        Me.tabParticulars.Controls.Add(Me.mskATA)
        Me.tabParticulars.Controls.Add(Me.lblATA)
        Me.tabParticulars.Controls.Add(Me.mskETA)
        Me.tabParticulars.Controls.Add(Me.lblETA)
        Me.tabParticulars.Controls.Add(Me.mskOvertime)
        Me.tabParticulars.Controls.Add(Me.mskSLGang)
        Me.tabParticulars.Controls.Add(Me.mskPier)
        Me.tabParticulars.Controls.Add(Me.mskRegistry)
        Me.tabParticulars.Controls.Add(Me.mskVoyage)
        Me.tabParticulars.Controls.Add(Me.mskVessel)
        Me.tabParticulars.Controls.Add(Me.lblOvertime)
        Me.tabParticulars.Controls.Add(Me.lblSLGang)
        Me.tabParticulars.Controls.Add(Me.lblPier)
        Me.tabParticulars.Controls.Add(Me.lblRegistry)
        Me.tabParticulars.Controls.Add(Me.lblVoyage)
        Me.tabParticulars.Controls.Add(Me.lblVessel)
        Me.tabParticulars.Controls.Add(Me.cmdNextPart)
        Me.tabParticulars.Controls.Add(Me.cmdExitPart)
        Me.tabParticulars.Location = New System.Drawing.Point(4, 29)
        Me.tabParticulars.Name = "tabParticulars"
        Me.tabParticulars.Padding = New System.Windows.Forms.Padding(3)
        Me.tabParticulars.Size = New System.Drawing.Size(1318, 672)
        Me.tabParticulars.TabIndex = 0
        Me.tabParticulars.Text = "Vessel Particulars"
        Me.tabParticulars.UseVisualStyleBackColor = True
        '
        'mskLastLoaded
        '
        Me.mskLastLoaded.Location = New System.Drawing.Point(942, 362)
        Me.mskLastLoaded.Name = "mskLastLoaded"
        Me.mskLastLoaded.Size = New System.Drawing.Size(205, 27)
        Me.mskLastLoaded.TabIndex = 28
        '
        'lblLastLoaded
        '
        Me.lblLastLoaded.AutoSize = True
        Me.lblLastLoaded.Location = New System.Drawing.Point(679, 365)
        Me.lblLastLoaded.Name = "lblLastLoaded"
        Me.lblLastLoaded.Size = New System.Drawing.Size(257, 22)
        Me.lblLastLoaded.TabIndex = 27
        Me.lblLastLoaded.Text = "Time of Last Container Loaded" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'mskFirstLoaded
        '
        Me.mskFirstLoaded.Location = New System.Drawing.Point(943, 309)
        Me.mskFirstLoaded.Name = "mskFirstLoaded"
        Me.mskFirstLoaded.Size = New System.Drawing.Size(205, 27)
        Me.mskFirstLoaded.TabIndex = 26
        '
        'lblFirstLoaded
        '
        Me.lblFirstLoaded.AutoSize = True
        Me.lblFirstLoaded.Location = New System.Drawing.Point(679, 312)
        Me.lblFirstLoaded.Name = "lblFirstLoaded"
        Me.lblFirstLoaded.Size = New System.Drawing.Size(258, 22)
        Me.lblFirstLoaded.TabIndex = 25
        Me.lblFirstLoaded.Text = "Time of First Container Loaded" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'mskLastDischarged
        '
        Me.mskLastDischarged.Location = New System.Drawing.Point(973, 256)
        Me.mskLastDischarged.Name = "mskLastDischarged"
        Me.mskLastDischarged.Size = New System.Drawing.Size(205, 27)
        Me.mskLastDischarged.TabIndex = 24
        '
        'lblLastDischarged
        '
        Me.lblLastDischarged.AutoSize = True
        Me.lblLastDischarged.Location = New System.Drawing.Point(679, 259)
        Me.lblLastDischarged.Name = "lblLastDischarged"
        Me.lblLastDischarged.Size = New System.Drawing.Size(288, 22)
        Me.lblLastDischarged.TabIndex = 23
        Me.lblLastDischarged.Text = "Time of Last Container Discharged" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'mskFirstDischarged
        '
        Me.mskFirstDischarged.Location = New System.Drawing.Point(974, 203)
        Me.mskFirstDischarged.Name = "mskFirstDischarged"
        Me.mskFirstDischarged.Size = New System.Drawing.Size(205, 27)
        Me.mskFirstDischarged.TabIndex = 22
        '
        'lblFirstDischarged
        '
        Me.lblFirstDischarged.AutoSize = True
        Me.lblFirstDischarged.Location = New System.Drawing.Point(679, 206)
        Me.lblFirstDischarged.Name = "lblFirstDischarged"
        Me.lblFirstDischarged.Size = New System.Drawing.Size(289, 22)
        Me.lblFirstDischarged.TabIndex = 21
        Me.lblFirstDischarged.Text = "Time of First Container Discharged" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'mskOpCommenced
        '
        Me.mskOpCommenced.Location = New System.Drawing.Point(924, 150)
        Me.mskOpCommenced.Name = "mskOpCommenced"
        Me.mskOpCommenced.Size = New System.Drawing.Size(205, 27)
        Me.mskOpCommenced.TabIndex = 20
        '
        'lblOpCommenced
        '
        Me.lblOpCommenced.AutoSize = True
        Me.lblOpCommenced.Location = New System.Drawing.Point(679, 153)
        Me.lblOpCommenced.Name = "lblOpCommenced"
        Me.lblOpCommenced.Size = New System.Drawing.Size(239, 22)
        Me.lblOpCommenced.TabIndex = 19
        Me.lblOpCommenced.Text = "Time Operation Commenced"
        '
        'mskATA
        '
        Me.mskATA.Location = New System.Drawing.Point(343, 444)
        Me.mskATA.Name = "mskATA"
        Me.mskATA.Size = New System.Drawing.Size(205, 27)
        Me.mskATA.TabIndex = 18
        '
        'lblATA
        '
        Me.lblATA.AutoSize = True
        Me.lblATA.Location = New System.Drawing.Point(103, 447)
        Me.lblATA.Name = "lblATA"
        Me.lblATA.Size = New System.Drawing.Size(234, 22)
        Me.lblATA.TabIndex = 17
        Me.lblATA.Text = "Actual Time of Arrival (ATA)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'mskETA
        '
        Me.mskETA.Location = New System.Drawing.Point(374, 399)
        Me.mskETA.Name = "mskETA"
        Me.mskETA.Size = New System.Drawing.Size(205, 27)
        Me.mskETA.TabIndex = 16
        '
        'lblETA
        '
        Me.lblETA.AutoSize = True
        Me.lblETA.Location = New System.Drawing.Point(105, 402)
        Me.lblETA.Name = "lblETA"
        Me.lblETA.Size = New System.Drawing.Size(263, 22)
        Me.lblETA.TabIndex = 15
        Me.lblETA.Text = "Estimated Time of Arrival (ETA)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'mskOvertime
        '
        Me.mskOvertime.Location = New System.Drawing.Point(269, 330)
        Me.mskOvertime.Name = "mskOvertime"
        Me.mskOvertime.Size = New System.Drawing.Size(205, 27)
        Me.mskOvertime.TabIndex = 14
        '
        'mskSLGang
        '
        Me.mskSLGang.Location = New System.Drawing.Point(269, 279)
        Me.mskSLGang.Name = "mskSLGang"
        Me.mskSLGang.Size = New System.Drawing.Size(205, 27)
        Me.mskSLGang.TabIndex = 13
        '
        'mskPier
        '
        Me.mskPier.Location = New System.Drawing.Point(256, 228)
        Me.mskPier.Name = "mskPier"
        Me.mskPier.Size = New System.Drawing.Size(188, 27)
        Me.mskPier.TabIndex = 12
        '
        'mskRegistry
        '
        Me.mskRegistry.Location = New System.Drawing.Point(255, 177)
        Me.mskRegistry.Name = "mskRegistry"
        Me.mskRegistry.Size = New System.Drawing.Size(194, 27)
        Me.mskRegistry.TabIndex = 11
        '
        'mskVoyage
        '
        Me.mskVoyage.Location = New System.Drawing.Point(250, 126)
        Me.mskVoyage.Name = "mskVoyage"
        Me.mskVoyage.Size = New System.Drawing.Size(194, 27)
        Me.mskVoyage.TabIndex = 10
        '
        'mskVessel
        '
        Me.mskVessel.Location = New System.Drawing.Point(227, 75)
        Me.mskVessel.Name = "mskVessel"
        Me.mskVessel.Size = New System.Drawing.Size(535, 27)
        Me.mskVessel.TabIndex = 9
        '
        'lblOvertime
        '
        Me.lblOvertime.AutoSize = True
        Me.lblOvertime.Location = New System.Drawing.Point(105, 333)
        Me.lblOvertime.Name = "lblOvertime"
        Me.lblOvertime.Size = New System.Drawing.Size(160, 22)
        Me.lblOvertime.TabIndex = 8
        Me.lblOvertime.Text = "Overtime Required"
        '
        'lblSLGang
        '
        Me.lblSLGang.AutoSize = True
        Me.lblSLGang.Location = New System.Drawing.Point(105, 282)
        Me.lblSLGang.Name = "lblSLGang"
        Me.lblSLGang.Size = New System.Drawing.Size(158, 22)
        Me.lblSLGang.TabIndex = 7
        Me.lblSLGang.Text = "S/L Gang Request"
        '
        'lblPier
        '
        Me.lblPier.AutoSize = True
        Me.lblPier.Location = New System.Drawing.Point(105, 231)
        Me.lblPier.Name = "lblPier"
        Me.lblPier.Size = New System.Drawing.Size(145, 22)
        Me.lblPier.TabIndex = 6
        Me.lblPier.Text = "Pier Berth (NCT)"
        '
        'lblRegistry
        '
        Me.lblRegistry.AutoSize = True
        Me.lblRegistry.Location = New System.Drawing.Point(105, 180)
        Me.lblRegistry.Name = "lblRegistry"
        Me.lblRegistry.Size = New System.Drawing.Size(144, 22)
        Me.lblRegistry.TabIndex = 5
        Me.lblRegistry.Text = "Registry Number"
        '
        'lblVoyage
        '
        Me.lblVoyage.AutoSize = True
        Me.lblVoyage.Location = New System.Drawing.Point(105, 129)
        Me.lblVoyage.Name = "lblVoyage"
        Me.lblVoyage.Size = New System.Drawing.Size(139, 22)
        Me.lblVoyage.TabIndex = 4
        Me.lblVoyage.Text = "Voyage Number"
        '
        'lblVessel
        '
        Me.lblVessel.AutoSize = True
        Me.lblVessel.Location = New System.Drawing.Point(105, 78)
        Me.lblVessel.Name = "lblVessel"
        Me.lblVessel.Size = New System.Drawing.Size(116, 22)
        Me.lblVessel.TabIndex = 3
        Me.lblVessel.Text = "Vessel Name"
        '
        'cmdNextPart
        '
        Me.cmdNextPart.Location = New System.Drawing.Point(1100, 569)
        Me.cmdNextPart.Name = "cmdNextPart"
        Me.cmdNextPart.Size = New System.Drawing.Size(164, 43)
        Me.cmdNextPart.TabIndex = 2
        Me.cmdNextPart.Text = "Next (F11)"
        Me.cmdNextPart.UseVisualStyleBackColor = True
        '
        'cmdExitPart
        '
        Me.cmdExitPart.Location = New System.Drawing.Point(62, 569)
        Me.cmdExitPart.Name = "cmdExitPart"
        Me.cmdExitPart.Size = New System.Drawing.Size(164, 43)
        Me.cmdExitPart.TabIndex = 0
        Me.cmdExitPart.Text = "Exit (F3)"
        Me.cmdExitPart.UseVisualStyleBackColor = True
        '
        'tabThroughput
        '
        Me.tabThroughput.Controls.Add(Me.mskActualDeparture)
        Me.tabThroughput.Controls.Add(Me.lblActualDeparture)
        Me.tabThroughput.Controls.Add(Me.mskRegulars)
        Me.tabThroughput.Controls.Add(Me.lblRegulars)
        Me.tabThroughput.Controls.Add(Me.mskOnCallSV)
        Me.tabThroughput.Controls.Add(Me.lblOnCallSV)
        Me.tabThroughput.Controls.Add(Me.mskTimeComplete)
        Me.tabThroughput.Controls.Add(Me.lblTimeComplete)
        Me.tabThroughput.Controls.Add(Me.mskDateComplete)
        Me.tabThroughput.Controls.Add(Me.lblDateComplete)
        Me.tabThroughput.Controls.Add(Me.mskGrandTot)
        Me.tabThroughput.Controls.Add(Me.lblGrandTot)
        Me.tabThroughput.Controls.Add(Me.mskTEUs)
        Me.tabThroughput.Controls.Add(Me.lblTEUs)
        Me.tabThroughput.Controls.Add(Me.crThroughput)
        Me.tabThroughput.Controls.Add(Me.cmdNextTpt)
        Me.tabThroughput.Controls.Add(Me.cmdPrevTpt)
        Me.tabThroughput.Controls.Add(Me.cmdExitTpt)
        Me.tabThroughput.Location = New System.Drawing.Point(4, 29)
        Me.tabThroughput.Name = "tabThroughput"
        Me.tabThroughput.Padding = New System.Windows.Forms.Padding(3)
        Me.tabThroughput.Size = New System.Drawing.Size(1318, 672)
        Me.tabThroughput.TabIndex = 2
        Me.tabThroughput.Text = "Throughput"
        Me.tabThroughput.UseVisualStyleBackColor = True
        '
        'mskActualDeparture
        '
        Me.mskActualDeparture.Location = New System.Drawing.Point(848, 502)
        Me.mskActualDeparture.Name = "mskActualDeparture"
        Me.mskActualDeparture.Size = New System.Drawing.Size(205, 27)
        Me.mskActualDeparture.TabIndex = 42
        '
        'lblActualDeparture
        '
        Me.lblActualDeparture.AutoSize = True
        Me.lblActualDeparture.Location = New System.Drawing.Point(659, 505)
        Me.lblActualDeparture.Name = "lblActualDeparture"
        Me.lblActualDeparture.Size = New System.Drawing.Size(183, 22)
        Me.lblActualDeparture.TabIndex = 41
        Me.lblActualDeparture.Text = "Actual time Departure" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'mskRegulars
        '
        Me.mskRegulars.Location = New System.Drawing.Point(816, 464)
        Me.mskRegulars.Name = "mskRegulars"
        Me.mskRegulars.Size = New System.Drawing.Size(205, 27)
        Me.mskRegulars.TabIndex = 40
        '
        'lblRegulars
        '
        Me.lblRegulars.AutoSize = True
        Me.lblRegulars.Location = New System.Drawing.Point(659, 466)
        Me.lblRegulars.Name = "lblRegulars"
        Me.lblRegulars.Size = New System.Drawing.Size(151, 22)
        Me.lblRegulars.TabIndex = 39
        Me.lblRegulars.Text = "Total regular staff" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'mskOnCallSV
        '
        Me.mskOnCallSV.Location = New System.Drawing.Point(925, 426)
        Me.mskOnCallSV.Name = "mskOnCallSV"
        Me.mskOnCallSV.Size = New System.Drawing.Size(205, 27)
        Me.mskOnCallSV.TabIndex = 38
        '
        'lblOnCallSV
        '
        Me.lblOnCallSV.AutoSize = True
        Me.lblOnCallSV.Location = New System.Drawing.Point(659, 427)
        Me.lblOnCallSV.Name = "lblOnCallSV"
        Me.lblOnCallSV.Size = New System.Drawing.Size(260, 22)
        Me.lblOnCallSV.TabIndex = 37
        Me.lblOnCallSV.Text = "Total on call stevedoers/drivers" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'mskTimeComplete
        '
        Me.mskTimeComplete.Location = New System.Drawing.Point(402, 519)
        Me.mskTimeComplete.Name = "mskTimeComplete"
        Me.mskTimeComplete.Size = New System.Drawing.Size(205, 27)
        Me.mskTimeComplete.TabIndex = 36
        '
        'lblTimeComplete
        '
        Me.lblTimeComplete.AutoSize = True
        Me.lblTimeComplete.Location = New System.Drawing.Point(233, 522)
        Me.lblTimeComplete.Name = "lblTimeComplete"
        Me.lblTimeComplete.Size = New System.Drawing.Size(165, 22)
        Me.lblTimeComplete.TabIndex = 35
        Me.lblTimeComplete.Text = "Time of Completion"
        '
        'mskDateComplete
        '
        Me.mskDateComplete.Location = New System.Drawing.Point(402, 481)
        Me.mskDateComplete.Name = "mskDateComplete"
        Me.mskDateComplete.Size = New System.Drawing.Size(205, 27)
        Me.mskDateComplete.TabIndex = 34
        '
        'lblDateComplete
        '
        Me.lblDateComplete.AutoSize = True
        Me.lblDateComplete.Location = New System.Drawing.Point(233, 484)
        Me.lblDateComplete.Name = "lblDateComplete"
        Me.lblDateComplete.Size = New System.Drawing.Size(163, 22)
        Me.lblDateComplete.TabIndex = 33
        Me.lblDateComplete.Text = "Date of Completion"
        '
        'mskGrandTot
        '
        Me.mskGrandTot.Location = New System.Drawing.Point(400, 446)
        Me.mskGrandTot.Name = "mskGrandTot"
        Me.mskGrandTot.Size = New System.Drawing.Size(205, 27)
        Me.mskGrandTot.TabIndex = 32
        '
        'lblGrandTot
        '
        Me.lblGrandTot.AutoSize = True
        Me.lblGrandTot.Location = New System.Drawing.Point(233, 449)
        Me.lblGrandTot.Name = "lblGrandTot"
        Me.lblGrandTot.Size = New System.Drawing.Size(161, 22)
        Me.lblGrandTot.TabIndex = 31
        Me.lblGrandTot.Text = "Grand Total Boxes"
        '
        'mskTEUs
        '
        Me.mskTEUs.Location = New System.Drawing.Point(341, 408)
        Me.mskTEUs.Name = "mskTEUs"
        Me.mskTEUs.Size = New System.Drawing.Size(205, 27)
        Me.mskTEUs.TabIndex = 30
        '
        'lblTEUs
        '
        Me.lblTEUs.AutoSize = True
        Me.lblTEUs.Location = New System.Drawing.Point(233, 411)
        Me.lblTEUs.Name = "lblTEUs"
        Me.lblTEUs.Size = New System.Drawing.Size(102, 22)
        Me.lblTEUs.TabIndex = 29
        Me.lblTEUs.Text = "Total TEUs"
        '
        'crThroughput
        '
        Me.crThroughput.ActiveViewIndex = -1
        Me.crThroughput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crThroughput.Cursor = System.Windows.Forms.Cursors.Default
        Me.crThroughput.Location = New System.Drawing.Point(6, 6)
        Me.crThroughput.Name = "crThroughput"
        Me.crThroughput.Size = New System.Drawing.Size(1306, 371)
        Me.crThroughput.TabIndex = 6
        '
        'cmdNextTpt
        '
        Me.cmdNextTpt.Location = New System.Drawing.Point(1100, 569)
        Me.cmdNextTpt.Name = "cmdNextTpt"
        Me.cmdNextTpt.Size = New System.Drawing.Size(164, 43)
        Me.cmdNextTpt.TabIndex = 5
        Me.cmdNextTpt.Text = "Next (F11)"
        Me.cmdNextTpt.UseVisualStyleBackColor = True
        '
        'cmdPrevTpt
        '
        Me.cmdPrevTpt.Location = New System.Drawing.Point(930, 569)
        Me.cmdPrevTpt.Name = "cmdPrevTpt"
        Me.cmdPrevTpt.Size = New System.Drawing.Size(164, 43)
        Me.cmdPrevTpt.TabIndex = 4
        Me.cmdPrevTpt.Text = "Prev (F10)"
        Me.cmdPrevTpt.UseVisualStyleBackColor = True
        '
        'cmdExitTpt
        '
        Me.cmdExitTpt.Location = New System.Drawing.Point(62, 569)
        Me.cmdExitTpt.Name = "cmdExitTpt"
        Me.cmdExitTpt.Size = New System.Drawing.Size(164, 43)
        Me.cmdExitTpt.TabIndex = 3
        Me.cmdExitTpt.Text = "Exit (F3)"
        Me.cmdExitTpt.UseVisualStyleBackColor = True
        '
        'tabSpecials
        '
        Me.tabSpecials.Controls.Add(Me.Label32)
        Me.tabSpecials.Controls.Add(Me.Label31)
        Me.tabSpecials.Controls.Add(Me.spltSpecials)
        Me.tabSpecials.Controls.Add(Me.cmdNextSpl)
        Me.tabSpecials.Controls.Add(Me.cmdPrevSpl)
        Me.tabSpecials.Controls.Add(Me.cmdExitSpl)
        Me.tabSpecials.Location = New System.Drawing.Point(4, 29)
        Me.tabSpecials.Name = "tabSpecials"
        Me.tabSpecials.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSpecials.Size = New System.Drawing.Size(1318, 672)
        Me.tabSpecials.TabIndex = 3
        Me.tabSpecials.Text = "Specials"
        Me.tabSpecials.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(640, 64)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(624, 22)
        Me.Label32.TabIndex = 8
        Me.Label32.Text = "Dangerous Containers"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(62, 64)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(574, 21)
        Me.Label31.TabIndex = 7
        Me.Label31.Text = "Chargeable Marine Unit Events"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'spltSpecials
        '
        Me.spltSpecials.Location = New System.Drawing.Point(62, 88)
        Me.spltSpecials.Name = "spltSpecials"
        '
        'spltSpecials.Panel1
        '
        Me.spltSpecials.Panel1.Controls.Add(Me.lblContainers)
        Me.spltSpecials.Panel1.Controls.Add(Me.lblGearboxes)
        Me.spltSpecials.Panel1.Controls.Add(Me.mskContainers)
        Me.spltSpecials.Panel1.Controls.Add(Me.mskLifted)
        Me.spltSpecials.Panel1.Controls.Add(Me.lblLifted)
        Me.spltSpecials.Panel1.Controls.Add(Me.mskGearboxes)
        Me.spltSpecials.Panel1.Controls.Add(Me.lblSVD)
        Me.spltSpecials.Panel1.Controls.Add(Me.mskFormalities)
        Me.spltSpecials.Panel1.Controls.Add(Me.lblFormalities)
        Me.spltSpecials.Panel1.Controls.Add(Me.mskStandby)
        Me.spltSpecials.Panel1.Controls.Add(Me.lblStandby)
        '
        'spltSpecials.Panel2
        '
        Me.spltSpecials.Panel2.Controls.Add(Me.crDanger)
        Me.spltSpecials.Size = New System.Drawing.Size(1202, 452)
        Me.spltSpecials.SplitterDistance = 574
        Me.spltSpecials.TabIndex = 6
        '
        'lblContainers
        '
        Me.lblContainers.AutoSize = True
        Me.lblContainers.Location = New System.Drawing.Point(318, 268)
        Me.lblContainers.Name = "lblContainers"
        Me.lblContainers.Size = New System.Drawing.Size(97, 22)
        Me.lblContainers.TabIndex = 53
        Me.lblContainers.Text = "Containers"
        '
        'lblGearboxes
        '
        Me.lblGearboxes.AutoSize = True
        Me.lblGearboxes.Location = New System.Drawing.Point(318, 235)
        Me.lblGearboxes.Name = "lblGearboxes"
        Me.lblGearboxes.Size = New System.Drawing.Size(98, 22)
        Me.lblGearboxes.TabIndex = 52
        Me.lblGearboxes.Text = "Gearboxes"
        '
        'mskContainers
        '
        Me.mskContainers.Location = New System.Drawing.Point(255, 265)
        Me.mskContainers.Name = "mskContainers"
        Me.mskContainers.Size = New System.Drawing.Size(57, 27)
        Me.mskContainers.TabIndex = 51
        '
        'mskLifted
        '
        Me.mskLifted.Location = New System.Drawing.Point(126, 327)
        Me.mskLifted.Name = "mskLifted"
        Me.mskLifted.Size = New System.Drawing.Size(205, 27)
        Me.mskLifted.TabIndex = 50
        '
        'lblLifted
        '
        Me.lblLifted.AutoSize = True
        Me.lblLifted.Location = New System.Drawing.Point(66, 330)
        Me.lblLifted.Name = "lblLifted"
        Me.lblLifted.Size = New System.Drawing.Size(54, 22)
        Me.lblLifted.TabIndex = 49
        Me.lblLifted.Text = "Lifted"
        '
        'mskGearboxes
        '
        Me.mskGearboxes.Location = New System.Drawing.Point(255, 232)
        Me.mskGearboxes.Name = "mskGearboxes"
        Me.mskGearboxes.Size = New System.Drawing.Size(57, 27)
        Me.mskGearboxes.TabIndex = 48
        '
        'lblSVD
        '
        Me.lblSVD.AutoSize = True
        Me.lblSVD.Location = New System.Drawing.Point(66, 235)
        Me.lblSVD.Name = "lblSVD"
        Me.lblSVD.Size = New System.Drawing.Size(144, 22)
        Me.lblSVD.TabIndex = 47
        Me.lblSVD.Text = "Shifting via Dock"
        '
        'mskFormalities
        '
        Me.mskFormalities.Location = New System.Drawing.Point(228, 137)
        Me.mskFormalities.Name = "mskFormalities"
        Me.mskFormalities.Size = New System.Drawing.Size(205, 27)
        Me.mskFormalities.TabIndex = 46
        '
        'lblFormalities
        '
        Me.lblFormalities.AutoSize = True
        Me.lblFormalities.Location = New System.Drawing.Point(66, 140)
        Me.lblFormalities.Name = "lblFormalities"
        Me.lblFormalities.Size = New System.Drawing.Size(156, 22)
        Me.lblFormalities.TabIndex = 45
        Me.lblFormalities.Text = "Vessel Formalities"
        '
        'mskStandby
        '
        Me.mskStandby.Location = New System.Drawing.Point(328, 42)
        Me.mskStandby.Name = "mskStandby"
        Me.mskStandby.Size = New System.Drawing.Size(205, 27)
        Me.mskStandby.TabIndex = 44
        '
        'lblStandby
        '
        Me.lblStandby.AutoSize = True
        Me.lblStandby.Location = New System.Drawing.Point(66, 45)
        Me.lblStandby.Name = "lblStandby"
        Me.lblStandby.Size = New System.Drawing.Size(256, 22)
        Me.lblStandby.TabIndex = 43
        Me.lblStandby.Text = "Standby Waiting for the Vessel"
        '
        'crDanger
        '
        Me.crDanger.ActiveViewIndex = -1
        Me.crDanger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crDanger.Cursor = System.Windows.Forms.Cursors.Default
        Me.crDanger.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crDanger.Location = New System.Drawing.Point(0, 0)
        Me.crDanger.Name = "crDanger"
        Me.crDanger.Size = New System.Drawing.Size(624, 452)
        Me.crDanger.TabIndex = 0
        '
        'cmdNextSpl
        '
        Me.cmdNextSpl.Location = New System.Drawing.Point(1100, 569)
        Me.cmdNextSpl.Name = "cmdNextSpl"
        Me.cmdNextSpl.Size = New System.Drawing.Size(164, 43)
        Me.cmdNextSpl.TabIndex = 5
        Me.cmdNextSpl.Text = "Next (F11)"
        Me.cmdNextSpl.UseVisualStyleBackColor = True
        '
        'cmdPrevSpl
        '
        Me.cmdPrevSpl.Location = New System.Drawing.Point(930, 569)
        Me.cmdPrevSpl.Name = "cmdPrevSpl"
        Me.cmdPrevSpl.Size = New System.Drawing.Size(164, 43)
        Me.cmdPrevSpl.TabIndex = 4
        Me.cmdPrevSpl.Text = "Prev (F10)"
        Me.cmdPrevSpl.UseVisualStyleBackColor = True
        '
        'cmdExitSpl
        '
        Me.cmdExitSpl.Location = New System.Drawing.Point(62, 569)
        Me.cmdExitSpl.Name = "cmdExitSpl"
        Me.cmdExitSpl.Size = New System.Drawing.Size(164, 43)
        Me.cmdExitSpl.TabIndex = 3
        Me.cmdExitSpl.Text = "Exit (F3)"
        Me.cmdExitSpl.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.lblManner)
        Me.TabPage5.Controls.Add(Me.mskOPCenter)
        Me.TabPage5.Controls.Add(Me.mskManner)
        Me.TabPage5.Controls.Add(Me.lblOPCenter)
        Me.TabPage5.Controls.Add(Me.mskAsstOP)
        Me.TabPage5.Controls.Add(Me.lblAsstOP)
        Me.TabPage5.Controls.Add(Me.mskSupervisor)
        Me.TabPage5.Controls.Add(Me.lblSupervisor)
        Me.TabPage5.Controls.Add(Me.mskChecker)
        Me.TabPage5.Controls.Add(Me.lblChecker)
        Me.TabPage5.Controls.Add(Me.cmdNextFoot)
        Me.TabPage5.Controls.Add(Me.cmdPrevFoot)
        Me.TabPage5.Controls.Add(Me.cmdExitFoot)
        Me.TabPage5.Location = New System.Drawing.Point(4, 29)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1318, 672)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Footers"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'lblManner
        '
        Me.lblManner.AutoSize = True
        Me.lblManner.Location = New System.Drawing.Point(566, 454)
        Me.lblManner.Name = "lblManner"
        Me.lblManner.Size = New System.Drawing.Size(174, 22)
        Me.lblManner.TabIndex = 57
        Me.lblManner.Text = "Manner of Operation"
        '
        'mskOPCenter
        '
        Me.mskOPCenter.Location = New System.Drawing.Point(458, 335)
        Me.mskOPCenter.Name = "mskOPCenter"
        Me.mskOPCenter.Size = New System.Drawing.Size(390, 27)
        Me.mskOPCenter.TabIndex = 54
        '
        'mskManner
        '
        Me.mskManner.Location = New System.Drawing.Point(458, 424)
        Me.mskManner.Name = "mskManner"
        Me.mskManner.Size = New System.Drawing.Size(390, 27)
        Me.mskManner.TabIndex = 52
        '
        'lblOPCenter
        '
        Me.lblOPCenter.AutoSize = True
        Me.lblOPCenter.Location = New System.Drawing.Point(606, 365)
        Me.lblOPCenter.Name = "lblOPCenter"
        Me.lblOPCenter.Size = New System.Drawing.Size(95, 22)
        Me.lblOPCenter.TabIndex = 49
        Me.lblOPCenter.Text = "OP Center"
        '
        'mskAsstOP
        '
        Me.mskAsstOP.Location = New System.Drawing.Point(458, 246)
        Me.mskAsstOP.Name = "mskAsstOP"
        Me.mskAsstOP.Size = New System.Drawing.Size(390, 27)
        Me.mskAsstOP.TabIndex = 48
        '
        'lblAsstOP
        '
        Me.lblAsstOP.AutoSize = True
        Me.lblAsstOP.Location = New System.Drawing.Point(532, 276)
        Me.lblAsstOP.Name = "lblAsstOP"
        Me.lblAsstOP.Size = New System.Drawing.Size(242, 22)
        Me.lblAsstOP.TabIndex = 47
        Me.lblAsstOP.Text = "Assistant Operation Manager"
        '
        'mskSupervisor
        '
        Me.mskSupervisor.Location = New System.Drawing.Point(811, 151)
        Me.mskSupervisor.Name = "mskSupervisor"
        Me.mskSupervisor.Size = New System.Drawing.Size(390, 27)
        Me.mskSupervisor.TabIndex = 46
        '
        'lblSupervisor
        '
        Me.lblSupervisor.AutoSize = True
        Me.lblSupervisor.Location = New System.Drawing.Point(934, 181)
        Me.lblSupervisor.Name = "lblSupervisor"
        Me.lblSupervisor.Size = New System.Drawing.Size(144, 22)
        Me.lblSupervisor.TabIndex = 45
        Me.lblSupervisor.Text = "OPS. Supervisor"
        '
        'mskChecker
        '
        Me.mskChecker.Location = New System.Drawing.Point(117, 151)
        Me.mskChecker.Name = "mskChecker"
        Me.mskChecker.Size = New System.Drawing.Size(390, 27)
        Me.mskChecker.TabIndex = 44
        '
        'lblChecker
        '
        Me.lblChecker.AutoSize = True
        Me.lblChecker.Location = New System.Drawing.Point(244, 181)
        Me.lblChecker.Name = "lblChecker"
        Me.lblChecker.Size = New System.Drawing.Size(136, 22)
        Me.lblChecker.TabIndex = 43
        Me.lblChecker.Text = "Vessel Checker"
        '
        'cmdNextFoot
        '
        Me.cmdNextFoot.Location = New System.Drawing.Point(1100, 569)
        Me.cmdNextFoot.Name = "cmdNextFoot"
        Me.cmdNextFoot.Size = New System.Drawing.Size(164, 43)
        Me.cmdNextFoot.TabIndex = 5
        Me.cmdNextFoot.Text = "Next (F11)"
        Me.cmdNextFoot.UseVisualStyleBackColor = True
        '
        'cmdPrevFoot
        '
        Me.cmdPrevFoot.Location = New System.Drawing.Point(930, 569)
        Me.cmdPrevFoot.Name = "cmdPrevFoot"
        Me.cmdPrevFoot.Size = New System.Drawing.Size(164, 43)
        Me.cmdPrevFoot.TabIndex = 4
        Me.cmdPrevFoot.Text = "Prev (F10)"
        Me.cmdPrevFoot.UseVisualStyleBackColor = True
        '
        'cmdExitFoot
        '
        Me.cmdExitFoot.Location = New System.Drawing.Point(62, 569)
        Me.cmdExitFoot.Name = "cmdExitFoot"
        Me.cmdExitFoot.Size = New System.Drawing.Size(164, 43)
        Me.cmdExitFoot.TabIndex = 3
        Me.cmdExitFoot.Text = "Exit (F3)"
        Me.cmdExitFoot.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.crPreview)
        Me.TabPage6.Controls.Add(Me.cmdSave)
        Me.TabPage6.Location = New System.Drawing.Point(4, 29)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(1318, 672)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Preview"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'crPreview
        '
        Me.crPreview.ActiveViewIndex = -1
        Me.crPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crPreview.Cursor = System.Windows.Forms.Cursors.Default
        Me.crPreview.Location = New System.Drawing.Point(3, 3)
        Me.crPreview.Name = "crPreview"
        Me.crPreview.Size = New System.Drawing.Size(1031, 666)
        Me.crPreview.TabIndex = 6
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(1100, 569)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(164, 43)
        Me.cmdSave.TabIndex = 5
        Me.cmdSave.Text = "Save | Print"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'frmVMR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.tabVMR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmVMR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form1"
        Me.TopMost = True
        Me.tabVMR.ResumeLayout(False)
        Me.tabParticulars.ResumeLayout(False)
        Me.tabParticulars.PerformLayout()
        Me.tabThroughput.ResumeLayout(False)
        Me.tabThroughput.PerformLayout()
        Me.tabSpecials.ResumeLayout(False)
        Me.spltSpecials.Panel1.ResumeLayout(False)
        Me.spltSpecials.Panel1.PerformLayout()
        Me.spltSpecials.Panel2.ResumeLayout(False)
        CType(Me.spltSpecials, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spltSpecials.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabVMR As TabControl
    Friend WithEvents tabParticulars As TabPage
    Friend WithEvents tabThroughput As TabPage
    Friend WithEvents tabSpecials As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents lblVoyage As Label
    Friend WithEvents lblVessel As Label
    Friend WithEvents cmdNextPart As Button
    Friend WithEvents cmdExitPart As Button
    Friend WithEvents cmdNextTpt As Button
    Friend WithEvents cmdPrevTpt As Button
    Friend WithEvents cmdExitTpt As Button
    Friend WithEvents cmdNextSpl As Button
    Friend WithEvents cmdPrevSpl As Button
    Friend WithEvents cmdExitSpl As Button
    Friend WithEvents cmdNextFoot As Button
    Friend WithEvents cmdPrevFoot As Button
    Friend WithEvents cmdExitFoot As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents lblOvertime As Label
    Friend WithEvents lblSLGang As Label
    Friend WithEvents lblPier As Label
    Friend WithEvents lblRegistry As Label
    Friend WithEvents mskOvertime As MaskedTextBox
    Friend WithEvents mskSLGang As MaskedTextBox
    Friend WithEvents mskPier As MaskedTextBox
    Friend WithEvents mskRegistry As MaskedTextBox
    Friend WithEvents mskVoyage As MaskedTextBox
    Friend WithEvents mskVessel As MaskedTextBox
    Friend WithEvents mskLastLoaded As MaskedTextBox
    Friend WithEvents lblLastLoaded As Label
    Friend WithEvents mskFirstLoaded As MaskedTextBox
    Friend WithEvents lblFirstLoaded As Label
    Friend WithEvents mskLastDischarged As MaskedTextBox
    Friend WithEvents lblLastDischarged As Label
    Friend WithEvents mskFirstDischarged As MaskedTextBox
    Friend WithEvents lblFirstDischarged As Label
    Friend WithEvents mskOpCommenced As MaskedTextBox
    Friend WithEvents lblOpCommenced As Label
    Friend WithEvents mskATA As MaskedTextBox
    Friend WithEvents lblATA As Label
    Friend WithEvents mskETA As MaskedTextBox
    Friend WithEvents lblETA As Label
    Friend WithEvents crThroughput As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents mskActualDeparture As MaskedTextBox
    Friend WithEvents lblActualDeparture As Label
    Friend WithEvents mskRegulars As MaskedTextBox
    Friend WithEvents lblRegulars As Label
    Friend WithEvents mskOnCallSV As MaskedTextBox
    Friend WithEvents lblOnCallSV As Label
    Friend WithEvents mskTimeComplete As MaskedTextBox
    Friend WithEvents lblTimeComplete As Label
    Friend WithEvents mskDateComplete As MaskedTextBox
    Friend WithEvents lblDateComplete As Label
    Friend WithEvents mskGrandTot As MaskedTextBox
    Friend WithEvents lblGrandTot As Label
    Friend WithEvents mskTEUs As MaskedTextBox
    Friend WithEvents lblTEUs As Label
    Friend WithEvents spltSpecials As SplitContainer
    Friend WithEvents mskLifted As MaskedTextBox
    Friend WithEvents lblLifted As Label
    Friend WithEvents mskGearboxes As MaskedTextBox
    Friend WithEvents lblSVD As Label
    Friend WithEvents mskFormalities As MaskedTextBox
    Friend WithEvents lblFormalities As Label
    Friend WithEvents mskStandby As MaskedTextBox
    Friend WithEvents lblStandby As Label
    Friend WithEvents crDanger As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents mskOPCenter As MaskedTextBox
    Friend WithEvents mskManner As MaskedTextBox
    Friend WithEvents lblOPCenter As Label
    Friend WithEvents mskAsstOP As MaskedTextBox
    Friend WithEvents lblAsstOP As Label
    Friend WithEvents mskSupervisor As MaskedTextBox
    Friend WithEvents lblSupervisor As Label
    Friend WithEvents mskChecker As MaskedTextBox
    Friend WithEvents lblChecker As Label
    Friend WithEvents lblManner As Label
    Friend WithEvents crPreview As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents lblContainers As Label
    Friend WithEvents lblGearboxes As Label
    Friend WithEvents mskContainers As MaskedTextBox
End Class
