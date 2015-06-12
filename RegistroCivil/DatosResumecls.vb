Public Class DatosResumecls
    Private _Tipo, _Nombre As String
    Private _Cantidad As Short
    Private _Importe As Decimal
    Public Sub New(ByVal Tipo As String, ByVal Nombre As String, ByVal Cantidad As Short, ByVal Importe As Decimal)
        _Tipo = Tipo
        _Nombre = Nombre
        _Cantidad = Cantidad
        _Importe = Importe
    End Sub
    Public Property Tipo() As String
        Get
            Return _Tipo
        End Get
        Set(ByVal value As String)
            _Tipo = Tipo
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
    Public Property Cantidad() As Short
        Get
            Return _Cantidad
        End Get
        Set(ByVal value As Short)
            _Cantidad = Cantidad
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

End Class
