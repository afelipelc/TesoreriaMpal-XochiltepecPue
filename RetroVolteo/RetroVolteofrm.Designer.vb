<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RetroVolteofrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RetroVolteofrm))
        Me.TituloLbl = New System.Windows.Forms.Label
        Me.DatosDtg = New System.Windows.Forms.DataGridView
        Me.ConceptosTotallbl = New System.Windows.Forms.Label
        Me.ConceptosTituloLbl = New System.Windows.Forms.Label
        Me.IngresoTotalLbl = New System.Windows.Forms.Label
        Me.TotalConcepLbl = New System.Windows.Forms.Label
        Me.ImprimirBrn = New DevComponents.DotNetBar.ButtonX
        Me.NPagoBtn = New DevComponents.DotNetBar.ButtonX
        Me.ConfigBtn = New DevComponents.DotNetBar.ButtonX
        Me.ExpandablePanel1 = New DevComponents.DotNetBar.ExpandablePanel
        Me.PagosDiaDtp = New System.Windows.Forms.DateTimePicker
        Me.PagosTodosBtn = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.PagDelAnoCmb = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.PagosMesCmb = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.SalirBtn = New DevComponents.DotNetBar.ButtonX
        CType(Me.DatosDtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ExpandablePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TituloLbl
        '
        Me.TituloLbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TituloLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TituloLbl.Location = New System.Drawing.Point(9, 3)
        Me.TituloLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TituloLbl.Name = "TituloLbl"
        Me.TituloLbl.Size = New System.Drawing.Size(485, 69)
        Me.TituloLbl.TabIndex = 3
        Me.TituloLbl.Text = "INGRESOS DE RETROEXCAVADORA Y VOLTEO"
        Me.TituloLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DatosDtg
        '
        Me.DatosDtg.AllowUserToAddRows = False
        Me.DatosDtg.AllowUserToDeleteRows = False
        Me.DatosDtg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatosDtg.BackgroundColor = System.Drawing.Color.White
        Me.DatosDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatosDtg.GridColor = System.Drawing.Color.LightSteelBlue
        Me.DatosDtg.Location = New System.Drawing.Point(9, 76)
        Me.DatosDtg.Margin = New System.Windows.Forms.Padding(4)
        Me.DatosDtg.Name = "DatosDtg"
        Me.DatosDtg.ReadOnly = True
        Me.DatosDtg.RowHeadersVisible = False
        Me.DatosDtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DatosDtg.Size = New System.Drawing.Size(515, 281)
        Me.DatosDtg.TabIndex = 2
        '
        'ConceptosTotallbl
        '
        Me.ConceptosTotallbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ConceptosTotallbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConceptosTotallbl.Location = New System.Drawing.Point(444, 361)
        Me.ConceptosTotallbl.Name = "ConceptosTotallbl"
        Me.ConceptosTotallbl.Size = New System.Drawing.Size(80, 20)
        Me.ConceptosTotallbl.TabIndex = 6
        Me.ConceptosTotallbl.Text = "0"
        '
        'ConceptosTituloLbl
        '
        Me.ConceptosTituloLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ConceptosTituloLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConceptosTituloLbl.Location = New System.Drawing.Point(281, 361)
        Me.ConceptosTituloLbl.Name = "ConceptosTituloLbl"
        Me.ConceptosTituloLbl.Size = New System.Drawing.Size(157, 20)
        Me.ConceptosTituloLbl.TabIndex = 7
        Me.ConceptosTituloLbl.Text = "Total de Pagos:"
        Me.ConceptosTituloLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IngresoTotalLbl
        '
        Me.IngresoTotalLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.IngresoTotalLbl.AutoSize = True
        Me.IngresoTotalLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IngresoTotalLbl.Location = New System.Drawing.Point(111, 361)
        Me.IngresoTotalLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IngresoTotalLbl.Name = "IngresoTotalLbl"
        Me.IngresoTotalLbl.Size = New System.Drawing.Size(50, 22)
        Me.IngresoTotalLbl.TabIndex = 4
        Me.IngresoTotalLbl.Text = "$ 0.0"
        '
        'TotalConcepLbl
        '
        Me.TotalConcepLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TotalConcepLbl.AutoSize = True
        Me.TotalConcepLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalConcepLbl.Location = New System.Drawing.Point(6, 361)
        Me.TotalConcepLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TotalConcepLbl.Name = "TotalConcepLbl"
        Me.TotalConcepLbl.Size = New System.Drawing.Size(106, 20)
        Me.TotalConcepLbl.TabIndex = 5
        Me.TotalConcepLbl.Text = "Ingreso Total:"
        '
        'ImprimirBrn
        '
        Me.ImprimirBrn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImprimirBrn.ColorScheme.DockSiteBackColorGradientAngle = 0
        Me.ImprimirBrn.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.ImprimirBrn.Enabled = False
        Me.ImprimirBrn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ImprimirBrn.Image = CType(resources.GetObject("ImprimirBrn.Image"), System.Drawing.Image)
        Me.ImprimirBrn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ImprimirBrn.Location = New System.Drawing.Point(565, 76)
        Me.ImprimirBrn.Name = "ImprimirBrn"
        Me.ImprimirBrn.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F8)
        Me.ImprimirBrn.Size = New System.Drawing.Size(57, 52)
        Me.ImprimirBrn.TabIndex = 13
        Me.ImprimirBrn.Tooltip = "Imprimir Reporte de Pagos"
        '
        'NPagoBtn
        '
        Me.NPagoBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NPagoBtn.ColorScheme.DockSiteBackColorGradientAngle = 0
        Me.NPagoBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.NPagoBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.NPagoBtn.Image = CType(resources.GetObject("NPagoBtn.Image"), System.Drawing.Image)
        Me.NPagoBtn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.NPagoBtn.Location = New System.Drawing.Point(535, 12)
        Me.NPagoBtn.Name = "NPagoBtn"
        Me.NPagoBtn.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5)
        Me.NPagoBtn.Size = New System.Drawing.Size(46, 58)
        Me.NPagoBtn.TabIndex = 0
        Me.NPagoBtn.Tooltip = "Nuevo Pago"
        '
        'ConfigBtn
        '
        Me.ConfigBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConfigBtn.ColorScheme.DockSiteBackColorGradientAngle = 0
        Me.ConfigBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.ConfigBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ConfigBtn.Image = CType(resources.GetObject("ConfigBtn.Image"), System.Drawing.Image)
        Me.ConfigBtn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ConfigBtn.Location = New System.Drawing.Point(595, 12)
        Me.ConfigBtn.Name = "ConfigBtn"
        Me.ConfigBtn.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F3)
        Me.ConfigBtn.Size = New System.Drawing.Size(57, 58)
        Me.ConfigBtn.TabIndex = 10
        Me.ConfigBtn.Tooltip = "Configurar Cuotas"
        '
        'ExpandablePanel1
        '
        Me.ExpandablePanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExpandablePanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.ExpandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.ExpandablePanel1.Controls.Add(Me.PagosDiaDtp)
        Me.ExpandablePanel1.Controls.Add(Me.PagosTodosBtn)
        Me.ExpandablePanel1.Controls.Add(Me.Label8)
        Me.ExpandablePanel1.Controls.Add(Me.PagDelAnoCmb)
        Me.ExpandablePanel1.Controls.Add(Me.Label6)
        Me.ExpandablePanel1.Controls.Add(Me.Label9)
        Me.ExpandablePanel1.Controls.Add(Me.Label12)
        Me.ExpandablePanel1.Controls.Add(Me.PagosMesCmb)
        Me.ExpandablePanel1.Controls.Add(Me.Label5)
        Me.ExpandablePanel1.Controls.Add(Me.Label11)
        Me.ExpandablePanel1.Expanded = False
        Me.ExpandablePanel1.ExpandedBounds = New System.Drawing.Rectangle(535, 134, 117, 227)
        Me.ExpandablePanel1.Location = New System.Drawing.Point(535, 134)
        Me.ExpandablePanel1.Name = "ExpandablePanel1"
        Me.ExpandablePanel1.Size = New System.Drawing.Size(117, 26)
        Me.ExpandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.ExpandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.ExpandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.ExpandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandablePanel1.Style.GradientAngle = 90
        Me.ExpandablePanel1.TabIndex = 14
        Me.ExpandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.ExpandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ExpandablePanel1.TitleStyle.GradientAngle = 90
        Me.ExpandablePanel1.TitleText = "Pagos Realizados"
        '
        'PagosDiaDtp
        '
        Me.PagosDiaDtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.PagosDiaDtp.Location = New System.Drawing.Point(12, 141)
        Me.PagosDiaDtp.Name = "PagosDiaDtp"
        Me.PagosDiaDtp.Size = New System.Drawing.Size(97, 20)
        Me.PagosDiaDtp.TabIndex = 6
        '
        'PagosTodosBtn
        '
        Me.PagosTodosBtn.Location = New System.Drawing.Point(31, 32)
        Me.PagosTodosBtn.Name = "PagosTodosBtn"
        Me.PagosTodosBtn.Size = New System.Drawing.Size(64, 25)
        Me.PagosTodosBtn.TabIndex = 1
        Me.PagosTodosBtn.Text = "Todos"
        Me.PagosTodosBtn.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "________________"
        '
        'PagDelAnoCmb
        '
        Me.PagDelAnoCmb.FormattingEnabled = True
        Me.PagDelAnoCmb.Location = New System.Drawing.Point(10, 194)
        Me.PagDelAnoCmb.Name = "PagDelAnoCmb"
        Me.PagDelAnoCmb.Size = New System.Drawing.Size(99, 21)
        Me.PagDelAnoCmb.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Del mes de:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 123)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Del dia:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 179)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Del año:"
        '
        'PagosMesCmb
        '
        Me.PagosMesCmb.FormattingEnabled = True
        Me.PagosMesCmb.Items.AddRange(New Object() {"enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre"})
        Me.PagosMesCmb.Location = New System.Drawing.Point(11, 84)
        Me.PagosMesCmb.Name = "PagosMesCmb"
        Me.PagosMesCmb.Size = New System.Drawing.Size(98, 21)
        Me.PagosMesCmb.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "________________"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 160)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "________________"
        '
        'SalirBtn
        '
        Me.SalirBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SalirBtn.ColorScheme.DockSiteBackColorGradientAngle = 0
        Me.SalirBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.SalirBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.SalirBtn.Image = CType(resources.GetObject("SalirBtn.Image"), System.Drawing.Image)
        Me.SalirBtn.Location = New System.Drawing.Point(591, 316)
        Me.SalirBtn.Name = "SalirBtn"
        Me.SalirBtn.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F12)
        Me.SalirBtn.Size = New System.Drawing.Size(57, 58)
        Me.SalirBtn.TabIndex = 15
        Me.SalirBtn.Tooltip = "Salir del sistema"
        '
        'RetroVolteofrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(660, 386)
        Me.Controls.Add(Me.ExpandablePanel1)
        Me.Controls.Add(Me.SalirBtn)
        Me.Controls.Add(Me.ImprimirBrn)
        Me.Controls.Add(Me.NPagoBtn)
        Me.Controls.Add(Me.ConfigBtn)
        Me.Controls.Add(Me.ConceptosTotallbl)
        Me.Controls.Add(Me.ConceptosTituloLbl)
        Me.Controls.Add(Me.IngresoTotalLbl)
        Me.Controls.Add(Me.TotalConcepLbl)
        Me.Controls.Add(Me.TituloLbl)
        Me.Controls.Add(Me.DatosDtg)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RetroVolteofrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TESORERIA MUNICIPAL "
        CType(Me.DatosDtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ExpandablePanel1.ResumeLayout(False)
        Me.ExpandablePanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TituloLbl As System.Windows.Forms.Label
    Friend WithEvents DatosDtg As System.Windows.Forms.DataGridView
    Friend WithEvents ConceptosTotallbl As System.Windows.Forms.Label
    Friend WithEvents ConceptosTituloLbl As System.Windows.Forms.Label
    Friend WithEvents IngresoTotalLbl As System.Windows.Forms.Label
    Friend WithEvents TotalConcepLbl As System.Windows.Forms.Label
    Friend WithEvents ImprimirBrn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents NPagoBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ConfigBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ExpandablePanel1 As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents PagosTodosBtn As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PagDelAnoCmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PagosMesCmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PagosDiaDtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SalirBtn As DevComponents.DotNetBar.ButtonX
End Class
