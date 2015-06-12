Imports System
'Imports MySql.Data.MySqlClient
Public NotInheritable Class Bienvenidopsc
    'Dim Servidor As New Process
    'Dim PruebaCon As MySqlConnection

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).

    Private Sub Bienvenidopsc_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Shell("taskkill.exe /S localhost /F /IM mysqld.exe", AppWinStyle.Hide, ) 'kill mysql server if is started
        'Set up the dialog text at runtime according to the application's assembly information.  

        'TODO: Customize the application's assembly information in the "Application" pane of the project 
        '  properties dialog (under the "Project" menu).

        'Application title
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'If the application title is missing, use the application name, without the extension
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        'Format the version information using the text set into the Version control at design time as the
        '  formatting string.  This allows for effective localization if desired.
        '  Build and revision information could be included by using the following code and changing the 
        '  Version control's designtime text to "Version {0}.{1:00}.{2}.{3}" or something similar.  See
        '  String.Format() in Help for more information.
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Copyright info
        Copyright.Text = My.Application.Info.Copyright
        'Process.Start(Application.StartupPath & "\mysql\bin\mysqld.exe")
        Try
            Shell(Application.StartupPath & "\mysql\bin\mysqld.exe", AppWinStyle.MinimizedNoFocus)
        Catch
            MessageBox.Show("No se inicio el servidor." & Chr(13) & "Inicia nuevamente el sistema, si el problema persiste," & Chr(13) & " contacta al desarrollador del sistema.", "Error al iniciar el orien de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
        ' End If
    End Sub

End Class
