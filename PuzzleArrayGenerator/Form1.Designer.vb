﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnCullPuzzleData = New System.Windows.Forms.Button()
        Me.txtFragment = New System.Windows.Forms.TextBox()
        Me.lblWord = New System.Windows.Forms.Label()
        Me.btnMakeArray = New System.Windows.Forms.Button()
        Me.btnMakePuzzString = New System.Windows.Forms.Button()
        Me.btnPuzzStrArray = New System.Windows.Forms.Button()
        Me.btnRandomizeFile = New System.Windows.Forms.Button()
        Me.btnWordDefinitions = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.txtClue = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnTwoWords = New System.Windows.Forms.Button()
        Me.btnThreeWords = New System.Windows.Forms.Button()
        Me.btnAddSnippet = New System.Windows.Forms.Button()
        Me.txtSnippet = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCullPuzzleData
        '
        Me.btnCullPuzzleData.Location = New System.Drawing.Point(143, 25)
        Me.btnCullPuzzleData.Name = "btnCullPuzzleData"
        Me.btnCullPuzzleData.Size = New System.Drawing.Size(75, 23)
        Me.btnCullPuzzleData.TabIndex = 3
        Me.btnCullPuzzleData.Text = "Extract"
        Me.btnCullPuzzleData.UseVisualStyleBackColor = True
        '
        'txtFragment
        '
        Me.txtFragment.Location = New System.Drawing.Point(24, 28)
        Me.txtFragment.Name = "txtFragment"
        Me.txtFragment.Size = New System.Drawing.Size(100, 20)
        Me.txtFragment.TabIndex = 11
        '
        'lblWord
        '
        Me.lblWord.AutoSize = True
        Me.lblWord.Location = New System.Drawing.Point(21, 12)
        Me.lblWord.Name = "lblWord"
        Me.lblWord.Size = New System.Drawing.Size(51, 13)
        Me.lblWord.TabIndex = 4
        Me.lblWord.Text = "Fragment"
        '
        'btnMakeArray
        '
        Me.btnMakeArray.Location = New System.Drawing.Point(143, 54)
        Me.btnMakeArray.Name = "btnMakeArray"
        Me.btnMakeArray.Size = New System.Drawing.Size(75, 23)
        Me.btnMakeArray.TabIndex = 4
        Me.btnMakeArray.Text = "Make Array"
        Me.btnMakeArray.UseVisualStyleBackColor = True
        '
        'btnMakePuzzString
        '
        Me.btnMakePuzzString.Location = New System.Drawing.Point(143, 83)
        Me.btnMakePuzzString.Name = "btnMakePuzzString"
        Me.btnMakePuzzString.Size = New System.Drawing.Size(123, 23)
        Me.btnMakePuzzString.TabIndex = 5
        Me.btnMakePuzzString.Text = "Make puzzle string"
        Me.btnMakePuzzString.UseVisualStyleBackColor = True
        '
        'btnPuzzStrArray
        '
        Me.btnPuzzStrArray.Location = New System.Drawing.Point(278, 54)
        Me.btnPuzzStrArray.Name = "btnPuzzStrArray"
        Me.btnPuzzStrArray.Size = New System.Drawing.Size(171, 23)
        Me.btnPuzzStrArray.TabIndex = 7
        Me.btnPuzzStrArray.Text = "Make puzzle-string Array"
        Me.btnPuzzStrArray.UseVisualStyleBackColor = True
        '
        'btnRandomizeFile
        '
        Me.btnRandomizeFile.Location = New System.Drawing.Point(278, 25)
        Me.btnRandomizeFile.Name = "btnRandomizeFile"
        Me.btnRandomizeFile.Size = New System.Drawing.Size(171, 23)
        Me.btnRandomizeFile.TabIndex = 6
        Me.btnRandomizeFile.Text = "Randomize puzzleData file"
        Me.btnRandomizeFile.UseVisualStyleBackColor = True
        '
        'btnWordDefinitions
        '
        Me.btnWordDefinitions.Location = New System.Drawing.Point(278, 83)
        Me.btnWordDefinitions.Name = "btnWordDefinitions"
        Me.btnWordDefinitions.Size = New System.Drawing.Size(171, 23)
        Me.btnWordDefinitions.TabIndex = 8
        Me.btnWordDefinitions.Text = "Combine words with def'ns"
        Me.btnWordDefinitions.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(455, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Remove duplicates"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(455, 54)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(171, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Move word/clue pairs to file"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtWord
        '
        Me.txtWord.Location = New System.Drawing.Point(362, 190)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(100, 20)
        Me.txtWord.TabIndex = 0
        '
        'txtClue
        '
        Me.txtClue.Location = New System.Drawing.Point(362, 129)
        Me.txtClue.Multiline = True
        Me.txtClue.Name = "txtClue"
        Me.txtClue.Size = New System.Drawing.Size(356, 46)
        Me.txtClue.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(323, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Word"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(323, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Clue"
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(636, 181)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(82, 37)
        Me.btnEnter.TabIndex = 2
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 300
        '
        'btnTwoWords
        '
        Me.btnTwoWords.Location = New System.Drawing.Point(12, 181)
        Me.btnTwoWords.Name = "btnTwoWords"
        Me.btnTwoWords.Size = New System.Drawing.Size(75, 23)
        Me.btnTwoWords.TabIndex = 14
        Me.btnTwoWords.TabStop = False
        Me.btnTwoWords.Text = "+(2 words)"
        Me.btnTwoWords.UseVisualStyleBackColor = True
        '
        'btnThreeWords
        '
        Me.btnThreeWords.Location = New System.Drawing.Point(93, 181)
        Me.btnThreeWords.Name = "btnThreeWords"
        Me.btnThreeWords.Size = New System.Drawing.Size(75, 23)
        Me.btnThreeWords.TabIndex = 15
        Me.btnThreeWords.TabStop = False
        Me.btnThreeWords.Text = "+(3 words)"
        Me.btnThreeWords.UseVisualStyleBackColor = True
        '
        'btnAddSnippet
        '
        Me.btnAddSnippet.Location = New System.Drawing.Point(180, 152)
        Me.btnAddSnippet.Name = "btnAddSnippet"
        Me.btnAddSnippet.Size = New System.Drawing.Size(132, 23)
        Me.btnAddSnippet.TabIndex = 16
        Me.btnAddSnippet.Text = "Add following snippet:"
        Me.btnAddSnippet.UseVisualStyleBackColor = True
        '
        'txtSnippet
        '
        Me.txtSnippet.Location = New System.Drawing.Point(180, 190)
        Me.txtSnippet.Name = "txtSnippet"
        Me.txtSnippet.Size = New System.Drawing.Size(132, 20)
        Me.txtSnippet.TabIndex = 17
        '
        'Form1
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 225)
        Me.Controls.Add(Me.txtSnippet)
        Me.Controls.Add(Me.btnAddSnippet)
        Me.Controls.Add(Me.btnThreeWords)
        Me.Controls.Add(Me.btnTwoWords)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtClue)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnRandomizeFile)
        Me.Controls.Add(Me.btnWordDefinitions)
        Me.Controls.Add(Me.btnPuzzStrArray)
        Me.Controls.Add(Me.btnMakePuzzString)
        Me.Controls.Add(Me.btnMakeArray)
        Me.Controls.Add(Me.lblWord)
        Me.Controls.Add(Me.txtFragment)
        Me.Controls.Add(Me.btnCullPuzzleData)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCullPuzzleData As Button
    Friend WithEvents txtFragment As TextBox
    Friend WithEvents lblWord As Label
    Friend WithEvents btnMakeArray As Button
    Friend WithEvents btnMakePuzzString As Button
    Friend WithEvents btnPuzzStrArray As Button
    Friend WithEvents btnRandomizeFile As Button
    Friend WithEvents btnWordDefinitions As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtWord As TextBox
    Friend WithEvents txtClue As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnTwoWords As Button
    Friend WithEvents btnThreeWords As Button
    Friend WithEvents btnAddSnippet As Button
    Friend WithEvents txtSnippet As TextBox
End Class