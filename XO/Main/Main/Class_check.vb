Public Class Class_check

    Public A1, A2, A3 As String
    Public B1, B2, B3 As String
    Public C1, C2, C3 As String
    Public asd As String

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
        If A1 = "X" And A2 = "X" And A3 = "X" Then
            Form1.MyInstance.A1.BackColor = Color.Green
            Form1.MyInstance.A2.BackColor = Color.Green
            Form1.MyInstance.A3.BackColor = Color.Green
            resultAL_X()

        ElseIf B1 = "X" And B2 = "X" And B3 = "X" Then
            Form1.MyInstance.B1.BackColor = Color.Green
            Form1.MyInstance.B2.BackColor = Color.Green
            Form1.MyInstance.B3.BackColor = Color.Green
            resultAL_X()
        ElseIf C1 = "X" And C2 = "X" And C3 = "X" Then
            Form1.MyInstance.C1.BackColor = Color.Green
            Form1.MyInstance.C2.BackColor = Color.Green
            Form1.MyInstance.C3.BackColor = Color.Green
            resultAL_X()

            'line vertical X
        ElseIf A1 = "X" And B1 = "X" And C1 = "X" Then
            Form1.MyInstance.A1.BackColor = Color.Green
            Form1.MyInstance.B1.BackColor = Color.Green
            Form1.MyInstance.C1.BackColor = Color.Green
            resultAL_X()
        ElseIf A2 = "X" And B2 = "X" And C2 = "X" Then
            Form1.MyInstance.A2.BackColor = Color.Green
            Form1.MyInstance.B2.BackColor = Color.Green
            Form1.MyInstance.C2.BackColor = Color.Green
            resultAL_X()
        ElseIf A3 = "X" And B3 = "X" And C3 = "X" Then
            Form1.MyInstance.A3.BackColor = Color.Green
            Form1.MyInstance.B3.BackColor = Color.Green
            Form1.MyInstance.C3.BackColor = Color.Green
            resultAL_X()

            'line diagonal X
        ElseIf A1 = "X" And B2 = "X" And C3 = "X" Then
            Form1.MyInstance.A1.BackColor = Color.Green
            Form1.MyInstance.B2.BackColor = Color.Green
            Form1.MyInstance.C3.BackColor = Color.Green
            resultAL_X()
        ElseIf C1 = "X" And B2 = "X" And A3 = "X" Then
            Form1.MyInstance.C1.BackColor = Color.Green
            Form1.MyInstance.B2.BackColor = Color.Green
            Form1.MyInstance.A3.BackColor = Color.Green
            resultAL_X()
        End If

        Check_Al_O()

    End Function
    Private Function Check_Al_O()
        'line horizon O
        If A1 = "O" And A2 = "O" And A3 = "O" Then
            Form1.MyInstance.A1.BackColor = Color.Green
            Form1.MyInstance.A2.BackColor = Color.Green
            Form1.MyInstance.A3.BackColor = Color.Green
            resultAL_O()

        ElseIf B1 = "O" And B2 = "O" And B3 = "O" Then
            Form1.MyInstance.B1.BackColor = Color.Green
            Form1.MyInstance.B2.BackColor = Color.Green
            Form1.MyInstance.B3.BackColor = Color.Green
            resultAL_O()
        ElseIf C1 = "O" And C2 = "O" And C3 = "O" Then
            Form1.MyInstance.C1.BackColor = Color.Green
            Form1.MyInstance.C2.BackColor = Color.Green
            Form1.MyInstance.C3.BackColor = Color.Green
            resultAL_O()

            'line vertical O
        ElseIf A1 = "O" And B1 = "O" And C1 = "O" Then
            Form1.MyInstance.A1.BackColor = Color.Green
            Form1.MyInstance.B1.BackColor = Color.Green
            Form1.MyInstance.C1.BackColor = Color.Green
            resultAL_O()
        ElseIf A2 = "O" And B2 = "O" And C2 = "O" Then
            Form1.MyInstance.A2.BackColor = Color.Green
            Form1.MyInstance.B2.BackColor = Color.Green
            Form1.MyInstance.C2.BackColor = Color.Green
            resultAL_O()
        ElseIf A3 = "O" And B3 = "O" And C3 = "O" Then
            Form1.MyInstance.A3.BackColor = Color.Green
            Form1.MyInstance.B3.BackColor = Color.Green
            Form1.MyInstance.C3.BackColor = Color.Green
            resultAL_O()

            'line diagonal O
        ElseIf A1 = "O" And B2 = "O" And C3 = "O" Then
            Form1.MyInstance.A1.BackColor = Color.Green
            Form1.MyInstance.B2.BackColor = Color.Green
            Form1.MyInstance.C3.BackColor = Color.Green
            resultAL_O()
        ElseIf C1 = "O" And B2 = "O" And A3 = "O" Then
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


        ' Form1.MyInstance.A1.BackgroundImage = Me.none

        Form1.MyInstance.A1.Enabled = True
        Form1.MyInstance.A2.Enabled = True
        Form1.MyInstance.A3.Enabled = True
        Form1.MyInstance.B1.Enabled = True
        Form1.MyInstance.B2.Enabled = True
        Form1.MyInstance.B3.Enabled = True
        Form1.MyInstance.C1.Enabled = True
        Form1.MyInstance.C2.Enabled = True
        Form1.MyInstance.C3.Enabled = True
        Form1.MyInstance.A1.BackgroundImage = Nothing
        Form1.MyInstance.A2.BackgroundImage = Nothing
        Form1.MyInstance.A3.BackgroundImage = Nothing
        Form1.MyInstance.B1.BackgroundImage = Nothing
        Form1.MyInstance.B2.BackgroundImage = Nothing
        Form1.MyInstance.B3.BackgroundImage = Nothing
        Form1.MyInstance.C1.BackgroundImage = Nothing
        Form1.MyInstance.C2.BackgroundImage = Nothing
        Form1.MyInstance.C3.BackgroundImage = Nothing

        Form1.MyInstance.A1.BackColor = Color.Transparent
        Form1.MyInstance.A2.BackColor = Color.Transparent
        Form1.MyInstance.A3.BackColor = Color.Transparent
        Form1.MyInstance.B1.BackColor = Color.Transparent
        Form1.MyInstance.B2.BackColor = Color.Transparent
        Form1.MyInstance.B3.BackColor = Color.Transparent
        Form1.MyInstance.C1.BackColor = Color.Transparent
        Form1.MyInstance.C2.BackColor = Color.Transparent
        Form1.MyInstance.C3.BackColor = Color.Transparent

        A1 = ""
        A2 = ""
        A3 = ""
        B1 = ""
        B2 = ""
        B3 = ""
        C1 = ""
        C2 = ""
        C3 = ""

        Form1.MyInstance.showTurnplay.Text = "Player : 1"
        'Form1.MyInstance.scoreP1.Text = "0"



    End Function
    Public Function resultAL_X()
        Try
            MsgBox("Dog Win !!!")
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
        MsgBox("Cat Win !!!")
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
