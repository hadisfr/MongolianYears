Public Class frmmy

    Private Sub txtyear_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtyear.TextChanged
        If Val(txtyear.Text) <= 0 Then MsgBox("اطلاعات اشتباه است!", MsgBoxStyle.Critical, "Error: Bad Data Type!") : txtyear.Text = "1"
    End Sub

    Private Sub Enter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Enter.Click
        Dim temp As Byte
        temp = (Val(txtyear.Text) + 6) Mod 12
        Select Case temp
            Case 1
                lbln.Text = "موش"
                pic.ImageLocation = CurDir() & "\pic\mouse.jpg"
            Case 2
                lbln.Text = "گاو"
                pic.ImageLocation = CurDir() & "\pic\cow.jpg"
            Case 3
                lbln.Text = "پلنگ"
                pic.ImageLocation = CurDir() & "\pic\leopard.jpg"
            Case 4
                lbln.Text = "خرگوش"
                pic.ImageLocation = CurDir() & "\pic\rabbit.jpg"
            Case 5
                lbln.Text = "نهنگ"
                pic.ImageLocation = CurDir() & "\pic\whale.jpg"
            Case 6
                lbln.Text = "مار"
                pic.ImageLocation = CurDir() & "\pic\snake.jpg"
            Case 7
                lbln.Text = "اسب"
                pic.ImageLocation = CurDir() & "\pic\horse.jpg"
            Case 8
                lbln.Text = "گوسفند"
                pic.ImageLocation = CurDir() & "\pic\sheep.jpg"
            Case 9
                lbln.Text = "میمون"
                pic.ImageLocation = CurDir() & "\pic\monkey.jpg"
            Case 10
                lbln.Text = "مرغ"
                pic.ImageLocation = CurDir() & "\pic\hen.jpg"
            Case 11
                lbln.Text = "سگ"
                pic.ImageLocation = CurDir() & "\pic\dog.jpg"
            Case 0
                lbln.Text = "خوک"
                pic.ImageLocation = CurDir() & "\pic\pig.jpg"
        End Select
    End Sub

    Private Sub mnuend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuend.Click
        End
    End Sub

    Private Sub mnuabout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuabout.Click
        frmabout.Show()
    End Sub
End Class
