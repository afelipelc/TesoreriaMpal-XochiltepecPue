Imports System
Imports System.Threading
Imports MySql.Data.MySqlClient
Public Class Tarifasfrm
    Dim CargaDatos As DataSet
    Dim DatosAdapter As MySqlDataAdapter
    Dim NoTarifa As Short
    Private Sub NuevaTBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevaTBtn.Click
        Dim NuevaTarifa As String
        NuevaTarifa = InputBox("Ingrese el Nombre de la Nueva Tarifa:", "Sistema de Agua Potable")
        If NuevaTarifa.Length > 0 Then

            'buscar que no se encuentre en la lista
            'verificar que no exista
            SQL = "SELECT nombre from tarifasagua where nombre='" & NuevaTarifa & "'"
            DatosMCmd = New MySqlCommand
            DatosMCmd.CommandText = SQL
            DatosMCmd.Connection = SQLCnn
            DatosMDR = DatosMCmd.ExecuteReader
            'comprobar que si ahi datos de configuracion
            If DatosMDR.HasRows = True Then
                MessageBox.Show("La Tarifa: " & NuevaTarifa & Chr(13) & "Ya se encuentra registrada", "Tarifas")
                'DatosMCmd.Dispose()
                DatosMDR.Close()
                Exit Sub
            Else
                'DatosMCmd.Dispose()
                DatosMDR.Close()
                'obtener el ultimo Id
                UltimaTarifa()
                SQL = "insert into tarifasagua values(" & NoTarifa & ",'" & NuevaTarifa & "')"
                DatosMCmd = New MySqlCommand
                DatosMCmd.CommandText = SQL
                DatosMCmd.Connection = SQLCnn
                'ejecutar consulta
                DatosMCmd.ExecuteNonQuery()
                'DatosMCmd.Dispose()
                CargarTarifas()
            End If
            'Else
            'MessageBox.Show("No puede dejar el nombre vacio", "Sistema de Agua potable", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Sub UltimaTarifa()
        SQL = "SELECT id_tarifa from tarifasagua order by id_tarifa desc limit 1"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        'comprobar que si ahi datos de configuracion
        If DatosMDR.HasRows = True Then
            DatosMDR.Read()
            NoTarifa = DatosMDR!id_tarifa + 1
        Else
            NoTarifa = 1
        End If
        'DatosMCmd.Dispose()
        DatosMDR.Close()
    End Sub

    Private Sub DetallesBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetallesBtn.Click
        MuestraDetallesTar()
    End Sub
    Sub MuestraDetallesTar()
        If Me.DatosDtg.Rows.Count > 0 Then
            DetalleTarifasfrm.IdTarifa = Me.DatosDtg.Item(0, DatosDtg.CurrentRow.Index).Value.ToString
            DetalleTarifasfrm.Nombretar = Me.DatosDtg.Item(1, DatosDtg.CurrentRow.Index).Value.ToString
            DetalleTarifasfrm.ShowDialog()
        End If
    End Sub
    Private Sub DatosDtg_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DatosDtg.CellDoubleClick
        MuestraDetallesTar()
    End Sub

    Private Sub Tarifasfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cargar tarifas
        'ConectaServer()
        CargarTarifas()
        Me.DatosDtg.Columns(0).ReadOnly = True
        'SQLCnn.Close()
    End Sub

    Private Sub CerrarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarBtn.Click
        'SQLCnn.Close()
        Me.Close()
    End Sub
    Sub CargarTarifas()
        SQL = "SELECT * FROM tarifasagua"
        Me.DatosDtg.DataSource = Nothing
        'crear una nueva instancia del dataset
        CargaDatos = New DataSet
        'cargar los datos en el mysqldataadapter
        DatosAdapter = New MySqlDataAdapter(SQL, SQLCnn)
        'rellenar el dataset con los datos cargados
        DatosAdapter.Fill(CargaDatos, "tarifasagua")
        'asignar la fuente de datos al datagrid de detalles
        Me.DatosDtg.DataSource = CargaDatos
        'asignar la tabla que debe mostrar el datagrid
        Me.DatosDtg.DataMember = "tarifasagua"
        'Dim c As Short
        'Ajustar ancho de columnas actomaticamente
        Dim c As Integer
        For c = 0 To Me.DatosDtg.Columns.Count - 1
            Me.DatosDtg.Columns.Item(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
    End Sub

    Private Sub DatosDtg_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DatosDtg.CellEndEdit
        SQL = "UPDATE tarifasagua set nombre='" & Me.DatosDtg.Item(1, DatosDtg.CurrentRow.Index).Value.ToString & "' where id_tarifa=" & Me.DatosDtg.Item(0, DatosDtg.CurrentRow.Index).Value.ToString
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMCmd.ExecuteNonQuery()
    End Sub

    Private Sub EliminarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarBtn.Click
        If Me.DatosDtg.Rows.Count > 0 Then
            Dim IDTarifa As Short
            IDTarifa = Me.DatosDtg.Item(0, DatosDtg.CurrentRow.Index).Value.ToString
            If MessageBox.Show("¿Desea ELIMINAR la tarifa seleccionada?" & Chr(13) & "Tarifa: " & IDTarifa & " - " & Me.DatosDtg.Item(1, DatosDtg.CurrentRow.Index).Value.ToString & Chr(13) & "Tenga en cuenta que si ha asignado esta tarifa" & Chr(13) & "a algunas tomas, tendra que REASIAGNAR otra nueva tarifa a esas tomas, sino los calculos se veran afectados" & Chr(13) & Chr(13) & "¿Confirma ELIMINAR la tarifa?", "Eliminar tarifa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                SQL = "DELETE from detarifagua where id_tarifa=" & IDTarifa
                DatosMCmd = New MySqlCommand
                DatosMCmd.CommandText = SQL
                DatosMCmd.Connection = SQLCnn
                DatosMCmd.ExecuteNonQuery()

                SQL = "DELETE from tarifasagua where id_tarifa=" & IDTarifa & " limit 1"
                DatosMCmd = New MySqlCommand
                DatosMCmd.CommandText = SQL
                DatosMCmd.Connection = SQLCnn
                DatosMCmd.ExecuteNonQuery()


                MessageBox.Show("La tarifa " & IDTarifa & " fue eliminada", "Tarifa eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information)

                CargarTarifas()
                Exit Sub
            Else
                Exit Sub
            End If
        End If
    End Sub
End Class