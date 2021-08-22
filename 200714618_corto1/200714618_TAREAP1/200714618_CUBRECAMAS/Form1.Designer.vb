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
        Me.p4 = New System.Windows.Forms.TextBox()
        Me.p3 = New System.Windows.Forms.TextBox()
        Me.p2 = New System.Windows.Forms.TextBox()
        Me.p1 = New System.Windows.Forms.TextBox()
        Me.thilo = New System.Windows.Forms.TextBox()
        Me.tseda = New System.Windows.Forms.TextBox()
        Me.talgodon = New System.Windows.Forms.TextBox()
        Me.tlino = New System.Windows.Forms.TextBox()
        Me.chhilo = New System.Windows.Forms.CheckBox()
        Me.chseda = New System.Windows.Forms.CheckBox()
        Me.chalgodon = New System.Windows.Forms.CheckBox()
        Me.chlino = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalcularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tcosto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tventa = New System.Windows.Forms.TextBox()
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tamañocama.SuspendLayout()
        Me.materiales.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rimperial
        '
        Me.rimperial.AutoSize = True
        Me.rimperial.Location = New System.Drawing.Point(21, 30)
        Me.rimperial.Name = "rimperial"
        Me.rimperial.Size = New System.Drawing.Size(82, 20)
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
        Me.rmatrimonial.Size = New System.Drawing.Size(106, 20)
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
        Me.rqueen.Size = New System.Drawing.Size(69, 20)
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
        Me.rking.Size = New System.Drawing.Size(55, 20)
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
        Me.tamañocama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tamañocama.Location = New System.Drawing.Point(52, 82)
        Me.tamañocama.Name = "tamañocama"
        Me.tamañocama.Size = New System.Drawing.Size(125, 141)
        Me.tamañocama.TabIndex = 4
        Me.tamañocama.TabStop = False
        Me.tamañocama.Text = "Tamaño Cama"
        '
        'materiales
        '
        Me.materiales.Controls.Add(Me.Label3)
        Me.materiales.Controls.Add(Me.p4)
        Me.materiales.Controls.Add(Me.p3)
        Me.materiales.Controls.Add(Me.p2)
        Me.materiales.Controls.Add(Me.p1)
        Me.materiales.Controls.Add(Me.thilo)
        Me.materiales.Controls.Add(Me.tseda)
        Me.materiales.Controls.Add(Me.talgodon)
        Me.materiales.Controls.Add(Me.tlino)
        Me.materiales.Controls.Add(Me.chhilo)
        Me.materiales.Controls.Add(Me.chseda)
        Me.materiales.Controls.Add(Me.chalgodon)
        Me.materiales.Controls.Add(Me.chlino)
        Me.materiales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.materiales.Location = New System.Drawing.Point(212, 90)
        Me.materiales.Name = "materiales"
        Me.materiales.Size = New System.Drawing.Size(417, 142)
        Me.materiales.TabIndex = 5
        Me.materiales.TabStop = False
        Me.materiales.Text = "Materiales"
        '
        'p4
        '
        Me.p4.Enabled = False
        Me.p4.Location = New System.Drawing.Point(281, 102)
        Me.p4.Name = "p4"
        Me.p4.Size = New System.Drawing.Size(100, 22)
        Me.p4.TabIndex = 11
        '
        'p3
        '
        Me.p3.Enabled = False
        Me.p3.Location = New System.Drawing.Point(281, 79)
        Me.p3.Name = "p3"
        Me.p3.Size = New System.Drawing.Size(100, 22)
        Me.p3.TabIndex = 10
        '
        'p2
        '
        Me.p2.Enabled = False
        Me.p2.Location = New System.Drawing.Point(281, 56)
        Me.p2.Name = "p2"
        Me.p2.Size = New System.Drawing.Size(100, 22)
        Me.p2.TabIndex = 9
        '
        'p1
        '
        Me.p1.Enabled = False
        Me.p1.Location = New System.Drawing.Point(281, 34)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(100, 22)
        Me.p1.TabIndex = 8
        '
        'thilo
        '
        Me.thilo.Location = New System.Drawing.Point(159, 102)
        Me.thilo.Name = "thilo"
        Me.thilo.Size = New System.Drawing.Size(116, 22)
        Me.thilo.TabIndex = 7
        Me.thilo.Visible = False
        '
        'tseda
        '
        Me.tseda.Location = New System.Drawing.Point(159, 80)
        Me.tseda.Name = "tseda"
        Me.tseda.Size = New System.Drawing.Size(116, 22)
        Me.tseda.TabIndex = 6
        Me.tseda.Visible = False
        '
        'talgodon
        '
        Me.talgodon.Location = New System.Drawing.Point(159, 56)
        Me.talgodon.Name = "talgodon"
        Me.talgodon.Size = New System.Drawing.Size(116, 22)
        Me.talgodon.TabIndex = 5
        Me.talgodon.Visible = False
        '
        'tlino
        '
        Me.tlino.Location = New System.Drawing.Point(159, 33)
        Me.tlino.Name = "tlino"
        Me.tlino.Size = New System.Drawing.Size(116, 22)
        Me.tlino.TabIndex = 4
        Me.tlino.Visible = False
        '
        'chhilo
        '
        Me.chhilo.AutoSize = True
        Me.chhilo.Location = New System.Drawing.Point(6, 104)
        Me.chhilo.Name = "chhilo"
        Me.chhilo.Size = New System.Drawing.Size(95, 20)
        Me.chhilo.TabIndex = 3
        Me.chhilo.Text = "hilo crudo"
        Me.chhilo.UseVisualStyleBackColor = True
        '
        'chseda
        '
        Me.chseda.AutoSize = True
        Me.chseda.Location = New System.Drawing.Point(6, 81)
        Me.chseda.Name = "chseda"
        Me.chseda.Size = New System.Drawing.Size(62, 20)
        Me.chseda.TabIndex = 2
        Me.chseda.Text = "seda"
        Me.chseda.UseVisualStyleBackColor = True
        '
        'chalgodon
        '
        Me.chalgodon.AutoSize = True
        Me.chalgodon.Location = New System.Drawing.Point(6, 58)
        Me.chalgodon.Name = "chalgodon"
        Me.chalgodon.Size = New System.Drawing.Size(84, 20)
        Me.chalgodon.TabIndex = 1
        Me.chalgodon.Text = "algodon"
        Me.chalgodon.UseVisualStyleBackColor = True
        '
        'chlino
        '
        Me.chlino.AutoSize = True
        Me.chlino.Location = New System.Drawing.Point(6, 35)
        Me.chlino.Name = "chlino"
        Me.chlino.Size = New System.Drawing.Size(52, 20)
        Me.chlino.TabIndex = 0
        Me.chlino.Text = "lino"
        Me.chlino.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcularToolStripMenuItem, Me.LimpiarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.InicioToolStripMenuItem.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.InicioToolStripMenuItem.Text = "INICIO"
        '
        'CalcularToolStripMenuItem
        '
        Me.CalcularToolStripMenuItem.Name = "CalcularToolStripMenuItem"
        Me.CalcularToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CalcularToolStripMenuItem.Text = "Calcular"
        '
        'tcosto
        '
        Me.tcosto.Enabled = False
        Me.tcosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcosto.Location = New System.Drawing.Point(349, 256)
        Me.tcosto.Name = "tcosto"
        Me.tcosto.Size = New System.Drawing.Size(108, 22)
        Me.tcosto.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(209, 262)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Costo Fabricacion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(209, 288)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Precio Venta"
        '
        'tventa
        '
        Me.tventa.Enabled = False
        Me.tventa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tventa.Location = New System.Drawing.Point(349, 282)
        Me.tventa.Name = "tventa"
        Me.tventa.Size = New System.Drawing.Size(108, 22)
        Me.tventa.TabIndex = 10
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LimpiarToolStripMenuItem.Text = "Limpiar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(281, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Total"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tventa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tcosto)
        Me.Controls.Add(Me.materiales)
        Me.Controls.Add(Me.tamañocama)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Cubre Camas"
        Me.tamañocama.ResumeLayout(False)
        Me.tamañocama.PerformLayout()
        Me.materiales.ResumeLayout(False)
        Me.materiales.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalcularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tcosto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tventa As TextBox
    Friend WithEvents p4 As TextBox
    Friend WithEvents p3 As TextBox
    Friend WithEvents p2 As TextBox
    Friend WithEvents p1 As TextBox
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
End Class
