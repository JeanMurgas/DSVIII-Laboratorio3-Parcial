<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CreacionCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatosClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepositoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RetiroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreacionCuentaToolStripMenuItem, Me.DatosClienteToolStripMenuItem, Me.DepositoToolStripMenuItem, Me.RetiroToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CreacionCuentaToolStripMenuItem
        '
        Me.CreacionCuentaToolStripMenuItem.Name = "CreacionCuentaToolStripMenuItem"
        Me.CreacionCuentaToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.CreacionCuentaToolStripMenuItem.Text = "CreacionCuenta"
        '
        'DatosClienteToolStripMenuItem
        '
        Me.DatosClienteToolStripMenuItem.Name = "DatosClienteToolStripMenuItem"
        Me.DatosClienteToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.DatosClienteToolStripMenuItem.Text = "DatosCliente"
        '
        'DepositoToolStripMenuItem
        '
        Me.DepositoToolStripMenuItem.Name = "DepositoToolStripMenuItem"
        Me.DepositoToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.DepositoToolStripMenuItem.Text = "Deposito"
        '
        'RetiroToolStripMenuItem
        '
        Me.RetiroToolStripMenuItem.Name = "RetiroToolStripMenuItem"
        Me.RetiroToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.RetiroToolStripMenuItem.Text = "Retiro"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CreacionCuentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatosClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepositoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RetiroToolStripMenuItem As ToolStripMenuItem
End Class
