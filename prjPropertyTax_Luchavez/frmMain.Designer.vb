<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.picApp = New System.Windows.Forms.PictureBox()
        Me.lblAppName = New System.Windows.Forms.Label()
        Me.grpProperty = New System.Windows.Forms.GroupBox()
        Me.txtPropValue = New System.Windows.Forms.TextBox()
        Me.txtPropName = New System.Windows.Forms.TextBox()
        Me.lblPropValue = New System.Windows.Forms.Label()
        Me.lblPropName = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtPropTax = New System.Windows.Forms.TextBox()
        Me.lblPropTax = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.printMain = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        CType(Me.picApp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProperty.SuspendLayout()
        Me.SuspendLayout()
        '
        'picApp
        '
        Me.picApp.Image = Global.prjPropertyTax_Luchavez.My.Resources.Resources.peso_sign
        Me.picApp.Location = New System.Drawing.Point(14, 15)
        Me.picApp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picApp.Name = "picApp"
        Me.picApp.Size = New System.Drawing.Size(140, 148)
        Me.picApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picApp.TabIndex = 0
        Me.picApp.TabStop = False
        '
        'lblAppName
        '
        Me.lblAppName.AutoSize = True
        Me.lblAppName.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppName.Location = New System.Drawing.Point(161, 59)
        Me.lblAppName.Name = "lblAppName"
        Me.lblAppName.Size = New System.Drawing.Size(340, 34)
        Me.lblAppName.TabIndex = 2
        Me.lblAppName.Text = "Property Tax Calculator"
        '
        'grpProperty
        '
        Me.grpProperty.Controls.Add(Me.txtPropValue)
        Me.grpProperty.Controls.Add(Me.txtPropName)
        Me.grpProperty.Controls.Add(Me.lblPropValue)
        Me.grpProperty.Controls.Add(Me.lblPropName)
        Me.grpProperty.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProperty.Location = New System.Drawing.Point(14, 187)
        Me.grpProperty.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpProperty.Name = "grpProperty"
        Me.grpProperty.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpProperty.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grpProperty.Size = New System.Drawing.Size(535, 130)
        Me.grpProperty.TabIndex = 3
        Me.grpProperty.TabStop = False
        Me.grpProperty.Text = "Property"
        '
        'txtPropValue
        '
        Me.txtPropValue.Location = New System.Drawing.Point(152, 84)
        Me.txtPropValue.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPropValue.Name = "txtPropValue"
        Me.txtPropValue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPropValue.Size = New System.Drawing.Size(374, 22)
        Me.txtPropValue.TabIndex = 3
        Me.txtPropValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPropName
        '
        Me.txtPropName.Location = New System.Drawing.Point(154, 46)
        Me.txtPropName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPropName.Name = "txtPropName"
        Me.txtPropName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPropName.Size = New System.Drawing.Size(374, 22)
        Me.txtPropName.TabIndex = 2
        Me.txtPropName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPropValue
        '
        Me.lblPropValue.AutoSize = True
        Me.lblPropValue.Location = New System.Drawing.Point(26, 87)
        Me.lblPropValue.Name = "lblPropValue"
        Me.lblPropValue.Size = New System.Drawing.Size(102, 16)
        Me.lblPropValue.TabIndex = 1
        Me.lblPropValue.Text = "Assessed Value"
        '
        'lblPropName
        '
        Me.lblPropName.AutoSize = True
        Me.lblPropName.Location = New System.Drawing.Point(26, 49)
        Me.lblPropName.Name = "lblPropName"
        Me.lblPropName.Size = New System.Drawing.Size(32, 16)
        Me.lblPropName.TabIndex = 0
        Me.lblPropName.Text = "Title"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.OliveDrab
        Me.btnCalculate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCalculate.Location = New System.Drawing.Point(413, 325)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(138, 39)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'txtPropTax
        '
        Me.txtPropTax.BackColor = System.Drawing.Color.Yellow
        Me.txtPropTax.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPropTax.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txtPropTax.Location = New System.Drawing.Point(162, 406)
        Me.txtPropTax.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPropTax.Name = "txtPropTax"
        Me.txtPropTax.ReadOnly = True
        Me.txtPropTax.Size = New System.Drawing.Size(374, 25)
        Me.txtPropTax.TabIndex = 6
        Me.txtPropTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPropTax
        '
        Me.lblPropTax.AutoSize = True
        Me.lblPropTax.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPropTax.Location = New System.Drawing.Point(37, 410)
        Me.lblPropTax.Name = "lblPropTax"
        Me.lblPropTax.Size = New System.Drawing.Size(89, 16)
        Me.lblPropTax.TabIndex = 5
        Me.lblPropTax.Text = "Property Tax"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.OrangeRed
        Me.btnClear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClear.Location = New System.Drawing.Point(267, 451)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(138, 39)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Cl&ear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.IndianRed
        Me.btnExit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(411, 451)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(138, 39)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Goldenrod
        Me.btnPrint.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPrint.Location = New System.Drawing.Point(16, 451)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(138, 39)
        Me.btnPrint.TabIndex = 9
        Me.btnPrint.Text = "&Print Receipt"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'printMain
        '
        Me.printMain.DocumentName = "document"
        Me.printMain.Form = Me
        Me.printMain.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.printMain.PrinterSettings = CType(resources.GetObject("printMain.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.printMain.PrintFileName = Nothing
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 503)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtPropTax)
        Me.Controls.Add(Me.lblPropTax)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpProperty)
        Me.Controls.Add(Me.lblAppName)
        Me.Controls.Add(Me.picApp)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.Text = "PropTaxCalc"
        CType(Me.picApp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProperty.ResumeLayout(False)
        Me.grpProperty.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picApp As PictureBox
    Friend WithEvents lblAppName As Label
    Friend WithEvents grpProperty As GroupBox
    Friend WithEvents txtPropValue As TextBox
    Friend WithEvents txtPropName As TextBox
    Friend WithEvents lblPropValue As Label
    Friend WithEvents lblPropName As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtPropTax As TextBox
    Friend WithEvents lblPropTax As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents printMain As PowerPacks.Printing.PrintForm
End Class
