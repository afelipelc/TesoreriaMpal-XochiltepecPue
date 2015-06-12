Public Class DatosPrediosCls
    Private _IdInmueble, _NoCuenta As Integer
    Private _Importe As Decimal
    Private _Ubicacion, _Nombre, _Domicilio, _AnosCobrados, _Fecha As String

    Public Sub New(ByVal IdInmueble As Integer, ByVal NoCuenta As Integer, ByVal Ubicacion As String, ByVal Nombre As String, ByVal Domicilio As String, ByVal AnosCobrados As String, ByVal Importe As Decimal, ByVal Fecha As String)
        _IdInmueble = IdInmueble
        _NoCuenta = NoCuenta
        _Ubicacion = Ubicacion
        _Nombre = Nombre
        _Domicilio = Domicilio
        _AnosCobrados = AnosCobrados
        _Importe = Importe
        _Fecha = Fecha
    End Sub
    Public Property IdInmueble() As Integer
        Get
            Return _IdInmueble
        End Get
        Set(ByVal value As Integer)
            _IdInmueble = IdInmueble
        End Set
    End Property
    Public Property NoCuenta() As Integer
        Get
            Return _NoCuenta
        End Get
        Set(ByVal value As Integer)
            _NoCuenta = NoCuenta
        End Set
    End Property
    Public Property Ubicacion() As String
        Get
            Return _Ubicacion
        End Get
        Set(ByVal value As String)
            _Ubicacion = Ubicacion
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
    Public Property AnosCobrados() As String
        Get
            Return _AnosCobrados
        End Get
        Set(ByVal value As String)
            _AnosCobrados = AnosCobrados
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
