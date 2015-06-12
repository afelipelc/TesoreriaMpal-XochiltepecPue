Imports MySql.Data.MySqlClient
Imports System.Collections
Public Class EgresosFrm
    Dim CargaDatos As DataSet
    Dim DatosAdapter As MySqlDataAdapter

    Private Sub EgresosFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = False
        CargarEgIngPFrm.Dispose()
    End Sub
    Private Sub EgresosFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Egresos de Ingresos Propios
        ConectaServer()
        CargarConfig()
        Me.Text += Ayuntamiento.ToUpper & " : EGRESOS DE INGRESOS PROPIOS"
        'cargar los años de los que se encuentra la info almacenada
        Me.EgrDelAnoCmb.Items.Clear()
        Dim i, DatAno As Short
        DatAno = Now.Year - DatosAno
        For i = 0 To DatAno
            Me.EgrDelAnoCmb.Items.Add(DatosAno + i)
        Next
    End Sub

    Public Sub CargarEgresos()
        Me.EgresoTotalLbl.Text = ""
        Me.DatosDtg.DataSource = Nothing
        'crear una nueva instancia del dataset
        CargaDatos = New DataSet
        'cargar los datos en el mysqldataadapter
        DatosAdapter = New MySqlDataAdapter(SQL, SQLCnn)
        'rellenar el dataset con los datos cargados
        DatosAdapter.Fill(CargaDatos, "egresosip")
        'asignar la fuente de datos al datagrid de detalles
        Me.DatosDtg.DataSource = CargaDatos
        'asignar la tabla que debe mostrar el datagrid
        Me.DatosDtg.DataMember = "egresosip"
        'Dim c As Short
        Me.ConceptosTotallbl.Text = Me.DatosDtg.Rows.Count
        'Ajustar ancho de columnas actomaticamente
        Dim c As Integer
        For c = 0 To Me.DatosDtg.Columns.Count - 1
            Me.DatosDtg.Columns.Item(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
        For c = 0 To Me.DatosDtg.Rows.Count - 1
            Me.EgresoTotalLbl.Text = Val(Me.EgresoTotalLbl.Text) + Val(Me.DatosDtg.Item(3, c).Value.ToString)
        Next
        Me.EgresoTotalLbl.Text = Format(CStr(Val(Me.EgresoTotalLbl.Text)), "Currency")
        'Me.ImprimirBrn.Enabled = True
        'SQLCnn.Close()
    End Sub

    Private Sub TodosBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TodosBtn.Click
        SQL = "SELECT * FROM egresosip"
        Me.TituloLbl.Text = "TODOS LOS EGRESOS REGISTRADOS"
        CargarEgresos()
    End Sub

    Private Sub EgresosMesCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EgresosMesCmb.SelectedIndexChanged
        Me.EgresosMesCmb.Text = Me.EgresosMesCmb.SelectedItem
        ObtenNMes(Me.EgresosMesCmb.Text)
        Dim DiasMes As String
        DiasMes = Date.DaysInMonth(Now.Year, Val(NoMes)).ToString
        SQL = "SELECT * FROM egresosip where fecha Between '" & Now.Year & "-" & NoMes & "-01" & "' and '" & Now.Year & "-" & NoMes & "-" & DiasMes & "' order by fecha asc"
        CargarEgresos()
        Me.TituloLbl.Text = "TODOS LOS EGRESOS REGISTRADOS EN EL MES DE " & Me.EgresosMesCmb.Text.ToUpper & " DEL AÑO " & Now.Year
    End Sub

    Private Sub EgresosDiaDtp_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EgresosDiaDtp.ValueChanged
        SQL = "SELECT * FROM egresosip where fecha ='" & Me.EgresosDiaDtp.Value.Year & "-" & Me.EgresosDiaDtp.Value.Month & "-" & Me.EgresosDiaDtp.Value.Day & "' order by id_egreso asc"
        CargarEgresos()
        Me.TituloLbl.Text = "TODOS LOS EGRESOS REGISTRADOS EL DIA " & Me.EgresosDiaDtp.Value.ToLongDateString.ToUpper
    End Sub

    Private Sub EgrDelAnoCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EgrDelAnoCmb.SelectedIndexChanged
        SQL = "SELECT * FROM egresosip where fecha like '%" & Me.EgrDelAnoCmb.Text & "%'"
        Me.TituloLbl.Text = "TODOS LOS EGRESOS REGISTRADOS EN EL AÑO " & Me.EgrDelAnoCmb.Text
        CargarEgresos()
    End Sub

    Private Sub SalirBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirBtn.Click
        SQLCnn.Close()
        Me.Close()
    End Sub

    Private Sub ImprimirBrn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirBrn.Click
        If Me.DatosDtg.Rows.Count > 0 Then
            ReporteFrm.Datos.Clear()
            Dim i As Integer
            For i = 0 To Me.DatosDtg.Rows.Count - 1
                ReporteFrm.Datos.Add(New DatosEgresosCls(Mid(Me.DatosDtg.Item(1, i).Value.ToString, 1, 10), Me.DatosDtg.Item(2, i).Value.ToString, Me.DatosDtg.Item(3, i).Value.ToString, Me.DatosDtg.Item(4, i).Value.ToString, Me.DatosDtg.Item(5, i).Value.ToString, Me.DatosDtg.Item(6, i).Value.ToString, Me.DatosDtg.Item(7, i).Value.ToString))
            Next
            ReporteFrm.Show()
        Else
            MessageBox.Show("No se encontró nada que imprimir", "Egresos de Ingresos Propios", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub NEgresoBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NEgresoBtn.Click
        NuevoEgresoFrm.ShowDialog()
    End Sub
End Class