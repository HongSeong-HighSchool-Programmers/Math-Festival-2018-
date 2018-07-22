Public Class unknown
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As New Random
        Dim b As New Integer

        Label1.Text = a.Next(1, 15)
        b = Label1.Text
        If Label1.Text = b Then
            Label2.Text = "★문제 번호" & b & " 이 뽑혔습니다★"
        End If

    End Sub

    Private Sub RANDOM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles 초기화.Click
        Label2.Text = ""
    End Sub
End Class
