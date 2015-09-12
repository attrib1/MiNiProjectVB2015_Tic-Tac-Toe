

Public Class Form1

    Dim turn As Integer = 1
    'Dim check As Class_check
    Dim check = New Class_check
    Dim showturnplayer As String = "Player : "
    Friend Shared MyInstance As Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Me.Top = 0
        'Me.Left = 0
        'Me.Height = Screen.PrimaryScreen.WorkingArea.Height
        'Me.Width = Screen.PrimaryScreen.WorkingArea.Width
        scoreP1.Text = "0"
        scoreP2.Text = "0"
        Debug.WriteLine("form ", turn.ToString)

        AxShockwaveFlash1.Movie = Application.StartupPath & "\flash\เตรียม.swf"

    End Sub

    Private Sub A1_Click(sender As Object, e As EventArgs) Handles A1.Click
        MyInstance = Me
        turn = check.Check_turn(turn)
        A1.Text = check.Player_T
        showTurnplay.Text = showturnplayer & turn
        A1.Enabled = False
        check.Check_Al()
        Debug.WriteLine("A1 ", turn.ToString)
    End Sub

    Private Sub A2_Click(sender As Object, e As EventArgs) Handles A2.Click
        MyInstance = Me
        turn = check.Check_turn(turn)
        A2.Text = check.Player_T
        showTurnplay.Text = showturnplayer & turn
        A2.Enabled = False
        check.Check_Al()
        Debug.WriteLine("A2 ", turn.ToString)
    End Sub


    Private Sub A3_Click(sender As Object, e As EventArgs) Handles A3.Click
        MyInstance = Me

        turn = check.Check_turn(turn)
        A3.Text = check.Player_T
        showTurnplay.Text = showturnplayer & turn
        A3.Enabled = False
        check.Check_Al()
        Debug.WriteLine("A2 ", turn.ToString)
    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        MyInstance = Me

        turn = check.Check_turn(turn)
        B1.Text = check.Player_T
        B1.ForeColor = Color.Red
        showTurnplay.Text = showturnplayer & turn
        check.Check_Al()
        B1.Enabled = False
        Debug.WriteLine("A2 ", turn.ToString)
    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        MyInstance = Me

        turn = check.Check_turn(turn)
        B2.Text = check.Player_T
        showTurnplay.Text = showturnplayer & turn
        B2.Enabled = False
        check.Check_Al()
        Debug.WriteLine("A2 ", turn.ToString)
    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        MyInstance = Me

        turn = check.Check_turn(turn)
        B3.Text = check.Player_T
        showTurnplay.Text = showturnplayer & turn
        B3.Enabled = False
        check.Check_Al()
        Debug.WriteLine("A2 ", turn.ToString)
    End Sub

    Private Sub C1_Click(sender As Object, e As EventArgs) Handles C1.Click
        MyInstance = Me

        turn = check.Check_turn(turn)
        C1.Text = check.Player_T
        showTurnplay.Text = showturnplayer & turn
        C1.Enabled = False
        check.Check_Al()
        Debug.WriteLine("A2 ", turn.ToString)
    End Sub

    Private Sub C2_Click(sender As Object, e As EventArgs) Handles C2.Click
        MyInstance = Me

        turn = check.Check_turn(turn)
        C2.Text = check.Player_T
        showTurnplay.Text = showturnplayer & turn
        C2.Enabled = False
        check.Check_Al()
        Debug.WriteLine("A2 ", turn.ToString)
    End Sub

    Private Sub C3_Click(sender As Object, e As EventArgs) Handles C3.Click
        MyInstance = Me

        turn = check.Check_turn(turn)
        C3.Text = check.Player_T
        showTurnplay.Text = showturnplayer & turn
        C3.Enabled = False
        check.Check_Al()
        Debug.WriteLine("A2 ", turn.ToString)
    End Sub

    Private Sub btn_Reset_Click(sender As Object, e As EventArgs) Handles btn_Reset.Click
        MyInstance = Me
        check.reset()
        turn = 1

    End Sub

    Private Sub AxShockwaveFlash1_Enter(sender As Object, e As EventArgs) Handles AxShockwaveFlash1.Enter

    End Sub
End Class
