Option Explicit On
Imports System.IO
Imports MySql.Data.MySqlClient
Module Generalmdl
    Public Ayuntamiento As String

    Public SQL, SCnn As String
    Public SQLCnn As MySqlConnection
    Public DatosMCmd As MySqlCommand
    Public DatosMDR As MySqlDataReader
    Public ConectedSer As Boolean
    Public Sub ConectaServer()
        'Connect = New MySqlConnection()
        SCnn = "server=localhost; user id=root; password=accessdenied; database=tesoreria"
        Try
            SQLCnn = New MySqlConnection(SCnn)
            SQLCnn.Open()
            ConectedSer = True
            'MessageBox.Show("Conexion establecida")
        Catch myerror As MySqlException
            'MessageBox.Show("Error: " & myerror.Number & " " & myerror.Message)
            Select Case myerror.Number
                Case 0
                    MessageBox.Show("No se encontro el origen de datos " & Chr(13) & "Error: " & myerror.Number)
                Case 1045
                    MessageBox.Show("Acceso denegado: Nombre de usuario y contraseña incorrectos" & Chr(13) & "Error: " & myerror.Number)
                Case 1044
                    MessageBox.Show("Acceso denegado a la base de datos" & Chr(13) & "Error: " & myerror.Number)
                Case 1042
                    MessageBox.Show("El origen de este problema es que modifico la ruta, elimino información o elimino archivos del sistema", "No se puede conectar al servidor", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'aqui se restaura my.ini
                    RestaurarMySql()
                    MessageBox.Show("Se restauro el archivo de configuración de BD" & Chr(13) & "Si el problema persiste contacte al autor del sistema", "Vuelva a iniciar el sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select
            ConectedSer = False
        End Try
    End Sub
    Public Sub CargarConfig()
        ConectaServer()
        SQL = "SELECT * from configuracion"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        'comprobar que si ahi datos de configuracion
        If DatosMDR.HasRows = True Then
            DatosMDR.Read()
            Ayuntamiento = DatosMDR!municipio
            DatosMDR.Close()
            SQLCnn.Close()
            Exit Sub
        Else
            DatosMDR.Close()
            Configfrm.Nuevo = True
            Configfrm.ShowDialog()
            SQLCnn.Close()
        End If
        'DatosMCmd.Dispose()

        'Ayuntamiento = "Xochiltepec, Puebla."

    End Sub
    Sub RestaurarMySql()
        Try
            If File.Exists(Application.StartupPath & "\mysql\my.ini") Then 'eliminar el archivo mysql.ini si existe
                My.Computer.FileSystem.DeleteFile( _
                                Application.StartupPath & "\mysql\my.ini", _
                                FileIO.UIOption.OnlyErrorDialogs, _
                                FileIO.RecycleOption.DeletePermanently, _
                                FileIO.UICancelOption.DoNothing)
            End If
            'convertir la ruta con diagonales a / /
            'Application.StartupPath.Format()
            'aqui se crea el archivo
            Dim oSW As New StreamWriter(Application.StartupPath & "\mysql\my.ini")

            Dim Linea As String
            Linea = "# FILE CREATED BY TESORERIA MUNICIPAL SYSTEM" ' & vbNewLine & "Otra linea de texto"
            Linea += vbNewLine & "# AUTOR: ALFONSO FELIPE LIMA CORTES, XOCHILTEPEC, PUEBLA. JULIO DE 2008"
            Linea += vbNewLine & "################################################"
            Linea += vbNewLine & "# NO MODIFIQUE ESTE ARCHIVO, PODRIA CAUSAR PROBLEMAS GRAVES AL SISTEMA"
            Linea += vbNewLine & vbNewLine & "[client]" & vbNewLine & "port=3306"
            Linea += vbNewLine & "[mysqld]" & vbNewLine & "port=3306"
            Linea += vbNewLine & "basedir=" & Chr(34) & Application.StartupPath.Replace("\", "/") & "/mysql" & Chr(34)
            Linea += vbNewLine & "datadir=" & Chr(34) & Application.StartupPath.Replace("\", "/") & "/mysql/data" & Chr(34)
            Linea += vbNewLine & "default-character-set=latin1"
            Linea += vbNewLine & "default-storage-engine=INNODB"
            Linea += vbNewLine & "max_connections=10"
            Linea += vbNewLine & "query_cache_size=0"
            Linea += vbNewLine & "table_cache=256"
            Linea += vbNewLine & "tmp_table_size=5M"
            Linea += vbNewLine & "myisam_max_sort_file_size=100G"
            Linea += vbNewLine & "myisam_max_extra_sort_file_size=100G"
            Linea += vbNewLine & "myisam_sort_buffer_size=8M"
            Linea += vbNewLine & "key_buffer_size=8M"
            Linea += vbNewLine & "read_rnd_buffer_size=256K"
            Linea += vbNewLine & "sort_buffer_size=212K"
            Linea += vbNewLine & "innodb_additional_mem_pool_size=2M"
            Linea += vbNewLine & "innodb_flush_log_at_trx_commit=1"
            Linea += vbNewLine & "innodb_log_buffer_size=1M"
            Linea += vbNewLine & "innodb_buffer_pool_size=8M"
            Linea += vbNewLine & "innodb_log_file_size=10M"
            Linea += vbNewLine & "innodb_thread_concurrency=8"
            oSW.WriteLine(Linea)
            oSW.Flush()
            oSW.Close()
        Catch
            Exit Sub
        End Try
    End Sub
End Module
