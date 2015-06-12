Public Class DatosResumenCls
    Private _Fecha, _Concepto As String
    Private _Ingreso As Double

    Public Sub New(ByVal Fecha As String, ByVal Concepto As String, ByVal Ingreso As Double)
        _Fecha = Fecha
        _Concepto = Concepto
        _Ingreso = Ingreso
    End Sub
    Public Property Fecha() As String
        Get
            Return _Fecha
        End Get
        Set(ByVal value As String)
            _Fecha = Fecha
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

    Public Property Ingreso() As Double
        Get
            Return _Ingreso
        End Get
        Set(ByVal value As Double)
            _Ingreso = Ingreso
        End Set
    End Property

End Class
