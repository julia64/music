Public Class Form1
    Dim song$() = {"", "告白气球", "九九八十一", "陪你度过漫长岁月", "美好事物", "少年锦时"}
    Dim singer$() = {"", "周杰伦", "西瓜 洛洛 方块 泥鳅", "陈奕迅", "房东的猫", "赵雷"}
    Dim lrc$() = {"", "lrc1", "lrc2", "lrc3", "lrc4", "lrc5"}
    Dim current% = 1, last% = 5

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        current = current - 1
        If current = 0 Then
            current = last
        End If
        Label1.Text = song(current)
        Label2.Text = singer(current)
        PictureBox1.Image = Image.FromFile("D:\My Documents\Visual Studio 2010\Projects\音乐播放器\" & song(current) & ".jpg")
        AxWindowsMediaPlayer1.URL = "D:\My Documents\Visual Studio 2010\Projects\音乐播放器\" & song(current) & ".mp3"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        current = current + 1
        If current = last + 1 Then
            current = 1
        End If
        Label1.Text = song(current)
        Label2.Text = singer(current)
        PictureBox1.Image = Image.FromFile("D:\My Documents\Visual Studio 2010\Projects\音乐播放器\" & song(current) & ".jpg")
        AxWindowsMediaPlayer1.URL = "D:\My Documents\Visual Studio 2010\Projects\音乐播放器\" & song(current) & ".mp3"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        current = TextBox1.Text
        Label1.Text = song(current)
        Label2.Text = singer(current)
        PictureBox1.Image = Image.FromFile("D:\My Documents\Visual Studio 2010\Projects\音乐播放器\" & song(current) & ".jpg")
        AxWindowsMediaPlayer1.URL = "D:\My Documents\Visual Studio 2010\Projects\音乐播放器\" & song(current) & ".mp3"
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        PictureBox2.Image = Image.FromFile("D:\My Documents\Visual Studio 2010\Projects\音乐播放器\" & lrc(current) & ".jpg")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim i%
        For i = 1 To last
            If song(i) = TextBox2.Text Then
                MsgBox(TextBox2.Text & "是第" & i & "首歌")
            End If
        Next
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim i%, x%
        For i = 1 To last
            If song(i) = TextBox2.Text Then
                x = i
            End If
        Next
        For i = x To last - 1
            song(i) = song(i + 1)
            singer(i) = singer(i + 1)
            lrc(i) = lrc(i + 1)
        Next
        last = last - 1
        ReDim Preserve song(last)
        ReDim Preserve singer(last)
        ReDim Preserve lrc(last)
    End Sub
End Class