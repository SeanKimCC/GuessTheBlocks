Public Class frmGuessTheBlocks
    '##################################################################'
    '######### I FORGOT THE TITLE #####################################'
    '##################### GUESS THE BLOCKS ###########################'
    '#################################################### SEAN KIM ####'
    '##################################################################'
    Dim RC, BC, GC, YC As Integer

    Dim R As Color = Color.Red
    Dim G As Color = Color.Green
    Dim B As Color = Color.Blue
    Dim Y As Color = Color.Yellow

    Dim answer1 As Integer 'Variables that are given random numbers as their values. answer1 is the answer for first block, answer2 is the answer 
    Dim answer2 As Integer ' for the second block, and so on. They are given random numbers from 1~6 for five block mode, and 1~4 for three
    Dim answer3 As Integer ' block mode.
    Dim answer4 As Integer
    Dim answer5 As Integer

    Dim input1 As Integer 'Variables that increases by 1 as the user clicks the blocks. For 5 block mode, input# decreases by 6 when it becomes 
    Dim input2 As Integer 'greater than 6. In 3 block mode, input# decreases by 4 when it becomes greater than 4.
    Dim input3 As Integer 'These are the variables that show you the count of clicks or the colours of the input blocks.
    Dim input4 As Integer
    Dim input5 As Integer

    Dim showAnswers As Boolean 'When btnShowAnswers is clicked, showAnswers is true, when btnHideAnswers is clicked, showAnswers is false.

    Dim correctColour As Integer
    Dim correctPosition As Integer

    Dim threeBlockMode As Integer 'When btnThreeBlockMode is clicked, threeBlockMode becomes 1 and when btnFiveBlockMode is clicked, it becomes 0.


    Private Sub btnCheckGuess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckGuess.Click

        correctColour = 0
        correctPosition = 0

        ' this is my algorithm to make the program count the colours correct only once.
        'When the answer block has been counted, the answer# becomes 100 + answer# to avoid being counted again.
        'Since answer# normally doesn't go over 6, when it is greater than 10 (safely 50), it should be reduced by 100
        ' so that they can be counted as correct colour block again.


        Select Case input1
            Case answer1 'when input of the user matches the answer, correctColour variable increases by one ans the answer#
                correctColour += 1 ' increases by 100 to avoid being counted again.
                answer1 += 100
            Case answer2
                correctColour += 1
                answer2 += 100
            Case answer3
                correctColour += 1
                answer3 += 100
            Case answer4
                correctColour += 1
                answer4 += 100
            Case answer5
                correctColour += 1
                answer5 += 100
        End Select

        Select Case input2
            Case answer2
                correctColour += 1
                answer2 += 100
            Case answer1
                correctColour += 1
                answer1 += 100
            Case answer3
                correctColour += 1
                answer3 += 100
            Case answer4
                correctColour += 1
                answer4 += 100
            Case answer5
                correctColour += 1
                answer5 += 100
        End Select

        Select Case input3
            Case answer3
                correctColour += 1
                answer3 += 100
            Case answer2
                correctColour += 1
                answer2 += 100
            Case answer1
                correctColour += 1
                answer1 += 100
            Case answer4
                correctColour += 1
                answer4 += 100
            Case answer5
                correctColour += 1
                answer5 += 100
        End Select

        Select Case input4
            Case answer4
                correctColour += 1
                answer4 += 100
            Case answer2
                correctColour += 1
                answer2 += 100
            Case answer3
                correctColour += 1
                answer3 += 100
            Case answer1
                correctColour += 1
                answer1 += 100
            Case answer5
                correctColour += 1
                answer5 += 100
        End Select

        Select Case input5
            Case answer5
                correctColour += 1
                answer5 += 100
            Case answer2
                correctColour += 1
                answer2 += 100
            Case answer3
                correctColour += 1
                answer3 += 100
            Case answer4
                correctColour += 1
                answer4 += 100
            Case answer1
                correctColour += 1
                answer1 += 100
        End Select

        If answer1 > 50 Then ' this is my algorithm to make the program count the colours correct only once.
            answer1 -= 100 'When the answer block has been counted, the answer# becomes 100 + answer# to avoid being counted again.
        End If
        If answer2 > 50 Then 'Since answer# normally doesn't go over 6, when it is greater than 10 (safely 50), it should be reduced by 100
            answer2 -= 100 ' so that they can be counted as correct colour block again.
        End If
        If answer3 > 50 Then
            answer3 -= 100
        End If
        If answer4 > 50 Then
            answer4 -= 100
        End If
        If answer5 > 50 Then
            answer5 -= 100
        End If

        If input1 = answer1 Then 'If input1 is equal to answer1, the variable correctPosition increases by 1.
            correctPosition += 1
        End If

        If input2 = answer2 Then
            correctPosition += 1
        End If

        If input3 = answer3 Then
            correctPosition += 1
        End If

        If input4 = answer4 Then
            correctPosition += 1
        End If

        If input5 = answer5 Then
            correctPosition += 1
        End If

        Me.lblCorrectColours.Text = correctColour
        Me.lblCorrectPositions.Text = correctPosition

        If threeBlockMode = 1 Then
            If correctColour + correctPosition = 6 Then 'In three block mode, only 3 correct colours and three correct positions are necessary
                MsgBox("You've won the three block mode")
            End If
        Else
            If correctColour + correctPosition = 10 Then
                MsgBox("You've won the five block mode")
            End If
        End If


    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        correctColour = 0 'Randomizes and resets all the values except for three block mode to avoid going back to 
        correctPosition = 0 'five block mode when playing three block mode.

        Me.lblCorrectColours.Text = correctColour
        Me.lblCorrectPositions.Text = correctPosition

        input1 = 0
        input2 = 0
        input3 = 0
        input4 = 0
        input5 = 0

        Me.lblInput1.BackColor = Color.Black
        Me.lblInput2.BackColor = Color.Black
        Me.lblInput3.BackColor = Color.Black
        Me.lblInput4.BackColor = Color.Black
        Me.lblInput5.BackColor = Color.Black

        If threeBlockMode <> 1 Then 'Randomizes and resets all the values
            Randomize()
            answer1 = Int(6 * Rnd() + 1)
            answer2 = Int(6 * Rnd() + 1)
            answer3 = Int(6 * Rnd() + 1)
            answer4 = Int(6 * Rnd() + 1)
            answer5 = Int(6 * Rnd() + 1)
        Else
            Randomize()
            answer2 = Int(4 * Rnd() + 1)
            answer3 = Int(4 * Rnd() + 1)
            answer4 = Int(4 * Rnd() + 1)

        End If

        Select Case answer1 'The colour of the answer# blocks change accordingly to their randomized values

            Case 1
                Me.lblAnswer1.BackColor = Color.Red
            Case 2
                Me.lblAnswer1.BackColor = Color.Blue
            Case 3
                Me.lblAnswer1.BackColor = Color.Green
            Case 4
                Me.lblAnswer1.BackColor = Color.Yellow
            Case 5
                Me.lblAnswer1.BackColor = Color.Purple
            Case 6
                Me.lblAnswer1.BackColor = Color.Orange
        End Select

        Select Case answer2

            Case 1
                Me.lblAnswer2.BackColor = Color.Red
            Case 2
                Me.lblAnswer2.BackColor = Color.Blue
            Case 3
                Me.lblAnswer2.BackColor = Color.Green
            Case 4
                Me.lblAnswer2.BackColor = Color.Yellow
            Case 5
                Me.lblAnswer2.BackColor = Color.Purple
            Case 6
                Me.lblAnswer2.BackColor = Color.Orange
        End Select

        Select Case answer3

            Case 1
                Me.lblAnswer3.BackColor = Color.Red
            Case 2
                Me.lblAnswer3.BackColor = Color.Blue
            Case 3
                Me.lblAnswer3.BackColor = Color.Green
            Case 4
                Me.lblAnswer3.BackColor = Color.Yellow
            Case 5
                Me.lblAnswer3.BackColor = Color.Purple
            Case 6
                Me.lblAnswer3.BackColor = Color.Orange

        End Select

        Select Case answer4

            Case 1
                Me.lblAnswer4.BackColor = Color.Red
            Case 2
                Me.lblAnswer4.BackColor = Color.Blue
            Case 3
                Me.lblAnswer4.BackColor = Color.Green
            Case 4
                Me.lblAnswer4.BackColor = Color.Yellow
            Case 5
                Me.lblAnswer4.BackColor = Color.Purple
            Case 6
                Me.lblAnswer4.BackColor = Color.Orange
        End Select


        Select Case answer5

            Case 1
                Me.lblAnswer5.BackColor = Color.Red
            Case 2
                Me.lblAnswer5.BackColor = Color.Blue
            Case 3
                Me.lblAnswer5.BackColor = Color.Green
            Case 4
                Me.lblAnswer5.BackColor = Color.Yellow
            Case 5
                Me.lblAnswer5.BackColor = Color.Purple
            Case 6
                Me.lblAnswer5.BackColor = Color.Orange
        End Select

    End Sub

    Private Sub lblInput1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblInput1.Click
        input1 += 1
        If input1 > 6 Then 'mod does not work because if input1 = input1 mod 6 , when input1 = 6, input1 =6 mod 6 = 0and
            input1 -= 6 ' when input1 =7, and input1 = input1 mod 7, then when input1 =7, input1 = 7 mod 7 = 0 not 1.
        End If


        Select Case input1 'The colour of the input# blocks change accordingly to their clicked values.
            Case 0
                Me.lblInput1.BackColor = Color.Black
            Case 1
                Me.lblInput1.BackColor = Color.Red
            Case 2
                Me.lblInput1.BackColor = Color.Blue
            Case 3
                Me.lblInput1.BackColor = Color.Green
            Case 4
                Me.lblInput1.BackColor = Color.Yellow
            Case 5
                Me.lblInput1.BackColor = Color.Purple
            Case 6
                Me.lblInput1.BackColor = Color.Orange
        End Select

    End Sub

    Private Sub lblInput2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblInput2.Click
        input2 += 1
        If input2 > 6 And threeBlockMode <> 1 Then 'since only the 3 blocks in the middle, input2~4, are used in three block mode, input1 and input5
            input2 -= 6 'are not given the if statement. Only when threeBlockMode is not 1, decrease it by 6, and when threeBlockMode = 1, decrease by 4
        ElseIf input2 > 4 And threeBlockMode = 1 Then 'because there are only 4 colours

            input2 -= 4
        End If
        Select Case input2
            Case 0
                Me.lblInput2.BackColor = Color.Black
            Case 1
                Me.lblInput2.BackColor = Color.Red
            Case 2
                Me.lblInput2.BackColor = Color.Blue
            Case 3
                Me.lblInput2.BackColor = Color.Green
            Case 4
                Me.lblInput2.BackColor = Color.Yellow
            Case 5
                Me.lblInput2.BackColor = Color.Purple
            Case 6
                Me.lblInput2.BackColor = Color.Orange
        End Select


    End Sub

    Private Sub lblinput3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblInput3.Click
        input3 += 1
        If input3 > 6 And threeBlockMode <> 1 Then
            input3 -= 6
        ElseIf input3 > 4 And threeBlockMode = 1 Then

            input3 -= 4
        End If

        Select Case input3
            Case 0
                Me.lblInput3.BackColor = Color.Black
            Case 1
                Me.lblInput3.BackColor = Color.Red
            Case 2
                Me.lblInput3.BackColor = Color.Blue
            Case 3
                Me.lblInput3.BackColor = Color.Green
            Case 4
                Me.lblInput3.BackColor = Color.Yellow
            Case 5
                Me.lblInput3.BackColor = Color.Purple
            Case 6
                Me.lblInput3.BackColor = Color.Orange
        End Select
    End Sub

    Private Sub lblInput4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblInput4.Click
        input4 += 1
        If input4 > 6 And threeBlockMode <> 1 Then
            input4 -= 6
        ElseIf input4 > 4 And threeBlockMode = 1 Then
            input4 -= 4
        End If

        Select Case input4

            Case 0
                Me.lblInput4.BackColor = Color.Black
            Case 1
                Me.lblInput4.BackColor = Color.Red
            Case 2
                Me.lblInput4.BackColor = Color.Blue
            Case 3
                Me.lblInput4.BackColor = Color.Green
            Case 4
                Me.lblInput4.BackColor = Color.Yellow
            Case 5
                Me.lblInput4.BackColor = Color.Purple
            Case 6
                Me.lblInput4.BackColor = Color.Orange

        End Select

    End Sub

    Private Sub lblInput5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblInput5.Click

        input5 += 1
        If input5 > 6 Then
            input5 -= 6
        End If

        Select Case input5
            Case 0
                Me.lblInput5.BackColor = Color.Black
            Case 1
                Me.lblInput5.BackColor = Color.Red
            Case 2
                Me.lblInput5.BackColor = Color.Blue
            Case 3
                Me.lblInput5.BackColor = Color.Green
            Case 4
                Me.lblInput5.BackColor = Color.Yellow
            Case 5
                Me.lblInput5.BackColor = Color.Purple
            Case 6
                Me.lblInput5.BackColor = Color.Orange
        End Select

    End Sub

    Private Sub btnThreeBlocks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThreeBlock.Click

        threeblockmode = 1
        answer1 = 1000 'avoid answer1 or answer5 from being counted
        answer5 = 1000
        Randomize() ' only create 3 random numbers

        answer2 = Int(4 * Rnd() + 1)
        answer3 = Int(4 * Rnd() + 1)
        answer4 = Int(4 * Rnd() + 1)


        input1 = 2000 'avoid input1 or input5 from counting.
        input5 = 2000

        Me.lblInput2.BackColor = Color.Black 'Reset the middle three blocks to colour black
        Me.lblInput3.BackColor = Color.Black
        Me.lblInput4.BackColor = Color.Black

        Me.lblQMblock1.Visible = False 'The Question Mark block # 1 and 5 don't need to be shown.
        Me.lblQMblock5.Visible = False

        Me.lblAnswer1.Visible = False 'Hide Answers1 and 5
        Me.lblAnswer5.Visible = False


        Select Case answer2 'Give answer2~4 colours from red,blue,green, or yellow.

            Case 1
                Me.lblAnswer2.BackColor = Color.Red
            Case 2
                Me.lblAnswer2.BackColor = Color.Blue
            Case 3
                Me.lblAnswer2.BackColor = Color.Green
            Case 4
                Me.lblAnswer2.BackColor = Color.Yellow

        End Select

        Select Case answer3

            Case 1
                Me.lblAnswer3.BackColor = Color.Red
            Case 2
                Me.lblAnswer3.BackColor = Color.Blue
            Case 3
                Me.lblAnswer3.BackColor = Color.Green
            Case 4
                Me.lblAnswer3.BackColor = Color.Yellow

        End Select

        Select Case answer4

            Case 1
                Me.lblAnswer4.BackColor = Color.Red
            Case 2
                Me.lblAnswer4.BackColor = Color.Blue
            Case 3
                Me.lblAnswer4.BackColor = Color.Green
            Case 4
                Me.lblAnswer4.BackColor = Color.Yellow

        End Select


        Me.lblInput1.Enabled = False 'stop input1 or 5 from being clicked
        Me.lblInput5.Enabled = False
        Me.lblInput1.Visible = False 'hide lblinput1 and 5
        Me.lblInput5.Visible = False
        Me.btnFiveBlock.Enabled = True 'make btnFiveBlock clickable
        Me.btnThreeBlock.Enabled = False 'make btnThreeBlock Unclickable.



    End Sub

    Private Sub btnFiveBlock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiveBlock.Click
        threeBlockMode = 0 'Change threeblockmode to 0

        Randomize() 'Copy of the Reset button, whenever the five block mode button is clicked, the inputers/colours are reset and 5 random
        answer1 = Int(6 * Rnd() + 1) 'numbers are generated.
        answer2 = Int(6 * Rnd() + 1)
        answer3 = Int(6 * Rnd() + 1)
        answer4 = Int(6 * Rnd() + 1)
        answer5 = Int(6 * Rnd() + 1)

        Me.lblInput1.BackColor = Color.Black
        Me.lblInput2.BackColor = Color.Black
        Me.lblInput3.BackColor = Color.Black
        Me.lblInput4.BackColor = Color.Black
        Me.lblInput5.BackColor = Color.Black

        input1 = 0 'Reset the colours of the lblInput#
        input2 = 0
        input3 = 0
        input4 = 0
        input5 = 0

        Select Case answer1

            Case 1
                Me.lblAnswer1.BackColor = Color.Red
            Case 2
                Me.lblAnswer1.BackColor = Color.Blue
            Case 3
                Me.lblAnswer1.BackColor = Color.Green
            Case 4
                Me.lblAnswer1.BackColor = Color.Yellow
            Case 5
                Me.lblAnswer1.BackColor = Color.Purple
            Case 6
                Me.lblAnswer1.BackColor = Color.Orange
        End Select

        Select Case answer2

            Case 1
                Me.lblAnswer2.BackColor = Color.Red
            Case 2
                Me.lblAnswer2.BackColor = Color.Blue
            Case 3
                Me.lblAnswer2.BackColor = Color.Green
            Case 4
                Me.lblAnswer2.BackColor = Color.Yellow
            Case 5
                Me.lblAnswer2.BackColor = Color.Purple
            Case 6
                Me.lblAnswer2.BackColor = Color.Orange
        End Select

        Select Case answer3

            Case 1
                Me.lblAnswer3.BackColor = Color.Red
            Case 2
                Me.lblAnswer3.BackColor = Color.Blue
            Case 3
                Me.lblAnswer3.BackColor = Color.Green
            Case 4
                Me.lblAnswer3.BackColor = Color.Yellow
            Case 5
                Me.lblAnswer3.BackColor = Color.Purple
            Case 6
                Me.lblAnswer3.BackColor = Color.Orange

        End Select

        Select Case answer4

            Case 1
                Me.lblAnswer4.BackColor = Color.Red
            Case 2
                Me.lblAnswer4.BackColor = Color.Blue
            Case 3
                Me.lblAnswer4.BackColor = Color.Green
            Case 4
                Me.lblAnswer4.BackColor = Color.Yellow
            Case 5
                Me.lblAnswer4.BackColor = Color.Purple
            Case 6
                Me.lblAnswer4.BackColor = Color.Orange
        End Select


        Select Case answer5

            Case 1
                Me.lblAnswer5.BackColor = Color.Red
            Case 2
                Me.lblAnswer5.BackColor = Color.Blue
            Case 3
                Me.lblAnswer5.BackColor = Color.Green
            Case 4
                Me.lblAnswer5.BackColor = Color.Yellow
            Case 5
                Me.lblAnswer5.BackColor = Color.Purple
            Case 6
                Me.lblAnswer5.BackColor = Color.Orange
        End Select

        Me.lblInput1.Enabled = True
        Me.lblInput5.Enabled = True
        Me.lblInput1.Visible = True
        Me.lblInput5.Visible = True
        Me.btnThreeBlock.Enabled = True
        Me.btnFiveBlock.Enabled = False

        Me.lblAnswer1.Visible = True
        Me.lblAnswer5.Visible = True
        If showAnswers = True Then 'When btnShowAnswers is clicked
            Me.lblQMblock1.Visible = False 'hide Question Mark blocks 1 and 5
            Me.lblQMblock5.Visible = False
        Else 'When btnHideAnswers
            Me.lblQMblock1.Visible = True 'show Question Mark blocks 1 and 5
            Me.lblQMblock5.Visible = True
        End If

    End Sub


    Private Sub btnShowAnswers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowAnswers.Click

        showAnswers = True 'When btnShowAnswers is clicked, change showAnswers to true


        Me.lblQMblock1.Visible = False 'hide all the QMblocks to show the answers
        Me.lblQMblock2.Visible = False
        Me.lblQMblock3.Visible = False
        Me.lblQMblock4.Visible = False
        Me.lblQMblock5.Visible = False


    End Sub

    Private Sub btnHideAnswers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHideAnswers.Click
        showAnswers = False 'When btnShowAnswers is clicked, change showAnswers to false.

        Me.lblQMblock1.Visible = True 'show all the QMblocks to hide the answers
        Me.lblQMblock2.Visible = True
        Me.lblQMblock3.Visible = True
        Me.lblQMblock4.Visible = True
        Me.lblQMblock5.Visible = True

        If threeblockmode = 1 Then
            Me.lblQMblock1.Visible = False 'If the three block mode is on, hide QMblocks 1 and 5.
            Me.lblQMblock5.Visible = False
        End If
    End Sub
    Private Sub send(ByVal a, ByVal b, ByVal c)
        Do Until lblInput2.BackColor = a
            Call lblInput2_Click(Nothing, Nothing)
        Loop
        Do Until lblInput3.BackColor = b
            Call lblinput3_Click(Nothing, Nothing)
        Loop
        Do Until lblInput4.BackColor = c
            Call lblInput4_Click(Nothing, Nothing)
        Loop
        Call btnCheckGuess_Click(Nothing, Nothing)

    End Sub
    Private Sub AI()
        Call send(R, R, R)
        RC = correctColour
        If RC <> 3 Then
            Call send(B, B, B)
            BC = correctColour
            If RC + BC <> 3 Then
                Call send(G, G, G)
                GC = correctColour
                YC = 3 - (RC + BC + GC)
                If YC = 3 Then
                    Call send(Y, Y, Y)

                End If
            End If
        End If
        Select Case RC
            Case 0
                Select Case BC
                    Case 0
                        Select Case GC
                            Case 1
                                CheckF(G, Y, Y)
                            Case 2
                                CheckF(G, G, Y)

                        End Select
                    Case 1
                        Select Case GC
                            Case 1
                                CheckF(B, G, Y)
                            Case 2
                                CheckF(B, G, G)


                        End Select
                    Case 2
                        Select Case GC
                            Case 0
                                CheckF(B, B, Y)
                            Case 1
                                CheckF(B, B, G)
                        End Select

                End Select
            Case 1
                Select Case BC
                    Case 1

                        Select Case GC
                            Case 0
                                Call CheckF(R, B, Y)
                            Case 1
                                Call CheckF(R, B, G)


                        End Select
                    Case 2
                        Call CheckF(R, B, B)

                End Select
            Case 2

                Select Case BC
                    Case 0
                        Select Case GC
                            Case 0
                                CheckF(R, R, Y)
                            Case 1
                                CheckF(R, R, G)

                        End Select
                    Case 1
                        Call CheckF(R, R, B)

                End Select

        End Select
        'If RC >= 1 Then
        '    If BC >= 1 Then
        '        If GC >= 1 Then

        '        End If
        '    End If
        'End If
    End Sub
    Private Sub CheckF(ByVal a, ByVal b, ByVal c)

        Call send(a, b, c)
        If correctPosition = 0 Then
            Call send(b, c, a)

            If correctPosition = 0 Then
                Call send(c, a, b)
            Else
                Call send(b, a, c)
                Call send(a, c, b)
                Call send(c, b, a)

            End If
        Else
            Call send(b, a, c)
            Call send(a, c, b)
            Call send(c, b, a)
        End If




    End Sub
    Private Sub CheckP(ByVal x, ByVal y, ByVal z)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call btnThreeBlocks_Click(Nothing, Nothing)
        Call AI()

    End Sub
End Class
