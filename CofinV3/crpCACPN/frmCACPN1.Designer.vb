<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCACPN1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCACPN1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombreTitular = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNro = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtExtension = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSexo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFecnac = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNacionalidad = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt2daNacionalidad = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtResidente = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPaisResidencia = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPaisNacimiento = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.chbxEEUU1 = New System.Windows.Forms.CheckBox()
        Me.chbxEEUU2 = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtCalleAv = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtNumDomicilio = New System.Windows.Forms.TextBox()
        Me.txtCalleAv2 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtDepartamento = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtProvincia = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtDistrito = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtTelFijo = New System.Windows.Forms.TextBox()
        Me.txtTelCel = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pctbxImagenBanco = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label27 = New System.Windows.Forms.Label()
        CType(Me.pctbxImagenBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(18, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(446, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CREACIÓN/ACTUALIZACIÓN CLIENTE PERSONA NATURAL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(19, 151)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DATOS DE TITULAR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(19, 181)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(373, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Apellido paterno / Apellido materno o de casada / Nombres"
        '
        'txtNombreTitular
        '
        Me.txtNombreTitular.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtNombreTitular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreTitular.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtNombreTitular.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtNombreTitular.Location = New System.Drawing.Point(23, 204)
        Me.txtNombreTitular.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombreTitular.Name = "txtNombreTitular"
        Me.txtNombreTitular.Size = New System.Drawing.Size(978, 25)
        Me.txtNombreTitular.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(19, 239)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Documento de identidad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(19, 272)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Nº"
        '
        'txtNro
        '
        Me.txtNro.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtNro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNro.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtNro.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtNro.Location = New System.Drawing.Point(50, 269)
        Me.txtNro.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNro.Name = "txtNro"
        Me.txtNro.Size = New System.Drawing.Size(130, 25)
        Me.txtNro.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(191, 272)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 19)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Ext."
        '
        'txtExtension
        '
        Me.txtExtension.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtExtension.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExtension.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtExtension.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtExtension.Location = New System.Drawing.Point(225, 269)
        Me.txtExtension.Margin = New System.Windows.Forms.Padding(2)
        Me.txtExtension.Name = "txtExtension"
        Me.txtExtension.Size = New System.Drawing.Size(113, 25)
        Me.txtExtension.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(354, 272)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 19)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Tipo"
        '
        'txtTipo
        '
        Me.txtTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtTipo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtTipo.Location = New System.Drawing.Point(393, 269)
        Me.txtTipo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(130, 25)
        Me.txtTipo.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(527, 272)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 19)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Sexo"
        '
        'txtSexo
        '
        Me.txtSexo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtSexo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSexo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtSexo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtSexo.Location = New System.Drawing.Point(571, 269)
        Me.txtSexo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSexo.Name = "txtSexo"
        Me.txtSexo.Size = New System.Drawing.Size(137, 25)
        Me.txtSexo.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(712, 272)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 19)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Fecha de Nacimiento"
        '
        'txtFecnac
        '
        Me.txtFecnac.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtFecnac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecnac.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtFecnac.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtFecnac.Location = New System.Drawing.Point(851, 269)
        Me.txtFecnac.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFecnac.Name = "txtFecnac"
        Me.txtFecnac.Size = New System.Drawing.Size(150, 25)
        Me.txtFecnac.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(19, 301)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 19)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Nacionalidad"
        '
        'txtNacionalidad
        '
        Me.txtNacionalidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtNacionalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNacionalidad.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtNacionalidad.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtNacionalidad.Location = New System.Drawing.Point(110, 299)
        Me.txtNacionalidad.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNacionalidad.Name = "txtNacionalidad"
        Me.txtNacionalidad.Size = New System.Drawing.Size(149, 25)
        Me.txtNacionalidad.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label12.Location = New System.Drawing.Point(275, 301)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 19)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "2da Nacionalidad"
        '
        'txt2daNacionalidad
        '
        Me.txt2daNacionalidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt2daNacionalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt2daNacionalidad.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txt2daNacionalidad.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt2daNacionalidad.Location = New System.Drawing.Point(393, 299)
        Me.txt2daNacionalidad.Margin = New System.Windows.Forms.Padding(2)
        Me.txt2daNacionalidad.Name = "txt2daNacionalidad"
        Me.txt2daNacionalidad.Size = New System.Drawing.Size(130, 25)
        Me.txt2daNacionalidad.TabIndex = 19
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label13.Location = New System.Drawing.Point(527, 301)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 19)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Residente"
        '
        'txtResidente
        '
        Me.txtResidente.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtResidente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResidente.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtResidente.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtResidente.Location = New System.Drawing.Point(602, 299)
        Me.txtResidente.Margin = New System.Windows.Forms.Padding(2)
        Me.txtResidente.Name = "txtResidente"
        Me.txtResidente.Size = New System.Drawing.Size(137, 25)
        Me.txtResidente.TabIndex = 21
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label14.Location = New System.Drawing.Point(743, 301)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 19)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "País Residencia"
        '
        'txtPaisResidencia
        '
        Me.txtPaisResidencia.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPaisResidencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPaisResidencia.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPaisResidencia.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtPaisResidencia.Location = New System.Drawing.Point(851, 299)
        Me.txtPaisResidencia.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPaisResidencia.Name = "txtPaisResidencia"
        Me.txtPaisResidencia.Size = New System.Drawing.Size(150, 25)
        Me.txtPaisResidencia.TabIndex = 23
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label15.Location = New System.Drawing.Point(19, 331)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(106, 19)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "País Nacimiento"
        '
        'txtPaisNacimiento
        '
        Me.txtPaisNacimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPaisNacimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPaisNacimiento.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPaisNacimiento.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtPaisNacimiento.Location = New System.Drawing.Point(133, 329)
        Me.txtPaisNacimiento.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPaisNacimiento.Name = "txtPaisNacimiento"
        Me.txtPaisNacimiento.Size = New System.Drawing.Size(126, 25)
        Me.txtPaisNacimiento.TabIndex = 25
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label17.Location = New System.Drawing.Point(19, 362)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(973, 67)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = resources.GetString("Label17.Text")
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label18.Location = New System.Drawing.Point(19, 124)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(117, 19)
        Me.Label18.TabIndex = 28
        Me.Label18.Text = "DATOS BÁSICOS"
        '
        'chbxEEUU1
        '
        Me.chbxEEUU1.AutoSize = True
        Me.chbxEEUU1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.chbxEEUU1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.chbxEEUU1.Location = New System.Drawing.Point(20, 431)
        Me.chbxEEUU1.Margin = New System.Windows.Forms.Padding(2)
        Me.chbxEEUU1.Name = "chbxEEUU1"
        Me.chbxEEUU1.Size = New System.Drawing.Size(355, 23)
        Me.chbxEEUU1.TabIndex = 29
        Me.chbxEEUU1.Text = "Si: Completar el formulario IWS W-9 Persona Natrural"
        Me.chbxEEUU1.UseVisualStyleBackColor = True
        '
        'chbxEEUU2
        '
        Me.chbxEEUU2.AutoSize = True
        Me.chbxEEUU2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.chbxEEUU2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.chbxEEUU2.Location = New System.Drawing.Point(588, 431)
        Me.chbxEEUU2.Margin = New System.Windows.Forms.Padding(2)
        Me.chbxEEUU2.Name = "chbxEEUU2"
        Me.chbxEEUU2.Size = New System.Drawing.Size(46, 23)
        Me.chbxEEUU2.TabIndex = 30
        Me.chbxEEUU2.Text = "No"
        Me.chbxEEUU2.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label16.Location = New System.Drawing.Point(18, 482)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(160, 19)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "DIRECCIÓN DOMICILIO"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label19.Location = New System.Drawing.Point(18, 508)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(70, 19)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "Calle / Av."
        '
        'txtCalleAv
        '
        Me.txtCalleAv.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtCalleAv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCalleAv.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCalleAv.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtCalleAv.Location = New System.Drawing.Point(96, 506)
        Me.txtCalleAv.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCalleAv.Name = "txtCalleAv"
        Me.txtCalleAv.Size = New System.Drawing.Size(684, 25)
        Me.txtCalleAv.TabIndex = 33
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label20.Location = New System.Drawing.Point(784, 508)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(59, 19)
        Me.Label20.TabIndex = 34
        Me.Label20.Text = "Número"
        '
        'txtNumDomicilio
        '
        Me.txtNumDomicilio.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtNumDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumDomicilio.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtNumDomicilio.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtNumDomicilio.Location = New System.Drawing.Point(850, 506)
        Me.txtNumDomicilio.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumDomicilio.Name = "txtNumDomicilio"
        Me.txtNumDomicilio.Size = New System.Drawing.Size(150, 25)
        Me.txtNumDomicilio.TabIndex = 35
        '
        'txtCalleAv2
        '
        Me.txtCalleAv2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCalleAv2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCalleAv2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCalleAv2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtCalleAv2.Location = New System.Drawing.Point(23, 535)
        Me.txtCalleAv2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCalleAv2.Name = "txtCalleAv2"
        Me.txtCalleAv2.Size = New System.Drawing.Size(977, 25)
        Me.txtCalleAv2.TabIndex = 36
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label21.Location = New System.Drawing.Point(18, 567)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(98, 19)
        Me.Label21.TabIndex = 37
        Me.Label21.Text = "Departamento"
        '
        'txtDepartamento
        '
        Me.txtDepartamento.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDepartamento.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtDepartamento.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtDepartamento.Location = New System.Drawing.Point(114, 566)
        Me.txtDepartamento.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.Size = New System.Drawing.Size(201, 25)
        Me.txtDepartamento.TabIndex = 38
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label22.Location = New System.Drawing.Point(370, 567)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 19)
        Me.Label22.TabIndex = 39
        Me.Label22.Text = "Provincia"
        '
        'txtProvincia
        '
        Me.txtProvincia.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtProvincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProvincia.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtProvincia.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtProvincia.Location = New System.Drawing.Point(438, 565)
        Me.txtProvincia.Margin = New System.Windows.Forms.Padding(2)
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(196, 25)
        Me.txtProvincia.TabIndex = 40
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label23.Location = New System.Drawing.Point(728, 568)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(54, 19)
        Me.Label23.TabIndex = 41
        Me.Label23.Text = "Distrito"
        '
        'txtDistrito
        '
        Me.txtDistrito.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDistrito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDistrito.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtDistrito.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtDistrito.Location = New System.Drawing.Point(786, 565)
        Me.txtDistrito.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDistrito.Name = "txtDistrito"
        Me.txtDistrito.Size = New System.Drawing.Size(214, 25)
        Me.txtDistrito.TabIndex = 42
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label24.Location = New System.Drawing.Point(19, 596)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(85, 19)
        Me.Label24.TabIndex = 43
        Me.Label24.Text = "Telefono Fijo"
        '
        'txtTelFijo
        '
        Me.txtTelFijo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTelFijo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelFijo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtTelFijo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtTelFijo.Location = New System.Drawing.Point(114, 594)
        Me.txtTelFijo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTelFijo.Name = "txtTelFijo"
        Me.txtTelFijo.Size = New System.Drawing.Size(201, 25)
        Me.txtTelFijo.TabIndex = 44
        '
        'txtTelCel
        '
        Me.txtTelCel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTelCel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelCel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtTelCel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtTelCel.Location = New System.Drawing.Point(438, 594)
        Me.txtTelCel.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTelCel.Name = "txtTelCel"
        Me.txtTelCel.Size = New System.Drawing.Size(196, 25)
        Me.txtTelCel.TabIndex = 46
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label25.Location = New System.Drawing.Point(328, 596)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(106, 19)
        Me.Label25.TabIndex = 45
        Me.Label25.Text = "Telefono Celular"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label26.Location = New System.Drawing.Point(643, 596)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(139, 19)
        Me.Label26.TabIndex = 47
        Me.Label26.Text = "Correo Electrónico (*)"
        '
        'txtCorreo
        '
        Me.txtCorreo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCorreo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCorreo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtCorreo.Location = New System.Drawing.Point(786, 594)
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(213, 25)
        Me.txtCorreo.TabIndex = 48
        '
        'btnSiguiente
        '
        Me.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSiguiente.FlatAppearance.BorderSize = 0
        Me.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguiente.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSiguiente.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSiguiente.Location = New System.Drawing.Point(874, 657)
        Me.btnSiguiente.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(127, 41)
        Me.btnSiguiente.TabIndex = 49
        Me.btnSiguiente.Text = "SIGUIENTE"
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancelar.Location = New System.Drawing.Point(690, 657)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(127, 41)
        Me.btnCancelar.TabIndex = 50
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(19, 89)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(927, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "(*) En caso no corresponda la información de NIT, Datos de Cónyuge, Dirección Com" &
    "ercial, Cargo o Correo Electrónico registre ""No Aplica"" o ""No tiene"""
        '
        'pctbxImagenBanco
        '
        Me.pctbxImagenBanco.Image = Global.CofinV3.My.Resources.Resources.bcp_logo2
        Me.pctbxImagenBanco.Location = New System.Drawing.Point(748, 12)
        Me.pctbxImagenBanco.Margin = New System.Windows.Forms.Padding(2)
        Me.pctbxImagenBanco.Name = "pctbxImagenBanco"
        Me.pctbxImagenBanco.Size = New System.Drawing.Size(234, 74)
        Me.pctbxImagenBanco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctbxImagenBanco.TabIndex = 51
        Me.pctbxImagenBanco.TabStop = False
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label27.Location = New System.Drawing.Point(19, 454)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(619, 3)
        Me.Label27.TabIndex = 52
        '
        'frmCACPN1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1026, 714)
        Me.Controls.Add(Me.pctbxImagenBanco)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.txtTelCel)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtTelFijo)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txtDistrito)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtProvincia)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtDepartamento)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtCalleAv2)
        Me.Controls.Add(Me.txtNumDomicilio)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtCalleAv)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.chbxEEUU2)
        Me.Controls.Add(Me.chbxEEUU1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtPaisNacimiento)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtPaisResidencia)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtResidente)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt2daNacionalidad)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtNacionalidad)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtFecnac)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtSexo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtExtension)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNro)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNombreTitular)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label27)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmCACPN1"
        Me.Padding = New System.Windows.Forms.Padding(16, 24, 24, 24)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario de Persona Natural"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pctbxImagenBanco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombreTitular As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNro As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtExtension As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTipo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSexo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtFecnac As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtNacionalidad As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt2daNacionalidad As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtResidente As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtPaisResidencia As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtPaisNacimiento As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents chbxEEUU1 As CheckBox
    Friend WithEvents chbxEEUU2 As CheckBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtCalleAv As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtNumDomicilio As TextBox
    Friend WithEvents txtCalleAv2 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtDepartamento As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtProvincia As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtDistrito As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtTelFijo As TextBox
    Friend WithEvents txtTelCel As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents pctbxImagenBanco As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label27 As Label
End Class
