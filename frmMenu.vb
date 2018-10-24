Public Class frmMenu
    Private Sub btnCad_Click(sender As Object, e As EventArgs) Handles btnCad.Click
        frmFormulario.Show()
        Me.Hide()
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub
End Class