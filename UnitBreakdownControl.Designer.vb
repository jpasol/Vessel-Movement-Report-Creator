<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UnitBreakdownControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.tabUnitBreakdown = New System.Windows.Forms.TabControl()
        Me.UnitBreakdown = New System.Windows.Forms.TabPage()
        Me.tabEmpty = New System.Windows.Forms.DataGridView()
        Me.lblShippingLine = New System.Windows.Forms.Label()
        Me.tabLoaded = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.tabUnitBreakdown.SuspendLayout()
        Me.UnitBreakdown.SuspendLayout()
        CType(Me.tabEmpty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabLoaded, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1327, 691)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.tabUnitBreakdown)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1319, 665)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'tabUnitBreakdown
        '
        Me.tabUnitBreakdown.Controls.Add(Me.UnitBreakdown)
        Me.tabUnitBreakdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabUnitBreakdown.Location = New System.Drawing.Point(6, 7)
        Me.tabUnitBreakdown.Name = "tabUnitBreakdown"
        Me.tabUnitBreakdown.SelectedIndex = 0
        Me.tabUnitBreakdown.Size = New System.Drawing.Size(1286, 596)
        Me.tabUnitBreakdown.TabIndex = 0
        '
        'UnitBreakdown
        '
        Me.UnitBreakdown.Controls.Add(Me.tabEmpty)
        Me.UnitBreakdown.Controls.Add(Me.lblShippingLine)
        Me.UnitBreakdown.Controls.Add(Me.tabLoaded)
        Me.UnitBreakdown.Controls.Add(Me.Label2)
        Me.UnitBreakdown.Controls.Add(Me.Label1)
        Me.UnitBreakdown.Location = New System.Drawing.Point(4, 29)
        Me.UnitBreakdown.Name = "UnitBreakdown"
        Me.UnitBreakdown.Size = New System.Drawing.Size(1278, 563)
        Me.UnitBreakdown.TabIndex = 0
        Me.UnitBreakdown.Text = "TabPage1"
        Me.UnitBreakdown.UseVisualStyleBackColor = True
        '
        'tabEmpty
        '
        Me.tabEmpty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabEmpty.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.tabEmpty.Location = New System.Drawing.Point(641, 170)
        Me.tabEmpty.Name = "tabEmpty"
        Me.tabEmpty.Size = New System.Drawing.Size(634, 275)
        Me.tabEmpty.TabIndex = 5
        '
        'lblShippingLine
        '
        Me.lblShippingLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShippingLine.Location = New System.Drawing.Point(3, 0)
        Me.lblShippingLine.Name = "lblShippingLine"
        Me.lblShippingLine.Size = New System.Drawing.Size(1272, 50)
        Me.lblShippingLine.TabIndex = 4
        Me.lblShippingLine.Text = "APL"
        Me.lblShippingLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabLoaded
        '
        Me.tabLoaded.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabLoaded.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.tabLoaded.Location = New System.Drawing.Point(3, 170)
        Me.tabLoaded.Name = "tabLoaded"
        Me.tabLoaded.Size = New System.Drawing.Size(634, 275)
        Me.tabLoaded.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(641, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(634, 50)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "EMPTY"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(3, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(634, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOADED"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.DataPropertyName = "iso"
        Me.Column1.HeaderText = "ISO"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.DataPropertyName = "20"
        Me.Column2.HeaderText = "20'"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.DataPropertyName = "40"
        Me.Column3.HeaderText = "40'"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.DataPropertyName = "45"
        Me.Column4.HeaderText = "45'"
        Me.Column4.Name = "Column4"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "iso"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ISO"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "20"
        Me.DataGridViewTextBoxColumn2.HeaderText = "20'"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "40"
        Me.DataGridViewTextBoxColumn3.HeaderText = "40'"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "45"
        Me.DataGridViewTextBoxColumn4.HeaderText = "45'"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'UnitBreakdownControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "UnitBreakdownControl"
        Me.Size = New System.Drawing.Size(1360, 768)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.tabUnitBreakdown.ResumeLayout(False)
        Me.UnitBreakdown.ResumeLayout(False)
        CType(Me.tabEmpty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabLoaded, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As Windows.Forms.TabPage
    Friend WithEvents tabUnitBreakdown As TabControl
    Friend WithEvents UnitBreakdown As TabPage
    Friend WithEvents tabLoaded As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblShippingLine As Label
    Friend WithEvents tabEmpty As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
