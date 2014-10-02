Public Class Form1

    Private Sub btbCross_Click(sender As Object, e As EventArgs) Handles btbCross.Click
        Dim strName As String = "Braden"
        Dim strQuest As String = "To seek the holy grail"
        Dim strColor As String = "Red"
        If strName = "Braden" Then
            Me.lblName2.Text = "You may pass"
        End If
        If strQuest = "To seek the holy grail" Then
            Me.lblQuest2.Text = "You may pass"
        End If
        If strColor = "Red" Then
            Me.lblColor2.Text = "You may cross the bridge"
        End If


    End Sub

    Private Sub lbl1_Click(sender As Object, e As EventArgs) Handles lblName.Click

    End Sub
End Class
