Imports MySql.Data.MySqlClient
Module Generalmdl
    Public SQL, SCnn As String
    Public SQLCnn As MySqlConnection
    Public DatosMCmd As MySqlCommand
    Public DatosMDR As MySqlDataReader
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
End Module
