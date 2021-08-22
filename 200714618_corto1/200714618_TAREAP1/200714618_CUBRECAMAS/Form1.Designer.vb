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
        Me.rimperial = New System.Windows.Forms.RadioButton()
        Me.rmatrimonial = New System.Windows.Forms.RadioButton()
        Me.rqueen = New System.Windows.Forms.RadioButton()
        Me.rking = New System.Windows.Forms.RadioButton()
        Me.tamañocama = New System.Windows.Forms.GroupBox()
        Me.materiales = New System.Windows.Forms.GroupBox()
        Me.chlino = New System.Windows.Forms.CheckBox()
        Me.chalgodon = New System.Windows.Forms.CheckBox()
        Me.chseda = New System.Windows.Forms.CheckBox()
        Me.chhilo = New System.Windows.Forms.CheckBox()
        Me.tlino = New System.Windows.Forms.TextBox()
        Me.talgodon = New System.Windows.Forms.TextBox()
        Me.tseda = New System.Windows.Forms.TextBox()
        Me.thilo = New System.Windows.Forms.TextBox()
        Me.tamañocama.SuspendLayout()
        Me.materiales.SuspendLayout()
        Me.SuspendLayout()
        '
        'rimperial
        '
        Me.rimperial.AutoSize = True
        Me.rimperial.Location = New System.Drawing.Point(21, 30)
        Me.rimperial.Name = "rimperial"
        Me.rimperial.Size = New System.Drawing.Size(60, 17)
        Me.rimperial.TabIndex = 0
        Me.rimperial.TabStop = True
        Me.rimperial.Text = "imperial"
        Me.rimperial.UseVisualStyleBackColor = True
        '
        'rmatrimonial
        '
        Me.rmatrimonial.AutoSize = True
        Me.rmatrimonial.Location = New System.Drawing.Point(21, 53)
        Me.rmatrimonial.Name = "rmatrimonial"
        Me.rmatrimonial.Size = New System.Drawing.Size(77, 17)
        Me.rmatrimonial.TabIndex = 1
        Me.rmatrimonial.TabStop = True
        Me.rmatrimonial.Text = "matrimonial"
        Me.rmatrimonial.UseVisualStyleBackColor = True
        '
        'rqueen
        '
        Me.rqueen.AutoSize = True
        Me.rqueen.Location = New System.Drawing.Point(21, 76)
        Me.rqueen.Name = "rqueen"
        Me.rqueen.Size = New System.Drawing.Size(55, 17)
        Me.rqueen.TabIndex = 2
        Me.rqueen.TabStop = True
        Me.rqueen.Text = "queen"
        Me.rqueen.UseVisualStyleBackColor = True
        '
        'rking
        '
        Me.rking.AutoSize = True
        Me.rking.Location = New System.Drawing.Point(21, 99)
        Me.rking.Name = "rking"
        Me.rking.Size = New System.Drawing.Size(45, 17)
        Me.rking.TabIndex = 3
        Me.rking.TabStop = True
        Me.rking.Text = "king"
        Me.rking.UseVisualStyleBackColor = True
        '
        'tamañocama
        '
        Me.tamañocama.Controls.Add(Me.rqueen)
        Me.tamañocama.Controls.Add(Me.rking)
        Me.tamañocama.Controls.Add(Me.rimperial)
        Me.tamañocama.Controls.Add(Me.rmatrimonial)
        Me.tamañocama.Location = New System.Drawing.Point(52, 82)
        Me.tamañocama.Name = "tamañocama"
        Me.tamañocama.Size = New System.Drawing.Size(125, 141)
        Me.tamañocama.TabIndex = 4
        Me.tamañocama.TabStop = False
        Me.tamañocama.Text = "tamaño cama"
        '
        'materiales
        '
        Me.materiales.Controls.Add(Me.thilo)
        Me.materiales.Controls.Add(Me.tseda)
        Me.materiales.Controls.Add(Me.talgodon)
        Me.materiales.Controls.Add(Me.tlino)
        Me.materiales.Controls.Add(Me.chhilo)
        Me.materiales.Controls.Add(Me.chseda)
        Me.materiales.Controls.Add(Me.chalgodon)
        Me.materiales.Controls.Add(Me.chlino)
        Me.materiales.Location = New System.Drawing.Point(211, 89)
        Me.materiales.Name = "materiales"
        Me.materiales.Size = New System.Drawing.Size(387, 142)
        Me.materiales.TabIndex = 5
        Me.materiales.TabStop = False
        Me.materiales.Text = "materiales"
        '
        'chlino
        '
        Me.chlino.AutoSize = True
        Me.chlino.Location = New System.Drawing.Point(6, 35)
        Me.chlino.Name = "chlino"
        Me.chlino.Size = New System.Drawing.Size(42, 17)
        Me.chlino.TabIndex = 0
        Me.chlino.Text = "lino"
        Me.chlino.UseVisualStyleBackColor = True
        '
        'chalgodon
        '
        Me.chalgodon.AutoSize = True
        Me.chalgodon.Location = New System.Drawing.Point(6, 58)
        Me.chalgodon.Name = "chalgodon"
        Me.chalgodon.Size = New System.Drawing.Size(64, 17)
        Me.chalgodon.TabIndex = 1
        Me.chalgodon.Text = "algodon"
        Me.chalgodon.UseVisualStyleBackColor = True
        '
        'chseda
        '
        Me.chseda.AutoSize = True
        Me.chseda.Location = New System.Drawing.Point(6, 81)
        Me.chseda.Name = "chseda"
        Me.chseda.Size = New System.Drawing.Size(49, 17)
        Me.chseda.TabIndex = 2
        Me.chseda.Text = "seda"
        Me.chseda.UseVisualStyleBackColor = True
        '
        'chhilo
        '
        Me.chhilo.AutoSize = True
        Me.chhilo.Location = New System.Drawing.Point(6, 104)
        Me.chhilo.Name = "chhilo"
        Me.chhilo.Size = New System.Drawing.Size(72, 17)
        Me.chhilo.TabIndex = 3
        Me.chhilo.Text = "hilo crudo"
        Me.chhilo.UseVisualStyleBackColor = True
        '
        'tlino
        '
        Me.tlino.Location = New System.Drawing.Point(111, 32)
        Me.tlino.Name = "tlino"
        Me.tlino.Size = New System.Drawing.Size(116, 20)
        Me.tlino.TabIndex = 4
        '
        'talgodon
        '
        Me.talgodon.Location = New System.Drawing.Point(111, 55)
        Me.talgodon.Name = "talgodon"
        Me.talgodon.Size = New System.Drawing.Size(116, 20)
        Me.talgodon.TabIndex = 5
        '
        'tseda
        '
        Me.tseda.Location = New System.Drawing.Point(111, 79)
        Me.tseda.Name = "tseda"
        Me.tseda.Size = New System.Drawing.Size(116, 20)
        Me.tseda.TabIndex = 6
        '
        'thilo
        '
        Me.thilo.Location = New System.Drawing.Point(111, 101)
        Me.thilo.Name = "thilo"
        Me.thilo.Size = New System.Drawing.Size(116, 20)
        Me.thilo.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.materiales)
        Me.Controls.Add(Me.tamañocama)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.tamañocama.ResumeLayout(False)
        Me.tamañocama.PerformLayout()
        Me.materiales.ResumeLayout(False)
        Me.materiales.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rimperial As RadioButton
    Friend WithEvents rmatrimonial As RadioButton
    Friend WithEvents rqueen As RadioButton
    Friend WithEvents rking As RadioButton
    Friend WithEvents tamañocama As GroupBox
    Friend WithEvents materiales As GroupBox
    Friend WithEvents thilo As TextBox
    Friend WithEvents tseda As TextBox
    Friend WithEvents talgodon As TextBox
    Friend WithEvents tlino As TextBox
    Friend WithEvents chhilo As CheckBox
    Friend WithEvents chseda As CheckBox
    Friend WithEvents chalgodon As CheckBox
    Friend WithEvents chlino As CheckBox
End Class
