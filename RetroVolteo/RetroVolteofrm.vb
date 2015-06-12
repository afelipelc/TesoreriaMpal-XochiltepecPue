Imports System
Imports System.Threading
Imports MySql.Data.MySqlClient
Imports System.Collections
Public Class RetroVolteofrm
    Dim CargaDatos As DataSet
    Dim DatosAdapter As MySqlDataAdapter
    Private Sub DatosDtg_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatosDtg.DoubleClick
        IngresoFrm.IdPago = Me.DatosDtg.Item(0, Me.DatosDtg.CurrentRow.Index).Value
        IngresoFrm.Comando = "Abrir"
        IngresoFrm.ShowDialog()
    End Sub

    Private Sub NPagoBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NPagoBtn.Click
        IngresoFrm.Comando = "Nuevo"
        IngresoFrm.ShowDialog()
    End Sub

    Private Sub RetroVolteofrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConectaServer()
        CargarConfig()
        Me.Text += Ayuntamiento & " : RETRO Y VOLTEO"
        'cargar los años de los que se encuentra la info almacenada
        Me.PagDelAnoCmb.Items.Clear()
        Dim i, DatAno As Short
        DatAno = Now.Year - DatosAno
        For i = 0 To DatAno
            Me.PagDelAnoCmb.Items.Add(DatosAno + i)
        Next
    End Sub

    Private Sub ConfigBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfigBtn.Click
        Configfrm.ShowDialog()
    End Sub
    Public Sub CargarPagos()
        Me.IngresoTotalLbl.Text = ""
        Me.DatosDtg.DataSource = Nothing
        'crear una nueva instancia del dataset
        CargaDatos = New DataSet
        'cargar los datos en el mysqldataadapter
        DatosAdapter = New MySqlDataAdapter(SQL, SQLCnn)
        'rellenar el dataset con los datos cargados
        DatosAdapter.Fill(CargaDatos, "cobromaquina")
        'asignar la fuente de datos al datagrid de detalles
        Me.DatosDtg.DataSource = CargaDatos
        'asignar la tabla que debe mostrar el datagrid
        Me.DatosDtg.DataMember = "cobromaquina"
        'Dim c As Short
        Me.ConceptosTotallbl.Text = Me.DatosDtg.Rows.Count
        Me.ConceptosTituloLbl.Text = "Total de Pagos:"
        'Ajustar ancho de columnas actomaticamente
        Dim c As Integer
        'For c = 0 To Me.DatosDtg.Columns.Count - 1
        ' Me.DatosDtg.Columns.Item(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        'Next
        For c = 0 To Me.DatosDtg.Rows.Count - 1
            Me.IngresoTotalLbl.Text = Val(Me.IngresoTotalLbl.Text) + Val(Me.DatosDtg.Item(6, c).Value.ToString)
        Next
        Me.IngresoTotalLbl.Text = Format(CStr(Val(Me.IngresoTotalLbl.Text)), "Currency")
        Me.ImprimirBrn.Enabled = True
        'SQLCnn.Close()
    End Sub

    Private Sub PagosTodosBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagosTodosBtn.Click
        SQL = "SELECT * FROM cobromaquina"
        Me.TituloLbl.Text = "TODOS LOS INGRESOS DE RETROEXCAVADORA Y VOLTEO REGISTRADOS"
        CargarPagos()
    End Sub

    Private Sub PagosMesCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagosMesCmb.SelectedIndexChanged
        Me.PagosMesCmb.Text = Me.PagosMesCmb.SelectedItem
        'sSQL = "Select * from SolicExtractostbl where Fecha_Entregado Between #" & Mes & "/01/" & Now.Year & "# And #" & Mes & "/" & Dias & "/" & Now.Year & "# and Estado='Entregado'"

        ObtenNMes(Me.PagosMesCmb.Text)
        Dim DiasMes As String

        DiasMes = Date.DaysInMonth(Now.Year, Val(NoMes)).ToString
        SQL = "SELECT * FROM cobromaquina where fecha Between '" & Now.Year & "-" & NoMes & "-01" & "' and '" & Now.Year & "-" & NoMes & "-" & DiasMes & "' order by fecha asc"
        CargarPagos()
        Me.TituloLbl.Text = "TODOS LOS INGRESOS DE RETROEXCAVADORA Y VOLTEO REGISTRADOS EN EL MES DE " & Me.PagosMesCmb.Text.ToUpper & " DEL AÑO " & Now.Year
    End Sub

    Private Sub PagosDiaDtp_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagosDiaDtp.ValueChanged
        SQL = "SELECT * FROM cobromaquina where fecha ='" & Me.PagosDiaDtp.Value.Year & "-" & Me.PagosDiaDtp.Value.Month & "-" & Me.PagosDiaDtp.Value.Day & "' order by id_cobro asc"
        CargarPagos()
        Me.TituloLbl.Text = "TODOS LOS INGRESOS DE RETROEXCAVADORA Y VOLTEO REGISTRADOS EL DIA " & Me.PagosDiaDtp.Value.ToLongDateString.ToUpper
    End Sub

    Private Sub PagDelAnoCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagDelAnoCmb.SelectedIndexChanged
        SQL = "SELECT * FROM cobromaquina where fecha like '%" & Me.PagDelAnoCmb.Text & "%'"
        Me.TituloLbl.Text = "TODOS LOS INGRESOS DE RETROEXCAVADORA Y VOLTEO REGISTRADOS EN EL AÑO " & Me.PagDelAnoCmb.Text
        CargarPagos()
    End Sub

    Private Sub PagosMesCmb_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PagosMesCmb.KeyPress

    End Sub

    Private Sub RetroVolteofrm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = False
        CargaRetroVoltFrm.Dispose()
    End Sub

    Private Sub ImprimirBrn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirBrn.Click
        If Me.DatosDtg.Rows.Count > 0 Then
            ReporteFrm.Datos.Clear()
            'agregar todos los detalles a la tabla de detalles
            Dim i As Integer
            For i = 0 To Me.DatosDtg.Rows.Count - 1
                ReporteFrm.Datos.Add(New DatosRetrovoltCls(Me.DatosDtg.Item(1, i).Value.ToString, Me.DatosDtg.Item(2, i).Value.ToString, Me.DatosDtg.Item(3, i).Value.ToString, Me.DatosDtg.Item(4, i).Value.ToString, Me.DatosDtg.Item(5, i).Value, Me.DatosDtg.Item(6, i).Value, Me.DatosDtg.Item(8, i).Value.ToString, Mid(Me.DatosDtg.Item(7, i).Value.ToString, 1, 10)))
            Next
            ReporteFrm.Show()
        Else
            MessageBox.Show("No se encontro nada que imprimir", "Retro y volteo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub SalirBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirBtn.Click
        SQLCnn.Close()
        Me.Close()
    End Sub
End Class