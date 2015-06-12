Imports System
Imports System.Threading
Imports MySql.Data.MySqlClient
Public Class DatosContribuyentefrm
    'variables para control de datos
    Public Comando As String 'Registrar, Nuevo, Editar
    Public IdContr, Indice As Integer
    Public DeContrib As Boolean
    'Public Nombre, Dir, Num, Localidad As String

    Private Sub CancelarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarBtn.Click
        DatosMDR.Close()
        Me.CallesCmb.Text = ""
        Me.CallesCmb.Items.Clear()
        Me.LocalidadesCmb.Text = ""
        Me.LocalidadesCmb.Items.Clear()
        Me.NombreTxt.Text = ""
        Me.Numerotxt.Text = ""
        DeContrib = False
        SQLCnn.Close()
        Me.Close()
    End Sub

    Private Sub AceptarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarBtn.Click
        Try
            'verificar si lleno los datos
            If Me.NombreTxt.Text = "" And Me.LocalidadesCmb.Text = "" Then
                MessageBox.Show("El Campo Nombre es obligatorio", "Datos del contribuyente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.NombreTxt.Focus()
            Else
                'realizar accion segun comando
                Select Case Comando
                    Case "Nuevo"
                        Registrar()
                    Case "Registrar"
                        Registrar()

                    Case "Editar"
                        ' primero actualizar base de datos
                        SQL = "UPDATE contribuyente set nombre = '" & Me.NombreTxt.Text & "', calle='" & Me.CallesCmb.Text & "', numero='" & Me.Numerotxt.Text & "', localidad='" & Me.LocalidadesCmb.Text & "' where id=" & Me.IdContribTxt.Text
                        DatosMCmd = New MySqlCommand
                        DatosMCmd.CommandText = SQL
                        DatosMCmd.Connection = SQLCnn
                        DatosMCmd.ExecuteNonQuery()
                        'DatosMCmd.Dispose()
                        'actualizar grid
                        If DeContrib = True Then
                            Contribuyentesfrm.DatosDtg.Item(1, Indice).Value = Me.NombreTxt.Text
                            Contribuyentesfrm.DatosDtg.Item(2, Indice).Value = Me.CallesCmb.Text
                            Contribuyentesfrm.DatosDtg.Item(3, Indice).Value = Me.Numerotxt.Text
                            Contribuyentesfrm.DatosDtg.Item(4, Indice).Value = Me.LocalidadesCmb.Text
                        End If
                End Select

                'al finalizar, limpiar las variables de datos 
                'Comando = ""
                SQLCnn.Close()
                Me.CallesCmb.Text = ""
                Me.CallesCmb.Items.Clear()
                Me.LocalidadesCmb.Text = ""
                Me.LocalidadesCmb.Items.Clear()
                Me.NombreTxt.Text = ""
                Me.Numerotxt.Text = ""
                DeContrib = False
                Me.Close()
            End If
            Catch Err As MySqlException
            MessageBox.Show(Err.Message, "MySQL Error: " & Err.Number)
        End Try
    End Sub

    Sub Registrar()
        'verificar que no exista
        SQL = "SELECT nombre from contribuyente where nombre='" & Me.NombreTxt.Text & "'"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        'comprobar que si ahi datos de configuracion
        If DatosMDR.HasRows = True Then
            MessageBox.Show("El contribuyente: " & Me.NombreTxt.Text & Chr(13) & "Ya se encuentra registrado")
            'DatosMCmd.Dispose()
            DatosMDR.Close()
            Exit Sub
        Else
            'DatosMCmd.Dispose()
            DatosMDR.Close()
            SQL = "insert into contribuyente values(" & Me.IdContribTxt.Text & ",'" & Me.NombreTxt.Text & "','" & Me.CallesCmb.Text & "','" & Me.Numerotxt.Text & "','" & Me.LocalidadesCmb.Text & "')"
            DatosMCmd = New MySqlCommand
            DatosMCmd.CommandText = SQL
            DatosMCmd.Connection = SQLCnn
            'ejecutar consulta
            DatosMCmd.ExecuteNonQuery()
        End If
    End Sub

    Private Sub DatosContribuyentefrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        ConectaServer()
        'cargar los datos de las calles y localidades
        'verificar si se le han pasado datos al form para editar o registrar los datos
        Select Case Comando
            Case "Nuevo"
                UltimoContrib()
                Me.NombreTxt.Focus()
            Case "Editar"
                CargarContribuyente()
                'Case "Registrar"
                '    UltimoContrib()
                '    Me.NombreTxt.Text = Nombre
                ''   Me.LocalidadesCmb.Text = Localidad
                '   Me.CallesCmb.Text = Dir()
                '  Me.Numerotxt.Text = Num
                '   Me.NombreTxt.Focus()
        End Select
        CargarLocalidades()
    End Sub
    Sub CargarContribuyente()
        SQL = "SELECT * from contribuyente where id='" & IdContr & "'"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        'comprobar que si ahi datos de configuracion
        If DatosMDR.HasRows = True Then
            DatosMDR.Read()
            Me.NombreTxt.Text = DatosMDR!nombre
            Me.CallesCmb.Text = DatosMDR!calle
            Me.Numerotxt.Text = DatosMDR!numero
            Me.LocalidadesCmb.Text = DatosMDR!localidad
            Me.IdContribTxt.Text = IdContr
        End If
        DatosMDR.Close()
    End Sub

    Sub CargarLocalidades()
        SQL = "SELECT * from localidades"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        'comprobar que si ahi datos de configuracion
        While DatosMDR.Read
            Me.LocalidadesCmb.Items.Add(DatosMDR!nombre)
        End While
        Me.LocalidadesCmb.Items.Add("< Agregar >")
        'DatosMCmd.Dispose()
        DatosMDR.Close()
    End Sub
    Sub CargarCalles(ByVal Localidad As String)
        SQL = "SELECT nombre from calles where localidad='" & Localidad & "'"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        'comprobar que si ahi datos de configuracion
        While DatosMDR.Read
            Me.CallesCmb.Items.Add(DatosMDR!nombre)
        End While
        Me.CallesCmb.Items.Add("< Agregar >")
        'DatosMCmd.Dispose()
        DatosMDR.Close()
    End Sub

    Private Sub LocalidadesCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalidadesCmb.SelectedIndexChanged
        Try
            Me.LocalidadesCmb.Text = Me.LocalidadesCmb.SelectedItem
            Me.CallesCmb.Text = ""
            Me.Numerotxt.Text = ""
            If Me.LocalidadesCmb.Text = "< Agregar >" Then
                Dim Nueva As String
                Nueva = InputBox("Ingrese el nombre de la nueva localidad", "Nueva Localidad")
                If Nueva.Length = 0 Then
                    Me.LocalidadesCmb.SelectedValue = ""
                    Exit Sub
                End If

                'verificar que no exista
                SQL = "SELECT nombre from localidades where nombre='" & Nueva & "'"
                DatosMCmd = New MySqlCommand
                DatosMCmd.CommandText = SQL
                DatosMCmd.Connection = SQLCnn
                DatosMDR = DatosMCmd.ExecuteReader
                'comprobar que si ahi datos de configuracion
                If DatosMDR.HasRows = True Then
                    MessageBox.Show("La localidad: " & Nueva & Chr(13) & "Ya se encuentra registrada")
                    'DatosMCmd.Dispose()
                    DatosMDR.Close()
                    Exit Sub
                Else
                    'DatosMCmd.Dispose()
                    DatosMDR.Close()
                    'obtener el ultimo Id
                    Dim ID As Integer
                    SQL = "SELECT id_localidad from localidades order by id_localidad desc limit 1"
                    DatosMCmd = New MySqlCommand
                    DatosMCmd.CommandText = SQL
                    DatosMCmd.Connection = SQLCnn
                    DatosMDR = DatosMCmd.ExecuteReader
                    If DatosMDR.HasRows = True Then
                        DatosMDR.Read()
                        ID = DatosMDR!id_localidad + 1
                    Else
                        ID = 1
                    End If
                    'DatosMCmd.Dispose()
                    DatosMDR.Close()

                    SQL = "insert into localidades values(" & ID & ",'" & Nueva & "')"
                    DatosMCmd = New MySqlCommand
                    DatosMCmd.CommandText = SQL
                    DatosMCmd.Connection = SQLCnn
                    'ejecutar consulta
                    DatosMCmd.ExecuteNonQuery()
                    Me.LocalidadesCmb.Items.Add(Nueva)
                    Me.LocalidadesCmb.Text = Nueva
                    'DatosMCmd.Dispose()
                End If
            Else
                Me.CallesCmb.Items.Clear()
                CargarCalles(Me.LocalidadesCmb.Text)
            End If
        Catch Err As MySqlException
            DatosMDR.Close()
            'MessageBox.Show(Err.Message, "MySQL Error: " & Err.Number)
        End Try
    End Sub

    Sub UltimoContrib()
        SQL = "SELECT id from contribuyente order by id desc limit 1"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        'comprobar que si ahi datos de configuracion
        If DatosMDR.HasRows = True Then
            DatosMDR.Read()
            Me.IdContribTxt.Text = DatosMDR!id + 1
        Else
            Me.IdContribTxt.Text = 1
        End If
        'DatosMCmd.Dispose()
        DatosMDR.Close()
    End Sub

    Private Sub CallesCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CallesCmb.SelectedIndexChanged
        Try
            Me.CallesCmb.Text = Me.CallesCmb.SelectedItem
            If Me.CallesCmb.Text = "< Agregar >" Then
                Dim Nueva As String
                Nueva = InputBox("Ingrese el nombre de la nueva calle", "Nueva calle en: " & Me.LocalidadesCmb.Text)
                If Nueva.Length = 0 Then
                    Me.CallesCmb.SelectedValue = ""
                    Exit Sub
                End If
                'verificar que no exista
                SQL = "SELECT nombre from calles where nombre='" & Nueva & "'"
                DatosMCmd = New MySqlCommand
                DatosMCmd.CommandText = SQL
                DatosMCmd.Connection = SQLCnn
                DatosMDR = DatosMCmd.ExecuteReader
                'comprobar que si ahi datos de configuracion
                If DatosMDR.HasRows = True Then
                    MessageBox.Show("La calle: " & Nueva & Chr(13) & "Ya se encuentra registrada")
                    'DatosMCmd.Dispose()
                    DatosMDR.Close()
                    Exit Sub
                Else
                    'DatosMCmd.Dispose()
                    DatosMDR.Close()
                    'obtener el ultimo Id
                    Dim ID As Integer
                    SQL = "SELECT id_calle from calles order by id_calle desc limit 1"
                    DatosMCmd = New MySqlCommand
                    DatosMCmd.CommandText = SQL
                    DatosMCmd.Connection = SQLCnn
                    DatosMDR = DatosMCmd.ExecuteReader
                    If DatosMDR.HasRows = True Then
                        DatosMDR.Read()
                        ID = DatosMDR!id_calle + 1
                    Else
                        ID = 1
                    End If
                    'DatosMCmd.Dispose()
                    DatosMDR.Close()

                    SQL = "insert into calles values(" & ID & ",'" & Me.LocalidadesCmb.Text & "','" & Nueva & "')"
                    DatosMCmd = New MySqlCommand
                    DatosMCmd.CommandText = SQL
                    DatosMCmd.Connection = SQLCnn
                    'ejecutar consulta
                    DatosMCmd.ExecuteNonQuery()
                    Me.CallesCmb.Items.Add(Nueva)
                    Me.CallesCmb.Text = Nueva
                    'DatosMCmd.Dispose()
                End If
            End If
        Catch Err As MySqlException
            MessageBox.Show(Err.Message, "MySQL Error: " & Err.Number)
        End Try
    End Sub
End Class