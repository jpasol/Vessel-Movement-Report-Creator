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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabInbound = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.tabInboundFCL = New System.Windows.Forms.TabPage()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdInboundFCL = New System.Windows.Forms.Button()
        Me.mskInboundFCL = New System.Windows.Forms.MaskedTextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tabInboundMTY = New System.Windows.Forms.TabPage()
        Me.DataGridView6 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView7 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView8 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView9 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.DataGridView10 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdInboundMTY = New System.Windows.Forms.Button()
        Me.mskInboundMTY = New System.Windows.Forms.MaskedTextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.tabOutbound = New System.Windows.Forms.TabPage()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.tabOutboundFCL = New System.Windows.Forms.TabPage()
        Me.DataGridView11 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView12 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView13 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView14 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.DataGridView15 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdOutboundFCL = New System.Windows.Forms.Button()
        Me.mskOutboundFCL = New System.Windows.Forms.MaskedTextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.tabOutboundMTY = New System.Windows.Forms.TabPage()
        Me.DataGridView16 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView17 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView18 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView19 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.DataGridView20 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn59 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn60 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn61 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn62 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdOutboundMTY = New System.Windows.Forms.Button()
        Me.mskOutboundMTY = New System.Windows.Forms.MaskedTextBox()
        Me.Label42 = New System.Windows.Forms.Label()
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
        Me.tabVMR.SuspendLayout()
        Me.tabParticulars.SuspendLayout()
        Me.tabThroughput.SuspendLayout()
        Me.tabUnits.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabInbound.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.tabInboundFCL.SuspendLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabInboundMTY.SuspendLayout()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabOutbound.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.tabOutboundFCL.SuspendLayout()
        CType(Me.DataGridView11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabOutboundMTY.SuspendLayout()
        CType(Me.DataGridView16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView20, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabParticulars.Text = "Vessel Particulars"
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
        Me.tabThroughput.Text = "Other Particulars"
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
        Me.tabUnits.Controls.Add(Me.TabControl1)
        Me.tabUnits.Location = New System.Drawing.Point(4, 29)
        Me.tabUnits.Name = "tabUnits"
        Me.tabUnits.Padding = New System.Windows.Forms.Padding(3)
        Me.tabUnits.Size = New System.Drawing.Size(1318, 672)
        Me.tabUnits.TabIndex = 7
        Me.tabUnits.Text = "Units"
        Me.tabUnits.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabInbound)
        Me.TabControl1.Controls.Add(Me.tabOutbound)
        Me.TabControl1.Location = New System.Drawing.Point(6, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1306, 660)
        Me.TabControl1.TabIndex = 0
        '
        'tabInbound
        '
        Me.tabInbound.Controls.Add(Me.TabControl2)
        Me.tabInbound.Location = New System.Drawing.Point(4, 29)
        Me.tabInbound.Name = "tabInbound"
        Me.tabInbound.Padding = New System.Windows.Forms.Padding(3)
        Me.tabInbound.Size = New System.Drawing.Size(1298, 627)
        Me.tabInbound.TabIndex = 0
        Me.tabInbound.Text = "Inbound"
        Me.tabInbound.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.tabInboundFCL)
        Me.TabControl2.Controls.Add(Me.tabInboundMTY)
        Me.TabControl2.Location = New System.Drawing.Point(6, 6)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1286, 615)
        Me.TabControl2.TabIndex = 1
        '
        'tabInboundFCL
        '
        Me.tabInboundFCL.Controls.Add(Me.DataGridView5)
        Me.tabInboundFCL.Controls.Add(Me.DataGridView4)
        Me.tabInboundFCL.Controls.Add(Me.DataGridView3)
        Me.tabInboundFCL.Controls.Add(Me.DataGridView2)
        Me.tabInboundFCL.Controls.Add(Me.Label24)
        Me.tabInboundFCL.Controls.Add(Me.Label23)
        Me.tabInboundFCL.Controls.Add(Me.Label22)
        Me.tabInboundFCL.Controls.Add(Me.Label21)
        Me.tabInboundFCL.Controls.Add(Me.Label20)
        Me.tabInboundFCL.Controls.Add(Me.DataGridView1)
        Me.tabInboundFCL.Controls.Add(Me.cmdInboundFCL)
        Me.tabInboundFCL.Controls.Add(Me.mskInboundFCL)
        Me.tabInboundFCL.Controls.Add(Me.Label19)
        Me.tabInboundFCL.Location = New System.Drawing.Point(4, 29)
        Me.tabInboundFCL.Name = "tabInboundFCL"
        Me.tabInboundFCL.Padding = New System.Windows.Forms.Padding(3)
        Me.tabInboundFCL.Size = New System.Drawing.Size(1278, 582)
        Me.tabInboundFCL.TabIndex = 0
        Me.tabInboundFCL.Text = "Loaded"
        Me.tabInboundFCL.UseVisualStyleBackColor = True
        '
        'DataGridView5
        '
        Me.DataGridView5.AllowUserToAddRows = False
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21})
        Me.DataGridView5.Location = New System.Drawing.Point(741, 383)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.Size = New System.Drawing.Size(317, 150)
        Me.DataGridView5.TabIndex = 16
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "line_op"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Line"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Opn20"
        Me.DataGridViewTextBoxColumn20.HeaderText = "20"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Opn40"
        Me.DataGridViewTextBoxColumn21.HeaderText = "40"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridView4
        '
        Me.DataGridView4.AllowUserToAddRows = False
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.DataGridView4.Location = New System.Drawing.Point(220, 383)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(317, 150)
        Me.DataGridView4.TabIndex = 15
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "line_op"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Line"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Tnk20"
        Me.DataGridViewTextBoxColumn16.HeaderText = "20"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.DataGridView3.Location = New System.Drawing.Point(940, 161)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(317, 150)
        Me.DataGridView3.TabIndex = 14
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "line_op"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Line"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Frk20"
        Me.DataGridViewTextBoxColumn12.HeaderText = "20"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Frk40"
        Me.DataGridViewTextBoxColumn13.HeaderText = "40"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.DataGridView2.Location = New System.Drawing.Point(481, 161)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(317, 150)
        Me.DataGridView2.TabIndex = 13
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "line_op"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Line"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Rfr20"
        Me.DataGridViewTextBoxColumn8.HeaderText = "20"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Rfr40"
        Me.DataGridViewTextBoxColumn9.HeaderText = "40"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'Label24
        '
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label24.Location = New System.Drawing.Point(741, 353)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(317, 27)
        Me.Label24.TabIndex = 12
        Me.Label24.Text = "Open Top"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label23.Location = New System.Drawing.Point(220, 353)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(317, 27)
        Me.Label23.TabIndex = 11
        Me.Label23.Text = "Tank Tainer"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Location = New System.Drawing.Point(940, 131)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(317, 27)
        Me.Label22.TabIndex = 10
        Me.Label22.Text = "Flat Rack"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.Location = New System.Drawing.Point(481, 131)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(317, 27)
        Me.Label21.TabIndex = 9
        Me.Label21.Text = "Reefer"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.Location = New System.Drawing.Point(22, 131)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(317, 27)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "Dry"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(22, 161)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(317, 150)
        Me.DataGridView1.TabIndex = 3
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.DataPropertyName = "line_op"
        Me.Column3.HeaderText = "Line"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.DataPropertyName = "Dry20"
        Me.Column4.HeaderText = "20"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.DataPropertyName = "Dry40"
        Me.Column5.HeaderText = "40"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.DataPropertyName = "Dry45"
        Me.Column6.HeaderText = "45"
        Me.Column6.Name = "Column6"
        '
        'cmdInboundFCL
        '
        Me.cmdInboundFCL.Location = New System.Drawing.Point(640, 69)
        Me.cmdInboundFCL.Name = "cmdInboundFCL"
        Me.cmdInboundFCL.Size = New System.Drawing.Size(108, 38)
        Me.cmdInboundFCL.TabIndex = 2
        Me.cmdInboundFCL.Text = "Add Line"
        Me.cmdInboundFCL.UseVisualStyleBackColor = True
        '
        'mskInboundFCL
        '
        Me.mskInboundFCL.Location = New System.Drawing.Point(534, 75)
        Me.mskInboundFCL.Mask = "AAA"
        Me.mskInboundFCL.Name = "mskInboundFCL"
        Me.mskInboundFCL.Size = New System.Drawing.Size(100, 27)
        Me.mskInboundFCL.TabIndex = 1
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(530, 49)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(104, 23)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Line"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabInboundMTY
        '
        Me.tabInboundMTY.Controls.Add(Me.DataGridView6)
        Me.tabInboundMTY.Controls.Add(Me.DataGridView7)
        Me.tabInboundMTY.Controls.Add(Me.DataGridView8)
        Me.tabInboundMTY.Controls.Add(Me.DataGridView9)
        Me.tabInboundMTY.Controls.Add(Me.Label25)
        Me.tabInboundMTY.Controls.Add(Me.Label26)
        Me.tabInboundMTY.Controls.Add(Me.Label27)
        Me.tabInboundMTY.Controls.Add(Me.Label28)
        Me.tabInboundMTY.Controls.Add(Me.Label29)
        Me.tabInboundMTY.Controls.Add(Me.DataGridView10)
        Me.tabInboundMTY.Controls.Add(Me.cmdInboundMTY)
        Me.tabInboundMTY.Controls.Add(Me.mskInboundMTY)
        Me.tabInboundMTY.Controls.Add(Me.Label30)
        Me.tabInboundMTY.Location = New System.Drawing.Point(4, 29)
        Me.tabInboundMTY.Name = "tabInboundMTY"
        Me.tabInboundMTY.Padding = New System.Windows.Forms.Padding(3)
        Me.tabInboundMTY.Size = New System.Drawing.Size(1278, 582)
        Me.tabInboundMTY.TabIndex = 1
        Me.tabInboundMTY.Text = "Empty"
        Me.tabInboundMTY.UseVisualStyleBackColor = True
        '
        'DataGridView6
        '
        Me.DataGridView6.AllowUserToAddRows = False
        Me.DataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView6.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn17})
        Me.DataGridView6.Location = New System.Drawing.Point(741, 383)
        Me.DataGridView6.Name = "DataGridView6"
        Me.DataGridView6.Size = New System.Drawing.Size(317, 150)
        Me.DataGridView6.TabIndex = 29
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "line_op"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Line"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Opn20"
        Me.DataGridViewTextBoxColumn14.HeaderText = "20"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Opn40"
        Me.DataGridViewTextBoxColumn17.HeaderText = "40"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridView7
        '
        Me.DataGridView7.AllowUserToAddRows = False
        Me.DataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView7.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn22})
        Me.DataGridView7.Location = New System.Drawing.Point(220, 383)
        Me.DataGridView7.Name = "DataGridView7"
        Me.DataGridView7.Size = New System.Drawing.Size(317, 150)
        Me.DataGridView7.TabIndex = 28
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "line_op"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Line"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Tnk20"
        Me.DataGridViewTextBoxColumn22.HeaderText = "20"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridView8
        '
        Me.DataGridView8.AllowUserToAddRows = False
        Me.DataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView8.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25})
        Me.DataGridView8.Location = New System.Drawing.Point(940, 161)
        Me.DataGridView8.Name = "DataGridView8"
        Me.DataGridView8.Size = New System.Drawing.Size(317, 150)
        Me.DataGridView8.TabIndex = 27
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "line_op"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Line"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Frk20"
        Me.DataGridViewTextBoxColumn24.HeaderText = "20"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "Frk40"
        Me.DataGridViewTextBoxColumn25.HeaderText = "40"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridView9
        '
        Me.DataGridView9.AllowUserToAddRows = False
        Me.DataGridView9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView9.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28})
        Me.DataGridView9.Location = New System.Drawing.Point(481, 161)
        Me.DataGridView9.Name = "DataGridView9"
        Me.DataGridView9.Size = New System.Drawing.Size(317, 150)
        Me.DataGridView9.TabIndex = 26
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "line_op"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Line"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "Rfr20"
        Me.DataGridViewTextBoxColumn27.HeaderText = "20"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "Rfr40"
        Me.DataGridViewTextBoxColumn28.HeaderText = "40"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'Label25
        '
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label25.Location = New System.Drawing.Point(741, 353)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(317, 27)
        Me.Label25.TabIndex = 25
        Me.Label25.Text = "Open Top"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label26.Location = New System.Drawing.Point(220, 353)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(317, 27)
        Me.Label26.TabIndex = 24
        Me.Label26.Text = "Tank Tainer"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label27.Location = New System.Drawing.Point(940, 131)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(317, 27)
        Me.Label27.TabIndex = 23
        Me.Label27.Text = "Flat Rack"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label28.Location = New System.Drawing.Point(481, 131)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(317, 27)
        Me.Label28.TabIndex = 22
        Me.Label28.Text = "Reefer"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label29.Location = New System.Drawing.Point(22, 131)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(317, 27)
        Me.Label29.TabIndex = 21
        Me.Label29.Text = "Dry"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView10
        '
        Me.DataGridView10.AllowUserToAddRows = False
        Me.DataGridView10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView10.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32})
        Me.DataGridView10.Location = New System.Drawing.Point(22, 161)
        Me.DataGridView10.Name = "DataGridView10"
        Me.DataGridView10.Size = New System.Drawing.Size(317, 150)
        Me.DataGridView10.TabIndex = 20
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "line_op"
        Me.DataGridViewTextBoxColumn29.HeaderText = "Line"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "Dry20"
        Me.DataGridViewTextBoxColumn30.HeaderText = "20"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "Dry40"
        Me.DataGridViewTextBoxColumn31.HeaderText = "40"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "Dry45"
        Me.DataGridViewTextBoxColumn32.HeaderText = "45"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'cmdInboundMTY
        '
        Me.cmdInboundMTY.Location = New System.Drawing.Point(640, 69)
        Me.cmdInboundMTY.Name = "cmdInboundMTY"
        Me.cmdInboundMTY.Size = New System.Drawing.Size(108, 38)
        Me.cmdInboundMTY.TabIndex = 2
        Me.cmdInboundMTY.Text = "Add Line"
        Me.cmdInboundMTY.UseVisualStyleBackColor = True
        '
        'mskInboundMTY
        '
        Me.mskInboundMTY.Location = New System.Drawing.Point(534, 75)
        Me.mskInboundMTY.Mask = "AAA"
        Me.mskInboundMTY.Name = "mskInboundMTY"
        Me.mskInboundMTY.Size = New System.Drawing.Size(100, 27)
        Me.mskInboundMTY.TabIndex = 1
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(530, 49)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(104, 23)
        Me.Label30.TabIndex = 17
        Me.Label30.Text = "Line"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabOutbound
        '
        Me.tabOutbound.Controls.Add(Me.TabControl3)
        Me.tabOutbound.Location = New System.Drawing.Point(4, 29)
        Me.tabOutbound.Name = "tabOutbound"
        Me.tabOutbound.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOutbound.Size = New System.Drawing.Size(1298, 627)
        Me.tabOutbound.TabIndex = 1
        Me.tabOutbound.Text = "Outbound"
        Me.tabOutbound.UseVisualStyleBackColor = True
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.tabOutboundFCL)
        Me.TabControl3.Controls.Add(Me.tabOutboundMTY)
        Me.TabControl3.Location = New System.Drawing.Point(6, 6)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(1286, 615)
        Me.TabControl3.TabIndex = 2
        '
        'tabOutboundFCL
        '
        Me.tabOutboundFCL.Controls.Add(Me.DataGridView11)
        Me.tabOutboundFCL.Controls.Add(Me.DataGridView12)
        Me.tabOutboundFCL.Controls.Add(Me.DataGridView13)
        Me.tabOutboundFCL.Controls.Add(Me.DataGridView14)
        Me.tabOutboundFCL.Controls.Add(Me.Label31)
        Me.tabOutboundFCL.Controls.Add(Me.Label32)
        Me.tabOutboundFCL.Controls.Add(Me.Label33)
        Me.tabOutboundFCL.Controls.Add(Me.Label34)
        Me.tabOutboundFCL.Controls.Add(Me.Label35)
        Me.tabOutboundFCL.Controls.Add(Me.DataGridView15)
        Me.tabOutboundFCL.Controls.Add(Me.cmdOutboundFCL)
        Me.tabOutboundFCL.Controls.Add(Me.mskOutboundFCL)
        Me.tabOutboundFCL.Controls.Add(Me.Label36)
        Me.tabOutboundFCL.Location = New System.Drawing.Point(4, 29)
        Me.tabOutboundFCL.Name = "tabOutboundFCL"
        Me.tabOutboundFCL.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOutboundFCL.Size = New System.Drawing.Size(1278, 582)
        Me.tabOutboundFCL.TabIndex = 0
        Me.tabOutboundFCL.Text = "Loaded"
        Me.tabOutboundFCL.UseVisualStyleBackColor = True
        '
        'DataGridView11
        '
        Me.DataGridView11.AllowUserToAddRows = False
        Me.DataGridView11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView11.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35})
        Me.DataGridView11.Location = New System.Drawing.Point(741, 383)
        Me.DataGridView11.Name = "DataGridView11"
        Me.DataGridView11.Size = New System.Drawing.Size(317, 150)
        Me.DataGridView11.TabIndex = 16
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "line_op"
        Me.DataGridViewTextBoxColumn33.HeaderText = "Line"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "Opn20"
        Me.DataGridViewTextBoxColumn34.HeaderText = "20"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "Opn40"
        Me.DataGridViewTextBoxColumn35.HeaderText = "40"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        '
        'DataGridView12
        '
        Me.DataGridView12.AllowUserToAddRows = False
        Me.DataGridView12.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView12.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37})
        Me.DataGridView12.Location = New System.Drawing.Point(220, 383)
        Me.DataGridView12.Name = "DataGridView12"
        Me.DataGridView12.Size = New System.Drawing.Size(317, 150)
        Me.DataGridView12.TabIndex = 15
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "line_op"
        Me.DataGridViewTextBoxColumn36.HeaderText = "Line"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "Tnk20"
        Me.DataGridViewTextBoxColumn37.HeaderText = "20"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        '
        'DataGridView13
        '
        Me.DataGridView13.AllowUserToAddRows = False
        Me.DataGridView13.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView13.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40})
        Me.DataGridView13.Location = New System.Drawing.Point(940, 161)
        Me.DataGridView13.Name = "DataGridView13"
        Me.DataGridView13.Size = New System.Drawing.Size(317, 150)
        Me.DataGridView13.TabIndex = 14
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "line_op"
        Me.DataGridViewTextBoxColumn38.HeaderText = "Line"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "Frk20"
        Me.DataGridViewTextBoxColumn39.HeaderText = "20"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "Frk40"
        Me.DataGridViewTextBoxColumn40.HeaderText = "40"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        '
        'DataGridView14
        '
        Me.DataGridView14.AllowUserToAddRows = False
        Me.DataGridView14.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView14.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn43})
        Me.DataGridView14.Location = New System.Drawing.Point(481, 161)
        Me.DataGridView14.Name = "DataGridView14"
        Me.DataGridView14.Size = New System.Drawing.Size(317, 150)
        Me.DataGridView14.TabIndex = 13
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "line_op"
        Me.DataGridViewTextBoxColumn41.HeaderText = "Line"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "Rfr20"
        Me.DataGridViewTextBoxColumn42.HeaderText = "20"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "Rfr40"
        Me.DataGridViewTextBoxColumn43.HeaderText = "40"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        '
        'Label31
        '
        Me.Label31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label31.Location = New System.Drawing.Point(741, 353)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(317, 27)
        Me.Label31.TabIndex = 12
        Me.Label31.Text = "Open Top"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label32
        '
        Me.Label32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label32.Location = New System.Drawing.Point(220, 353)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(317, 27)
        Me.Label32.TabIndex = 11
        Me.Label32.Text = "Tank Tainer"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label33
        '
        Me.Label33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label33.Location = New System.Drawing.Point(940, 131)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(317, 27)
        Me.Label33.TabIndex = 10
        Me.Label33.Text = "Flat Rack"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label34
        '
        Me.Label34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label34.Location = New System.Drawing.Point(481, 131)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(317, 27)
        Me.Label34.TabIndex = 9
        Me.Label34.Text = "Reefer"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label35
        '
        Me.Label35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label35.Location = New System.Drawing.Point(22, 131)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(317, 27)
        Me.Label35.TabIndex = 8
        Me.Label35.Text = "Dry"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView15
        '
        Me.DataGridView15.AllowUserToAddRows = False
        Me.DataGridView15.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView15.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn44, Me.DataGridViewTextBoxColumn45, Me.DataGridViewTextBoxColumn46, Me.DataGridViewTextBoxColumn47})
        Me.DataGridView15.Location = New System.Drawing.Point(22, 161)
        Me.DataGridView15.Name = "DataGridView15"
        Me.DataGridView15.Size = New System.Drawing.Size(317, 150)
        Me.DataGridView15.TabIndex = 3
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "line_op"
        Me.DataGridViewTextBoxColumn44.HeaderText = "Line"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "Dry20"
        Me.DataGridViewTextBoxColumn45.HeaderText = "20"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "Dry40"
        Me.DataGridViewTextBoxColumn46.HeaderText = "40"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "Dry45"
        Me.DataGridViewTextBoxColumn47.HeaderText = "45"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        '
        'cmdOutboundFCL
        '
        Me.cmdOutboundFCL.Location = New System.Drawing.Point(640, 69)
        Me.cmdOutboundFCL.Name = "cmdOutboundFCL"
        Me.cmdOutboundFCL.Size = New System.Drawing.Size(108, 38)
        Me.cmdOutboundFCL.TabIndex = 2
        Me.cmdOutboundFCL.Text = "Add Line"
        Me.cmdOutboundFCL.UseVisualStyleBackColor = True
        '
        'mskOutboundFCL
        '
        Me.mskOutboundFCL.Location = New System.Drawing.Point(534, 75)
        Me.mskOutboundFCL.Mask = "AAA"
        Me.mskOutboundFCL.Name = "mskOutboundFCL"
        Me.mskOutboundFCL.Size = New System.Drawing.Size(100, 27)
        Me.mskOutboundFCL.TabIndex = 1
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(530, 49)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(104, 23)
        Me.Label36.TabIndex = 0
        Me.Label36.Text = "Line"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabOutboundMTY
        '
        Me.tabOutboundMTY.Controls.Add(Me.DataGridView16)
        Me.tabOutboundMTY.Controls.Add(Me.DataGridView17)
        Me.tabOutboundMTY.Controls.Add(Me.DataGridView18)
        Me.tabOutboundMTY.Controls.Add(Me.DataGridView19)
        Me.tabOutboundMTY.Controls.Add(Me.Label37)
        Me.tabOutboundMTY.Controls.Add(Me.Label38)
        Me.tabOutboundMTY.Controls.Add(Me.Label39)
        Me.tabOutboundMTY.Controls.Add(Me.Label40)
        Me.tabOutboundMTY.Controls.Add(Me.Label41)
        Me.tabOutboundMTY.Controls.Add(Me.DataGridView20)
        Me.tabOutboundMTY.Controls.Add(Me.cmdOutboundMTY)
        Me.tabOutboundMTY.Controls.Add(Me.mskOutboundMTY)
        Me.tabOutboundMTY.Controls.Add(Me.Label42)
        Me.tabOutboundMTY.Location = New System.Drawing.Point(4, 29)
        Me.tabOutboundMTY.Name = "tabOutboundMTY"
        Me.tabOutboundMTY.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOutboundMTY.Size = New System.Drawing.Size(1278, 582)
        Me.tabOutboundMTY.TabIndex = 1
        Me.tabOutboundMTY.Text = "Empty"
        Me.tabOutboundMTY.UseVisualStyleBackColor = True
        '
        'DataGridView16
        '
        Me.DataGridView16.AllowUserToAddRows = False
        Me.DataGridView16.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView16.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn48, Me.DataGridViewTextBoxColumn49, Me.DataGridViewTextBoxColumn50})
        Me.DataGridView16.Location = New System.Drawing.Point(741, 383)
        Me.DataGridView16.Name = "DataGridView16"
        Me.DataGridView16.Size = New System.Drawing.Size(317, 150)
        Me.DataGridView16.TabIndex = 29
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "line_op"
        Me.DataGridViewTextBoxColumn48.HeaderText = "Line"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "Opn20"
        Me.DataGridViewTextBoxColumn49.HeaderText = "20"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn50.DataPropertyName = "Opn40"
        Me.DataGridViewTextBoxColumn50.HeaderText = "40"
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        '
        'DataGridView17
        '
        Me.DataGridView17.AllowUserToAddRows = False
        Me.DataGridView17.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView17.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn51, Me.DataGridViewTextBoxColumn52})
        Me.DataGridView17.Location = New System.Drawing.Point(220, 383)
        Me.DataGridView17.Name = "DataGridView17"
        Me.DataGridView17.Size = New System.Drawing.Size(317, 150)
        Me.DataGridView17.TabIndex = 28
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn51.DataPropertyName = "line_op"
        Me.DataGridViewTextBoxColumn51.HeaderText = "Line"
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "Tnk20"
        Me.DataGridViewTextBoxColumn52.HeaderText = "20"
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        '
        'DataGridView18
        '
        Me.DataGridView18.AllowUserToAddRows = False
        Me.DataGridView18.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView18.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn53, Me.DataGridViewTextBoxColumn54, Me.DataGridViewTextBoxColumn55})
        Me.DataGridView18.Location = New System.Drawing.Point(940, 161)
        Me.DataGridView18.Name = "DataGridView18"
        Me.DataGridView18.Size = New System.Drawing.Size(317, 150)
        Me.DataGridView18.TabIndex = 27
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn53.DataPropertyName = "line_op"
        Me.DataGridViewTextBoxColumn53.HeaderText = "Line"
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn54.DataPropertyName = "Frk20"
        Me.DataGridViewTextBoxColumn54.HeaderText = "20"
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        '
        'DataGridViewTextBoxColumn55
        '
        Me.DataGridViewTextBoxColumn55.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn55.DataPropertyName = "Frk40"
        Me.DataGridViewTextBoxColumn55.HeaderText = "40"
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        '
        'DataGridView19
        '
        Me.DataGridView19.AllowUserToAddRows = False
        Me.DataGridView19.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView19.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn56, Me.DataGridViewTextBoxColumn57, Me.DataGridViewTextBoxColumn58})
        Me.DataGridView19.Location = New System.Drawing.Point(481, 161)
        Me.DataGridView19.Name = "DataGridView19"
        Me.DataGridView19.Size = New System.Drawing.Size(317, 150)
        Me.DataGridView19.TabIndex = 26
        '
        'DataGridViewTextBoxColumn56
        '
        Me.DataGridViewTextBoxColumn56.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn56.DataPropertyName = "line_op"
        Me.DataGridViewTextBoxColumn56.HeaderText = "Line"
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        '
        'DataGridViewTextBoxColumn57
        '
        Me.DataGridViewTextBoxColumn57.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn57.DataPropertyName = "Rfr20"
        Me.DataGridViewTextBoxColumn57.HeaderText = "20"
        Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
        '
        'DataGridViewTextBoxColumn58
        '
        Me.DataGridViewTextBoxColumn58.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn58.DataPropertyName = "Rfr40"
        Me.DataGridViewTextBoxColumn58.HeaderText = "40"
        Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
        '
        'Label37
        '
        Me.Label37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label37.Location = New System.Drawing.Point(741, 353)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(317, 27)
        Me.Label37.TabIndex = 25
        Me.Label37.Text = "Open Top"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label38
        '
        Me.Label38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label38.Location = New System.Drawing.Point(220, 353)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(317, 27)
        Me.Label38.TabIndex = 24
        Me.Label38.Text = "Tank Tainer"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label39
        '
        Me.Label39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label39.Location = New System.Drawing.Point(940, 131)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(317, 27)
        Me.Label39.TabIndex = 23
        Me.Label39.Text = "Flat Rack"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label40
        '
        Me.Label40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label40.Location = New System.Drawing.Point(481, 131)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(317, 27)
        Me.Label40.TabIndex = 22
        Me.Label40.Text = "Reefer"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label41
        '
        Me.Label41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label41.Location = New System.Drawing.Point(22, 131)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(317, 27)
        Me.Label41.TabIndex = 21
        Me.Label41.Text = "Dry"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView20
        '
        Me.DataGridView20.AllowUserToAddRows = False
        Me.DataGridView20.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView20.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn59, Me.DataGridViewTextBoxColumn60, Me.DataGridViewTextBoxColumn61, Me.DataGridViewTextBoxColumn62})
        Me.DataGridView20.Location = New System.Drawing.Point(22, 161)
        Me.DataGridView20.Name = "DataGridView20"
        Me.DataGridView20.Size = New System.Drawing.Size(317, 150)
        Me.DataGridView20.TabIndex = 20
        '
        'DataGridViewTextBoxColumn59
        '
        Me.DataGridViewTextBoxColumn59.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn59.DataPropertyName = "line_op"
        Me.DataGridViewTextBoxColumn59.HeaderText = "Line"
        Me.DataGridViewTextBoxColumn59.Name = "DataGridViewTextBoxColumn59"
        '
        'DataGridViewTextBoxColumn60
        '
        Me.DataGridViewTextBoxColumn60.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn60.DataPropertyName = "Dry20"
        Me.DataGridViewTextBoxColumn60.HeaderText = "20"
        Me.DataGridViewTextBoxColumn60.Name = "DataGridViewTextBoxColumn60"
        '
        'DataGridViewTextBoxColumn61
        '
        Me.DataGridViewTextBoxColumn61.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn61.DataPropertyName = "Dry40"
        Me.DataGridViewTextBoxColumn61.HeaderText = "40"
        Me.DataGridViewTextBoxColumn61.Name = "DataGridViewTextBoxColumn61"
        '
        'DataGridViewTextBoxColumn62
        '
        Me.DataGridViewTextBoxColumn62.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn62.DataPropertyName = "Dry45"
        Me.DataGridViewTextBoxColumn62.HeaderText = "45"
        Me.DataGridViewTextBoxColumn62.Name = "DataGridViewTextBoxColumn62"
        '
        'cmdOutboundMTY
        '
        Me.cmdOutboundMTY.Location = New System.Drawing.Point(640, 69)
        Me.cmdOutboundMTY.Name = "cmdOutboundMTY"
        Me.cmdOutboundMTY.Size = New System.Drawing.Size(108, 38)
        Me.cmdOutboundMTY.TabIndex = 2
        Me.cmdOutboundMTY.Text = "Add Line"
        Me.cmdOutboundMTY.UseVisualStyleBackColor = True
        '
        'mskOutboundMTY
        '
        Me.mskOutboundMTY.Location = New System.Drawing.Point(534, 75)
        Me.mskOutboundMTY.Mask = "AAA"
        Me.mskOutboundMTY.Name = "mskOutboundMTY"
        Me.mskOutboundMTY.Size = New System.Drawing.Size(100, 27)
        Me.mskOutboundMTY.TabIndex = 1
        '
        'Label42
        '
        Me.Label42.Location = New System.Drawing.Point(530, 49)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(104, 23)
        Me.Label42.TabIndex = 17
        Me.Label42.Text = "Line"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.tabCMU.Text = "Chargeables"
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
        Me.TabControl1.ResumeLayout(False)
        Me.tabInbound.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.tabInboundFCL.ResumeLayout(False)
        Me.tabInboundFCL.PerformLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabInboundMTY.ResumeLayout(False)
        Me.tabInboundMTY.PerformLayout()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabOutbound.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.tabOutboundFCL.ResumeLayout(False)
        Me.tabOutboundFCL.PerformLayout()
        CType(Me.DataGridView11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabOutboundMTY.ResumeLayout(False)
        Me.tabOutboundMTY.PerformLayout()
        CType(Me.DataGridView16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView20, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabVMR As TabControl
    Friend WithEvents tabParticulars As TabPage
    Friend WithEvents tabThroughput As TabPage
    Friend WithEvents tabFooters As TabPage
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
    Friend WithEvents tabPreview As TabPage
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
    Friend WithEvents tabCMU As TabPage
    Friend WithEvents dgvCMU As DataGridView
    Friend WithEvents tabSpecificCMU As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgvContainers As DataGridView
    Friend WithEvents mskBoxes As MaskedTextBox
    Friend WithEvents cmbSizes As ComboBox
    Friend WithEvents cmbFreight As ComboBox
    Friend WithEvents cmbUnits As ComboBox
    Friend WithEvents cmbMoveKinds As ComboBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgvGearboxes As DataGridView
    Friend WithEvents TabPage3 As TabPage
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
    Friend WithEvents tabUnits As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabInbound As TabPage
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents tabInboundFCL As TabPage
    Friend WithEvents DataGridView5 As DataGridView
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cmdInboundFCL As Button
    Friend WithEvents mskInboundFCL As MaskedTextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents tabInboundMTY As TabPage
    Friend WithEvents tabOutbound As TabPage
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView6 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView7 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView8 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView9 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents DataGridView10 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents cmdInboundMTY As Button
    Friend WithEvents mskInboundMTY As MaskedTextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents tabOutboundFCL As TabPage
    Friend WithEvents DataGridView11 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView12 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView13 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn38 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView14 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn41 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As DataGridViewTextBoxColumn
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents DataGridView15 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn44 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As DataGridViewTextBoxColumn
    Friend WithEvents cmdOutboundFCL As Button
    Friend WithEvents mskOutboundFCL As MaskedTextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents tabOutboundMTY As TabPage
    Friend WithEvents DataGridView16 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn48 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView17 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn51 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView18 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn53 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView19 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn56 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn57 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn58 As DataGridViewTextBoxColumn
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents DataGridView20 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn59 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn60 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn61 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn62 As DataGridViewTextBoxColumn
    Friend WithEvents cmdOutboundMTY As Button
    Friend WithEvents mskOutboundMTY As MaskedTextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmdChargeReset As Button
End Class
