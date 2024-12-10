Public Class [MyClass]
    Implements IMyClass

    Private _factor As Integer

    Public Sub New(factor As Integer)
        _factor = factor
    End Sub

    Public Function Product(value As Integer) As Integer Implements IMyClass.Product
        Return value * _factor
    End Function

End Class