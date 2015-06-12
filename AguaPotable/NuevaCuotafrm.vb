Imports MySql.Data.MySqlClient
Public Class NuevaCuotafrm
    Public IdTar As Short
    Dim IDdet As Integer
    Private Sub CancelarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarBtn.Click
        Me.Close()
    End Sub

    Private Sub NuevaCuotafrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MesCmb.Text = ""
        Me.AnoCmb.Text = ""
        Me.AnoCmb.Items.Clear()
        Me.PrecioTxt.Text = ""
        Me.PrecioTxt.Focus()
        Dim i As Short
        Dim c As Short
        c = 3
        For i = 1 To 3
            Me.AnoCmb.Items.Add(Now.Year - c)
            c -= 1
        Next
        For i = 0 To 3
            Me.AnoCmb.Items.Add(Now.Year + i)
        Next
    End Sub

    Private Sub AceptarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarBtn.Click
        If Me.PrecioTxt.Text <> "" And Me.MesCmb.Text <> "" And Me.AnoCmb.Text <> "" Then
            ObtenNMes(Me.MesCmb.Text)

            'comprobar que este agregada
            'ObtenNMes(Me.MesCmb.Text)
            If DetalleTarifasfrm.DatosDtg.Rows.Count = 0 Then
                SQL = "INSERT INTO detarifagua(id_tarifa,costo,apar_mes,apar_ano) values(" & IdTar & "," & Me.PrecioTxt.Text & "," & NoMes & "," & Me.AnoCmb.Text & ")"
                DatosMCmd = New MySqlCommand
                DatosMCmd.CommandText = SQL
                DatosMCmd.Connection = SQLCnn
                DatosMCmd.ExecuteNonQuery()
                DetalleTarifasfrm.CargarCuotas()
            Else

                If Val(Me.AnoCmb.Text) < Val(DetalleTarifasfrm.DatosDtg.Item(3, 0).Value.ToString) Then
                    MessageBox.Show("No puede agregar una cuota mas antigua de la última existente", "Nueva cuota", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.MesCmb.Focus()
                    Exit Sub
                Else
                    If Val(Me.AnoCmb.Text) = Val(DetalleTarifasfrm.DatosDtg.Item(3, 0).Value.ToString) And Val(NoMes) <= Val(DetalleTarifasfrm.DatosDtg.Item(2, 0).Value.ToString) Then
                        MessageBox.Show("No puede agregar una cuota mas antigua de la última existente", "Nueva cuota", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.MesCmb.Focus()
                        Exit Sub
                    End If

                    'se agrega nueva cuota
                    'obtener el ultimo no del detalle
                    SQL = "SELECT id_detalle from detarifagua order by id_detalle desc limit 1"
                    DatosMCmd = New MySqlCommand
                    DatosMCmd.CommandText = SQL
                    DatosMCmd.Connection = SQLCnn
                    DatosMDR = DatosMCmd.ExecuteReader
                    'comprobar que si ahi datos de configuracion
                    If DatosMDR.HasRows = True Then
                        DatosMDR.Read()
                        IDdet = DatosMDR!id_detalle
                    Else
                        IDdet = 0
                    End If
                    DatosMDR.Close()
                    SQL = "INSERT INTO detarifagua values(" & IDdet + 1 & "," & IdTar & "," & Me.PrecioTxt.Text & "," & NoMes & "," & Me.AnoCmb.Text & ")"
                    DatosMCmd = New MySqlCommand
                    DatosMCmd.CommandText = SQL
                    DatosMCmd.Connection = SQLCnn
                    DatosMCmd.ExecuteNonQuery()

                End If
            End If
        'y se actualiza el grid de detalles
            DetalleTarifasfrm.CargarCuotas()
            Me.MesCmb.SelectedValue = ""
            Me.Close()
        Else
        MessageBox.Show("Todos los datos son obligatorios", "Cuota de agua potable", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub PrecioTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PrecioTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub MesCmb_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MesCmb.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = 0
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub AnoCmb_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AnoCmb.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = 0
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
End Class