Public Class DatosEgresosCls
    Private _Fecha, _Origen, _Cheque, _Destino, _ANombreDe, _Cargo As String
    Private _Cantidad As Double

    Public Sub New(ByVal Fecha As String, ByVal Cantidad As Double, ByVal Origen As String, ByVal Cheque As String, ByVal Destino As String, ByVal ANombreDe As String, ByVal Cargo As String)
        _Fecha = Fecha
        _Cantidad = Cantidad
        _Origen = Origen
        _Cheque = Cheque
        _Destino = Destino
        _ANombreDe = ANombreDe
        _Cargo = Cargo
    End Sub
    Public Property Fecha() As String
        Get
            Return _Fecha
        End Get
        Set(ByVal value As String)
            _Fecha = Fecha
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
    Public Property Origen() As String
        Get
            Return _Origen
        End Get
        Set(ByVal value As String)
            _Origen = Origen
        End Set
    End Property
    Public Property Cheque() As String
        Get
            Return _Cheque
        End Get
        Set(ByVal value As String)
            _Cheque = Cheque
        End Set
    End Property
    Public Property Destino() As String
        Get
            Return _Destino
        End Get
        Set(ByVal value As String)
            _Destino = Destino
        End Set
    End Property

    Public Property aNombreDe() As String
        Get
            Return _ANombreDe
        End Get
        Set(ByVal value As String)
            _ANombreDe = aNombreDe
        End Set
    End Property
    Public Property Cargo() As String
        Get
            Return _Cargo
        End Get
        Set(ByVal value As String)
            _Cargo = Cargo
        End Set
    End Property
End Class
