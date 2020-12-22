<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LabelCovertirPeso = New System.Windows.Forms.Label()
        Me.LabelKg = New System.Windows.Forms.Label()
        Me.LabelGr = New System.Windows.Forms.Label()
        Me.LabelMgr = New System.Windows.Forms.Label()
        Me.TextBoxKgr = New System.Windows.Forms.TextBox()
        Me.TextBoxGr = New System.Windows.Forms.TextBox()
        Me.TextBoxMgr = New System.Windows.Forms.TextBox()
        Me.ButtonCalcular = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LabelGrMgr = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelCovertirPeso
        '
        Me.LabelCovertirPeso.AutoSize = True
        Me.LabelCovertirPeso.Location = New System.Drawing.Point(55, 121)
        Me.LabelCovertirPeso.Name = "LabelCovertirPeso"
        Me.LabelCovertirPeso.Size = New System.Drawing.Size(99, 15)
        Me.LabelCovertirPeso.TabIndex = 0
        Me.LabelCovertirPeso.Text = "CONVERTIR PESO"
        '
        'LabelKg
        '
        Me.LabelKg.AutoSize = True
        Me.LabelKg.Location = New System.Drawing.Point(55, 234)
        Me.LabelKg.Name = "LabelKg"
        Me.LabelKg.Size = New System.Drawing.Size(87, 15)
        Me.LabelKg.TabIndex = 1
        Me.LabelKg.Text = "PESO EN KILOS"
        '
        'LabelGr
        '
        Me.LabelGr.AutoSize = True
        Me.LabelGr.Location = New System.Drawing.Point(222, 234)
        Me.LabelGr.Name = "LabelGr"
        Me.LabelGr.Size = New System.Drawing.Size(105, 15)
        Me.LabelGr.TabIndex = 2
        Me.LabelGr.Text = "PESO EN GRAMOS"
        '
        'LabelMgr
        '
        Me.LabelMgr.AutoSize = True
        Me.LabelMgr.Location = New System.Drawing.Point(222, 263)
        Me.LabelMgr.Name = "LabelMgr"
        Me.LabelMgr.Size = New System.Drawing.Size(128, 15)
        Me.LabelMgr.TabIndex = 3
        Me.LabelMgr.Text = "PESO EN MILIGRAMOS"
        '
        'TextBoxKgr
        '
        Me.TextBoxKgr.Location = New System.Drawing.Point(12, 255)
        Me.TextBoxKgr.Name = "TextBoxKgr"
        Me.TextBoxKgr.Size = New System.Drawing.Size(186, 23)
        Me.TextBoxKgr.TabIndex = 4
        '
        'TextBoxGr
        '
        Me.TextBoxGr.Enabled = False
        Me.TextBoxGr.Location = New System.Drawing.Point(421, 226)
        Me.TextBoxGr.Name = "TextBoxGr"
        Me.TextBoxGr.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxGr.TabIndex = 5
        Me.TextBoxGr.Text = "0"
        '
        'TextBoxMgr
        '
        Me.TextBoxMgr.Enabled = False
        Me.TextBoxMgr.Location = New System.Drawing.Point(421, 255)
        Me.TextBoxMgr.Name = "TextBoxMgr"
        Me.TextBoxMgr.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxMgr.TabIndex = 6
        Me.TextBoxMgr.Text = "0"
        '
        'ButtonCalcular
        '
        Me.ButtonCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonCalcular.Image = CType(resources.GetObject("ButtonCalcular.Image"), System.Drawing.Image)
        Me.ButtonCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCalcular.Location = New System.Drawing.Point(55, 149)
        Me.ButtonCalcular.Name = "ButtonCalcular"
        Me.ButtonCalcular.Size = New System.Drawing.Size(99, 32)
        Me.ButtonCalcular.TabIndex = 7
        Me.ButtonCalcular.Text = "CALCULAR"
        Me.ButtonCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonCalcular.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.BackColor = System.Drawing.Color.Red
        Me.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonExit.Image = CType(resources.GetObject("ButtonExit.Image"), System.Drawing.Image)
        Me.ButtonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonExit.Location = New System.Drawing.Point(12, 296)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(509, 23)
        Me.ButtonExit.TabIndex = 8
        Me.ButtonExit.Text = "SALIR"
        Me.ButtonExit.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(204, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(317, 169)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(186, 92)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'LabelGrMgr
        '
        Me.LabelGrMgr.AutoSize = True
        Me.LabelGrMgr.Location = New System.Drawing.Point(222, 201)
        Me.LabelGrMgr.Name = "LabelGrMgr"
        Me.LabelGrMgr.Size = New System.Drawing.Size(126, 15)
        Me.LabelGrMgr.TabIndex = 11
        Me.LabelGrMgr.Text = "Pasar de Kilogramos a:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 328)
        Me.Controls.Add(Me.LabelGrMgr)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonExit)
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
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora Gramos Miligramos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ButtonExit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LabelGrMgr As Label
End Class
