Public Class UnitBreakdown
    Inherits UnitBreakdownData
    Private Structure Unit

        Private Property isotype
        Public Property ISO As String
            Get
                Return isotype
            End Get
            Set(value As String)
                isotype = Reports.ReportFunctions.TranslateISO(value)
            End Set

        End Property

        Public Property Size As Integer
        Public Property Count As Integer

        Private freight As String
        Public Property FreightKind As String

    End Structure
    Public Sub New(Category As String, ShippingLine As String, Throughput As DataSet)
        MyBase.New
        Me.Category = Category
        Me.ShippingLine = ShippingLine
        Me.Throughput = Throughput
        Me.Units = New List(Of Unit)


        CreateDataUsingExistingData()
        CreateDatagridviewSource()
    End Sub

    Private Sub CreateDatagridviewSource()
        Dim FreightKinds As String() = {"FCL", "MTY"}
        Dim ISOTypes As String() = {"Dry", "Reefer", "Flat/Rack", "Tank Tainer", "Open Top"}
        For Each freight As String In FreightKinds
            For Each type As String In ISOTypes
                Dim tempDatatable As DataTable = Me.Tables.Item(freight)

                Dim count20 As Integer = Units.AsEnumerable.Where(Function(unit) unit.ISO = type And unit.FreightKind = freight And unit.Size = 20).Sum(Function(unit) unit.Count)
                Dim count40 As Integer = Units.AsEnumerable.Where(Function(unit) unit.ISO = type And unit.FreightKind = freight And unit.Size = 40).Sum(Function(unit) unit.Count)
                Dim count45 As Integer = Units.AsEnumerable.Where(Function(unit) unit.ISO = type And unit.FreightKind = freight And unit.Size = 45).Sum(Function(unit) unit.Count)


                Dim tempRow As DataRow
                tempRow = tempDatatable.NewRow
                tempRow.ItemArray = {type, count20, count40, count45}
                tempDatatable.Rows.Add(tempRow)
            Next
        Next
    End Sub

    Private Sub CreateDataUsingExistingData()
        Dim Freight As String() = {"FCL", "MTY"}
        Dim ISOTypes As String() = {"Dry", "Rfr", "FRk", "Tnk", "Opn"}
        Dim sizes As Integer() = {20, 40, 45}

        For Each freightKind As String In Freight
            Dim Units As DataTable = Throughput.Tables.Item($"dt{Category}{freightKind}")

            For Each row As DataRow In Units.Rows
                If row("line_op").ToString = Me.ShippingLine Then
                    For Each type As String In ISOTypes
                        For Each size As Integer In sizes
                            Try
                                Dim tempUnit As Unit
                                tempUnit.ISO = type
                                tempUnit.Size = size
                                tempUnit.FreightKind = freightKind
                                tempUnit.Count = row($"{type}{size}")

                                Me.Units.Add(tempUnit)

                            Catch ex As Exception

                            End Try
                        Next
                    Next
                End If
            Next
        Next

    End Sub

    Public Property ShippingLine As String
    Public Property Category As String
    Private Throughput As dsThroughput
    Private Units As List(Of Unit)
End Class
