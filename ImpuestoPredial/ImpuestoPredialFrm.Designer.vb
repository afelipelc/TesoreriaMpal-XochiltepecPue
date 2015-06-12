<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImpuestoPredialFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImpuestoPredialFrm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ImprimirBrn = New DevComponents.DotNetBar.ButtonX
        Me.NuevoInmueble = New DevComponents.DotNetBar.ButtonX
        Me.DatosDtg = New System.Windows.Forms.DataGridView
        Me.TituloLbl = New System.Windows.Forms.Label
        Me.SalirBtn = New DevComponents.DotNetBar.ButtonX
        Me.CobrarBtn = New DevComponents.DotNetBar.ButtonX
        Me.ExpandablePanel1 = New DevComponents.DotNetBar.ExpandablePanel
        Me.UbicacionCmb = New System.Windows.Forms.ComboBox
        Me.PorTipoCmb = New System.Windows.Forms.ComboBox
        Me.EliminarInmBtn = New System.Windows.Forms.Button
        Me.TodosBtn = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.BusInmuBtn = New DevComponents.DotNetBar.ButtonX
        Me.ItemContainer1 = New DevComponents.DotNetBar.ItemContainer
        Me.PorCuentaBtni = New DevComponents.DotNetBar.ButtonItem
        Me.ExpandablePanel2 = New DevComponents.DotNetBar.ExpandablePanel
        Me.PagosTodosBtn = New System.Windows.Forms.Button
        Me.PagDelAnoCmb = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.PagosDiaDtp = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.FiltroMesCmb = New System.Windows.Forms.ComboBox
        Me.FiltroAnoCmb = New System.Windows.Forms.ComboBox
        Me.PagoMesesCmb = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.TotalConcepLbl = New System.Windows.Forms.Label
        Me.TotalImnLbl = New System.Windows.Forms.Label
        Me.TotIngresoTitLbl = New System.Windows.Forms.Label
        Me.IngresoTotalLbl = New System.Windows.Forms.Label
        Me.ConfiguraNotifBtn = New System.Windows.Forms.Button
        Me.OtroCobroBtn = New DevComponents.DotNetBar.ButtonItem
        CType(Me.DatosDtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ExpandablePanel1.SuspendLayout()
        Me.ExpandablePanel2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.ImprimirBrn.Location = New System.Drawing.Point(578, 76)
        Me.ImprimirBrn.Name = "ImprimirBrn"
        Me.ImprimirBrn.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F9)
        Me.ImprimirBrn.Size = New System.Drawing.Size(57, 52)
        Me.ImprimirBrn.TabIndex = 13
        Me.ImprimirBrn.Tooltip = "Imprimir Reporte de Pagos"
        '
        'NuevoInmueble
        '
        Me.NuevoInmueble.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NuevoInmueble.ColorScheme.DockSiteBackColorGradientAngle = 0
        Me.NuevoInmueble.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.NuevoInmueble.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.NuevoInmueble.Image = CType(resources.GetObject("NuevoInmueble.Image"), System.Drawing.Image)
        Me.NuevoInmueble.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.NuevoInmueble.Location = New System.Drawing.Point(517, 12)
        Me.NuevoInmueble.Name = "NuevoInmueble"
        Me.NuevoInmueble.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5)
        Me.NuevoInmueble.Size = New System.Drawing.Size(46, 58)
        Me.NuevoInmueble.TabIndex = 11
        Me.NuevoInmueble.Tooltip = "Nuevo Inmueble"
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DatosDtg.DefaultCellStyle = DataGridViewCellStyle1
        Me.DatosDtg.GridColor = System.Drawing.Color.LightSteelBlue
        Me.DatosDtg.Location = New System.Drawing.Point(10, 66)
        Me.DatosDtg.Margin = New System.Windows.Forms.Padding(4)
        Me.DatosDtg.Name = "DatosDtg"
        Me.DatosDtg.ReadOnly = True
        Me.DatosDtg.RowHeadersVisible = False
        Me.DatosDtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DatosDtg.Size = New System.Drawing.Size(500, 353)
        Me.DatosDtg.TabIndex = 15
        '
        'TituloLbl
        '
        Me.TituloLbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TituloLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TituloLbl.Location = New System.Drawing.Point(11, 9)
        Me.TituloLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TituloLbl.Name = "TituloLbl"
        Me.TituloLbl.Size = New System.Drawing.Size(499, 53)
        Me.TituloLbl.TabIndex = 16
        Me.TituloLbl.Text = "IMPUESTO PREDIAL"
        Me.TituloLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SalirBtn
        '
        Me.SalirBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SalirBtn.ColorScheme.DockSiteBackColorGradientAngle = 0
        Me.SalirBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.SalirBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.SalirBtn.Image = CType(resources.GetObject("SalirBtn.Image"), System.Drawing.Image)
        Me.SalirBtn.Location = New System.Drawing.Point(578, 377)
        Me.SalirBtn.Name = "SalirBtn"
        Me.SalirBtn.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F12)
        Me.SalirBtn.Size = New System.Drawing.Size(57, 63)
        Me.SalirBtn.TabIndex = 17
        Me.SalirBtn.Tooltip = "Salir del sistema"
        '
        'CobrarBtn
        '
        Me.CobrarBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CobrarBtn.ColorScheme.DockSiteBackColorGradientAngle = 0
        Me.CobrarBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.CobrarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CobrarBtn.Image = CType(resources.GetObject("CobrarBtn.Image"), System.Drawing.Image)
        Me.CobrarBtn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.CobrarBtn.Location = New System.Drawing.Point(517, 76)
        Me.CobrarBtn.Name = "CobrarBtn"
        Me.CobrarBtn.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F8)
        Me.CobrarBtn.Size = New System.Drawing.Size(46, 52)
        Me.CobrarBtn.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.OtroCobroBtn})
        Me.CobrarBtn.TabIndex = 18
        Me.CobrarBtn.Tooltip = "Cobrar Impuesto Predial"
        '
        'ExpandablePanel1
        '
        Me.ExpandablePanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExpandablePanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.ExpandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.ExpandablePanel1.Controls.Add(Me.UbicacionCmb)
        Me.ExpandablePanel1.Controls.Add(Me.PorTipoCmb)
        Me.ExpandablePanel1.Controls.Add(Me.EliminarInmBtn)
        Me.ExpandablePanel1.Controls.Add(Me.TodosBtn)
        Me.ExpandablePanel1.Controls.Add(Me.Label3)
        Me.ExpandablePanel1.Controls.Add(Me.Label2)
        Me.ExpandablePanel1.Controls.Add(Me.Label4)
        Me.ExpandablePanel1.Controls.Add(Me.Label1)
        Me.ExpandablePanel1.Controls.Add(Me.Label7)
        Me.ExpandablePanel1.Expanded = False
        Me.ExpandablePanel1.ExpandedBounds = New System.Drawing.Rectangle(517, 134, 118, 219)
        Me.ExpandablePanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpandablePanel1.Location = New System.Drawing.Point(517, 134)
        Me.ExpandablePanel1.Name = "ExpandablePanel1"
        Me.ExpandablePanel1.Size = New System.Drawing.Size(118, 26)
        Me.ExpandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.ExpandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.ExpandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.ExpandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandablePanel1.Style.GradientAngle = 90
        Me.ExpandablePanel1.TabIndex = 19
        Me.ExpandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.ExpandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ExpandablePanel1.TitleStyle.GradientAngle = 90
        Me.ExpandablePanel1.TitleText = "Inmuebles"
        '
        'UbicacionCmb
        '
        Me.UbicacionCmb.FormattingEnabled = True
        Me.UbicacionCmb.Location = New System.Drawing.Point(6, 139)
        Me.UbicacionCmb.Name = "UbicacionCmb"
        Me.UbicacionCmb.Size = New System.Drawing.Size(109, 24)
        Me.UbicacionCmb.TabIndex = 3
        '
        'PorTipoCmb
        '
        Me.PorTipoCmb.FormattingEnabled = True
        Me.PorTipoCmb.Items.AddRange(New Object() {"Rustico", "Urbano"})
        Me.PorTipoCmb.Location = New System.Drawing.Point(6, 85)
        Me.PorTipoCmb.Name = "PorTipoCmb"
        Me.PorTipoCmb.Size = New System.Drawing.Size(109, 24)
        Me.PorTipoCmb.TabIndex = 3
        '
        'EliminarInmBtn
        '
        Me.EliminarInmBtn.Location = New System.Drawing.Point(22, 174)
        Me.EliminarInmBtn.Name = "EliminarInmBtn"
        Me.EliminarInmBtn.Size = New System.Drawing.Size(81, 42)
        Me.EliminarInmBtn.TabIndex = 2
        Me.EliminarInmBtn.Text = "&Eliminar Inmueble"
        Me.EliminarInmBtn.UseVisualStyleBackColor = True
        '
        'TodosBtn
        '
        Me.TodosBtn.Location = New System.Drawing.Point(33, 31)
        Me.TodosBtn.Name = "TodosBtn"
        Me.TodosBtn.Size = New System.Drawing.Size(57, 24)
        Me.TodosBtn.TabIndex = 2
        Me.TodosBtn.Text = "&Todos"
        Me.TodosBtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "_____________"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "_____________"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Por Ubicación:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Por Tipo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "_____________"
        '
        'BusInmuBtn
        '
        Me.BusInmuBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BusInmuBtn.ColorScheme.DockSiteBackColorGradientAngle = 0
        Me.BusInmuBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.BusInmuBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BusInmuBtn.Image = CType(resources.GetObject("BusInmuBtn.Image"), System.Drawing.Image)
        Me.BusInmuBtn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.BusInmuBtn.Location = New System.Drawing.Point(571, 12)
        Me.BusInmuBtn.Name = "BusInmuBtn"
        Me.BusInmuBtn.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F6)
        Me.BusInmuBtn.Size = New System.Drawing.Size(64, 58)
        Me.BusInmuBtn.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer1})
        Me.BusInmuBtn.TabIndex = 20
        Me.BusInmuBtn.Tooltip = "Buscar Inmueble"
        '
        'ItemContainer1
        '
        Me.ItemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer1.MinimumSize = New System.Drawing.Size(0, 0)
        Me.ItemContainer1.Name = "ItemContainer1"
        Me.ItemContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.PorCuentaBtni})
        '
        'PorCuentaBtni
        '
        Me.PorCuentaBtni.Name = "PorCuentaBtni"
        Me.PorCuentaBtni.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F7)
        Me.PorCuentaBtni.Text = "Por Cuenta"
        Me.PorCuentaBtni.Tooltip = "Buscar toma por numero de cuenta"
        '
        'ExpandablePanel2
        '
        Me.ExpandablePanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExpandablePanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.ExpandablePanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.ExpandablePanel2.Controls.Add(Me.PagosTodosBtn)
        Me.ExpandablePanel2.Controls.Add(Me.PagDelAnoCmb)
        Me.ExpandablePanel2.Controls.Add(Me.Label8)
        Me.ExpandablePanel2.Controls.Add(Me.PagosDiaDtp)
        Me.ExpandablePanel2.Controls.Add(Me.Label9)
        Me.ExpandablePanel2.Controls.Add(Me.FiltroMesCmb)
        Me.ExpandablePanel2.Controls.Add(Me.FiltroAnoCmb)
        Me.ExpandablePanel2.Controls.Add(Me.PagoMesesCmb)
        Me.ExpandablePanel2.Controls.Add(Me.Label6)
        Me.ExpandablePanel2.Controls.Add(Me.Label10)
        Me.ExpandablePanel2.Controls.Add(Me.Label5)
        Me.ExpandablePanel2.Controls.Add(Me.Label11)
        Me.ExpandablePanel2.Controls.Add(Me.Label12)
        Me.ExpandablePanel2.Controls.Add(Me.Label13)
        Me.ExpandablePanel2.Expanded = False
        Me.ExpandablePanel2.ExpandedBounds = New System.Drawing.Rectangle(517, 166, 118, 286)
        Me.ExpandablePanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpandablePanel2.Location = New System.Drawing.Point(517, 166)
        Me.ExpandablePanel2.Name = "ExpandablePanel2"
        Me.ExpandablePanel2.Size = New System.Drawing.Size(118, 26)
        Me.ExpandablePanel2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.ExpandablePanel2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.ExpandablePanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.ExpandablePanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandablePanel2.Style.GradientAngle = 90
        Me.ExpandablePanel2.TabIndex = 21
        Me.ExpandablePanel2.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel2.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel2.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel2.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.ExpandablePanel2.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandablePanel2.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ExpandablePanel2.TitleStyle.GradientAngle = 90
        Me.ExpandablePanel2.TitleText = "Pagos realizados"
        '
        'PagosTodosBtn
        '
        Me.PagosTodosBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PagosTodosBtn.Location = New System.Drawing.Point(28, 31)
        Me.PagosTodosBtn.Name = "PagosTodosBtn"
        Me.PagosTodosBtn.Size = New System.Drawing.Size(68, 26)
        Me.PagosTodosBtn.TabIndex = 18
        Me.PagosTodosBtn.Text = "Todos"
        Me.PagosTodosBtn.UseVisualStyleBackColor = True
        '
        'PagDelAnoCmb
        '
        Me.PagDelAnoCmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PagDelAnoCmb.FormattingEnabled = True
        Me.PagDelAnoCmb.Location = New System.Drawing.Point(9, 227)
        Me.PagDelAnoCmb.Name = "PagDelAnoCmb"
        Me.PagDelAnoCmb.Size = New System.Drawing.Size(100, 24)
        Me.PagDelAnoCmb.Sorted = True
        Me.PagDelAnoCmb.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 207)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Del Año"
        '
        'PagosDiaDtp
        '
        Me.PagosDiaDtp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PagosDiaDtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.PagosDiaDtp.Location = New System.Drawing.Point(8, 170)
        Me.PagosDiaDtp.Name = "PagosDiaDtp"
        Me.PagosDiaDtp.Size = New System.Drawing.Size(101, 23)
        Me.PagosDiaDtp.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(5, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "_________________"
        '
        'FiltroMesCmb
        '
        Me.FiltroMesCmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiltroMesCmb.FormattingEnabled = True
        Me.FiltroMesCmb.Items.AddRange(New Object() {"R", "U", "Todos"})
        Me.FiltroMesCmb.Location = New System.Drawing.Point(44, 118)
        Me.FiltroMesCmb.Name = "FiltroMesCmb"
        Me.FiltroMesCmb.Size = New System.Drawing.Size(65, 24)
        Me.FiltroMesCmb.TabIndex = 13
        '
        'FiltroAnoCmb
        '
        Me.FiltroAnoCmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiltroAnoCmb.FormattingEnabled = True
        Me.FiltroAnoCmb.Items.AddRange(New Object() {"R", "U", "Todos"})
        Me.FiltroAnoCmb.Location = New System.Drawing.Point(44, 257)
        Me.FiltroAnoCmb.Name = "FiltroAnoCmb"
        Me.FiltroAnoCmb.Size = New System.Drawing.Size(65, 24)
        Me.FiltroAnoCmb.TabIndex = 13
        '
        'PagoMesesCmb
        '
        Me.PagoMesesCmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PagoMesesCmb.FormattingEnabled = True
        Me.PagoMesesCmb.Items.AddRange(New Object() {"enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre", "", "Todos"})
        Me.PagoMesesCmb.Location = New System.Drawing.Point(8, 88)
        Me.PagoMesesCmb.Name = "PagoMesesCmb"
        Me.PagoMesesCmb.Size = New System.Drawing.Size(101, 24)
        Me.PagoMesesCmb.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Filtro:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 152)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 17)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Del Dia:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Filtro:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(2, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 17)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Pagos del mes:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(5, 50)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "_________________"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(5, 137)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(109, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "_________________"
        '
        'TotalConcepLbl
        '
        Me.TotalConcepLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TotalConcepLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalConcepLbl.Location = New System.Drawing.Point(12, 423)
        Me.TotalConcepLbl.Name = "TotalConcepLbl"
        Me.TotalConcepLbl.Size = New System.Drawing.Size(129, 23)
        Me.TotalConcepLbl.TabIndex = 22
        Me.TotalConcepLbl.Text = "Total Inmuebles:"
        Me.TotalConcepLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotalImnLbl
        '
        Me.TotalImnLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TotalImnLbl.AutoSize = True
        Me.TotalImnLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalImnLbl.Location = New System.Drawing.Point(147, 426)
        Me.TotalImnLbl.Name = "TotalImnLbl"
        Me.TotalImnLbl.Size = New System.Drawing.Size(17, 17)
        Me.TotalImnLbl.TabIndex = 22
        Me.TotalImnLbl.Text = "0"
        '
        'TotIngresoTitLbl
        '
        Me.TotIngresoTitLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TotIngresoTitLbl.AutoSize = True
        Me.TotIngresoTitLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotIngresoTitLbl.Location = New System.Drawing.Point(214, 426)
        Me.TotIngresoTitLbl.Name = "TotIngresoTitLbl"
        Me.TotIngresoTitLbl.Size = New System.Drawing.Size(95, 17)
        Me.TotIngresoTitLbl.TabIndex = 22
        Me.TotIngresoTitLbl.Text = "Ingreso Total:"
        '
        'IngresoTotalLbl
        '
        Me.IngresoTotalLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.IngresoTotalLbl.AutoSize = True
        Me.IngresoTotalLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IngresoTotalLbl.Location = New System.Drawing.Point(307, 426)
        Me.IngresoTotalLbl.Name = "IngresoTotalLbl"
        Me.IngresoTotalLbl.Size = New System.Drawing.Size(31, 17)
        Me.IngresoTotalLbl.TabIndex = 22
        Me.IngresoTotalLbl.Text = "$ 0"
        '
        'ConfiguraNotifBtn
        '
        Me.ConfiguraNotifBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConfiguraNotifBtn.Location = New System.Drawing.Point(532, 205)
        Me.ConfiguraNotifBtn.Name = "ConfiguraNotifBtn"
        Me.ConfiguraNotifBtn.Size = New System.Drawing.Size(93, 35)
        Me.ConfiguraNotifBtn.TabIndex = 23
        Me.ConfiguraNotifBtn.Text = "Configurar Notificaciones"
        Me.ConfiguraNotifBtn.UseVisualStyleBackColor = True
        '
        'OtroCobroBtn
        '
        Me.OtroCobroBtn.Name = "OtroCobroBtn"
        Me.OtroCobroBtn.Text = "Otro Cobro"
        '
        'ImpuestoPredialFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(647, 452)
        Me.Controls.Add(Me.ExpandablePanel1)
        Me.Controls.Add(Me.ExpandablePanel2)
        Me.Controls.Add(Me.ConfiguraNotifBtn)
        Me.Controls.Add(Me.TotalImnLbl)
        Me.Controls.Add(Me.IngresoTotalLbl)
        Me.Controls.Add(Me.TotIngresoTitLbl)
        Me.Controls.Add(Me.TotalConcepLbl)
        Me.Controls.Add(Me.BusInmuBtn)
        Me.Controls.Add(Me.CobrarBtn)
        Me.Controls.Add(Me.SalirBtn)
        Me.Controls.Add(Me.TituloLbl)
        Me.Controls.Add(Me.DatosDtg)
        Me.Controls.Add(Me.ImprimirBrn)
        Me.Controls.Add(Me.NuevoInmueble)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ImpuestoPredialFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IMPUESTO PREDIAL  :  TESORERIA MUNICIPAL "
        CType(Me.DatosDtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ExpandablePanel1.ResumeLayout(False)
        Me.ExpandablePanel1.PerformLayout()
        Me.ExpandablePanel2.ResumeLayout(False)
        Me.ExpandablePanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImprimirBrn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents NuevoInmueble As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DatosDtg As System.Windows.Forms.DataGridView
    Friend WithEvents TituloLbl As System.Windows.Forms.Label
    Friend WithEvents SalirBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents CobrarBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ExpandablePanel1 As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TodosBtn As System.Windows.Forms.Button
    Friend WithEvents BusInmuBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ItemContainer1 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents PorCuentaBtni As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PorTipoCmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents UbicacionCmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ExpandablePanel2 As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents PagosTodosBtn As System.Windows.Forms.Button
    Friend WithEvents PagDelAnoCmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PagosDiaDtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PagoMesesCmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TotalConcepLbl As System.Windows.Forms.Label
    Friend WithEvents TotalImnLbl As System.Windows.Forms.Label
    Friend WithEvents TotIngresoTitLbl As System.Windows.Forms.Label
    Friend WithEvents IngresoTotalLbl As System.Windows.Forms.Label
    Friend WithEvents ConfiguraNotifBtn As System.Windows.Forms.Button
    Friend WithEvents FiltroAnoCmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents FiltroMesCmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents EliminarInmBtn As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents OtroCobroBtn As DevComponents.DotNetBar.ButtonItem
End Class
