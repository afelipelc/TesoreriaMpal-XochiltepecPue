<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AguaPotablefrm
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AguaPotablefrm))
        Me.DatosDtg = New System.Windows.Forms.DataGridView
        Me.EstadoTsp = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TomaActivaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SuspenderTomaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CancelarTomaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NContribBtn = New DevComponents.DotNetBar.ButtonX
        Me.ConfigBtn = New DevComponents.DotNetBar.ButtonX
        Me.ItemContainer3 = New DevComponents.DotNetBar.ItemContainer
        Me.ConfigNotiBrni = New DevComponents.DotNetBar.ButtonItem
        Me.CostoRegSBtn = New DevComponents.DotNetBar.ButtonItem
        Me.CancelSuspBtn = New DevComponents.DotNetBar.ButtonX
        Me.ItemContainer2 = New DevComponents.DotNetBar.ItemContainer
        Me.CanceladasBtni = New DevComponents.DotNetBar.ButtonItem
        Me.SuspendidasBtni = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem
        Me.ExpandablePanel1 = New DevComponents.DotNetBar.ExpandablePanel
        Me.TActivasBtn = New System.Windows.Forms.Button
        Me.CallesCmb = New System.Windows.Forms.ComboBox
        Me.LocalidadesCmb = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.BuscarTomaBtn = New DevComponents.DotNetBar.ButtonX
        Me.ItemContainer1 = New DevComponents.DotNetBar.ItemContainer
        Me.PorNumBtni = New DevComponents.DotNetBar.ButtonItem
        Me.SalirBtn = New DevComponents.DotNetBar.ButtonX
        Me.DescripcionLbl = New System.Windows.Forms.Label
        Me.Titulolbl = New System.Windows.Forms.Label
        Me.TotalTomaslbl = New System.Windows.Forms.Label
        Me.TodasBtn = New System.Windows.Forms.Button
        Me.CobrarBtn = New DevComponents.DotNetBar.ButtonX
        Me.ItemContainer4 = New DevComponents.DotNetBar.ItemContainer
        Me.SancionBtn = New DevComponents.DotNetBar.ButtonItem
        Me.AdelantadoBtni = New DevComponents.DotNetBar.ButtonItem
        Me.ExpandablePanel2 = New DevComponents.DotNetBar.ExpandablePanel
        Me.PagosTodosBtn = New System.Windows.Forms.Button
        Me.PagDelAnoCmb = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.PagosDiaDtp = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.PagoMesesCmb = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TituloTotalLbl = New System.Windows.Forms.Label
        Me.TotalPagosLbl = New System.Windows.Forms.Label
        Me.ImprimirBrn = New DevComponents.DotNetBar.ButtonX
        CType(Me.DatosDtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EstadoTsp.SuspendLayout()
        Me.ExpandablePanel1.SuspendLayout()
        Me.ExpandablePanel2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.DatosDtg.ContextMenuStrip = Me.EstadoTsp
        Me.DatosDtg.GridColor = System.Drawing.Color.CornflowerBlue
        Me.DatosDtg.Location = New System.Drawing.Point(5, 56)
        Me.DatosDtg.Name = "DatosDtg"
        Me.DatosDtg.ReadOnly = True
        Me.DatosDtg.RowHeadersVisible = False
        Me.DatosDtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DatosDtg.Size = New System.Drawing.Size(552, 393)
        Me.DatosDtg.TabIndex = 0
        '
        'EstadoTsp
        '
        Me.EstadoTsp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TomaActivaToolStripMenuItem, Me.SuspenderTomaToolStripMenuItem, Me.CancelarTomaToolStripMenuItem})
        Me.EstadoTsp.Name = "EstadoTsp"
        Me.EstadoTsp.Size = New System.Drawing.Size(166, 70)
        Me.EstadoTsp.Text = "Estado"
        '
        'TomaActivaToolStripMenuItem
        '
        Me.TomaActivaToolStripMenuItem.Name = "TomaActivaToolStripMenuItem"
        Me.TomaActivaToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.TomaActivaToolStripMenuItem.Text = "Toma Activa"
        '
        'SuspenderTomaToolStripMenuItem
        '
        Me.SuspenderTomaToolStripMenuItem.Name = "SuspenderTomaToolStripMenuItem"
        Me.SuspenderTomaToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.SuspenderTomaToolStripMenuItem.Text = "Suspender Toma"
        '
        'CancelarTomaToolStripMenuItem
        '
        Me.CancelarTomaToolStripMenuItem.Name = "CancelarTomaToolStripMenuItem"
        Me.CancelarTomaToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.CancelarTomaToolStripMenuItem.Text = "Cancelar Toma"
        '
        'NContribBtn
        '
        Me.NContribBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NContribBtn.ColorScheme.DockSiteBackColorGradientAngle = 0
        Me.NContribBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.NContribBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.NContribBtn.Image = CType(resources.GetObject("NContribBtn.Image"), System.Drawing.Image)
        Me.NContribBtn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.NContribBtn.Location = New System.Drawing.Point(563, 76)
        Me.NContribBtn.Name = "NContribBtn"
        Me.NContribBtn.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5)
        Me.NContribBtn.Size = New System.Drawing.Size(46, 61)
        Me.NContribBtn.TabIndex = 2
        Me.NContribBtn.Tooltip = "Nueva Toma"
        '
        'ConfigBtn
        '
        Me.ConfigBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConfigBtn.ColorScheme.DockSiteBackColorGradientAngle = 0
        Me.ConfigBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.ConfigBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ConfigBtn.Image = CType(resources.GetObject("ConfigBtn.Image"), System.Drawing.Image)
        Me.ConfigBtn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ConfigBtn.Location = New System.Drawing.Point(564, 10)
        Me.ConfigBtn.Name = "ConfigBtn"
        Me.ConfigBtn.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F3)
        Me.ConfigBtn.Size = New System.Drawing.Size(61, 61)
        Me.ConfigBtn.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer3})
        Me.ConfigBtn.TabIndex = 0
        Me.ConfigBtn.Tooltip = "Configurar Cuotas"
        '
        'ItemContainer3
        '
        Me.ItemContainer3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer3.MinimumSize = New System.Drawing.Size(0, 0)
        Me.ItemContainer3.Name = "ItemContainer3"
        Me.ItemContainer3.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ConfigNotiBrni, Me.CostoRegSBtn})
        '
        'ConfigNotiBrni
        '
        Me.ConfigNotiBrni.Name = "ConfigNotiBrni"
        Me.ConfigNotiBrni.Text = "Notificaciones"
        '
        'CostoRegSBtn
        '
        Me.CostoRegSBtn.Name = "CostoRegSBtn"
        Me.CostoRegSBtn.Text = "Costo de Reg.."
        '
        'CancelSuspBtn
        '
        Me.CancelSuspBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelSuspBtn.ColorScheme.DockSiteBackColorGradientAngle = 0
        Me.CancelSuspBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.CancelSuspBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CancelSuspBtn.Image = CType(resources.GetObject("CancelSuspBtn.Image"), System.Drawing.Image)
        Me.CancelSuspBtn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.CancelSuspBtn.Location = New System.Drawing.Point(627, 10)
        Me.CancelSuspBtn.Name = "CancelSuspBtn"
        Me.CancelSuspBtn.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F4)
        Me.CancelSuspBtn.Size = New System.Drawing.Size(70, 61)
        Me.CancelSuspBtn.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer2})
        Me.CancelSuspBtn.TabIndex = 1
        Me.CancelSuspBtn.Tooltip = "Tomas Canceladas y suspendidas"
        '
        'ItemContainer2
        '
        Me.ItemContainer2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer2.MinimumSize = New System.Drawing.Size(0, 0)
        Me.ItemContainer2.Name = "ItemContainer2"
        Me.ItemContainer2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.CanceladasBtni, Me.SuspendidasBtni})
        '
        'CanceladasBtni
        '
        Me.CanceladasBtni.Name = "CanceladasBtni"
        Me.CanceladasBtni.Text = "Canceladas"
        Me.CanceladasBtni.Tooltip = "Mostrar solo tomas canceladas"
        '
        'SuspendidasBtni
        '
        Me.SuspendidasBtni.Name = "SuspendidasBtni"
        Me.SuspendidasBtni.Text = "Suspendidas"
        Me.SuspendidasBtni.Tooltip = "Mostrar solo tomas suspendidas"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Text = "Tarifas"
        '
        'ExpandablePanel1
        '
        Me.ExpandablePanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExpandablePanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.ExpandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.ExpandablePanel1.Controls.Add(Me.TActivasBtn)
        Me.ExpandablePanel1.Controls.Add(Me.CallesCmb)
        Me.ExpandablePanel1.Controls.Add(Me.LocalidadesCmb)
        Me.ExpandablePanel1.Controls.Add(Me.Label1)
        Me.ExpandablePanel1.Controls.Add(Me.Label2)
        Me.ExpandablePanel1.Controls.Add(Me.Label3)
        Me.ExpandablePanel1.Expanded = False
        Me.ExpandablePanel1.ExpandedBounds = New System.Drawing.Rectangle(564, 210, 134, 181)
        Me.ExpandablePanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpandablePanel1.Location = New System.Drawing.Point(563, 210)
        Me.ExpandablePanel1.Name = "ExpandablePanel1"
        Me.ExpandablePanel1.Size = New System.Drawing.Size(134, 26)
        Me.ExpandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.ExpandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.ExpandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.ExpandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandablePanel1.Style.GradientAngle = 90
        Me.ExpandablePanel1.TabIndex = 7
        Me.ExpandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.ExpandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ExpandablePanel1.TitleStyle.GradientAngle = 90
        Me.ExpandablePanel1.TitleText = "Tomas activas"
        '
        'TActivasBtn
        '
        Me.TActivasBtn.Location = New System.Drawing.Point(15, 32)
        Me.TActivasBtn.Name = "TActivasBtn"
        Me.TActivasBtn.Size = New System.Drawing.Size(108, 25)
        Me.TActivasBtn.TabIndex = 1
        Me.TActivasBtn.Text = "Mostrar Todas"
        Me.TActivasBtn.UseVisualStyleBackColor = True
        '
        'CallesCmb
        '
        Me.CallesCmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CallesCmb.FormattingEnabled = True
        Me.CallesCmb.Location = New System.Drawing.Point(6, 148)
        Me.CallesCmb.Name = "CallesCmb"
        Me.CallesCmb.Size = New System.Drawing.Size(122, 24)
        Me.CallesCmb.TabIndex = 13
        '
        'LocalidadesCmb
        '
        Me.LocalidadesCmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LocalidadesCmb.FormattingEnabled = True
        Me.LocalidadesCmb.Location = New System.Drawing.Point(6, 95)
        Me.LocalidadesCmb.Name = "LocalidadesCmb"
        Me.LocalidadesCmb.Size = New System.Drawing.Size(122, 24)
        Me.LocalidadesCmb.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(3, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Filtrar por Calle"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(3, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Por Localidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(12, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "_____________"
        '
        'BuscarTomaBtn
        '
        Me.BuscarTomaBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BuscarTomaBtn.ColorScheme.DockSiteBackColorGradientAngle = 0
        Me.BuscarTomaBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.BuscarTomaBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BuscarTomaBtn.Image = CType(resources.GetObject("BuscarTomaBtn.Image"), System.Drawing.Image)
        Me.BuscarTomaBtn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.BuscarTomaBtn.Location = New System.Drawing.Point(627, 76)
        Me.BuscarTomaBtn.Name = "BuscarTomaBtn"
        Me.BuscarTomaBtn.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F6)
        Me.BuscarTomaBtn.Size = New System.Drawing.Size(70, 61)
        Me.BuscarTomaBtn.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer1})
        Me.BuscarTomaBtn.TabIndex = 3
        Me.BuscarTomaBtn.Tooltip = "Buscar toma"
        '
        'ItemContainer1
        '
        Me.ItemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer1.MinimumSize = New System.Drawing.Size(0, 0)
        Me.ItemContainer1.Name = "ItemContainer1"
        Me.ItemContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.PorNumBtni})
        '
        'PorNumBtni
        '
        Me.PorNumBtni.Name = "PorNumBtni"
        Me.PorNumBtni.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F7)
        Me.PorNumBtni.Text = "Por Numero"
        Me.PorNumBtni.Tooltip = "Buscar toma por numero de toma"
        '
        'SalirBtn
        '
        Me.SalirBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SalirBtn.ColorScheme.DockSiteBackColorGradientAngle = 0
        Me.SalirBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.SalirBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SalirBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.SalirBtn.Image = CType(resources.GetObject("SalirBtn.Image"), System.Drawing.Image)
        Me.SalirBtn.Location = New System.Drawing.Point(640, 416)
        Me.SalirBtn.Name = "SalirBtn"
        Me.SalirBtn.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F12)
        Me.SalirBtn.Size = New System.Drawing.Size(57, 63)
        Me.SalirBtn.TabIndex = 8
        Me.SalirBtn.Tooltip = "Salir del sistema"
        '
        'DescripcionLbl
        '
        Me.DescripcionLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DescripcionLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionLbl.Location = New System.Drawing.Point(22, 459)
        Me.DescripcionLbl.Name = "DescripcionLbl"
        Me.DescripcionLbl.Size = New System.Drawing.Size(151, 20)
        Me.DescripcionLbl.TabIndex = 9
        Me.DescripcionLbl.Text = "Total de Tomas:"
        Me.DescripcionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Titulolbl
        '
        Me.Titulolbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Titulolbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulolbl.Location = New System.Drawing.Point(5, 9)
        Me.Titulolbl.Name = "Titulolbl"
        Me.Titulolbl.Size = New System.Drawing.Size(549, 43)
        Me.Titulolbl.TabIndex = 9
        Me.Titulolbl.Text = "TOMAS  DE AGUA POTABLE...."
        Me.Titulolbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TotalTomaslbl
        '
        Me.TotalTomaslbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TotalTomaslbl.AutoSize = True
        Me.TotalTomaslbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalTomaslbl.Location = New System.Drawing.Point(179, 456)
        Me.TotalTomaslbl.Name = "TotalTomaslbl"
        Me.TotalTomaslbl.Size = New System.Drawing.Size(21, 24)
        Me.TotalTomaslbl.TabIndex = 10
        Me.TotalTomaslbl.Text = "0"
        '
        'TodasBtn
        '
        Me.TodasBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TodasBtn.Location = New System.Drawing.Point(582, 282)
        Me.TodasBtn.Name = "TodasBtn"
        Me.TodasBtn.Size = New System.Drawing.Size(102, 25)
        Me.TodasBtn.TabIndex = 11
        Me.TodasBtn.Text = "Todas las Tomas"
        Me.TodasBtn.UseVisualStyleBackColor = True
        '
        'CobrarBtn
        '
        Me.CobrarBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CobrarBtn.ColorScheme.DockSiteBackColorGradientAngle = 0
        Me.CobrarBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.CobrarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CobrarBtn.Image = CType(resources.GetObject("CobrarBtn.Image"), System.Drawing.Image)
        Me.CobrarBtn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.CobrarBtn.Location = New System.Drawing.Point(563, 143)
        Me.CobrarBtn.Name = "CobrarBtn"
        Me.CobrarBtn.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F8)
        Me.CobrarBtn.Size = New System.Drawing.Size(57, 61)
        Me.CobrarBtn.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer4})
        Me.CobrarBtn.TabIndex = 4
        Me.CobrarBtn.Tooltip = "Cobrar Agua Potable"
        '
        'ItemContainer4
        '
        Me.ItemContainer4.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer4.MinimumSize = New System.Drawing.Size(0, 0)
        Me.ItemContainer4.Name = "ItemContainer4"
        Me.ItemContainer4.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SancionBtn, Me.AdelantadoBtni})
        '
        'SancionBtn
        '
        Me.SancionBtn.Name = "SancionBtn"
        Me.SancionBtn.Text = "Otro Pago"
        Me.SancionBtn.Tooltip = "Multas, Recargos, Permisos, etc."
        '
        'AdelantadoBtni
        '
        Me.AdelantadoBtni.Name = "AdelantadoBtni"
        Me.AdelantadoBtni.Text = "Cobro Adelantado"
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
        Me.ExpandablePanel2.Controls.Add(Me.Label4)
        Me.ExpandablePanel2.Controls.Add(Me.PagoMesesCmb)
        Me.ExpandablePanel2.Controls.Add(Me.Label7)
        Me.ExpandablePanel2.Controls.Add(Me.Label6)
        Me.ExpandablePanel2.Controls.Add(Me.Label9)
        Me.ExpandablePanel2.Controls.Add(Me.Label5)
        Me.ExpandablePanel2.Expanded = False
        Me.ExpandablePanel2.ExpandedBounds = New System.Drawing.Rectangle(564, 242, 134, 238)
        Me.ExpandablePanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpandablePanel2.Location = New System.Drawing.Point(563, 242)
        Me.ExpandablePanel2.Name = "ExpandablePanel2"
        Me.ExpandablePanel2.Size = New System.Drawing.Size(134, 26)
        Me.ExpandablePanel2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.ExpandablePanel2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.ExpandablePanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.ExpandablePanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandablePanel2.Style.GradientAngle = 90
        Me.ExpandablePanel2.TabIndex = 12
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
        Me.PagosTodosBtn.Location = New System.Drawing.Point(28, 31)
        Me.PagosTodosBtn.Name = "PagosTodosBtn"
        Me.PagosTodosBtn.Size = New System.Drawing.Size(68, 26)
        Me.PagosTodosBtn.TabIndex = 18
        Me.PagosTodosBtn.Text = "Todos"
        Me.PagosTodosBtn.UseVisualStyleBackColor = True
        '
        'PagDelAnoCmb
        '
        Me.PagDelAnoCmb.FormattingEnabled = True
        Me.PagDelAnoCmb.Location = New System.Drawing.Point(7, 206)
        Me.PagDelAnoCmb.Name = "PagDelAnoCmb"
        Me.PagDelAnoCmb.Size = New System.Drawing.Size(118, 24)
        Me.PagDelAnoCmb.Sorted = True
        Me.PagDelAnoCmb.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 187)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Del Año"
        '
        'PagosDiaDtp
        '
        Me.PagosDiaDtp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PagosDiaDtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.PagosDiaDtp.Location = New System.Drawing.Point(6, 149)
        Me.PagosDiaDtp.Name = "PagosDiaDtp"
        Me.PagosDiaDtp.Size = New System.Drawing.Size(120, 23)
        Me.PagosDiaDtp.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(3, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "_______________"
        '
        'PagoMesesCmb
        '
        Me.PagoMesesCmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PagoMesesCmb.FormattingEnabled = True
        Me.PagoMesesCmb.Items.AddRange(New Object() {"enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre", "", "Todos"})
        Me.PagoMesesCmb.Location = New System.Drawing.Point(6, 91)
        Me.PagoMesesCmb.Name = "PagoMesesCmb"
        Me.PagoMesesCmb.Size = New System.Drawing.Size(120, 24)
        Me.PagoMesesCmb.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Del Dia:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(2, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Pagos del mes:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(3, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 17)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "_______________"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(2, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "_______________"
        '
        'TituloTotalLbl
        '
        Me.TituloTotalLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TituloTotalLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TituloTotalLbl.Location = New System.Drawing.Point(319, 459)
        Me.TituloTotalLbl.Name = "TituloTotalLbl"
        Me.TituloTotalLbl.Size = New System.Drawing.Size(142, 20)
        Me.TituloTotalLbl.TabIndex = 9
        Me.TituloTotalLbl.Text = "Total de Pagos:"
        Me.TituloTotalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TituloTotalLbl.Visible = False
        '
        'TotalPagosLbl
        '
        Me.TotalPagosLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TotalPagosLbl.AutoSize = True
        Me.TotalPagosLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPagosLbl.Location = New System.Drawing.Point(467, 456)
        Me.TotalPagosLbl.Name = "TotalPagosLbl"
        Me.TotalPagosLbl.Size = New System.Drawing.Size(21, 24)
        Me.TotalPagosLbl.TabIndex = 10
        Me.TotalPagosLbl.Text = "0"
        Me.TotalPagosLbl.Visible = False
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
        Me.ImprimirBrn.Location = New System.Drawing.Point(640, 143)
        Me.ImprimirBrn.Name = "ImprimirBrn"
        Me.ImprimirBrn.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F9)
        Me.ImprimirBrn.Size = New System.Drawing.Size(57, 61)
        Me.ImprimirBrn.TabIndex = 5
        Me.ImprimirBrn.Tooltip = "Imprimir Reporte de Pagos"
        '
        'AguaPotablefrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(706, 486)
        Me.Controls.Add(Me.ExpandablePanel1)
        Me.Controls.Add(Me.ExpandablePanel2)
        Me.Controls.Add(Me.TotalPagosLbl)
        Me.Controls.Add(Me.TotalTomaslbl)
        Me.Controls.Add(Me.Titulolbl)
        Me.Controls.Add(Me.TituloTotalLbl)
        Me.Controls.Add(Me.DescripcionLbl)
        Me.Controls.Add(Me.CancelSuspBtn)
        Me.Controls.Add(Me.DatosDtg)
        Me.Controls.Add(Me.TodasBtn)
        Me.Controls.Add(Me.ConfigBtn)
        Me.Controls.Add(Me.BuscarTomaBtn)
        Me.Controls.Add(Me.ImprimirBrn)
        Me.Controls.Add(Me.CobrarBtn)
        Me.Controls.Add(Me.SalirBtn)
        Me.Controls.Add(Me.NContribBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AguaPotablefrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SISTEMA DE AGUA POTABLE : "
        CType(Me.DatosDtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EstadoTsp.ResumeLayout(False)
        Me.ExpandablePanel1.ResumeLayout(False)
        Me.ExpandablePanel1.PerformLayout()
        Me.ExpandablePanel2.ResumeLayout(False)
        Me.ExpandablePanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatosDtg As System.Windows.Forms.DataGridView
    Friend WithEvents NContribBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ConfigBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents CancelSuspBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ExpandablePanel1 As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents TActivasBtn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CallesCmb As System.Windows.Forms.ComboBox
    Friend WithEvents LocalidadesCmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BuscarTomaBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ItemContainer1 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents PorNumBtni As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents SalirBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DescripcionLbl As System.Windows.Forms.Label
    Friend WithEvents Titulolbl As System.Windows.Forms.Label
    Friend WithEvents TotalTomaslbl As System.Windows.Forms.Label
    Friend WithEvents EstadoTsp As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TomaActivaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuspenderTomaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelarTomaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TodasBtn As System.Windows.Forms.Button
    Friend WithEvents ItemContainer2 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents CanceladasBtni As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents SuspendidasBtni As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CobrarBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ExpandablePanel2 As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents PagoMesesCmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PagosDiaDtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TituloTotalLbl As System.Windows.Forms.Label
    Friend WithEvents TotalPagosLbl As System.Windows.Forms.Label
    Friend WithEvents ImprimirBrn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ItemContainer3 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ConfigNotiBrni As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PagDelAnoCmb As System.Windows.Forms.ComboBox
    Friend WithEvents PagosTodosBtn As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CostoRegSBtn As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ItemContainer4 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents SancionBtn As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents AdelantadoBtni As DevComponents.DotNetBar.ButtonItem
End Class
