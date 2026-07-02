<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCajero
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCajero))
        Me.btnLimpiarOperaciones = New System.Windows.Forms.Button()
        Me.btnCuadre = New System.Windows.Forms.Button()
        Me.btnSaldoInicial = New System.Windows.Forms.Button()
        Me.btnDineroRecibido = New System.Windows.Forms.Button()
        Me.btnDineroEntregado = New System.Windows.Forms.Button()
        Me.btnBalance = New System.Windows.Forms.Button()
        Me.lstSalidas = New System.Windows.Forms.ListView()
        Me.lstEntradas = New System.Windows.Forms.ListView()
        Me.btnGenerarOp = New System.Windows.Forms.Button()
        Me.btnAtencionFin = New System.Windows.Forms.Button()
        Me.lblAtencionCont = New System.Windows.Forms.Label()
        Me.lblEntradas = New System.Windows.Forms.Label()
        Me.lblSalidas = New System.Windows.Forms.Label()
        Me.btnIncautacion = New System.Windows.Forms.Button()
        Me.pctbLogo = New System.Windows.Forms.PictureBox()
        CType(Me.pctbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLimpiarOperaciones
        '
        Me.btnLimpiarOperaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnLimpiarOperaciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiarOperaciones.FlatAppearance.BorderSize = 0
        Me.btnLimpiarOperaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiarOperaciones.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarOperaciones.ForeColor = System.Drawing.Color.White
        Me.btnLimpiarOperaciones.Location = New System.Drawing.Point(19, 35)
        Me.btnLimpiarOperaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLimpiarOperaciones.Name = "btnLimpiarOperaciones"
        Me.btnLimpiarOperaciones.Size = New System.Drawing.Size(280, 40)
        Me.btnLimpiarOperaciones.TabIndex = 0
        Me.btnLimpiarOperaciones.Text = "Limpiar Operaciones"
        Me.btnLimpiarOperaciones.UseVisualStyleBackColor = False
        '
        'btnCuadre
        '
        Me.btnCuadre.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnCuadre.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCuadre.FlatAppearance.BorderSize = 0
        Me.btnCuadre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCuadre.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCuadre.ForeColor = System.Drawing.Color.White
        Me.btnCuadre.Location = New System.Drawing.Point(1024, 150)
        Me.btnCuadre.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCuadre.Name = "btnCuadre"
        Me.btnCuadre.Size = New System.Drawing.Size(192, 40)
        Me.btnCuadre.TabIndex = 1
        Me.btnCuadre.Text = "Cuadre"
        Me.btnCuadre.UseVisualStyleBackColor = False
        '
        'btnSaldoInicial
        '
        Me.btnSaldoInicial.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnSaldoInicial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaldoInicial.FlatAppearance.BorderSize = 0
        Me.btnSaldoInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaldoInicial.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaldoInicial.ForeColor = System.Drawing.Color.White
        Me.btnSaldoInicial.Location = New System.Drawing.Point(1024, 198)
        Me.btnSaldoInicial.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSaldoInicial.Name = "btnSaldoInicial"
        Me.btnSaldoInicial.Size = New System.Drawing.Size(192, 40)
        Me.btnSaldoInicial.TabIndex = 2
        Me.btnSaldoInicial.Text = "Saldo Inicial"
        Me.btnSaldoInicial.UseVisualStyleBackColor = False
        '
        'btnDineroRecibido
        '
        Me.btnDineroRecibido.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnDineroRecibido.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDineroRecibido.FlatAppearance.BorderSize = 0
        Me.btnDineroRecibido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDineroRecibido.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDineroRecibido.ForeColor = System.Drawing.Color.White
        Me.btnDineroRecibido.Location = New System.Drawing.Point(1024, 269)
        Me.btnDineroRecibido.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDineroRecibido.Name = "btnDineroRecibido"
        Me.btnDineroRecibido.Size = New System.Drawing.Size(192, 40)
        Me.btnDineroRecibido.TabIndex = 3
        Me.btnDineroRecibido.Text = "Dinero Recibido"
        Me.btnDineroRecibido.UseVisualStyleBackColor = False
        '
        'btnDineroEntregado
        '
        Me.btnDineroEntregado.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnDineroEntregado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDineroEntregado.FlatAppearance.BorderSize = 0
        Me.btnDineroEntregado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDineroEntregado.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDineroEntregado.ForeColor = System.Drawing.Color.White
        Me.btnDineroEntregado.Location = New System.Drawing.Point(1024, 317)
        Me.btnDineroEntregado.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDineroEntregado.Name = "btnDineroEntregado"
        Me.btnDineroEntregado.Size = New System.Drawing.Size(192, 40)
        Me.btnDineroEntregado.TabIndex = 4
        Me.btnDineroEntregado.Text = "Dinero Entregado"
        Me.btnDineroEntregado.UseVisualStyleBackColor = False
        '
        'btnBalance
        '
        Me.btnBalance.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnBalance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBalance.FlatAppearance.BorderSize = 0
        Me.btnBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBalance.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBalance.ForeColor = System.Drawing.Color.White
        Me.btnBalance.Location = New System.Drawing.Point(1024, 384)
        Me.btnBalance.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBalance.Name = "btnBalance"
        Me.btnBalance.Size = New System.Drawing.Size(192, 40)
        Me.btnBalance.TabIndex = 5
        Me.btnBalance.Text = "Balance"
        Me.btnBalance.UseVisualStyleBackColor = False
        '
        'lstSalidas
        '
        Me.lstSalidas.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSalidas.HideSelection = False
        Me.lstSalidas.Location = New System.Drawing.Point(517, 120)
        Me.lstSalidas.Margin = New System.Windows.Forms.Padding(4)
        Me.lstSalidas.Name = "lstSalidas"
        Me.lstSalidas.OwnerDraw = True
        Me.lstSalidas.Size = New System.Drawing.Size(481, 337)
        Me.lstSalidas.TabIndex = 6
        Me.lstSalidas.UseCompatibleStateImageBehavior = False
        Me.lstSalidas.View = System.Windows.Forms.View.Details
        '
        'lstEntradas
        '
        Me.lstEntradas.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstEntradas.HideSelection = False
        Me.lstEntradas.Location = New System.Drawing.Point(19, 120)
        Me.lstEntradas.Margin = New System.Windows.Forms.Padding(4)
        Me.lstEntradas.Name = "lstEntradas"
        Me.lstEntradas.OwnerDraw = True
        Me.lstEntradas.Size = New System.Drawing.Size(481, 337)
        Me.lstEntradas.TabIndex = 7
        Me.lstEntradas.UseCompatibleStateImageBehavior = False
        Me.lstEntradas.View = System.Windows.Forms.View.Details
        '
        'btnGenerarOp
        '
        Me.btnGenerarOp.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnGenerarOp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerarOp.FlatAppearance.BorderSize = 0
        Me.btnGenerarOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerarOp.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarOp.ForeColor = System.Drawing.Color.White
        Me.btnGenerarOp.Location = New System.Drawing.Point(19, 482)
        Me.btnGenerarOp.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGenerarOp.Name = "btnGenerarOp"
        Me.btnGenerarOp.Size = New System.Drawing.Size(280, 40)
        Me.btnGenerarOp.TabIndex = 8
        Me.btnGenerarOp.Text = "Generar Operación"
        Me.btnGenerarOp.UseVisualStyleBackColor = False
        '
        'btnAtencionFin
        '
        Me.btnAtencionFin.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnAtencionFin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAtencionFin.FlatAppearance.BorderSize = 0
        Me.btnAtencionFin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtencionFin.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtencionFin.ForeColor = System.Drawing.Color.White
        Me.btnAtencionFin.Location = New System.Drawing.Point(530, 483)
        Me.btnAtencionFin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAtencionFin.Name = "btnAtencionFin"
        Me.btnAtencionFin.Size = New System.Drawing.Size(192, 40)
        Me.btnAtencionFin.TabIndex = 9
        Me.btnAtencionFin.Text = "Atención Finalizada"
        Me.btnAtencionFin.UseVisualStyleBackColor = False
        '
        'lblAtencionCont
        '
        Me.lblAtencionCont.AutoSize = True
        Me.lblAtencionCont.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtencionCont.Location = New System.Drawing.Point(729, 486)
        Me.lblAtencionCont.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAtencionCont.Name = "lblAtencionCont"
        Me.lblAtencionCont.Size = New System.Drawing.Size(239, 32)
        Me.lblAtencionCont.TabIndex = 10
        Me.lblAtencionCont.Text = "Clientes Atendidos: 0"
        '
        'lblEntradas
        '
        Me.lblEntradas.AutoSize = True
        Me.lblEntradas.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntradas.Location = New System.Drawing.Point(14, 86)
        Me.lblEntradas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEntradas.Name = "lblEntradas"
        Me.lblEntradas.Size = New System.Drawing.Size(174, 30)
        Me.lblEntradas.TabIndex = 11
        Me.lblEntradas.Text = "Lista de Entradas"
        '
        'lblSalidas
        '
        Me.lblSalidas.AutoSize = True
        Me.lblSalidas.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalidas.Location = New System.Drawing.Point(511, 86)
        Me.lblSalidas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSalidas.Name = "lblSalidas"
        Me.lblSalidas.Size = New System.Drawing.Size(158, 30)
        Me.lblSalidas.TabIndex = 12
        Me.lblSalidas.Text = "Lista de Salidas"
        '
        'btnIncautacion
        '
        Me.btnIncautacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnIncautacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIncautacion.FlatAppearance.BorderSize = 0
        Me.btnIncautacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIncautacion.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIncautacion.ForeColor = System.Drawing.Color.White
        Me.btnIncautacion.Location = New System.Drawing.Point(516, 35)
        Me.btnIncautacion.Margin = New System.Windows.Forms.Padding(4)
        Me.btnIncautacion.Name = "btnIncautacion"
        Me.btnIncautacion.Size = New System.Drawing.Size(280, 40)
        Me.btnIncautacion.TabIndex = 14
        Me.btnIncautacion.Text = "Incautar Billetes"
        Me.btnIncautacion.UseVisualStyleBackColor = False
        '
        'pctbLogo
        '
        Me.pctbLogo.Image = Global.CofinV3.My.Resources.Resources.cofin_image
        Me.pctbLogo.Location = New System.Drawing.Point(1010, 0)
        Me.pctbLogo.Margin = New System.Windows.Forms.Padding(2)
        Me.pctbLogo.Name = "pctbLogo"
        Me.pctbLogo.Size = New System.Drawing.Size(232, 115)
        Me.pctbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctbLogo.TabIndex = 13
        Me.pctbLogo.TabStop = False
        '
        'frmCajero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1242, 561)
        Me.Controls.Add(Me.btnIncautacion)
        Me.Controls.Add(Me.pctbLogo)
        Me.Controls.Add(Me.lblSalidas)
        Me.Controls.Add(Me.lblEntradas)
        Me.Controls.Add(Me.lblAtencionCont)
        Me.Controls.Add(Me.btnAtencionFin)
        Me.Controls.Add(Me.btnGenerarOp)
        Me.Controls.Add(Me.lstEntradas)
        Me.Controls.Add(Me.lstSalidas)
        Me.Controls.Add(Me.btnBalance)
        Me.Controls.Add(Me.btnDineroEntregado)
        Me.Controls.Add(Me.btnDineroRecibido)
        Me.Controls.Add(Me.btnSaldoInicial)
        Me.Controls.Add(Me.btnCuadre)
        Me.Controls.Add(Me.btnLimpiarOperaciones)
        Me.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmCajero"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COFIN"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pctbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLimpiarOperaciones As Button
    Friend WithEvents btnCuadre As Button
    Friend WithEvents btnSaldoInicial As Button
    Friend WithEvents btnDineroRecibido As Button
    Friend WithEvents btnDineroEntregado As Button
    Friend WithEvents btnBalance As Button
    Friend WithEvents lstSalidas As ListView
    Friend WithEvents lstEntradas As ListView
    Friend WithEvents btnGenerarOp As Button
    Friend WithEvents btnAtencionFin As Button
    Friend WithEvents lblAtencionCont As Label
    Friend WithEvents lblEntradas As Label
    Friend WithEvents lblSalidas As Label
    Friend WithEvents pctbLogo As PictureBox
    Friend WithEvents btnIncautacion As Button
End Class
