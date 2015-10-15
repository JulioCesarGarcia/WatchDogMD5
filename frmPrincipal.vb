Public Class frmPrincipal
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tslblVersion.Text = My.Application.Info.Version.ToString
    End Sub
End Class
