Public Class intro_info





    Private Sub intro_info_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        
        'classifica a lista em ordem alfabética
        ListBox1.Sorted = True
        Dim dir As New IO.DirectoryInfo("c:\login\Doriel\")
        Dim di As IO.FileInfo() = dir.GetFiles()
        Dim dra As IO.FileInfo


        For Each dra In di
            ListBox1.Items.Add(dra)
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        AxAcroPDF1.src = OpenFileDialog1.FileName
        If ListBox1.SelectedItem Then
            FileOpen("c:\login\Doriel\pass.txt\")

        End If
    End Sub

    Private Function dra() As Object
        Throw New NotImplementedException
    End Function

    
  
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        ListBox1.SelectedItem.ToString()


    End Sub

    Private Sub FileOpen(ByVal p1 As String)
        Throw New NotImplementedException
    End Sub

End Class