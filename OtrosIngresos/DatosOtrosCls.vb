Public Class DatosOtrosCls
    Private _Factura As Integer
    Private _Importe As Decimal
    Private _Nombre, _Domicilio, _Concepto, _Fecha As String

    Public Sub New(ByVal Factura As Integer, ByVal Nombre As String, ByVal Domicilio As String, ByVal Concepto As String, ByVal Importe As Decimal, ByVal Fecha As String)
        _Factura = Factura
        _Nombre = Nombre
        _Domicilio = Domicilio
        _Concepto = Concepto
        _Importe = Importe
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

    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = Nombre
        End Set
    End Property
    Public Property Domicilio() As String
        Get
            Return _Domicilio
        End Get
        Set(ByVal value As String)
            _Domicilio = Domicilio
        End Set
    End Property

    Public Property Concepto() As String
        Get
            Return _Concepto
        End Get
        Set(ByVal value As String)
            _Concepto = Concepto
        End Set
    End Property
    Public Property Importe() As Decimal
        Get
            Return _Importe
        End Get
        Set(ByVal value As Decimal)
            _Importe = Importe
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
