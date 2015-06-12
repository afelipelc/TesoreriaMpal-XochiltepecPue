Public Class DatosPagosCls
    Private _Factura As Integer
    Private _Conceptos As Short
    Private _Importe As Decimal
    Private _Nombre, _Domicilio, _Descripcion, _Comentario, _Fecha As String

    Public Sub New(ByVal Factura As Integer, ByVal Nombre As String, ByVal Domicilio As String, ByVal Descripcion As String, ByVal Conceptos As Short, ByVal Importe As Decimal, ByVal Comentario As String, ByVal Fecha As String)
        _Factura = Factura
        _Nombre = Nombre
        _Domicilio = Domicilio
        _Descripcion = Descripcion
        _Conceptos = Conceptos
        _Importe = Importe
        _Comentario = Comentario
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

    Public Property Descripcion() As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = Descripcion
        End Set
    End Property
    Public Property Conceptos() As Short
        Get
            Return _Conceptos
        End Get
        Set(ByVal value As Short)
            _Conceptos = Conceptos
        End Set
    End Property

    Public Property Comentario() As String
        Get
            Return _Comentario
        End Get
        Set(ByVal value As String)
            _Comentario = Comentario
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
