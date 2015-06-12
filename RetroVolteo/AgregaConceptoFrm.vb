Imports MySql.Data.MySqlClient
Public Class AgregaConceptoFrm

    Private Sub AgregaConceptoFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TrabdeCmb.SelectedValue = ""
        Me.TrabdeCmb.SelectedItem = Nothing
        Me.ConceptosCmb.Text = ""
        Me.TrabdeCmb.Text = ""
    End Sub
    Sub LimpiarDatos()
        Me.TrabdeCmb.SelectedValue = ""
        Me.ConceptosCmb.Items.Clear()
        Me.ConceptosCmb.SelectedValue = ""
        Me.TrabdeCmb.Text = ""
        Me.ConceptosCmb.Text = ""
        Me.PUTxt.Text = ""
        Me.CantidadTxt.Text = ""
        Me.ImporteTxt.Text = ""
    End Sub

    Private Sub CancelarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarBtn.Click
        LimpiarDatos()
    End Sub

    Private Sub TrabdeCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrabdeCmb.SelectedIndexChanged
        Me.TrabdeCmb.Text = Me.TrabdeCmb.SelectedItem
        Me.ConceptosCmb.Items.Clear()
        Me.ConceptosCmb.SelectedValue = ""
        SQL = "SELECT descripcion from configmaquina where trabajode='" & Me.TrabdeCmb.Text & "'"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        While DatosMDR.Read
            Me.ConceptosCmb.Items.Add(DatosMDR!descripcion.ToString)
        End While
        DatosMDR.Close()
    End Sub

    Private Sub ConceptosCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConceptosCmb.SelectedIndexChanged
        Me.ConceptosCmb.Text = Me.ConceptosCmb.SelectedItem
        Me.PUTxt.Text = ""
        SQL = "SELECT costo from configmaquina where trabajode='" & Me.TrabdeCmb.Text & "' and descripcion='" & Me.ConceptosCmb.Text & "' limit 1"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        While DatosMDR.Read
            Me.PUTxt.Text = DatosMDR!costo
        End While
        DatosMDR.Close()
        Me.CantidadTxt.Focus()
    End Sub

    Private Sub CantidadTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CantidadTxt.KeyPress
        'si presiona enter
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        NumeroDec(e, Me.CantidadTxt)
        'If KeyAscii = 13 Then 'si presiona enter,
        ' Me.CantidadTxt.Focus()
        ' End If

        If KeyAscii = 13 Then
            Me.AceptarBtn.Focus()
            Exit Sub
        End If

        If KeyAscii = 0 Then
            e.Handled = True
        Else
            ' si es un numero
            If Me.CantidadTxt.Text <> "" Then 'si el campo cantidad No esta en blanco: PU *lo que ahi en el campo y el numero presionado eje: 250 * "1"  que ya estaba & "2" que se presiono -> 12 -->250*12
                Me.ImporteTxt.Text = Val(Me.PUTxt.Text) * Val(Me.CantidadTxt.Text & Chr(KeyAscii))
            Else
                Me.ImporteTxt.Text = Val(Me.PUTxt.Text) * Val(Chr(KeyAscii))
            End If
        End If
    End Sub

    Private Sub ImporteTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ImporteTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        'si presiona enter
        If KeyAscii = 13 Then
            Me.AceptarBtn.Focus()
            Exit Sub
        End If
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub AceptarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarBtn.Click
        If Me.TrabdeCmb.Text <> "" And Me.ConceptosCmb.Text <> "" And Val(Me.CantidadTxt.Text) > 0 And Val(Me.ImporteTxt.Text) > 0 Then
            IngresoFrm.DetallesDtg.Rows.Add(Me.TrabdeCmb.Text & "-" & Me.ConceptosCmb.Text, Me.CantidadTxt.Text, Me.PUTxt.Text, Me.ImporteTxt.Text)
            LimpiarDatos()
            Me.Close()
        Else
            MessageBox.Show("Todos los campos son obligatorios", "Agregar concepto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TrabdeCmb_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TrabdeCmb.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = 0
        'si presiona enter
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub ConceptosCmb_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ConceptosCmb.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = 0
        'si presiona enter
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
End Class