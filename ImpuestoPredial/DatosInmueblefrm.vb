Imports Contribuyentes
Imports MySql.Data.MySqlClient
Public Class DatosInmueblefrm
    Public Comando As String
    Public IdInmueble As Integer
    Dim IdContr As Integer
    Dim auto, Registrado, Cerrar, CambiaAno As Boolean

    Dim CargaDatos As DataSet
    Dim DatosAdapter As MySqlDataAdapter
    Private Sub AceptarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarBtn.Click
        If Me.Nombrecmb.Text <> "" And Me.NoCuentaTxt.Text <> "" And Me.AnoPagadoCmb.Text <> "" And Me.TipoCmb.Text <> "" Then
            Try
                Select Case Comando
                    Case "Nuevo"

                        'comprobar primero el numero de cuenta que no exista registrado
                        SQL = "SELECT cuenta, tipo, ubicacion, propietario  from inmuebles  where cuenta=" & Val(Me.NoCuentaTxt.Text)
                        DatosMCmd = New MySqlCommand
                        DatosMCmd.CommandText = SQL
                        DatosMCmd.Connection = SQLCnn
                        DatosMDR = DatosMCmd.ExecuteReader
                        If DatosMDR.HasRows Then 'si ya esta registrado impedir que se vuelva a registrar
                            DatosMDR.Read()
                            'notificar el registro
                            MessageBox.Show("Ya existe un inmueble registrado con la cuenta: " & Me.NoCuentaTxt.Text.ToString & Chr(13) & _
                            "Propietario: " & DatosMDR!propietario.ToString & ", tipo: " & DatosMDR!tipo.ToString & Chr(13) & _
                            "Ubicado en: " & DatosMDR!ubicacion.ToString & ", NO se puede duplicar el registro", "Registro de inmueble", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            DatosMDR.Close()
                        Else
                            DatosMDR.Close()

                            If MessageBox.Show("¿Confirma registrar el inmueble?", "Registro de inmuebles", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                                SQL = "INSERT INTO inmuebles values(" & Me.IdTxt.Text & "," & Me.NoCuentaTxt.Text & ",'" & Me.TipoCmb.Text & "','" & Me.UbicacionCmb.Text & "','" & Me.Nombrecmb.Text & "','" & Me.DomicilioTxt.Text & "'," & Me.AnoPagadoCmb.Text & ",'" & Me.AnoPagadoCmb.Text & "-12-01',0,' ')"
                                DatosMCmd = New MySqlCommand
                                DatosMCmd.CommandText = SQL
                                DatosMCmd.Connection = SQLCnn
                                DatosMCmd.ExecuteNonQuery()

                                'activar su registro de impuestos anuales
                                SQL = "INSERT INTO impuestospred (id_inmueble) VALUES (" & Me.IdTxt.Text & ")"

                                DatosMCmd = New MySqlCommand
                                DatosMCmd.CommandText = SQL
                                DatosMCmd.Connection = SQLCnn
                                DatosMCmd.ExecuteNonQuery()
                                'despues de que registro todo, mostrar la tabla de impuestos
                                ' tamaño minimo=
                                Me.Size = New Size(531, 347)
                                Me.MinimumSize = New Size(531, 347)
                                Me.MaximumSize = New Size(531, 347)
                                Me.ImpuestosGpb.Enabled = True
                                Me.ImpuestosGpb.Visible = True

                                'cargar los impuestos apartir del año pagado
                                CargaImpuestos(Val(Me.IdTxt.Text), Val(Me.AnoPagadoCmb.Text) + 1)
                                Me.AceptarBtn.Enabled = False
                                Me.AnoPagadoCmb.Enabled = False
                                Registrado = True
                            End If
                        End If
                        

                    Case "Abrir"
                        SQL = "UPDATE inmuebles SET tipo='" & Me.TipoCmb.Text & "', ubicacion='" & Me.UbicacionCmb.Text & "', propietario='" & Me.Nombrecmb.Text & "', direccion='" & Me.DomicilioTxt.Text & "' where id_inmueble=" & IdInmueble
                        DatosMCmd = New MySqlCommand
                        DatosMCmd.CommandText = SQL
                        DatosMCmd.Connection = SQLCnn
                        DatosMCmd.ExecuteNonQuery()
                        Cerrar = True
                        Me.Close()
                End Select
                

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("Los campos: Nombre, Cuenta y año pagado, son obligatorios", "Registro de inmuebles", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub DatosInmueblefrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Cerrar = True Then
            LimpiarDatos()
            e.Cancel = False
        Else
            e.Cancel = True
        End If

    End Sub

    Private Sub DatosInmueblefrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Size(531, 226)
        Me.MinimumSize = New Size(531, 226)
        Me.MaximumSize = New Size(531, 226)
        Me.ImpuestosGpb.Enabled = False
        Me.ImpuestosGpb.Visible = False
        Me.AceptarBtn.Enabled = False
        'Me.DatosContribBtn.Enabled = False
        Me.AnoPagadoCmb.Enabled = False
        Me.UltimoPagoLbl.Visible = False
        Me.UltimoPagoLbl.Visible = False
        'Me.UbicacionCmb.Enabled = False
        Me.NoCuentaTxt.ReadOnly = True
        CambiaAno = False
        Registrado = False
        Cerrar = False
        Select Case Comando
            Case "Nuevo"
                UltimoId() 'obtener el no de id que le corresponde
                Me.AceptarBtn.Enabled = True
                'Me.DatosContribBtn.Enabled = True
                Me.AnoPagadoCmb.Enabled = True
                'Me.UbicacionCmb.Enabled = True
                Me.NoCuentaTxt.ReadOnly = False
                Me.AnoPagadoCmb.Text = " "
                Me.TipoCmb.Text = ""
                Me.UbicacionCmb.Text = ""
                Me.ObservacionesTxt.Text = ""

                CargarAnos() 'cargar los años para que seleccione el utlimo pagado
                CargarUbicacionesRusticos()
                Me.Nombrecmb.Focus()
                'cargar las ubicaciones

            Case "Abrir"
                Me.UltimoPagoLbl.Visible = True
                Me.UltimoPagoLbl.Visible = True
                CargarInmueble()
                Me.Size = New Size(531, 347)
                Me.MinimumSize = New Size(531, 347)
                Me.MaximumSize = New Size(531, 347)
                Me.ImpuestosGpb.Enabled = True
                Me.ImpuestosGpb.Visible = True

                'cargar los impuestos apartir del año pagado
                CargaImpuestos(Val(Me.IdTxt.Text), Val(Me.AnoPagadoCmb.Text) + 1)
                'Me.AceptarBtn.Enabled = False
                Me.AnoPagadoCmb.Enabled = False
                CalculaTot()
                CargarAnos()
                Me.CerrarBtn.Focus()
                'Registrado = True
        End Select
    End Sub
    Sub CargarInmueble()
        SQL = "SELECT * from inmuebles  where id_inmueble=" & IdInmueble
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        If DatosMDR.HasRows Then
            DatosMDR.Read()
            Me.IdTxt.Text = DatosMDR!id_inmueble
            Me.NoCuentaTxt.Text = DatosMDR!cuenta
            Me.TipoCmb.Text = DatosMDR!tipo
            Me.UbicacionCmb.Text = DatosMDR!ubicacion.ToString
            Me.Nombrecmb.Text = DatosMDR!propietario
            Me.DomicilioTxt.Text = DatosMDR!direccion.ToString
            Me.AnoPagadoCmb.Text = DatosMDR!pagadohasta
            Me.UltimoPagoLbl.Visible = True
            Me.Ultimopagotitlbl.Visible = True
            Me.UltimoPagoLbl.Text = DatosMDR!ultimopago
            Me.ObservacionesTxt.Text = DatosMDR!observaciones.ToString
        End If
        DatosMDR.Close()
        'cargar los impuestos
        CargaImpuestos(Val(Me.IdTxt.Text), Val(Me.AnoPagadoCmb.Text) + 1)

    End Sub

    Sub UltimoId()
        SQL = "SELECT id_inmueble from inmuebles order by id_inmueble desc limit 1"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        'comprobar que si ahi datos de configuracion
        If DatosMDR.HasRows = True Then
            DatosMDR.Read()
            Me.IdTxt.Text = DatosMDR!id_inmueble + 1
            '.Text = DatosMDR!id_toma + 1
        Else
            Me.IdTxt.Text = 1
        End If
        'DatosMCmd.Dispose()
        DatosMDR.Close()
    End Sub

    Sub CargarAnos()
        Dim i As Short

        Dim c As Short
        c = 6
        For i = 1 To 6
            Me.AnoPagadoCmb.Items.Add(Now.Year - c)
            c -= 1
        Next
    End Sub

    Private Sub Nombrecmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nombrecmb.SelectedIndexChanged
        Me.Nombrecmb.Text = Me.Nombrecmb.SelectedItem
        'hacer consulta y rellenar los datos automaticamente
        Try
            SQL = "SELECT * from contribuyente where nombre='" & Me.Nombrecmb.Text & "'"
            DatosMCmd = New MySqlCommand
            DatosMCmd.CommandText = SQL
            DatosMCmd.Connection = SQLCnn
            DatosMDR = DatosMCmd.ExecuteReader
            'comprobar que si ahi datos de configuracion
            If DatosMDR.HasRows = True Then
                DatosMDR.Read()
                'Me.CallesCmb.Items.Clear()
                Me.Nombrecmb.Text = DatosMDR!nombre
                Me.DomicilioTxt.Text = DatosMDR!calle & " No. " & DatosMDR!numero & ", " & DatosMDR!localidad
                'Me.LocalidadesCmb.Items.Clear()

                IdContr = DatosMDR!id
                DatosMDR.Close()
                Me.NoCuentaTxt.Focus()
                Exit Sub
            Else
                Me.DomicilioTxt.Text = ""
            End If
            'DatosMCmd.Dispose()
            DatosMDR.Close()
        Catch Ex As MySqlException
            MessageBox.Show(Ex.Message)
            'DatosMDR.Close()
        End Try
    End Sub

    Private Sub Nombrecmb_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Nombrecmb.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        'si presiona espacio
        IdContr = 0
        If KeyAscii = 32 And auto = False Then
            'cargar consulta "%like%" de nombres
            Try
                SQL = "SELECT nombre from contribuyente where nombre like '%" & Me.Nombrecmb.Text & "%'"
                DatosMCmd = New MySqlCommand
                DatosMCmd.CommandText = SQL
                DatosMCmd.Connection = SQLCnn
                DatosMDR = DatosMCmd.ExecuteReader
                'comprobar que si ahi datos de configuracion
                While DatosMDR.Read()
                    Me.Nombrecmb.Items.Add(DatosMDR!nombre)
                End While
                DatosMDR.Close()
                auto = True
            Catch Ex As MySqlException
                MessageBox.Show(Ex.Message)
                'DatosMDR.Close()
            End Try
        End If
    End Sub

    Private Sub Nombrecmb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nombrecmb.TextChanged
        If Me.Nombrecmb.Text.Length = 0 Then
            Me.Nombrecmb.Items.Clear()
            auto = False
            Me.DomicilioTxt.Text = ""
        End If
    End Sub

    Sub LimpiarDatos()
        Me.IdTxt.Text = ""
        'Me.Nombrecmb.Items.Clear()
        Me.Nombrecmb.Text = ""
        Me.NoCuentaTxt.Text = ""
        Me.DomicilioTxt.Text = ""
        Me.TipoCmb.Text = ""
        Me.TipoCmb.SelectedText = ""
        'Me.UltimoPagoLbl.Text = "yyyy-mm-dd"
        'me.Ultimopagotitlbl
        Me.AnoPagadoCmb.Items.Clear()
        Me.UbicacionCmb.Items.Clear()
        Me.UbicacionCmb.Text = ""
        Me.AnoPagadoCmb.Text = ""
        Me.ImpuestosDtg.DataSource = Nothing
        Me.ImpuestosDtg.Rows.Clear()
        Me.AdeudoTotalLbl.Text = "0"
        Me.ObservacionesTxt.Text = ""
        Me.CambiarAnoChk.Checked = False
    End Sub

    Sub CargarImpuestos()
        Me.ImpuestosDtg.DataSource = Nothing
        'crear una nueva instancia del dataset
        CargaDatos = New DataSet
        'cargar los datos en el mysqldataadapter
        DatosAdapter = New MySqlDataAdapter(SQL, SQLCnn)
        'rellenar el dataset con los datos cargados
        DatosAdapter.Fill(CargaDatos, "impuestospred")
        'asignar la fuente de datos al datagrid de detalles
        Me.ImpuestosDtg.DataSource = CargaDatos
        'asignar la tabla que debe mostrar el datagrid
        Me.ImpuestosDtg.DataMember = "impuestospred"

        'Ajustar ancho de columnas actomaticamente
        Dim c As Integer
        For c = 0 To Me.ImpuestosDtg.Columns.Count - 1
            'Me.ImpuestosDtg.gridc()
            Me.ImpuestosDtg.Columns.Item(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next

    End Sub

    Sub CargarUbicacionesRusticos()
        SQL = "SELECT nombre from ubicrusticos"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        While DatosMDR.Read
            Me.UbicacionCmb.Items.Add(DatosMDR!nombre.ToString)
        End While
        DatosMDR.Close()
        Me.UbicacionCmb.Items.Add("<Agregar>")
    End Sub
    Sub CalculaTot()
        Dim c As Short
        Me.AdeudoTotalLbl.Text = ""
        For c = 0 To Me.ImpuestosDtg.Columns.Count - 1
            Me.AdeudoTotalLbl.Text = Val(Me.AdeudoTotalLbl.Text) + Val(Me.ImpuestosDtg.Item(c, 0).Value.ToString)
        Next
        'Me.AdeudoTotalLbl.Text = Format(CStr(Val(Me.AdeudoTotalLbl.Text)), "Currency")
    End Sub

    Sub CargaImpuestos(ByVal IdInmueble As Short, ByVal ApaAno As Short)
        Dim i As Short
        SQL = "SELECT "
        If ApaAno - 1 = Now.Year Then
            Me.AdeudoTotalLbl.Text = "Sin adeudos"
        Else
            For i = ApaAno To Now.Year
                If i = Now.Year Then
                    SQL += "imp" & i & " "
                Else
                    SQL += "imp" & i & ", "
                End If
            Next
            SQL += " from impuestospred where id_inmueble=" & IdInmueble & " limit 1"
            CargarImpuestos()
        End If
    End Sub

    Private Sub CerrarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarBtn.Click
        If Comando <> "Nuevo" Then
            Cerrar = True
            Me.Close()
            Exit Sub
        End If
        If Comando = "Nuevo" And Registrado = True Then
            Cerrar = True
            Me.Close()
        Else
            If MessageBox.Show("¿Confirma salir sin registrar el inmueble?", "Registro de inmuebles", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Cerrar = True
                Me.Close()
            Else
                Cerrar = False
                Exit Sub
            End If
        End If
        
    End Sub

    Private Sub TipoCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoCmb.SelectedIndexChanged
        Me.TipoCmb.Text = Me.TipoCmb.SelectedItem
    End Sub

    Private Sub AnoPagadoCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnoPagadoCmb.SelectedIndexChanged
        Me.AnoPagadoCmb.Text = Me.AnoPagadoCmb.SelectedItem
        If Me.CambiaAno = True Then
            If MessageBox.Show("¿Confirma cambiar el ultimo año pagado?" & Chr(13) & "Ingrese un comentario del porque modifico el ultimmo año pagado y presione Enter", "Datos del inmueble", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                SQL = "UPDATE inmuebles set pagadohasta=" & Me.AnoPagadoCmb.Text & " where id_inmueble=" & Me.IdTxt.Text & " limit 1"
                DatosMCmd = New MySqlCommand
                DatosMCmd.CommandText = SQL
                DatosMCmd.Connection = SQLCnn
                DatosMCmd.ExecuteNonQuery()
                MessageBox.Show("El ultimo año pagado ha cambiado a: " & Me.AnoPagadoCmb.Text & Chr(13) & "Cierre esta ventana y vuelva a abrir los datos para ver los cambios", "Datos del inmueble", MessageBoxButtons.OK)
            End If
        End If
    End Sub

    Private Sub UbicacionCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UbicacionCmb.SelectedIndexChanged
        Me.UbicacionCmb.Text = Me.UbicacionCmb.SelectedItem
        If Me.UbicacionCmb.Text = "<Agregar>" Then

            Dim Nueva As String
            Nueva = InputBox("Ingrese el nombre de la nueva ubicación", "Nueva Ubicación")
            If Nueva.Length = 0 Then
                Me.UbicacionCmb.SelectedValue = ""
                'Me.UbicacionCmb.Text = " "
                Exit Sub
            End If

            'verificar que no exista
            SQL = "SELECT nombre from ubicrusticos where nombre='" & Nueva & "'"
            DatosMCmd = New MySqlCommand
            DatosMCmd.CommandText = SQL
            DatosMCmd.Connection = SQLCnn
            DatosMDR = DatosMCmd.ExecuteReader
            'comprobar que si ahi datos de configuracion
            If DatosMDR.HasRows = True Then
                MessageBox.Show("La ubicación: " & Nueva & Chr(13) & "Ya se encuentra registrada")
                'DatosMCmd.Dispose()
                DatosMDR.Close()
                Exit Sub
            Else
                'DatosMCmd.Dispose()
                DatosMDR.Close()
                'obtener el ultimo Id

                SQL = "insert into ubicrusticos (nombre) values('" & Nueva & "')"
                DatosMCmd = New MySqlCommand
                DatosMCmd.CommandText = SQL
                DatosMCmd.Connection = SQLCnn
                'ejecutar consulta
                DatosMCmd.ExecuteNonQuery()
                Me.UbicacionCmb.Items.Add(Nueva)
                Me.UbicacionCmb.Text = Nueva
                'DatosMCmd.Dispose()
            End If

        End If
    End Sub

    Private Sub TipoCmb_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TipoCmb.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = 0
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub AnoPagadoCmb_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AnoPagadoCmb.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = 0
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub ImpuestosDtg_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ImpuestosDtg.CellEndEdit
        Try
            SQL = "UPDATE impuestospred set " & Me.ImpuestosDtg.Columns(Me.ImpuestosDtg.CurrentCell.ColumnIndex).HeaderText & "=" & Val(Me.ImpuestosDtg.CurrentCell.Value.ToString) & " where id_inmueble=" & Me.IdTxt.Text
            DatosMCmd = New MySqlCommand
            DatosMCmd.CommandText = SQL
            DatosMCmd.Connection = SQLCnn
            DatosMCmd.ExecuteNonQuery()
            CalculaTot()
            SQL = "UPDATE inmuebles set adeudo=" & Me.AdeudoTotalLbl.Text & " where id_inmueble=" & Me.IdTxt.Text & " limit 1"
            DatosMCmd = New MySqlCommand
            DatosMCmd.CommandText = SQL
            DatosMCmd.Connection = SQLCnn
            DatosMCmd.ExecuteNonQuery()
        Catch Ex As MySqlException
            MessageBox.Show(Ex.Message, "Error al ingresar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub NoCuentaTxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NoCuentaTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        'si presiona enter
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub DatosContribBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatosContribBtn.Click
        Dim Contribuyente As Contribuyentes.DatosContribuyentefrm
        Contribuyente = New Contribuyentes.DatosContribuyentefrm
        If Me.Nombrecmb.Text = "" Or IdContr = 0 Then
            Contribuyente.Comando = "Nuevo"
        Else
            Contribuyente.IdContr = IdContr
            Contribuyente.Comando = "Editar"
        End If
        'Me.Nombrecmb.Text = ""
        Contribuyente.ShowDialog()
    End Sub

    Private Sub ImpuestosDtg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ImpuestosDtg.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        'si presiona enter
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub ObservacionesTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ObservacionesTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = 13 Then
            e.Handled = True
            Try
                SQL = "UPDATE inmuebles set observaciones='" & Me.ObservacionesTxt.Text.ToString & "' where id_inmueble=" & Me.IdTxt.Text & " limit 1"
                DatosMCmd = New MySqlCommand
                DatosMCmd.CommandText = SQL
                DatosMCmd.Connection = SQLCnn
                DatosMCmd.ExecuteNonQuery()
            Catch Ex As MySqlException
                MessageBox.Show(Ex.Message, "Error al ingresar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub CambiarAnoChk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarAnoChk.CheckedChanged
        If Me.CambiarAnoChk.Checked = True Then
            Me.AnoPagadoCmb.Enabled = True
            CambiaAno = True
        Else
            Me.AnoPagadoCmb.Enabled = False
            CambiaAno = False
        End If
    End Sub
End Class