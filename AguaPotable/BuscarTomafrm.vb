Imports System.Threading
'Imports mysql.Data.MySqlClient
Public Class BuscarTomafrm
    Public BuscarEn As String
    Private Sub BuscarTomafrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BuscaBombreTxt.Text = ""

        If Me.BuscarEn = "id_toma" Then
            Me.TituloLbl.Text = "Numero de Toma"
            'Me.BuscaNumTxtn.Visible = True
            'Me.BuscaBombreTxt.Visible = False
        End If
        If Me.BuscarEn = "nombre" Then
            Me.TituloLbl.Text = "Nombre de Titular"
            'Me.BuscaNumTxtn.Visible = False
            'Me.BuscaBombreTxt.Visible = True
            'Me.BuscaBombreTxt.Focus()
        End If
        Me.BuscaBombreTxt.Focus()
    End Sub

    Private Sub CerrarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarBtn.Click
        Me.Close()
    End Sub

    Private Sub BuscaBombreTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles BuscaBombreTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        'si presiona espacio
        If KeyAscii = 13 Then
            If Me.BuscaBombreTxt.Text.Length > 0 Then
                'ConectaServer()
                If Me.BuscarEn = "id_toma" Then
                    'cargar consulta "%like%" de nombres
                    SQL = "SELECT * from aguapotable where id_toma=" & Val(Me.BuscaBombreTxt.Text)
                    AguaPotablefrm.CargarDatos()
                    AguaPotablefrm.Mostrados = "Buscar"
                    AguaPotablefrm.Titulolbl.Text = "Toma de agua potable numero: " & Val(Me.BuscaBombreTxt.Text)
                    Me.Close()
                End If
                If Me.BuscarEn = "nombre" Then
                    'cargar consulta "%like%" de nombres
                    SQL = "SELECT * from aguapotable where nombre like '%" & Me.BuscaBombreTxt.Text & "%'"
                    AguaPotablefrm.CargarDatos()
                    AguaPotablefrm.Mostrados = "Buscar"
                    AguaPotablefrm.Titulolbl.Text = "Todas las tomas que contienen el nombre de: " & Me.BuscaBombreTxt.Text
                    Me.Close()
                End If
                'SQLCnn.Close()
            Else
                Me.BuscaBombreTxt.Focus()
            End If
        End If
    End Sub
End Class