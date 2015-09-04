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
            resultAL_X()

        ElseIf Form1.MyInstance.B1.Text = "X" And Form1.MyInstance.B2.Text = "X" And Form1.MyInstance.B3.Text = "X" Then
            resultAL_X()
        ElseIf Form1.MyInstance.C1.Text = "X" And Form1.MyInstance.C2.Text = "X" And Form1.MyInstance.C3.Text = "X" Then
            resultAL_X()

            'line vertical X
        ElseIf Form1.MyInstance.A1.Text = "X" And Form1.MyInstance.B1.Text = "X" And Form1.MyInstance.C1.Text = "X" Then
            resultAL_X()
        ElseIf Form1.MyInstance.A2.Text = "X" And Form1.MyInstance.B2.Text = "X" And Form1.MyInstance.C2.Text = "X" Then
            resultAL_X()
        ElseIf Form1.MyInstance.A3.Text = "X" And Form1.MyInstance.B3.Text = "X" And Form1.MyInstance.C3.Text = "X" Then
            resultAL_X()

            'line diagonal X
        ElseIf Form1.MyInstance.A1.Text = "X" And Form1.MyInstance.B2.Text = "X" And Form1.MyInstance.C3.Text = "X" Then
            resultAL_X()
        ElseIf Form1.MyInstance.C1.Text = "X" And Form1.MyInstance.B2.Text = "X" And Form1.MyInstance.A3.Text = "X" Then
            resultAL_X()
        End If

        Check_Al_O()

    End Function
    Private Function Check_Al_O()
        'line horizon O
        If Form1.MyInstance.A1.Text = "O" And Form1.MyInstance.A2.Text = "O" And Form1.MyInstance.A3.Text = "O" Then
            resultAL_O()
        ElseIf Form1.MyInstance.B1.Text = "O" And Form1.MyInstance.B2.Text = "O" And Form1.MyInstance.B3.Text = "O" Then
            resultAL_O()
        ElseIf Form1.MyInstance.C1.Text = "O" And Form1.MyInstance.C2.Text = "O" And Form1.MyInstance.C3.Text = "O" Then
            resultAL_O()

            'line vertical O
        ElseIf Form1.MyInstance.A1.Text = "O" And Form1.MyInstance.B1.Text = "O" And Form1.MyInstance.C1.Text = "O" Then
            resultAL_O()
        ElseIf Form1.MyInstance.A2.Text = "O" And Form1.MyInstance.B2.Text = "O" And Form1.MyInstance.C2.Text = "O" Then
            resultAL_O()
        ElseIf Form1.MyInstance.A3.Text = "O" And Form1.MyInstance.B3.Text = "O" And Form1.MyInstance.C3.Text = "O" Then
            resultAL_O()

            'line diagonal O
        ElseIf Form1.MyInstance.A1.Text = "O" And Form1.MyInstance.B2.Text = "O" And Form1.MyInstance.C3.Text = "O" Then
            resultAL_O()
        ElseIf Form1.MyInstance.C1.Text = "O" And Form1.MyInstance.B2.Text = "O" And Form1.MyInstance.A3.Text = "O" Then
            resultAL_O()
        End If

    End Function

    Public Function reset()

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

        Form1.MyInstance.showTurnplay.Text = "Player : 1"
        'Form1.MyInstance.scoreP1.Text = "0"


    End Function
    Public Function resultAL_X()
        MsgBox("ddd")
        Form1.MyInstance.scoreP1.Text += 1
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
    Public Function resultAL_O()
        MsgBox("ddd")
        Form1.MyInstance.scoreP2.Text += 1
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
End Class
