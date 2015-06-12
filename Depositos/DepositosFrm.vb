Imports MySql.Data.MySqlClient
Public Class DepositosFrm
    Dim CargaDatos As DataSet
    Dim DatosAdapter As MySqlDataAdapter

    Private Sub DepositosFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = False
        CargarDepositosfrm.Dispose()
    End Sub
    Private Sub DepositosFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConectaServer()
        CargarConfig()
        Me.Text += Ayuntamiento.ToUpper & " : DEPOSITOS"
        'cargar los años de los que se encuentra la info almacenada
        Me.DepDelAnoCmb.Items.Clear()
        Dim i, DatAno As Short
        DatAno = Now.Year - DatosAno
        For i = 0 To DatAno
            Me.DepDelAnoCmb.Items.Add(DatosAno + i)
        Next
    End Sub
    Public Sub CargarDepositos()
        Me.DepositoTotalLbl.Text = ""
        Me.DatosDtg.DataSource = Nothing
        'crear una nueva instancia del dataset
        CargaDatos = New DataSet
        'cargar los datos en el mysqldataadapter
        DatosAdapter = New MySqlDataAdapter(SQL, SQLCnn)
        'rellenar el dataset con los datos cargados
        DatosAdapter.Fill(CargaDatos, "depositosip")
        'asignar la fuente de datos al datagrid de detalles
        Me.DatosDtg.DataSource = CargaDatos
        'asignar la tabla que debe mostrar el datagrid
        Me.DatosDtg.DataMember = "depositosip"
        'Dim c As Short
        Me.ConceptosTotallbl.Text = Me.DatosDtg.Rows.Count
        'Ajustar ancho de columnas actomaticamente
        Dim c As Integer
        For c = 0 To Me.DatosDtg.Columns.Count - 1
            Me.DatosDtg.Columns.Item(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
        For c = 0 To Me.DatosDtg.Rows.Count - 1
            Me.DepositoTotalLbl.Text = Val(Me.DepositoTotalLbl.Text) + Val(Me.DatosDtg.Item(3, c).Value.ToString)
        Next
        Me.DepositoTotalLbl.Text = Format(CStr(Val(Me.DepositoTotalLbl.Text)), "Currency")
        'Me.ImprimirBrn.Enabled = True
        'SQLCnn.Close()
    End Sub

    Private Sub TodosBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TodosBtn.Click
        SQL = "SELECT * FROM depositosip"
        Me.TituloLbl.Text = "TODOS LOS DEPOSITOS REGISTRADOS"
        CargarDepositos()
    End Sub

    Private Sub DepositosMesCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepositosMesCmb.SelectedIndexChanged
        Me.DepositosMesCmb.Text = Me.DepositosMesCmb.SelectedItem
        ObtenNMes(Me.DepositosMesCmb.Text)
        Dim DiasMes As String
        DiasMes = Date.DaysInMonth(Now.Year, Val(NoMes)).ToString
        SQL = "SELECT * FROM depositosip where fecha Between '" & Now.Year & "-" & NoMes & "-01" & "' and '" & Now.Year & "-" & NoMes & "-" & DiasMes & "' order by fecha asc"
        CargarDepositos()
        Me.TituloLbl.Text = "TODOS LOS DEPOSITOS REGISTRADOS EN EL MES DE " & Me.DepositosMesCmb.Text.ToUpper & " DEL AÑO " & Now.Year
    End Sub

    Private Sub DepDelAnoCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepDelAnoCmb.SelectedIndexChanged
        SQL = "SELECT * FROM depositosip where fecha like '%" & Me.DepDelAnoCmb.Text & "%'"
        Me.TituloLbl.Text = "TODOS LOS DEPOSITOS REGISTRADOS EN EL AÑO " & Me.DepDelAnoCmb.Text
        CargarDepositos()
    End Sub

    Private Sub SalirBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirBtn.Click
        SQLCnn.Close()
        Me.Close()
    End Sub

    Private Sub NEgresoBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NEgresoBtn.Click
        NDepositoFrm.ShowDialog()
    End Sub

    Private Sub ImprimirBrn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirBrn.Click
        If Me.DatosDtg.Rows.Count > 0 Then
            ReporteFrm.Datos.Clear()
            Dim i As Integer
            For i = 0 To Me.DatosDtg.Rows.Count - 1
                ReporteFrm.Datos.Add(New DatosDepositosCls(Mid(Me.DatosDtg.Item(3, i).Value.ToString, 1, 10), Me.DatosDtg.Item(1, i).Value.ToString, Me.DatosDtg.Item(2, i).Value.ToString))
            Next
            ReporteFrm.Show()
        Else
            MessageBox.Show("No se encontró nada que imprimir", "Despositos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ConfigBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfigBtn.Click
        Cuentasfrm.ShowDialog()
    End Sub
End Class