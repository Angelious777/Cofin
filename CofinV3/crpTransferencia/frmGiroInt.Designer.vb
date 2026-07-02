<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGiroInt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGiroInt))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCuentaDestino = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCuentaOrigen = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.txtPaisOrigen = New System.Windows.Forms.TextBox()
        Me.txtPaisDestino = New System.Windows.Forms.TextBox()
        Me.txtComision = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(430, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GIROS INTERNACIONALES"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(544, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 19)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "País Destino"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(544, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 19)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "País Origen"
        '
        'txtMonto
        '
        Me.txtMonto.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMonto.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtMonto.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtMonto.Location = New System.Drawing.Point(184, 211)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(291, 25)
        Me.txtMonto.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(19, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 19)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Monto"
        '
        'txtCuentaDestino
        '
        Me.txtCuentaDestino.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCuentaDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuentaDestino.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCuentaDestino.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtCuentaDestino.Location = New System.Drawing.Point(184, 172)
        Me.txtCuentaDestino.Name = "txtCuentaDestino"
        Me.txtCuentaDestino.Size = New System.Drawing.Size(291, 25)
        Me.txtCuentaDestino.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(19, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 19)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Cuenta Destino"
        '
        'txtCuentaOrigen
        '
        Me.txtCuentaOrigen.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCuentaOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuentaOrigen.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCuentaOrigen.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtCuentaOrigen.Location = New System.Drawing.Point(184, 133)
        Me.txtCuentaOrigen.Name = "txtCuentaOrigen"
        Me.txtCuentaOrigen.Size = New System.Drawing.Size(291, 25)
        Me.txtCuentaOrigen.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(19, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 19)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Cuenta Origen"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtNombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtNombre.Location = New System.Drawing.Point(184, 94)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(291, 25)
        Me.txtNombre.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(19, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 19)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nombre del Cliente"
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCerrar.Location = New System.Drawing.Point(758, 280)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(111, 42)
        Me.btnCerrar.TabIndex = 30
        Me.btnCerrar.Text = "CERRAR"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnGenerar
        '
        Me.btnGenerar.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerar.FlatAppearance.BorderSize = 0
        Me.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnGenerar.ForeColor = System.Drawing.Color.White
        Me.btnGenerar.Location = New System.Drawing.Point(909, 280)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(111, 42)
        Me.btnGenerar.TabIndex = 29
        Me.btnGenerar.Text = "GENERAR"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'txtPaisOrigen
        '
        Me.txtPaisOrigen.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPaisOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPaisOrigen.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPaisOrigen.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtPaisOrigen.Location = New System.Drawing.Point(652, 133)
        Me.txtPaisOrigen.Name = "txtPaisOrigen"
        Me.txtPaisOrigen.Size = New System.Drawing.Size(352, 25)
        Me.txtPaisOrigen.TabIndex = 31
        '
        'txtPaisDestino
        '
        Me.txtPaisDestino.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPaisDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPaisDestino.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPaisDestino.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtPaisDestino.Location = New System.Drawing.Point(652, 172)
        Me.txtPaisDestino.Name = "txtPaisDestino"
        Me.txtPaisDestino.Size = New System.Drawing.Size(352, 25)
        Me.txtPaisDestino.TabIndex = 32
        '
        'txtComision
        '
        Me.txtComision.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtComision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtComision.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtComision.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtComision.Location = New System.Drawing.Point(184, 250)
        Me.txtComision.Name = "txtComision"
        Me.txtComision.Size = New System.Drawing.Size(291, 25)
        Me.txtComision.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(19, 253)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 19)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Comisión"
        '
        'frmGiroInt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1039, 341)
        Me.Controls.Add(Me.txtComision)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPaisDestino)
        Me.Controls.Add(Me.txtPaisOrigen)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCuentaDestino)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCuentaOrigen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frmGiroInt"
        Me.Padding = New System.Windows.Forms.Padding(16)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Giro Internacional"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCuentaDestino As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCuentaOrigen As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnGenerar As Button
    Friend WithEvents txtPaisOrigen As TextBox
    Friend WithEvents txtPaisDestino As TextBox
    Friend WithEvents txtComision As TextBox
    Friend WithEvents Label8 As Label
End Class
