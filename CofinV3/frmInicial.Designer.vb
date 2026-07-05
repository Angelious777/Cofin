<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInicial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicial))
        Me.btnCajero = New System.Windows.Forms.Button()
        Me.btnPlataforma = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCajero
        '
        Me.btnCajero.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.btnCajero.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCajero.FlatAppearance.BorderSize = 0
        Me.btnCajero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCajero.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCajero.ForeColor = System.Drawing.Color.White
        Me.btnCajero.Location = New System.Drawing.Point(502, 128)
        Me.btnCajero.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCajero.Name = "btnCajero"
        Me.btnCajero.Size = New System.Drawing.Size(172, 41)
        Me.btnCajero.TabIndex = 0
        Me.btnCajero.Text = "CAJERO"
        Me.btnCajero.UseVisualStyleBackColor = False
        '
        'btnPlataforma
        '
        Me.btnPlataforma.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.btnPlataforma.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlataforma.FlatAppearance.BorderSize = 0
        Me.btnPlataforma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlataforma.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlataforma.ForeColor = System.Drawing.Color.White
        Me.btnPlataforma.Location = New System.Drawing.Point(502, 204)
        Me.btnPlataforma.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPlataforma.Name = "btnPlataforma"
        Me.btnPlataforma.Size = New System.Drawing.Size(172, 41)
        Me.btnPlataforma.TabIndex = 1
        Me.btnPlataforma.Text = "PLATAFORMA"
        Me.btnPlataforma.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.CofinV3.My.Resources.Resources.cofin_portada
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(479, 366)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'frmInicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(697, 366)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnPlataforma)
        Me.Controls.Add(Me.btnCajero)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInicial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COFIN"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCajero As Button
    Friend WithEvents btnPlataforma As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
