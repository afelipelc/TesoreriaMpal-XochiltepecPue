Imports MySql.Data.MySqlClient
Public Class ConfiRegCivilfrm
    Dim CargaDatos As DataSet
    Dim DatosAdapter As MySqlDataAdapter
    'Dim NoTarifa As Short
    Private Sub ConfiRegCivilfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.EditarChk.Checked = False
        CargarTipos()
        Me.DatosDtg.Columns(0).ReadOnly = True
        Me.DatosDtg.Columns(1).ReadOnly = True
        Me.DatosDtg.Columns(2).ReadOnly = True
        Me.DatosDtg.Columns(3).ReadOnly = True
    End Sub

    Sub CargarTipos()
        'cargar la lista de diferentes registros y actas del reg civil
        SQL = "SELECT * FROM configregcivil"
        Me.DatosDtg.DataSource = Nothing
        'crear una nueva instancia del dataset
        CargaDatos = New DataSet
        'cargar los datos en el mysqldataadapter
        DatosAdapter = New MySqlDataAdapter(SQL, SQLCnn)
        'rellenar el dataset con los datos cargados
        DatosAdapter.Fill(CargaDatos, "configregcivil")
        'asignar la fuente de datos al datagrid de detalles
        Me.DatosDtg.DataSource = CargaDatos
        'asignar la tabla que debe mostrar el datagrid
        Me.DatosDtg.DataMember = "configregcivil"
        'Dim c As Short
        Dim c As Integer
        For c = 0 To Me.DatosDtg.Columns.Count - 1
            Me.DatosDtg.Columns.Item(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next

    End Sub

    Private Sub DatosDtg_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DatosDtg.CellEndEdit
        SQL = "UPDATE configregcivil set costo='" & Val(Me.DatosDtg.Item(3, DatosDtg.CurrentRow.Index).Value.ToString) & "' where id_tipo=" & Me.DatosDtg.Item(0, DatosDtg.CurrentRow.Index).Value.ToString
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMCmd.ExecuteNonQuery()
    End Sub

 
    Private Sub CerrarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarBtn.Click
        Me.Close()
    End Sub

    Private Sub EditarChk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarChk.CheckedChanged
        If Me.EditarChk.Checked = True Then
            Me.DatosDtg.Columns(3).ReadOnly = False
        Else
            Me.DatosDtg.Columns(3).ReadOnly = True
        End If
    End Sub
End Class