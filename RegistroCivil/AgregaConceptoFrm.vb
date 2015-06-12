Imports MySql.Data.MySqlClient
Public Class AgregaConceptoFrm
    Dim Costo, Certificacion As Short
    Private Sub AgregaConceptoFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TipoCmb.SelectedValue = ""
        Me.TipoCmb.SelectedItem = Nothing
        Me.TipoCmb.Text = ""
        Me.NombreCmb.Items.Clear()
        Me.NombreCmb.Text = ""
        Limpiardatos()
        'cargar el costo de la certificacion
        SQL = "SELECT costo from configregcivil where tipo='Certificacion' and nombre='Certificacion'"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        If DatosMDR.HasRows = True Then
            DatosMDR.Read()
            Certificacion = DatosMDR!costo
        End If
        DatosMDR.Close()
        Me.CertificacionChk.Checked = False
        Me.CostoTxt.Text = ""
        Me.TipoCmb.Focus()
    End Sub
    Sub Limpiardatos()
        Me.CostoTxt.Text = ""
        Me.ComentarioTxt.Text = ""
        Me.FolioTxt.Text = ""
        Me.CertificacionChk.Checked = False
        Costo = 0
    End Sub
    Private Sub CerrarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarBtn.Click
        Me.TipoCmb.SelectedValue = ""
        Me.Close()
    End Sub

    Private Sub TipoCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoCmb.SelectedIndexChanged
        Me.TipoCmb.Text = Me.TipoCmb.SelectedItem
        Me.NombreCmb.Items.Clear()
        Me.NombreCmb.Text = ""
        If Me.TipoCmb.Text <> "" Then
            SQL = "SELECT nombre from configregcivil where tipo='" & Me.TipoCmb.Text & "'"
            DatosMCmd = New MySqlCommand
            DatosMCmd.CommandText = SQL
            DatosMCmd.Connection = SQLCnn
            DatosMDR = DatosMCmd.ExecuteReader
            While DatosMDR.Read
                Me.NombreCmb.Items.Add(DatosMDR!nombre.ToString)
            End While
            DatosMDR.Close()
        End If
    End Sub

    Private Sub FolioTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FolioTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        'si presiona enter
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TipoCmb_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TipoCmb.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = 0
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub NombreCmb_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreCmb.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = 0
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub NombreCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombreCmb.SelectedIndexChanged
        Me.NombreCmb.Text = Me.NombreCmb.SelectedItem
        Limpiardatos()
        Me.CertificacionChk.Enabled = True
        If Me.NombreCmb.Text <> "" Then
            SQL = "SELECT costo from configregcivil where tipo='" & Me.TipoCmb.Text & "' and nombre='" & Me.NombreCmb.Text & "' limit 1"
            DatosMCmd = New MySqlCommand
            DatosMCmd.CommandText = SQL
            DatosMCmd.Connection = SQLCnn
            DatosMDR = DatosMCmd.ExecuteReader
            If DatosMDR.HasRows = True Then
                DatosMDR.Read()
                Costo = DatosMDR!costo
                Me.CostoTxt.Text = Costo
            End If
            DatosMDR.Close()
        End If
    End Sub

    Private Sub AceptarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarBtn.Click
        If Me.NombreCmb.Text <> "" And Me.TipoCmb.Text <> "" And Me.CostoTxt.Text <> "" Then
            NuevoIngresoFrm.DetallesDtg.Rows.Add(Me.TipoCmb.Text, Me.NombreCmb.Text, Me.FolioTxt.Text, Me.CostoTxt.Text, Me.ComentarioTxt.Text)
            Limpiardatos()
            Me.Close()
        Else
            MessageBox.Show("Seleccione un tipo, un nombre y el costo", "Registro Civil", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CertificacionChk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CertificacionChk.CheckedChanged
        If Me.CertificacionChk.Checked = True Then
            'cargar el costo de la certificacion
            Me.CostoTxt.Text = Costo + Certificacion
            Me.ComentarioTxt.Text += "Con Certificación"
            Me.CertificacionChk.Enabled = False
        End If
    End Sub

    Private Sub CostoTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CostoTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        'si presiona enter
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
End Class