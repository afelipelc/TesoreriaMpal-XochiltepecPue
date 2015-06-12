Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Drawing.Printing
Imports System.String
Public Class NotificacionFrm
    Dim Contrib, Texto, Atentamente, Tesorero, Municipio As String
    Private Sub NotificacionFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cargar los datos 
        SQL = "SELECT municipio, tesorero, textopredio from configuracion"
        DatosMCmd = New MySqlCommand
        DatosMCmd.CommandText = SQL
        DatosMCmd.Connection = SQLCnn
        DatosMDR = DatosMCmd.ExecuteReader
        If DatosMDR.HasRows = True Then
            DatosMDR.Read()
            Municipio = DatosMDR!municipio.ToString
            Tesorero = DatosMDR!tesorero.ToString.ToUpper
            Texto = DatosMDR!textopredio.ToString
            DatosMDR.Close()
        End If
        DatosMDR.Close()
        Me.NotificacionPpv.Refresh()
    End Sub

    Private Sub NotificacionPD_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles NotificacionPD.PrintPage
        Dim stringFormat As New StringFormat()
        Dim tabStops As Single() = {50.0F, 50.0F, 50.0F, 50.0F}
        stringFormat.SetTabStops(0.0F, tabStops)
        'Dim Texto As String

        'Dim Fuente As Font
        Dim Fuente As New Font("Arial", 12)
        Dim Fuente2 As New Font("Arial", 7)
        Dim FNegrita As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point)
        'Texto = ControlChars.Tab & "Por este medio me dirijo a usted con el debido respeto para invitarle a pasar a la Tesoreria Municipal a cubrir su adeudo con respecto a su servicio de aga potable. Sin otro asunto que tratar me despido de usted. Anexo los detalles de su adeudo"

        Try

            e.Graphics.DrawString("Sistema de cobro de impuesto predial del Municipio de " & Municipio, Fuente2, Brushes.Gray, 10, 10, New StringFormat())

            Dim AtentRec As New Rectangle(200, 365, 450, 150)
            Dim TituloRec As New Rectangle(50, 40, 500, 50)
            Dim ContentRec As New Rectangle(50, 95, 750, 280)


            ' Create a StringFormat object with the each line of text, and the block
            ' of text centered on the page.

            Contrib = "C. " & CobrarFrm.NombreTxt.Text.ToUpper & ControlChars.CrLf & "P R E S E N T E"
            'dibujar el nombre del contrib.
            stringFormat.Alignment = StringAlignment.Near
            stringFormat.LineAlignment = StringAlignment.Near

            e.Graphics.DrawString(Contrib, FNegrita, Brushes.Black, TituloRec, stringFormat)
            'e.Graphics.DrawRectangle(Pens.Black, TituloRec)

            Dim Contenido As String
            Contenido = ControlChars.Tab & Texto & ControlChars.CrLf & ControlChars.CrLf & "Detalles de su adeudo;   Número de cuenta: " & CobrarFrm.NoCuentaTxt.Text.ToString & ControlChars.CrLf
            Contenido += "AÑO " & ControlChars.Tab & ControlChars.Tab & "ADEUDO" & ControlChars.Tab & ControlChars.Tab & ControlChars.Tab & "AÑO" & ControlChars.Tab & ControlChars.Tab & "ADEUDO" & ControlChars.CrLf
            Dim i, No As Short
            No = 0
            For i = 0 To CobrarFrm.ImpuestosDtg.Columns.Count - 1
                No += 1
                If No = 1 Then
                    Contenido += Mid(CobrarFrm.ImpuestosDtg.Columns(i).HeaderText.ToString, 4, 4) & ControlChars.Tab & ControlChars.Tab & "$ " & CobrarFrm.ImpuestosDtg.Item(i, 0).Value.ToString & ControlChars.Tab & ControlChars.Tab & ControlChars.Tab
                End If
                If No = 2 Then
                    Contenido += Mid(CobrarFrm.ImpuestosDtg.Columns(i).HeaderText.ToString, 4, 4) & ControlChars.Tab & ControlChars.Tab & "$ " & CobrarFrm.ImpuestosDtg.Item(i, 0).Value.ToString & ControlChars.CrLf
                    No = 0
                End If
            Next
            Contenido += ControlChars.CrLf & "Su adeudo total es de " & CobrarFrm.AnosPagTxt.Text.ToString & " año(s) con un importe total de $ " & CobrarFrm.AdeuTotTxt.Text.ToString & " pesos."

            'contenido +

            'dibujar el contenido
            stringFormat.Alignment = StringAlignment.Near
            stringFormat.LineAlignment = StringAlignment.Near
            e.Graphics.DrawString(Contenido, Fuente, Brushes.Black, ContentRec, stringFormat)
            'e.Graphics.DrawRectangle(Pens.Black, ContentRec)

            stringFormat.Alignment = StringAlignment.Center
            stringFormat.LineAlignment = StringAlignment.Center
            Atentamente = "A T E N T A M E N T E" & ControlChars.CrLf & Municipio.ToUpper & " A " & Now.Day & " DE " & System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames(Now.Month - 1).ToUpper & " DE " & Now.Year & ControlChars.CrLf & "LA OFICINA RECAUDADORA" & ControlChars.CrLf & ControlChars.CrLf & ControlChars.CrLf & " _________________________________" & ControlChars.CrLf & "C. " & Tesorero
            ' Draw the text and the surrounding rectangle.
            e.Graphics.DrawString(Atentamente, FNegrita, Brushes.Black, AtentRec, stringFormat)
            'e.Graphics.DrawRectangle(Pens.Black, AtentRec)
        Finally
            FNegrita.Dispose()
            Fuente.Dispose()
        End Try
    End Sub

    Private Sub Imprimirbrn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Imprimirbrn.Click
        Me.ImprimirPDlg.AllowSomePages = True

        ' Show the help button.
        Me.ImprimirPDlg.ShowHelp = True

        ' Set the Document property to the PrintDocument for 
        ' which the PrintPage Event has been handled. To display the
        ' dialog, either this property or the PrinterSettings property 
        ' must be set 
        Me.ImprimirPDlg.Document = Me.NotificacionPD

        Dim result As DialogResult = Me.ImprimirPDlg.ShowDialog()

        ' If the result is OK then print the document.
        If (result = Windows.Forms.DialogResult.OK) Then
            Me.NotificacionPD.Print()
        End If
    End Sub
End Class