Option Explicit On
Imports System.IO
Public Class RestaurarFrm
    Dim Ruta As String
    Private Sub RestaurarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestaurarBtn.Click
        Try
            If Me.RutaLbl.Text <> "" Then
                Ruta = Me.RutaLbl.Text
                Me.RutaLbl.Text = "Espere un monento mientras el sistema restaura la base de datos..."
                If MessageBox.Show("¿Confirma restaurar la base de datos del sistema?" & Chr(13) & "Si cuenta con un respaldo actual, podra restaurar si lo requiere", "Restaurar base de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    'aqui se crea el archivo bat que contiene la cadena de texto a ejecutar
                    Dim oSW As New StreamWriter(Application.StartupPath & "\restaurar.bat")
                    Dim Linea As String = Application.StartupPath & "\mysql\bin\mysql --password=accessdenied --user=root tesoreria < " & Ruta ' & vbNewLine & "Otra linea de texto"
                    oSW.WriteLine(Linea)
                    oSW.Flush()
                    oSW.Close()
                    'Dim RutaRes As String
                    'RutaRes = Application.StartupPath & "\base" & Now.Day & "-" & Now.Month & "-" & Now.Year
                    'RutaRes = "c:\mysql\bin\mysqldump --opt --password=accessdenied --user=root tesoreria > " & Me.RutaLbl.Text & "\base" & Now.Day & "-" & Now.Month & "-" & Now.Year

                    Shell(Application.StartupPath & "\restaurar.bat", AppWinStyle.Hide, True) 'ejecutar archivo bat
                    'elimirar el archivo bat
                    My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\restaurar.bat", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.DoNothing)
                    MessageBox.Show("La base de datos ha sido restaurada correctamente", "Restaurar Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Me.RutaLbl.Text = ""
            Else
                MessageBox.Show("Seleccione el archivo de respaldo", "Restaurar Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Ocurrio un error al restaurar la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CerrarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarBtn.Click
        Me.Close()
    End Sub

    Private Sub RestaurarFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MessageBox.Show("Cierre todos los modulos que esten abiertos, para prevenir errores", "Restaurar Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.OpenFileDialog1.Multiselect = False
        Me.OpenFileDialog1.Filter = "Archivos de Respaldo(*.bkp)|*.bkp"
        Me.OpenFileDialog1.ShowDialog()
        Me.RutaLbl.Text = Me.OpenFileDialog1.FileName
    End Sub
End Class