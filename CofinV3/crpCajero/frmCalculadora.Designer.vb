<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculadora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalculadora))
        Me.lblSuperior = New System.Windows.Forms.Label()
        Me.txtPantalla = New System.Windows.Forms.TextBox()
        Me.btnDigito7 = New System.Windows.Forms.Button()
        Me.btnDigito8 = New System.Windows.Forms.Button()
        Me.btnDigito9 = New System.Windows.Forms.Button()
        Me.btnDigito6 = New System.Windows.Forms.Button()
        Me.btnDigito5 = New System.Windows.Forms.Button()
        Me.btnDigito4 = New System.Windows.Forms.Button()
        Me.btnDigito3 = New System.Windows.Forms.Button()
        Me.btnDigito2 = New System.Windows.Forms.Button()
        Me.btnDigito1 = New System.Windows.Forms.Button()
        Me.btnPuntoDecimal = New System.Windows.Forms.Button()
        Me.btnDigito0 = New System.Windows.Forms.Button()
        Me.btnInvertirSigno = New System.Windows.Forms.Button()
        Me.btnCE = New System.Windows.Forms.Button()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnOperacionResta = New System.Windows.Forms.Button()
        Me.btnOperacionDivision = New System.Windows.Forms.Button()
        Me.btnOperacionSuma = New System.Windows.Forms.Button()
        Me.btnOperacionMultiplicacion = New System.Windows.Forms.Button()
        Me.btnPorcentaje = New System.Windows.Forms.Button()
        Me.btnIgual = New System.Windows.Forms.Button()
        Me.lstbHistorial = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblFoco = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSuperior
        '
        Me.lblSuperior.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuperior.Location = New System.Drawing.Point(12, 53)
        Me.lblSuperior.Name = "lblSuperior"
        Me.lblSuperior.Size = New System.Drawing.Size(498, 25)
        Me.lblSuperior.TabIndex = 0
        Me.lblSuperior.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPantalla
        '
        Me.txtPantalla.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPantalla.Location = New System.Drawing.Point(12, 81)
        Me.txtPantalla.Name = "txtPantalla"
        Me.txtPantalla.ReadOnly = True
        Me.txtPantalla.Size = New System.Drawing.Size(499, 70)
        Me.txtPantalla.TabIndex = 1
        Me.txtPantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnDigito7
        '
        Me.btnDigito7.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDigito7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDigito7.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDigito7.Location = New System.Drawing.Point(12, 157)
        Me.btnDigito7.Name = "btnDigito7"
        Me.btnDigito7.Size = New System.Drawing.Size(90, 70)
        Me.btnDigito7.TabIndex = 2
        Me.btnDigito7.Text = "7"
        Me.btnDigito7.UseVisualStyleBackColor = False
        '
        'btnDigito8
        '
        Me.btnDigito8.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDigito8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDigito8.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDigito8.Location = New System.Drawing.Point(108, 157)
        Me.btnDigito8.Name = "btnDigito8"
        Me.btnDigito8.Size = New System.Drawing.Size(90, 70)
        Me.btnDigito8.TabIndex = 3
        Me.btnDigito8.Text = "8"
        Me.btnDigito8.UseVisualStyleBackColor = False
        '
        'btnDigito9
        '
        Me.btnDigito9.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDigito9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDigito9.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDigito9.Location = New System.Drawing.Point(204, 157)
        Me.btnDigito9.Name = "btnDigito9"
        Me.btnDigito9.Size = New System.Drawing.Size(90, 70)
        Me.btnDigito9.TabIndex = 4
        Me.btnDigito9.Text = "9"
        Me.btnDigito9.UseVisualStyleBackColor = False
        '
        'btnDigito6
        '
        Me.btnDigito6.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDigito6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDigito6.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDigito6.Location = New System.Drawing.Point(204, 233)
        Me.btnDigito6.Name = "btnDigito6"
        Me.btnDigito6.Size = New System.Drawing.Size(90, 70)
        Me.btnDigito6.TabIndex = 7
        Me.btnDigito6.Text = "6"
        Me.btnDigito6.UseVisualStyleBackColor = False
        '
        'btnDigito5
        '
        Me.btnDigito5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDigito5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDigito5.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDigito5.Location = New System.Drawing.Point(108, 233)
        Me.btnDigito5.Name = "btnDigito5"
        Me.btnDigito5.Size = New System.Drawing.Size(90, 70)
        Me.btnDigito5.TabIndex = 6
        Me.btnDigito5.Text = "5"
        Me.btnDigito5.UseVisualStyleBackColor = False
        '
        'btnDigito4
        '
        Me.btnDigito4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDigito4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDigito4.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDigito4.Location = New System.Drawing.Point(12, 233)
        Me.btnDigito4.Name = "btnDigito4"
        Me.btnDigito4.Size = New System.Drawing.Size(90, 70)
        Me.btnDigito4.TabIndex = 5
        Me.btnDigito4.Text = "4"
        Me.btnDigito4.UseVisualStyleBackColor = False
        '
        'btnDigito3
        '
        Me.btnDigito3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDigito3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDigito3.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDigito3.Location = New System.Drawing.Point(204, 309)
        Me.btnDigito3.Name = "btnDigito3"
        Me.btnDigito3.Size = New System.Drawing.Size(90, 70)
        Me.btnDigito3.TabIndex = 10
        Me.btnDigito3.Text = "3"
        Me.btnDigito3.UseVisualStyleBackColor = False
        '
        'btnDigito2
        '
        Me.btnDigito2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDigito2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDigito2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDigito2.Location = New System.Drawing.Point(108, 309)
        Me.btnDigito2.Name = "btnDigito2"
        Me.btnDigito2.Size = New System.Drawing.Size(90, 70)
        Me.btnDigito2.TabIndex = 9
        Me.btnDigito2.Text = "2"
        Me.btnDigito2.UseVisualStyleBackColor = False
        '
        'btnDigito1
        '
        Me.btnDigito1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDigito1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDigito1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDigito1.Location = New System.Drawing.Point(12, 309)
        Me.btnDigito1.Name = "btnDigito1"
        Me.btnDigito1.Size = New System.Drawing.Size(90, 70)
        Me.btnDigito1.TabIndex = 8
        Me.btnDigito1.Text = "1"
        Me.btnDigito1.UseVisualStyleBackColor = False
        '
        'btnPuntoDecimal
        '
        Me.btnPuntoDecimal.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPuntoDecimal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPuntoDecimal.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPuntoDecimal.Location = New System.Drawing.Point(204, 385)
        Me.btnPuntoDecimal.Name = "btnPuntoDecimal"
        Me.btnPuntoDecimal.Size = New System.Drawing.Size(90, 70)
        Me.btnPuntoDecimal.TabIndex = 13
        Me.btnPuntoDecimal.Text = "."
        Me.btnPuntoDecimal.UseVisualStyleBackColor = False
        '
        'btnDigito0
        '
        Me.btnDigito0.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDigito0.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDigito0.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDigito0.Location = New System.Drawing.Point(108, 385)
        Me.btnDigito0.Name = "btnDigito0"
        Me.btnDigito0.Size = New System.Drawing.Size(90, 70)
        Me.btnDigito0.TabIndex = 12
        Me.btnDigito0.Text = "0"
        Me.btnDigito0.UseVisualStyleBackColor = False
        '
        'btnInvertirSigno
        '
        Me.btnInvertirSigno.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnInvertirSigno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInvertirSigno.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInvertirSigno.Location = New System.Drawing.Point(12, 385)
        Me.btnInvertirSigno.Name = "btnInvertirSigno"
        Me.btnInvertirSigno.Size = New System.Drawing.Size(90, 70)
        Me.btnInvertirSigno.TabIndex = 11
        Me.btnInvertirSigno.Text = "+/-"
        Me.btnInvertirSigno.UseVisualStyleBackColor = False
        '
        'btnCE
        '
        Me.btnCE.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCE.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCE.Location = New System.Drawing.Point(421, 157)
        Me.btnCE.Name = "btnCE"
        Me.btnCE.Size = New System.Drawing.Size(90, 70)
        Me.btnCE.TabIndex = 15
        Me.btnCE.Text = "CE"
        Me.btnCE.UseVisualStyleBackColor = False
        '
        'btnC
        '
        Me.btnC.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnC.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC.Location = New System.Drawing.Point(325, 157)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(90, 70)
        Me.btnC.TabIndex = 14
        Me.btnC.Text = "C"
        Me.btnC.UseVisualStyleBackColor = False
        '
        'btnOperacionResta
        '
        Me.btnOperacionResta.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnOperacionResta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOperacionResta.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOperacionResta.Location = New System.Drawing.Point(421, 233)
        Me.btnOperacionResta.Name = "btnOperacionResta"
        Me.btnOperacionResta.Size = New System.Drawing.Size(90, 70)
        Me.btnOperacionResta.TabIndex = 17
        Me.btnOperacionResta.Text = "-"
        Me.btnOperacionResta.UseVisualStyleBackColor = False
        '
        'btnOperacionDivision
        '
        Me.btnOperacionDivision.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnOperacionDivision.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOperacionDivision.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOperacionDivision.Location = New System.Drawing.Point(325, 233)
        Me.btnOperacionDivision.Name = "btnOperacionDivision"
        Me.btnOperacionDivision.Size = New System.Drawing.Size(90, 70)
        Me.btnOperacionDivision.TabIndex = 16
        Me.btnOperacionDivision.Text = "/"
        Me.btnOperacionDivision.UseVisualStyleBackColor = False
        '
        'btnOperacionSuma
        '
        Me.btnOperacionSuma.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnOperacionSuma.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOperacionSuma.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOperacionSuma.Location = New System.Drawing.Point(421, 309)
        Me.btnOperacionSuma.Name = "btnOperacionSuma"
        Me.btnOperacionSuma.Size = New System.Drawing.Size(90, 70)
        Me.btnOperacionSuma.TabIndex = 19
        Me.btnOperacionSuma.Text = "+"
        Me.btnOperacionSuma.UseVisualStyleBackColor = False
        '
        'btnOperacionMultiplicacion
        '
        Me.btnOperacionMultiplicacion.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnOperacionMultiplicacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOperacionMultiplicacion.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOperacionMultiplicacion.Location = New System.Drawing.Point(325, 309)
        Me.btnOperacionMultiplicacion.Name = "btnOperacionMultiplicacion"
        Me.btnOperacionMultiplicacion.Size = New System.Drawing.Size(90, 70)
        Me.btnOperacionMultiplicacion.TabIndex = 18
        Me.btnOperacionMultiplicacion.Text = "x"
        Me.btnOperacionMultiplicacion.UseVisualStyleBackColor = False
        '
        'btnPorcentaje
        '
        Me.btnPorcentaje.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPorcentaje.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPorcentaje.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPorcentaje.Location = New System.Drawing.Point(421, 385)
        Me.btnPorcentaje.Name = "btnPorcentaje"
        Me.btnPorcentaje.Size = New System.Drawing.Size(90, 70)
        Me.btnPorcentaje.TabIndex = 21
        Me.btnPorcentaje.Text = "%"
        Me.btnPorcentaje.UseVisualStyleBackColor = False
        '
        'btnIgual
        '
        Me.btnIgual.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnIgual.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIgual.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIgual.Location = New System.Drawing.Point(325, 385)
        Me.btnIgual.Name = "btnIgual"
        Me.btnIgual.Size = New System.Drawing.Size(90, 70)
        Me.btnIgual.TabIndex = 20
        Me.btnIgual.Text = "="
        Me.btnIgual.UseVisualStyleBackColor = False
        '
        'lstbHistorial
        '
        Me.lstbHistorial.Dock = System.Windows.Forms.DockStyle.Right
        Me.lstbHistorial.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.lstbHistorial.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstbHistorial.FormattingEnabled = True
        Me.lstbHistorial.Location = New System.Drawing.Point(532, 0)
        Me.lstbHistorial.Name = "lstbHistorial"
        Me.lstbHistorial.Size = New System.Drawing.Size(250, 473)
        Me.lstbHistorial.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.CofinV3.My.Resources.Resources.historial
        Me.PictureBox1.Location = New System.Drawing.Point(480, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'lblFoco
        '
        Me.lblFoco.AutoSize = True
        Me.lblFoco.Location = New System.Drawing.Point(468, 12)
        Me.lblFoco.Name = "lblFoco"
        Me.lblFoco.Size = New System.Drawing.Size(0, 20)
        Me.lblFoco.TabIndex = 23
        Me.lblFoco.Visible = False
        '
        'frmCalculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(782, 473)
        Me.Controls.Add(Me.lblFoco)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lstbHistorial)
        Me.Controls.Add(Me.btnPorcentaje)
        Me.Controls.Add(Me.btnIgual)
        Me.Controls.Add(Me.btnOperacionSuma)
        Me.Controls.Add(Me.btnOperacionMultiplicacion)
        Me.Controls.Add(Me.btnOperacionResta)
        Me.Controls.Add(Me.btnOperacionDivision)
        Me.Controls.Add(Me.btnCE)
        Me.Controls.Add(Me.btnC)
        Me.Controls.Add(Me.btnPuntoDecimal)
        Me.Controls.Add(Me.btnDigito0)
        Me.Controls.Add(Me.btnInvertirSigno)
        Me.Controls.Add(Me.btnDigito3)
        Me.Controls.Add(Me.btnDigito2)
        Me.Controls.Add(Me.btnDigito1)
        Me.Controls.Add(Me.btnDigito6)
        Me.Controls.Add(Me.btnDigito5)
        Me.Controls.Add(Me.btnDigito4)
        Me.Controls.Add(Me.btnDigito9)
        Me.Controls.Add(Me.btnDigito8)
        Me.Controls.Add(Me.btnDigito7)
        Me.Controls.Add(Me.txtPantalla)
        Me.Controls.Add(Me.lblSuperior)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCalculadora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSuperior As Label
    Friend WithEvents txtPantalla As TextBox
    Friend WithEvents btnDigito7 As Button
    Friend WithEvents btnDigito8 As Button
    Friend WithEvents btnDigito9 As Button
    Friend WithEvents btnDigito6 As Button
    Friend WithEvents btnDigito5 As Button
    Friend WithEvents btnDigito4 As Button
    Friend WithEvents btnDigito3 As Button
    Friend WithEvents btnDigito2 As Button
    Friend WithEvents btnDigito1 As Button
    Friend WithEvents btnPuntoDecimal As Button
    Friend WithEvents btnDigito0 As Button
    Friend WithEvents btnInvertirSigno As Button
    Friend WithEvents btnCE As Button
    Friend WithEvents btnC As Button
    Friend WithEvents btnOperacionResta As Button
    Friend WithEvents btnOperacionDivision As Button
    Friend WithEvents btnOperacionSuma As Button
    Friend WithEvents btnOperacionMultiplicacion As Button
    Friend WithEvents btnPorcentaje As Button
    Friend WithEvents btnIgual As Button
    Friend WithEvents lstbHistorial As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblFoco As Label
End Class
