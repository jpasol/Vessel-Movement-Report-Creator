Public Class UnitBreakdownControl
    Public Sub New(UnitBreakdownClass As UnitBreakdown)

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        Me.UnitBreakdownClass = UnitBreakdownClass
        With UnitBreakdownClass
            tabLoaded.DataSource = .FCL
            tabEmpty.DataSource = .MTY

            Me.Category = .Category
            Me.ShippingLine = .ShippingLine

            UnitBreakdownPage.Text = .ShippingLine
            UnitBreakdownPage.Name = $"tab{ .ShippingLine}{ .Category}"
        End With

        AddHandler tabLoaded.EditingControlShowing, AddressOf DataGridViewNumeric
        AddHandler tabEmpty.EditingControlShowing, AddressOf DataGridViewNumeric
    End Sub
    Public ReadOnly Property UnitBreakdownPage As TabPage
        Get
            Return tabUnitBreakdown.TabPages.Item(0)
        End Get
    End Property

    Public ReadOnly Property Category As String
    Public ReadOnly Property ShippingLine As String
    Private UnitBreakdownClass As UnitBreakdown

    Private Sub DataGridViewNumeric(sender As Object, e As DataGridViewEditingControlShowingEventArgs)

        RemoveHandler e.Control.KeyPress, AddressOf Common_Numeric

        Dim textBox As TextBox = DirectCast(e.Control, TextBox)
        If Not (textBox Is Nothing) Then
            AddHandler textBox.KeyPress, AddressOf Common_Numeric
        End If

    End Sub

    Private Sub Common_Numeric(sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) 'Handler for Numeric Fields
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
