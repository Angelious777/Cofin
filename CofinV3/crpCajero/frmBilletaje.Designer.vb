<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBilletaje
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBilletaje))
        Me.lblTituloForm = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMont10 = New System.Windows.Forms.TextBox()
        Me.txtMont20 = New System.Windows.Forms.TextBox()
        Me.txtMont50 = New System.Windows.Forms.TextBox()
        Me.txtMont100 = New System.Windows.Forms.TextBox()
        Me.txtMont200 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTotalBill = New System.Windows.Forms.TextBox()
        Me.txtCant10 = New System.Windows.Forms.TextBox()
        Me.txtCant20 = New System.Windows.Forms.TextBox()
        Me.txtCant50 = New System.Windows.Forms.TextBox()
        Me.txtCant100 = New System.Windows.Forms.TextBox()
        Me.txtCant200 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTotalMon = New System.Windows.Forms.TextBox()
        Me.txtMont010 = New System.Windows.Forms.TextBox()
        Me.txtCant010 = New System.Windows.Forms.TextBox()
        Me.txtMont020 = New System.Windows.Forms.TextBox()
        Me.txtCant020 = New System.Windows.Forms.TextBox()
        Me.txtMont050 = New System.Windows.Forms.TextBox()
        Me.txtCant050 = New System.Windows.Forms.TextBox()
        Me.txtMont1 = New System.Windows.Forms.TextBox()
        Me.txtCant1 = New System.Windows.Forms.TextBox()
        Me.txtMont2 = New System.Windows.Forms.TextBox()
        Me.txtCant2 = New System.Windows.Forms.TextBox()
        Me.txtMont5 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtCant5 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtTotalCompleto = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTituloForm
        '
        Me.lblTituloForm.AutoSize = True
        Me.lblTituloForm.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloForm.Location = New System.Drawing.Point(392, 9)
        Me.lblTituloForm.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTituloForm.Name = "lblTituloForm"
        Me.lblTituloForm.Size = New System.Drawing.Size(259, 41)
        Me.lblTituloForm.TabIndex = 0
        Me.lblTituloForm.Text = "Formulario para """""
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Controls.Add(Me.txtMont10)
        Me.GroupBox1.Controls.Add(Me.txtMont20)
        Me.GroupBox1.Controls.Add(Me.txtMont50)
        Me.GroupBox1.Controls.Add(Me.txtMont100)
        Me.GroupBox1.Controls.Add(Me.txtMont200)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtTotalBill)
        Me.GroupBox1.Controls.Add(Me.txtCant10)
        Me.GroupBox1.Controls.Add(Me.txtCant20)
        Me.GroupBox1.Controls.Add(Me.txtCant50)
        Me.GroupBox1.Controls.Add(Me.txtCant100)
        Me.GroupBox1.Controls.Add(Me.txtCant200)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(27, 73)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(597, 452)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Billetes"
        '
        'txtMont10
        '
        Me.txtMont10.Enabled = False
        Me.txtMont10.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMont10.Location = New System.Drawing.Point(385, 309)
        Me.txtMont10.Margin = New System.Windows.Forms.Padding(5)
        Me.txtMont10.Name = "txtMont10"
        Me.txtMont10.Size = New System.Drawing.Size(183, 43)
        Me.txtMont10.TabIndex = 21
        '
        'txtMont20
        '
        Me.txtMont20.Enabled = False
        Me.txtMont20.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMont20.Location = New System.Drawing.Point(385, 258)
        Me.txtMont20.Margin = New System.Windows.Forms.Padding(5)
        Me.txtMont20.Name = "txtMont20"
        Me.txtMont20.Size = New System.Drawing.Size(183, 43)
        Me.txtMont20.TabIndex = 20
        '
        'txtMont50
        '
        Me.txtMont50.Enabled = False
        Me.txtMont50.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMont50.Location = New System.Drawing.Point(385, 207)
        Me.txtMont50.Margin = New System.Windows.Forms.Padding(5)
        Me.txtMont50.Name = "txtMont50"
        Me.txtMont50.Size = New System.Drawing.Size(183, 43)
        Me.txtMont50.TabIndex = 19
        '
        'txtMont100
        '
        Me.txtMont100.Enabled = False
        Me.txtMont100.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMont100.Location = New System.Drawing.Point(385, 156)
        Me.txtMont100.Margin = New System.Windows.Forms.Padding(5)
        Me.txtMont100.Name = "txtMont100"
        Me.txtMont100.Size = New System.Drawing.Size(183, 43)
        Me.txtMont100.TabIndex = 18
        '
        'txtMont200
        '
        Me.txtMont200.Enabled = False
        Me.txtMont200.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMont200.Location = New System.Drawing.Point(385, 104)
        Me.txtMont200.Margin = New System.Windows.Forms.Padding(5)
        Me.txtMont200.Name = "txtMont200"
        Me.txtMont200.Size = New System.Drawing.Size(183, 43)
        Me.txtMont200.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(287, 383)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 38)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Total:"
        '
        'txtTotalBill
        '
        Me.txtTotalBill.Enabled = False
        Me.txtTotalBill.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalBill.Location = New System.Drawing.Point(385, 380)
        Me.txtTotalBill.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTotalBill.Name = "txtTotalBill"
        Me.txtTotalBill.Size = New System.Drawing.Size(183, 43)
        Me.txtTotalBill.TabIndex = 15
        '
        'txtCant10
        '
        Me.txtCant10.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCant10.Location = New System.Drawing.Point(183, 307)
        Me.txtCant10.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCant10.Name = "txtCant10"
        Me.txtCant10.Size = New System.Drawing.Size(183, 43)
        Me.txtCant10.TabIndex = 14
        '
        'txtCant20
        '
        Me.txtCant20.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCant20.Location = New System.Drawing.Point(183, 256)
        Me.txtCant20.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCant20.Name = "txtCant20"
        Me.txtCant20.Size = New System.Drawing.Size(183, 43)
        Me.txtCant20.TabIndex = 13
        '
        'txtCant50
        '
        Me.txtCant50.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCant50.Location = New System.Drawing.Point(183, 205)
        Me.txtCant50.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCant50.Name = "txtCant50"
        Me.txtCant50.Size = New System.Drawing.Size(183, 43)
        Me.txtCant50.TabIndex = 12
        '
        'txtCant100
        '
        Me.txtCant100.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCant100.Location = New System.Drawing.Point(183, 154)
        Me.txtCant100.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCant100.Name = "txtCant100"
        Me.txtCant100.Size = New System.Drawing.Size(183, 43)
        Me.txtCant100.TabIndex = 11
        '
        'txtCant200
        '
        Me.txtCant200.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCant200.Location = New System.Drawing.Point(183, 102)
        Me.txtCant200.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCant200.Name = "txtCant200"
        Me.txtCant200.Size = New System.Drawing.Size(183, 43)
        Me.txtCant200.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(62, 312)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 38)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "10"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(62, 261)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 38)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "20"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(62, 209)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 38)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "50"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(49, 158)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 38)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "100"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 107)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 38)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "200"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(432, 44)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 38)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Monto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(217, 42)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 38)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cantidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 50)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Denominación"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox2.Controls.Add(Me.txtTotalMon)
        Me.GroupBox2.Controls.Add(Me.txtMont010)
        Me.GroupBox2.Controls.Add(Me.txtCant010)
        Me.GroupBox2.Controls.Add(Me.txtMont020)
        Me.GroupBox2.Controls.Add(Me.txtCant020)
        Me.GroupBox2.Controls.Add(Me.txtMont050)
        Me.GroupBox2.Controls.Add(Me.txtCant050)
        Me.GroupBox2.Controls.Add(Me.txtMont1)
        Me.GroupBox2.Controls.Add(Me.txtCant1)
        Me.GroupBox2.Controls.Add(Me.txtMont2)
        Me.GroupBox2.Controls.Add(Me.txtCant2)
        Me.GroupBox2.Controls.Add(Me.txtMont5)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.txtCant5)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(665, 73)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(618, 500)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Monedas"
        '
        'txtTotalMon
        '
        Me.txtTotalMon.Enabled = False
        Me.txtTotalMon.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalMon.Location = New System.Drawing.Point(400, 434)
        Me.txtTotalMon.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTotalMon.Name = "txtTotalMon"
        Me.txtTotalMon.Size = New System.Drawing.Size(183, 43)
        Me.txtTotalMon.TabIndex = 22
        '
        'txtMont010
        '
        Me.txtMont010.Enabled = False
        Me.txtMont010.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMont010.Location = New System.Drawing.Point(400, 361)
        Me.txtMont010.Margin = New System.Windows.Forms.Padding(5)
        Me.txtMont010.Name = "txtMont010"
        Me.txtMont010.Size = New System.Drawing.Size(183, 43)
        Me.txtMont010.TabIndex = 40
        '
        'txtCant010
        '
        Me.txtCant010.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCant010.Location = New System.Drawing.Point(192, 361)
        Me.txtCant010.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCant010.Name = "txtCant010"
        Me.txtCant010.Size = New System.Drawing.Size(183, 43)
        Me.txtCant010.TabIndex = 39
        '
        'txtMont020
        '
        Me.txtMont020.Enabled = False
        Me.txtMont020.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMont020.Location = New System.Drawing.Point(400, 310)
        Me.txtMont020.Margin = New System.Windows.Forms.Padding(5)
        Me.txtMont020.Name = "txtMont020"
        Me.txtMont020.Size = New System.Drawing.Size(183, 43)
        Me.txtMont020.TabIndex = 38
        '
        'txtCant020
        '
        Me.txtCant020.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCant020.Location = New System.Drawing.Point(192, 310)
        Me.txtCant020.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCant020.Name = "txtCant020"
        Me.txtCant020.Size = New System.Drawing.Size(183, 43)
        Me.txtCant020.TabIndex = 37
        '
        'txtMont050
        '
        Me.txtMont050.Enabled = False
        Me.txtMont050.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMont050.Location = New System.Drawing.Point(400, 259)
        Me.txtMont050.Margin = New System.Windows.Forms.Padding(5)
        Me.txtMont050.Name = "txtMont050"
        Me.txtMont050.Size = New System.Drawing.Size(183, 43)
        Me.txtMont050.TabIndex = 36
        '
        'txtCant050
        '
        Me.txtCant050.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCant050.Location = New System.Drawing.Point(192, 259)
        Me.txtCant050.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCant050.Name = "txtCant050"
        Me.txtCant050.Size = New System.Drawing.Size(183, 43)
        Me.txtCant050.TabIndex = 35
        '
        'txtMont1
        '
        Me.txtMont1.Enabled = False
        Me.txtMont1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMont1.Location = New System.Drawing.Point(400, 208)
        Me.txtMont1.Margin = New System.Windows.Forms.Padding(5)
        Me.txtMont1.Name = "txtMont1"
        Me.txtMont1.Size = New System.Drawing.Size(183, 43)
        Me.txtMont1.TabIndex = 34
        '
        'txtCant1
        '
        Me.txtCant1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCant1.Location = New System.Drawing.Point(192, 208)
        Me.txtCant1.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCant1.Name = "txtCant1"
        Me.txtCant1.Size = New System.Drawing.Size(183, 43)
        Me.txtCant1.TabIndex = 33
        '
        'txtMont2
        '
        Me.txtMont2.Enabled = False
        Me.txtMont2.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMont2.Location = New System.Drawing.Point(400, 157)
        Me.txtMont2.Margin = New System.Windows.Forms.Padding(5)
        Me.txtMont2.Name = "txtMont2"
        Me.txtMont2.Size = New System.Drawing.Size(183, 43)
        Me.txtMont2.TabIndex = 32
        '
        'txtCant2
        '
        Me.txtCant2.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCant2.Location = New System.Drawing.Point(192, 157)
        Me.txtCant2.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCant2.Name = "txtCant2"
        Me.txtCant2.Size = New System.Drawing.Size(183, 43)
        Me.txtCant2.TabIndex = 31
        '
        'txtMont5
        '
        Me.txtMont5.Enabled = False
        Me.txtMont5.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMont5.Location = New System.Drawing.Point(400, 105)
        Me.txtMont5.Margin = New System.Windows.Forms.Padding(5)
        Me.txtMont5.Name = "txtMont5"
        Me.txtMont5.Size = New System.Drawing.Size(183, 43)
        Me.txtMont5.TabIndex = 23
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(302, 437)
        Me.Label19.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(81, 38)
        Me.Label19.TabIndex = 30
        Me.Label19.Text = "Total:"
        '
        'txtCant5
        '
        Me.txtCant5.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCant5.Location = New System.Drawing.Point(192, 105)
        Me.txtCant5.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCant5.Name = "txtCant5"
        Me.txtCant5.Size = New System.Drawing.Size(183, 43)
        Me.txtCant5.TabIndex = 22
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(58, 366)
        Me.Label18.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 38)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "0.10"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(58, 315)
        Me.Label17.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 38)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "0.20"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(58, 264)
        Me.Label16.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 38)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "0.50"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(58, 212)
        Me.Label15.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 38)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "1.00"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(58, 161)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 38)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "2.00"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(58, 110)
        Me.Label13.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 38)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "5.00"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(447, 45)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 38)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Monto"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(226, 45)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(126, 38)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Cantidad"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(22, 53)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(162, 31)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Denominación"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(800, 606)
        Me.Label20.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(81, 38)
        Me.Label20.TabIndex = 41
        Me.Label20.Text = "Total:"
        '
        'txtTotalCompleto
        '
        Me.txtTotalCompleto.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCompleto.Location = New System.Drawing.Point(898, 603)
        Me.txtTotalCompleto.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTotalCompleto.Name = "txtTotalCompleto"
        Me.txtTotalCompleto.Size = New System.Drawing.Size(183, 43)
        Me.txtTotalCompleto.TabIndex = 41
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(127, 596)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(166, 50)
        Me.btnGuardar.TabIndex = 42
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVolver.FlatAppearance.BorderSize = 0
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.White
        Me.btnVolver.Location = New System.Drawing.Point(331, 596)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(5)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(166, 50)
        Me.btnVolver.TabIndex = 43
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'frmBilletaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1314, 676)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtTotalCompleto)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTituloForm)
        Me.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MaximizeBox = False
        Me.Name = "frmBilletaje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTituloForm As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCant200 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCant20 As TextBox
    Friend WithEvents txtCant50 As TextBox
    Friend WithEvents txtCant100 As TextBox
    Friend WithEvents txtCant10 As TextBox
    Friend WithEvents txtMont200 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTotalBill As TextBox
    Friend WithEvents txtMont50 As TextBox
    Friend WithEvents txtMont100 As TextBox
    Friend WithEvents txtMont10 As TextBox
    Friend WithEvents txtMont20 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtTotalMon As TextBox
    Friend WithEvents txtMont010 As TextBox
    Friend WithEvents txtCant010 As TextBox
    Friend WithEvents txtMont020 As TextBox
    Friend WithEvents txtCant020 As TextBox
    Friend WithEvents txtMont050 As TextBox
    Friend WithEvents txtCant050 As TextBox
    Friend WithEvents txtMont1 As TextBox
    Friend WithEvents txtCant1 As TextBox
    Friend WithEvents txtMont2 As TextBox
    Friend WithEvents txtCant2 As TextBox
    Friend WithEvents txtMont5 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtCant5 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtTotalCompleto As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnVolver As Button
End Class
