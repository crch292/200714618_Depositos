<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rgrande = New System.Windows.Forms.RadioButton()
        Me.rmediano = New System.Windows.Forms.RadioButton()
        Me.rpequeño = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.texoticas = New System.Windows.Forms.TextBox()
        Me.tazucenas = New System.Windows.Forms.TextBox()
        Me.tgerberas = New System.Windows.Forms.TextBox()
        Me.trosas = New System.Windows.Forms.TextBox()
        Me.chexotica = New System.Windows.Forms.CheckBox()
        Me.chazucenas = New System.Windows.Forms.CheckBox()
        Me.chgerberas = New System.Windows.Forms.CheckBox()
        Me.chrosas = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.subtotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tdescuento = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rgrande)
        Me.GroupBox1.Controls.Add(Me.rmediano)
        Me.GroupBox1.Controls.Add(Me.rpequeño)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(157, 143)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tamaño Arreglo"
        '
        'rgrande
        '
        Me.rgrande.AutoSize = True
        Me.rgrande.Location = New System.Drawing.Point(40, 83)
        Me.rgrande.Name = "rgrande"
        Me.rgrande.Size = New System.Drawing.Size(60, 17)
        Me.rgrande.TabIndex = 2
        Me.rgrande.TabStop = True
        Me.rgrande.Text = "Grande"
        Me.rgrande.UseVisualStyleBackColor = True
        '
        'rmediano
        '
        Me.rmediano.AutoSize = True
        Me.rmediano.Location = New System.Drawing.Point(40, 60)
        Me.rmediano.Name = "rmediano"
        Me.rmediano.Size = New System.Drawing.Size(66, 17)
        Me.rmediano.TabIndex = 1
        Me.rmediano.TabStop = True
        Me.rmediano.Text = "Mediano"
        Me.rmediano.UseVisualStyleBackColor = True
        '
        'rpequeño
        '
        Me.rpequeño.AutoSize = True
        Me.rpequeño.Location = New System.Drawing.Point(40, 37)
        Me.rpequeño.Name = "rpequeño"
        Me.rpequeño.Size = New System.Drawing.Size(68, 17)
        Me.rpequeño.TabIndex = 0
        Me.rpequeño.TabStop = True
        Me.rpequeño.Text = "Pequeño"
        Me.rpequeño.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.texoticas)
        Me.GroupBox2.Controls.Add(Me.tazucenas)
        Me.GroupBox2.Controls.Add(Me.tgerberas)
        Me.GroupBox2.Controls.Add(Me.trosas)
        Me.GroupBox2.Controls.Add(Me.chexotica)
        Me.GroupBox2.Controls.Add(Me.chazucenas)
        Me.GroupBox2.Controls.Add(Me.chgerberas)
        Me.GroupBox2.Controls.Add(Me.chrosas)
        Me.GroupBox2.Location = New System.Drawing.Point(231, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(227, 138)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "flores"
        '
        'texoticas
        '
        Me.texoticas.Location = New System.Drawing.Point(123, 90)
        Me.texoticas.Name = "texoticas"
        Me.texoticas.Size = New System.Drawing.Size(87, 20)
        Me.texoticas.TabIndex = 7
        Me.texoticas.Visible = False
        '
        'tazucenas
        '
        Me.tazucenas.Location = New System.Drawing.Point(123, 67)
        Me.tazucenas.Name = "tazucenas"
        Me.tazucenas.Size = New System.Drawing.Size(87, 20)
        Me.tazucenas.TabIndex = 6
        Me.tazucenas.Visible = False
        '
        'tgerberas
        '
        Me.tgerberas.Location = New System.Drawing.Point(123, 46)
        Me.tgerberas.Name = "tgerberas"
        Me.tgerberas.Size = New System.Drawing.Size(87, 20)
        Me.tgerberas.TabIndex = 5
        Me.tgerberas.Visible = False
        '
        'trosas
        '
        Me.trosas.Location = New System.Drawing.Point(123, 23)
        Me.trosas.Name = "trosas"
        Me.trosas.Size = New System.Drawing.Size(87, 20)
        Me.trosas.TabIndex = 4
        Me.trosas.Visible = False
        '
        'chexotica
        '
        Me.chexotica.AutoSize = True
        Me.chexotica.Location = New System.Drawing.Point(28, 92)
        Me.chexotica.Name = "chexotica"
        Me.chexotica.Size = New System.Drawing.Size(60, 17)
        Me.chexotica.TabIndex = 3
        Me.chexotica.Text = "exotica"
        Me.chexotica.UseVisualStyleBackColor = True
        '
        'chazucenas
        '
        Me.chazucenas.AutoSize = True
        Me.chazucenas.Location = New System.Drawing.Point(28, 69)
        Me.chazucenas.Name = "chazucenas"
        Me.chazucenas.Size = New System.Drawing.Size(72, 17)
        Me.chazucenas.TabIndex = 2
        Me.chazucenas.Text = "azucenas"
        Me.chazucenas.UseVisualStyleBackColor = True
        '
        'chgerberas
        '
        Me.chgerberas.AutoSize = True
        Me.chgerberas.Location = New System.Drawing.Point(28, 46)
        Me.chgerberas.Name = "chgerberas"
        Me.chgerberas.Size = New System.Drawing.Size(67, 17)
        Me.chgerberas.TabIndex = 1
        Me.chgerberas.Text = "gerberas"
        Me.chgerberas.UseVisualStyleBackColor = True
        '
        'chrosas
        '
        Me.chrosas.AutoSize = True
        Me.chrosas.Location = New System.Drawing.Point(28, 23)
        Me.chrosas.Name = "chrosas"
        Me.chrosas.Size = New System.Drawing.Size(51, 17)
        Me.chrosas.TabIndex = 0
        Me.chrosas.Text = "rosas"
        Me.chrosas.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(476, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 33)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'subtotal
        '
        Me.subtotal.Enabled = False
        Me.subtotal.Location = New System.Drawing.Point(324, 246)
        Me.subtotal.Name = "subtotal"
        Me.subtotal.Size = New System.Drawing.Size(117, 20)
        Me.subtotal.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(228, 253)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "subtotal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(228, 305)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "total"
        '
        'total
        '
        Me.total.Enabled = False
        Me.total.Location = New System.Drawing.Point(324, 302)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(117, 20)
        Me.total.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(228, 279)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "descuento"
        '
        'tdescuento
        '
        Me.tdescuento.Enabled = False
        Me.tdescuento.Location = New System.Drawing.Point(324, 276)
        Me.tdescuento.Name = "tdescuento"
        Me.tdescuento.Size = New System.Drawing.Size(117, 20)
        Me.tdescuento.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tdescuento)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.subtotal)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rgrande As RadioButton
    Friend WithEvents rmediano As RadioButton
    Friend WithEvents rpequeño As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chexotica As CheckBox
    Friend WithEvents chazucenas As CheckBox
    Friend WithEvents chgerberas As CheckBox
    Friend WithEvents chrosas As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents subtotal As TextBox
    Friend WithEvents texoticas As TextBox
    Friend WithEvents tazucenas As TextBox
    Friend WithEvents tgerberas As TextBox
    Friend WithEvents trosas As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents total As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tdescuento As TextBox
End Class
