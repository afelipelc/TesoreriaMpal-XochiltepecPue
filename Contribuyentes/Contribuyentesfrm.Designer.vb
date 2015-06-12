<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contribuyentesfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Contribuyentesfrm))
        Me.DatosDtg = New System.Windows.Forms.DataGridView
        Me.NContribBtn = New DevComponents.DotNetBar.ButtonX
        Me.SalirBtn = New DevComponents.DotNetBar.ButtonX
        Me.MostrartodosBtn = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.ExpandablePanel1 = New DevComponents.DotNetBar.ExpandablePanel
        Me.CallesCmb = New System.Windows.Forms.ComboBox
        Me.LocalidadesCmb = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TotalContribLbl = New System.Windows.Forms.Label
        CType(Me.DatosDtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ExpandablePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DatosDtg
        '
        Me.DatosDtg.AllowUserToAddRows = False
        Me.DatosDtg.AllowUserToDeleteRows = False
        resources.ApplyResources(Me.DatosDtg, "DatosDtg")
        Me.DatosDtg.BackgroundColor = System.Drawing.Color.White
        Me.DatosDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatosDtg.GridColor = System.Drawing.Color.SteelBlue
        Me.DatosDtg.MultiSelect = False
        Me.DatosDtg.Name = "DatosDtg"
        Me.DatosDtg.ReadOnly = True
        Me.DatosDtg.RowHeadersVisible = False
        Me.DatosDtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'NContribBtn
        '
        resources.ApplyResources(Me.NContribBtn, "NContribBtn")
        Me.NContribBtn.ColorScheme.DockSiteBackColorGradientAngle = 0
        Me.NContribBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.NContribBtn.Image = CType(resources.GetObject("NContribBtn.Image"), System.Drawing.Image)
        Me.NContribBtn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.NContribBtn.Name = "NContribBtn"
        Me.NContribBtn.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5)
        '
        'SalirBtn
        '
        resources.ApplyResources(Me.SalirBtn, "SalirBtn")
        Me.SalirBtn.ColorScheme.DockSiteBackColorGradientAngle = 0
        Me.SalirBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.SalirBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SalirBtn.Image = CType(resources.GetObject("SalirBtn.Image"), System.Drawing.Image)
        Me.SalirBtn.Name = "SalirBtn"
        Me.SalirBtn.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F12)
        '
        'MostrartodosBtn
        '
        resources.ApplyResources(Me.MostrartodosBtn, "MostrartodosBtn")
        Me.MostrartodosBtn.Name = "MostrartodosBtn"
        Me.MostrartodosBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'ExpandablePanel1
        '
        resources.ApplyResources(Me.ExpandablePanel1, "ExpandablePanel1")
        Me.ExpandablePanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.ExpandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.ExpandablePanel1.Controls.Add(Me.CallesCmb)
        Me.ExpandablePanel1.Controls.Add(Me.LocalidadesCmb)
        Me.ExpandablePanel1.Controls.Add(Me.MostrartodosBtn)
        Me.ExpandablePanel1.Controls.Add(Me.Label3)
        Me.ExpandablePanel1.Controls.Add(Me.Label1)
        Me.ExpandablePanel1.Controls.Add(Me.Label2)
        Me.ExpandablePanel1.Name = "ExpandablePanel1"
        Me.ExpandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.ExpandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.ExpandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.ExpandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandablePanel1.Style.GradientAngle = 90
        Me.ExpandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.ExpandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ExpandablePanel1.TitleStyle.GradientAngle = 90
        Me.ExpandablePanel1.TitleText = "Mostrar"
        '
        'CallesCmb
        '
        resources.ApplyResources(Me.CallesCmb, "CallesCmb")
        Me.CallesCmb.FormattingEnabled = True
        Me.CallesCmb.Name = "CallesCmb"
        '
        'LocalidadesCmb
        '
        resources.ApplyResources(Me.LocalidadesCmb, "LocalidadesCmb")
        Me.LocalidadesCmb.FormattingEnabled = True
        Me.LocalidadesCmb.Name = "LocalidadesCmb"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'TotalContribLbl
        '
        resources.ApplyResources(Me.TotalContribLbl, "TotalContribLbl")
        Me.TotalContribLbl.Name = "TotalContribLbl"
        '
        'Contribuyentesfrm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CancelButton = Me.SalirBtn
        Me.Controls.Add(Me.ExpandablePanel1)
        Me.Controls.Add(Me.SalirBtn)
        Me.Controls.Add(Me.NContribBtn)
        Me.Controls.Add(Me.DatosDtg)
        Me.Controls.Add(Me.TotalContribLbl)
        Me.Controls.Add(Me.Label4)
        Me.Name = "Contribuyentesfrm"
        CType(Me.DatosDtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ExpandablePanel1.ResumeLayout(False)
        Me.ExpandablePanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatosDtg As System.Windows.Forms.DataGridView
    Friend WithEvents NContribBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents SalirBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents MostrartodosBtn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ExpandablePanel1 As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents CallesCmb As System.Windows.Forms.ComboBox
    Friend WithEvents LocalidadesCmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TotalContribLbl As System.Windows.Forms.Label
End Class
