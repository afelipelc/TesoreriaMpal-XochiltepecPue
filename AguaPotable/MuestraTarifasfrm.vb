Imports MySql.Data.MySqlClient
Public Class MuestraTarifasfrm
    Dim CargaDatos As DataSet
    Dim DatosAdapter As MySqlDataAdapter
    Private Sub CerrarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarBtn.Click
        Me.Close()
    End Sub

    Private Sub MuestraTarifasfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cargar tarifas
        SQL = "SELECT * FROM tarifasagua"
        Me.TarifasDtg.DataSource = Nothing
        'crear una nueva instancia del dataset
        CargaDatos = New DataSet
        'cargar los datos en el mysqldataadapter
        DatosAdapter = New MySqlDataAdapter(SQL, SQLCnn)
        'rellenar el dataset con los datos cargados
        DatosAdapter.Fill(CargaDatos, "tarifasagua")
        'asignar la fuente de datos al datagrid de detalles
        Me.TarifasDtg.DataSource = CargaDatos
        'asignar la tabla que debe mostrar el datagrid
        Me.TarifasDtg.DataMember = "tarifasagua"
    End Sub

    Private Sub TarifasDrg_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TarifasDtg.CellDoubleClick
        If Me.TarifasDtg.Rows.Count > 0 Then
            NuevaTomafrm.IdTarifaTxt.Text = Me.TarifasDtg.Item(0, TarifasDtg.CurrentRow.Index).Value.ToString
            NuevaTomafrm.NombreTarifaTxt.Text = Me.TarifasDtg.Item(1, TarifasDtg.CurrentRow.Index).Value.ToString
            Me.Close()
        End If
    End Sub
End Class