<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CalcuGram
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CalcuGram))
        Me.LabelCovertirPeso = New System.Windows.Forms.Label()
        Me.LabelKg = New System.Windows.Forms.Label()
        Me.LabelGr = New System.Windows.Forms.Label()
        Me.LabelMgr = New System.Windows.Forms.Label()
        Me.TextBoxKgr = New System.Windows.Forms.TextBox()
        Me.TextBoxGr = New System.Windows.Forms.TextBox()
        Me.TextBoxMgr = New System.Windows.Forms.TextBox()
        Me.ButtonCalcular = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelCovertirPeso
        '
        Me.LabelCovertirPeso.AutoSize = True
        Me.LabelCovertirPeso.Location = New System.Drawing.Point(12, 23)
        Me.LabelCovertirPeso.Name = "LabelCovertirPeso"
        Me.LabelCovertirPeso.Size = New System.Drawing.Size(99, 15)
        Me.LabelCovertirPeso.TabIndex = 0
        Me.LabelCovertirPeso.Text = "CONVERTIR PESO"
        '
        'LabelKg
        '
        Me.LabelKg.AutoSize = True
        Me.LabelKg.Location = New System.Drawing.Point(12, 68)
        Me.LabelKg.Name = "LabelKg"
        Me.LabelKg.Size = New System.Drawing.Size(87, 15)
        Me.LabelKg.TabIndex = 1
        Me.LabelKg.Text = "PESO EN KILOS"
        '
        'LabelGr
        '
        Me.LabelGr.AutoSize = True
        Me.LabelGr.Location = New System.Drawing.Point(12, 104)
        Me.LabelGr.Name = "LabelGr"
        Me.LabelGr.Size = New System.Drawing.Size(105, 15)
        Me.LabelGr.TabIndex = 2
        Me.LabelGr.Text = "PESO EN GRAMOS"
        '
        'LabelMgr
        '
        Me.LabelMgr.AutoSize = True
        Me.LabelMgr.Location = New System.Drawing.Point(12, 139)
        Me.LabelMgr.Name = "LabelMgr"
        Me.LabelMgr.Size = New System.Drawing.Size(128, 15)
        Me.LabelMgr.TabIndex = 3
        Me.LabelMgr.Text = "PESO EN MILIGRAMOS"
        '
        'TextBoxKgr
        '
        Me.TextBoxKgr.Location = New System.Drawing.Point(146, 60)
        Me.TextBoxKgr.Name = "TextBoxKgr"
        Me.TextBoxKgr.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxKgr.TabIndex = 4
        Me.TextBoxKgr.Text = "0"
        '
        'TextBoxGr
        '
        Me.TextBoxGr.Location = New System.Drawing.Point(146, 96)
        Me.TextBoxGr.Name = "TextBoxGr"
        Me.TextBoxGr.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxGr.TabIndex = 5
        Me.TextBoxGr.Text = "0"
        '
        'TextBoxMgr
        '
        Me.TextBoxMgr.Location = New System.Drawing.Point(146, 136)
        Me.TextBoxMgr.Name = "TextBoxMgr"
        Me.TextBoxMgr.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxMgr.TabIndex = 6
        Me.TextBoxMgr.Text = "0"
        '
        'ButtonCalcular
        '
        Me.ButtonCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCalcular.Image = CType(resources.GetObject("ButtonCalcular.Image"), System.Drawing.Image)
        Me.ButtonCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCalcular.Location = New System.Drawing.Point(24, 187)
        Me.ButtonCalcular.Name = "ButtonCalcular"
        Me.ButtonCalcular.Size = New System.Drawing.Size(116, 23)
        Me.ButtonCalcular.TabIndex = 7
        Me.ButtonCalcular.Text = "CALCULAR"
        Me.ButtonCalcular.UseVisualStyleBackColor = True
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Image = CType(resources.GetObject("ButtonSalir.Image"), System.Drawing.Image)
        Me.ButtonSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSalir.Location = New System.Drawing.Point(161, 187)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(85, 23)
        Me.ButtonSalir.TabIndex = 8
        Me.ButtonSalir.Text = "SALIR"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(263, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(229, 187)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'CalcuGram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 329)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.ButtonCalcular)
        Me.Controls.Add(Me.TextBoxMgr)
        Me.Controls.Add(Me.TextBoxGr)
        Me.Controls.Add(Me.TextBoxKgr)
        Me.Controls.Add(Me.LabelMgr)
        Me.Controls.Add(Me.LabelGr)
        Me.Controls.Add(Me.LabelKg)
        Me.Controls.Add(Me.LabelCovertirPeso)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CalcuGram"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora Gramos Miligramos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelCovertirPeso As Label
    Friend WithEvents LabelKg As Label
    Friend WithEvents LabelGr As Label
    Friend WithEvents LabelMgr As Label
    Friend WithEvents TextBoxKgr As TextBox
    Friend WithEvents TextBoxGr As TextBox
    Friend WithEvents TextBoxMgr As TextBox
    Friend WithEvents ButtonCalcular As Button
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
