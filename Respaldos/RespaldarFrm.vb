Option Explicit On
Imports System.IO

Public Class RespaldarFrm
    Private Sub CerrarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarBtn.Click
        Me.Close()
    End Sub
    Private Sub RespaldarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RespaldarBtn.Click
        Try
            If Me.RutaLbl.Text <> "" Then
                'aqui se crea el archivo bat que contiene la cadena de texto a ejecutar
                If File.Exists(Me.RutaLbl.Text & "\base" & Now.Day & "-" & Now.Month & "-" & Now.Year & ".bkp") Then
                    MessageBox.Show("Ya existe un respaldo creado hoy, elimine o cambie el nombre del archivo", "Respaldar Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                Dim oSW As New StreamWriter(Application.StartupPath & "\respaldar.bat")
                Dim Linea As String = Application.StartupPath & "\mysql\bin\mysqldump --opt --password=accessdenied --user=root tesoreria > " & Me.RutaLbl.Text & "\base" & Now.Day & "-" & Now.Month & "-" & Now.Year & ".bkp" ' & vbNewLine & "Otra linea de texto"
                oSW.WriteLine(Linea)
                oSW.Flush()
                oSW.Close()
                'Dim RutaRes As String
                'RutaRes = Application.StartupPath & "\base" & Now.Day & "-" & Now.Month & "-" & Now.Year
                'RutaRes = "c:\mysql\bin\mysqldump --opt --password=accessdenied --user=root tesoreria > " & Me.RutaLbl.Text & "\base" & Now.Day & "-" & Now.Month & "-" & Now.Year
                Shell(Application.StartupPath & "\respaldar.bat", AppWinStyle.Hide, True) 'ejecutar archivo bat
                'elimirar el archivo bat
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\respaldar.bat", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.DoNothing)
                MessageBox.Show("El respaldo ha sido creado correctamente", "Respaldar Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Seleccione la carpeta donde se guardara el respaldo", "Respaldar Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Ocurrio un error al crear el respaldo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SelecCarpBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelecCarpBtn.Click
        Me.SelecCarptFbd.ShowDialog()
        Me.RutaLbl.Text = Me.SelecCarptFbd.SelectedPath
    End Sub
End Class
