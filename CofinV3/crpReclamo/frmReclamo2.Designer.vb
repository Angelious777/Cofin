<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReclamo2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReclamo2))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbxMedioComunicacion = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.txtDepartamento = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMedioEntrega = New System.Windows.Forms.TextBox()
        Me.txtNumeroReclamo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.cbxMedioComunicacion, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label17, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtMedioEntrega, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNumeroReclamo, 1, 1)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(19, 19)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(917, 181)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'cbxMedioComunicacion
        '
        Me.cbxMedioComunicacion.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbxMedioComunicacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cbxMedioComunicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMedioComunicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxMedioComunicacion.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.cbxMedioComunicacion.FormattingEnabled = True
        Me.cbxMedioComunicacion.Location = New System.Drawing.Point(369, 95)
        Me.cbxMedioComunicacion.Margin = New System.Windows.Forms.Padding(3, 8, 3, 8)
        Me.cbxMedioComunicacion.Name = "cbxMedioComunicacion"
        Me.cbxMedioComunicacion.Size = New System.Drawing.Size(282, 23)
        Me.cbxMedioComunicacion.TabIndex = 4
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.AutoSize = True
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.txtCiudad, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.txtDepartamento, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label18, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label19, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(369, 5)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(545, 44)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'txtCiudad
        '
        Me.txtCiudad.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCiudad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCiudad.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtCiudad.Location = New System.Drawing.Point(272, 18)
        Me.txtCiudad.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(247, 23)
        Me.txtCiudad.TabIndex = 2
        '
        'txtDepartamento
        '
        Me.txtDepartamento.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDepartamento.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtDepartamento.Location = New System.Drawing.Point(0, 18)
        Me.txtDepartamento.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.Size = New System.Drawing.Size(246, 23)
        Me.txtDepartamento.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(275, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 15)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Ciudad"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(3, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(83, 15)
        Me.Label19.TabIndex = 9
        Me.Label19.Text = "Departamento"
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 19)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(111, 15)
        Me.Label17.TabIndex = 48
        Me.Label17.Text = "Origen del Reclamo"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Medio de Entrega del Reclamo"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Medio de Comunicación del Reclamo"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número de Reclamo"
        '
        'txtMedioEntrega
        '
        Me.txtMedioEntrega.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMedioEntrega.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtMedioEntrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMedioEntrega.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtMedioEntrega.Location = New System.Drawing.Point(369, 142)
        Me.txtMedioEntrega.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtMedioEntrega.Name = "txtMedioEntrega"
        Me.txtMedioEntrega.Size = New System.Drawing.Size(545, 23)
        Me.txtMedioEntrega.TabIndex = 5
        '
        'txtNumeroReclamo
        '
        Me.txtNumeroReclamo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumeroReclamo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtNumeroReclamo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumeroReclamo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtNumeroReclamo.Location = New System.Drawing.Point(369, 59)
        Me.txtNumeroReclamo.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtNumeroReclamo.Name = "txtNumeroReclamo"
        Me.txtNumeroReclamo.Size = New System.Drawing.Size(545, 23)
        Me.txtNumeroReclamo.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(19, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(917, 54)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = resources.GetString("Label4.Text")
        '
        'btnFinalizar
        '
        Me.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFinalizar.FlatAppearance.BorderSize = 0
        Me.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinalizar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnFinalizar.ForeColor = System.Drawing.Color.White
        Me.btnFinalizar.Location = New System.Drawing.Point(826, 301)
        Me.btnFinalizar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(111, 42)
        Me.btnFinalizar.TabIndex = 7
        Me.btnFinalizar.Text = "FINALIZAR"
        Me.btnFinalizar.UseVisualStyleBackColor = False
        '
        'btnAnterior
        '
        Me.btnAnterior.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnAnterior.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnterior.FlatAppearance.BorderSize = 0
        Me.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnterior.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAnterior.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnAnterior.Location = New System.Drawing.Point(678, 301)
        Me.btnAnterior.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(111, 42)
        Me.btnAnterior.TabIndex = 6
        Me.btnAnterior.Text = "ANTERIOR"
        Me.btnAnterior.UseVisualStyleBackColor = False
        '
        'frmReclamo2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 361)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmReclamo2"
        Me.Padding = New System.Windows.Forms.Padding(16)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario de Reclamo"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMedioEntrega As TextBox
    Friend WithEvents txtNumeroReclamo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents txtDepartamento As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents btnFinalizar As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents cbxMedioComunicacion As ComboBox
End Class
