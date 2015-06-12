<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlPanelFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlPanelFrm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ContribuyentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IngresosPropiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AguaPotableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RegistroCivilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ImpuestoPredialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TrascaboYVolteoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TortiMpalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OtrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EgresosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DepositosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReporteGeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DatosGeneralesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DatosGeneralesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RespaldarBDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RestaurarBDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BorrarDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ResumenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CanceladasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CambiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.infoLbl = New System.Windows.Forms.Label
        Me.SalirBtn = New DevComponents.DotNetBar.ButtonX
        Me.Label1 = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DatosGeneralesToolStripMenuItem, Me.HerramientasToolStripMenuItem, Me.FacturasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(386, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContribuyentesToolStripMenuItem, Me.IngresosPropiosToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(36, 20)
        Me.FileToolStripMenuItem.Text = "&Ir a"
        '
        'ContribuyentesToolStripMenuItem
        '
        Me.ContribuyentesToolStripMenuItem.Name = "ContribuyentesToolStripMenuItem"
        Me.ContribuyentesToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ContribuyentesToolStripMenuItem.Text = "Contribuyentes"
        '
        'IngresosPropiosToolStripMenuItem
        '
        Me.IngresosPropiosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AguaPotableToolStripMenuItem, Me.RegistroCivilToolStripMenuItem, Me.ImpuestoPredialToolStripMenuItem, Me.TrascaboYVolteoToolStripMenuItem, Me.TortiMpalToolStripMenuItem, Me.OtrosToolStripMenuItem, Me.EgresosToolStripMenuItem, Me.DepositosToolStripMenuItem, Me.ReporteGeneralToolStripMenuItem})
        Me.IngresosPropiosToolStripMenuItem.Name = "IngresosPropiosToolStripMenuItem"
        Me.IngresosPropiosToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.IngresosPropiosToolStripMenuItem.Text = "Ingresos Propios"
        '
        'AguaPotableToolStripMenuItem
        '
        Me.AguaPotableToolStripMenuItem.Name = "AguaPotableToolStripMenuItem"
        Me.AguaPotableToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AguaPotableToolStripMenuItem.Text = "Agua Potable"
        '
        'RegistroCivilToolStripMenuItem
        '
        Me.RegistroCivilToolStripMenuItem.Name = "RegistroCivilToolStripMenuItem"
        Me.RegistroCivilToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.RegistroCivilToolStripMenuItem.Text = "Registro Civil"
        '
        'ImpuestoPredialToolStripMenuItem
        '
        Me.ImpuestoPredialToolStripMenuItem.Name = "ImpuestoPredialToolStripMenuItem"
        Me.ImpuestoPredialToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ImpuestoPredialToolStripMenuItem.Text = "Impuesto Predial"
        '
        'TrascaboYVolteoToolStripMenuItem
        '
        Me.TrascaboYVolteoToolStripMenuItem.Name = "TrascaboYVolteoToolStripMenuItem"
        Me.TrascaboYVolteoToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.TrascaboYVolteoToolStripMenuItem.Text = "Trascabo y Volteo"
        '
        'TortiMpalToolStripMenuItem
        '
        Me.TortiMpalToolStripMenuItem.Name = "TortiMpalToolStripMenuItem"
        Me.TortiMpalToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.TortiMpalToolStripMenuItem.Text = "Tortilleria Mpal"
        '
        'OtrosToolStripMenuItem
        '
        Me.OtrosToolStripMenuItem.Name = "OtrosToolStripMenuItem"
        Me.OtrosToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.OtrosToolStripMenuItem.Text = "Otros Ingresos"
        '
        'EgresosToolStripMenuItem
        '
        Me.EgresosToolStripMenuItem.Name = "EgresosToolStripMenuItem"
        Me.EgresosToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.EgresosToolStripMenuItem.Text = "Egresos"
        '
        'DepositosToolStripMenuItem
        '
        Me.DepositosToolStripMenuItem.Name = "DepositosToolStripMenuItem"
        Me.DepositosToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.DepositosToolStripMenuItem.Text = "Depositos"
        '
        'ReporteGeneralToolStripMenuItem
        '
        Me.ReporteGeneralToolStripMenuItem.Name = "ReporteGeneralToolStripMenuItem"
        Me.ReporteGeneralToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ReporteGeneralToolStripMenuItem.Text = "Resumen Ing. Prop."
        '
        'DatosGeneralesToolStripMenuItem
        '
        Me.DatosGeneralesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatosGeneralesToolStripMenuItem1, Me.UsuarioToolStripMenuItem})
        Me.DatosGeneralesToolStripMenuItem.Name = "DatosGeneralesToolStripMenuItem"
        Me.DatosGeneralesToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.DatosGeneralesToolStripMenuItem.Text = "&Configurar"
        '
        'DatosGeneralesToolStripMenuItem1
        '
        Me.DatosGeneralesToolStripMenuItem1.Name = "DatosGeneralesToolStripMenuItem1"
        Me.DatosGeneralesToolStripMenuItem1.Size = New System.Drawing.Size(164, 22)
        Me.DatosGeneralesToolStripMenuItem1.Text = "Datos Generales"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.UsuarioToolStripMenuItem.Text = "Usuarios"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RespaldarBDToolStripMenuItem, Me.RestaurarBDToolStripMenuItem, Me.BorrarDatosToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.HerramientasToolStripMenuItem.Text = "Herramientas"
        '
        'RespaldarBDToolStripMenuItem
        '
        Me.RespaldarBDToolStripMenuItem.Name = "RespaldarBDToolStripMenuItem"
        Me.RespaldarBDToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.RespaldarBDToolStripMenuItem.Text = "Respaldar BD"
        '
        'RestaurarBDToolStripMenuItem
        '
        Me.RestaurarBDToolStripMenuItem.Name = "RestaurarBDToolStripMenuItem"
        Me.RestaurarBDToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.RestaurarBDToolStripMenuItem.Text = "Restaurar BD"
        '
        'BorrarDatosToolStripMenuItem
        '
        Me.BorrarDatosToolStripMenuItem.Name = "BorrarDatosToolStripMenuItem"
        Me.BorrarDatosToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.BorrarDatosToolStripMenuItem.Text = "Eliminar Ing. Propios"
        '
        'FacturasToolStripMenuItem
        '
        Me.FacturasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResumenToolStripMenuItem, Me.CanceladasToolStripMenuItem, Me.CambiarToolStripMenuItem})
        Me.FacturasToolStripMenuItem.Name = "FacturasToolStripMenuItem"
        Me.FacturasToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.FacturasToolStripMenuItem.Text = "Facturas"
        '
        'ResumenToolStripMenuItem
        '
        Me.ResumenToolStripMenuItem.Name = "ResumenToolStripMenuItem"
        Me.ResumenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ResumenToolStripMenuItem.Text = "Resumen"
        '
        'CanceladasToolStripMenuItem
        '
        Me.CanceladasToolStripMenuItem.Name = "CanceladasToolStripMenuItem"
        Me.CanceladasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CanceladasToolStripMenuItem.Text = "Canceladas"
        '
        'CambiarToolStripMenuItem
        '
        Me.CambiarToolStripMenuItem.Name = "CambiarToolStripMenuItem"
        Me.CambiarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CambiarToolStripMenuItem.Text = "Cambiar"
        '
        'infoLbl
        '
        Me.infoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.infoLbl.Location = New System.Drawing.Point(12, 95)
        Me.infoLbl.Name = "infoLbl"
        Me.infoLbl.Size = New System.Drawing.Size(256, 24)
        Me.infoLbl.TabIndex = 7
        '
        'SalirBtn
        '
        Me.SalirBtn.ColorScheme.DockSiteBackColorGradientAngle = 0
        Me.SalirBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.SalirBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SalirBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalirBtn.Image = CType(resources.GetObject("SalirBtn.Image"), System.Drawing.Image)
        Me.SalirBtn.Location = New System.Drawing.Point(317, 38)
        Me.SalirBtn.Name = "SalirBtn"
        Me.SalirBtn.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F12)
        Me.SalirBtn.Size = New System.Drawing.Size(57, 60)
        Me.SalirBtn.TabIndex = 5
        Me.SalirBtn.Tooltip = "Salir del sistema"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 60)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Registre los datos de cobro correctamente, ya que no se pueden cancelar."
        '
        'ControlPanelFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CancelButton = Me.SalirBtn
        Me.ClientSize = New System.Drawing.Size(386, 124)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.infoLbl)
        Me.Controls.Add(Me.SalirBtn)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(394, 158)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(394, 158)
        Me.Name = "ControlPanelFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TESORERIA   MUNICIPAL  :  "
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SalirBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContribuyentesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresosPropiosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AguaPotableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroCivilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrascaboYVolteoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TortiMpalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EgresosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteGeneralToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatosGeneralesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents infoLbl As System.Windows.Forms.Label
    Friend WithEvents DatosGeneralesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImpuestoPredialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepositosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RespaldarBDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestaurarBDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BorrarDatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FacturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResumenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CanceladasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
