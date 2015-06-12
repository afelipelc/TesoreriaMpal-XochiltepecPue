Imports MySql.Data.MySqlClient

Public Class Configfrm
    Public Nuevo As Boolean
    Private Sub Configfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CerrarBtn.Enabled = False
        If Nuevo = True Then
            'CargaConfig()
            'Me.FacturaInicialTxt.Visible = True
            'Me.FacturaLbl.Visible = True
            'Me.MarcaFacLbl.Visible = True
            Me.MunicipioTxt.Focus()
        Else
            'Me.FacturaInicialTxt.Visible = False
            'Me.FacturaLbl.Visible = False
            'Me.MarcaFacLbl.Visible = False
            'ConectaServer()
            CargaConfig()
            Me.CerrarBtn.Enabled = True
        End If

    End Sub
    Sub CargaConfig()
        'ConectaServer()
        SQL = "SELECT * from configuracion"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        'comprobar que si ahi datos de configuracion
        If DatosMDR.HasRows = True Then
            DatosMDR.Read()
            Me.MunicipioTxt.Text = DatosMDR!municipio
            Me.PresidenteTxt.Text = DatosMDR!presidente
            Me.TesoreroTxt.Text = DatosMDR!tesorero
            Me.DiaCobroTxt.Text = DatosMDR!diacobro
            Me.FacturaInicialTxt.Text = DatosMDR!ultimafactura + 1
        End If
        DatosMDR.Close()
        'DatosMCmd.Dispose()

        'Ayuntamiento = "Xochiltepec, Puebla."

    End Sub

    Private Sub AceptarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarBtn.Click
        If Me.MunicipioTxt.Text.Length > 0 And Val(Me.DiaCobroTxt.Text) > 0 Then
            If Nuevo = True Then 'si es la primera vez que se corre el programa
                If Me.FacturaInicialTxt.Text.Length > 0 And Me.DiaCobroTxt.Text.Length > 0 Then
                    'registrarlo
                    SQL = "INSERT into configuracion values('" & Me.MunicipioTxt.Text & "','" & Me.PresidenteTxt.Text & "','" & Me.TesoreroTxt.Text & "'," & Val(Me.FacturaInicialTxt.Text) - 1 & "," & Now.Year & "," & Me.DiaCobroTxt.Text & ",'Mensaje de notificacion de adeudo de agua ','Mensaje de notificacion de adeudo predial')"
                    DatosMCmd = New MySqlCommand
                    DatosMCmd.CommandText = SQL
                    DatosMCmd.Connection = SQLCnn
                    'ejecutar consulta
                    DatosMCmd.ExecuteNonQuery()
                    Ayuntamiento = Me.MunicipioTxt.Text
                    Me.Close()
                Else
                    MessageBox.Show("El Numero de Factura Inicial es indispensable", "Datos del Ayuntamiento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Else
                If MessageBox.Show("¿Confirma actualizar los datos?", "Datos del Ayuntamiento", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    SQL = "UPDATE configuracion SET municipio='" & Me.MunicipioTxt.Text & "', presidente='" & Me.PresidenteTxt.Text & "', tesorero='" & Me.TesoreroTxt.Text & "', diacobro=" & Me.DiaCobroTxt.Text & ", ultimafactura=" & Val(Me.FacturaInicialTxt.Text) - 1
                    DatosMCmd = New MySqlCommand
                    DatosMCmd.CommandText = SQL
                    DatosMCmd.Connection = SQLCnn
                    'ejecutar consulta
                    DatosMCmd.ExecuteNonQuery()
                    ControlPanelFrm.Text = "TESORERIA   MUNICIPAL  :  " & Me.MunicipioTxt.Text.ToUpper
                    Ayuntamiento = Me.MunicipioTxt.Text
                    Me.Close()
                Else
                    Me.Close()
                End If
            End If
        Else
            MessageBox.Show("El Campo Nombre del Municipio y dia de cobro de agua potable son indispensables", "Datos del Ayuntamiento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub DiaCobroTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DiaCobroTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))

        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Function SoloNumeros(ByVal Keyascii As Short) As Short 'funcion utilizada en cuadros de texto que solo aceptan numeros
        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            SoloNumeros = 0
        Else
            SoloNumeros = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNumeros = Keyascii
            Case 13
                SoloNumeros = Keyascii
        End Select
    End Function

    Private Sub FacturaInicialTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FacturaInicialTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))

        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub CerrarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarBtn.Click
        Me.Close()
    End Sub
End Class