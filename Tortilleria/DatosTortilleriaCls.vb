Public Class DatosTortilleriaCls
    Private _Factura As Integer
    Private _Ingreso As Decimal
    Private _Periodo, _Fecha As String

    Public Sub New(ByVal Factura As Integer, ByVal Periodo As String, ByVal Ingreso As Decimal, ByVal Fecha As String)
        _Factura = Factura
        _Periodo = Periodo
        _Ingreso = Ingreso
        _Fecha = Fecha
    End Sub
    Public Property Factura() As Integer
        Get
            Return _Factura
        End Get
        Set(ByVal value As Integer)
            _Factura = Factura
        End Set
    End Property

    Public Property Periodo() As String
        Get
            Return _Periodo
        End Get
        Set(ByVal value As String)
            _Periodo = Periodo
        End Set
    End Property
    Public Property Ingreso() As Decimal
        Get
            Return _Ingreso
        End Get
        Set(ByVal value As Decimal)
            _Ingreso = Ingreso
        End Set
    End Property
    Public Property Fecha() As String
        Get
            Return _Fecha
        End Get
        Set(ByVal value As String)
            _Fecha = Fecha
        End Set
    End Property
End Class
