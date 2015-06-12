Imports System
Imports System.Threading
Imports MySql.Data.MySqlClient
Public Class Contribuyentesfrm

    Public CargaDatos As DataSet
    Public DatosAdapter As MySqlDataAdapter
    Private Sub SalirBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirBtn.Click
        SQLCnn.Close()
        Me.Close()
    End Sub
    Private Sub LocalidadesCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalidadesCmb.SelectedIndexChanged
        Me.LocalidadesCmb.Text = Me.LocalidadesCmb.SelectedItem
        Me.CallesCmb.Items.Clear()
        'ConectaServer()
        CargarCalles(Me.LocalidadesCmb.Text)
        SQL = "SELECT * from contribuyente where localidad='" & Me.LocalidadesCmb.Text & "'"
        CargarDatos()
        'SQLCnn.Close()
    End Sub

    Private Sub CallesCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CallesCmb.SelectedIndexChanged
        Me.CallesCmb.Text = Me.CallesCmb.SelectedItem
        'ConectaServer()
        If Me.CallesCmb.Text <> "Todas" Then
            SQL = "SELECT * from contribuyente where calle='" & Me.CallesCmb.Text & "' and localidad='" & Me.LocalidadesCmb.Text & "'"
        Else
            SQL = "SELECT * from contribuyente where localidad='" & Me.LocalidadesCmb.Text & "'"
        End If
        CargarDatos()
        'SQLCnn.Close()
    End Sub

    Private Sub NContribBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NContribBtn.Click
        DatosContribuyentefrm.Comando = "Nuevo"
        DatosContribuyentefrm.ShowDialog()
        ConectaServer()
    End Sub

    Private Sub DatosDtg_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DatosDtg.CellContentDoubleClick
        SQLCnn.Close()
        DatosContribuyentefrm.Indice = DatosDtg.CurrentRow.Index
        DatosContribuyentefrm.DeContrib = True
        DatosContribuyentefrm.IdContr = Me.DatosDtg.Item(0, DatosDtg.CurrentRow.Index).Value
        'DatosContribuyentefrm.Nombre = Me.DatosDtg.Item(1, DatosDtg.CurrentRow.Index).Value.ToString
        'DatosContribuyentefrm.Dir = Me.DatosDtg.Item(2, DatosDtg.CurrentRow.Index).Value.ToString
        'DatosContribuyentefrm.Num = Me.DatosDtg.Item(3, DatosDtg.CurrentRow.Index).Value.ToString
        'DatosContribuyentefrm.Localidad = Me.DatosDtg.Item(4, DatosDtg.CurrentRow.Index).Value.ToString
        DatosContribuyentefrm.Comando = "Editar"
        DatosContribuyentefrm.ShowDialog()
        ConectaServer()
    End Sub

    Private Sub Contribuyentesfrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'MessageBox.Show(returnValue)
        Cargar.Dispose()
    End Sub

    Private Sub Contribuyentesfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        ConectaServer()
        CargarLocalidades()
        'SQLCnn.Close()
    End Sub
    Sub CargarLocalidades()
        SQL = "SELECT * from localidades"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        'comprobar que si ahi datos de configuracion
        While DatosMDR.Read
            LocalidadesCmb.Items.Add(DatosMDR!nombre)
        End While
        'DatosMCmd.Dispose()
        DatosMDR.Close()
    End Sub
    Sub CargarCalles(ByVal Localidad As String)
        SQL = "SELECT * from calles where localidad='" & Localidad & "'"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        'comprobar que si ahi datos de configuracion
        While DatosMDR.Read
            Me.CallesCmb.Items.Add(DatosMDR!nombre)
        End While
        Me.CallesCmb.Items.Add("Todas")
        'DatosMCmd.Dispose()
        DatosMCmd.Dispose()
        DatosMDR.Close()
    End Sub

    Private Sub MostrartodosBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostrartodosBtn.Click
        'ConectaServer()
        SQL = "SELECT * from contribuyente"
        CargarDatos()
    End Sub
    Sub CargarDatos()
        Me.DatosDtg.DataSource = Nothing
        'crear una nueva instancia del dataset
        CargaDatos = New DataSet
        'cargar los datos en el mysqldataadapter
        DatosAdapter = New MySqlDataAdapter(SQL, SQLCnn)
        'rellenar el dataset con los datos cargados
        DatosAdapter.Fill(CargaDatos, "contribuyente")
        'asignar la fuente de datos al datagrid de detalles
        Me.DatosDtg.DataSource = CargaDatos
        'asignar la tabla que debe mostrar el datagrid
        Me.DatosDtg.DataMember = "contribuyente"
        'Dim c As Short
        Me.TotalContribLbl.Text = Me.DatosDtg.Rows.Count
        'Ajustar ancho de columnas actomaticamente
        'For c = 0 To Me.DatosDtg.Columns.Count - 1
        ' Me.DatosDtg.Columns.Item(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        ' Next
        'SQLCnn.Close()
    End Sub
End Class