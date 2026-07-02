<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOperaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOperaciones))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSubTipo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCuentaDestino = New System.Windows.Forms.Label()
        Me.lblVerificacionCuenta = New System.Windows.Forms.Label()
        Me.cbxTipoOp = New System.Windows.Forms.ComboBox()
        Me.cbxSubTipo = New System.Windows.Forms.ComboBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtCuentaDestino = New System.Windows.Forms.TextBox()
        Me.btnVerificarUsuario = New System.Windows.Forms.Button()
        Me.pctbVerificado = New System.Windows.Forms.PictureBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.pctbBtnCalculadora = New System.Windows.Forms.PictureBox()
        CType(Me.pctbVerificado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctbBtnCalculadora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(301, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Generar Operación"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(265, 41)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo de Operación"
        '
        'lblSubTipo
        '
        Me.lblSubTipo.AutoSize = True
        Me.lblSubTipo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTipo.Location = New System.Drawing.Point(480, 114)
        Me.lblSubTipo.Name = "lblSubTipo"
        Me.lblSubTipo.Size = New System.Drawing.Size(317, 41)
        Me.lblSubTipo.TabIndex = 2
        Me.lblSubTipo.Text = "Tipo de Entrada/Salida"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(56, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 41)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Monto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(480, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(212, 41)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nro de Cuenta"
        '
        'lblCuentaDestino
        '
        Me.lblCuentaDestino.AutoSize = True
        Me.lblCuentaDestino.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuentaDestino.Location = New System.Drawing.Point(56, 354)
        Me.lblCuentaDestino.Name = "lblCuentaDestino"
        Me.lblCuentaDestino.Size = New System.Drawing.Size(222, 41)
        Me.lblCuentaDestino.TabIndex = 5
        Me.lblCuentaDestino.Text = "Cuenta Destino"
        '
        'lblVerificacionCuenta
        '
        Me.lblVerificacionCuenta.AutoSize = True
        Me.lblVerificacionCuenta.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVerificacionCuenta.Location = New System.Drawing.Point(526, 354)
        Me.lblVerificacionCuenta.Name = "lblVerificacionCuenta"
        Me.lblVerificacionCuenta.Size = New System.Drawing.Size(42, 41)
        Me.lblVerificacionCuenta.TabIndex = 6
        Me.lblVerificacionCuenta.Text = """"""
        '
        'cbxTipoOp
        '
        Me.cbxTipoOp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoOp.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTipoOp.FormattingEnabled = True
        Me.cbxTipoOp.Items.AddRange(New Object() {"Depósito", "Retiro", "Pago de Servicios", "Transferencia"})
        Me.cbxTipoOp.Location = New System.Drawing.Point(56, 158)
        Me.cbxTipoOp.Name = "cbxTipoOp"
        Me.cbxTipoOp.Size = New System.Drawing.Size(265, 45)
        Me.cbxTipoOp.TabIndex = 7
        '
        'cbxSubTipo
        '
        Me.cbxSubTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSubTipo.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSubTipo.FormattingEnabled = True
        Me.cbxSubTipo.Location = New System.Drawing.Point(480, 158)
        Me.cbxSubTipo.Name = "cbxSubTipo"
        Me.cbxSubTipo.Size = New System.Drawing.Size(317, 45)
        Me.cbxSubTipo.TabIndex = 8
        '
        'txtMonto
        '
        Me.txtMonto.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.Location = New System.Drawing.Point(56, 285)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(265, 43)
        Me.txtMonto.TabIndex = 9
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(480, 285)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(265, 43)
        Me.txtUsuario.TabIndex = 10
        '
        'txtCuentaDestino
        '
        Me.txtCuentaDestino.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaDestino.Location = New System.Drawing.Point(56, 412)
        Me.txtCuentaDestino.Name = "txtCuentaDestino"
        Me.txtCuentaDestino.Size = New System.Drawing.Size(265, 43)
        Me.txtCuentaDestino.TabIndex = 11
        '
        'btnVerificarUsuario
        '
        Me.btnVerificarUsuario.BackColor = System.Drawing.SystemColors.Window
        Me.btnVerificarUsuario.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerificarUsuario.Location = New System.Drawing.Point(751, 285)
        Me.btnVerificarUsuario.Name = "btnVerificarUsuario"
        Me.btnVerificarUsuario.Size = New System.Drawing.Size(46, 43)
        Me.btnVerificarUsuario.TabIndex = 12
        Me.btnVerificarUsuario.Text = "✔"
        Me.btnVerificarUsuario.UseVisualStyleBackColor = False
        '
        'pctbVerificado
        '
        Me.pctbVerificado.Location = New System.Drawing.Point(480, 355)
        Me.pctbVerificado.Name = "pctbVerificado"
        Me.pctbVerificado.Size = New System.Drawing.Size(40, 40)
        Me.pctbVerificado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctbVerificado.TabIndex = 13
        Me.pctbVerificado.TabStop = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(466, 506)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(160, 60)
        Me.btnGuardar.TabIndex = 14
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(230, 506)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(160, 60)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'pctbBtnCalculadora
        '
        Me.pctbBtnCalculadora.BackColor = System.Drawing.Color.White
        Me.pctbBtnCalculadora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pctbBtnCalculadora.Image = Global.CofinV3.My.Resources.Resources.calculadora
        Me.pctbBtnCalculadora.Location = New System.Drawing.Point(783, 24)
        Me.pctbBtnCalculadora.Name = "pctbBtnCalculadora"
        Me.pctbBtnCalculadora.Size = New System.Drawing.Size(55, 55)
        Me.pctbBtnCalculadora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctbBtnCalculadora.TabIndex = 16
        Me.pctbBtnCalculadora.TabStop = False
        '
        'frmOperaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(882, 603)
        Me.Controls.Add(Me.pctbBtnCalculadora)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.pctbVerificado)
        Me.Controls.Add(Me.btnVerificarUsuario)
        Me.Controls.Add(Me.txtCuentaDestino)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.cbxSubTipo)
        Me.Controls.Add(Me.cbxTipoOp)
        Me.Controls.Add(Me.lblVerificacionCuenta)
        Me.Controls.Add(Me.lblCuentaDestino)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblSubTipo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmOperaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventana de Operaciones"
        CType(Me.pctbVerificado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctbBtnCalculadora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSubTipo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblCuentaDestino As Label
    Friend WithEvents lblVerificacionCuenta As Label
    Friend WithEvents cbxTipoOp As ComboBox
    Friend WithEvents cbxSubTipo As ComboBox
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtCuentaDestino As TextBox
    Friend WithEvents btnVerificarUsuario As Button
    Friend WithEvents pctbVerificado As PictureBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents pctbBtnCalculadora As PictureBox
End Class
