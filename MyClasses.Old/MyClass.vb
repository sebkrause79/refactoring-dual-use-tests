Public Class [MyClass]
    Private _factor As Integer

    Public Sub New(factor As Integer)
        _factor = factor
    End Sub

    Public Function Product(value As Integer) As Integer
        Return value * _factor
    End Function

End Class