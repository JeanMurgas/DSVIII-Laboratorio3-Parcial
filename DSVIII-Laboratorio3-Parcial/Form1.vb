Public Class Form1
    Private Sub CreacionCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreacionCuentaToolStripMenuItem.Click
        frmCreacionCuentas.Show()
    End Sub

    Private Sub DatosClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosClienteToolStripMenuItem.Click
        frmDatosCliente.Show()
    End Sub

    Private Sub DepositoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepositoToolStripMenuItem.Click
        frmDeposito.Show()
    End Sub

    Private Sub RetiroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetiroToolStripMenuItem.Click
        frmRetiro.Show()
    End Sub
End Class
