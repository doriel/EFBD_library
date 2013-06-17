Public Class princi_biblio

    Private Sub PictureBox1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Image = My.Resources.bt_close2
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Image = My.Resources.bt_close1
    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.Image = My.Resources.bt_min2
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Image = My.Resources.bt_min1
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        End
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        MinimizeBox = False
    End Sub

    Private Sub PictureBox4_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseHover

    End Sub

    Private Sub PictureBox5_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseEnter
        PictureBox5.Image = My.Resources.bt_html2
    End Sub

    Private Sub PictureBox5_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseLeave
        PictureBox5.Image = My.Resources.bt_html
    End Sub

    Private Sub PictureBox6_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseEnter
        PictureBox6.Image = My.Resources.bt_php2
    End Sub

    Private Sub PictureBox6_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseLeave
        PictureBox6.Image = My.Resources.bt_php
    End Sub

    Private Sub PictureBox7_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.MouseEnter
        PictureBox7.Image = My.Resources.bt_js2
    End Sub

    Private Sub PictureBox7_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.MouseLeave
        PictureBox7.Image = My.Resources.bt_js1
    End Sub

    Private Sub PictureBox8_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.MouseEnter
        PictureBox8.Image = My.Resources.bt_asp2
    End Sub

    Private Sub PictureBox8_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.MouseLeave
        PictureBox8.Image = My.Resources.bt_asp
    End Sub

    Private Sub PictureBox9_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.MouseEnter
        PictureBox9.Image = My.Resources.bt_pesq1
    End Sub

    Private Sub PictureBox9_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.MouseLeave
        PictureBox9.Image = My.Resources.bt_pesq
    End Sub

    Private Sub SobreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SobreToolStripMenuItem.Click
        Me.Visible = False
        sobre.Show()
    End Sub
End Class
