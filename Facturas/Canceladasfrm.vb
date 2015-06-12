Imports MySql.Data.MySqlClient
Public Class Canceladasfrm
    Dim CargaDatos As DataSet
    Dim DatosAdapter As MySqlDataAdapter
    Dim DetaTarMDR As MySqlDataReader
    Dim DetaTarMCMD As MySqlCommand
    Private Sub Canceladasfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConectaServer()
    End Sub

    Private Sub TodasBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TodasBtn.Click
        Me.DatosDtg.DataSource = Nothing
        'crear una nueva instancia del dataset
        CargaDatos = New DataSet
        SQL = "select * from factcancel"
        'cargar los datos en el mysqldataadapter
        DatosAdapter = New MySqlDataAdapter(SQL, SQLCnn)
        'rellenar el dataset con los datos cargados
        DatosAdapter.Fill(CargaDatos, "factcancel")
        'asignar la fuente de datos al datagrid de detalles
        Me.DatosDtg.DataSource = CargaDatos
        'asignar la tabla que debe mostrar el datagrid
        Me.DatosDtg.DataMember = "factcancel"
        'Dim c As Short
        Me.TotalCancelLbl.Text = Me.DatosDtg.Rows.Count
        'Ajustar ancho de columnas actomaticamente
        Dim c As Integer
        For c = 0 To Me.DatosDtg.Columns.Count - 1
            Me.DatosDtg.Columns.Item(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next

    End Sub

    Private Sub CerrarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarBtn.Click
        SQLCnn.Close()
        Me.Close()
    End Sub

    Private Sub AgregarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarBtn.Click
        CancelarFactFrm.ShowDialog()
        TodasBtn.Focus()
    End Sub
End Class