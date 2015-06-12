Public Class BuscarFrm
    Public Buscar As String
    Private Sub CerrarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarBtn.Click
        BuscarTxt.Text = ""
        Me.Close()
    End Sub

    Private Sub BuscarFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BuscarTxt.Focus()
        If Buscar = "cuenta" Then
            Me.Label1.Text = "Buscar por cuenta"
        End If
        If Buscar = "propietario" Then
            Me.Label1.Text = "Buscar por nombre"
        End If
    End Sub

    Private Sub BuscarTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles BuscarTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = 13 Then
            If Me.BuscarTxt.Text.Length > 0 Then
                'ConectaServer()
                If Buscar = "cuenta" Then
                    'cargar consulta "%like%" de nombres
                    SQL = "SELECT * from inmuebles where cuenta like '%" & Val(Me.BuscarTxt.Text) & "%'"
                    ImpuestoPredialFrm.CargarPredios()
                    ImpuestoPredialFrm.TituloLbl.Text = "Todos lo inmuebles que contienen el No. de cuenta: " & Val(Me.BuscarTxt.Text) & " en el campo Numero de inmueble"
                    Me.Close()
                End If
                If Buscar = "propietario" Then
                    'cargar consulta "%like%" de nombres
                    SQL = "SELECT * from inmuebles where propietario like '%" & Me.BuscarTxt.Text & "%'"
                    ImpuestoPredialFrm.CargarPredios()
                    ImpuestoPredialFrm.TituloLbl.Text = "Todos los inmuebles que contienen el nombre de: " & Me.BuscarTxt.Text
                    Me.Close()
                End If
                Me.BuscarTxt.Text = ""
                'SQLCnn.Close()
            Else
                Me.BuscarTxt.Focus()
            End If
        End If
    End Sub
End Class