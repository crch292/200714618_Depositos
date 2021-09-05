<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class resultados
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
        Me.listiposervico = New System.Windows.Forms.ListBox()
        Me.listipotarifa = New System.Windows.Forms.ListBox()
        Me.lissaldoanterior = New System.Windows.Forms.ListBox()
        Me.lispagoinicial = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lispagototal = New System.Windows.Forms.ListBox()
        Me.lisdescuento = New System.Windows.Forms.ListBox()
        Me.lismora = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listiposervico
        '
        Me.listiposervico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listiposervico.FormattingEnabled = True
        Me.listiposervico.ItemHeight = 15
        Me.listiposervico.Location = New System.Drawing.Point(3, 29)
        Me.listiposervico.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.listiposervico.Name = "listiposervico"
        Me.listiposervico.Size = New System.Drawing.Size(101, 139)
        Me.listiposervico.TabIndex = 0
        '
        'listipotarifa
        '
        Me.listipotarifa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listipotarifa.FormattingEnabled = True
        Me.listipotarifa.ItemHeight = 15
        Me.listipotarifa.Location = New System.Drawing.Point(113, 29)
        Me.listipotarifa.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.listipotarifa.Name = "listipotarifa"
        Me.listipotarifa.Size = New System.Drawing.Size(100, 139)
        Me.listipotarifa.TabIndex = 1
        '
        'lissaldoanterior
        '
        Me.lissaldoanterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lissaldoanterior.FormattingEnabled = True
        Me.lissaldoanterior.ItemHeight = 15
        Me.lissaldoanterior.Location = New System.Drawing.Point(223, 29)
        Me.lissaldoanterior.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lissaldoanterior.Name = "lissaldoanterior"
        Me.lissaldoanterior.Size = New System.Drawing.Size(120, 139)
        Me.lissaldoanterior.TabIndex = 2
        '
        'lispagoinicial
        '
        Me.lispagoinicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lispagoinicial.FormattingEnabled = True
        Me.lispagoinicial.ItemHeight = 15
        Me.lispagoinicial.Location = New System.Drawing.Point(352, 29)
        Me.lispagoinicial.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lispagoinicial.Name = "lispagoinicial"
        Me.lispagoinicial.Size = New System.Drawing.Size(107, 139)
        Me.lispagoinicial.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tipo servicio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(113, 10)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tipo tarifa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(219, 10)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Saldo anterior"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(348, 10)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "pago inicial"
        '
        'lispagototal
        '
        Me.lispagototal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lispagototal.FormattingEnabled = True
        Me.lispagototal.ItemHeight = 15
        Me.lispagototal.Location = New System.Drawing.Point(701, 29)
        Me.lispagototal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lispagototal.Name = "lispagototal"
        Me.lispagototal.Size = New System.Drawing.Size(101, 139)
        Me.lispagototal.TabIndex = 8
        '
        'lisdescuento
        '
        Me.lisdescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lisdescuento.FormattingEnabled = True
        Me.lisdescuento.ItemHeight = 15
        Me.lisdescuento.Location = New System.Drawing.Point(585, 29)
        Me.lisdescuento.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lisdescuento.Name = "lisdescuento"
        Me.lisdescuento.Size = New System.Drawing.Size(107, 139)
        Me.lisdescuento.TabIndex = 9
        '
        'lismora
        '
        Me.lismora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lismora.FormattingEnabled = True
        Me.lismora.ItemHeight = 15
        Me.lismora.Location = New System.Drawing.Point(468, 29)
        Me.lismora.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lismora.Name = "lismora"
        Me.lismora.Size = New System.Drawing.Size(108, 139)
        Me.lismora.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(468, 10)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Mora"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(581, 10)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Descuento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(697, 10)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Pago Total"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(113, 222)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 39)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'resultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 519)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lismora)
        Me.Controls.Add(Me.lisdescuento)
        Me.Controls.Add(Me.lispagototal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lispagoinicial)
        Me.Controls.Add(Me.lissaldoanterior)
        Me.Controls.Add(Me.listipotarifa)
        Me.Controls.Add(Me.listiposervico)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "resultados"
        Me.Text = "resultados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents listiposervico As ListBox
    Friend WithEvents listipotarifa As ListBox
    Friend WithEvents lissaldoanterior As ListBox
    Friend WithEvents lispagoinicial As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lispagototal As ListBox
    Friend WithEvents lisdescuento As ListBox
    Friend WithEvents lismora As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
End Class
