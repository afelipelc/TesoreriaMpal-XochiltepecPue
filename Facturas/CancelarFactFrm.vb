Imports MySql.Data.MySqlClient
Public Class CancelarFactFrm

    Private Sub CancelarFactFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.NoFacturaTxt.Text = ""
        Me.NombreTxt.Text = ""
        Me.DescripcionTxt.Text = ""
        SQL = "SELECT ultimafactura from configuracion limit 1"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        'comprobar que si ahi datos de configuracion
        If DatosMDR.HasRows = True Then
            DatosMDR.Read()
            Me.NoFacturaTxt.Text = DatosMDR!ultimafactura + 1
            Me.NombreTxt.Focus()
            DatosMDR.Close()
        Else
            MessageBox.Show("No se pudo cargar la ultima factura a cancelar", "Cancelar Factura", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub RegistrarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrarBtn.Click
        If Me.NoFacturaTxt.Text <> "" And Me.DescripcionTxt.Text <> "" Then
            If MessageBox.Show("¿Confirma CANCELAR la factura No. " & Me.NoFacturaTxt.Text & "?", "Cancelar Factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                'AQUI SE REGISTRA LA FACTUA A CANCELADAS
                SQL = "INSERT INTO factcancel (factura,anombrede,descripcion,fecha) values(" & Me.NoFacturaTxt.Text & ",'" & Me.NombreTxt.Text & "','" & Me.DescripcionTxt.Text & "',now())"
                DatosMCmd = New MySqlCommand
                DatosMCmd.CommandText = SQL
                DatosMCmd.Connection = SQLCnn
                DatosMCmd.ExecuteNonQuery()

                SQL = "UPDATE configuracion set ultimafactura = ultimafactura + 1"
                DatosMCmd = New MySqlCommand
                DatosMCmd.CommandText = SQL
                DatosMCmd.Connection = SQLCnn
                DatosMCmd.ExecuteNonQuery()
                MessageBox.Show("La factura No. " & Me.NoFacturaTxt.Text & " fue registrada como cacelada", "Cancelar Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Else
            MessageBox.Show("El numero de factura o descripcion del cancelo esta en vacio", "Cancelar Factura", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CancelarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarBtn.Click
        Me.Close()
    End Sub
End Class