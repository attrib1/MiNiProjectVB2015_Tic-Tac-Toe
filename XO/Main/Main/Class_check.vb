Public Class Class_check

    Public Player_T As String




    Public Function Check_turn(turn As Integer) As Integer
        If turn = 1 Then
            Player_T = "X"
            Return turn + 1
        Else
            Player_T = "O"
            Return turn - 1
        End If
    End Function

    Public Function Check_Al()
        'line horizon X
        If Form1.MyInstance.A1.Text = "X" And Form1.MyInstance.A2.Text = "X" And Form1.MyInstance.A3.Text = "X" Then
            Form1.MyInstance.A1.BackColor = Color.Green
            Form1.MyInstance.A2.BackColor = Color.Green
            Form1.MyInstance.A3.BackColor = Color.Green
            resultAL_X()

        ElseIf Form1.MyInstance.B1.Text = "X" And Form1.MyInstance.B2.Text = "X" And Form1.MyInstance.B3.Text = "X" Then
            Form1.MyInstance.B1.BackColor = Color.Green
            Form1.MyInstance.B2.BackColor = Color.Green
            Form1.MyInstance.B3.BackColor = Color.Green
            resultAL_X()
        ElseIf Form1.MyInstance.C1.Text = "X" And Form1.MyInstance.C2.Text = "X" And Form1.MyInstance.C3.Text = "X" Then
            Form1.MyInstance.C1.BackColor = Color.Green
            Form1.MyInstance.C2.BackColor = Color.Green
            Form1.MyInstance.C3.BackColor = Color.Green
            resultAL_X()

            'line vertical X
        ElseIf Form1.MyInstance.A1.Text = "X" And Form1.MyInstance.B1.Text = "X" And Form1.MyInstance.C1.Text = "X" Then
            Form1.MyInstance.A1.BackColor = Color.Green
            Form1.MyInstance.B1.BackColor = Color.Green
            Form1.MyInstance.C1.BackColor = Color.Green
            resultAL_X()
        ElseIf Form1.MyInstance.A2.Text = "X" And Form1.MyInstance.B2.Text = "X" And Form1.MyInstance.C2.Text = "X" Then
            Form1.MyInstance.A2.BackColor = Color.Green
            Form1.MyInstance.B2.BackColor = Color.Green
            Form1.MyInstance.C2.BackColor = Color.Green
            resultAL_X()
        ElseIf Form1.MyInstance.A3.Text = "X" And Form1.MyInstance.B3.Text = "X" And Form1.MyInstance.C3.Text = "X" Then
            Form1.MyInstance.A3.BackColor = Color.Green
            Form1.MyInstance.B3.BackColor = Color.Green
            Form1.MyInstance.C3.BackColor = Color.Green
            resultAL_X()

            'line diagonal X
        ElseIf Form1.MyInstance.A1.Text = "X" And Form1.MyInstance.B2.Text = "X" And Form1.MyInstance.C3.Text = "X" Then
            Form1.MyInstance.A1.BackColor = Color.Green
            Form1.MyInstance.B2.BackColor = Color.Green
            Form1.MyInstance.C3.BackColor = Color.Green
            resultAL_X()
        ElseIf Form1.MyInstance.C1.Text = "X" And Form1.MyInstance.B2.Text = "X" And Form1.MyInstance.A3.Text = "X" Then
            Form1.MyInstance.C1.BackColor = Color.Green
            Form1.MyInstance.B2.BackColor = Color.Green
            Form1.MyInstance.A3.BackColor = Color.Green
            resultAL_X()
        End If

        Check_Al_O()

    End Function
    Private Function Check_Al_O()
        'line horizon O
        If Form1.MyInstance.A1.Text = "O" And Form1.MyInstance.A2.Text = "O" And Form1.MyInstance.A3.Text = "O" Then
            Form1.MyInstance.A1.BackColor = Color.Green
            Form1.MyInstance.A2.BackColor = Color.Green
            Form1.MyInstance.A3.BackColor = Color.Green
            resultAL_O()

        ElseIf Form1.MyInstance.B1.Text = "O" And Form1.MyInstance.B2.Text = "O" And Form1.MyInstance.B3.Text = "O" Then
            Form1.MyInstance.B1.BackColor = Color.Green
            Form1.MyInstance.B2.BackColor = Color.Green
            Form1.MyInstance.B3.BackColor = Color.Green
            resultAL_O()
        ElseIf Form1.MyInstance.C1.Text = "O" And Form1.MyInstance.C2.Text = "O" And Form1.MyInstance.C3.Text = "O" Then
            Form1.MyInstance.C1.BackColor = Color.Green
            Form1.MyInstance.C2.BackColor = Color.Green
            Form1.MyInstance.C3.BackColor = Color.Green
            resultAL_O()

            'line vertical O
        ElseIf Form1.MyInstance.A1.Text = "O" And Form1.MyInstance.B1.Text = "O" And Form1.MyInstance.C1.Text = "O" Then
            Form1.MyInstance.A1.BackColor = Color.Green
            Form1.MyInstance.B1.BackColor = Color.Green
            Form1.MyInstance.C1.BackColor = Color.Green
            resultAL_O()
        ElseIf Form1.MyInstance.A2.Text = "O" And Form1.MyInstance.B2.Text = "O" And Form1.MyInstance.C2.Text = "O" Then
            Form1.MyInstance.A2.BackColor = Color.Green
            Form1.MyInstance.B2.BackColor = Color.Green
            Form1.MyInstance.C2.BackColor = Color.Green
            resultAL_O()
        ElseIf Form1.MyInstance.A3.Text = "O" And Form1.MyInstance.B3.Text = "O" And Form1.MyInstance.C3.Text = "O" Then
            Form1.MyInstance.A3.BackColor = Color.Green
            Form1.MyInstance.B3.BackColor = Color.Green
            Form1.MyInstance.C3.BackColor = Color.Green
            resultAL_O()

            'line diagonal O
        ElseIf Form1.MyInstance.A1.Text = "O" And Form1.MyInstance.B2.Text = "O" And Form1.MyInstance.C3.Text = "O" Then
            Form1.MyInstance.A1.BackColor = Color.Green
            Form1.MyInstance.B2.BackColor = Color.Green
            Form1.MyInstance.C3.BackColor = Color.Green
            resultAL_O()
        ElseIf Form1.MyInstance.C1.Text = "O" And Form1.MyInstance.B2.Text = "O" And Form1.MyInstance.A3.Text = "O" Then
            Form1.MyInstance.C1.BackColor = Color.Green
            Form1.MyInstance.B2.BackColor = Color.Green
            Form1.MyInstance.A3.BackColor = Color.Green
            resultAL_O()
        End If

    End Function

    Public Function reset()
        Form1.MyInstance.AxShockwaveFlash1.Visible = True
        play_intro()
        Form1.MyInstance.A1.Text = ""
        Form1.MyInstance.A2.Text = ""
        Form1.MyInstance.A3.Text = ""
        Form1.MyInstance.B1.Text = ""
        Form1.MyInstance.B2.Text = ""
        Form1.MyInstance.B3.Text = ""
        Form1.MyInstance.C1.Text = ""
        Form1.MyInstance.C2.Text = ""
        Form1.MyInstance.C3.Text = ""

        Form1.MyInstance.A1.Enabled = True
        Form1.MyInstance.A2.Enabled = True
        Form1.MyInstance.A3.Enabled = True
        Form1.MyInstance.B1.Enabled = True
        Form1.MyInstance.B2.Enabled = True
        Form1.MyInstance.B3.Enabled = True
        Form1.MyInstance.C1.Enabled = True
        Form1.MyInstance.C2.Enabled = True
        Form1.MyInstance.C3.Enabled = True

        Form1.MyInstance.A1.BackColor = Color.Transparent
        Form1.MyInstance.A2.BackColor = Color.Transparent
        Form1.MyInstance.A3.BackColor = Color.Transparent
        Form1.MyInstance.B1.BackColor = Color.Transparent
        Form1.MyInstance.B2.BackColor = Color.Transparent
        Form1.MyInstance.B3.BackColor = Color.Transparent
        Form1.MyInstance.C1.BackColor = Color.Transparent
        Form1.MyInstance.C2.BackColor = Color.Transparent
        Form1.MyInstance.C3.BackColor = Color.Transparent


        Form1.MyInstance.showTurnplay.Text = "Player : 1"
        'Form1.MyInstance.scoreP1.Text = "0"



    End Function
    Public Function resultAL_X()
        Try
            MsgBox("X Win !!!")
            'X คือ แดง
            Form1.MyInstance.scoreP1.Text += 1
            If Val(Form1.MyInstance.scoreP1.Text) = 3 Then
                play_flash_X_die()
            Else
                play_flash_X()
            End If

            Form1.MyInstance.A1.Enabled = False
            Form1.MyInstance.A2.Enabled = False
            Form1.MyInstance.A3.Enabled = False
            Form1.MyInstance.B1.Enabled = False
            Form1.MyInstance.B2.Enabled = False
            Form1.MyInstance.B3.Enabled = False
            Form1.MyInstance.C1.Enabled = False
            Form1.MyInstance.C2.Enabled = False
            Form1.MyInstance.C3.Enabled = False
        Catch

            MsgBox("error")
            Return False
        Finally
            ' If Not cn Is Nothing Then cn.Close()
        End Try
    End Function



    Public Function resultAL_O()
        MsgBox("O Win !!!")
        ' O คือ น้ำเงิน
        Form1.MyInstance.scoreP2.Text += 1
        If Val(Form1.MyInstance.scoreP2.Text) = 3 Then
            play_flash_O_die()
        Else
            play_flash_O()
        End If

        Form1.MyInstance.A1.Enabled = False
        Form1.MyInstance.A2.Enabled = False
        Form1.MyInstance.A3.Enabled = False
        Form1.MyInstance.B1.Enabled = False
        Form1.MyInstance.B2.Enabled = False
        Form1.MyInstance.B3.Enabled = False
        Form1.MyInstance.C1.Enabled = False
        Form1.MyInstance.C2.Enabled = False
        Form1.MyInstance.C3.Enabled = False
    End Function

    Private Sub play_flash_O_die()

        'Form1.MyInstance.AxShockwaveFlash1.Movie = Application.StartupPath & "\..\..\flash\red_die.swf"
        Form1.MyInstance.AxShockwaveFlash1.LoadMovie(0, My.Application.Info.DirectoryPath & "\flash" & "red_die.swf")
        Form1.MyInstance.AxShockwaveFlash1.Play()

        Form1.MyInstance.scoreP1.Text = 0
        Form1.MyInstance.scoreP2.Text = 0

    End Sub

    Private Sub play_flash_O()

        'Form1.MyInstance.AxShockwaveFlash1.Movie = Application.StartupPath & "\..\..\flash\blue_f.swf"
        Form1.MyInstance.AxShockwaveFlash1.LoadMovie(0, My.Application.Info.DirectoryPath & "\flash" & "blue_f.swf")
        Form1.MyInstance.AxShockwaveFlash1.Play()


    End Sub

    Private Function play_flash_X()

        '  Form1.MyInstance.AxShockwaveFlash1.Movie = Application.StartupPath & "\..\..\flash\red_f.swf"
        Form1.MyInstance.AxShockwaveFlash1.LoadMovie(0, My.Application.Info.DirectoryPath & "\flash" & "red_f.swf")
        Form1.MyInstance.AxShockwaveFlash1.Play()


    End Function

    Public Function play_intro()
        Try

            ' Form1.MyInstance.AxShockwaveFlash1.Movie = Application.StartupPath & "\..\..\flash\intro.swf"
            Form1.MyInstance.AxShockwaveFlash1.LoadMovie(0, My.Application.Info.DirectoryPath & "\flash" & "intro_d.swf")
            Form1.MyInstance.AxShockwaveFlash1.Play()


        Catch

            MsgBox("error")
            Return False
        Finally
            ' If Not cn Is Nothing Then cn.Close()
        End Try

    End Function

    Private Sub play_flash_X_die()

        'Form1.MyInstance.AxShockwaveFlash1.Movie = Application.StartupPath & "\..\..\flash\blue_die.swf"

        Form1.MyInstance.AxShockwaveFlash1.LoadMovie(0, My.Application.Info.DirectoryPath & "\flash" & "blue_die.swf")
        Form1.MyInstance.AxShockwaveFlash1.Play()

        Form1.MyInstance.scoreP1.Text = 0
        Form1.MyInstance.scoreP2.Text = 0

    End Sub

End Class
