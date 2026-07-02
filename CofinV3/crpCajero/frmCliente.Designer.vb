<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCliente))
        Me.pctbFoto = New System.Windows.Forms.PictureBox()
        Me.pctbFirma = New System.Windows.Forms.PictureBox()
        Me.pctbHuella = New System.Windows.Forms.PictureBox()
        Me.lblNroCliente = New System.Windows.Forms.Label()
        Me.lblNombreCliente = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pctbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctbFirma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctbHuella, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctbFoto
        '
        Me.pctbFoto.BackColor = System.Drawing.Color.Transparent
        Me.pctbFoto.Location = New System.Drawing.Point(30, 83)
        Me.pctbFoto.Name = "pctbFoto"
        Me.pctbFoto.Size = New System.Drawing.Size(180, 180)
        Me.pctbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctbFoto.TabIndex = 0
        Me.pctbFoto.TabStop = False
        '
        'pctbFirma
        '
        Me.pctbFirma.BackColor = System.Drawing.Color.White
        Me.pctbFirma.Location = New System.Drawing.Point(258, 83)
        Me.pctbFirma.Name = "pctbFirma"
        Me.pctbFirma.Size = New System.Drawing.Size(200, 99)
        Me.pctbFirma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctbFirma.TabIndex = 1
        Me.pctbFirma.TabStop = False
        '
        'pctbHuella
        '
        Me.pctbHuella.BackColor = System.Drawing.Color.Transparent
        Me.pctbHuella.Location = New System.Drawing.Point(503, 83)
        Me.pctbHuella.Name = "pctbHuella"
        Me.pctbHuella.Size = New System.Drawing.Size(141, 180)
        Me.pctbHuella.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctbHuella.TabIndex = 2
        Me.pctbHuella.TabStop = False
        '
        'lblNroCliente
        '
        Me.lblNroCliente.AutoSize = True
        Me.lblNroCliente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroCliente.Location = New System.Drawing.Point(229, 198)
        Me.lblNroCliente.Name = "lblNroCliente"
        Me.lblNroCliente.Size = New System.Drawing.Size(28, 28)
        Me.lblNroCliente.TabIndex = 3
        Me.lblNroCliente.Text = """"""
        '
        'lblNombreCliente
        '
        Me.lblNombreCliente.AutoSize = True
        Me.lblNombreCliente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCliente.Location = New System.Drawing.Point(229, 229)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(28, 28)
        Me.lblNombreCliente.TabIndex = 4
        Me.lblNombreCliente.Text = """"""
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.Location = New System.Drawing.Point(269, 281)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(140, 60)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(285, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 41)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Cliente"
        '
        'frmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(682, 353)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblNombreCliente)
        Me.Controls.Add(Me.lblNroCliente)
        Me.Controls.Add(Me.pctbHuella)
        Me.Controls.Add(Me.pctbFirma)
        Me.Controls.Add(Me.pctbFoto)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos Cliente"
        CType(Me.pctbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctbFirma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctbHuella, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pctbFoto As PictureBox
    Friend WithEvents pctbFirma As PictureBox
    Friend WithEvents pctbHuella As PictureBox
    Friend WithEvents lblNroCliente As Label
    Friend WithEvents lblNombreCliente As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents Label1 As Label
End Class
