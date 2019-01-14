Public Class Container
    Public Property MoveKind
    Public Property Freight
    Public Property Size
    Public Property Boxes

    Public Sub New(movekind As String, freight As String, Size As Integer, Boxes As Integer)
        Me.MoveKind = movekind
        Me.Freight = freight
        Me.Size = Size
        Me.Boxes = Boxes

    End Sub
End Class
