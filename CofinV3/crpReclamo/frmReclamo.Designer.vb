<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReclamo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReclamo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtCorreoElectronico = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtFechaAnio = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtFechaMes = New System.Windows.Forms.TextBox()
        Me.txtFechaDia = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtMontoReclamo = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtDescripcionReclamo = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtTelefonoCelular = New System.Windows.Forms.TextBox()
        Me.txtTelefonoDomicilio = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtDireccionZona = New System.Windows.Forms.TextBox()
        Me.txtDireccionCalle = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNroTestimonio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombreRepresentante = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCIReclamante = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombreReclamante = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxTipoReclamante = New System.Windows.Forms.ComboBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(365, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FORMULARIO DE RECLAMO"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtCorreoElectronico, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel5, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.txtMontoReclamo, 1, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.Label16, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.txtDescripcionReclamo, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label15, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Label14, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNroTestimonio, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNombreRepresentante, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCIReclamante, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNombreReclamante, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cbxTipoReclamante, 1, 1)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(19, 81)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 11
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(918, 479)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'txtCorreoElectronico
        '
        Me.txtCorreoElectronico.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCorreoElectronico.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCorreoElectronico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCorreoElectronico.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtCorreoElectronico.Location = New System.Drawing.Point(371, 292)
        Me.txtCorreoElectronico.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtCorreoElectronico.Name = "txtCorreoElectronico"
        Me.txtCorreoElectronico.Size = New System.Drawing.Size(543, 23)
        Me.txtCorreoElectronico.TabIndex = 12
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.AutoSize = True
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 423.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.txtFechaAnio, 2, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Label20, 2, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.txtFechaMes, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.txtFechaDia, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Label21, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label22, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(371, 326)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(543, 44)
        Me.TableLayoutPanel5.TabIndex = 13
        '
        'txtFechaAnio
        '
        Me.txtFechaAnio.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtFechaAnio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFechaAnio.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtFechaAnio.Location = New System.Drawing.Point(120, 18)
        Me.txtFechaAnio.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.txtFechaAnio.Name = "txtFechaAnio"
        Me.txtFechaAnio.Size = New System.Drawing.Size(45, 23)
        Me.txtFechaAnio.TabIndex = 15
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(123, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(29, 15)
        Me.Label20.TabIndex = 13
        Me.Label20.Text = "Año"
        '
        'txtFechaMes
        '
        Me.txtFechaMes.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtFechaMes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFechaMes.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtFechaMes.Location = New System.Drawing.Point(60, 18)
        Me.txtFechaMes.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.txtFechaMes.Name = "txtFechaMes"
        Me.txtFechaMes.Size = New System.Drawing.Size(45, 23)
        Me.txtFechaMes.TabIndex = 14
        '
        'txtFechaDia
        '
        Me.txtFechaDia.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtFechaDia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFechaDia.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtFechaDia.Location = New System.Drawing.Point(0, 18)
        Me.txtFechaDia.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.txtFechaDia.Name = "txtFechaDia"
        Me.txtFechaDia.Size = New System.Drawing.Size(45, 23)
        Me.txtFechaDia.TabIndex = 13
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(63, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(29, 15)
        Me.Label21.TabIndex = 10
        Me.Label21.Text = "Mes"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(3, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(24, 15)
        Me.Label22.TabIndex = 9
        Me.Label22.Text = "Día"
        '
        'txtMontoReclamo
        '
        Me.txtMontoReclamo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMontoReclamo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtMontoReclamo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMontoReclamo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtMontoReclamo.Location = New System.Drawing.Point(371, 432)
        Me.txtMontoReclamo.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtMontoReclamo.Name = "txtMontoReclamo"
        Me.txtMontoReclamo.Size = New System.Drawing.Size(543, 23)
        Me.txtMontoReclamo.TabIndex = 17
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(4, 436)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(126, 15)
        Me.Label16.TabIndex = 45
        Me.Label16.Text = "Monto comprometido"
        '
        'txtDescripcionReclamo
        '
        Me.txtDescripcionReclamo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcionReclamo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDescripcionReclamo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionReclamo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtDescripcionReclamo.Location = New System.Drawing.Point(371, 381)
        Me.txtDescripcionReclamo.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtDescripcionReclamo.Name = "txtDescripcionReclamo"
        Me.txtDescripcionReclamo.Size = New System.Drawing.Size(543, 23)
        Me.txtDescripcionReclamo.TabIndex = 16
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.txtTelefonoCelular, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txtTelefonoDomicilio, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label11, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label12, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(371, 237)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(543, 44)
        Me.TableLayoutPanel3.TabIndex = 9
        '
        'txtTelefonoCelular
        '
        Me.txtTelefonoCelular.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTelefonoCelular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefonoCelular.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtTelefonoCelular.Location = New System.Drawing.Point(271, 18)
        Me.txtTelefonoCelular.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.txtTelefonoCelular.Name = "txtTelefonoCelular"
        Me.txtTelefonoCelular.Size = New System.Drawing.Size(247, 23)
        Me.txtTelefonoCelular.TabIndex = 11
        '
        'txtTelefonoDomicilio
        '
        Me.txtTelefonoDomicilio.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTelefonoDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefonoDomicilio.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtTelefonoDomicilio.Location = New System.Drawing.Point(0, 18)
        Me.txtTelefonoDomicilio.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.txtTelefonoDomicilio.Name = "txtTelefonoDomicilio"
        Me.txtTelefonoDomicilio.Size = New System.Drawing.Size(246, 23)
        Me.txtTelefonoDomicilio.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(274, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 15)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Celular"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(122, 15)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Teléfono de domicilio"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.txtDireccionZona, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtDireccionCalle, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(371, 182)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(543, 44)
        Me.TableLayoutPanel2.TabIndex = 6
        '
        'txtDireccionZona
        '
        Me.txtDireccionZona.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDireccionZona.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccionZona.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtDireccionZona.Location = New System.Drawing.Point(271, 18)
        Me.txtDireccionZona.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.txtDireccionZona.Name = "txtDireccionZona"
        Me.txtDireccionZona.Size = New System.Drawing.Size(247, 23)
        Me.txtDireccionZona.TabIndex = 8
        '
        'txtDireccionCalle
        '
        Me.txtDireccionCalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDireccionCalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccionCalle.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtDireccionCalle.Location = New System.Drawing.Point(0, 18)
        Me.txtDireccionCalle.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.txtDireccionCalle.Name = "txtDireccionCalle"
        Me.txtDireccionCalle.Size = New System.Drawing.Size(246, 23)
        Me.txtDireccionCalle.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(274, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 15)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Zona"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 15)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Calle"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(4, 385)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(277, 15)
        Me.Label15.TabIndex = 43
        Me.Label15.Text = "Descripción el reclamo y/o solicitud del reclamante"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(4, 340)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(158, 15)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "Fecha del hecho del reclamo"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(4, 296)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 15)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Correo electrónico"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 251)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 15)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Teléfonos"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 15)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Dirección"
        '
        'txtNroTestimonio
        '
        Me.txtNroTestimonio.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNroTestimonio.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtNroTestimonio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroTestimonio.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtNroTestimonio.Location = New System.Drawing.Point(371, 148)
        Me.txtNroTestimonio.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtNroTestimonio.Name = "txtNroTestimonio"
        Me.txtNroTestimonio.Size = New System.Drawing.Size(543, 23)
        Me.txtNroTestimonio.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 15)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Número de Testimonio Poder"
        '
        'txtNombreRepresentante
        '
        Me.txtNombreRepresentante.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreRepresentante.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtNombreRepresentante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreRepresentante.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtNombreRepresentante.Location = New System.Drawing.Point(371, 114)
        Me.txtNombreRepresentante.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtNombreRepresentante.Name = "txtNombreRepresentante"
        Me.txtNombreRepresentante.Size = New System.Drawing.Size(543, 23)
        Me.txtNombreRepresentante.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(243, 15)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Nombre del representante legal o apoderado"
        '
        'txtCIReclamante
        '
        Me.txtCIReclamante.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCIReclamante.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCIReclamante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCIReclamante.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtCIReclamante.Location = New System.Drawing.Point(371, 80)
        Me.txtCIReclamante.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtCIReclamante.Name = "txtCIReclamante"
        Me.txtCIReclamante.Size = New System.Drawing.Size(543, 23)
        Me.txtCIReclamante.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 15)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Cédula de Identidad o NIT"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 15)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Tipo de reclamante"
        '
        'txtNombreReclamante
        '
        Me.txtNombreReclamante.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreReclamante.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtNombreReclamante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreReclamante.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombreReclamante.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtNombreReclamante.Location = New System.Drawing.Point(371, 6)
        Me.txtNombreReclamante.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtNombreReclamante.Name = "txtNombreReclamante"
        Me.txtNombreReclamante.Size = New System.Drawing.Size(543, 23)
        Me.txtNombreReclamante.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(214, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre o Razón Social del Reclamante"
        '
        'cbxTipoReclamante
        '
        Me.cbxTipoReclamante.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbxTipoReclamante.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cbxTipoReclamante.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cbxTipoReclamante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoReclamante.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxTipoReclamante.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.cbxTipoReclamante.FormattingEnabled = True
        Me.cbxTipoReclamante.Location = New System.Drawing.Point(371, 43)
        Me.cbxTipoReclamante.Margin = New System.Windows.Forms.Padding(3, 8, 3, 8)
        Me.cbxTipoReclamante.Name = "cbxTipoReclamante"
        Me.cbxTipoReclamante.Size = New System.Drawing.Size(282, 23)
        Me.cbxTipoReclamante.TabIndex = 2
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCancelar.Location = New System.Drawing.Point(687, 581)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(111, 42)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnSiguiente
        '
        Me.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSiguiente.FlatAppearance.BorderSize = 0
        Me.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguiente.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSiguiente.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSiguiente.Location = New System.Drawing.Point(826, 581)
        Me.btnSiguiente.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(111, 42)
        Me.btnSiguiente.TabIndex = 4
        Me.btnSiguiente.Text = "SIGUIENTE"
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'frmReclamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(954, 641)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmReclamo"
        Me.Padding = New System.Windows.Forms.Padding(16)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario de Reclamo"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtMontoReclamo As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtDescripcionReclamo As TextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents txtTelefonoCelular As TextBox
    Friend WithEvents txtTelefonoDomicilio As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtNroTestimonio As TextBox
    Friend WithEvents txtNombreRepresentante As TextBox
    Friend WithEvents txtCIReclamante As TextBox
    Friend WithEvents cbxTipoReclamante As ComboBox
    Friend WithEvents txtNombreReclamante As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents txtDireccionZona As TextBox
    Friend WithEvents txtDireccionCalle As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents txtCorreoElectronico As TextBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents txtFechaAnio As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtFechaMes As TextBox
    Friend WithEvents txtFechaDia As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
End Class
