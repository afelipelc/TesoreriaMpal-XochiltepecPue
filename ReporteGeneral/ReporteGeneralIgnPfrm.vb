Imports MySql.Data.MySqlClient
Public Class ReporteGeneralIgnPfrm
    Dim CargaDatos As DataSet
    Dim DatosAdapter As MySqlDataAdapter
    Dim Resumen As Boolean

    Private Sub ReporteGeneralIgnPfrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = False
        CargarIngGeneral.Dispose()
    End Sub
    Private Sub ReporteGeneralIgnPfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConectaServer()
        CargarConfig()
        Me.Text += Ayuntamiento & " : RESUMEN DE INGRESOS PROPIOS"
        'cargar los años de los que se encuentra la info almacenada
        Me.IngDelAnoCmb.Items.Clear()
        Dim i, DatAno As Short
        DatAno = Now.Year - DatosAno
        For i = 0 To DatAno
            Me.IngDelAnoCmb.Items.Add(DatosAno + i)
        Next
    End Sub
    Public Sub CargarIngresos()

        Me.DatosDtg.DataSource = Nothing
        'crear una nueva instancia del dataset
        CargaDatos = New DataSet
        'cargar los datos en el mysqldataadapter
        DatosAdapter = New MySqlDataAdapter(SQL, SQLCnn)
        'rellenar el dataset con los datos cargados
        DatosAdapter.Fill(CargaDatos, "ingpropios")
        'asignar la fuente de datos al datagrid de detalles
        Me.DatosDtg.DataSource = CargaDatos
        'asignar la tabla que debe mostrar el datagrid
        Me.DatosDtg.DataMember = "ingpropios"
        'Dim c As Short
        'Ajustar ancho de columnas actomaticamente
        Dim c As Integer
        'For c = 0 To Me.DatosDtg.Columns.Count - 1
        ' Me.DatosDtg.Columns.Item(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        'Next
        For c = 0 To Me.DatosDtg.Rows.Count - 1
            Me.IngresoTotalLbl.Text = Val(Me.IngresoTotalLbl.Text) + Val(Me.DatosDtg.Item(Me.DatosDtg.Columns.Count - 1, c).Value.ToString)
        Next
        Me.IngresoTotalLbl.Text = Format(CStr(Val(Me.IngresoTotalLbl.Text)), "Currency")
        'SQLCnn.Close()
    End Sub

    Private Sub TodosBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TodosBtn.Click
        SQL = "SELECT * FROM ingpropios"
        Me.TituloLbl.Text = "RESUMEN DE TODOS LOS INGRESOS"
        CargarIngresos()
        Resumen = False
    End Sub

    Private Sub IngresosMesCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresosMesCmb.SelectedIndexChanged
        Me.IngresosMesCmb.Text = Me.IngresosMesCmb.SelectedItem
        'sSQL = "Select * from SolicExtractostbl where Fecha_Entregado Between #" & Mes & "/01/" & Now.Year & "# And #" & Mes & "/" & Dias & "/" & Now.Year & "# and Estado='Entregado'"
        If Me.IngresosMesCmb.Text <> "" Then
            ObtenNMes(Me.IngresosMesCmb.Text)
            Dim DiasMes As String
            DiasMes = Date.DaysInMonth(Now.Year, Val(NoMes)).ToString
            SQL = "SELECT * FROM ingpropios where fecha Between '" & Now.Year & "-" & NoMes & "-01" & "' and '" & Now.Year & "-" & NoMes & "-" & DiasMes & "' order by fecha asc"
            CargarIngresos()
            Me.TituloLbl.Text = "RESUMEN DE TODOS LOS INGRESOS DEL MES DE " & Me.IngresosMesCmb.Text.ToUpper & " DEL AÑO " & Now.Year
            'CARGAR TOTALES
            Resumen = False
        End If
    End Sub


    Private Sub IngMesFiltroCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngMesFiltroCmb.SelectedIndexChanged
        If Me.IngresosMesCmb.Text <> "" Then
            Me.IngMesFiltroCmb.Text = Me.IngMesFiltroCmb.SelectedItem
            ObtenNMes(Me.IngresosMesCmb.Text)
            Dim DiasMes As String
            DiasMes = Date.DaysInMonth(Now.Year, Val(NoMes)).ToString
            'aqui se hace el filtro por mes
            'Registros
            'Extractos
            'Resumen
            'Todos
            Select Case Me.IngMesFiltroCmb.Text
                Case "Todos"
                    SQL = "SELECT * FROM ingpropios where fecha Between '" & Now.Year & "-" & NoMes & "-01" & "' and '" & Now.Year & "-" & NoMes & "-" & DiasMes & "' order by fecha asc"
                    Me.TituloLbl.Text = "RESUMEN DE TODOS LOS INGRESOS DEL MES DE " & Me.IngresosMesCmb.Text.ToUpper & " DEL AÑO " & Now.Year
                    Resumen = False
                Case "Agua Potable"
                    SQL = "SELECT * FROM ingpropios where fecha Between '" & Now.Year & "-" & NoMes & "-01" & "' and '" & Now.Year & "-" & NoMes & "-" & DiasMes & "' and concepto='Agua Potable' order by fecha asc"
                    Me.TituloLbl.Text = "RESUMEN DE TODOS LOS INGRESOS DE AGUA POTABLE DEL MES DE " & Me.IngresosMesCmb.Text.ToUpper & " DEL AÑO " & Now.Year
                    Resumen = False
                Case "Impuesto Predial"
                    SQL = "SELECT * FROM ingpropios where fecha Between '" & Now.Year & "-" & NoMes & "-01" & "' and '" & Now.Year & "-" & NoMes & "-" & DiasMes & "' and concepto='Impuesto Predial' order by fecha asc"
                    Me.TituloLbl.Text = "RESUMEN DE TODOS LOS INGRESOS DE IMPUESTO PREDIAL DEL MES DE " & Me.IngresosMesCmb.Text.ToUpper & " DEL AÑO " & Now.Year
                    Resumen = False
                Case "Registro Civil"
                    SQL = "SELECT * FROM ingpropios where fecha Between '" & Now.Year & "-" & NoMes & "-01" & "' and '" & Now.Year & "-" & NoMes & "-" & DiasMes & "' and concepto='Registro Civil' order by fecha asc"
                    Me.TituloLbl.Text = "RESUMEN DE TODOS LOS INGRESOS DEL REGISTRO CIVIL DEL MES DE " & Me.IngresosMesCmb.Text.ToUpper & " DEL AÑO " & Now.Year
                    Resumen = False
                Case "Retro y Volteo"
                    SQL = "SELECT * FROM ingpropios where fecha Between '" & Now.Year & "-" & NoMes & "-01" & "' and '" & Now.Year & "-" & NoMes & "-" & DiasMes & "' and concepto='Retro y Volteo' order by fecha asc"
                    Me.TituloLbl.Text = "RESUMEN DE TODOS LOS INGRESOS DE RETRO Y VOLTEO DEL MES DE " & Me.IngresosMesCmb.Text.ToUpper & " DEL AÑO " & Now.Year
                    Resumen = False
                Case "Tortilleria"
                    SQL = "SELECT * FROM ingpropios where fecha Between '" & Now.Year & "-" & NoMes & "-01" & "' and '" & Now.Year & "-" & NoMes & "-" & DiasMes & "' and concepto='Tortilleria' order by fecha asc"
                    Me.TituloLbl.Text = "RESUMEN DE TODOS LOS INGRESOS DE LA TORTILLERIA MPA. DEL MES DE " & Me.IngresosMesCmb.Text.ToUpper & " DEL AÑO " & Now.Year
                    Resumen = False
                Case "Otros Ingresos"
                    SQL = "SELECT * FROM ingpropios where fecha Between '" & Now.Year & "-" & NoMes & "-01" & "' and '" & Now.Year & "-" & NoMes & "-" & DiasMes & "' and concepto='Otros Ingresos' order by fecha asc"
                    Me.TituloLbl.Text = "RESUMEN DE TODOS LOS INGRESOS DE OTROS INGRESOS DEL MES DE " & Me.IngresosMesCmb.Text.ToUpper & " DEL AÑO " & Now.Year
                    Resumen = False
                Case "Resumen"
                    'SELECT Extracto_de, Count(Extracto_de) as Cantidad, SUM(Costo) AS Total  FROM SolicExtractostbl Where Estado='Entregado' and Fecha_Entregado Between #" & Mesde & "/" & Diade & "/" & Me.aPartirDeDtp.Value.Year & "# And #" & Mesa & "/" & Diaa & "/" & Me.HastaDtp.Value.Year & "# GROUP BY Extracto_de"
                    SQL = "select concepto, SUM(ingreso) as Total FROM ingpropios where fecha Between '" & Now.Year & "-" & NoMes & "-01" & "' and '" & Now.Year & "-" & NoMes & "-" & DiasMes & "' GROUP BY concepto" ' WITH ROLLUP"
                    Me.TituloLbl.Text = "RESUMEN DE TODOS LOS INGRESOS DEL MES DE " & Me.IngresosMesCmb.Text.ToUpper & " DEL AÑO " & Now.Year
                    Resumen = True
            End Select
            CargarIngresos()
        End If
    End Sub

    Private Sub IngresosDiaDtp_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresosDiaDtp.ValueChanged
        Try
            SQL = "SELECT * FROM ingpropios where fecha ='" & Me.IngresosDiaDtp.Value.Year & "-" & Me.IngresosDiaDtp.Value.Month & "-" & Me.IngresosDiaDtp.Value.Day & "' order by id_ing asc"

            'verificar que si la fecha es igual a hoy, entonces deshabilitar el otro DTP
            Me.IngresosAlDiadDtp.Enabled = True
            If IngresosDiaDtp.Value.ToShortDateString = Now.Date.ToShortDateString Then
                Me.IngresosAlDiadDtp.Enabled = False
            Else
                'Me.IngresosAlDiadDtp.Value = Me.IngresosDiaDtp.Value
                Me.IngresosAlDiadDtp.MinDate = Me.IngresosDiaDtp.Value
                Me.IngresosAlDiadDtp.MaxDate = Now.Date
            End If

            CargarIngresos()
            Me.TituloLbl.Text = "RESUMEN DE TODOS LOS INGRESOS DEL DIA " & Me.IngresosDiaDtp.Value.ToLongDateString.ToUpper
            Resumen = False
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Resumen de ingresos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub IngresosAlDiadDtp_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresosAlDiadDtp.ValueChanged
        Try
            If Me.IngresosAlDiadDtp.Value <> Me.IngresosDiaDtp.Value Then
                SQL = "SELECT * FROM ingpropios where fecha Between '" & Me.IngresosDiaDtp.Value.Year & "-" & Me.IngresosDiaDtp.Value.Month & "-" & Me.IngresosDiaDtp.Value.Day & "' and '" & Me.IngresosAlDiadDtp.Value.Year & "-" & Me.IngresosAlDiadDtp.Value.Month & "-" & Me.IngresosAlDiadDtp.Value.Day & "' order by id_ing asc"
                'Me.IngresosAlDiadDtp.MinDate = Me.IngresosDiaDtp.Value
                'Me.IngresosAlDiadDtp.Value = Me.IngresosDiaDtp.Value
                CargarIngresos()
                Me.TituloLbl.Text = "RESUMEN DE TODOS LOS INGRESOS DEL " & Me.IngresosDiaDtp.Value.ToLongDateString.ToUpper & " AL " & Me.IngresosAlDiadDtp.Value.ToLongDateString
                Resumen = False
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Resumen de ingresos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub IngDiaFiltroCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngDiaFiltroCmb.SelectedIndexChanged
        Me.IngMesFiltroCmb.Text = Me.IngMesFiltroCmb.SelectedItem
        Select Case Me.IngDiaFiltroCmb.Text
            Case "Todos"
                SQL = "SELECT * FROM ingpropios where fecha Between '" & Me.IngresosDiaDtp.Value.Year & "-" & Me.IngresosDiaDtp.Value.Month & "-" & Me.IngresosDiaDtp.Value.Day & "' and '" & Me.IngresosAlDiadDtp.Value.Year & "-" & Me.IngresosAlDiadDtp.Value.Month & "-" & Me.IngresosAlDiadDtp.Value.Day & "' order by id_ing asc"
                Me.TituloLbl.Text = "RESUMEN DE TODOS LOS INGRESOS DEL " & Me.IngresosDiaDtp.Value.ToLongDateString.ToUpper & " AL " & Me.IngresosAlDiadDtp.Value.ToLongDateString
                Resumen = False
            Case "Agua Potable"
                SQL = "SELECT * FROM ingpropios where fecha Between '" & Me.IngresosDiaDtp.Value.Year & "-" & Me.IngresosDiaDtp.Value.Month & "-" & Me.IngresosDiaDtp.Value.Day & "' and '" & Me.IngresosAlDiadDtp.Value.Year & "-" & Me.IngresosAlDiadDtp.Value.Month & "-" & Me.IngresosAlDiadDtp.Value.Day & "' and concepto='Agua Potable' order by id_ing asc"
                Me.TituloLbl.Text = "RESUMEN DE TODOS LOS INGRESOS DE AGUA POTABLE DEL DIA " & Me.IngresosDiaDtp.Value.ToLongDateString.ToUpper
                Resumen = False
            Case "Impuesto Predial"
                SQL = "SELECT * FROM ingpropios where fecha Between '" & Me.IngresosDiaDtp.Value.Year & "-" & Me.IngresosDiaDtp.Value.Month & "-" & Me.IngresosDiaDtp.Value.Day & "' and '" & Me.IngresosAlDiadDtp.Value.Year & "-" & Me.IngresosAlDiadDtp.Value.Month & "-" & Me.IngresosAlDiadDtp.Value.Day & "' and concepto='Impuesto Predial' order by id_ing asc"
                Me.TituloLbl.Text = "RESUMEN DE TODOS LOS INGRESOS DE IMPUESTO PREDIAL DEL " & Me.IngresosDiaDtp.Value.ToLongDateString.ToUpper & " AL " & Me.IngresosAlDiadDtp.Value.ToLongDateString
                Resumen = False
            Case "Registro Civil"
                SQL = "SELECT * FROM ingpropios where fecha Between '" & Me.IngresosDiaDtp.Value.Year & "-" & Me.IngresosDiaDtp.Value.Month & "-" & Me.IngresosDiaDtp.Value.Day & "' and '" & Me.IngresosAlDiadDtp.Value.Year & "-" & Me.IngresosAlDiadDtp.Value.Month & "-" & Me.IngresosAlDiadDtp.Value.Day & "' and concepto='Registro Civil' order by id_ing asc"
                Me.TituloLbl.Text = "RESUMEN DE TODOS LOS INGRESOS DEL REGISTRO CIVIL DEL " & Me.IngresosDiaDtp.Value.ToLongDateString.ToUpper & " AL " & Me.IngresosAlDiadDtp.Value.ToLongDateString
                Resumen = False
            Case "Retro y Volteo"
                SQL = "SELECT * FROM ingpropios where fecha Between '" & Me.IngresosDiaDtp.Value.Year & "-" & Me.IngresosDiaDtp.Value.Month & "-" & Me.IngresosDiaDtp.Value.Day & "' and '" & Me.IngresosAlDiadDtp.Value.Year & "-" & Me.IngresosAlDiadDtp.Value.Month & "-" & Me.IngresosAlDiadDtp.Value.Day & "' and concepto='Retro y Volteo' order by id_ing asc"
                Me.TituloLbl.Text = "RESUMEN DE TODOS LOS INGRESOS DE RETRO Y VOLTEO DEL " & Me.IngresosDiaDtp.Value.ToLongDateString.ToUpper & " AL " & Me.IngresosAlDiadDtp.Value.ToLongDateString
                Resumen = False
            Case "Tortilleria"
                SQL = "SELECT * FROM ingpropios where fecha Between '" & Me.IngresosDiaDtp.Value.Year & "-" & Me.IngresosDiaDtp.Value.Month & "-" & Me.IngresosDiaDtp.Value.Day & "' and '" & Me.IngresosAlDiadDtp.Value.Year & "-" & Me.IngresosAlDiadDtp.Value.Month & "-" & Me.IngresosAlDiadDtp.Value.Day & "' and concepto='Tortilleria' order by id_ing asc"
                Me.TituloLbl.Text = "RESUMEN DE TODOS LOS INGRESOS DE LA TORTILLERIA MPA. DEL " & Me.IngresosDiaDtp.Value.ToLongDateString.ToUpper & " AL " & Me.IngresosAlDiadDtp.Value.ToLongDateString
                Resumen = False
            Case "Otros Ingresos"
                SQL = "SELECT * FROM ingpropios where fecha Between '" & Me.IngresosDiaDtp.Value.Year & "-" & Me.IngresosDiaDtp.Value.Month & "-" & Me.IngresosDiaDtp.Value.Day & "' and '" & Me.IngresosAlDiadDtp.Value.Year & "-" & Me.IngresosAlDiadDtp.Value.Month & "-" & Me.IngresosAlDiadDtp.Value.Day & "' and concepto='Otros Ingresos' order by id_ing asc"
                Me.TituloLbl.Text = "RESUMEN DE TODOS LOS INGRESOS DE OTROS INGRESOS DEL " & Me.IngresosDiaDtp.Value.ToLongDateString.ToUpper & " AL " & Me.IngresosAlDiadDtp.Value.ToLongDateString
                Resumen = False
            Case "Resumen"
                'SELECT Extracto_de, Count(Extracto_de) as Cantidad, SUM(Costo) AS Total  FROM SolicExtractostbl Where Estado='Entregado' and Fecha_Entregado Between #" & Mesde & "/" & Diade & "/" & Me.aPartirDeDtp.Value.Year & "# And #" & Mesa & "/" & Diaa & "/" & Me.HastaDtp.Value.Year & "# GROUP BY Extracto_de"
                SQL = "select concepto, SUM(ingreso) as Total FROM ingpropios where fecha Between '" & Me.IngresosDiaDtp.Value.Year & "-" & Me.IngresosDiaDtp.Value.Month & "-" & Me.IngresosDiaDtp.Value.Day & "' and '" & Me.IngresosAlDiadDtp.Value.Year & "-" & Me.IngresosAlDiadDtp.Value.Month & "-" & Me.IngresosAlDiadDtp.Value.Day & "' GROUP BY concepto" ' WITH ROLLUP"
                Me.TituloLbl.Text = "RESUMEN DE TODOS LOS INGRESOS DEL " & Me.IngresosDiaDtp.Value.ToLongDateString.ToUpper & " AL " & Me.IngresosAlDiadDtp.Value.ToLongDateString
                Resumen = True
        End Select
        CargarIngresos()
    End Sub

    Private Sub IngDelAnoCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngDelAnoCmb.SelectedIndexChanged
        SQL = "SELECT * FROM ingpropios where fecha like '%" & Me.IngDelAnoCmb.Text & "%'"
        Me.TituloLbl.Text = "RESUMEN DE TODOS LOS INGRESOS DEL AÑO " & Me.IngDelAnoCmb.Text
        CargarIngresos()
        Resumen = False
    End Sub

    Private Sub IngAnoFiltroCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngAnoFiltroCmb.SelectedIndexChanged
        Me.IngAnoFiltroCmb.Text = Me.IngAnoFiltroCmb.SelectedItem
        Select Case Me.IngAnoFiltroCmb.Text
            Case "Todos"
                SQL = "SELECT * FROM ingpropios where fecha like '%" & Me.IngDelAnoCmb.Text & "%'"
                Me.TituloLbl.Text = "RESUMEN DE TODOS LOS INGRESOS DEL AÑO " & Me.IngDelAnoCmb.Text
                Resumen = False
            Case "Agua Potable"
                SQL = "SELECT * FROM ingpropios where fecha like '%" & Me.IngDelAnoCmb.Text & "%' and concepto='Agua Potable' order by fecha asc"
                Me.TituloLbl.Text = "RESUMEN DE TODOS LOS INGRESOS DE AGUA POTABLE DEL DEL AÑO " & Me.IngDelAnoCmb.Text
                Resumen = False
            Case "Impuesto Predial"
                SQL = "SELECT * FROM ingpropios where fecha like '%" & Me.IngDelAnoCmb.Text & "%' and concepto='Impuesto Predial' order by fecha asc"
                Me.TituloLbl.Text = "RESUMEN DE TODOS LOS INGRESOS DE IMPUESTO PREDIAL DEL DEL AÑO " & Me.IngDelAnoCmb.Text
                Resumen = False
            Case "Registro Civil"
                SQL = "SELECT * FROM ingpropios where fecha like '%" & Me.IngDelAnoCmb.Text & "%' and concepto='Registro Civil' order by fecha asc"
                Me.TituloLbl.Text = "RESUMEN DE TODOS LOS INGRESOS DEL REGISTRO CIVIL DEL DEL AÑO " & Me.IngDelAnoCmb.Text
                Resumen = False
            Case "Retro y Volteo"
                SQL = "SELECT * FROM ingpropios where fecha like '%" & Me.IngDelAnoCmb.Text & "%' and concepto='Retro y Volteo' order by fecha asc"
                Me.TituloLbl.Text = "RESUMEN DE TODOS LOS INGRESOS DE RETRO Y VOLTEO DEL DEL AÑO " & Me.IngDelAnoCmb.Text
                Resumen = False
            Case "Tortilleria"
                SQL = "SELECT * FROM ingpropios where fecha like '%" & Me.IngDelAnoCmb.Text & "%' and concepto='Tortilleria' order by fecha asc"
                Me.TituloLbl.Text = "RESUMEN DE TODOS LOS INGRESOS DE LA TORTILLERIA MPA. DEL DEL AÑO " & Me.IngDelAnoCmb.Text
                Resumen = False
            Case "Otros Ingresos"
                SQL = "SELECT * FROM ingpropios where fecha like '%" & Me.IngDelAnoCmb.Text & "%' and concepto='Otros Ingresos' order by fecha asc"
                Me.TituloLbl.Text = "RESUMEN DE TODOS LOS INGRESOS DE OTROS INGRESOS DEL DEL AÑO " & Me.IngDelAnoCmb.Text
                Resumen = False
            Case "Resumen"
                'SELECT Extracto_de, Count(Extracto_de) as Cantidad, SUM(Costo) AS Total  FROM SolicExtractostbl Where Estado='Entregado' and Fecha_Entregado Between #" & Mesde & "/" & Diade & "/" & Me.aPartirDeDtp.Value.Year & "# And #" & Mesa & "/" & Diaa & "/" & Me.HastaDtp.Value.Year & "# GROUP BY Extracto_de"
                SQL = "select concepto, SUM(ingreso) as Total FROM ingpropios where fecha like '%" & Me.IngDelAnoCmb.Text & "%' GROUP BY concepto" ' WITH ROLLUP"
                Me.TituloLbl.Text = "RESUMEN DE TODOS LOS INGRESOS DEL AÑO " & Me.IngDelAnoCmb.Text
                Resumen = True
        End Select
        CargarIngresos()
    End Sub

    Private Sub ResumenBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResumenBtn.Click
        ResumenGeneralFrm.ShowDialog()
    End Sub

    Private Sub SalirBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirBtn.Click
        SQLCnn.Close()
        Me.Close()
    End Sub

    Private Sub ImprimirBrn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirBrn.Click
        If Me.DatosDtg.Rows.Count > 0 Then
            If Resumen = False Then
                'aqui se imprime el resumen
                Reportefrm.Datos.Clear()
                Dim i As Short
                For i = 0 To Me.DatosDtg.Rows.Count - 1
                    Reportefrm.Datos.Add(New DatosResumenCls(Mid(Me.DatosDtg.Item(1, i).Value.ToString, 1, 10), Me.DatosDtg.Item(2, i).Value.ToString, Me.DatosDtg.Item(3, i).Value))
                Next
                Reportefrm.ShowDialog()
            End If
        End If
    End Sub

    Private Sub IngresosMesCmb_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles IngresosMesCmb.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = 0
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub IngDelAnoCmb_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles IngDelAnoCmb.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = 0
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

   
    Private Sub ResCtasBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResCtasBtn.Click
        ResCuentasfrm.ShowDialog()
    End Sub
End Class