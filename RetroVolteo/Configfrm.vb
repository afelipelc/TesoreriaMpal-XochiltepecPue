Imports MySql.Data.MySqlClient
Public Class Configfrm

    Private Sub Configfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.EditarChk.Checked = False
        CargaCostos()
    End Sub

    'cargar lista de costos
    Sub CargaCostos()
        SQL = "SELECT * from configmaquina"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = Sql
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        While DatosMDR.Read
            Me.DatosDtg.Rows.Add(DatosMDR!id, DatosMDR!trabajode, DatosMDR!descripcion, DatosMDR!costo)
        End While
        DatosMDR.Close()
    End Sub

    Private Sub EditarChk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarChk.CheckedChanged
        If Me.EditarChk.Checked = True Then
            Me.DatosDtg.ReadOnly = False
            Me.DatosDtg.Columns(0).ReadOnly = True
            Me.DatosDtg.Columns(1).ReadOnly = False
            Me.DatosDtg.Columns(2).ReadOnly = False
            Me.DatosDtg.Columns(3).ReadOnly = False
            Me.Nuevobtn.Enabled = True
            Me.EliminarBtn.Enabled = True
        Else
            Me.DatosDtg.ReadOnly = True
            Me.Nuevobtn.Enabled = False
            Me.EliminarBtn.Enabled = False
        End If
    End Sub

    Private Sub Nuevobtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevobtn.Click
        
        SQL = "INSERT INTO configmaquina (trabajode,descripcion) values('Retro','Descripcion')"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMCmd.ExecuteNonQuery()
        Me.DatosDtg.Rows.Clear()
        CargaCostos()
    End Sub

    Private Sub DatosDtg_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DatosDtg.CellEndEdit
        SQL = "UPDATE configmaquina set trabajode='" & Me.DatosDtg.Item(1, DatosDtg.CurrentRow.Index).Value.ToString & "', descripcion='" & Me.DatosDtg.Item(2, DatosDtg.CurrentRow.Index).Value.ToString & "', costo=" & Val(Me.DatosDtg.Item(3, DatosDtg.CurrentRow.Index).Value.ToString) & " where id=" & Me.DatosDtg.Item(0, DatosDtg.CurrentRow.Index).Value.ToString
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMCmd.ExecuteNonQuery()
    End Sub

    Private Sub CerrarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarBtn.Click
        Me.DatosDtg.Rows.Clear()
        Me.Close()
    End Sub

    Private Sub EliminarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarBtn.Click
        If DatosDtg.Rows.Count > 0 Then
            If MessageBox.Show("¿Confirma eliminar el concepto No." & Me.DatosDtg.Item(0, Me.DatosDtg.CurrentRow.Index).Value.ToString, "Confirguración de costos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                SQL = "DELETE FROM configmaquina where id=" & Me.DatosDtg.Item(0, DatosDtg.CurrentRow.Index).Value.ToString ', costo=" & Val(Me.DatosDtg.Item(3, DatosDtg.CurrentRow.Index).Value.ToString) & " where id=" & Me.DatosDtg.Item(0, DatosDtg.CurrentRow.Index).Value.ToString
                DatosMCmd = New MySqlCommand
                DatosMCmd.CommandText = SQL
                DatosMCmd.Connection = SQLCnn
                DatosMCmd.ExecuteNonQuery()
                Me.DatosDtg.Rows.Clear()
                CargaCostos()
            End If
        End If
    End Sub
End Class