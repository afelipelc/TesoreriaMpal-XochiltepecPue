Public Class DatosDepositosCls
    Private _Ficha, _Fecha As String
    Private _Cantidad As Double

    Public Sub New(ByVal Fecha As String, ByVal Ficha As String, ByVal Cantidad As Double)
        _Fecha = Fecha
        _Ficha = Ficha
        _Cantidad = Cantidad
    End Sub

    Public Property Fecha() As String
        Get
            Return _Fecha
        End Get
        Set(ByVal value As String)
            _Fecha = Fecha
        End Set
    End Property
    Public Property Ficha() As String
        Get
            Return _Ficha
        End Get
        Set(ByVal value As String)
            _Ficha = Ficha
        End Set
    End Property
    Public Property Cantidad() As Double
        Get
            Return _Cantidad
        End Get
        Set(ByVal value As Double)
            _Cantidad = Cantidad
        End Set
    End Property
End Class
