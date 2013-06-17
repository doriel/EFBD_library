Public Class Form1
    Public ID As Integer
    Public Nome As String
    Public Data_de_Nascimento As Date
    Public BI As String
    Public País As String
    Public Bairro As String
    Public Password As String
    Public screen As String
    Public screen1 As String
    Public msg As String


    Private Sub UtilizadorBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.UtilizadorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UtilizadoresDataSet)



    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UtilizadoresDataSet.utilizador' table. You can move, or remove it, as needed.
        Me.UtilizadorTableAdapter.Fill(Me.UtilizadoresDataSet.utilizador)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        screen = TextBox1.Text
        screen1 = TextBox2.Text
        msg = Val(screen) + Val(screen1)
        MsgBox(msg)
        Select Case msg
            Case msg > 10
                MsgBox("++")
            Case msg < 10
                MsgBox("--")
            Case Else
        End Select
    End Sub
End Class
