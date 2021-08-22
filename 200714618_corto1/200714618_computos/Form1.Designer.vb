<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tnombre = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rnorte = New System.Windows.Forms.RadioButton()
        Me.rsur = New System.Windows.Forms.RadioButton()
        Me.roriente = New System.Windows.Forms.RadioButton()
        Me.roccidente = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbono = New System.Windows.Forms.RadioButton()
        Me.rcomision = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tventas = New System.Windows.Forms.TextBox()
        Me.calcular = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tadicional = New System.Windows.Forms.TextBox()
        Me.tsueldo = New System.Windows.Forms.TextBox()
        Me.limpiar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "nombre"
        '
        'tnombre
        '
        Me.tnombre.Location = New System.Drawing.Point(108, 42)
        Me.tnombre.Name = "tnombre"
        Me.tnombre.Size = New System.Drawing.Size(177, 20)
        Me.tnombre.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.roccidente)
        Me.GroupBox1.Controls.Add(Me.roriente)
        Me.GroupBox1.Controls.Add(Me.rsur)
        Me.GroupBox1.Controls.Add(Me.rnorte)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(211, 118)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "region"
        '
        'rnorte
        '
        Me.rnorte.AutoSize = True
        Me.rnorte.Location = New System.Drawing.Point(60, 19)
        Me.rnorte.Name = "rnorte"
        Me.rnorte.Size = New System.Drawing.Size(49, 17)
        Me.rnorte.TabIndex = 0
        Me.rnorte.TabStop = True
        Me.rnorte.Text = "norte"
        Me.rnorte.UseVisualStyleBackColor = True
        '
        'rsur
        '
        Me.rsur.AutoSize = True
        Me.rsur.Location = New System.Drawing.Point(60, 42)
        Me.rsur.Name = "rsur"
        Me.rsur.Size = New System.Drawing.Size(39, 17)
        Me.rsur.TabIndex = 1
        Me.rsur.TabStop = True
        Me.rsur.Text = "sur"
        Me.rsur.UseVisualStyleBackColor = True
        '
        'roriente
        '
        Me.roriente.AutoSize = True
        Me.roriente.Location = New System.Drawing.Point(60, 62)
        Me.roriente.Name = "roriente"
        Me.roriente.Size = New System.Drawing.Size(57, 17)
        Me.roriente.TabIndex = 2
        Me.roriente.TabStop = True
        Me.roriente.Text = "oriente"
        Me.roriente.UseVisualStyleBackColor = True
        '
        'roccidente
        '
        Me.roccidente.AutoSize = True
        Me.roccidente.Location = New System.Drawing.Point(60, 85)
        Me.roccidente.Name = "roccidente"
        Me.roccidente.Size = New System.Drawing.Size(72, 17)
        Me.roccidente.TabIndex = 3
        Me.roccidente.TabStop = True
        Me.roccidente.Text = "occidente"
        Me.roccidente.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rcomision)
        Me.GroupBox2.Controls.Add(Me.rbono)
        Me.GroupBox2.Location = New System.Drawing.Point(294, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "comision"
        '
        'rbono
        '
        Me.rbono.AutoSize = True
        Me.rbono.Location = New System.Drawing.Point(55, 19)
        Me.rbono.Name = "rbono"
        Me.rbono.Size = New System.Drawing.Size(49, 17)
        Me.rbono.TabIndex = 1
        Me.rbono.TabStop = True
        Me.rbono.Text = "bono"
        Me.rbono.UseVisualStyleBackColor = True
        '
        'rcomision
        '
        Me.rcomision.AutoSize = True
        Me.rcomision.Location = New System.Drawing.Point(55, 42)
        Me.rcomision.Name = "rcomision"
        Me.rcomision.Size = New System.Drawing.Size(66, 17)
        Me.rcomision.TabIndex = 2
        Me.rcomision.TabStop = True
        Me.rcomision.Text = "comision"
        Me.rcomision.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "monto de ventas"
        '
        'tventas
        '
        Me.tventas.Location = New System.Drawing.Point(131, 77)
        Me.tventas.Name = "tventas"
        Me.tventas.Size = New System.Drawing.Size(142, 20)
        Me.tventas.TabIndex = 5
        '
        'calcular
        '
        Me.calcular.Location = New System.Drawing.Point(343, 46)
        Me.calcular.Name = "calcular"
        Me.calcular.Size = New System.Drawing.Size(98, 31)
        Me.calcular.TabIndex = 6
        Me.calcular.Text = "calculos"
        Me.calcular.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(175, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "total comision"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(173, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "sueldo total"
        '
        'tadicional
        '
        Me.tadicional.Enabled = False
        Me.tadicional.Location = New System.Drawing.Point(289, 245)
        Me.tadicional.Name = "tadicional"
        Me.tadicional.Size = New System.Drawing.Size(127, 20)
        Me.tadicional.TabIndex = 9
        '
        'tsueldo
        '
        Me.tsueldo.Enabled = False
        Me.tsueldo.Location = New System.Drawing.Point(289, 266)
        Me.tsueldo.Name = "tsueldo"
        Me.tsueldo.Size = New System.Drawing.Size(127, 20)
        Me.tsueldo.TabIndex = 10
        '
        'limpiar
        '
        Me.limpiar.Location = New System.Drawing.Point(447, 46)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(99, 31)
        Me.limpiar.TabIndex = 11
        Me.limpiar.Text = "limpiar"
        Me.limpiar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.limpiar)
        Me.Controls.Add(Me.tsueldo)
        Me.Controls.Add(Me.tadicional)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.calcular)
        Me.Controls.Add(Me.tventas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tnombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tnombre As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents roccidente As RadioButton
    Friend WithEvents roriente As RadioButton
    Friend WithEvents rsur As RadioButton
    Friend WithEvents rnorte As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rcomision As RadioButton
    Friend WithEvents rbono As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents tventas As TextBox
    Friend WithEvents calcular As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tadicional As TextBox
    Friend WithEvents tsueldo As TextBox
    Friend WithEvents limpiar As Button
End Class
