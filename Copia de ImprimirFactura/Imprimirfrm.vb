Imports System.Text
Imports System.Drawing.Printing
Imports System.String
Public Class Imprimirfrm
    Dim WithEvents pd As Printing.PrintDocument
    Public Contrib, Cantidad, Contenido, CantidStr, PUnit, Totals As String
    Public TotNeto As Double
    Public Imprimir As Boolean
    Dim Fechal, Tesorero, Municipio As String

    Private Sub Imprimirfrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Contrib = ""
        Cantidad = ""
        Contenido = ""
        CantidStr = ""
        PUnit = ""
        Totals = ""
        TotNeto = 0
        Fechal = ""
    End Sub
    Private Sub Imprimirfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.Imprimir = True Then
            pd = New Printing.PrintDocument
            Dim Factura As New Printing.PaperSize("Custom Paper Size", 600, 750)
            '        pd.PrinterSettings.DefaultPageSettings.PaperSize = pkCustomSize1
            Me.FacturaPD.DefaultPageSettings.PaperSize = Factura
            Me.FacturaPD.DefaultPageSettings.Margins.Top = 0
            Me.FacturaPD.DefaultPageSettings.Margins.Left = 0
            Dim i As Short
            For i = 1 To 3
                FacturaPD.Print()
            Next
            Me.Close()
        Else
            MessageBox.Show("No se han proporcionado los datos a imprimir", "ERROR AL IMPRIMIR FACTURA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            'origen.Close()
        End If
    End Sub

    Private Sub FacturaPD_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles FacturaPD.PrintPage
        Dim stringFormat As New StringFormat()
        Dim tabStops As Single() = {50.0F, 50.0F, 50.0F, 50.0F}
        stringFormat.SetTabStops(0.0F, tabStops)
        'Dim Texto As String

        'Dim Fuente As Font
        Dim Fuente As New Font("Arial", 11)
        Dim Fuente2 As New Font("Arial", 7)
        Dim FNegrita As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point)
        'Texto = ControlChars.Tab & "Por este medio me dirijo a usted con el debido respeto para invitarle a pasar a la Tesoreria Municipal a cubrir su adeudo con respecto a su servicio de aga potable. Sin otro asunto que tratar me despido de usted. Anexo los detalles de su adeudo"

        Try

            'e.Graphics.DrawString("Sistema de cobro de agua potable del Municipio de " & Municipio, Fuente2, Brushes.Gray, 10, 10, New StringFormat())

            Dim Datoscont As New Rectangle(120, 186, 450, 55)
            Dim Cantidades As New Rectangle(46, 284, 50, 180)
            Dim DescConcep As New Rectangle(102, 284, 240, 180)
            Dim PU As New Rectangle(332, 284, 78, 180)
            Dim Totales As New Rectangle(413, 284, 93, 180)
            Dim Neto As New Rectangle(413, 492, 95, 20)
            Dim Cantidadletra As New Rectangle(48, 654, 480, 20)
            Dim Fecha As New Rectangle(48, 680, 480, 20)

            ' Create a StringFormat object with the each line of text, and the block
            ' of text centered on the page.
            'ControlChars.CrLf es  una nueva linea
            'ControlChars.Tab ES UN TAP


            'DATOS DEL CONTRIBUYENTE
            ''Contrib = "NOMBRE DEL CONTRIBUYENTE " & ControlChars.CrLf & "DIRECCION DEL CONTRIBUYENTE" & ControlChars.CrLf & "MUNICIPIO" & ControlChars.CrLf
            'dibujar el nombre del contrib.
            stringFormat.Alignment = StringAlignment.Near
            stringFormat.LineAlignment = StringAlignment.Near

            e.Graphics.DrawString(Contrib, FNegrita, Brushes.Black, Datoscont, stringFormat)
            'e.Graphics.DrawRectangle(Pens.Black, Datoscont)

            'CANTIDAD, DESCRIPCION, P.U., TOTALES


            'Dim Contenido As String
            'Contenido = ControlChars.Tab & Texto & ControlChars.CrLf & ControlChars.CrLf & "Detalles de su adeudo; Número de toma: " & CobrarAguafrm.IdTomatxt.Text.ToString & ",  Tomas instaladas: " & CobrarAguafrm.NoTomasTxt.Text.ToString & ControlChars.CrLf
            ''Contenido = "AQUI LA DESCRIPCION DEL C ONTENIDO " ' & ControlChars.CrLf & "AQUI EL OTRO CONCEPTO"
            Dim I, a As Decimal

            I = Contenido.Length / 25 'obtiene el numero de lineas que tiene la descripcion 'REEMPLAZAR CONTENIDO POR LA DESCRIPCION ORIGINAL
            If ((Contenido.Length / 25) - Int(Contenido.Length / 25)) > 0 Then
                I = Int(Contenido.Length / 25) + 1
            Else
                I = Int(Contenido.Length / 25)
            End If
            'Contenido += ControlChars.CrLf & "Su adeudo total es de " & CobrarAguafrm.TotalMesesTxt.Text.ToString & " meses con un importe total de $ " & CobrarAguafrm.AdeuTotTxt.Text.ToString & " pesos."
            'contenido +

            'dibujar la descripcion del concepto
            stringFormat.Alignment = StringAlignment.Near
            stringFormat.LineAlignment = StringAlignment.Near
            e.Graphics.DrawString(Contenido.ToUpper, Fuente, Brushes.Black, DescConcep, stringFormat)
            'e.Graphics.DrawRectangle(Pens.Black, DescConcep)

            'PARA IMPRIMIR LAS CANTIDADES, VERIFICAR SI LA DESCRIPCION OCUPA VARIOS RENGLONES PARA AUMENTALOS A LOS TOTALES

            'Dim CantidStr As String
            ''CantidStr = "1" & ControlChars.CrLf
            stringFormat.Alignment = StringAlignment.Center
            stringFormat.LineAlignment = StringAlignment.Near
            e.Graphics.DrawString(CantidStr, Fuente, Brushes.Black, Cantidades, stringFormat)
            'e.Graphics.DrawRectangle(Pens.Black, Cantidades)

            'IMPRIMIR LOS PRECIOS UNITARIOS
            'Dim PUnit As String
            ''PUnit = "$100.00" & ControlChars.CrLf & I & " " & a

            stringFormat.Alignment = StringAlignment.Far
            stringFormat.LineAlignment = StringAlignment.Near
            e.Graphics.DrawString(PUnit, Fuente, Brushes.Black, PU, stringFormat)
            'e.Graphics.DrawRectangle(Pens.Black, PU)

            'IMPRIMIR LOS TOTALES
            'Dim Totals As String
            ''Totals = "$100.00" & ControlChars.CrLf
            stringFormat.Alignment = StringAlignment.Far
            stringFormat.LineAlignment = StringAlignment.Near
            e.Graphics.DrawString(Totals, FNegrita, Brushes.Black, Totales, stringFormat)
            'e.Graphics.DrawRectangle(Pens.Black, Totales)

            'IMPRIMIR EL TOTAL NETO
            'Dim TotNeto As String
            ''TotNeto = "100.00" & ControlChars.CrLf
            stringFormat.Alignment = StringAlignment.Far
            stringFormat.LineAlignment = StringAlignment.Near
            e.Graphics.DrawString(String.Format("{0:c}", TotNeto), FNegrita, Brushes.Black, Neto, stringFormat)
            'e.Graphics.DrawRectangle(Pens.Black, Neto)

            'IMPRIMIR LA CANTIDAD CON LETRA
            stringFormat.Alignment = StringAlignment.Center
            stringFormat.LineAlignment = StringAlignment.Near
            Cantidad = num_letras(TotNeto).ToUpper '& ControlChars.CrLf
            ' Draw the text and the surrounding rectangle.
            e.Graphics.DrawString(Cantidad, FNegrita, Brushes.Black, Cantidadletra, stringFormat)
            'e.Graphics.DrawRectangle(Pens.Black, Cantidadletra)

            'IMPRIMIR LA FECHA
            stringFormat.Alignment = StringAlignment.Near
            stringFormat.LineAlignment = StringAlignment.Near
            Select Case System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames(Now.Month - 1).ToString.Length
                Case Is <= 5
                    Fechal = ControlChars.Tab & "             " & Now.Day & "           " & System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames(Now.Month - 1).ToUpper & ControlChars.Tab & ControlChars.Tab & ControlChars.Tab & "         " & Now.Year & ControlChars.CrLf
                Case Is <= 7
                    Fechal = ControlChars.Tab & "             " & Now.Day & "           " & System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames(Now.Month - 1).ToUpper & ControlChars.Tab & ControlChars.Tab & ControlChars.Tab & " " & Now.Year & ControlChars.CrLf
                Case Is > 7
                    Fechal = ControlChars.Tab & "             " & Now.Day & "           " & System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames(Now.Month - 1).ToUpper & ControlChars.Tab & ControlChars.Tab & ControlChars.Tab & Now.Year & ControlChars.CrLf
            End Select

            ' Draw the text and the surrounding rectangle.
            e.Graphics.DrawString(Fechal, FNegrita, Brushes.Black, Fecha, stringFormat)
            'e.Graphics.DrawRectangle(Pens.Black, Fecha)
            'Me.FacturaPD.Print()
        Finally
            FNegrita.Dispose()
            Fuente.Dispose()
        End Try
    End Sub
    Function num_letras(ByVal numero As Double) As String
        Dim letras As String
        letras = ""
        Dim HuboCentavos As Boolean
        Dim decimales As Double
        decimales = numero - Int(numero)
        numero = Int(numero)
        Dim Numeros(90) As String
        Numeros(0) = "cero "
        Numeros(1) = "uno "
        Numeros(2) = "dos "
        Numeros(3) = "tres "
        Numeros(4) = "cuatro "
        Numeros(5) = "cinco "
        Numeros(6) = "seis "
        Numeros(7) = "siete "
        Numeros(8) = "ocho "
        Numeros(9) = "nueve "
        Numeros(10) = "diez "
        Numeros(11) = "once "
        Numeros(12) = "doce "
        Numeros(13) = "trece "
        Numeros(14) = "catorce "
        Numeros(15) = "quince "
        Numeros(16) = "dieciséis "
        Numeros(17) = "diecisiete "
        Numeros(18) = "dieciocho "
        Numeros(19) = "diecinueve "
        Numeros(20) = "veinte "
        Numeros(21) = "veintiuno "
        Numeros(22) = "veintidós "
        Numeros(23) = "veintitrés "
        Numeros(24) = "veinticuatro "
        Numeros(25) = "veinticinco "
        Numeros(26) = "veintiséis "
        Numeros(27) = "veintisiete "
        Numeros(28) = "veintiocho "
        Numeros(29) = "veintinueve "
        Numeros(30) = "treinta "
        Numeros(40) = "cuarenta "
        Numeros(50) = "cincuenta "
        Numeros(60) = "sesenta "
        Numeros(70) = "setenta "
        Numeros(80) = "ochenta "
        Numeros(90) = "noventa "
        Do
            '*---> Centenas de Millón
            If (numero < 1000000000) And (numero >= 100000000) Then
                If (Int(numero / 100000000) = 1) And ((numero - (Int(numero / 100000000) * 100000000)) < 1000000) Then
                    letras = letras & "Cien millones "
                Else
                    Select Case Int(numero / 100000000)
                        Case 1
                            letras = letras & "Ciento"
                        Case 5
                            letras = letras & "Quinientos"
                        Case 7
                            letras = letras & "Setecientos"
                        Case 9
                            letras = letras & "Novecientos"
                        Case Else
                            letras = letras & Numeros(Int(numero / 100000000))
                    End Select
                    If (Int(numero / 100000000) <> 1) And (Int(numero / 100000000) <> 5) And (Int(numero / 100000000) <> 7) And (Int(numero / 100000000) <> 9) Then
                        letras = letras & "cientos "
                    Else
                        letras = letras & " "
                    End If
                End If
                numero = numero - (Int(numero / 100000000) * 100000000)
            End If
            '*---> Decenas de Millón
            If (numero < 100000000) And (numero >= 10000000) Then
                If Int(numero / 1000000) < 16 Then
                    letras = letras & Numeros(Int(numero / 1000000))
                    letras = letras & " millones "
                    numero = numero - (Int(numero / 1000000) * 1000000)
                Else
                    letras = letras & Numeros(Int(numero / 10000000) * 10)
                    numero = numero - (Int(numero / 10000000) * 10000000)
                    If numero > 1000000 Then
                        letras = letras & " y "
                    End If
                End If
            End If
            '*---> Unidades de Millón
            If (numero < 10000000) And (numero >= 1000000) Then
                If Int(numero / 1000000) = 1 Then
                    letras = letras & " Un millón "
                Else
                    letras = letras & Numeros(Int(numero / 1000000))
                    letras = letras & " millones "
                End If
                numero = numero - (Int(numero / 1000000) * 1000000)
            End If
            '*---> Centenas de Millar
            If (numero < 1000000) And (numero >= 100000) Then
                If (Int(numero / 100000) = 1) And ((numero - (Int(numero / 100000) * 100000)) < 1000) Then
                    letras = letras & "Cien mil "
                Else
                    Select Case Int(numero / 100000)
                        Case 1
                            letras = letras & "Ciento"
                        Case 5
                            letras = letras & "Quinientos"
                        Case 7
                            letras = letras & "Setecientos"
                        Case 9
                            letras = letras & "Novecientos"
                        Case Else
                            letras = letras & Numeros(Int(numero / 100000))
                    End Select
                    If (Int(numero / 100000) <> 1) And (Int(numero / 100000) <> 5) And (Int(numero / 100000) <> 7) And (Int(numero / 100000) <> 9) Then
                        letras = letras & "cientos "
                    Else
                        letras = letras & " mil "
                    End If
                End If
                numero = numero - (Int(numero / 100000) * 100000)
            End If
            '*---> Decenas de Millar
            If (numero < 100000) And (numero >= 10000) Then
                If Int(numero / 1000) < 16 Then
                    letras = letras & Numeros(Int(numero / 1000))
                    letras = letras & " mil "
                    numero = numero - (Int(numero / 1000) * 1000)
                Else
                    letras = letras & Numeros(Int(numero / 10000) * 10)
                    numero = numero - (Int((numero / 10000)) * 10000)
                    If numero > 1000 Then
                        letras = letras & " y "
                    Else
                        letras = letras & " mil "
                    End If
                End If
            End If
            '*---> Unidades de Millar
            If (numero < 10000) And (numero >= 1000) Then
                If Int(numero / 1000) = 1 Then
                    letras = letras & "Un"
                Else
                    letras = letras & Numeros(Int(numero / 1000))
                End If
                letras = letras & " mil "
                numero = numero - (Int(numero / 1000) * 1000)
            End If
            '*---> Centenas
            If (numero < 1000) And (numero > 99) Then
                If (Int(numero / 100) = 1) And ((numero - (Int(numero / 100) * 100)) < 1) Then
                    letras = letras & "cien "
                Else
                    Select Case Int(numero / 100)
                        Case 1
                            letras = letras & "ciento "
                        Case 2
                            letras = letras & "doscientos "
                        Case 3
                            letras = letras & "trescientos "
                        Case 4
                            letras = letras & "cuatrocientos "
                        Case 5
                            letras = letras & "quinientos "
                        Case 6
                            letras = letras & "seiscientos "
                        Case 7
                            letras = letras & "setecientos "
                        Case 8
                            letras = letras & "ochocientos "
                        Case 9
                            letras = letras & "novecientos "
                        Case Else
                            letras = letras & Numeros(Int(numero / 100))
                    End Select
                End If
                numero = numero - (Int(numero / 100) * 100)
            End If
            '*---> Decenas
            If (numero < 100) And (numero > 9) Then
                If numero < 31 Then
                    letras = letras & Numeros(Int(numero))
                    numero = numero - Int(numero)
                Else
                    letras = letras & Numeros(Int((numero / 10)) * 10)
                    numero = numero - (Int((numero / 10)) * 10)
                    If numero > 0.99 Then
                        letras = letras & "y "
                    End If
                End If
            End If
            '*---> Unidades
            If (numero < 10) And (numero > 0.99) Then
                letras = letras & Numeros(Int(numero))
                numero = numero - Int(numero)
            End If
        Loop Until (numero = 0)
        '*---> Decimales
        If (decimales > 0) Then
            letras = letras & "PESOS "
            letras = letras & Format(decimales * 100, "00") & "/100 M.N."
            num_letras = letras
            Exit Function
        End If
        num_letras = letras & "PESOS 00/100 M.N."
    End Function
End Class
