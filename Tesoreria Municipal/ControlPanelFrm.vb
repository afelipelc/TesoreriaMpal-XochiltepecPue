Imports System
Imports System.Threading
Imports AguaPotable
Imports Contribuyentes
Imports RegistroCivil
Imports ImpuestoPredial
Imports RetroVolteo
Imports Tortilleria
Imports OtrosIngresos
Imports EgresosIngP
Imports Depositos
Imports ReporteGeneral
Imports Respaldos
Imports Facturas
Public Class ControlPanelFrm
    Dim Contribuyentes As Contribuyentes.Cargar
    Dim AguaPotable As AguaPotable.CargarAguafrm
    Dim RegistroCivil As RegistroCivil.CargaRegCivilFrm
    Dim Predios As ImpuestoPredial.CargarPrediosFrm
    Dim RetroVolt As RetroVolteo.CargaRetroVoltFrm
    Dim TortilleriaMpal As Tortilleria.CargarTortilleriaFrm
    Dim OtrosIng As OtrosIngresos.CargarOtrosfrm
    Dim Egresos As EgresosIngP.CargarEgIngPFrm
    Dim Depositos As Depositos.CargarDepositosfrm
    Dim Resumen As ReporteGeneral.CargarIngGeneral
    Dim MoficaFactura As Facturas.ModificarFacturafrm
    Dim FactCancel As Facturas.Canceladasfrm
    Private Sub ControlPanelFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        CargarConfig()
        Me.Text += Ayuntamiento
        Me.infoLbl.Text = "Fecha del sistema: " & Mid(Date.Now, 1, 10)
        'Me.Visible = False
        'Loginfrm.Close()
        'Me.Visible = True
        'MessageBox.Show(System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames(0))
        Dim vence As Date
        vence = "07/03/2011"
        If Now.Date >= "25/02/2011" And Now.Date < vence Then
            MessageBox.Show("Este sistema fue desarrollado para Tesoreria Mpal 2008 - 2011 " & Chr(13) & "dejara de funcionar a partir del 07 de marzo de 2011" & Chr(13) & "Para poder continuar con su uso, contacte a: " & Chr(13) & "Alfonso Felipe Lima Cortes  afelipelc@gmail.com Allende 8, Alta Vista, Xochiltepec, Pue." & Chr(13) & "Desarrollador de este sistema." & Chr(13) & Chr(13) & "Gracias por probar este sistema...")
        End If
        If Now.Date >= vence Then
            Me.MenuStrip1.Enabled = False
            MessageBox.Show("Este sistema fue desarrollado para Tesoreria Mpal 2008 - 2011 " & Chr(13) & "y fue programado para dejar de funcionar a partir del 07 de marzo de 2011" & Chr(13) & "Para poder continuar con su uso, contacte a: " & Chr(13) & "Alfonso Felipe Lima Cortes  afelipelc@gmail.com Allende 8, Alta Vista, Xochiltepec, Pue." & Chr(13) & "Desarrollador de este sistema." & Chr(13) & Chr(13) & "Gracias por probar este sistema...")
        End If
    End Sub

    Private Sub ControlPanelFrm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("¿Confirma salir del Sistema?", "Sistema de Tesoreria", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            'for start server
            'Shell("C:\mysql\bin\mysqld.exe", AppWinStyle.Hide)
            'e.Cancel = False
            'If Contribuyentes.Cerrar = 1 Then
            ' Contribuyentes.Close()
            'End If
            'AguaPotable.Close()
            'Application.Exit()
            'Shell("taskkill.exe /S localhost /F /IM mysqld.exe", AppWinStyle.MinimizedNoFocus) 'kill mysql server
            Shell(Application.StartupPath & "\mysql\bin\mysqladmin --password=accessdenied --user=root shutdown", AppWinStyle.MinimizedNoFocus) 'shutdown mysql server
            Loginfrm.Close()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub SalirBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirBtn.Click
        Me.Close()
    End Sub

    Private Sub ContribuyentesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContribuyentesToolStripMenuItem.Click
        'Dim Contribuyentes As Threading.SemaphoreFullException
        Try
            Contribuyentes = New Contribuyentes.Cargar
            Contribuyentes.login = True
            Contribuyentes.Show()
            Contribuyentes.Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub AguaPotableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AguaPotableToolStripMenuItem.Click
        Try
            AguaPotable = New AguaPotable.CargarAguafrm
            AguaPotable.login = True
            AguaPotable.Show()
            AguaPotable.Visible = False
        Catch Err As Exception
            MessageBox.Show(Err.Message)
        End Try
    End Sub

    Private Sub DatosGeneralesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatosGeneralesToolStripMenuItem1.Click
        ConectaServer()
        Configfrm.ShowDialog()
        SQLCnn.Close()
    End Sub

    Private Sub RegistroCivilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroCivilToolStripMenuItem.Click
        Try
            RegistroCivil = New RegistroCivil.CargaRegCivilFrm
            RegistroCivil.Login = True
            RegistroCivil.Show()
            RegistroCivil.Visible = False
        Catch Err As Exception
            MessageBox.Show(Err.Message)
        End Try
    End Sub

    Private Sub ImpuestoPredialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImpuestoPredialToolStripMenuItem.Click
        Try
            Predios = New ImpuestoPredial.CargarPrediosFrm
            Predios.Login = True
            Predios.Show()
            Predios.Visible = False
        Catch Err As Exception
            MessageBox.Show(Err.Message)
        End Try
    End Sub

    Private Sub TrascaboYVolteoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrascaboYVolteoToolStripMenuItem.Click
        Try
            RetroVolt = New RetroVolteo.CargaRetroVoltFrm
            RetroVolt.Login = True
            RetroVolt.Show()
            RetroVolt.Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TortiMpalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TortiMpalToolStripMenuItem.Click
        Try
            TortilleriaMpal = New Tortilleria.CargarTortilleriaFrm
            TortilleriaMpal.Login = True
            TortilleriaMpal.Show()
            TortilleriaMpal.Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub OtrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtrosToolStripMenuItem.Click
        Try
            OtrosIng = New OtrosIngresos.CargarOtrosfrm
            OtrosIng.Login = True
            OtrosIng.Show()
            OtrosIng.Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub EgresosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EgresosToolStripMenuItem.Click
        Try
            Egresos = New EgresosIngP.CargarEgIngPFrm
            Egresos.Login = True
            Egresos.Show()
            Egresos.Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DepositosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepositosToolStripMenuItem.Click
        Try
            Depositos = New Depositos.CargarDepositosfrm
            Depositos.Login = True
            Depositos.Show()
            Depositos.Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ReporteGeneralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteGeneralToolStripMenuItem.Click
        Try
            Resumen = New ReporteGeneral.CargarIngGeneral
            Resumen.Login = True
            Resumen.Show()
            Resumen.Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RespaldarBDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RespaldarBDToolStripMenuItem.Click
        Try
            Dim Respaldar As Respaldos.RespaldarFrm
            Respaldar = New Respaldos.RespaldarFrm
            Respaldar.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RestaurarBDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestaurarBDToolStripMenuItem.Click
        Try
            Dim Restaurar As Respaldos.RestaurarFrm
            Restaurar = New Respaldos.RestaurarFrm
            Restaurar.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub UsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuarioToolStripMenuItem.Click
        UsuariosFrm.ShowDialog()
    End Sub

    Private Sub BorrarDatosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrarDatosToolStripMenuItem.Click
        BorrarDatosFrm.ShowDialog()
    End Sub

    Private Sub CambiarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarToolStripMenuItem.Click
        Try
            MoficaFactura = New Facturas.ModificarFacturafrm
            MoficaFactura.Show()
        Catch Err As Exception
            MessageBox.Show(Err.Message)
        End Try
    End Sub

    Private Sub CanceladasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CanceladasToolStripMenuItem.Click
        Try
            FactCancel = New Facturas.Canceladasfrm
            FactCancel.Show()
        Catch Err As Exception
            MessageBox.Show(Err.Message)
        End Try
    End Sub
End Class