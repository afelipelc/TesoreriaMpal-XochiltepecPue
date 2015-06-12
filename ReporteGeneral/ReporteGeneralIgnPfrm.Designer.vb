<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteGeneralIgnPfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReporteGeneralIgnPfrm))
        Me.TituloLbl = New System.Windows.Forms.Label
        Me.DatosDtg = New System.Windows.Forms.DataGridView
        Me.ImprimirBrn = New DevComponents.DotNetBar.ButtonX
        Me.SalirBtn = New DevComponents.DotNetBar.ButtonX
        Me.ExpandablePanel1 = New DevComponents.DotNetBar.ExpandablePanel
        Me.IngAnoFiltroCmb = New System.Windows.Forms.ComboBox
        Me.IngresosAlDiadDtp = New System.Windows.Forms.DateTimePicker
        Me.IngresosDiaDtp = New System.Windows.Forms.DateTimePicker
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.IngDelAnoCmb = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.IngDiaFiltroCmb = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TodosBtn = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.IngMesFiltroCmb = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.IngresosMesCmb = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.IngresoTotalLbl = New System.Windows.Forms.Label
        Me.TotalConcepLbl = New System.Windows.Forms.Label
        Me.ResumenBtn = New System.Windows.Forms.Button
        Me.ResCtasBtn = New System.Windows.Forms.Button
        CType(Me.DatosDtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ExpandablePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TituloLbl
        '
        Me.TituloLbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TituloLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TituloLbl.Location = New System.Drawing.Point(11, 3)
        Me.TituloLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TituloLbl.Name = "TituloLbl"
        Me.TituloLbl.Size = New System.Drawing.Size(418, 70)
        Me.TituloLbl.TabIndex = 3
        Me.TituloLbl.Text = "RESUMEN DE INGRESOS PROPIOS"
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
        Me.DatosDtg.Location = New System.Drawing.Point(7, 77)
        Me.DatosDtg.Margin = New System.Windows.Forms.Padding(4)
        Me.DatosDtg.Name = "DatosDtg"
        Me.DatosDtg.ReadOnly = True
        Me.DatosDtg.RowHeadersVisible = False
        Me.DatosDtg.Size = New System.Drawing.Size(422, 331)
        Me.DatosDtg.TabIndex = 2
        '
        'ImprimirBrn
        '
        Me.ImprimirBrn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImprimirBrn.ColorScheme.DockSiteBackColorGradientAngle = 0
        Me.ImprimirBrn.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.ImprimirBrn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ImprimirBrn.Image = CType(resources.GetObject("ImprimirBrn.Image"), System.Drawing.Image)
        Me.ImprimirBrn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ImprimirBrn.Location = New System.Drawing.Point(491, 201)
        Me.ImprimirBrn.Name = "ImprimirBrn"
        Me.ImprimirBrn.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F8)
        Me.ImprimirBrn.Size = New System.Drawing.Size(57, 52)
        Me.ImprimirBrn.TabIndex = 13
        Me.ImprimirBrn.Tooltip = "Imprimir Reporte de Pagos"
        '
        'SalirBtn
        '
        Me.SalirBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SalirBtn.ColorScheme.DockSiteBackColorGradientAngle = 0
        Me.SalirBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.SalirBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.SalirBtn.Image = CType(resources.GetObject("SalirBtn.Image"), System.Drawing.Image)
        Me.SalirBtn.Location = New System.Drawing.Point(524, 367)
        Me.SalirBtn.Name = "SalirBtn"
        Me.SalirBtn.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F12)
        Me.SalirBtn.Size = New System.Drawing.Size(57, 63)
        Me.SalirBtn.TabIndex = 14
        Me.SalirBtn.Tooltip = "Salir del sistema"
        '
        'ExpandablePanel1
        '
        Me.ExpandablePanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExpandablePanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.ExpandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.ExpandablePanel1.Controls.Add(Me.IngAnoFiltroCmb)
        Me.ExpandablePanel1.Controls.Add(Me.IngresosAlDiadDtp)
        Me.ExpandablePanel1.Controls.Add(Me.IngresosDiaDtp)
        Me.ExpandablePanel1.Controls.Add(Me.Label13)
        Me.ExpandablePanel1.Controls.Add(Me.Label10)
        Me.ExpandablePanel1.Controls.Add(Me.IngDelAnoCmb)
        Me.ExpandablePanel1.Controls.Add(Me.Label7)
        Me.ExpandablePanel1.Controls.Add(Me.Label12)
        Me.ExpandablePanel1.Controls.Add(Me.IngDiaFiltroCmb)
        Me.ExpandablePanel1.Controls.Add(Me.Label3)
        Me.ExpandablePanel1.Controls.Add(Me.TodosBtn)
        Me.ExpandablePanel1.Controls.Add(Me.Label9)
        Me.ExpandablePanel1.Controls.Add(Me.IngMesFiltroCmb)
        Me.ExpandablePanel1.Controls.Add(Me.Label2)
        Me.ExpandablePanel1.Controls.Add(Me.Label1)
        Me.ExpandablePanel1.Controls.Add(Me.Label8)
        Me.ExpandablePanel1.Controls.Add(Me.IngresosMesCmb)
        Me.ExpandablePanel1.Controls.Add(Me.Label6)
        Me.ExpandablePanel1.Expanded = False
        Me.ExpandablePanel1.ExpandedBounds = New System.Drawing.Rectangle(446, 29, 135, 353)
        Me.ExpandablePanel1.Location = New System.Drawing.Point(446, 29)
        Me.ExpandablePanel1.Name = "ExpandablePanel1"
        Me.ExpandablePanel1.Size = New System.Drawing.Size(135, 26)
        Me.ExpandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.ExpandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.ExpandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.ExpandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandablePanel1.Style.GradientAngle = 90
        Me.ExpandablePanel1.TabIndex = 15
        Me.ExpandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.ExpandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ExpandablePanel1.TitleStyle.GradientAngle = 90
        Me.ExpandablePanel1.TitleText = "Mostrar Ingresos"
        '
        'IngAnoFiltroCmb
        '
        Me.IngAnoFiltroCmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IngAnoFiltroCmb.FormattingEnabled = True
        Me.IngAnoFiltroCmb.Items.AddRange(New Object() {"Agua Potable", "Impuesto Predial", "Registro Civil", "Retro y Volteo", "Tortilleria", "Otros Ingresos", "Resumen", "Todos"})
        Me.IngAnoFiltroCmb.Location = New System.Drawing.Point(7, 322)
        Me.IngAnoFiltroCmb.Name = "IngAnoFiltroCmb"
        Me.IngAnoFiltroCmb.Size = New System.Drawing.Size(121, 21)
        Me.IngAnoFiltroCmb.TabIndex = 18
        '
        'IngresosAlDiadDtp
        '
        Me.IngresosAlDiadDtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.IngresosAlDiadDtp.Location = New System.Drawing.Point(36, 187)
        Me.IngresosAlDiadDtp.Name = "IngresosAlDiadDtp"
        Me.IngresosAlDiadDtp.Size = New System.Drawing.Size(93, 20)
        Me.IngresosAlDiadDtp.TabIndex = 19
        '
        'IngresosDiaDtp
        '
        Me.IngresosDiaDtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.IngresosDiaDtp.Location = New System.Drawing.Point(36, 159)
        Me.IngresosDiaDtp.Name = "IngresosDiaDtp"
        Me.IngresosDiaDtp.Size = New System.Drawing.Size(93, 20)
        Me.IngresosDiaDtp.TabIndex = 19
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Maroon
        Me.Label13.Location = New System.Drawing.Point(12, 304)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 15)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Filtrar por:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(12, 212)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 15)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Filtrar por:"
        '
        'IngDelAnoCmb
        '
        Me.IngDelAnoCmb.FormattingEnabled = True
        Me.IngDelAnoCmb.Location = New System.Drawing.Point(7, 281)
        Me.IngDelAnoCmb.Name = "IngDelAnoCmb"
        Me.IngDelAnoCmb.Size = New System.Drawing.Size(121, 21)
        Me.IngDelAnoCmb.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(12, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 15)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Filtrar por:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 264)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 17)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Del año:"
        '
        'IngDiaFiltroCmb
        '
        Me.IngDiaFiltroCmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IngDiaFiltroCmb.FormattingEnabled = True
        Me.IngDiaFiltroCmb.Items.AddRange(New Object() {"Agua Potable", "Impuesto Predial", "Registro Civil", "Retro y Volteo", "Tortilleria", "Otros Ingresos", "Resumen", "Todos"})
        Me.IngDiaFiltroCmb.Location = New System.Drawing.Point(9, 230)
        Me.IngDiaFiltroCmb.Name = "IngDiaFiltroCmb"
        Me.IngDiaFiltroCmb.Size = New System.Drawing.Size(121, 21)
        Me.IngDiaFiltroCmb.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Al:"
        '
        'TodosBtn
        '
        Me.TodosBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TodosBtn.Location = New System.Drawing.Point(38, 32)
        Me.TodosBtn.Name = "TodosBtn"
        Me.TodosBtn.Size = New System.Drawing.Size(64, 25)
        Me.TodosBtn.TabIndex = 16
        Me.TodosBtn.Text = "Todos"
        Me.TodosBtn.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(5, 161)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 17)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Del:"
        '
        'IngMesFiltroCmb
        '
        Me.IngMesFiltroCmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IngMesFiltroCmb.FormattingEnabled = True
        Me.IngMesFiltroCmb.Items.AddRange(New Object() {"Agua Potable", "Impuesto Predial", "Registro Civil", "Retro y Volteo", "Tortilleria", "Otros Ingresos", "Resumen", "Todos"})
        Me.IngMesFiltroCmb.Location = New System.Drawing.Point(9, 122)
        Me.IngMesFiltroCmb.Name = "IngMesFiltroCmb"
        Me.IngMesFiltroCmb.Size = New System.Drawing.Size(119, 21)
        Me.IngMesFiltroCmb.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "____________________"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "____________________"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "____________________"
        '
        'IngresosMesCmb
        '
        Me.IngresosMesCmb.FormattingEnabled = True
        Me.IngresosMesCmb.Items.AddRange(New Object() {"enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre"})
        Me.IngresosMesCmb.Location = New System.Drawing.Point(9, 83)
        Me.IngresosMesCmb.Name = "IngresosMesCmb"
        Me.IngresosMesCmb.Size = New System.Drawing.Size(119, 21)
        Me.IngresosMesCmb.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 17)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Del mes de:"
        '
        'IngresoTotalLbl
        '
        Me.IngresoTotalLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.IngresoTotalLbl.AutoSize = True
        Me.IngresoTotalLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IngresoTotalLbl.Location = New System.Drawing.Point(113, 415)
        Me.IngresoTotalLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IngresoTotalLbl.Name = "IngresoTotalLbl"
        Me.IngresoTotalLbl.Size = New System.Drawing.Size(50, 22)
        Me.IngresoTotalLbl.TabIndex = 17
        Me.IngresoTotalLbl.Text = "$ 0.0"
        '
        'TotalConcepLbl
        '
        Me.TotalConcepLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TotalConcepLbl.AutoSize = True
        Me.TotalConcepLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalConcepLbl.Location = New System.Drawing.Point(8, 415)
        Me.TotalConcepLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TotalConcepLbl.Name = "TotalConcepLbl"
        Me.TotalConcepLbl.Size = New System.Drawing.Size(106, 20)
        Me.TotalConcepLbl.TabIndex = 16
        Me.TotalConcepLbl.Text = "Ingreso Total:"
        '
        'ResumenBtn
        '
        Me.ResumenBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ResumenBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ResumenBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResumenBtn.Location = New System.Drawing.Point(457, 77)
        Me.ResumenBtn.Name = "ResumenBtn"
        Me.ResumenBtn.Size = New System.Drawing.Size(116, 38)
        Me.ResumenBtn.TabIndex = 18
        Me.ResumenBtn.Text = "Resumen de Ingresos Propios"
        Me.ResumenBtn.UseVisualStyleBackColor = True
        '
        'ResCtasBtn
        '
        Me.ResCtasBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ResCtasBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ResCtasBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResCtasBtn.Location = New System.Drawing.Point(457, 121)
        Me.ResCtasBtn.Name = "ResCtasBtn"
        Me.ResCtasBtn.Size = New System.Drawing.Size(116, 38)
        Me.ResCtasBtn.TabIndex = 18
        Me.ResCtasBtn.Text = "Resumen de cuentas"
        Me.ResCtasBtn.UseVisualStyleBackColor = True
        '
        'ReporteGeneralIgnPfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(593, 442)
        Me.Controls.Add(Me.ExpandablePanel1)
        Me.Controls.Add(Me.ResCtasBtn)
        Me.Controls.Add(Me.ResumenBtn)
        Me.Controls.Add(Me.IngresoTotalLbl)
        Me.Controls.Add(Me.TotalConcepLbl)
        Me.Controls.Add(Me.ImprimirBrn)
        Me.Controls.Add(Me.SalirBtn)
        Me.Controls.Add(Me.TituloLbl)
        Me.Controls.Add(Me.DatosDtg)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReporteGeneralIgnPfrm"
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
    Friend WithEvents ImprimirBrn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents SalirBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ExpandablePanel1 As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents TodosBtn As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents IngMesFiltroCmb As System.Windows.Forms.ComboBox
    Friend WithEvents IngresosMesCmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IngresosDiaDtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents IngDiaFiltroCmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents IngAnoFiltroCmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents IngDelAnoCmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents IngresoTotalLbl As System.Windows.Forms.Label
    Friend WithEvents TotalConcepLbl As System.Windows.Forms.Label
    Friend WithEvents ResumenBtn As System.Windows.Forms.Button
    Friend WithEvents IngresosAlDiadDtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ResCtasBtn As System.Windows.Forms.Button
End Class
