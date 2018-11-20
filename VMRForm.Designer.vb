<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VMRForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tabVMR = New System.Windows.Forms.TabControl()
        Me.tabParticulars = New System.Windows.Forms.TabPage()
        Me.mskATD = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.mskTimeComplete = New System.Windows.Forms.MaskedTextBox()
        Me.lblTimeComplete = New System.Windows.Forms.Label()
        Me.mskDateComplete = New System.Windows.Forms.MaskedTextBox()
        Me.lblDateComplete = New System.Windows.Forms.Label()
        Me.mskRegulars = New System.Windows.Forms.MaskedTextBox()
        Me.lblRegulars = New System.Windows.Forms.Label()
        Me.mskOnCallSV = New System.Windows.Forms.MaskedTextBox()
        Me.lblOnCallSV = New System.Windows.Forms.Label()
        Me.cmdNextTpt = New System.Windows.Forms.Button()
        Me.cmdPrevTpt = New System.Windows.Forms.Button()
        Me.cmdExitTpt = New System.Windows.Forms.Button()
        Me.tabSpecials = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cmdNextSpl = New System.Windows.Forms.Button()
        Me.cmdPrevSpl = New System.Windows.Forms.Button()
        Me.cmdExitSpl = New System.Windows.Forms.Button()
        Me.tabFooters = New System.Windows.Forms.TabPage()
        Me.mskOPCenter = New System.Windows.Forms.MaskedTextBox()
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
        Me.tabPreview = New System.Windows.Forms.TabPage()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.tabVMR.SuspendLayout()
        Me.tabParticulars.SuspendLayout()
        Me.tabThroughput.SuspendLayout()
        Me.tabSpecials.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabFooters.SuspendLayout()
        Me.tabPreview.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabVMR
        '
        Me.tabVMR.Controls.Add(Me.tabParticulars)
        Me.tabVMR.Controls.Add(Me.tabThroughput)
        Me.tabVMR.Controls.Add(Me.tabSpecials)
        Me.tabVMR.Controls.Add(Me.tabFooters)
        Me.tabVMR.Controls.Add(Me.tabPreview)
        Me.tabVMR.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.tabVMR.Location = New System.Drawing.Point(12, 12)
        Me.tabVMR.Name = "tabVMR"
        Me.tabVMR.SelectedIndex = 0
        Me.tabVMR.Size = New System.Drawing.Size(1326, 705)
        Me.tabVMR.TabIndex = 0
        '
        'tabParticulars
        '
        Me.tabParticulars.Controls.Add(Me.mskATD)
        Me.tabParticulars.Controls.Add(Me.Label1)
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
        'mskATD
        '
        Me.mskATD.Location = New System.Drawing.Point(950, 322)
        Me.mskATD.Mask = "0000H 00/00/0000"
        Me.mskATD.Name = "mskATD"
        Me.mskATD.Size = New System.Drawing.Size(205, 27)
        Me.mskATD.TabIndex = 92
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(710, 325)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 22)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Actual Time of Arrival (ATD)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'mskATA
        '
        Me.mskATA.Location = New System.Drawing.Point(950, 267)
        Me.mskATA.Mask = "0000H 00/00/0000"
        Me.mskATA.Name = "mskATA"
        Me.mskATA.Size = New System.Drawing.Size(205, 27)
        Me.mskATA.TabIndex = 18
        '
        'lblATA
        '
        Me.lblATA.AutoSize = True
        Me.lblATA.Location = New System.Drawing.Point(710, 270)
        Me.lblATA.Name = "lblATA"
        Me.lblATA.Size = New System.Drawing.Size(234, 22)
        Me.lblATA.TabIndex = 17
        Me.lblATA.Text = "Actual Time of Arrival (ATA)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'mskETA
        '
        Me.mskETA.Location = New System.Drawing.Point(981, 212)
        Me.mskETA.Mask = "0000H 00/00/0000"
        Me.mskETA.Name = "mskETA"
        Me.mskETA.Size = New System.Drawing.Size(205, 27)
        Me.mskETA.TabIndex = 16
        Me.mskETA.ValidatingType = GetType(Date)
        '
        'lblETA
        '
        Me.lblETA.AutoSize = True
        Me.lblETA.Location = New System.Drawing.Point(712, 215)
        Me.lblETA.Name = "lblETA"
        Me.lblETA.Size = New System.Drawing.Size(263, 22)
        Me.lblETA.TabIndex = 15
        Me.lblETA.Text = "Estimated Time of Arrival (ETA)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'mskOvertime
        '
        Me.mskOvertime.Location = New System.Drawing.Point(876, 157)
        Me.mskOvertime.Mask = "0000H 00/00/0000"
        Me.mskOvertime.Name = "mskOvertime"
        Me.mskOvertime.Size = New System.Drawing.Size(205, 27)
        Me.mskOvertime.TabIndex = 14
        '
        'mskSLGang
        '
        Me.mskSLGang.Location = New System.Drawing.Point(297, 396)
        Me.mskSLGang.Mask = "0000H 00/00/0000"
        Me.mskSLGang.Name = "mskSLGang"
        Me.mskSLGang.Size = New System.Drawing.Size(205, 27)
        Me.mskSLGang.TabIndex = 13
        '
        'mskPier
        '
        Me.mskPier.Location = New System.Drawing.Point(284, 321)
        Me.mskPier.Name = "mskPier"
        Me.mskPier.Size = New System.Drawing.Size(188, 27)
        Me.mskPier.TabIndex = 12
        '
        'mskRegistry
        '
        Me.mskRegistry.Location = New System.Drawing.Point(283, 246)
        Me.mskRegistry.Name = "mskRegistry"
        Me.mskRegistry.Size = New System.Drawing.Size(194, 27)
        Me.mskRegistry.TabIndex = 11
        '
        'mskVoyage
        '
        Me.mskVoyage.Location = New System.Drawing.Point(278, 171)
        Me.mskVoyage.Name = "mskVoyage"
        Me.mskVoyage.Size = New System.Drawing.Size(194, 27)
        Me.mskVoyage.TabIndex = 10
        '
        'mskVessel
        '
        Me.mskVessel.Location = New System.Drawing.Point(255, 96)
        Me.mskVessel.Name = "mskVessel"
        Me.mskVessel.Size = New System.Drawing.Size(535, 27)
        Me.mskVessel.TabIndex = 9
        '
        'lblOvertime
        '
        Me.lblOvertime.AutoSize = True
        Me.lblOvertime.Location = New System.Drawing.Point(712, 160)
        Me.lblOvertime.Name = "lblOvertime"
        Me.lblOvertime.Size = New System.Drawing.Size(160, 22)
        Me.lblOvertime.TabIndex = 8
        Me.lblOvertime.Text = "Overtime Required"
        '
        'lblSLGang
        '
        Me.lblSLGang.AutoSize = True
        Me.lblSLGang.Location = New System.Drawing.Point(133, 399)
        Me.lblSLGang.Name = "lblSLGang"
        Me.lblSLGang.Size = New System.Drawing.Size(158, 22)
        Me.lblSLGang.TabIndex = 7
        Me.lblSLGang.Text = "S/L Gang Request"
        '
        'lblPier
        '
        Me.lblPier.AutoSize = True
        Me.lblPier.Location = New System.Drawing.Point(133, 324)
        Me.lblPier.Name = "lblPier"
        Me.lblPier.Size = New System.Drawing.Size(145, 22)
        Me.lblPier.TabIndex = 6
        Me.lblPier.Text = "Pier Berth (NCT)"
        '
        'lblRegistry
        '
        Me.lblRegistry.AutoSize = True
        Me.lblRegistry.Location = New System.Drawing.Point(133, 249)
        Me.lblRegistry.Name = "lblRegistry"
        Me.lblRegistry.Size = New System.Drawing.Size(144, 22)
        Me.lblRegistry.TabIndex = 5
        Me.lblRegistry.Text = "Registry Number"
        '
        'lblVoyage
        '
        Me.lblVoyage.AutoSize = True
        Me.lblVoyage.Location = New System.Drawing.Point(133, 174)
        Me.lblVoyage.Name = "lblVoyage"
        Me.lblVoyage.Size = New System.Drawing.Size(139, 22)
        Me.lblVoyage.TabIndex = 4
        Me.lblVoyage.Text = "Voyage Number"
        '
        'lblVessel
        '
        Me.lblVessel.AutoSize = True
        Me.lblVessel.Location = New System.Drawing.Point(133, 99)
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
        Me.tabThroughput.Controls.Add(Me.mskLastLoaded)
        Me.tabThroughput.Controls.Add(Me.lblLastLoaded)
        Me.tabThroughput.Controls.Add(Me.mskFirstLoaded)
        Me.tabThroughput.Controls.Add(Me.lblFirstLoaded)
        Me.tabThroughput.Controls.Add(Me.mskLastDischarged)
        Me.tabThroughput.Controls.Add(Me.lblLastDischarged)
        Me.tabThroughput.Controls.Add(Me.mskFirstDischarged)
        Me.tabThroughput.Controls.Add(Me.lblFirstDischarged)
        Me.tabThroughput.Controls.Add(Me.mskOpCommenced)
        Me.tabThroughput.Controls.Add(Me.lblOpCommenced)
        Me.tabThroughput.Controls.Add(Me.mskTimeComplete)
        Me.tabThroughput.Controls.Add(Me.lblTimeComplete)
        Me.tabThroughput.Controls.Add(Me.mskDateComplete)
        Me.tabThroughput.Controls.Add(Me.lblDateComplete)
        Me.tabThroughput.Controls.Add(Me.mskRegulars)
        Me.tabThroughput.Controls.Add(Me.lblRegulars)
        Me.tabThroughput.Controls.Add(Me.mskOnCallSV)
        Me.tabThroughput.Controls.Add(Me.lblOnCallSV)
        Me.tabThroughput.Controls.Add(Me.cmdNextTpt)
        Me.tabThroughput.Controls.Add(Me.cmdPrevTpt)
        Me.tabThroughput.Controls.Add(Me.cmdExitTpt)
        Me.tabThroughput.Location = New System.Drawing.Point(4, 29)
        Me.tabThroughput.Name = "tabThroughput"
        Me.tabThroughput.Padding = New System.Windows.Forms.Padding(3)
        Me.tabThroughput.Size = New System.Drawing.Size(1318, 672)
        Me.tabThroughput.TabIndex = 2
        Me.tabThroughput.Text = "Other Particulars"
        Me.tabThroughput.UseVisualStyleBackColor = True
        '
        'mskLastLoaded
        '
        Me.mskLastLoaded.Location = New System.Drawing.Point(365, 322)
        Me.mskLastLoaded.Mask = "0000H 00/00/0000"
        Me.mskLastLoaded.Name = "mskLastLoaded"
        Me.mskLastLoaded.Size = New System.Drawing.Size(205, 27)
        Me.mskLastLoaded.TabIndex = 100
        '
        'lblLastLoaded
        '
        Me.lblLastLoaded.AutoSize = True
        Me.lblLastLoaded.Location = New System.Drawing.Point(102, 325)
        Me.lblLastLoaded.Name = "lblLastLoaded"
        Me.lblLastLoaded.Size = New System.Drawing.Size(257, 22)
        Me.lblLastLoaded.TabIndex = 99
        Me.lblLastLoaded.Text = "Time of Last Container Loaded" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'mskFirstLoaded
        '
        Me.mskFirstLoaded.Location = New System.Drawing.Point(366, 269)
        Me.mskFirstLoaded.Mask = "0000H 00/00/0000"
        Me.mskFirstLoaded.Name = "mskFirstLoaded"
        Me.mskFirstLoaded.Size = New System.Drawing.Size(205, 27)
        Me.mskFirstLoaded.TabIndex = 98
        '
        'lblFirstLoaded
        '
        Me.lblFirstLoaded.AutoSize = True
        Me.lblFirstLoaded.Location = New System.Drawing.Point(102, 272)
        Me.lblFirstLoaded.Name = "lblFirstLoaded"
        Me.lblFirstLoaded.Size = New System.Drawing.Size(258, 22)
        Me.lblFirstLoaded.TabIndex = 97
        Me.lblFirstLoaded.Text = "Time of First Container Loaded" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'mskLastDischarged
        '
        Me.mskLastDischarged.Location = New System.Drawing.Point(396, 216)
        Me.mskLastDischarged.Mask = "0000H 00/00/0000"
        Me.mskLastDischarged.Name = "mskLastDischarged"
        Me.mskLastDischarged.Size = New System.Drawing.Size(205, 27)
        Me.mskLastDischarged.TabIndex = 96
        '
        'lblLastDischarged
        '
        Me.lblLastDischarged.AutoSize = True
        Me.lblLastDischarged.Location = New System.Drawing.Point(102, 219)
        Me.lblLastDischarged.Name = "lblLastDischarged"
        Me.lblLastDischarged.Size = New System.Drawing.Size(288, 22)
        Me.lblLastDischarged.TabIndex = 95
        Me.lblLastDischarged.Text = "Time of Last Container Discharged" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'mskFirstDischarged
        '
        Me.mskFirstDischarged.Location = New System.Drawing.Point(397, 163)
        Me.mskFirstDischarged.Mask = "0000H 00/00/0000"
        Me.mskFirstDischarged.Name = "mskFirstDischarged"
        Me.mskFirstDischarged.Size = New System.Drawing.Size(205, 27)
        Me.mskFirstDischarged.TabIndex = 94
        '
        'lblFirstDischarged
        '
        Me.lblFirstDischarged.AutoSize = True
        Me.lblFirstDischarged.Location = New System.Drawing.Point(102, 166)
        Me.lblFirstDischarged.Name = "lblFirstDischarged"
        Me.lblFirstDischarged.Size = New System.Drawing.Size(289, 22)
        Me.lblFirstDischarged.TabIndex = 93
        Me.lblFirstDischarged.Text = "Time of First Container Discharged" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'mskOpCommenced
        '
        Me.mskOpCommenced.Location = New System.Drawing.Point(347, 110)
        Me.mskOpCommenced.Mask = "0000H 00/00/0000"
        Me.mskOpCommenced.Name = "mskOpCommenced"
        Me.mskOpCommenced.Size = New System.Drawing.Size(205, 27)
        Me.mskOpCommenced.TabIndex = 92
        '
        'lblOpCommenced
        '
        Me.lblOpCommenced.AutoSize = True
        Me.lblOpCommenced.Location = New System.Drawing.Point(102, 113)
        Me.lblOpCommenced.Name = "lblOpCommenced"
        Me.lblOpCommenced.Size = New System.Drawing.Size(239, 22)
        Me.lblOpCommenced.TabIndex = 91
        Me.lblOpCommenced.Text = "Time Operation Commenced"
        '
        'mskTimeComplete
        '
        Me.mskTimeComplete.Location = New System.Drawing.Point(914, 299)
        Me.mskTimeComplete.Mask = "0000H"
        Me.mskTimeComplete.Name = "mskTimeComplete"
        Me.mskTimeComplete.Size = New System.Drawing.Size(205, 27)
        Me.mskTimeComplete.TabIndex = 88
        '
        'lblTimeComplete
        '
        Me.lblTimeComplete.AutoSize = True
        Me.lblTimeComplete.Location = New System.Drawing.Point(745, 302)
        Me.lblTimeComplete.Name = "lblTimeComplete"
        Me.lblTimeComplete.Size = New System.Drawing.Size(165, 22)
        Me.lblTimeComplete.TabIndex = 87
        Me.lblTimeComplete.Text = "Time of Completion"
        '
        'mskDateComplete
        '
        Me.mskDateComplete.Location = New System.Drawing.Point(914, 261)
        Me.mskDateComplete.Mask = "00/00/0000"
        Me.mskDateComplete.Name = "mskDateComplete"
        Me.mskDateComplete.Size = New System.Drawing.Size(205, 27)
        Me.mskDateComplete.TabIndex = 86
        '
        'lblDateComplete
        '
        Me.lblDateComplete.AutoSize = True
        Me.lblDateComplete.Location = New System.Drawing.Point(745, 264)
        Me.lblDateComplete.Name = "lblDateComplete"
        Me.lblDateComplete.Size = New System.Drawing.Size(163, 22)
        Me.lblDateComplete.TabIndex = 85
        Me.lblDateComplete.Text = "Date of Completion"
        '
        'mskRegulars
        '
        Me.mskRegulars.Location = New System.Drawing.Point(902, 173)
        Me.mskRegulars.Name = "mskRegulars"
        Me.mskRegulars.Size = New System.Drawing.Size(205, 27)
        Me.mskRegulars.TabIndex = 82
        '
        'lblRegulars
        '
        Me.lblRegulars.AutoSize = True
        Me.lblRegulars.Location = New System.Drawing.Point(745, 175)
        Me.lblRegulars.Name = "lblRegulars"
        Me.lblRegulars.Size = New System.Drawing.Size(151, 22)
        Me.lblRegulars.TabIndex = 81
        Me.lblRegulars.Text = "Total regular staff" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'mskOnCallSV
        '
        Me.mskOnCallSV.Location = New System.Drawing.Point(1011, 133)
        Me.mskOnCallSV.Name = "mskOnCallSV"
        Me.mskOnCallSV.Size = New System.Drawing.Size(205, 27)
        Me.mskOnCallSV.TabIndex = 80
        '
        'lblOnCallSV
        '
        Me.lblOnCallSV.AutoSize = True
        Me.lblOnCallSV.Location = New System.Drawing.Point(745, 136)
        Me.lblOnCallSV.Name = "lblOnCallSV"
        Me.lblOnCallSV.Size = New System.Drawing.Size(260, 22)
        Me.lblOnCallSV.TabIndex = 79
        Me.lblOnCallSV.Text = "Total on call stevedoers/drivers" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        Me.tabSpecials.Controls.Add(Me.DataGridView1)
        Me.tabSpecials.Controls.Add(Me.TextBox1)
        Me.tabSpecials.Controls.Add(Me.ComboBox1)
        Me.tabSpecials.Controls.Add(Me.cmdNextSpl)
        Me.tabSpecials.Controls.Add(Me.cmdPrevSpl)
        Me.tabSpecials.Controls.Add(Me.cmdExitSpl)
        Me.tabSpecials.Location = New System.Drawing.Point(4, 29)
        Me.tabSpecials.Name = "tabSpecials"
        Me.tabSpecials.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSpecials.Size = New System.Drawing.Size(1318, 672)
        Me.tabSpecials.TabIndex = 3
        Me.tabSpecials.Text = "CMU Events"
        Me.tabSpecials.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(216, 115)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(886, 353)
        Me.DataGridView1.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(558, 82)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(486, 27)
        Me.TextBox1.TabIndex = 7
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Standby Waiting for the Vessel", "Vessel Formalities", "Shifting via Dock", "Lifted"})
        Me.ComboBox1.Location = New System.Drawing.Point(275, 81)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(277, 28)
        Me.ComboBox1.TabIndex = 6
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
        'tabFooters
        '
        Me.tabFooters.Controls.Add(Me.mskOPCenter)
        Me.tabFooters.Controls.Add(Me.lblOPCenter)
        Me.tabFooters.Controls.Add(Me.mskAsstOP)
        Me.tabFooters.Controls.Add(Me.lblAsstOP)
        Me.tabFooters.Controls.Add(Me.mskSupervisor)
        Me.tabFooters.Controls.Add(Me.lblSupervisor)
        Me.tabFooters.Controls.Add(Me.mskChecker)
        Me.tabFooters.Controls.Add(Me.lblChecker)
        Me.tabFooters.Controls.Add(Me.cmdNextFoot)
        Me.tabFooters.Controls.Add(Me.cmdPrevFoot)
        Me.tabFooters.Controls.Add(Me.cmdExitFoot)
        Me.tabFooters.Location = New System.Drawing.Point(4, 29)
        Me.tabFooters.Name = "tabFooters"
        Me.tabFooters.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFooters.Size = New System.Drawing.Size(1318, 672)
        Me.tabFooters.TabIndex = 4
        Me.tabFooters.Text = "Footers"
        Me.tabFooters.UseVisualStyleBackColor = True
        '
        'mskOPCenter
        '
        Me.mskOPCenter.Location = New System.Drawing.Point(458, 365)
        Me.mskOPCenter.Name = "mskOPCenter"
        Me.mskOPCenter.Size = New System.Drawing.Size(390, 27)
        Me.mskOPCenter.TabIndex = 54
        '
        'lblOPCenter
        '
        Me.lblOPCenter.AutoSize = True
        Me.lblOPCenter.Location = New System.Drawing.Point(606, 395)
        Me.lblOPCenter.Name = "lblOPCenter"
        Me.lblOPCenter.Size = New System.Drawing.Size(95, 22)
        Me.lblOPCenter.TabIndex = 49
        Me.lblOPCenter.Text = "OP Center"
        '
        'mskAsstOP
        '
        Me.mskAsstOP.Location = New System.Drawing.Point(458, 276)
        Me.mskAsstOP.Name = "mskAsstOP"
        Me.mskAsstOP.Size = New System.Drawing.Size(390, 27)
        Me.mskAsstOP.TabIndex = 48
        '
        'lblAsstOP
        '
        Me.lblAsstOP.AutoSize = True
        Me.lblAsstOP.Location = New System.Drawing.Point(532, 306)
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
        'tabPreview
        '
        Me.tabPreview.Controls.Add(Me.cmdSave)
        Me.tabPreview.Controls.Add(Me.CrystalReportViewer1)
        Me.tabPreview.Location = New System.Drawing.Point(4, 29)
        Me.tabPreview.Name = "tabPreview"
        Me.tabPreview.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPreview.Size = New System.Drawing.Size(1318, 672)
        Me.tabPreview.TabIndex = 5
        Me.tabPreview.Text = "Preview"
        Me.tabPreview.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(1100, 569)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(164, 43)
        Me.cmdSave.TabIndex = 1
        Me.cmdSave.Text = "Save | Print"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(6, 6)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1052, 660)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'VMRForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.tabVMR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VMRForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.tabVMR.ResumeLayout(False)
        Me.tabParticulars.ResumeLayout(False)
        Me.tabParticulars.PerformLayout()
        Me.tabThroughput.ResumeLayout(False)
        Me.tabThroughput.PerformLayout()
        Me.tabSpecials.ResumeLayout(False)
        Me.tabSpecials.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabFooters.ResumeLayout(False)
        Me.tabFooters.PerformLayout()
        Me.tabPreview.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabVMR As TabControl
    Friend WithEvents tabParticulars As TabPage
    Friend WithEvents tabThroughput As TabPage
    Friend WithEvents tabSpecials As TabPage
    Friend WithEvents tabFooters As TabPage
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
    Friend WithEvents mskATA As MaskedTextBox
    Friend WithEvents lblATA As Label
    Friend WithEvents mskETA As MaskedTextBox
    Friend WithEvents lblETA As Label
    Friend WithEvents mskOPCenter As MaskedTextBox
    Friend WithEvents lblOPCenter As Label
    Friend WithEvents mskAsstOP As MaskedTextBox
    Friend WithEvents lblAsstOP As Label
    Friend WithEvents mskSupervisor As MaskedTextBox
    Friend WithEvents lblSupervisor As Label
    Friend WithEvents mskChecker As MaskedTextBox
    Friend WithEvents lblChecker As Label
    Friend WithEvents tabPreview As TabPage
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cmdSave As Button
    Friend WithEvents mskATD As MaskedTextBox
    Friend WithEvents Label1 As Label
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
    Friend WithEvents mskTimeComplete As MaskedTextBox
    Friend WithEvents lblTimeComplete As Label
    Friend WithEvents mskDateComplete As MaskedTextBox
    Friend WithEvents lblDateComplete As Label
    Friend WithEvents mskRegulars As MaskedTextBox
    Friend WithEvents lblRegulars As Label
    Friend WithEvents mskOnCallSV As MaskedTextBox
    Friend WithEvents lblOnCallSV As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
