<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Rentautos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chefectivo = New System.Windows.Forms.CheckBox()
        Me.chtarjeta = New System.Windows.Forms.CheckBox()
        Me.formapago = New System.Windows.Forms.GroupBox()
        Me.ttarjeta = New System.Windows.Forms.TextBox()
        Me.tefectivo = New System.Windows.Forms.TextBox()
        Me.cmarca = New System.Windows.Forms.ComboBox()
        Me.ttnit = New System.Windows.Forms.TextBox()
        Me.tplaca = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AccionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcesoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarListasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tdias = New System.Windows.Forms.TextBox()
        Me.lplacas = New System.Windows.Forms.ListBox()
        Me.lmarcas = New System.Windows.Forms.ListBox()
        Me.ldias = New System.Windows.Forms.ListBox()
        Me.ldescuentos = New System.Windows.Forms.ListBox()
        Me.lrecargos = New System.Windows.Forms.ListBox()
        Me.lpagosparciales = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lpagototal = New System.Windows.Forms.ListBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.formapago.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PLACA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(280, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "MARCA"
        '
        'chefectivo
        '
        Me.chefectivo.AutoSize = True
        Me.chefectivo.Location = New System.Drawing.Point(34, 32)
        Me.chefectivo.Name = "chefectivo"
        Me.chefectivo.Size = New System.Drawing.Size(78, 17)
        Me.chefectivo.TabIndex = 3
        Me.chefectivo.Text = "EFECTIVO"
        Me.chefectivo.UseVisualStyleBackColor = True
        '
        'chtarjeta
        '
        Me.chtarjeta.AutoSize = True
        Me.chtarjeta.Location = New System.Drawing.Point(34, 55)
        Me.chtarjeta.Name = "chtarjeta"
        Me.chtarjeta.Size = New System.Drawing.Size(74, 17)
        Me.chtarjeta.TabIndex = 4
        Me.chtarjeta.Text = "TARJETA"
        Me.chtarjeta.UseVisualStyleBackColor = True
        '
        'formapago
        '
        Me.formapago.Controls.Add(Me.ttarjeta)
        Me.formapago.Controls.Add(Me.tefectivo)
        Me.formapago.Controls.Add(Me.chefectivo)
        Me.formapago.Controls.Add(Me.chtarjeta)
        Me.formapago.Location = New System.Drawing.Point(273, 68)
        Me.formapago.Name = "formapago"
        Me.formapago.Size = New System.Drawing.Size(260, 98)
        Me.formapago.TabIndex = 5
        Me.formapago.TabStop = False
        Me.formapago.Text = "FORMA PAGO"
        '
        'ttarjeta
        '
        Me.ttarjeta.Location = New System.Drawing.Point(121, 52)
        Me.ttarjeta.Name = "ttarjeta"
        Me.ttarjeta.Size = New System.Drawing.Size(100, 20)
        Me.ttarjeta.TabIndex = 6
        Me.ttarjeta.Visible = False
        '
        'tefectivo
        '
        Me.tefectivo.Location = New System.Drawing.Point(121, 30)
        Me.tefectivo.Name = "tefectivo"
        Me.tefectivo.Size = New System.Drawing.Size(100, 20)
        Me.tefectivo.TabIndex = 5
        Me.tefectivo.Visible = False
        '
        'cmarca
        '
        Me.cmarca.FormattingEnabled = True
        Me.cmarca.Items.AddRange(New Object() {"HONDA", "MERCEDES BENZ", "TOYOTA", "MAZDA"})
        Me.cmarca.Location = New System.Drawing.Point(357, 41)
        Me.cmarca.Name = "cmarca"
        Me.cmarca.Size = New System.Drawing.Size(108, 21)
        Me.cmarca.TabIndex = 6
        '
        'ttnit
        '
        Me.ttnit.Location = New System.Drawing.Point(154, 49)
        Me.ttnit.Name = "ttnit"
        Me.ttnit.Size = New System.Drawing.Size(90, 20)
        Me.ttnit.TabIndex = 7
        '
        'tplaca
        '
        Me.tplaca.Location = New System.Drawing.Point(154, 73)
        Me.tplaca.Name = "tplaca"
        Me.tplaca.Size = New System.Drawing.Size(90, 20)
        Me.tplaca.TabIndex = 8
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AccionesToolStripMenuItem
        '
        Me.AccionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProcesoToolStripMenuItem, Me.LimpiarListasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.AccionesToolStripMenuItem.Name = "AccionesToolStripMenuItem"
        Me.AccionesToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.AccionesToolStripMenuItem.Text = "INICIO"
        '
        'ProcesoToolStripMenuItem
        '
        Me.ProcesoToolStripMenuItem.Name = "ProcesoToolStripMenuItem"
        Me.ProcesoToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ProcesoToolStripMenuItem.Text = "PROCESAR"
        '
        'LimpiarListasToolStripMenuItem
        '
        Me.LimpiarListasToolStripMenuItem.Name = "LimpiarListasToolStripMenuItem"
        Me.LimpiarListasToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.LimpiarListasToolStripMenuItem.Text = "Limpiar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "DIAS ALQUILAR"
        '
        'tdias
        '
        Me.tdias.Location = New System.Drawing.Point(154, 97)
        Me.tdias.Name = "tdias"
        Me.tdias.Size = New System.Drawing.Size(90, 20)
        Me.tdias.TabIndex = 11
        '
        'lplacas
        '
        Me.lplacas.FormatString = "C2"
        Me.lplacas.FormattingEnabled = True
        Me.lplacas.Location = New System.Drawing.Point(63, 207)
        Me.lplacas.Name = "lplacas"
        Me.lplacas.Size = New System.Drawing.Size(96, 160)
        Me.lplacas.TabIndex = 12
        '
        'lmarcas
        '
        Me.lmarcas.FormatString = "C2"
        Me.lmarcas.FormattingEnabled = True
        Me.lmarcas.Location = New System.Drawing.Point(165, 207)
        Me.lmarcas.Name = "lmarcas"
        Me.lmarcas.Size = New System.Drawing.Size(96, 160)
        Me.lmarcas.TabIndex = 13
        '
        'ldias
        '
        Me.ldias.FormattingEnabled = True
        Me.ldias.Location = New System.Drawing.Point(267, 207)
        Me.ldias.Name = "ldias"
        Me.ldias.Size = New System.Drawing.Size(96, 160)
        Me.ldias.TabIndex = 14
        '
        'ldescuentos
        '
        Me.ldescuentos.FormatString = "C2"
        Me.ldescuentos.FormattingEnabled = True
        Me.ldescuentos.Location = New System.Drawing.Point(369, 207)
        Me.ldescuentos.Name = "ldescuentos"
        Me.ldescuentos.Size = New System.Drawing.Size(96, 160)
        Me.ldescuentos.TabIndex = 15
        '
        'lrecargos
        '
        Me.lrecargos.FormatString = "C2"
        Me.lrecargos.FormattingEnabled = True
        Me.lrecargos.Location = New System.Drawing.Point(471, 207)
        Me.lrecargos.Name = "lrecargos"
        Me.lrecargos.Size = New System.Drawing.Size(96, 160)
        Me.lrecargos.TabIndex = 16
        '
        'lpagosparciales
        '
        Me.lpagosparciales.FormatString = "C2"
        Me.lpagosparciales.FormattingEnabled = True
        Me.lpagosparciales.Location = New System.Drawing.Point(573, 207)
        Me.lpagosparciales.Name = "lpagosparciales"
        Me.lpagosparciales.Size = New System.Drawing.Size(96, 160)
        Me.lpagosparciales.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(64, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Placa"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(270, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "dias alquilados"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(162, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Marca"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(366, 186)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Descuento"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(468, 186)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Recargo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(570, 186)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Pago Parcial"
        '
        'lpagototal
        '
        Me.lpagototal.FormatString = "C2"
        Me.lpagototal.FormattingEnabled = True
        Me.lpagototal.Location = New System.Drawing.Point(675, 207)
        Me.lpagototal.Name = "lpagototal"
        Me.lpagototal.Size = New System.Drawing.Size(96, 160)
        Me.lpagototal.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(672, 186)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Pago Total"
        '
        'Rentautos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lpagototal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lpagosparciales)
        Me.Controls.Add(Me.lrecargos)
        Me.Controls.Add(Me.ldescuentos)
        Me.Controls.Add(Me.ldias)
        Me.Controls.Add(Me.lmarcas)
        Me.Controls.Add(Me.lplacas)
        Me.Controls.Add(Me.tdias)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tplaca)
        Me.Controls.Add(Me.ttnit)
        Me.Controls.Add(Me.cmarca)
        Me.Controls.Add(Me.formapago)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Rentautos"
        Me.Text = "Form1"
        Me.formapago.ResumeLayout(False)
        Me.formapago.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents chefectivo As CheckBox
    Friend WithEvents chtarjeta As CheckBox
    Friend WithEvents formapago As GroupBox
    Friend WithEvents ttarjeta As TextBox
    Friend WithEvents tefectivo As TextBox
    Friend WithEvents cmarca As ComboBox
    Friend WithEvents ttnit As TextBox
    Friend WithEvents tplaca As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AccionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProcesoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarListasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label4 As Label
    Friend WithEvents tdias As TextBox
    Friend WithEvents lplacas As ListBox
    Friend WithEvents lmarcas As ListBox
    Friend WithEvents ldias As ListBox
    Friend WithEvents ldescuentos As ListBox
    Friend WithEvents lrecargos As ListBox
    Friend WithEvents lpagosparciales As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lpagototal As ListBox
    Friend WithEvents Label11 As Label
End Class
