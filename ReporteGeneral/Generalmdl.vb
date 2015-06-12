Imports MySql.Data.MySqlClient
Module Generalmdl
    Public NoMes As String
    Public SQL, SCnn, Ayuntamiento As String
    Public SQLCnn As MySqlConnection
    Public DatosMCmd As MySqlCommand
    Public DatosMDR As MySqlDataReader
    Public DatosAno As Short

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
            'DiaCobroMes = DatosMDR!diacobro
            DatosAno = DatosMDR!datos_ano
        End If
        'DatosMCmd.Dispose()
        DatosMDR.Close()
        'Ayuntamiento = "Xochiltepec, Puebla."

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
End Module
