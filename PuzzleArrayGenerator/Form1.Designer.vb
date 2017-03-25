<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.btnDisableOnChange = New System.Windows.Forms.Button()
        Me.btnFragmentate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCullPuzzleData
        '
        Me.btnCullPuzzleData.Location = New System.Drawing.Point(286, 48)
        Me.btnCullPuzzleData.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnCullPuzzleData.Name = "btnCullPuzzleData"
        Me.btnCullPuzzleData.Size = New System.Drawing.Size(150, 44)
        Me.btnCullPuzzleData.TabIndex = 3
        Me.btnCullPuzzleData.Text = "Extract"
        Me.btnCullPuzzleData.UseVisualStyleBackColor = True
        '
        'txtFragment
        '
        Me.txtFragment.Location = New System.Drawing.Point(48, 54)
        Me.txtFragment.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtFragment.Name = "txtFragment"
        Me.txtFragment.Size = New System.Drawing.Size(196, 31)
        Me.txtFragment.TabIndex = 11
        '
        'lblWord
        '
        Me.lblWord.AutoSize = True
        Me.lblWord.Location = New System.Drawing.Point(42, 23)
        Me.lblWord.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblWord.Name = "lblWord"
        Me.lblWord.Size = New System.Drawing.Size(103, 25)
        Me.lblWord.TabIndex = 4
        Me.lblWord.Text = "Fragment"
        '
        'btnMakeArray
        '
        Me.btnMakeArray.Location = New System.Drawing.Point(286, 104)
        Me.btnMakeArray.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnMakeArray.Name = "btnMakeArray"
        Me.btnMakeArray.Size = New System.Drawing.Size(150, 44)
        Me.btnMakeArray.TabIndex = 4
        Me.btnMakeArray.Text = "Make Array"
        Me.btnMakeArray.UseVisualStyleBackColor = True
        '
        'btnMakePuzzString
        '
        Me.btnMakePuzzString.Location = New System.Drawing.Point(286, 160)
        Me.btnMakePuzzString.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnMakePuzzString.Name = "btnMakePuzzString"
        Me.btnMakePuzzString.Size = New System.Drawing.Size(246, 44)
        Me.btnMakePuzzString.TabIndex = 5
        Me.btnMakePuzzString.Text = "Make puzzle string"
        Me.btnMakePuzzString.UseVisualStyleBackColor = True
        '
        'btnPuzzStrArray
        '
        Me.btnPuzzStrArray.Location = New System.Drawing.Point(556, 104)
        Me.btnPuzzStrArray.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnPuzzStrArray.Name = "btnPuzzStrArray"
        Me.btnPuzzStrArray.Size = New System.Drawing.Size(342, 44)
        Me.btnPuzzStrArray.TabIndex = 7
        Me.btnPuzzStrArray.Text = "Make puzzle-string Array"
        Me.btnPuzzStrArray.UseVisualStyleBackColor = True
        '
        'btnRandomizeFile
        '
        Me.btnRandomizeFile.Location = New System.Drawing.Point(556, 48)
        Me.btnRandomizeFile.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnRandomizeFile.Name = "btnRandomizeFile"
        Me.btnRandomizeFile.Size = New System.Drawing.Size(342, 44)
        Me.btnRandomizeFile.TabIndex = 6
        Me.btnRandomizeFile.Text = "Randomize puzzleData file"
        Me.btnRandomizeFile.UseVisualStyleBackColor = True
        '
        'btnWordDefinitions
        '
        Me.btnWordDefinitions.Location = New System.Drawing.Point(556, 160)
        Me.btnWordDefinitions.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnWordDefinitions.Name = "btnWordDefinitions"
        Me.btnWordDefinitions.Size = New System.Drawing.Size(342, 44)
        Me.btnWordDefinitions.TabIndex = 8
        Me.btnWordDefinitions.Text = "Combine words with def'ns"
        Me.btnWordDefinitions.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(910, 48)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(342, 44)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Remove duplicates"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(910, 104)
        Me.Button2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(342, 44)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Move word/clue pairs to file"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtWord
        '
        Me.txtWord.Location = New System.Drawing.Point(724, 365)
        Me.txtWord.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(196, 31)
        Me.txtWord.TabIndex = 0
        '
        'txtClue
        '
        Me.txtClue.Location = New System.Drawing.Point(724, 248)
        Me.txtClue.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtClue.Multiline = True
        Me.txtClue.Name = "txtClue"
        Me.txtClue.Size = New System.Drawing.Size(708, 85)
        Me.txtClue.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(646, 371)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 25)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Word"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(646, 248)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 25)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Clue"
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(1272, 348)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(164, 71)
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
        Me.btnTwoWords.Location = New System.Drawing.Point(24, 348)
        Me.btnTwoWords.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnTwoWords.Name = "btnTwoWords"
        Me.btnTwoWords.Size = New System.Drawing.Size(150, 44)
        Me.btnTwoWords.TabIndex = 14
        Me.btnTwoWords.TabStop = False
        Me.btnTwoWords.Text = "+(2 words)"
        Me.btnTwoWords.UseVisualStyleBackColor = True
        '
        'btnThreeWords
        '
        Me.btnThreeWords.Location = New System.Drawing.Point(186, 348)
        Me.btnThreeWords.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnThreeWords.Name = "btnThreeWords"
        Me.btnThreeWords.Size = New System.Drawing.Size(150, 44)
        Me.btnThreeWords.TabIndex = 15
        Me.btnThreeWords.TabStop = False
        Me.btnThreeWords.Text = "+(3 words)"
        Me.btnThreeWords.UseVisualStyleBackColor = True
        '
        'btnAddSnippet
        '
        Me.btnAddSnippet.Location = New System.Drawing.Point(360, 292)
        Me.btnAddSnippet.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnAddSnippet.Name = "btnAddSnippet"
        Me.btnAddSnippet.Size = New System.Drawing.Size(264, 44)
        Me.btnAddSnippet.TabIndex = 16
        Me.btnAddSnippet.Text = "Add following snippet:"
        Me.btnAddSnippet.UseVisualStyleBackColor = True
        '
        'txtSnippet
        '
        Me.txtSnippet.Location = New System.Drawing.Point(360, 365)
        Me.txtSnippet.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtSnippet.Name = "txtSnippet"
        Me.txtSnippet.Size = New System.Drawing.Size(260, 31)
        Me.txtSnippet.TabIndex = 17
        '
        'btnDisableOnChange
        '
        Me.btnDisableOnChange.Location = New System.Drawing.Point(938, 365)
        Me.btnDisableOnChange.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnDisableOnChange.Name = "btnDisableOnChange"
        Me.btnDisableOnChange.Size = New System.Drawing.Size(150, 38)
        Me.btnDisableOnChange.TabIndex = 18
        Me.btnDisableOnChange.Text = "Allow entry..."
        Me.btnDisableOnChange.UseVisualStyleBackColor = True
        '
        'btnFragmentate
        '
        Me.btnFragmentate.Location = New System.Drawing.Point(910, 160)
        Me.btnFragmentate.Name = "btnFragmentate"
        Me.btnFragmentate.Size = New System.Drawing.Size(342, 44)
        Me.btnFragmentate.TabIndex = 19
        Me.btnFragmentate.Text = "Find fragments"
        Me.btnFragmentate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1460, 433)
        Me.Controls.Add(Me.btnFragmentate)
        Me.Controls.Add(Me.btnDisableOnChange)
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
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
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
    Friend WithEvents btnDisableOnChange As Button
    Friend WithEvents btnFragmentate As Button
End Class
