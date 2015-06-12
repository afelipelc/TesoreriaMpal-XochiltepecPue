Imports MySql.Data.MySqlClient
Imports System.Collections
Public Class OtrosIngresosFrm
    Dim CargaDatos As DataSet
    Dim DatosAdapter As MySqlDataAdapter

    Private Sub OtrosIngresosFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = False
        CargarOtrosfrm.Dispose()
    End Sub
    Private Sub OtrosIngresosFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConectaServer()
        CargarConfig()
        Me.Text += Ayuntamiento.ToUpper & " : OTROS INGRESOS"
        'cargar los años de los que se encuentra la info almacenada
        Me.IngDelAnoCmb.Items.Clear()
        Dim i, DatAno As Short
        DatAno = Now.Year - DatosAno
        For i = 0 To DatAno
            Me.IngDelAnoCmb.Items.Add(DatosAno + i)
        Next
    End Sub

    Public Sub CargarIngresos()
        Me.IngresoTotalLbl.Text = ""
        Me.DatosDtg.DataSource = Nothing
        'crear una nueva instancia del dataset
        CargaDatos = New DataSet
        'cargar los datos en el mysqldataadapter
        DatosAdapter = New MySqlDataAdapter(SQL, SQLCnn)
        'rellenar el dataset con los datos cargados
        DatosAdapter.Fill(CargaDatos, "otrosing")
        'asignar la fuente de datos al datagrid de detalles
        Me.DatosDtg.DataSource = CargaDatos
        'asignar la tabla que debe mostrar el datagrid
        Me.DatosDtg.DataMember = "otrosing"
        'Dim c As Short
        Me.ConceptosTotallbl.Text = Me.DatosDtg.Rows.Count
        'Ajustar ancho de columnas actomaticamente
        Dim c As Integer
        For c = 0 To Me.DatosDtg.Columns.Count - 1
            Me.DatosDtg.Columns.Item(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
        For c = 0 To Me.DatosDtg.Rows.Count - 1
            Me.IngresoTotalLbl.Text = Val(Me.IngresoTotalLbl.Text) + Val(Me.DatosDtg.Item(5, c).Value.ToString)
        Next
        Me.IngresoTotalLbl.Text = Format(CStr(Val(Me.IngresoTotalLbl.Text)), "Currency")
        'Me.ImprimirBrn.Enabled = True
        'SQLCnn.Close()
    End Sub

    Private Sub TodosBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TodosBtn.Click
        SQL = "SELECT * FROM otrosing"
        Me.TituloLbl.Text = "TODOS LOS INGRESOS REGISTRADOS EN OTROS INGRESOS"
        CargarIngresos()
    End Sub

    Private Sub IngMesCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngMesCmb.SelectedIndexChanged
        Me.IngMesCmb.Text = Me.IngMesCmb.SelectedItem

        ObtenNMes(Me.IngMesCmb.Text)
        Dim DiasMes As String

        DiasMes = Date.DaysInMonth(Now.Year, Val(NoMes)).ToString
        SQL = "SELECT * FROM otrosing where fecha Between '" & Now.Year & "-" & NoMes & "-01" & "' and '" & Now.Year & "-" & NoMes & "-" & DiasMes & "' order by fecha asc"
        CargarIngresos()
        Me.TituloLbl.Text = "TODOS LOS INGRESOS REGISTRADOS EN OTROS INGRESOS EN EL MES DE " & Me.IngMesCmb.Text.ToUpper & " DEL AÑO " & Now.Year
    End Sub

    Private Sub IngDiaDtp_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngDiaDtp.ValueChanged
        SQL = "SELECT * FROM otrosing where fecha ='" & Me.IngDiaDtp.Value.Year & "-" & Me.IngDiaDtp.Value.Month & "-" & Me.IngDiaDtp.Value.Day & "' order by id asc"
        CargarIngresos()
        Me.TituloLbl.Text = "TODOS LOS INGRESOS REGISTRADOS EN OTROS INGRESOS EL DIA " & Me.IngDiaDtp.Value.ToLongDateString.ToUpper
    End Sub

    Private Sub IngDelAnoCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngDelAnoCmb.SelectedIndexChanged
        SQL = "SELECT * FROM otrosing where fecha like '%" & Me.IngDelAnoCmb.Text & "%'"
        Me.TituloLbl.Text = "TODOS LOS INGRESOS REGISTRADOS EN OTROS INGRESOS EN EL AÑO " & Me.IngDelAnoCmb.Text
        CargarIngresos()
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
                ReporteFrm.Datos.Add(New DatosOtrosCls(Me.DatosDtg.Item(1, i).Value.ToString, Me.DatosDtg.Item(2, i).Value.ToString, Me.DatosDtg.Item(3, i).Value.ToString, Me.DatosDtg.Item(4, i).Value.ToString, Me.DatosDtg.Item(5, i).Value.ToString, Mid(Me.DatosDtg.Item(6, i).Value.ToString, 1, 10)))
            Next
            ReporteFrm.Show()
        Else
            MessageBox.Show("No se encontró nada que imprimir", "Otros Ingresos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub NIngBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NIngBtn.Click
        NuevoFrm.ShowDialog()
    End Sub
End Class