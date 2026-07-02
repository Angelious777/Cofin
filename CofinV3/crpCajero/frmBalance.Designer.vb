<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBalance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBalance))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTituloDiferencia = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSaldoInicial = New System.Windows.Forms.TextBox()
        Me.txtSaldoFinal = New System.Windows.Forms.TextBox()
        Me.txtCuadre = New System.Windows.Forms.TextBox()
        Me.txtDiferencia = New System.Windows.Forms.TextBox()
        Me.txtDineroRecibido = New System.Windows.Forms.TextBox()
        Me.txtDineroEntregado = New System.Windows.Forms.TextBox()
        Me.txtTotalIngreso = New System.Windows.Forms.TextBox()
        Me.txtTotalEgreso = New System.Windows.Forms.TextBox()
        Me.lblDiferencia = New System.Windows.Forms.Label()
        Me.btnCuadre = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Saldo Inicial:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 41)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Saldo Final:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(226, 41)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cuadre de Caja:"
        '
        'lblTituloDiferencia
        '
        Me.lblTituloDiferencia.AutoSize = True
        Me.lblTituloDiferencia.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloDiferencia.Location = New System.Drawing.Point(41, 287)
        Me.lblTituloDiferencia.Name = "lblTituloDiferencia"
        Me.lblTituloDiferencia.Size = New System.Drawing.Size(157, 41)
        Me.lblTituloDiferencia.TabIndex = 3
        Me.lblTituloDiferencia.Text = "Diferencia:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(437, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(237, 41)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Dinero Recibido:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(437, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(259, 41)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Dinero Entregado:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(437, 226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(196, 41)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total Ingreso:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(437, 287)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(186, 41)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Total Egreso:"
        '
        'txtSaldoInicial
        '
        Me.txtSaldoInicial.Enabled = False
        Me.txtSaldoInicial.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoInicial.Location = New System.Drawing.Point(277, 73)
        Me.txtSaldoInicial.Name = "txtSaldoInicial"
        Me.txtSaldoInicial.Size = New System.Drawing.Size(140, 43)
        Me.txtSaldoInicial.TabIndex = 8
        '
        'txtSaldoFinal
        '
        Me.txtSaldoFinal.Enabled = False
        Me.txtSaldoFinal.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoFinal.Location = New System.Drawing.Point(277, 136)
        Me.txtSaldoFinal.Name = "txtSaldoFinal"
        Me.txtSaldoFinal.Size = New System.Drawing.Size(140, 43)
        Me.txtSaldoFinal.TabIndex = 9
        '
        'txtCuadre
        '
        Me.txtCuadre.Enabled = False
        Me.txtCuadre.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuadre.Location = New System.Drawing.Point(277, 226)
        Me.txtCuadre.Name = "txtCuadre"
        Me.txtCuadre.Size = New System.Drawing.Size(140, 43)
        Me.txtCuadre.TabIndex = 10
        '
        'txtDiferencia
        '
        Me.txtDiferencia.Enabled = False
        Me.txtDiferencia.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiferencia.Location = New System.Drawing.Point(277, 284)
        Me.txtDiferencia.Name = "txtDiferencia"
        Me.txtDiferencia.Size = New System.Drawing.Size(140, 43)
        Me.txtDiferencia.TabIndex = 11
        '
        'txtDineroRecibido
        '
        Me.txtDineroRecibido.Enabled = False
        Me.txtDineroRecibido.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDineroRecibido.Location = New System.Drawing.Point(704, 71)
        Me.txtDineroRecibido.Name = "txtDineroRecibido"
        Me.txtDineroRecibido.Size = New System.Drawing.Size(140, 43)
        Me.txtDineroRecibido.TabIndex = 12
        '
        'txtDineroEntregado
        '
        Me.txtDineroEntregado.Enabled = False
        Me.txtDineroEntregado.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDineroEntregado.Location = New System.Drawing.Point(704, 138)
        Me.txtDineroEntregado.Name = "txtDineroEntregado"
        Me.txtDineroEntregado.Size = New System.Drawing.Size(140, 43)
        Me.txtDineroEntregado.TabIndex = 13
        '
        'txtTotalIngreso
        '
        Me.txtTotalIngreso.Enabled = False
        Me.txtTotalIngreso.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalIngreso.Location = New System.Drawing.Point(704, 224)
        Me.txtTotalIngreso.Name = "txtTotalIngreso"
        Me.txtTotalIngreso.Size = New System.Drawing.Size(140, 43)
        Me.txtTotalIngreso.TabIndex = 14
        '
        'txtTotalEgreso
        '
        Me.txtTotalEgreso.Enabled = False
        Me.txtTotalEgreso.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalEgreso.Location = New System.Drawing.Point(704, 285)
        Me.txtTotalEgreso.Name = "txtTotalEgreso"
        Me.txtTotalEgreso.Size = New System.Drawing.Size(140, 43)
        Me.txtTotalEgreso.TabIndex = 15
        '
        'lblDiferencia
        '
        Me.lblDiferencia.AutoSize = True
        Me.lblDiferencia.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiferencia.Location = New System.Drawing.Point(77, 328)
        Me.lblDiferencia.Name = "lblDiferencia"
        Me.lblDiferencia.Size = New System.Drawing.Size(19, 31)
        Me.lblDiferencia.TabIndex = 16
        Me.lblDiferencia.Text = "."
        '
        'btnCuadre
        '
        Me.btnCuadre.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnCuadre.FlatAppearance.BorderSize = 0
        Me.btnCuadre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCuadre.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCuadre.ForeColor = System.Drawing.Color.White
        Me.btnCuadre.Location = New System.Drawing.Point(229, 420)
        Me.btnCuadre.Name = "btnCuadre"
        Me.btnCuadre.Size = New System.Drawing.Size(164, 51)
        Me.btnCuadre.TabIndex = 17
        Me.btnCuadre.Text = "Cuadre"
        Me.btnCuadre.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnVolver.FlatAppearance.BorderSize = 0
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.White
        Me.btnVolver.Location = New System.Drawing.Point(492, 420)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(164, 51)
        Me.btnVolver.TabIndex = 18
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'frmBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(882, 503)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnCuadre)
        Me.Controls.Add(Me.lblDiferencia)
        Me.Controls.Add(Me.txtTotalEgreso)
        Me.Controls.Add(Me.txtTotalIngreso)
        Me.Controls.Add(Me.txtDineroEntregado)
        Me.Controls.Add(Me.txtDineroRecibido)
        Me.Controls.Add(Me.txtDiferencia)
        Me.Controls.Add(Me.txtCuadre)
        Me.Controls.Add(Me.txtSaldoFinal)
        Me.Controls.Add(Me.txtSaldoInicial)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblTituloDiferencia)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmBalance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTituloDiferencia As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSaldoInicial As TextBox
    Friend WithEvents txtSaldoFinal As TextBox
    Friend WithEvents txtCuadre As TextBox
    Friend WithEvents txtDiferencia As TextBox
    Friend WithEvents txtDineroRecibido As TextBox
    Friend WithEvents txtDineroEntregado As TextBox
    Friend WithEvents txtTotalIngreso As TextBox
    Friend WithEvents txtTotalEgreso As TextBox
    Friend WithEvents lblDiferencia As Label
    Friend WithEvents btnCuadre As Button
    Friend WithEvents btnVolver As Button
End Class
