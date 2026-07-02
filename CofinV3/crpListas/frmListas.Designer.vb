<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListas))
        Me.lstElementos = New System.Windows.Forms.ListView()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstElementos
        '
        Me.lstElementos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lstElementos.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lstElementos.HideSelection = False
        Me.lstElementos.Location = New System.Drawing.Point(19, 27)
        Me.lstElementos.Name = "lstElementos"
        Me.lstElementos.Size = New System.Drawing.Size(579, 457)
        Me.lstElementos.TabIndex = 0
        Me.lstElementos.UseCompatibleStateImageBehavior = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnLimpiar.FlatAppearance.BorderSize = 0
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.White
        Me.btnLimpiar.Location = New System.Drawing.Point(603, 373)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(205, 42)
        Me.btnLimpiar.TabIndex = 4
        Me.btnLimpiar.Text = "LIMPIAR INFORMACION"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTitulo.Location = New System.Drawing.Point(604, 24)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(204, 138)
        Me.lblTitulo.TabIndex = 6
        Me.lblTitulo.Text = "titulo"
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCerrar.Location = New System.Drawing.Point(696, 442)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(111, 42)
        Me.btnCerrar.TabIndex = 17
        Me.btnCerrar.Text = "CERRAR"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'frmListas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(834, 511)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.lstElementos)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frmListas"
        Me.Padding = New System.Windows.Forms.Padding(16, 24, 24, 24)
        Me.Text = "Listas"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstElementos As ListView
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnCerrar As Button
End Class
