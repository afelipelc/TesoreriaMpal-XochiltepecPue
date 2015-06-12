Imports MySql.Data.MySqlClient
Public Class DetalleTarifasfrm
    Public IdTarifa As Integer
    Public Nombretar As String
    Dim DatosAdapter As MySqlDataAdapter
    Dim CargaDatos As DataSet
    Private Sub CerrarBrn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarBrn.Click
        Me.Close()
    End Sub

    Private Sub NuevaBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevaBtn.Click
        'If Me.DatosDtg.Rows.Count > 0 Then
        ' NuevaCuotafrm.IDdet = Me.DatosDtg.Item(0, Me.DatosDtg.Rows.Count - 1).Value.ToString
        ' Else
        ' NuevaCuotafrm.IDdet = 0
        ' End If
        Me.DatosDtg.Sort(Me.DatosDtg.Columns(3), System.ComponentModel.ListSortDirection.Descending)
        NuevaCuotafrm.IdTar = IdLbl.Text
        NuevaCuotafrm.ShowDialog()
    End Sub

    Private Sub DetalleTarifasfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.IdLbl.Text = IdTarifa
        Me.Nombrelbl.Text = Nombretar
        'cargar detalles de la tarifa
        CargarCuotas()
    End Sub

    Public Sub CargarCuotas()
        SQL = "SELECT id_detalle, costo, apar_mes as apartir_mes, apar_ano as apartir_año from detarifagua where id_tarifa=" & IdTarifa
        Me.DatosDtg.DataSource = Nothing
        'crear una nueva instancia del dataset
        CargaDatos = New DataSet
        'cargar los datos en el mysqldataadapter
        DatosAdapter = New MySqlDataAdapter(SQL, SQLCnn)
        'rellenar el dataset con los datos cargados
        DatosAdapter.Fill(CargaDatos, "detarifagua")
        'asignar la fuente de datos al datagrid de detalles
        Me.DatosDtg.DataSource = CargaDatos
        'asignar la tabla que debe mostrar el datagrid
        Me.DatosDtg.DataMember = "detarifagua"

        Dim c As Integer
        For c = 0 To Me.DatosDtg.Columns.Count - 1
            Me.DatosDtg.Columns.Item(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
        'SQLCnn.Close()

    End Sub

    Private Sub EliminarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarBtn.Click
        If Me.DatosDtg.Rows.Count > 0 Then
            Dim IDDetalle, AnoC, i As Short
            IDDetalle = Val(Me.DatosDtg.Item(0, Me.DatosDtg.CurrentRow.Index).Value.ToString)
            AnoC = Val(Me.DatosDtg.Item(3, Me.DatosDtg.CurrentRow.Index).Value.ToString)
            Me.DatosDtg.Sort(Me.DatosDtg.Columns(3), System.ComponentModel.ListSortDirection.Descending)
            For i = 0 To Me.DatosDtg.Rows.Count - 1
                If AnoC < Val(Me.DatosDtg.Item(3, i).Value.ToString) Then
                    MessageBox.Show("Se encuentra otra cuota mas reciente", "No se puede eliminar la cuota", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    If MessageBox.Show("Tenga en cuenta que si elimina esta cuota y ya" & Chr(13) & "ha realizado cobros donde se aplico esta cuota, " & Chr(13) & " los nuevos calculos serán diferentes" & Chr(13) & Chr(13) & "¿Desea ELIMINAR la cuota seleccionada?", "Eliminar cuota de la tarifa: " & Me.IdLbl.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                        SQL = "DELETE from detarifagua where id_detalle=" & IDDetalle & " and id_tarifa=" & Me.IdLbl.Text & " limit 1"
                        DatosMCmd = New MySqlCommand
                        DatosMCmd.CommandText = SQL
                        DatosMCmd.Connection = SQLCnn
                        DatosMCmd.ExecuteNonQuery()
                        CargarCuotas()
                        Exit Sub
                    Else
                        Exit Sub
                    End If
                End If
            Next

        End If
    End Sub
End Class