

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

        Dim appPath1 As String = My.Application.Info.DirectoryPath & "\flash" & "intro_d.swf"
        My.Computer.FileSystem.WriteAllBytes(appPath1, My.Resources.intro_d, False)

        Dim appPath2 As String = My.Application.Info.DirectoryPath & "\flash" & "blue_f.swf"
        My.Computer.FileSystem.WriteAllBytes(appPath2, My.Resources.blue_f, False)

        Dim appPath3 As String = My.Application.Info.DirectoryPath & "\flash" & "red_f.swf"
        My.Computer.FileSystem.WriteAllBytes(appPath3, My.Resources.red_f, False)

        Dim appPath4 As String = My.Application.Info.DirectoryPath & "\flash" & "blue_die.swf"
        My.Computer.FileSystem.WriteAllBytes(appPath4, My.Resources.blue_die, False)

        Dim appPath5 As String = My.Application.Info.DirectoryPath & "\flash" & "red_die.swf"
        My.Computer.FileSystem.WriteAllBytes(appPath5, My.Resources.red_die, False)

        AxShockwaveFlash1.LoadMovie(0, My.Application.Info.DirectoryPath & "\flash" & "intro_d.swf")
        AxShockwaveFlash1.Play()

        'AxShockwaveFlash1.Movie = Application.StartupPath & (appPath,My.Resources.intro_d , False)





    End Sub

    Private Sub A1_Click(sender As Object, e As EventArgs) Handles A1.Click
        MyInstance = Me
        turn = check.Check_turn(turn)
        If turn = 2 Then
            A1.BackgroundImage = My.Resources.x
            A1.BackgroundImageLayout = ImageLayout.Center
            check.A1 = check.Player_T

        Else
            A1.BackgroundImageLayout = ImageLayout.Center
            A1.BackgroundImage = My.Resources.o
            check.A1 = check.Player_T

        End If

        If turn = 1 Then
            showTurnplay.Text = showturnplayer & "หมา"
        Else
            showTurnplay.Text = showturnplayer & "แมว"
        End If

        A1.Enabled = False
        check.Check_Al()
        Debug.WriteLine("A1 ", turn.ToString)
    End Sub

    Private Sub A2_Click(sender As Object, e As EventArgs) Handles A2.Click
        MyInstance = Me
        turn = check.Check_turn(turn)

        If turn = 2 Then
            A2.BackgroundImage = My.Resources.x
            A2.BackgroundImageLayout = ImageLayout.Center
            check.A2 = check.Player_T

        Else
            A2.BackgroundImageLayout = ImageLayout.Center
            A2.BackgroundImage = My.Resources.o
            check.A2 = check.Player_T

        End If

        If turn = 1 Then
            showTurnplay.Text = showturnplayer & "หมา"
        Else
            showTurnplay.Text = showturnplayer & "แมว"
        End If

        A2.Enabled = False
        check.Check_Al()
        Debug.WriteLine("A2 ", turn.ToString)
    End Sub


    Private Sub A3_Click(sender As Object, e As EventArgs) Handles A3.Click
        MyInstance = Me
        turn = check.Check_turn(turn)

        If turn = 2 Then
            A3.BackgroundImage = My.Resources.x
            A3.BackgroundImageLayout = ImageLayout.Center
            check.A3 = check.Player_T

        Else
            A3.BackgroundImageLayout = ImageLayout.Center
            A3.BackgroundImage = My.Resources.o
            check.A3 = check.Player_T

        End If

        If turn = 1 Then
            showTurnplay.Text = showturnplayer & "หมา"
        Else
            showTurnplay.Text = showturnplayer & "แมว"
        End If
        A3.Enabled = False
        check.Check_Al()
        Debug.WriteLine("A2 ", turn.ToString)
    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        MyInstance = Me
        turn = check.Check_turn(turn)

        If turn = 2 Then
            B1.BackgroundImage = My.Resources.x
            B1.BackgroundImageLayout = ImageLayout.Center
            check.B1 = check.Player_T

        Else
            B1.BackgroundImageLayout = ImageLayout.Center
            B1.BackgroundImage = My.Resources.o
            check.B1 = check.Player_T

        End If

        If turn = 1 Then
            showTurnplay.Text = showturnplayer & "หมา"
        Else
            showTurnplay.Text = showturnplayer & "แมว"
        End If
        check.Check_Al()
        B1.Enabled = False
        Debug.WriteLine("A2 ", turn.ToString)
    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        MyInstance = Me

        turn = check.Check_turn(turn)

        If turn = 2 Then
            B2.BackgroundImage = My.Resources.x
            B2.BackgroundImageLayout = ImageLayout.Center
            check.B2 = check.Player_T

        Else
            B2.BackgroundImageLayout = ImageLayout.Center
            B2.BackgroundImage = My.Resources.o
            check.B2 = check.Player_T

        End If

        If turn = 1 Then
            showTurnplay.Text = showturnplayer & "หมา"
        Else
            showTurnplay.Text = showturnplayer & "แมว"
        End If
        B2.Enabled = False
        check.Check_Al()
        Debug.WriteLine("A2 ", turn.ToString)
    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        MyInstance = Me

        turn = check.Check_turn(turn)

        If turn = 2 Then
            B3.BackgroundImage = My.Resources.x
            B3.BackgroundImageLayout = ImageLayout.Center
            check.B3 = check.Player_T

        Else
            B3.BackgroundImageLayout = ImageLayout.Center
            B3.BackgroundImage = My.Resources.o
            check.B3 = check.Player_T

        End If

        If turn = 1 Then
            showTurnplay.Text = showturnplayer & "หมา"
        Else
            showTurnplay.Text = showturnplayer & "แมว"
        End If
        B3.Enabled = False
        check.Check_Al()
        Debug.WriteLine("A2 ", turn.ToString)
    End Sub

    Private Sub C1_Click(sender As Object, e As EventArgs) Handles C1.Click
        MyInstance = Me

        turn = check.Check_turn(turn)
        If turn = 2 Then
            C1.BackgroundImage = My.Resources.x
            C1.BackgroundImageLayout = ImageLayout.Center
            check.C1 = check.Player_T

        Else
            C1.BackgroundImageLayout = ImageLayout.Center
            C1.BackgroundImage = My.Resources.o
            check.C1 = check.Player_T

        End If
        If turn = 1 Then
            showTurnplay.Text = showturnplayer & "หมา"
        Else
            showTurnplay.Text = showturnplayer & "แมว"
        End If
        C1.Enabled = False
        check.Check_Al()
        Debug.WriteLine("A2 ", turn.ToString)
    End Sub

    Private Sub C2_Click(sender As Object, e As EventArgs) Handles C2.Click
        MyInstance = Me

        turn = check.Check_turn(turn)

        If turn = 2 Then
            C2.BackgroundImage = My.Resources.x
            C2.BackgroundImageLayout = ImageLayout.Center
            check.C2 = check.Player_T

        Else
            C2.BackgroundImageLayout = ImageLayout.Center
            C2.BackgroundImage = My.Resources.o
            check.C2 = check.Player_T

        End If
        If turn = 1 Then
            showTurnplay.Text = showturnplayer & "หมา"
        Else
            showTurnplay.Text = showturnplayer & "แมว"
        End If
        C2.Enabled = False
        check.Check_Al()
        Debug.WriteLine("A2 ", turn.ToString)
    End Sub

    Private Sub C3_Click(sender As Object, e As EventArgs) Handles C3.Click
        MyInstance = Me

        turn = check.Check_turn(turn)

        If turn = 2 Then
            C3.BackgroundImage = My.Resources.x
            C3.BackgroundImageLayout = ImageLayout.Center
            check.C3 = check.Player_T

        Else
            C3.BackgroundImageLayout = ImageLayout.Center
            C3.BackgroundImage = My.Resources.o
            check.C3 = check.Player_T

        End If
        If turn = 1 Then
            showTurnplay.Text = showturnplayer & "หมา"
        Else
            showTurnplay.Text = showturnplayer & "แมว"
        End If
        C3.Enabled = False
        check.Check_Al()
        Debug.WriteLine("A2 ", turn.ToString)
    End Sub

    Private Sub btn_Reset_Click(sender As Object, e As EventArgs) Handles btn_Reset.Click
        MyInstance = Me
        check.reset()
        turn = 1

    End Sub

    Private Sub AxShockwaveFlash1_Enter(sender As Object, e As EventArgs)

    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        AxShockwaveFlash1.Visible = False
    End Sub


End Class
