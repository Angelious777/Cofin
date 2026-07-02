<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransferenciaInt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransferenciaInt))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCuentaOrigen = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCuentaDestino = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxBancoOrigen = New System.Windows.Forms.ComboBox()
        Me.cbxBancoDestino = New System.Windows.Forms.ComboBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(387, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TRANSFERENCIA INTERBANCARIA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(65, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre del Cliente"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtNombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtNombre.Location = New System.Drawing.Point(202, 111)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(291, 25)
        Me.txtNombre.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(65, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cuenta Origen"
        '
        'txtCuentaOrigen
        '
        Me.txtCuentaOrigen.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCuentaOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuentaOrigen.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCuentaOrigen.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtCuentaOrigen.Location = New System.Drawing.Point(202, 150)
        Me.txtCuentaOrigen.Name = "txtCuentaOrigen"
        Me.txtCuentaOrigen.Size = New System.Drawing.Size(291, 25)
        Me.txtCuentaOrigen.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(65, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Cuenta Destino"
        '
        'txtCuentaDestino
        '
        Me.txtCuentaDestino.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCuentaDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuentaDestino.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCuentaDestino.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtCuentaDestino.Location = New System.Drawing.Point(202, 189)
        Me.txtCuentaDestino.Name = "txtCuentaDestino"
        Me.txtCuentaDestino.Size = New System.Drawing.Size(291, 25)
        Me.txtCuentaDestino.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(65, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 19)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Monto"
        '
        'txtMonto
        '
        Me.txtMonto.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMonto.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtMonto.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtMonto.Location = New System.Drawing.Point(202, 228)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(291, 25)
        Me.txtMonto.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(561, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 19)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Banco Origen"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(561, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 19)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Banco Destino"
        '
        'cbxBancoOrigen
        '
        Me.cbxBancoOrigen.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cbxBancoOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxBancoOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxBancoOrigen.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbxBancoOrigen.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.cbxBancoOrigen.FormattingEnabled = True
        Me.cbxBancoOrigen.Location = New System.Drawing.Point(659, 150)
        Me.cbxBancoOrigen.Name = "cbxBancoOrigen"
        Me.cbxBancoOrigen.Size = New System.Drawing.Size(352, 25)
        Me.cbxBancoOrigen.TabIndex = 13
        '
        'cbxBancoDestino
        '
        Me.cbxBancoDestino.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cbxBancoDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxBancoDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxBancoDestino.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbxBancoDestino.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.cbxBancoDestino.FormattingEnabled = True
        Me.cbxBancoDestino.Location = New System.Drawing.Point(659, 192)
        Me.cbxBancoDestino.Name = "cbxBancoDestino"
        Me.cbxBancoDestino.Size = New System.Drawing.Size(352, 25)
        Me.cbxBancoDestino.TabIndex = 14
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCerrar.Location = New System.Drawing.Point(746, 280)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(111, 42)
        Me.btnCerrar.TabIndex = 16
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
        Me.btnGenerar.TabIndex = 15
        Me.btnGenerar.Text = "GENERAR"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'frmTransferenciaInt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1039, 341)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.cbxBancoDestino)
        Me.Controls.Add(Me.cbxBancoOrigen)
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
        Me.Name = "frmTransferenciaInt"
        Me.Padding = New System.Windows.Forms.Padding(16)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transferencia Interbancaria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCuentaOrigen As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCuentaDestino As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbxBancoOrigen As ComboBox
    Friend WithEvents cbxBancoDestino As ComboBox
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnGenerar As Button
End Class
