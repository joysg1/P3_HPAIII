<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbTitulo = New System.Windows.Forms.Label()
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.lbRegistar = New System.Windows.Forms.Label()
        Me.lbData = New System.Windows.Forms.Label()
        Me.lbPrecio = New System.Windows.Forms.Label()
        Me.cbTipoNave = New System.Windows.Forms.ComboBox()
        Me.gbRegistro = New System.Windows.Forms.GroupBox()
        Me.lbComision = New System.Windows.Forms.Label()
        Me.lbTotalDiario = New System.Windows.Forms.Label()
        Me.lbDisPrecNave = New System.Windows.Forms.Label()
        Me.lbDesNave = New System.Windows.Forms.Label()
        Me.lboxPrecioNave = New System.Windows.Forms.ListBox()
        Me.lboxTipoNave = New System.Windows.Forms.ListBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.gbDatos.SuspendLayout()
        Me.gbRegistro.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbTitulo
        '
        Me.lbTitulo.AutoSize = True
        Me.lbTitulo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbTitulo.Location = New System.Drawing.Point(191, 22)
        Me.lbTitulo.Name = "lbTitulo"
        Me.lbTitulo.Size = New System.Drawing.Size(427, 41)
        Me.lbTitulo.TabIndex = 0
        Me.lbTitulo.Text = "REGISTRO DIARIO DE NAVES"
        '
        'gbDatos
        '
        Me.gbDatos.Controls.Add(Me.btnRegistrar)
        Me.gbDatos.Controls.Add(Me.lbRegistar)
        Me.gbDatos.Controls.Add(Me.lbData)
        Me.gbDatos.Controls.Add(Me.lbPrecio)
        Me.gbDatos.Controls.Add(Me.cbTipoNave)
        Me.gbDatos.Location = New System.Drawing.Point(28, 106)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(250, 305)
        Me.gbDatos.TabIndex = 1
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "DATOS "
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(73, 170)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(94, 52)
        Me.btnRegistrar.TabIndex = 4
        Me.btnRegistrar.Text = "REGISTRAR"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'lbRegistar
        '
        Me.lbRegistar.AutoSize = True
        Me.lbRegistar.Location = New System.Drawing.Point(18, 269)
        Me.lbRegistar.Name = "lbRegistar"
        Me.lbRegistar.Size = New System.Drawing.Size(168, 20)
        Me.lbRegistar.TabIndex = 3
        Me.lbRegistar.Text = "NAVES POR REGISTRAR:"
        '
        'lbData
        '
        Me.lbData.AutoSize = True
        Me.lbData.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbData.Location = New System.Drawing.Point(192, 252)
        Me.lbData.Name = "lbData"
        Me.lbData.Size = New System.Drawing.Size(52, 41)
        Me.lbData.TabIndex = 2
        Me.lbData.Text = "10"
        '
        'lbPrecio
        '
        Me.lbPrecio.AutoSize = True
        Me.lbPrecio.Location = New System.Drawing.Point(35, 111)
        Me.lbPrecio.Name = "lbPrecio"
        Me.lbPrecio.Size = New System.Drawing.Size(132, 20)
        Me.lbPrecio.TabIndex = 1
        Me.lbPrecio.Text = "PRECIO DE PEAJE: "
        '
        'cbTipoNave
        '
        Me.cbTipoNave.FormattingEnabled = True
        Me.cbTipoNave.Items.AddRange(New Object() {"Crucero", "Buque de carga", "PostPanamax"})
        Me.cbTipoNave.Location = New System.Drawing.Point(35, 48)
        Me.cbTipoNave.Name = "cbTipoNave"
        Me.cbTipoNave.Size = New System.Drawing.Size(151, 28)
        Me.cbTipoNave.TabIndex = 0
        Me.cbTipoNave.Text = "TIPO DE NAVE"
        '
        'gbRegistro
        '
        Me.gbRegistro.Controls.Add(Me.lbComision)
        Me.gbRegistro.Controls.Add(Me.lbTotalDiario)
        Me.gbRegistro.Controls.Add(Me.lbDisPrecNave)
        Me.gbRegistro.Controls.Add(Me.lbDesNave)
        Me.gbRegistro.Controls.Add(Me.lboxPrecioNave)
        Me.gbRegistro.Controls.Add(Me.lboxTipoNave)
        Me.gbRegistro.Location = New System.Drawing.Point(315, 106)
        Me.gbRegistro.Name = "gbRegistro"
        Me.gbRegistro.Size = New System.Drawing.Size(441, 363)
        Me.gbRegistro.TabIndex = 2
        Me.gbRegistro.TabStop = False
        Me.gbRegistro.Text = "REGISTRO"
        '
        'lbComision
        '
        Me.lbComision.AutoSize = True
        Me.lbComision.Location = New System.Drawing.Point(105, 330)
        Me.lbComision.Name = "lbComision"
        Me.lbComision.Size = New System.Drawing.Size(87, 20)
        Me.lbComision.TabIndex = 5
        Me.lbComision.Text = "COMISION: "
        '
        'lbTotalDiario
        '
        Me.lbTotalDiario.AutoSize = True
        Me.lbTotalDiario.Location = New System.Drawing.Point(105, 300)
        Me.lbTotalDiario.Name = "lbTotalDiario"
        Me.lbTotalDiario.Size = New System.Drawing.Size(110, 20)
        Me.lbTotalDiario.TabIndex = 4
        Me.lbTotalDiario.Text = "TOTAL DIARIO: "
        '
        'lbDisPrecNave
        '
        Me.lbDisPrecNave.AutoSize = True
        Me.lbDisPrecNave.Location = New System.Drawing.Point(264, 17)
        Me.lbDisPrecNave.Name = "lbDisPrecNave"
        Me.lbDisPrecNave.Size = New System.Drawing.Size(125, 20)
        Me.lbDisPrecNave.TabIndex = 3
        Me.lbDisPrecNave.Text = "PRECIO DE PEAJE"
        '
        'lbDesNave
        '
        Me.lbDesNave.AutoSize = True
        Me.lbDesNave.Location = New System.Drawing.Point(105, 17)
        Me.lbDesNave.Name = "lbDesNave"
        Me.lbDesNave.Size = New System.Drawing.Size(104, 20)
        Me.lbDesNave.TabIndex = 2
        Me.lbDesNave.Text = "TIPO DE NAVE"
        '
        'lboxPrecioNave
        '
        Me.lboxPrecioNave.FormattingEnabled = True
        Me.lboxPrecioNave.ItemHeight = 20
        Me.lboxPrecioNave.Location = New System.Drawing.Point(264, 48)
        Me.lboxPrecioNave.Name = "lboxPrecioNave"
        Me.lboxPrecioNave.Size = New System.Drawing.Size(125, 224)
        Me.lboxPrecioNave.TabIndex = 1
        '
        'lboxTipoNave
        '
        Me.lboxTipoNave.FormattingEnabled = True
        Me.lboxTipoNave.ItemHeight = 20
        Me.lboxTipoNave.Location = New System.Drawing.Point(76, 48)
        Me.lboxTipoNave.Name = "lboxTipoNave"
        Me.lboxTipoNave.Size = New System.Drawing.Size(131, 224)
        Me.lboxTipoNave.TabIndex = 0
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(662, 506)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(94, 48)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 566)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.gbRegistro)
        Me.Controls.Add(Me.gbDatos)
        Me.Controls.Add(Me.lbTitulo)
        Me.Name = "Form1"
        Me.Text = "JoyNelatonParcial3"
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        Me.gbRegistro.ResumeLayout(False)
        Me.gbRegistro.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbTitulo As Label
    Friend WithEvents gbDatos As GroupBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents lbRegistar As Label
    Friend WithEvents lbData As Label
    Friend WithEvents lbPrecio As Label
    Friend WithEvents cbTipoNave As ComboBox
    Friend WithEvents gbRegistro As GroupBox
    Friend WithEvents lbDisPrecNave As Label
    Friend WithEvents lbDesNave As Label
    Friend WithEvents lboxPrecioNave As ListBox
    Friend WithEvents lboxTipoNave As ListBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents lbComision As Label
    Friend WithEvents lbTotalDiario As Label
End Class
