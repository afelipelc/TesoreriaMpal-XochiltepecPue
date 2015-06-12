Imports MySql.Data.MySqlClient
Module Generalmdl
    Public NoMes As String
    Public SQL, SCnn, Ayuntamiento As String
    Public SQLCnn As MySqlConnection
    Public DatosMCmd As MySqlCommand
    Public DatosMDR As MySqlDataReader
    Public PeriodoMeses As Integer
    Public DiaCobroMes, DatosAno As Short
    Public Sub ConectaServer()
        'Connect = New MySqlConnection()
        SCnn = "server=localhost; user id=root; password=accessdenied; database=tesoreria"
        Try
            SQLCnn = New MySqlConnection(SCnn)
            SQLCnn.Open()
        Catch myerror As MySqlException
            'MessageBox.Show("Error: " & myerror.Number & " " & myerror.Message)
            Select Case myerror.Number
                Case 0
                    MessageBox.Show("No se encontro el origen de datos " & Chr(13) & "Error: " & myerror.Number)
                Case 1045
                    MessageBox.Show("Acceso denegado: Nombre de usuario y contraseña incorrectos" & Chr(13) & "Error: " & myerror.Number)
                Case 1044
                    MessageBox.Show("Acceso denegado a la base de datos" & Chr(13) & "Error: " & myerror.Number)
            End Select
        End Try
    End Sub
    Public Sub ObtenNMes(ByVal Mes As String)
        Select Case Mes
            Case "enero"
                NoMes = "01"
            Case "febrero"
                NoMes = "02"
            Case "marzo"
                NoMes = "03"
            Case "abril"
                NoMes = "04"
            Case "mayo"
                NoMes = "05"
            Case "junio"
                NoMes = "06"
            Case "julio"
                NoMes = "07"
            Case "agosto"
                NoMes = "08"
            Case "septiembre"
                NoMes = "09"
            Case "octubre"
                NoMes = "10"
            Case "noviembre"
                NoMes = "11"
            Case "diciembre"
                NoMes = "12"
        End Select
    End Sub
    

    Public Function SoloNumeros(ByVal Keyascii As Short) As Short 'funcion utilizada en cuadros de texto que solo aceptan numeros
        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            SoloNumeros = 0
        Else
            SoloNumeros = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNumeros = Keyascii
            Case 13
                SoloNumeros = Keyascii
        End Select
    End Function
    Public Sub CargarConfig()
        'ConectaServer()
        SQL = "SELECT * from configuracion"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        'comprobar que si ahi datos de configuracion
        If DatosMDR.HasRows = True Then
            DatosMDR.Read()
            Ayuntamiento = DatosMDR!municipio
            DiaCobroMes = DatosMDR!diacobro
            DatosAno = DatosMDR!datos_ano
        End If
        'DatosMCmd.Dispose()
        DatosMDR.Close()
        'Ayuntamiento = "Xochiltepec, Puebla."

    End Sub

    Public Function NumeroDec(ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal Text As TextBox) As Integer

        Dim dig As Integer = Len(Text.Text & e.KeyChar)
        Dim a, esDecimal, NumDecimales As Integer
        Dim esDec As Boolean
        ' se verifica si es un digito o un punto 
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            Return a
        Else
            e.Handled = True
        End If
        ' se verifica que el primer digito ingresado no sea un punto al seleccionar
        If Text.SelectedText <> "" Then
            If e.KeyChar = "." Then
                e.Handled = True
                Return a
            End If
        End If
        If dig = 1 And e.KeyChar = "." Then
            e.Handled = True
            Return a
        End If
        'aqui se hace la verificacion cuando es seleccionado el valor del texto
        'y no sea considerado como la adicion de un digito mas al valor ya contenido en el textbox
        If Text.SelectedText = "" Then
            ' aqui se hace el for para controlar que el numero sea de dos digitos - contadose a partir del punto decimal.
            For a = 0 To dig - 1
                Dim car As String = CStr(Text.Text & e.KeyChar)
                If car.Substring(a, 1) = "." Then
                    esDecimal = esDecimal + 1
                    esDec = True
                End If
                If esDec = True Then
                    NumDecimales = NumDecimales + 1
                End If
                ' aqui se controla los digitos a partir del punto numdecimales = 4 si es de dos decimales 
                If NumDecimales >= 4 Or esDecimal >= 2 Then
                    e.Handled = True
                End If
            Next
        End If
    End Function
End Module
