<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBuscarFormulario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarFormulario))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblResultadoBusqueda = New System.Windows.Forms.Label()
        Me.btnActualizarDatos = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxTipoCuenta = New System.Windows.Forms.ComboBox()
        Me.btnAlmacenados = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(18, 107)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nro De Identidad"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtBusqueda.Location = New System.Drawing.Point(18, 139)
        Me.txtBusqueda.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(263, 29)
        Me.txtBusqueda.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnBuscar.Location = New System.Drawing.Point(303, 132)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(111, 42)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "BUSCAR"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'lblResultadoBusqueda
        '
        Me.lblResultadoBusqueda.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultadoBusqueda.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblResultadoBusqueda.Location = New System.Drawing.Point(18, 193)
        Me.lblResultadoBusqueda.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblResultadoBusqueda.Name = "lblResultadoBusqueda"
        Me.lblResultadoBusqueda.Size = New System.Drawing.Size(262, 85)
        Me.lblResultadoBusqueda.TabIndex = 3
        Me.lblResultadoBusqueda.Text = "''"
        '
        'btnActualizarDatos
        '
        Me.btnActualizarDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnActualizarDatos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizarDatos.FlatAppearance.BorderSize = 0
        Me.btnActualizarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarDatos.ForeColor = System.Drawing.Color.White
        Me.btnActualizarDatos.Location = New System.Drawing.Point(303, 234)
        Me.btnActualizarDatos.Margin = New System.Windows.Forms.Padding(2)
        Me.btnActualizarDatos.Name = "btnActualizarDatos"
        Me.btnActualizarDatos.Size = New System.Drawing.Size(165, 42)
        Me.btnActualizarDatos.TabIndex = 4
        Me.btnActualizarDatos.Text = "ACTUALIZAR DATOS"
        Me.btnActualizarDatos.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(19, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tipo de cuenta"
        '
        'cbxTipoCuenta
        '
        Me.cbxTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoCuenta.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTipoCuenta.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.cbxTipoCuenta.FormattingEnabled = True
        Me.cbxTipoCuenta.Location = New System.Drawing.Point(18, 54)
        Me.cbxTipoCuenta.Name = "cbxTipoCuenta"
        Me.cbxTipoCuenta.Size = New System.Drawing.Size(262, 29)
        Me.cbxTipoCuenta.TabIndex = 6
        '
        'btnAlmacenados
        '
        Me.btnAlmacenados.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnAlmacenados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlmacenados.FlatAppearance.BorderSize = 0
        Me.btnAlmacenados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlmacenados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlmacenados.ForeColor = System.Drawing.Color.White
        Me.btnAlmacenados.Location = New System.Drawing.Point(303, 48)
        Me.btnAlmacenados.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAlmacenados.Name = "btnAlmacenados"
        Me.btnAlmacenados.Size = New System.Drawing.Size(165, 42)
        Me.btnAlmacenados.TabIndex = 7
        Me.btnAlmacenados.Text = "DATOS ALMACENADOS"
        Me.btnAlmacenados.UseVisualStyleBackColor = False
        '
        'frmBuscarFormulario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(494, 302)
        Me.Controls.Add(Me.btnAlmacenados)
        Me.Controls.Add(Me.cbxTipoCuenta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnActualizarDatos)
        Me.Controls.Add(Me.lblResultadoBusqueda)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmBuscarFormulario"
        Me.Padding = New System.Windows.Forms.Padding(16, 24, 24, 24)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Formulario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblResultadoBusqueda As Label
    Friend WithEvents btnActualizarDatos As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxTipoCuenta As ComboBox
    Friend WithEvents btnAlmacenados As Button
End Class
