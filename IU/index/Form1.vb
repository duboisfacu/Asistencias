Public Class Form1

    Private Sub btn_Cargar_Datos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cargar_Datos.Click
        Cargar_Datos.Show()
    End Sub

    Private Sub btn_tomar_asistencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tomar_asistencias.Click
        Seleccionador_Preceptor.Show()
    End Sub

    Private Sub btn_consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_consultar.Click
        consultar.Show()
    End Sub

End Class
