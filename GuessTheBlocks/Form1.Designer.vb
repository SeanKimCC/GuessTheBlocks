<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuessTheBlocks
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGuessTheBlocks))
        Me.lblPromptEnter = New System.Windows.Forms.Label()
        Me.lblCorrectColours = New System.Windows.Forms.Label()
        Me.lblCorrectPositions = New System.Windows.Forms.Label()
        Me.btnCheckGuess = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblAnswer1 = New System.Windows.Forms.Label()
        Me.lblAnswer2 = New System.Windows.Forms.Label()
        Me.lblAnswer3 = New System.Windows.Forms.Label()
        Me.lblAnswer4 = New System.Windows.Forms.Label()
        Me.lblAnswer5 = New System.Windows.Forms.Label()
        Me.lblInput5 = New System.Windows.Forms.Label()
        Me.lblInput4 = New System.Windows.Forms.Label()
        Me.lblInput3 = New System.Windows.Forms.Label()
        Me.lblInput2 = New System.Windows.Forms.Label()
        Me.lblInput1 = New System.Windows.Forms.Label()
        Me.lblPromptCorrectColours = New System.Windows.Forms.Label()
        Me.lblPromptCorrectPositions = New System.Windows.Forms.Label()
        Me.btnThreeBlock = New System.Windows.Forms.Button()
        Me.btnFiveBlock = New System.Windows.Forms.Button()
        Me.lblQMblock5 = New System.Windows.Forms.Label()
        Me.lblQMblock4 = New System.Windows.Forms.Label()
        Me.lblQMblock3 = New System.Windows.Forms.Label()
        Me.lblQMblock2 = New System.Windows.Forms.Label()
        Me.lblQMblock1 = New System.Windows.Forms.Label()
        Me.btnShowAnswers = New System.Windows.Forms.Button()
        Me.btnHideAnswers = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPromptEnter
        '
        Me.lblPromptEnter.AutoSize = True
        Me.lblPromptEnter.ForeColor = System.Drawing.Color.Black
        Me.lblPromptEnter.Location = New System.Drawing.Point(48, 212)
        Me.lblPromptEnter.Name = "lblPromptEnter"
        Me.lblPromptEnter.Size = New System.Drawing.Size(75, 13)
        Me.lblPromptEnter.TabIndex = 1
        Me.lblPromptEnter.Text = "Enter colours :"
        '
        'lblCorrectColours
        '
        Me.lblCorrectColours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCorrectColours.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrectColours.ForeColor = System.Drawing.Color.Black
        Me.lblCorrectColours.Location = New System.Drawing.Point(189, 281)
        Me.lblCorrectColours.Name = "lblCorrectColours"
        Me.lblCorrectColours.Size = New System.Drawing.Size(20, 20)
        Me.lblCorrectColours.TabIndex = 6
        Me.lblCorrectColours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCorrectPositions
        '
        Me.lblCorrectPositions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCorrectPositions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrectPositions.ForeColor = System.Drawing.Color.Black
        Me.lblCorrectPositions.Location = New System.Drawing.Point(189, 304)
        Me.lblCorrectPositions.Name = "lblCorrectPositions"
        Me.lblCorrectPositions.Size = New System.Drawing.Size(20, 20)
        Me.lblCorrectPositions.TabIndex = 7
        Me.lblCorrectPositions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCheckGuess
        '
        Me.btnCheckGuess.ForeColor = System.Drawing.Color.Black
        Me.btnCheckGuess.Location = New System.Drawing.Point(266, 306)
        Me.btnCheckGuess.Name = "btnCheckGuess"
        Me.btnCheckGuess.Size = New System.Drawing.Size(89, 23)
        Me.btnCheckGuess.TabIndex = 8
        Me.btnCheckGuess.Text = "Check Guess"
        Me.btnCheckGuess.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.ForeColor = System.Drawing.Color.Black
        Me.btnReset.Location = New System.Drawing.Point(266, 276)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(89, 23)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblAnswer1
        '
        Me.lblAnswer1.ForeColor = System.Drawing.Color.White
        Me.lblAnswer1.Location = New System.Drawing.Point(138, 80)
        Me.lblAnswer1.Name = "lblAnswer1"
        Me.lblAnswer1.Size = New System.Drawing.Size(50, 54)
        Me.lblAnswer1.TabIndex = 10
        '
        'lblAnswer2
        '
        Me.lblAnswer2.ForeColor = System.Drawing.Color.White
        Me.lblAnswer2.Location = New System.Drawing.Point(194, 80)
        Me.lblAnswer2.Name = "lblAnswer2"
        Me.lblAnswer2.Size = New System.Drawing.Size(50, 54)
        Me.lblAnswer2.TabIndex = 11
        '
        'lblAnswer3
        '
        Me.lblAnswer3.ForeColor = System.Drawing.Color.White
        Me.lblAnswer3.Location = New System.Drawing.Point(250, 80)
        Me.lblAnswer3.Name = "lblAnswer3"
        Me.lblAnswer3.Size = New System.Drawing.Size(50, 54)
        Me.lblAnswer3.TabIndex = 12
        '
        'lblAnswer4
        '
        Me.lblAnswer4.ForeColor = System.Drawing.Color.White
        Me.lblAnswer4.Location = New System.Drawing.Point(305, 80)
        Me.lblAnswer4.Name = "lblAnswer4"
        Me.lblAnswer4.Size = New System.Drawing.Size(50, 54)
        Me.lblAnswer4.TabIndex = 13
        '
        'lblAnswer5
        '
        Me.lblAnswer5.ForeColor = System.Drawing.Color.White
        Me.lblAnswer5.Location = New System.Drawing.Point(361, 80)
        Me.lblAnswer5.Name = "lblAnswer5"
        Me.lblAnswer5.Size = New System.Drawing.Size(50, 54)
        Me.lblAnswer5.TabIndex = 14
        '
        'lblInput5
        '
        Me.lblInput5.BackColor = System.Drawing.Color.Black
        Me.lblInput5.Location = New System.Drawing.Point(362, 195)
        Me.lblInput5.Name = "lblInput5"
        Me.lblInput5.Size = New System.Drawing.Size(50, 50)
        Me.lblInput5.TabIndex = 19
        '
        'lblInput4
        '
        Me.lblInput4.BackColor = System.Drawing.Color.Black
        Me.lblInput4.Location = New System.Drawing.Point(305, 195)
        Me.lblInput4.Name = "lblInput4"
        Me.lblInput4.Size = New System.Drawing.Size(50, 50)
        Me.lblInput4.TabIndex = 18
        '
        'lblInput3
        '
        Me.lblInput3.BackColor = System.Drawing.Color.Black
        Me.lblInput3.Location = New System.Drawing.Point(249, 195)
        Me.lblInput3.Name = "lblInput3"
        Me.lblInput3.Size = New System.Drawing.Size(50, 50)
        Me.lblInput3.TabIndex = 17
        '
        'lblInput2
        '
        Me.lblInput2.BackColor = System.Drawing.Color.Black
        Me.lblInput2.Location = New System.Drawing.Point(193, 195)
        Me.lblInput2.Name = "lblInput2"
        Me.lblInput2.Size = New System.Drawing.Size(50, 50)
        Me.lblInput2.TabIndex = 16
        '
        'lblInput1
        '
        Me.lblInput1.BackColor = System.Drawing.Color.Black
        Me.lblInput1.Location = New System.Drawing.Point(137, 195)
        Me.lblInput1.Name = "lblInput1"
        Me.lblInput1.Size = New System.Drawing.Size(50, 50)
        Me.lblInput1.TabIndex = 15
        '
        'lblPromptCorrectColours
        '
        Me.lblPromptCorrectColours.AutoSize = True
        Me.lblPromptCorrectColours.ForeColor = System.Drawing.Color.Black
        Me.lblPromptCorrectColours.Location = New System.Drawing.Point(34, 286)
        Me.lblPromptCorrectColours.Name = "lblPromptCorrectColours"
        Me.lblPromptCorrectColours.Size = New System.Drawing.Size(131, 13)
        Me.lblPromptCorrectColours.TabIndex = 20
        Me.lblPromptCorrectColours.Text = "Number of Correct Colours"
        '
        'lblPromptCorrectPositions
        '
        Me.lblPromptCorrectPositions.AutoSize = True
        Me.lblPromptCorrectPositions.ForeColor = System.Drawing.Color.Black
        Me.lblPromptCorrectPositions.Location = New System.Drawing.Point(34, 306)
        Me.lblPromptCorrectPositions.Name = "lblPromptCorrectPositions"
        Me.lblPromptCorrectPositions.Size = New System.Drawing.Size(138, 13)
        Me.lblPromptCorrectPositions.TabIndex = 21
        Me.lblPromptCorrectPositions.Text = "Number of Correct Positions"
        '
        'btnThreeBlock
        '
        Me.btnThreeBlock.Location = New System.Drawing.Point(383, 275)
        Me.btnThreeBlock.Name = "btnThreeBlock"
        Me.btnThreeBlock.Size = New System.Drawing.Size(111, 25)
        Me.btnThreeBlock.TabIndex = 22
        Me.btnThreeBlock.Text = "Three block mode"
        Me.btnThreeBlock.UseVisualStyleBackColor = True
        '
        'btnFiveBlock
        '
        Me.btnFiveBlock.Location = New System.Drawing.Point(383, 304)
        Me.btnFiveBlock.Name = "btnFiveBlock"
        Me.btnFiveBlock.Size = New System.Drawing.Size(111, 25)
        Me.btnFiveBlock.TabIndex = 23
        Me.btnFiveBlock.Text = "Five block mode"
        Me.btnFiveBlock.UseVisualStyleBackColor = True
        '
        'lblQMblock5
        '
        Me.lblQMblock5.BackColor = System.Drawing.Color.Black
        Me.lblQMblock5.Image = Global.GuessTheBlocks.My.Resources.Resources.rainbow_question_mark_beverage_coaster_r15df19fc55c84f31bed898928e13e4e8_ambkq_8byvr_5121
        Me.lblQMblock5.Location = New System.Drawing.Point(361, 80)
        Me.lblQMblock5.Name = "lblQMblock5"
        Me.lblQMblock5.Size = New System.Drawing.Size(50, 54)
        Me.lblQMblock5.TabIndex = 33
        '
        'lblQMblock4
        '
        Me.lblQMblock4.BackColor = System.Drawing.Color.Black
        Me.lblQMblock4.Image = CType(resources.GetObject("lblQMblock4.Image"), System.Drawing.Image)
        Me.lblQMblock4.Location = New System.Drawing.Point(305, 80)
        Me.lblQMblock4.Name = "lblQMblock4"
        Me.lblQMblock4.Size = New System.Drawing.Size(50, 54)
        Me.lblQMblock4.TabIndex = 32
        '
        'lblQMblock3
        '
        Me.lblQMblock3.BackColor = System.Drawing.Color.Black
        Me.lblQMblock3.Image = CType(resources.GetObject("lblQMblock3.Image"), System.Drawing.Image)
        Me.lblQMblock3.Location = New System.Drawing.Point(250, 80)
        Me.lblQMblock3.Name = "lblQMblock3"
        Me.lblQMblock3.Size = New System.Drawing.Size(50, 54)
        Me.lblQMblock3.TabIndex = 31
        '
        'lblQMblock2
        '
        Me.lblQMblock2.BackColor = System.Drawing.Color.Black
        Me.lblQMblock2.Image = CType(resources.GetObject("lblQMblock2.Image"), System.Drawing.Image)
        Me.lblQMblock2.Location = New System.Drawing.Point(194, 80)
        Me.lblQMblock2.Name = "lblQMblock2"
        Me.lblQMblock2.Size = New System.Drawing.Size(50, 54)
        Me.lblQMblock2.TabIndex = 30
        '
        'lblQMblock1
        '
        Me.lblQMblock1.BackColor = System.Drawing.Color.Black
        Me.lblQMblock1.Image = CType(resources.GetObject("lblQMblock1.Image"), System.Drawing.Image)
        Me.lblQMblock1.Location = New System.Drawing.Point(138, 80)
        Me.lblQMblock1.Name = "lblQMblock1"
        Me.lblQMblock1.Size = New System.Drawing.Size(50, 54)
        Me.lblQMblock1.TabIndex = 29
        '
        'btnShowAnswers
        '
        Me.btnShowAnswers.Location = New System.Drawing.Point(445, 80)
        Me.btnShowAnswers.Name = "btnShowAnswers"
        Me.btnShowAnswers.Size = New System.Drawing.Size(93, 25)
        Me.btnShowAnswers.TabIndex = 34
        Me.btnShowAnswers.Text = "Show Answers"
        Me.btnShowAnswers.UseVisualStyleBackColor = True
        '
        'btnHideAnswers
        '
        Me.btnHideAnswers.Location = New System.Drawing.Point(445, 109)
        Me.btnHideAnswers.Name = "btnHideAnswers"
        Me.btnHideAnswers.Size = New System.Drawing.Size(93, 25)
        Me.btnHideAnswers.TabIndex = 35
        Me.btnHideAnswers.Text = "Hide Answers"
        Me.btnHideAnswers.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(463, 207)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmGuessTheBlocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(550, 369)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnHideAnswers)
        Me.Controls.Add(Me.btnShowAnswers)
        Me.Controls.Add(Me.lblQMblock5)
        Me.Controls.Add(Me.lblQMblock4)
        Me.Controls.Add(Me.lblQMblock3)
        Me.Controls.Add(Me.lblQMblock2)
        Me.Controls.Add(Me.lblQMblock1)
        Me.Controls.Add(Me.btnFiveBlock)
        Me.Controls.Add(Me.btnThreeBlock)
        Me.Controls.Add(Me.lblPromptCorrectPositions)
        Me.Controls.Add(Me.lblPromptCorrectColours)
        Me.Controls.Add(Me.lblInput5)
        Me.Controls.Add(Me.lblInput4)
        Me.Controls.Add(Me.lblInput3)
        Me.Controls.Add(Me.lblInput2)
        Me.Controls.Add(Me.lblInput1)
        Me.Controls.Add(Me.lblAnswer5)
        Me.Controls.Add(Me.lblAnswer4)
        Me.Controls.Add(Me.lblAnswer3)
        Me.Controls.Add(Me.lblAnswer2)
        Me.Controls.Add(Me.lblAnswer1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCheckGuess)
        Me.Controls.Add(Me.lblCorrectPositions)
        Me.Controls.Add(Me.lblCorrectColours)
        Me.Controls.Add(Me.lblPromptEnter)
        Me.Name = "frmGuessTheBlocks"
        Me.Text = "Guess The Blocks"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPromptEnter As System.Windows.Forms.Label
    Friend WithEvents lblCorrectColours As System.Windows.Forms.Label
    Friend WithEvents lblCorrectPositions As System.Windows.Forms.Label
    Friend WithEvents btnCheckGuess As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents lblAnswer1 As System.Windows.Forms.Label
    Friend WithEvents lblAnswer2 As System.Windows.Forms.Label
    Friend WithEvents lblAnswer3 As System.Windows.Forms.Label
    Friend WithEvents lblAnswer4 As System.Windows.Forms.Label
    Friend WithEvents lblAnswer5 As System.Windows.Forms.Label
    Friend WithEvents lblInput5 As System.Windows.Forms.Label
    Friend WithEvents lblInput4 As System.Windows.Forms.Label
    Friend WithEvents lblInput3 As System.Windows.Forms.Label
    Friend WithEvents lblInput2 As System.Windows.Forms.Label
    Friend WithEvents lblInput1 As System.Windows.Forms.Label
    Friend WithEvents lblPromptCorrectColours As System.Windows.Forms.Label
    Friend WithEvents lblPromptCorrectPositions As System.Windows.Forms.Label
    Friend WithEvents btnThreeBlock As System.Windows.Forms.Button
    Friend WithEvents btnFiveBlock As System.Windows.Forms.Button
    Friend WithEvents lblQMblock5 As System.Windows.Forms.Label
    Friend WithEvents lblQMblock4 As System.Windows.Forms.Label
    Friend WithEvents lblQMblock3 As System.Windows.Forms.Label
    Friend WithEvents lblQMblock2 As System.Windows.Forms.Label
    Friend WithEvents lblQMblock1 As System.Windows.Forms.Label
    Friend WithEvents btnShowAnswers As System.Windows.Forms.Button
    Friend WithEvents btnHideAnswers As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
