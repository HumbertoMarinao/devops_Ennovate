Public Class Form1
    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        Label1.Text = Devops_Ennovate.BLL.Metodo.MostrarConneccion()
    End Sub
End Class
