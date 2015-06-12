<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tortilleriafrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tortilleriafrm))
        Me.TituloLbl = New System.Windows.Forms.Label
        Me.DatosDtg = New System.Windows.Forms.DataGridView
        Me.ConceptosTotallbl = New System.Windows.Forms.Label
        Me.ConceptosTituloLbl = New System.Windows.Forms.Label
        Me.IngresoTotalLbl = New System.Windows.Forms.Label
        Me.TotalConcepLbl = New System.Windows.Forms.Label
        Me.ImprimirBrn = New DevComponents.DotNetBar.ButtonX
        Me.NIngBtn = New DevComponents.DotNetBar.ButtonX
        Me.ExpandablePanel1 = New DevComponents.DotNetBar.ExpandablePanel
        Me.TodosBtn = New System.Windows.Forms.Button
        Me.IngDiaDtp = New System.Windows.Forms.DateTimePicker
        Me.IngDelAnoCmb = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.IngMesCmb = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
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
        Me.TituloLbl.Location = New System.Drawing.Point(6, 7)
        Me.TituloLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TituloLbl.Name = "TituloLbl"
        Me.TituloLbl.Size = New System.Drawing.Size(391, 69)
        Me.TituloLbl.TabIndex = 4
        Me.TituloLbl.Text = "INGRESOS DE LA TORTILLERIA MUNICIPAL"
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
        Me.DatosDtg.Location = New System.Drawing.Point(5, 80)
        Me.DatosDtg.Margin = New System.Windows.Forms.Padding(4)
        Me.DatosDtg.Name = "DatosDtg"
        Me.DatosDtg.ReadOnly = True
        Me.DatosDtg.RowHeadersVisible = False
        Me.DatosDtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DatosDtg.Size = New System.Drawing.Size(392, 217)
        Me.DatosDtg.TabIndex = 5
        '
        'ConceptosTotallbl
        '
        Me.ConceptosTotallbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ConceptosTotallbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConceptosTotallbl.Location = New System.Drawing.Point(447, 301)
        Me.ConceptosTotallbl.Name = "ConceptosTotallbl"
        Me.ConceptosTotallbl.Size = New System.Drawing.Size(80, 20)
        Me.ConceptosTotallbl.TabIndex = 10
        Me.ConceptosTotallbl.Text = "0"
        '
        'ConceptosTituloLbl
        '
        Me.ConceptosTituloLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ConceptosTituloLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConceptosTituloLbl.Location = New System.Drawing.Point(284, 301)
        Me.ConceptosTituloLbl.Name = "ConceptosTituloLbl"
        Me.ConceptosTituloLbl.Size = New System.Drawing.Size(157, 20)
        Me.ConceptosTituloLbl.TabIndex = 11
        Me.ConceptosTituloLbl.Text = "Total de Ingresos:"
        Me.ConceptosTituloLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IngresoTotalLbl
        '
        Me.IngresoTotalLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.IngresoTotalLbl.AutoSize = True
        Me.IngresoTotalLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IngresoTotalLbl.Location = New System.Drawing.Point(114, 301)
        Me.IngresoTotalLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IngresoTotalLbl.Name = "IngresoTotalLbl"
        Me.IngresoTotalLbl.Size = New System.Drawing.Size(50, 22)
        Me.IngresoTotalLbl.TabIndex = 8
        Me.IngresoTotalLbl.Text = "$ 0.0"
        '
        'TotalConcepLbl
        '
        Me.TotalConcepLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TotalConcepLbl.AutoSize = True
        Me.TotalConcepLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalConcepLbl.Location = New System.Drawing.Point(9, 301)
        Me.TotalConcepLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TotalConcepLbl.Name = "TotalConcepLbl"
        Me.TotalConcepLbl.Size = New System.Drawing.Size(106, 20)
        Me.TotalConcepLbl.TabIndex = 9
        Me.TotalConcepLbl.Text = "Ingreso Total:"
        '
        'ImprimirBrn
        '
        Me.ImprimirBrn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImprimirBrn.ColorScheme.DockSiteBackColorGradientAngle = 0
        Me.ImprimirBrn.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.ImprimirBrn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ImprimirBrn.Image = CType(resources.GetObject("ImprimirBrn.Image"), System.Drawing.Image)
        Me.ImprimirBrn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ImprimirBrn.Location = New System.Drawing.Point(465, 24)
        Me.ImprimirBrn.Name = "ImprimirBrn"
        Me.ImprimirBrn.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F8)
        Me.ImprimirBrn.Size = New System.Drawing.Size(57, 52)
        Me.ImprimirBrn.TabIndex = 15
        Me.ImprimirBrn.Tooltip = "Imprimir Reporte de Pagos"
        '
        'NIngBtn
        '
        Me.NIngBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NIngBtn.ColorScheme.DockSiteBackColorGradientAngle = 0
        Me.NIngBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.NIngBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.NIngBtn.Image = CType(resources.GetObject("NIngBtn.Image"), System.Drawing.Image)
        Me.NIngBtn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.NIngBtn.Location = New System.Drawing.Point(404, 24)
        Me.NIngBtn.Name = "NIngBtn"
        Me.NIngBtn.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5)
        Me.NIngBtn.Size = New System.Drawing.Size(46, 52)
        Me.NIngBtn.TabIndex = 14
        Me.NIngBtn.Tooltip = "Nuevo Ingreso"
        '
        'ExpandablePanel1
        '
        Me.ExpandablePanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExpandablePanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.ExpandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.ExpandablePanel1.Controls.Add(Me.TodosBtn)
        Me.ExpandablePanel1.Controls.Add(Me.IngDiaDtp)
        Me.ExpandablePanel1.Controls.Add(Me.IngDelAnoCmb)
        Me.ExpandablePanel1.Controls.Add(Me.Label6)
        Me.ExpandablePanel1.Controls.Add(Me.Label9)
        Me.ExpandablePanel1.Controls.Add(Me.Label12)
        Me.ExpandablePanel1.Controls.Add(Me.IngMesCmb)
        Me.ExpandablePanel1.Controls.Add(Me.Label1)
        Me.ExpandablePanel1.Controls.Add(Me.Label5)
        Me.ExpandablePanel1.Controls.Add(Me.Label11)
        Me.ExpandablePanel1.Expanded = False
        Me.ExpandablePanel1.ExpandedBounds = New System.Drawing.Rectangle(404, 90, 118, 223)
        Me.ExpandablePanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpandablePanel1.Location = New System.Drawing.Point(404, 90)
        Me.ExpandablePanel1.Name = "ExpandablePanel1"
        Me.ExpandablePanel1.Size = New System.Drawing.Size(118, 26)
        Me.ExpandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.ExpandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.ExpandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.ExpandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandablePanel1.Style.GradientAngle = 90
        Me.ExpandablePanel1.TabIndex = 16
        Me.ExpandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.ExpandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ExpandablePanel1.TitleStyle.GradientAngle = 90
        Me.ExpandablePanel1.TitleText = "Ingresos"
        '
        'TodosBtn
        '
        Me.TodosBtn.Location = New System.Drawing.Point(34, 31)
        Me.TodosBtn.Name = "TodosBtn"
        Me.TodosBtn.Size = New System.Drawing.Size(57, 24)
        Me.TodosBtn.TabIndex = 1
        Me.TodosBtn.Text = "Todos"
        Me.TodosBtn.UseVisualStyleBackColor = True
        '
        'IngDiaDtp
        '
        Me.IngDiaDtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.IngDiaDtp.Location = New System.Drawing.Point(11, 139)
        Me.IngDiaDtp.Name = "IngDiaDtp"
        Me.IngDiaDtp.Size = New System.Drawing.Size(95, 21)
        Me.IngDiaDtp.TabIndex = 14
        '
        'IngDelAnoCmb
        '
        Me.IngDelAnoCmb.FormattingEnabled = True
        Me.IngDelAnoCmb.Location = New System.Drawing.Point(9, 192)
        Me.IngDelAnoCmb.Name = "IngDelAnoCmb"
        Me.IngDelAnoCmb.Size = New System.Drawing.Size(101, 23)
        Me.IngDelAnoCmb.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Del mes de:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 15)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Del dia:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(5, 177)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 15)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Del año:"
        '
        'IngMesCmb
        '
        Me.IngMesCmb.FormattingEnabled = True
        Me.IngMesCmb.Items.AddRange(New Object() {"enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre"})
        Me.IngMesCmb.Location = New System.Drawing.Point(10, 82)
        Me.IngMesCmb.Name = "IngMesCmb"
        Me.IngMesCmb.Size = New System.Drawing.Size(96, 23)
        Me.IngMesCmb.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "______________"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "______________"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(4, 158)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 15)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "______________"
        '
        'SalirBtn
        '
        Me.SalirBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SalirBtn.ColorScheme.DockSiteBackColorGradientAngle = 0
        Me.SalirBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.SalirBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.SalirBtn.Image = CType(resources.GetObject("SalirBtn.Image"), System.Drawing.Image)
        Me.SalirBtn.Location = New System.Drawing.Point(465, 256)
        Me.SalirBtn.Name = "SalirBtn"
        Me.SalirBtn.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F12)
        Me.SalirBtn.Size = New System.Drawing.Size(57, 58)
        Me.SalirBtn.TabIndex = 17
        Me.SalirBtn.Tooltip = "Salir del sistema"
        '
        'Tortilleriafrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(534, 326)
        Me.Controls.Add(Me.ExpandablePanel1)
        Me.Controls.Add(Me.SalirBtn)
        Me.Controls.Add(Me.ImprimirBrn)
        Me.Controls.Add(Me.NIngBtn)
        Me.Controls.Add(Me.ConceptosTotallbl)
        Me.Controls.Add(Me.ConceptosTituloLbl)
        Me.Controls.Add(Me.IngresoTotalLbl)
        Me.Controls.Add(Me.TotalConcepLbl)
        Me.Controls.Add(Me.DatosDtg)
        Me.Controls.Add(Me.TituloLbl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Tortilleriafrm"
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
    Friend WithEvents NIngBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ExpandablePanel1 As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents TodosBtn As System.Windows.Forms.Button
    Friend WithEvents IngDiaDtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents IngDelAnoCmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents IngMesCmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SalirBtn As DevComponents.DotNetBar.ButtonX
End Class
