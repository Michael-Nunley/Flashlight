Public Class frmSplash
    Dim count As Byte
    Private Sub frmSplash_Load(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Load
        'while the count is below 250
        Do While count < 250
            'add one to count
            count += 1
        Loop
        'Once this is done the splash screen will go away.
    End Sub
End Class
