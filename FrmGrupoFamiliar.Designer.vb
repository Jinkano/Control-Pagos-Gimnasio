<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGrupoFamiliar
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ColNomApeCli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColIdCli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColBnomApeCli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColBidCli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNumIntgrntes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNomGrupo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColIdGrupo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvListIntgrntes = New System.Windows.Forms.DataGridView()
        Me.DgvBscrIntgrntes = New System.Windows.Forms.DataGridView()
        Me.DgvListNomGrupo = New System.Windows.Forms.DataGridView()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblNomGrupo = New System.Windows.Forms.Label()
        Me.LblNumPerson = New System.Windows.Forms.Label()
        Me.TxtEdad = New System.Windows.Forms.Label()
        Me.NudNumPerson = New System.Windows.Forms.NumericUpDown()
        Me.TxtNomGrupo = New System.Windows.Forms.TextBox()
        Me.LblBuscarIntgrntes = New System.Windows.Forms.Label()
        Me.TxtBscrIntgrntes = New System.Windows.Forms.TextBox()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        CType(Me.DgvListIntgrntes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvBscrIntgrntes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvListNomGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel.SuspendLayout()
        CType(Me.NudNumPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ColNomApeCli
        '
        Me.ColNomApeCli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ColNomApeCli.HeaderText = "Nombre y Apellido"
        Me.ColNomApeCli.Name = "ColNomApeCli"
        Me.ColNomApeCli.ReadOnly = True
        Me.ColNomApeCli.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColNomApeCli.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColNomApeCli.Width = 414
        '
        'ColIdCli
        '
        Me.ColIdCli.HeaderText = "idCli"
        Me.ColIdCli.Name = "ColIdCli"
        Me.ColIdCli.ReadOnly = True
        Me.ColIdCli.Visible = False
        '
        'ColBnomApeCli
        '
        Me.ColBnomApeCli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ColBnomApeCli.HeaderText = ""
        Me.ColBnomApeCli.Name = "ColBnomApeCli"
        Me.ColBnomApeCli.ReadOnly = True
        Me.ColBnomApeCli.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColBnomApeCli.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColBnomApeCli.Width = 414
        '
        'ColBidCli
        '
        Me.ColBidCli.HeaderText = ""
        Me.ColBidCli.Name = "ColBidCli"
        Me.ColBidCli.ReadOnly = True
        Me.ColBidCli.Visible = False
        '
        'ColNumIntgrntes
        '
        Me.ColNumIntgrntes.HeaderText = ""
        Me.ColNumIntgrntes.Name = "ColNumIntgrntes"
        Me.ColNumIntgrntes.ReadOnly = True
        Me.ColNumIntgrntes.Visible = False
        '
        'ColNomGrupo
        '
        Me.ColNomGrupo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ColNomGrupo.HeaderText = ""
        Me.ColNomGrupo.Name = "ColNomGrupo"
        Me.ColNomGrupo.ReadOnly = True
        Me.ColNomGrupo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColNomGrupo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColNomGrupo.Width = 260
        '
        'ColIdGrupo
        '
        Me.ColIdGrupo.HeaderText = ""
        Me.ColIdGrupo.Name = "ColIdGrupo"
        Me.ColIdGrupo.ReadOnly = True
        Me.ColIdGrupo.Visible = False
        '
        'DgvListIntgrntes
        '
        Me.DgvListIntgrntes.AllowUserToAddRows = False
        Me.DgvListIntgrntes.AllowUserToDeleteRows = False
        Me.DgvListIntgrntes.AllowUserToResizeColumns = False
        Me.DgvListIntgrntes.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvListIntgrntes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DgvListIntgrntes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvListIntgrntes.ColumnHeadersHeight = 30
        Me.DgvListIntgrntes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvListIntgrntes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColIdCli, Me.ColNomApeCli})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvListIntgrntes.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvListIntgrntes.Location = New System.Drawing.Point(23, 162)
        Me.DgvListIntgrntes.Margin = New System.Windows.Forms.Padding(0, 6, 20, 20)
        Me.DgvListIntgrntes.MultiSelect = False
        Me.DgvListIntgrntes.Name = "DgvListIntgrntes"
        Me.DgvListIntgrntes.ReadOnly = True
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DgvListIntgrntes.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvListIntgrntes.RowHeadersWidth = 4
        Me.DgvListIntgrntes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvListIntgrntes.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DgvListIntgrntes.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvListIntgrntes.RowTemplate.DividerHeight = 2
        Me.DgvListIntgrntes.RowTemplate.Height = 30
        Me.DgvListIntgrntes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvListIntgrntes.Size = New System.Drawing.Size(440, 175)
        Me.DgvListIntgrntes.TabIndex = 5
        '
        'DgvBscrIntgrntes
        '
        Me.DgvBscrIntgrntes.AllowUserToAddRows = False
        Me.DgvBscrIntgrntes.AllowUserToDeleteRows = False
        Me.DgvBscrIntgrntes.AllowUserToResizeColumns = False
        Me.DgvBscrIntgrntes.AllowUserToResizeRows = False
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvBscrIntgrntes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvBscrIntgrntes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DgvBscrIntgrntes.ColumnHeadersHeight = 4
        Me.DgvBscrIntgrntes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvBscrIntgrntes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColBidCli, Me.ColBnomApeCli})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvBscrIntgrntes.DefaultCellStyle = DataGridViewCellStyle8
        Me.DgvBscrIntgrntes.Location = New System.Drawing.Point(23, 129)
        Me.DgvBscrIntgrntes.Margin = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.DgvBscrIntgrntes.MultiSelect = False
        Me.DgvBscrIntgrntes.Name = "DgvBscrIntgrntes"
        Me.DgvBscrIntgrntes.ReadOnly = True
        Me.DgvBscrIntgrntes.RowHeadersWidth = 4
        Me.DgvBscrIntgrntes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvBscrIntgrntes.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvBscrIntgrntes.RowTemplate.DividerHeight = 1
        Me.DgvBscrIntgrntes.RowTemplate.Height = 25
        Me.DgvBscrIntgrntes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvBscrIntgrntes.Size = New System.Drawing.Size(440, 208)
        Me.DgvBscrIntgrntes.TabIndex = 4
        Me.DgvBscrIntgrntes.Visible = False
        '
        'DgvListNomGrupo
        '
        Me.DgvListNomGrupo.AllowUserToAddRows = False
        Me.DgvListNomGrupo.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvListNomGrupo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvListNomGrupo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DgvListNomGrupo.ColumnHeadersHeight = 4
        Me.DgvListNomGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvListNomGrupo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColIdGrupo, Me.ColNomGrupo, Me.ColNumIntgrntes})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvListNomGrupo.DefaultCellStyle = DataGridViewCellStyle11
        Me.DgvListNomGrupo.Location = New System.Drawing.Point(23, 69)
        Me.DgvListNomGrupo.Margin = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.DgvListNomGrupo.MultiSelect = False
        Me.DgvListNomGrupo.Name = "DgvListNomGrupo"
        Me.DgvListNomGrupo.ReadOnly = True
        Me.DgvListNomGrupo.RowHeadersWidth = 4
        Me.DgvListNomGrupo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvListNomGrupo.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvListNomGrupo.RowTemplate.DividerHeight = 1
        Me.DgvListNomGrupo.RowTemplate.Height = 25
        Me.DgvListNomGrupo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvListNomGrupo.Size = New System.Drawing.Size(287, 148)
        Me.DgvListNomGrupo.TabIndex = 2
        Me.DgvListNomGrupo.Visible = False
        '
        'Panel
        '
        Me.Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel.Controls.Add(Me.Label1)
        Me.Panel.Controls.Add(Me.DgvListIntgrntes)
        Me.Panel.Controls.Add(Me.LblNomGrupo)
        Me.Panel.Controls.Add(Me.LblNumPerson)
        Me.Panel.Controls.Add(Me.TxtEdad)
        Me.Panel.Controls.Add(Me.NudNumPerson)
        Me.Panel.Controls.Add(Me.TxtNomGrupo)
        Me.Panel.Controls.Add(Me.LblBuscarIntgrntes)
        Me.Panel.Controls.Add(Me.TxtBscrIntgrntes)
        Me.Panel.Controls.Add(Me.DgvBscrIntgrntes)
        Me.Panel.Controls.Add(Me.DgvListNomGrupo)
        Me.Panel.Location = New System.Drawing.Point(29, 29)
        Me.Panel.Margin = New System.Windows.Forms.Padding(20, 20, 0, 0)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(487, 361)
        Me.Panel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 140)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Lista de los integrantes"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblNomGrupo
        '
        Me.LblNomGrupo.AutoSize = True
        Me.LblNomGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNomGrupo.Location = New System.Drawing.Point(20, 20)
        Me.LblNomGrupo.Margin = New System.Windows.Forms.Padding(20, 20, 0, 0)
        Me.LblNomGrupo.Name = "LblNomGrupo"
        Me.LblNomGrupo.Size = New System.Drawing.Size(162, 16)
        Me.LblNomGrupo.TabIndex = 1
        Me.LblNomGrupo.Text = "Nombre del grupo familiar"
        '
        'LblNumPerson
        '
        Me.LblNumPerson.AutoSize = True
        Me.LblNumPerson.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumPerson.Location = New System.Drawing.Point(320, 20)
        Me.LblNumPerson.Margin = New System.Windows.Forms.Padding(0)
        Me.LblNumPerson.Name = "LblNumPerson"
        Me.LblNumPerson.Size = New System.Drawing.Size(143, 16)
        Me.LblNumPerson.TabIndex = 2
        Me.LblNumPerson.Text = "Número de integrantes"
        Me.LblNumPerson.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtEdad
        '
        Me.TxtEdad.BackColor = System.Drawing.Color.Azure
        Me.TxtEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEdad.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!)
        Me.TxtEdad.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtEdad.Location = New System.Drawing.Point(393, 42)
        Me.TxtEdad.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(70, 26)
        Me.TxtEdad.TabIndex = 0
        Me.TxtEdad.Text = "9 de 9"
        Me.TxtEdad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NudNumPerson
        '
        Me.NudNumPerson.BackColor = System.Drawing.Color.Azure
        Me.NudNumPerson.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NudNumPerson.ForeColor = System.Drawing.Color.MediumBlue
        Me.NudNumPerson.Location = New System.Drawing.Point(320, 42)
        Me.NudNumPerson.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.NudNumPerson.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NudNumPerson.Name = "NudNumPerson"
        Me.NudNumPerson.Size = New System.Drawing.Size(70, 26)
        Me.NudNumPerson.TabIndex = 1
        Me.NudNumPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtNomGrupo
        '
        Me.TxtNomGrupo.BackColor = System.Drawing.Color.Azure
        Me.TxtNomGrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNomGrupo.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomGrupo.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtNomGrupo.Location = New System.Drawing.Point(23, 42)
        Me.TxtNomGrupo.Margin = New System.Windows.Forms.Padding(20, 6, 10, 0)
        Me.TxtNomGrupo.MaxLength = 30
        Me.TxtNomGrupo.Name = "TxtNomGrupo"
        Me.TxtNomGrupo.Size = New System.Drawing.Size(287, 26)
        Me.TxtNomGrupo.TabIndex = 0
        Me.TxtNomGrupo.WordWrap = False
        '
        'LblBuscarIntgrntes
        '
        Me.LblBuscarIntgrntes.AutoSize = True
        Me.LblBuscarIntgrntes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscarIntgrntes.Location = New System.Drawing.Point(20, 80)
        Me.LblBuscarIntgrntes.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.LblBuscarIntgrntes.Name = "LblBuscarIntgrntes"
        Me.LblBuscarIntgrntes.Size = New System.Drawing.Size(171, 16)
        Me.LblBuscarIntgrntes.TabIndex = 3
        Me.LblBuscarIntgrntes.Text = "Buscar integrante del grupo"
        Me.LblBuscarIntgrntes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtBscrIntgrntes
        '
        Me.TxtBscrIntgrntes.BackColor = System.Drawing.Color.Azure
        Me.TxtBscrIntgrntes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBscrIntgrntes.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBscrIntgrntes.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtBscrIntgrntes.Location = New System.Drawing.Point(23, 102)
        Me.TxtBscrIntgrntes.Margin = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.TxtBscrIntgrntes.MaxLength = 30
        Me.TxtBscrIntgrntes.Name = "TxtBscrIntgrntes"
        Me.TxtBscrIntgrntes.Size = New System.Drawing.Size(440, 26)
        Me.TxtBscrIntgrntes.TabIndex = 3
        Me.TxtBscrIntgrntes.WordWrap = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.SystemColors.Control
        Me.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.ForeColor = System.Drawing.Color.Brown
        Me.BtnCerrar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.salir22
        Me.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCerrar.Location = New System.Drawing.Point(532, 350)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(0, 0, 20, 20)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.BtnCerrar.Size = New System.Drawing.Size(150, 40)
        Me.BtnCerrar.TabIndex = 6
        Me.BtnCerrar.Text = "Cerrar &ventana"
        Me.BtnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.eliminar_28x32
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(532, 143)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Padding = New System.Windows.Forms.Padding(16, 0, 16, 0)
        Me.BtnEliminar.Size = New System.Drawing.Size(150, 45)
        Me.BtnEliminar.TabIndex = 2
        Me.BtnEliminar.Text = "&Eliminar"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Image = Global.ControlPagosGimnasio.My.Resources.Resources.nuevo_24x32
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(532, 29)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Padding = New System.Windows.Forms.Padding(22, 0, 22, 0)
        Me.BtnNuevo.Size = New System.Drawing.Size(150, 45)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.Text = "&Nuevo"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.cancel_c_28x28
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(532, 200)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Padding = New System.Windows.Forms.Padding(16, 0, 14, 0)
        Me.BtnCancelar.Size = New System.Drawing.Size(150, 45)
        Me.BtnCancelar.TabIndex = 3
        Me.BtnCancelar.Text = "&Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelar.UseVisualStyleBackColor = True
        Me.BtnCancelar.Visible = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.guardar_28x28
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(532, 29)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Padding = New System.Windows.Forms.Padding(18, 0, 16, 0)
        Me.BtnGuardar.Size = New System.Drawing.Size(150, 45)
        Me.BtnGuardar.TabIndex = 4
        Me.BtnGuardar.Text = "&Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = True
        Me.BtnGuardar.Visible = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.actualizar_28x27
        Me.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnActualizar.Location = New System.Drawing.Point(532, 29)
        Me.BtnActualizar.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Padding = New System.Windows.Forms.Padding(13, 0, 12, 0)
        Me.BtnActualizar.Size = New System.Drawing.Size(150, 45)
        Me.BtnActualizar.TabIndex = 5
        Me.BtnActualizar.Text = "&Actualizar"
        Me.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnActualizar.UseVisualStyleBackColor = True
        Me.BtnActualizar.Visible = False
        '
        'BtnModificar
        '
        Me.BtnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.editar_28x32
        Me.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModificar.Location = New System.Drawing.Point(532, 86)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Padding = New System.Windows.Forms.Padding(16, 0, 14, 0)
        Me.BtnModificar.Size = New System.Drawing.Size(150, 45)
        Me.BtnModificar.TabIndex = 1
        Me.BtnModificar.Text = "&Modificar"
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'FrmGrupoFamiliar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 419)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmGrupoFamiliar"
        Me.Text = "AGREGAR O MODIFICAR UN GRUPO FAMILIAR"
        CType(Me.DgvListIntgrntes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvBscrIntgrntes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvListNomGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        CType(Me.NudNumPerson, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents ColNomApeCli As DataGridViewTextBoxColumn
    Friend WithEvents ColIdCli As DataGridViewTextBoxColumn
    Friend WithEvents ColBnomApeCli As DataGridViewTextBoxColumn
    Friend WithEvents ColBidCli As DataGridViewTextBoxColumn
    Friend WithEvents ColNumIntgrntes As DataGridViewTextBoxColumn
    Friend WithEvents ColNomGrupo As DataGridViewTextBoxColumn
    Friend WithEvents BtnModificar As Button
    Friend WithEvents ColIdGrupo As DataGridViewTextBoxColumn
    Friend WithEvents DgvListIntgrntes As DataGridView
    Friend WithEvents DgvBscrIntgrntes As DataGridView
    Friend WithEvents DgvListNomGrupo As DataGridView
    Friend WithEvents Panel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LblNomGrupo As Label
    Friend WithEvents LblNumPerson As Label
    Friend WithEvents TxtEdad As Label
    Friend WithEvents NudNumPerson As NumericUpDown
    Friend WithEvents TxtNomGrupo As TextBox
    Friend WithEvents LblBuscarIntgrntes As Label
    Friend WithEvents TxtBscrIntgrntes As TextBox
    Friend WithEvents BtnCerrar As Button
End Class
