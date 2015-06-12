Public Class DatosReporteCls
    Private _Factura As Integer
    Private _NoToma, _Tarifa, _NoTomas, _Meses As Short
    Private _Nombre, _Domicilio, _PagDesde, _PagHasta, _Fecha As String
    Private _Importe As Decimal

    Public Sub New(ByVal Factura As Integer, ByVal NoToma As Short, ByVal Tarifa As Short, ByVal NoTomas As Short, ByVal Nombre As String, ByVal Domicilio As String, ByVal PagDesde As String, ByVal PagHasta As String, ByVal Meses As Short, ByVal Importe As Decimal, ByVal Fecha As String)
        _Factura = Factura
        _NoToma = NoToma
        _Tarifa = Tarifa
        _NoTomas = NoTomas
        _Nombre = Nombre
        _Domicilio = Domicilio
        _PagDesde = PagDesde
        _PagHasta = PagHasta
        _Meses = Meses
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
    Public Property NoToma() As Short
        Get
            Return _NoToma
        End Get
        Set(ByVal value As Short)
            _NoToma = NoToma
        End Set
    End Property
    Public Property Tarifa() As Short
        Get
            Return _Tarifa
        End Get
        Set(ByVal value As Short)
            _Tarifa = Tarifa
        End Set
    End Property

    Public Property NoTomas() As Short
        Get
            Return _NoTomas
        End Get
        Set(ByVal value As Short)
            _NoTomas = NoTomas
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

    Public Property PagDesde() As String
        Get
            Return _PagDesde
        End Get
        Set(ByVal value As String)
            _PagDesde = PagDesde
        End Set
    End Property

    Public Property PagHasta() As String
        Get
            Return _PagHasta
        End Get
        Set(ByVal value As String)
            _PagHasta = PagHasta
        End Set
    End Property
    Public Property Meses() As Short
        Get
            Return _Meses
        End Get
        Set(ByVal value As Short)
            _Meses = Meses
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
