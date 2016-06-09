Public Class frmMain
    Public isOn As Boolean = False
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
    Private Sub cmdHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHelp.Click
        'Shows the help dialog.
        frmHelp.ShowDialog()
    End Sub
    'This is what detects if the form is being moved
    '============================================================================================================
    Dim loc As Point = Me.Location
    'This timer updates every milisecond, updating the live position of the form
    Private Sub tmrShake_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLive.Tick
        'if the current locaton is equal to the delayed location
        If loc = Me.Location Then
            'the light stays off
            picboxLight.Visible = False
        Else 'if they are different then it turns the light on
            picboxLight.Visible = True
        End If
    End Sub
    'This timer update every 100 miliseconds, updating a delayed position of the form
    Private Sub tmrPosition_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDelay.Tick
        loc = Me.Location
    End Sub
    '===========================================================================================================
End Class
