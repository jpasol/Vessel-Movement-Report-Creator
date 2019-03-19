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
        Me.components = New System.ComponentModel.Container()
        Me.tabVMR = New System.Windows.Forms.TabControl()
        Me.tabParticulars = New System.Windows.Forms.TabPage()
        Me.mskFormEnd = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mskFormStart = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mskPrincipal = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.mskStandby = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.tabUnits = New System.Windows.Forms.TabPage()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.tabUnitBreakdown = New System.Windows.Forms.TabControl()
        Me.tabInbound = New System.Windows.Forms.TabPage()
        Me.tabInboundBreakdown = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.tabOutbound = New System.Windows.Forms.TabPage()
        Me.tabOutboundBreakdown = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.tabCMU = New System.Windows.Forms.TabPage()
        Me.cmdChargeReset = New System.Windows.Forms.Button()
        Me.cmdNextCMU = New System.Windows.Forms.Button()
        Me.cmdPrevCMU = New System.Windows.Forms.Button()
        Me.cmdExitCMU = New System.Windows.Forms.Button()
        Me.tabSpecificCMU = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.mskOwner = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvContainers = New System.Windows.Forms.DataGridView()
        Me.line_op2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mskBoxes = New System.Windows.Forms.MaskedTextBox()
        Me.cmbSizes = New System.Windows.Forms.ComboBox()
        Me.cmbFreight = New System.Windows.Forms.ComboBox()
        Me.cmbUnits = New System.Windows.Forms.ComboBox()
        Me.cmbMoveKinds = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.mskBayGB = New System.Windows.Forms.MaskedTextBox()
        Me.cmbSizesGB = New System.Windows.Forms.ComboBox()
        Me.mskCharge2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mskGearbox = New System.Windows.Forms.MaskedTextBox()
        Me.dgvGearboxes = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.mskBayHC = New System.Windows.Forms.MaskedTextBox()
        Me.mskCharge3 = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.mskHatchcovers = New System.Windows.Forms.MaskedTextBox()
        Me.dgvHatchcovers = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCMU = New System.Windows.Forms.DataGridView()
        Me.line_op = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.move_kind = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabFooters = New System.Windows.Forms.TabPage()
        Me.mskVisor1 = New System.Windows.Forms.MaskedTextBox()
        Me.mskChecker1 = New System.Windows.Forms.MaskedTextBox()
        Me.mskOPCenter = New System.Windows.Forms.MaskedTextBox()
        Me.lblOPCenter = New System.Windows.Forms.Label()
        Me.mskAsstOP = New System.Windows.Forms.MaskedTextBox()
        Me.lblAsstOP = New System.Windows.Forms.Label()
        Me.mskVisor2 = New System.Windows.Forms.MaskedTextBox()
        Me.lblSupervisor = New System.Windows.Forms.Label()
        Me.mskChecker2 = New System.Windows.Forms.MaskedTextBox()
        Me.lblChecker = New System.Windows.Forms.Label()
        Me.cmdNextFoot = New System.Windows.Forms.Button()
        Me.cmdPrevFoot = New System.Windows.Forms.Button()
        Me.cmdExitFoot = New System.Windows.Forms.Button()
        Me.tabPreview = New System.Windows.Forms.TabPage()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.AddSL = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddShippingLineToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddRemoveSL = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddShippingLineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveShippingLineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabVMR.SuspendLayout()
        Me.tabParticulars.SuspendLayout()
        Me.tabThroughput.SuspendLayout()
        Me.tabUnits.SuspendLayout()
        Me.tabUnitBreakdown.SuspendLayout()
        Me.tabInbound.SuspendLayout()
        Me.tabInboundBreakdown.SuspendLayout()
        Me.tabOutbound.SuspendLayout()
        Me.tabOutboundBreakdown.SuspendLayout()
        Me.tabCMU.SuspendLayout()
        Me.tabSpecificCMU.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvContainers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvGearboxes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvHatchcovers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCMU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabFooters.SuspendLayout()
        Me.tabPreview.SuspendLayout()
        Me.AddSL.SuspendLayout()
        Me.AddRemoveSL.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabVMR
        '
        Me.tabVMR.Controls.Add(Me.tabParticulars)
        Me.tabVMR.Controls.Add(Me.tabThroughput)
        Me.tabVMR.Controls.Add(Me.tabUnits)
        Me.tabVMR.Controls.Add(Me.tabCMU)
        Me.tabVMR.Controls.Add(Me.tabFooters)
        Me.tabVMR.Controls.Add(Me.tabPreview)
        Me.tabVMR.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.tabVMR.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.tabVMR.Location = New System.Drawing.Point(12, 12)
        Me.tabVMR.Name = "tabVMR"
        Me.tabVMR.SelectedIndex = 0
        Me.tabVMR.Size = New System.Drawing.Size(1326, 705)
        Me.tabVMR.TabIndex = 0
        '
        'tabParticulars
        '
        Me.tabParticulars.Controls.Add(Me.mskFormEnd)
        Me.tabParticulars.Controls.Add(Me.Label6)
        Me.tabParticulars.Controls.Add(Me.mskFormStart)
        Me.tabParticulars.Controls.Add(Me.Label5)
        Me.tabParticulars.Controls.Add(Me.mskPrincipal)
        Me.tabParticulars.Controls.Add(Me.Label4)
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
        Me.tabParticulars.Text = "Vessel Information"
        Me.tabParticulars.UseVisualStyleBackColor = True
        '
        'mskFormEnd
        '
        Me.mskFormEnd.Location = New System.Drawing.Point(923, 408)
        Me.mskFormEnd.Mask = "0000H 00/00/0000"
        Me.mskFormEnd.Name = "mskFormEnd"
        Me.mskFormEnd.Size = New System.Drawing.Size(205, 27)
        Me.mskFormEnd.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(712, 411)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(205, 22)
        Me.Label6.TabIndex = 101
        Me.Label6.Text = "Vessel Formalities (End)"
        '
        'mskFormStart
        '
        Me.mskFormStart.Location = New System.Drawing.Point(929, 371)
        Me.mskFormStart.Mask = "0000H 00/00/0000"
        Me.mskFormStart.Name = "mskFormStart"
        Me.mskFormStart.Size = New System.Drawing.Size(205, 27)
        Me.mskFormStart.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(712, 374)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(211, 22)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "Vessel Formalities (Start)"
        '
        'mskPrincipal
        '
        Me.mskPrincipal.Location = New System.Drawing.Point(897, 96)
        Me.mskPrincipal.Mask = "AAA"
        Me.mskPrincipal.Name = "mskPrincipal"
        Me.mskPrincipal.Size = New System.Drawing.Size(98, 27)
        Me.mskPrincipal.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(802, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 22)
        Me.Label4.TabIndex = 97
        Me.Label4.Text = "Principal: "
        '
        'mskATD
        '
        Me.mskATD.Location = New System.Drawing.Point(950, 316)
        Me.mskATD.Mask = "0000H 00/00/0000"
        Me.mskATD.Name = "mskATD"
        Me.mskATD.Size = New System.Drawing.Size(205, 27)
        Me.mskATD.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(710, 319)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 22)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Actual Time of Arrival (ATD)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'mskATA
        '
        Me.mskATA.Location = New System.Drawing.Point(950, 261)
        Me.mskATA.Mask = "0000H 00/00/0000"
        Me.mskATA.Name = "mskATA"
        Me.mskATA.Size = New System.Drawing.Size(205, 27)
        Me.mskATA.TabIndex = 9
        '
        'lblATA
        '
        Me.lblATA.AutoSize = True
        Me.lblATA.Location = New System.Drawing.Point(710, 264)
        Me.lblATA.Name = "lblATA"
        Me.lblATA.Size = New System.Drawing.Size(234, 22)
        Me.lblATA.TabIndex = 17
        Me.lblATA.Text = "Actual Time of Arrival (ATA)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'mskETA
        '
        Me.mskETA.Location = New System.Drawing.Point(981, 206)
        Me.mskETA.Mask = "0000H 00/00/0000"
        Me.mskETA.Name = "mskETA"
        Me.mskETA.Size = New System.Drawing.Size(205, 27)
        Me.mskETA.TabIndex = 8
        Me.mskETA.ValidatingType = GetType(Date)
        '
        'lblETA
        '
        Me.lblETA.AutoSize = True
        Me.lblETA.Location = New System.Drawing.Point(712, 209)
        Me.lblETA.Name = "lblETA"
        Me.lblETA.Size = New System.Drawing.Size(263, 22)
        Me.lblETA.TabIndex = 15
        Me.lblETA.Text = "Estimated Time of Arrival (ETA)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'mskOvertime
        '
        Me.mskOvertime.Location = New System.Drawing.Point(876, 151)
        Me.mskOvertime.Mask = "0000H 00/00/0000"
        Me.mskOvertime.Name = "mskOvertime"
        Me.mskOvertime.Size = New System.Drawing.Size(205, 27)
        Me.mskOvertime.TabIndex = 7
        '
        'mskSLGang
        '
        Me.mskSLGang.Location = New System.Drawing.Point(297, 396)
        Me.mskSLGang.Mask = "0000H 00/00/0000"
        Me.mskSLGang.Name = "mskSLGang"
        Me.mskSLGang.Size = New System.Drawing.Size(205, 27)
        Me.mskSLGang.TabIndex = 6
        '
        'mskPier
        '
        Me.mskPier.Location = New System.Drawing.Point(284, 321)
        Me.mskPier.Name = "mskPier"
        Me.mskPier.Size = New System.Drawing.Size(188, 27)
        Me.mskPier.TabIndex = 5
        '
        'mskRegistry
        '
        Me.mskRegistry.Location = New System.Drawing.Point(283, 246)
        Me.mskRegistry.Name = "mskRegistry"
        Me.mskRegistry.Size = New System.Drawing.Size(194, 27)
        Me.mskRegistry.TabIndex = 4
        '
        'mskVoyage
        '
        Me.mskVoyage.Location = New System.Drawing.Point(278, 171)
        Me.mskVoyage.Name = "mskVoyage"
        Me.mskVoyage.Size = New System.Drawing.Size(194, 27)
        Me.mskVoyage.TabIndex = 3
        '
        'mskVessel
        '
        Me.mskVessel.Location = New System.Drawing.Point(255, 96)
        Me.mskVessel.Name = "mskVessel"
        Me.mskVessel.Size = New System.Drawing.Size(535, 27)
        Me.mskVessel.TabIndex = 1
        '
        'lblOvertime
        '
        Me.lblOvertime.AutoSize = True
        Me.lblOvertime.Location = New System.Drawing.Point(712, 154)
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
        Me.cmdNextPart.TabIndex = 99
        Me.cmdNextPart.Text = "Next (F11)"
        Me.cmdNextPart.UseVisualStyleBackColor = True
        '
        'cmdExitPart
        '
        Me.cmdExitPart.Location = New System.Drawing.Point(62, 569)
        Me.cmdExitPart.Name = "cmdExitPart"
        Me.cmdExitPart.Size = New System.Drawing.Size(164, 43)
        Me.cmdExitPart.TabIndex = 99
        Me.cmdExitPart.Text = "Exit (F3)"
        Me.cmdExitPart.UseVisualStyleBackColor = True
        '
        'tabThroughput
        '
        Me.tabThroughput.Controls.Add(Me.mskStandby)
        Me.tabThroughput.Controls.Add(Me.Label2)
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
        Me.tabThroughput.Text = "Time Details"
        Me.tabThroughput.UseVisualStyleBackColor = True
        '
        'mskStandby
        '
        Me.mskStandby.Location = New System.Drawing.Point(379, 379)
        Me.mskStandby.Mask = "0000H 00/00/0000"
        Me.mskStandby.Name = "mskStandby"
        Me.mskStandby.Size = New System.Drawing.Size(205, 27)
        Me.mskStandby.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(102, 384)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(271, 22)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "Standby Waiting Time for Vessel"
        '
        'mskLastLoaded
        '
        Me.mskLastLoaded.Location = New System.Drawing.Point(365, 322)
        Me.mskLastLoaded.Mask = "0000H 00/00/0000"
        Me.mskLastLoaded.Name = "mskLastLoaded"
        Me.mskLastLoaded.Size = New System.Drawing.Size(205, 27)
        Me.mskLastLoaded.TabIndex = 5
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
        Me.mskFirstLoaded.TabIndex = 4
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
        Me.mskLastDischarged.TabIndex = 3
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
        Me.mskFirstDischarged.TabIndex = 2
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
        Me.mskOpCommenced.TabIndex = 1
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
        Me.mskTimeComplete.TabIndex = 10
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
        Me.mskDateComplete.TabIndex = 9
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
        Me.mskRegulars.TabIndex = 8
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
        Me.mskOnCallSV.HidePromptOnLeave = True
        Me.mskOnCallSV.Location = New System.Drawing.Point(1011, 133)
        Me.mskOnCallSV.Mask = "00\ \G\A\N\G"
        Me.mskOnCallSV.Name = "mskOnCallSV"
        Me.mskOnCallSV.Size = New System.Drawing.Size(205, 27)
        Me.mskOnCallSV.TabIndex = 7
        Me.mskOnCallSV.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
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
        Me.cmdNextTpt.TabIndex = 99
        Me.cmdNextTpt.Text = "Next (F11)"
        Me.cmdNextTpt.UseVisualStyleBackColor = True
        '
        'cmdPrevTpt
        '
        Me.cmdPrevTpt.Location = New System.Drawing.Point(930, 569)
        Me.cmdPrevTpt.Name = "cmdPrevTpt"
        Me.cmdPrevTpt.Size = New System.Drawing.Size(164, 43)
        Me.cmdPrevTpt.TabIndex = 99
        Me.cmdPrevTpt.Text = "Prev (F10)"
        Me.cmdPrevTpt.UseVisualStyleBackColor = True
        '
        'cmdExitTpt
        '
        Me.cmdExitTpt.Location = New System.Drawing.Point(62, 569)
        Me.cmdExitTpt.Name = "cmdExitTpt"
        Me.cmdExitTpt.Size = New System.Drawing.Size(164, 43)
        Me.cmdExitTpt.TabIndex = 99
        Me.cmdExitTpt.Text = "Exit (F3)"
        Me.cmdExitTpt.UseVisualStyleBackColor = True
        '
        'tabUnits
        '
        Me.tabUnits.Controls.Add(Me.cmbCategory)
        Me.tabUnits.Controls.Add(Me.tabUnitBreakdown)
        Me.tabUnits.Location = New System.Drawing.Point(4, 29)
        Me.tabUnits.Name = "tabUnits"
        Me.tabUnits.Padding = New System.Windows.Forms.Padding(3)
        Me.tabUnits.Size = New System.Drawing.Size(1318, 672)
        Me.tabUnits.TabIndex = 7
        Me.tabUnits.Text = "Units Breakdown"
        Me.tabUnits.UseVisualStyleBackColor = True
        '
        'cmbCategory
        '
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Items.AddRange(New Object() {"Inbound", "Outbound"})
        Me.cmbCategory.Location = New System.Drawing.Point(10, 6)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(233, 28)
        Me.cmbCategory.TabIndex = 1
        '
        'tabUnitBreakdown
        '
        Me.tabUnitBreakdown.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabUnitBreakdown.Controls.Add(Me.tabInbound)
        Me.tabUnitBreakdown.Controls.Add(Me.tabOutbound)
        Me.tabUnitBreakdown.ItemSize = New System.Drawing.Size(0, 1)
        Me.tabUnitBreakdown.Location = New System.Drawing.Point(6, 40)
        Me.tabUnitBreakdown.Name = "tabUnitBreakdown"
        Me.tabUnitBreakdown.SelectedIndex = 0
        Me.tabUnitBreakdown.Size = New System.Drawing.Size(1306, 626)
        Me.tabUnitBreakdown.TabIndex = 0
        '
        'tabInbound
        '
        Me.tabInbound.Controls.Add(Me.tabInboundBreakdown)
        Me.tabInbound.Location = New System.Drawing.Point(4, 14)
        Me.tabInbound.Name = "tabInbound"
        Me.tabInbound.Padding = New System.Windows.Forms.Padding(3)
        Me.tabInbound.Size = New System.Drawing.Size(1298, 608)
        Me.tabInbound.TabIndex = 0
        Me.tabInbound.Text = "Inbound"
        Me.tabInbound.UseVisualStyleBackColor = True
        '
        'tabInboundBreakdown
        '
        Me.tabInboundBreakdown.Controls.Add(Me.TabPage4)
        Me.tabInboundBreakdown.Location = New System.Drawing.Point(6, 6)
        Me.tabInboundBreakdown.Name = "tabInboundBreakdown"
        Me.tabInboundBreakdown.SelectedIndex = 0
        Me.tabInboundBreakdown.Size = New System.Drawing.Size(1289, 599)
        Me.tabInboundBreakdown.TabIndex = 2
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 29)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1281, 566)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "Shipping Line"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'tabOutbound
        '
        Me.tabOutbound.Controls.Add(Me.tabOutboundBreakdown)
        Me.tabOutbound.Location = New System.Drawing.Point(4, 5)
        Me.tabOutbound.Name = "tabOutbound"
        Me.tabOutbound.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOutbound.Size = New System.Drawing.Size(1298, 617)
        Me.tabOutbound.TabIndex = 1
        Me.tabOutbound.Text = "Outbound"
        Me.tabOutbound.UseVisualStyleBackColor = True
        '
        'tabOutboundBreakdown
        '
        Me.tabOutboundBreakdown.Controls.Add(Me.TabPage5)
        Me.tabOutboundBreakdown.Location = New System.Drawing.Point(6, 6)
        Me.tabOutboundBreakdown.Name = "tabOutboundBreakdown"
        Me.tabOutboundBreakdown.SelectedIndex = 0
        Me.tabOutboundBreakdown.Size = New System.Drawing.Size(1286, 596)
        Me.tabOutboundBreakdown.TabIndex = 102
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 29)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1278, 563)
        Me.TabPage5.TabIndex = 0
        Me.TabPage5.Text = "TabPage5"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'tabCMU
        '
        Me.tabCMU.Controls.Add(Me.cmdChargeReset)
        Me.tabCMU.Controls.Add(Me.cmdNextCMU)
        Me.tabCMU.Controls.Add(Me.cmdPrevCMU)
        Me.tabCMU.Controls.Add(Me.cmdExitCMU)
        Me.tabCMU.Controls.Add(Me.tabSpecificCMU)
        Me.tabCMU.Controls.Add(Me.dgvCMU)
        Me.tabCMU.Location = New System.Drawing.Point(4, 29)
        Me.tabCMU.Name = "tabCMU"
        Me.tabCMU.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCMU.Size = New System.Drawing.Size(1318, 672)
        Me.tabCMU.TabIndex = 6
        Me.tabCMU.Text = "Shiftings"
        Me.tabCMU.UseVisualStyleBackColor = True
        '
        'cmdChargeReset
        '
        Me.cmdChargeReset.Location = New System.Drawing.Point(740, 569)
        Me.cmdChargeReset.Name = "cmdChargeReset"
        Me.cmdChargeReset.Size = New System.Drawing.Size(164, 43)
        Me.cmdChargeReset.TabIndex = 100
        Me.cmdChargeReset.Text = "Reset"
        Me.cmdChargeReset.UseVisualStyleBackColor = True
        '
        'cmdNextCMU
        '
        Me.cmdNextCMU.Location = New System.Drawing.Point(1100, 569)
        Me.cmdNextCMU.Name = "cmdNextCMU"
        Me.cmdNextCMU.Size = New System.Drawing.Size(164, 43)
        Me.cmdNextCMU.TabIndex = 99
        Me.cmdNextCMU.Text = "Next (F11)"
        Me.cmdNextCMU.UseVisualStyleBackColor = True
        '
        'cmdPrevCMU
        '
        Me.cmdPrevCMU.Location = New System.Drawing.Point(930, 569)
        Me.cmdPrevCMU.Name = "cmdPrevCMU"
        Me.cmdPrevCMU.Size = New System.Drawing.Size(164, 43)
        Me.cmdPrevCMU.TabIndex = 99
        Me.cmdPrevCMU.Text = "Prev (F10)"
        Me.cmdPrevCMU.UseVisualStyleBackColor = True
        '
        'cmdExitCMU
        '
        Me.cmdExitCMU.Location = New System.Drawing.Point(62, 569)
        Me.cmdExitCMU.Name = "cmdExitCMU"
        Me.cmdExitCMU.Size = New System.Drawing.Size(164, 43)
        Me.cmdExitCMU.TabIndex = 99
        Me.cmdExitCMU.Text = "Exit (F3)"
        Me.cmdExitCMU.UseVisualStyleBackColor = True
        '
        'tabSpecificCMU
        '
        Me.tabSpecificCMU.Controls.Add(Me.TabPage1)
        Me.tabSpecificCMU.Controls.Add(Me.TabPage2)
        Me.tabSpecificCMU.Controls.Add(Me.TabPage3)
        Me.tabSpecificCMU.Location = New System.Drawing.Point(6, 259)
        Me.tabSpecificCMU.Name = "tabSpecificCMU"
        Me.tabSpecificCMU.SelectedIndex = 0
        Me.tabSpecificCMU.Size = New System.Drawing.Size(1306, 304)
        Me.tabSpecificCMU.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.mskOwner)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.dgvContainers)
        Me.TabPage1.Controls.Add(Me.mskBoxes)
        Me.TabPage1.Controls.Add(Me.cmbSizes)
        Me.TabPage1.Controls.Add(Me.cmbFreight)
        Me.TabPage1.Controls.Add(Me.cmbUnits)
        Me.TabPage1.Controls.Add(Me.cmbMoveKinds)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1298, 271)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Container"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(1027, 3)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 45)
        Me.Label13.TabIndex = 101
        Me.Label13.Text = "Boxes"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(900, 3)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(121, 45)
        Me.Label12.TabIndex = 100
        Me.Label12.Text = "Size"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(773, 3)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 45)
        Me.Label11.TabIndex = 99
        Me.Label11.Text = "Freight"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(552, 3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(215, 45)
        Me.Label10.TabIndex = 98
        Me.Label10.Text = "Unit Kind"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(425, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 45)
        Me.Label9.TabIndex = 97
        Me.Label9.Text = "Move Kind"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mskOwner
        '
        Me.mskOwner.Location = New System.Drawing.Point(284, 51)
        Me.mskOwner.Mask = "AAA"
        Me.mskOwner.Name = "mskOwner"
        Me.mskOwner.Size = New System.Drawing.Size(98, 27)
        Me.mskOwner.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(172, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 22)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "Charge To: "
        '
        'dgvContainers
        '
        Me.dgvContainers.AllowUserToAddRows = False
        Me.dgvContainers.AllowUserToOrderColumns = True
        Me.dgvContainers.AllowUserToResizeColumns = False
        Me.dgvContainers.AllowUserToResizeRows = False
        Me.dgvContainers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContainers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.line_op2, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.dgvContainers.Location = New System.Drawing.Point(6, 85)
        Me.dgvContainers.Name = "dgvContainers"
        Me.dgvContainers.Size = New System.Drawing.Size(1286, 180)
        Me.dgvContainers.TabIndex = 7
        '
        'line_op2
        '
        Me.line_op2.DataPropertyName = "Line"
        Me.line_op2.HeaderText = "Line"
        Me.line_op2.Name = "line_op2"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "move_kind"
        Me.DataGridViewTextBoxColumn1.FillWeight = 47.71573!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Move Kind"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "description"
        Me.DataGridViewTextBoxColumn2.FillWeight = 152.2843!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'mskBoxes
        '
        Me.mskBoxes.Location = New System.Drawing.Point(1027, 51)
        Me.mskBoxes.Name = "mskBoxes"
        Me.mskBoxes.Size = New System.Drawing.Size(100, 27)
        Me.mskBoxes.TabIndex = 6
        '
        'cmbSizes
        '
        Me.cmbSizes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSizes.FormattingEnabled = True
        Me.cmbSizes.Items.AddRange(New Object() {"20", "40", "45"})
        Me.cmbSizes.Location = New System.Drawing.Point(900, 51)
        Me.cmbSizes.Name = "cmbSizes"
        Me.cmbSizes.Size = New System.Drawing.Size(121, 28)
        Me.cmbSizes.TabIndex = 5
        '
        'cmbFreight
        '
        Me.cmbFreight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFreight.FormattingEnabled = True
        Me.cmbFreight.Items.AddRange(New Object() {"FULL", "EMPTY"})
        Me.cmbFreight.Location = New System.Drawing.Point(773, 51)
        Me.cmbFreight.Name = "cmbFreight"
        Me.cmbFreight.Size = New System.Drawing.Size(121, 28)
        Me.cmbFreight.TabIndex = 4
        '
        'cmbUnits
        '
        Me.cmbUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUnits.FormattingEnabled = True
        Me.cmbUnits.Items.AddRange(New Object() {"DRY", "REEFER", "FLAT RACK", "OPEN TOP ", "TANK TAINER"})
        Me.cmbUnits.Location = New System.Drawing.Point(552, 51)
        Me.cmbUnits.Name = "cmbUnits"
        Me.cmbUnits.Size = New System.Drawing.Size(215, 28)
        Me.cmbUnits.TabIndex = 3
        '
        'cmbMoveKinds
        '
        Me.cmbMoveKinds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMoveKinds.FormattingEnabled = True
        Me.cmbMoveKinds.Items.AddRange(New Object() {"SVD", "SOB"})
        Me.cmbMoveKinds.Location = New System.Drawing.Point(425, 51)
        Me.cmbMoveKinds.Name = "cmbMoveKinds"
        Me.cmbMoveKinds.Size = New System.Drawing.Size(121, 28)
        Me.cmbMoveKinds.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.mskBayGB)
        Me.TabPage2.Controls.Add(Me.cmbSizesGB)
        Me.TabPage2.Controls.Add(Me.mskCharge2)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.mskGearbox)
        Me.TabPage2.Controls.Add(Me.dgvGearboxes)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1298, 271)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Gearbox"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(850, 3)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 45)
        Me.Label14.TabIndex = 108
        Me.Label14.Text = "Boxes"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(744, 3)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 45)
        Me.Label15.TabIndex = 107
        Me.Label15.Text = "Bay"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(617, 3)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(121, 45)
        Me.Label16.TabIndex = 106
        Me.Label16.Text = "Size"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mskBayGB
        '
        Me.mskBayGB.Location = New System.Drawing.Point(744, 52)
        Me.mskBayGB.Name = "mskBayGB"
        Me.mskBayGB.Size = New System.Drawing.Size(100, 27)
        Me.mskBayGB.TabIndex = 3
        '
        'cmbSizesGB
        '
        Me.cmbSizesGB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSizesGB.FormattingEnabled = True
        Me.cmbSizesGB.Items.AddRange(New Object() {"20", "40"})
        Me.cmbSizesGB.Location = New System.Drawing.Point(617, 52)
        Me.cmbSizesGB.Name = "cmbSizesGB"
        Me.cmbSizesGB.Size = New System.Drawing.Size(121, 28)
        Me.cmbSizesGB.TabIndex = 2
        '
        'mskCharge2
        '
        Me.mskCharge2.Location = New System.Drawing.Point(460, 52)
        Me.mskCharge2.Mask = "AAA"
        Me.mskCharge2.Name = "mskCharge2"
        Me.mskCharge2.Size = New System.Drawing.Size(98, 27)
        Me.mskCharge2.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(348, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 22)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "Charge To: "
        '
        'mskGearbox
        '
        Me.mskGearbox.Location = New System.Drawing.Point(850, 52)
        Me.mskGearbox.Name = "mskGearbox"
        Me.mskGearbox.Size = New System.Drawing.Size(100, 27)
        Me.mskGearbox.TabIndex = 4
        '
        'dgvGearboxes
        '
        Me.dgvGearboxes.AllowUserToAddRows = False
        Me.dgvGearboxes.AllowUserToOrderColumns = True
        Me.dgvGearboxes.AllowUserToResizeColumns = False
        Me.dgvGearboxes.AllowUserToResizeRows = False
        Me.dgvGearboxes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGearboxes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.dgvGearboxes.Location = New System.Drawing.Point(6, 85)
        Me.dgvGearboxes.Name = "dgvGearboxes"
        Me.dgvGearboxes.Size = New System.Drawing.Size(1286, 180)
        Me.dgvGearboxes.TabIndex = 8
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Line"
        Me.Column1.HeaderText = "Line"
        Me.Column1.Name = "Column1"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "move_kind"
        Me.DataGridViewTextBoxColumn3.FillWeight = 47.71573!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Move Kind"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "description"
        Me.DataGridViewTextBoxColumn4.FillWeight = 152.2843!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Controls.Add(Me.mskBayHC)
        Me.TabPage3.Controls.Add(Me.mskCharge3)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.mskHatchcovers)
        Me.TabPage3.Controls.Add(Me.dgvHatchcovers)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1298, 271)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Hatchcover"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(826, 4)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 45)
        Me.Label17.TabIndex = 111
        Me.Label17.Text = "Boxes"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(720, 4)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(100, 45)
        Me.Label18.TabIndex = 110
        Me.Label18.Text = "Bay"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mskBayHC
        '
        Me.mskBayHC.Location = New System.Drawing.Point(720, 52)
        Me.mskBayHC.Name = "mskBayHC"
        Me.mskBayHC.Size = New System.Drawing.Size(100, 27)
        Me.mskBayHC.TabIndex = 2
        '
        'mskCharge3
        '
        Me.mskCharge3.Location = New System.Drawing.Point(484, 52)
        Me.mskCharge3.Mask = "AAA"
        Me.mskCharge3.Name = "mskCharge3"
        Me.mskCharge3.Size = New System.Drawing.Size(98, 27)
        Me.mskCharge3.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(372, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 22)
        Me.Label8.TabIndex = 102
        Me.Label8.Text = "Charge To: "
        '
        'mskHatchcovers
        '
        Me.mskHatchcovers.Location = New System.Drawing.Point(826, 52)
        Me.mskHatchcovers.Name = "mskHatchcovers"
        Me.mskHatchcovers.Size = New System.Drawing.Size(100, 27)
        Me.mskHatchcovers.TabIndex = 3
        '
        'dgvHatchcovers
        '
        Me.dgvHatchcovers.AllowUserToAddRows = False
        Me.dgvHatchcovers.AllowUserToOrderColumns = True
        Me.dgvHatchcovers.AllowUserToResizeColumns = False
        Me.dgvHatchcovers.AllowUserToResizeRows = False
        Me.dgvHatchcovers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHatchcovers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.dgvHatchcovers.Location = New System.Drawing.Point(6, 85)
        Me.dgvHatchcovers.Name = "dgvHatchcovers"
        Me.dgvHatchcovers.Size = New System.Drawing.Size(1286, 180)
        Me.dgvHatchcovers.TabIndex = 8
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Line"
        Me.Column2.HeaderText = "Line"
        Me.Column2.Name = "Column2"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "move_kind"
        Me.DataGridViewTextBoxColumn5.FillWeight = 47.71573!
        Me.DataGridViewTextBoxColumn5.HeaderText = "Move Kind"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "description"
        Me.DataGridViewTextBoxColumn6.FillWeight = 152.2843!
        Me.DataGridViewTextBoxColumn6.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'dgvCMU
        '
        Me.dgvCMU.AllowUserToAddRows = False
        Me.dgvCMU.AllowUserToDeleteRows = False
        Me.dgvCMU.AllowUserToOrderColumns = True
        Me.dgvCMU.AllowUserToResizeColumns = False
        Me.dgvCMU.AllowUserToResizeRows = False
        Me.dgvCMU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCMU.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.line_op, Me.move_kind, Me.description})
        Me.dgvCMU.Location = New System.Drawing.Point(6, 6)
        Me.dgvCMU.Name = "dgvCMU"
        Me.dgvCMU.Size = New System.Drawing.Size(1309, 247)
        Me.dgvCMU.TabIndex = 0
        '
        'line_op
        '
        Me.line_op.DataPropertyName = "Line"
        Me.line_op.HeaderText = "Line"
        Me.line_op.Name = "line_op"
        '
        'move_kind
        '
        Me.move_kind.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.move_kind.DataPropertyName = "move_kind"
        Me.move_kind.FillWeight = 47.71573!
        Me.move_kind.HeaderText = "Move Kind"
        Me.move_kind.Name = "move_kind"
        '
        'description
        '
        Me.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.description.DataPropertyName = "description"
        Me.description.FillWeight = 152.2843!
        Me.description.HeaderText = "Description"
        Me.description.Name = "description"
        '
        'tabFooters
        '
        Me.tabFooters.Controls.Add(Me.mskVisor1)
        Me.tabFooters.Controls.Add(Me.mskChecker1)
        Me.tabFooters.Controls.Add(Me.mskOPCenter)
        Me.tabFooters.Controls.Add(Me.lblOPCenter)
        Me.tabFooters.Controls.Add(Me.mskAsstOP)
        Me.tabFooters.Controls.Add(Me.lblAsstOP)
        Me.tabFooters.Controls.Add(Me.mskVisor2)
        Me.tabFooters.Controls.Add(Me.lblSupervisor)
        Me.tabFooters.Controls.Add(Me.mskChecker2)
        Me.tabFooters.Controls.Add(Me.lblChecker)
        Me.tabFooters.Controls.Add(Me.cmdNextFoot)
        Me.tabFooters.Controls.Add(Me.cmdPrevFoot)
        Me.tabFooters.Controls.Add(Me.cmdExitFoot)
        Me.tabFooters.Location = New System.Drawing.Point(4, 29)
        Me.tabFooters.Name = "tabFooters"
        Me.tabFooters.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFooters.Size = New System.Drawing.Size(1318, 672)
        Me.tabFooters.TabIndex = 4
        Me.tabFooters.Text = "Signature"
        Me.tabFooters.UseVisualStyleBackColor = True
        '
        'mskVisor1
        '
        Me.mskVisor1.Location = New System.Drawing.Point(811, 107)
        Me.mskVisor1.Name = "mskVisor1"
        Me.mskVisor1.Size = New System.Drawing.Size(390, 27)
        Me.mskVisor1.TabIndex = 3
        '
        'mskChecker1
        '
        Me.mskChecker1.Location = New System.Drawing.Point(117, 107)
        Me.mskChecker1.Name = "mskChecker1"
        Me.mskChecker1.Size = New System.Drawing.Size(390, 27)
        Me.mskChecker1.TabIndex = 1
        '
        'mskOPCenter
        '
        Me.mskOPCenter.Location = New System.Drawing.Point(458, 365)
        Me.mskOPCenter.Name = "mskOPCenter"
        Me.mskOPCenter.Size = New System.Drawing.Size(390, 27)
        Me.mskOPCenter.TabIndex = 6
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
        Me.mskAsstOP.TabIndex = 5
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
        'mskVisor2
        '
        Me.mskVisor2.Location = New System.Drawing.Point(811, 151)
        Me.mskVisor2.Name = "mskVisor2"
        Me.mskVisor2.Size = New System.Drawing.Size(390, 27)
        Me.mskVisor2.TabIndex = 4
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
        'mskChecker2
        '
        Me.mskChecker2.Location = New System.Drawing.Point(117, 151)
        Me.mskChecker2.Name = "mskChecker2"
        Me.mskChecker2.Size = New System.Drawing.Size(390, 27)
        Me.mskChecker2.TabIndex = 2
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
        Me.cmdNextFoot.TabIndex = 99
        Me.cmdNextFoot.Text = "Next (F11)"
        Me.cmdNextFoot.UseVisualStyleBackColor = True
        '
        'cmdPrevFoot
        '
        Me.cmdPrevFoot.Location = New System.Drawing.Point(930, 569)
        Me.cmdPrevFoot.Name = "cmdPrevFoot"
        Me.cmdPrevFoot.Size = New System.Drawing.Size(164, 43)
        Me.cmdPrevFoot.TabIndex = 99
        Me.cmdPrevFoot.Text = "Prev (F10)"
        Me.cmdPrevFoot.UseVisualStyleBackColor = True
        '
        'cmdExitFoot
        '
        Me.cmdExitFoot.Location = New System.Drawing.Point(62, 569)
        Me.cmdExitFoot.Name = "cmdExitFoot"
        Me.cmdExitFoot.Size = New System.Drawing.Size(164, 43)
        Me.cmdExitFoot.TabIndex = 99
        Me.cmdExitFoot.Text = "Exit (F3)"
        Me.cmdExitFoot.UseVisualStyleBackColor = True
        '
        'tabPreview
        '
        Me.tabPreview.Controls.Add(Me.cmdSave)
        Me.tabPreview.Controls.Add(Me.cmdPrint)
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
        Me.cmdSave.Location = New System.Drawing.Point(1100, 520)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(164, 43)
        Me.cmdSave.TabIndex = 2
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(1100, 569)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(164, 43)
        Me.cmdPrint.TabIndex = 1
        Me.cmdPrint.Text = "Print"
        Me.cmdPrint.UseVisualStyleBackColor = True
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
        'AddSL
        '
        Me.AddSL.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddShippingLineToolStripMenuItem1})
        Me.AddSL.Name = "AddSL"
        Me.AddSL.Size = New System.Drawing.Size(172, 26)
        '
        'AddShippingLineToolStripMenuItem1
        '
        Me.AddShippingLineToolStripMenuItem1.Name = "AddShippingLineToolStripMenuItem1"
        Me.AddShippingLineToolStripMenuItem1.Size = New System.Drawing.Size(171, 22)
        Me.AddShippingLineToolStripMenuItem1.Text = "Add Shipping Line"
        '
        'AddRemoveSL
        '
        Me.AddRemoveSL.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddShippingLineToolStripMenuItem, Me.RemoveShippingLineToolStripMenuItem})
        Me.AddRemoveSL.Name = "AddRemoveSL"
        Me.AddRemoveSL.Size = New System.Drawing.Size(193, 48)
        '
        'AddShippingLineToolStripMenuItem
        '
        Me.AddShippingLineToolStripMenuItem.Name = "AddShippingLineToolStripMenuItem"
        Me.AddShippingLineToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.AddShippingLineToolStripMenuItem.Text = "Add Shipping Line"
        '
        'RemoveShippingLineToolStripMenuItem
        '
        Me.RemoveShippingLineToolStripMenuItem.Name = "RemoveShippingLineToolStripMenuItem"
        Me.RemoveShippingLineToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.RemoveShippingLineToolStripMenuItem.Text = "Remove Shipping Line"
        '
        'VMRForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.tabVMR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VMRForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.tabVMR.ResumeLayout(False)
        Me.tabParticulars.ResumeLayout(False)
        Me.tabParticulars.PerformLayout()
        Me.tabThroughput.ResumeLayout(False)
        Me.tabThroughput.PerformLayout()
        Me.tabUnits.ResumeLayout(False)
        Me.tabUnitBreakdown.ResumeLayout(False)
        Me.tabInbound.ResumeLayout(False)
        Me.tabInboundBreakdown.ResumeLayout(False)
        Me.tabOutbound.ResumeLayout(False)
        Me.tabOutboundBreakdown.ResumeLayout(False)
        Me.tabCMU.ResumeLayout(False)
        Me.tabSpecificCMU.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvContainers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvGearboxes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dgvHatchcovers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCMU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabFooters.ResumeLayout(False)
        Me.tabFooters.PerformLayout()
        Me.tabPreview.ResumeLayout(False)
        Me.AddSL.ResumeLayout(False)
        Me.AddRemoveSL.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabVMR As TabControl
    Friend WithEvents tabParticulars As Windows.Forms.TabPage
    Friend WithEvents tabThroughput As Windows.Forms.TabPage
    Friend WithEvents tabFooters As Windows.Forms.TabPage
    Friend WithEvents lblVoyage As Label
    Friend WithEvents lblVessel As Label
    Friend WithEvents cmdNextPart As Button
    Friend WithEvents cmdExitPart As Button
    Friend WithEvents cmdNextTpt As Button
    Friend WithEvents cmdPrevTpt As Button
    Friend WithEvents cmdExitTpt As Button
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
    Friend WithEvents mskVisor2 As MaskedTextBox
    Friend WithEvents lblSupervisor As Label
    Friend WithEvents mskChecker2 As MaskedTextBox
    Friend WithEvents lblChecker As Label
    Friend WithEvents tabPreview As Windows.Forms.TabPage
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cmdPrint As Button
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
    Friend WithEvents mskVisor1 As MaskedTextBox
    Friend WithEvents mskChecker1 As MaskedTextBox
    Friend WithEvents tabCMU As Windows.Forms.TabPage
    Friend WithEvents dgvCMU As DataGridView
    Friend WithEvents tabSpecificCMU As TabControl
    Friend WithEvents TabPage1 As Windows.Forms.TabPage
    Friend WithEvents dgvContainers As DataGridView
    Friend WithEvents mskBoxes As MaskedTextBox
    Friend WithEvents cmbSizes As ComboBox
    Friend WithEvents cmbFreight As ComboBox
    Friend WithEvents cmbUnits As ComboBox
    Friend WithEvents cmbMoveKinds As ComboBox
    Friend WithEvents TabPage2 As Windows.Forms.TabPage
    Friend WithEvents dgvGearboxes As DataGridView
    Friend WithEvents TabPage3 As Windows.Forms.TabPage
    Friend WithEvents dgvHatchcovers As DataGridView
    Friend WithEvents mskStandby As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents mskOwner As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents line_op2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents line_op As DataGridViewTextBoxColumn
    Friend WithEvents move_kind As DataGridViewTextBoxColumn
    Friend WithEvents description As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents mskPrincipal As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents mskFormStart As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents mskFormEnd As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents mskCharge2 As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents mskGearbox As MaskedTextBox
    Friend WithEvents mskCharge3 As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents mskHatchcovers As MaskedTextBox
    Friend WithEvents cmbSizesGB As ComboBox
    Friend WithEvents mskBayGB As MaskedTextBox
    Friend WithEvents mskBayHC As MaskedTextBox
    Friend WithEvents cmdNextCMU As Button
    Friend WithEvents cmdPrevCMU As Button
    Friend WithEvents cmdExitCMU As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents tabUnits As Windows.Forms.TabPage
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmdChargeReset As Button
    Friend WithEvents tabUnitBreakdown As TabControl
    Friend WithEvents tabInbound As Windows.Forms.TabPage
    Friend WithEvents tabOutbound As Windows.Forms.TabPage
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents tabInboundBreakdown As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents tabOutboundBreakdown As TabControl
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents AddSL As ContextMenuStrip
    Friend WithEvents AddShippingLineToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AddRemoveSL As ContextMenuStrip
    Friend WithEvents AddShippingLineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveShippingLineToolStripMenuItem As ToolStripMenuItem
End Class
