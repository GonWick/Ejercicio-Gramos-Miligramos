Public Class Form1
    Dim Kg, gr, mgr As Double
    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Close()
    End Sub

    Private Sub ButtonCalcular_Click(sender As Object, e As EventArgs) Handles ButtonCalcular.Click
        LabelGrMgr.Text = "Pasar de Kilogramos a:"
        If TextBoxKgr.Text <> "" Then
            Kg = TextBoxKgr.Text
            gr = Kg * 1000
            mgr = gr * 1000
            TextBoxGr.Text = gr
            TextBoxMgr.Text = mgr
        ElseIf TextBoxGr.Text <> "" Then
            gr = TextBoxGr.Text
            mgr = gr * 1000
            Kg = gr / 1000
            TextBoxMgr.Text = mgr
            TextBoxKgr.Text = Kg
        ElseIf TextBoxMgr.Text <> "" Then
            mgr = TextBoxMgr.Text
            gr = mgr / 1000
            Kg = gr / 1000
            TextBoxGr.Text = gr
            TextBoxKgr.Text = Kg
        End If
        TextBoxGr.Enabled = False
        TextBoxMgr.Enabled = False
        TextBoxKgr.Enabled = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        LabelGrMgr.Text = "Pasar de Gramos a Miligramos y Kilogramos"
        TextBoxKgr.Text = ""
        TextBoxGr.Text = ""
        TextBoxMgr.Text = ""
        TextBoxKgr.Enabled = False
        TextBoxGr.Enabled = True
    End Sub

    Private Sub PictureBox2_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox2.DoubleClick
        LabelGrMgr.Text = "Pasar de Miligramos a Gramos y Kilogramos"
        TextBoxKgr.Text = ""
        TextBoxGr.Text = ""
        TextBoxMgr.Text = ""
        TextBoxKgr.Enabled = False
        TextBoxGr.Enabled = False
        TextBoxMgr.Enabled = True
    End Sub
End Class
