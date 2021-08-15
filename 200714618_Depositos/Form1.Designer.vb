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
        Me.depositos = New System.Windows.Forms.GroupBox()
        Me.efectivo = New System.Windows.Forms.CheckBox()
        Me.chequeotros = New System.Windows.Forms.CheckBox()
        Me.chequepropio = New System.Windows.Forms.CheckBox()
        Me.tcpropio = New System.Windows.Forms.TextBox()
        Me.tcotros = New System.Windows.Forms.TextBox()
        Me.tefectivo = New System.Windows.Forms.TextBox()
        Me.tipocuenta = New System.Windows.Forms.GroupBox()
        Me.rahorros = New System.Windows.Forms.RadioButton()
        Me.rmpremier = New System.Windows.Forms.RadioButton()
        Me.rMonetaria = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.saldoanterior = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.depositar = New System.Windows.Forms.Button()
        Me.totaldeposito = New System.Windows.Forms.TextBox()
        Me.interes = New System.Windows.Forms.TextBox()
        Me.nuevosaldo = New System.Windows.Forms.TextBox()
        Me.ingresar = New System.Windows.Forms.Button()
        Me.salidas = New System.Windows.Forms.GroupBox()
        Me.gruposaldo = New System.Windows.Forms.GroupBox()
        Me.limpiarbutton = New System.Windows.Forms.Button()
        Me.salir = New System.Windows.Forms.Button()
        Me.depositos.SuspendLayout()
        Me.tipocuenta.SuspendLayout()
        Me.salidas.SuspendLayout()
        Me.gruposaldo.SuspendLayout()
        Me.SuspendLayout()
        '
        'depositos
        '
        Me.depositos.Controls.Add(Me.efectivo)
        Me.depositos.Controls.Add(Me.chequeotros)
        Me.depositos.Controls.Add(Me.chequepropio)
        Me.depositos.Location = New System.Drawing.Point(376, 89)
        Me.depositos.Name = "depositos"
        Me.depositos.Size = New System.Drawing.Size(199, 128)
        Me.depositos.TabIndex = 0
        Me.depositos.TabStop = False
        Me.depositos.Text = "forma de deposito"
        Me.depositos.Visible = False
        '
        'efectivo
        '
        Me.efectivo.AutoSize = True
        Me.efectivo.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.efectivo.Location = New System.Drawing.Point(68, 105)
        Me.efectivo.Name = "efectivo"
        Me.efectivo.Size = New System.Drawing.Size(72, 23)
        Me.efectivo.TabIndex = 2
        Me.efectivo.Text = "Efectivo"
        Me.efectivo.UseVisualStyleBackColor = True
        '
        'chequeotros
        '
        Me.chequeotros.AutoSize = True
        Me.chequeotros.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chequeotros.Location = New System.Drawing.Point(68, 61)
        Me.chequeotros.Name = "chequeotros"
        Me.chequeotros.Size = New System.Drawing.Size(143, 23)
        Me.chequeotros.TabIndex = 1
        Me.chequeotros.Text = "cheques otros bancos"
        Me.chequeotros.UseVisualStyleBackColor = True
        '
        'chequepropio
        '
        Me.chequepropio.AutoSize = True
        Me.chequepropio.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chequepropio.Location = New System.Drawing.Point(68, 19)
        Me.chequepropio.Name = "chequepropio"
        Me.chequepropio.Size = New System.Drawing.Size(115, 23)
        Me.chequepropio.TabIndex = 0
        Me.chequepropio.Text = "cheques propios"
        Me.chequepropio.UseVisualStyleBackColor = True
        '
        'tcpropio
        '
        Me.tcpropio.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcpropio.Location = New System.Drawing.Point(581, 108)
        Me.tcpropio.Name = "tcpropio"
        Me.tcpropio.Size = New System.Drawing.Size(105, 27)
        Me.tcpropio.TabIndex = 2
        Me.tcpropio.Visible = False
        '
        'tcotros
        '
        Me.tcotros.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcotros.Location = New System.Drawing.Point(581, 148)
        Me.tcotros.Name = "tcotros"
        Me.tcotros.Size = New System.Drawing.Size(105, 27)
        Me.tcotros.TabIndex = 3
        Me.tcotros.Visible = False
        '
        'tefectivo
        '
        Me.tefectivo.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tefectivo.Location = New System.Drawing.Point(581, 187)
        Me.tefectivo.Name = "tefectivo"
        Me.tefectivo.Size = New System.Drawing.Size(105, 27)
        Me.tefectivo.TabIndex = 4
        Me.tefectivo.Visible = False
        '
        'tipocuenta
        '
        Me.tipocuenta.Controls.Add(Me.rahorros)
        Me.tipocuenta.Controls.Add(Me.rmpremier)
        Me.tipocuenta.Controls.Add(Me.rMonetaria)
        Me.tipocuenta.Location = New System.Drawing.Point(33, 89)
        Me.tipocuenta.Name = "tipocuenta"
        Me.tipocuenta.Size = New System.Drawing.Size(337, 125)
        Me.tipocuenta.TabIndex = 5
        Me.tipocuenta.TabStop = False
        Me.tipocuenta.Text = "Tipo cuenta"
        Me.tipocuenta.Visible = False
        '
        'rahorros
        '
        Me.rahorros.AutoSize = True
        Me.rahorros.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rahorros.Location = New System.Drawing.Point(55, 65)
        Me.rahorros.Name = "rahorros"
        Me.rahorros.Size = New System.Drawing.Size(72, 23)
        Me.rahorros.TabIndex = 2
        Me.rahorros.TabStop = True
        Me.rahorros.Text = "Ahorros"
        Me.rahorros.UseVisualStyleBackColor = True
        '
        'rmpremier
        '
        Me.rmpremier.AutoSize = True
        Me.rmpremier.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rmpremier.Location = New System.Drawing.Point(55, 42)
        Me.rmpremier.Name = "rmpremier"
        Me.rmpremier.Size = New System.Drawing.Size(132, 23)
        Me.rmpremier.TabIndex = 1
        Me.rmpremier.TabStop = True
        Me.rmpremier.Text = "Monetaria Premier"
        Me.rmpremier.UseVisualStyleBackColor = True
        '
        'rMonetaria
        '
        Me.rMonetaria.AutoSize = True
        Me.rMonetaria.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rMonetaria.Location = New System.Drawing.Point(55, 19)
        Me.rMonetaria.Name = "rMonetaria"
        Me.rMonetaria.Size = New System.Drawing.Size(82, 23)
        Me.rMonetaria.TabIndex = 0
        Me.rMonetaria.TabStop = True
        Me.rMonetaria.Text = "Monetaria"
        Me.rMonetaria.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 19)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Ingrese saldo anterior"
        '
        'saldoanterior
        '
        Me.saldoanterior.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saldoanterior.Location = New System.Drawing.Point(208, 31)
        Me.saldoanterior.Name = "saldoanterior"
        Me.saldoanterior.Size = New System.Drawing.Size(100, 27)
        Me.saldoanterior.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 19)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "total deposito"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 19)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "interes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "nuevo saldo"
        '
        'depositar
        '
        Me.depositar.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.depositar.Location = New System.Drawing.Point(103, 223)
        Me.depositar.Name = "depositar"
        Me.depositar.Size = New System.Drawing.Size(93, 30)
        Me.depositar.TabIndex = 11
        Me.depositar.Text = "depositar"
        Me.depositar.UseVisualStyleBackColor = True
        Me.depositar.Visible = False
        '
        'totaldeposito
        '
        Me.totaldeposito.Enabled = False
        Me.totaldeposito.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totaldeposito.Location = New System.Drawing.Point(169, 36)
        Me.totaldeposito.Name = "totaldeposito"
        Me.totaldeposito.Size = New System.Drawing.Size(100, 27)
        Me.totaldeposito.TabIndex = 12
        '
        'interes
        '
        Me.interes.Enabled = False
        Me.interes.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.interes.Location = New System.Drawing.Point(169, 10)
        Me.interes.Name = "interes"
        Me.interes.Size = New System.Drawing.Size(100, 27)
        Me.interes.TabIndex = 13
        '
        'nuevosaldo
        '
        Me.nuevosaldo.Enabled = False
        Me.nuevosaldo.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nuevosaldo.Location = New System.Drawing.Point(169, 61)
        Me.nuevosaldo.Name = "nuevosaldo"
        Me.nuevosaldo.Size = New System.Drawing.Size(100, 27)
        Me.nuevosaldo.TabIndex = 14
        '
        'ingresar
        '
        Me.ingresar.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ingresar.Location = New System.Drawing.Point(324, 26)
        Me.ingresar.Name = "ingresar"
        Me.ingresar.Size = New System.Drawing.Size(133, 25)
        Me.ingresar.TabIndex = 15
        Me.ingresar.Text = "ingresar"
        Me.ingresar.UseVisualStyleBackColor = True
        '
        'salidas
        '
        Me.salidas.Controls.Add(Me.Label2)
        Me.salidas.Controls.Add(Me.Label3)
        Me.salidas.Controls.Add(Me.nuevosaldo)
        Me.salidas.Controls.Add(Me.Label4)
        Me.salidas.Controls.Add(Me.interes)
        Me.salidas.Controls.Add(Me.totaldeposito)
        Me.salidas.Location = New System.Drawing.Point(231, 223)
        Me.salidas.Name = "salidas"
        Me.salidas.Size = New System.Drawing.Size(344, 133)
        Me.salidas.TabIndex = 16
        Me.salidas.TabStop = False
        Me.salidas.Visible = False
        '
        'gruposaldo
        '
        Me.gruposaldo.Controls.Add(Me.saldoanterior)
        Me.gruposaldo.Controls.Add(Me.Label1)
        Me.gruposaldo.Controls.Add(Me.ingresar)
        Me.gruposaldo.Location = New System.Drawing.Point(33, 6)
        Me.gruposaldo.Name = "gruposaldo"
        Me.gruposaldo.Size = New System.Drawing.Size(528, 77)
        Me.gruposaldo.TabIndex = 17
        Me.gruposaldo.TabStop = False
        '
        'limpiarbutton
        '
        Me.limpiarbutton.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.limpiarbutton.Location = New System.Drawing.Point(599, 32)
        Me.limpiarbutton.Name = "limpiarbutton"
        Me.limpiarbutton.Size = New System.Drawing.Size(96, 26)
        Me.limpiarbutton.TabIndex = 18
        Me.limpiarbutton.Text = "limpiar"
        Me.limpiarbutton.UseVisualStyleBackColor = True
        '
        'salir
        '
        Me.salir.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salir.Location = New System.Drawing.Point(599, 63)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(96, 28)
        Me.salir.TabIndex = 19
        Me.salir.Text = "Salir"
        Me.salir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.salir)
        Me.Controls.Add(Me.limpiarbutton)
        Me.Controls.Add(Me.gruposaldo)
        Me.Controls.Add(Me.salidas)
        Me.Controls.Add(Me.depositar)
        Me.Controls.Add(Me.tipocuenta)
        Me.Controls.Add(Me.tefectivo)
        Me.Controls.Add(Me.tcotros)
        Me.Controls.Add(Me.tcpropio)
        Me.Controls.Add(Me.depositos)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.depositos.ResumeLayout(False)
        Me.depositos.PerformLayout()
        Me.tipocuenta.ResumeLayout(False)
        Me.tipocuenta.PerformLayout()
        Me.salidas.ResumeLayout(False)
        Me.salidas.PerformLayout()
        Me.gruposaldo.ResumeLayout(False)
        Me.gruposaldo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents depositos As GroupBox
    Friend WithEvents efectivo As CheckBox
    Friend WithEvents chequeotros As CheckBox
    Friend WithEvents chequepropio As CheckBox
    Friend WithEvents tcpropio As TextBox
    Friend WithEvents tcotros As TextBox
    Friend WithEvents tefectivo As TextBox
    Friend WithEvents tipocuenta As GroupBox
    Friend WithEvents rahorros As RadioButton
    Friend WithEvents rmpremier As RadioButton
    Friend WithEvents rMonetaria As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents saldoanterior As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents depositar As Button
    Friend WithEvents totaldeposito As TextBox
    Friend WithEvents interes As TextBox
    Friend WithEvents nuevosaldo As TextBox
    Friend WithEvents ingresar As Button
    Friend WithEvents salidas As GroupBox
    Friend WithEvents gruposaldo As GroupBox
    Friend WithEvents limpiarbutton As Button
    Friend WithEvents salir As Button
End Class
