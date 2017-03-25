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
        Me.lblCount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbnTheme = New System.Windows.Forms.RadioButton()
        Me.rbnHard = New System.Windows.Forms.RadioButton()
        Me.rbnMedium = New System.Windows.Forms.RadioButton()
        Me.rbnEasy = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNumPuzzles = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCullPuzzleData
        '
        Me.btnCullPuzzleData.Location = New System.Drawing.Point(44, 36)
        Me.btnCullPuzzleData.Margin = New System.Windows.Forms.Padding(6)
        Me.btnCullPuzzleData.Name = "btnCullPuzzleData"
        Me.btnCullPuzzleData.Size = New System.Drawing.Size(150, 44)
        Me.btnCullPuzzleData.TabIndex = 3
        Me.btnCullPuzzleData.Text = "Extract"
        Me.btnCullPuzzleData.UseVisualStyleBackColor = True
        '
        'txtFragment
        '
        Me.txtFragment.Location = New System.Drawing.Point(1133, 74)
        Me.txtFragment.Margin = New System.Windows.Forms.Padding(6)
        Me.txtFragment.Name = "txtFragment"
        Me.txtFragment.Size = New System.Drawing.Size(97, 31)
        Me.txtFragment.TabIndex = 11
        '
        'lblWord
        '
        Me.lblWord.AutoSize = True
        Me.lblWord.Location = New System.Drawing.Point(1127, 43)
        Me.lblWord.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblWord.Name = "lblWord"
        Me.lblWord.Size = New System.Drawing.Size(103, 25)
        Me.lblWord.TabIndex = 4
        Me.lblWord.Text = "Fragment"
        '
        'btnMakeArray
        '
        Me.btnMakeArray.Location = New System.Drawing.Point(44, 92)
        Me.btnMakeArray.Margin = New System.Windows.Forms.Padding(6)
        Me.btnMakeArray.Name = "btnMakeArray"
        Me.btnMakeArray.Size = New System.Drawing.Size(150, 44)
        Me.btnMakeArray.TabIndex = 4
        Me.btnMakeArray.Text = "Make Array"
        Me.btnMakeArray.UseVisualStyleBackColor = True
        '
        'btnMakePuzzString
        '
        Me.btnMakePuzzString.Location = New System.Drawing.Point(44, 148)
        Me.btnMakePuzzString.Margin = New System.Windows.Forms.Padding(6)
        Me.btnMakePuzzString.Name = "btnMakePuzzString"
        Me.btnMakePuzzString.Size = New System.Drawing.Size(246, 44)
        Me.btnMakePuzzString.TabIndex = 5
        Me.btnMakePuzzString.Text = "Make puzzle string"
        Me.btnMakePuzzString.UseVisualStyleBackColor = True
        '
        'btnPuzzStrArray
        '
        Me.btnPuzzStrArray.Location = New System.Drawing.Point(314, 92)
        Me.btnPuzzStrArray.Margin = New System.Windows.Forms.Padding(6)
        Me.btnPuzzStrArray.Name = "btnPuzzStrArray"
        Me.btnPuzzStrArray.Size = New System.Drawing.Size(342, 44)
        Me.btnPuzzStrArray.TabIndex = 7
        Me.btnPuzzStrArray.Text = "Make puzzle-string Array"
        Me.btnPuzzStrArray.UseVisualStyleBackColor = True
        '
        'btnRandomizeFile
        '
        Me.btnRandomizeFile.Location = New System.Drawing.Point(314, 36)
        Me.btnRandomizeFile.Margin = New System.Windows.Forms.Padding(6)
        Me.btnRandomizeFile.Name = "btnRandomizeFile"
        Me.btnRandomizeFile.Size = New System.Drawing.Size(342, 44)
        Me.btnRandomizeFile.TabIndex = 6
        Me.btnRandomizeFile.Text = "Randomize puzzleData file"
        Me.btnRandomizeFile.UseVisualStyleBackColor = True
        '
        'btnWordDefinitions
        '
        Me.btnWordDefinitions.Location = New System.Drawing.Point(314, 148)
        Me.btnWordDefinitions.Margin = New System.Windows.Forms.Padding(6)
        Me.btnWordDefinitions.Name = "btnWordDefinitions"
        Me.btnWordDefinitions.Size = New System.Drawing.Size(342, 44)
        Me.btnWordDefinitions.TabIndex = 8
        Me.btnWordDefinitions.Text = "Combine words with def'ns"
        Me.btnWordDefinitions.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(668, 36)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(342, 44)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Remove duplicates"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(668, 92)
        Me.Button2.Margin = New System.Windows.Forms.Padding(6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(342, 44)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Move word/clue pairs to file"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtWord
        '
        Me.txtWord.Location = New System.Drawing.Point(724, 365)
        Me.txtWord.Margin = New System.Windows.Forms.Padding(6)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(196, 31)
        Me.txtWord.TabIndex = 0
        '
        'txtClue
        '
        Me.txtClue.Location = New System.Drawing.Point(724, 248)
        Me.txtClue.Margin = New System.Windows.Forms.Padding(6)
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
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(6)
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
        Me.btnTwoWords.Margin = New System.Windows.Forms.Padding(6)
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
        Me.btnThreeWords.Margin = New System.Windows.Forms.Padding(6)
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
        Me.btnAddSnippet.Margin = New System.Windows.Forms.Padding(6)
        Me.btnAddSnippet.Name = "btnAddSnippet"
        Me.btnAddSnippet.Size = New System.Drawing.Size(264, 44)
        Me.btnAddSnippet.TabIndex = 16
        Me.btnAddSnippet.Text = "Add following snippet:"
        Me.btnAddSnippet.UseVisualStyleBackColor = True
        '
        'txtSnippet
        '
        Me.txtSnippet.Location = New System.Drawing.Point(360, 365)
        Me.txtSnippet.Margin = New System.Windows.Forms.Padding(6)
        Me.txtSnippet.Name = "txtSnippet"
        Me.txtSnippet.Size = New System.Drawing.Size(260, 31)
        Me.txtSnippet.TabIndex = 17
        '
        'btnDisableOnChange
        '
        Me.btnDisableOnChange.Location = New System.Drawing.Point(938, 365)
        Me.btnDisableOnChange.Margin = New System.Windows.Forms.Padding(6)
        Me.btnDisableOnChange.Name = "btnDisableOnChange"
        Me.btnDisableOnChange.Size = New System.Drawing.Size(150, 38)
        Me.btnDisableOnChange.TabIndex = 18
        Me.btnDisableOnChange.Text = "Allow entry..."
        Me.btnDisableOnChange.UseVisualStyleBackColor = True
        '
        'btnFragmentate
        '
        Me.btnFragmentate.Location = New System.Drawing.Point(668, 148)
        Me.btnFragmentate.Name = "btnFragmentate"
        Me.btnFragmentate.Size = New System.Drawing.Size(342, 44)
        Me.btnFragmentate.TabIndex = 19
        Me.btnFragmentate.Text = "Make puzzle string"
        Me.btnFragmentate.UseVisualStyleBackColor = True
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(1362, 153)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(39, 42)
        Me.lblCount.TabIndex = 20
        Me.lblCount.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1347, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 25)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "letters"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbnTheme)
        Me.GroupBox1.Controls.Add(Me.rbnHard)
        Me.GroupBox1.Controls.Add(Me.rbnMedium)
        Me.GroupBox1.Controls.Add(Me.rbnEasy)
        Me.GroupBox1.Location = New System.Drawing.Point(1035, 137)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(294, 54)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'rbnTheme
        '
        Me.rbnTheme.AutoSize = True
        Me.rbnTheme.Location = New System.Drawing.Point(196, 11)
        Me.rbnTheme.Name = "rbnTheme"
        Me.rbnTheme.Size = New System.Drawing.Size(56, 29)
        Me.rbnTheme.TabIndex = 0
        Me.rbnTheme.Text = "T"
        Me.rbnTheme.UseVisualStyleBackColor = True
        '
        'rbnHard
        '
        Me.rbnHard.AutoSize = True
        Me.rbnHard.Location = New System.Drawing.Point(133, 11)
        Me.rbnHard.Name = "rbnHard"
        Me.rbnHard.Size = New System.Drawing.Size(58, 29)
        Me.rbnHard.TabIndex = 0
        Me.rbnHard.Text = "H"
        Me.rbnHard.UseVisualStyleBackColor = True
        '
        'rbnMedium
        '
        Me.rbnMedium.AutoSize = True
        Me.rbnMedium.Checked = True
        Me.rbnMedium.Location = New System.Drawing.Point(70, 11)
        Me.rbnMedium.Name = "rbnMedium"
        Me.rbnMedium.Size = New System.Drawing.Size(61, 29)
        Me.rbnMedium.TabIndex = 0
        Me.rbnMedium.TabStop = True
        Me.rbnMedium.Text = "M"
        Me.rbnMedium.UseVisualStyleBackColor = True
        '
        'rbnEasy
        '
        Me.rbnEasy.AutoSize = True
        Me.rbnEasy.Location = New System.Drawing.Point(7, 11)
        Me.rbnEasy.Name = "rbnEasy"
        Me.rbnEasy.Size = New System.Drawing.Size(57, 29)
        Me.rbnEasy.TabIndex = 0
        Me.rbnEasy.Text = "E"
        Me.rbnEasy.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1095, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 25)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Puzzle Type"
        '
        'lblNumPuzzles
        '
        Me.lblNumPuzzles.AutoSize = True
        Me.lblNumPuzzles.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumPuzzles.Location = New System.Drawing.Point(1362, 74)
        Me.lblNumPuzzles.Name = "lblNumPuzzles"
        Me.lblNumPuzzles.Size = New System.Drawing.Size(39, 42)
        Me.lblNumPuzzles.TabIndex = 20
        Me.lblNumPuzzles.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1347, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 25)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "puzzles"
        '
        'Form1
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1460, 433)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblNumPuzzles)
        Me.Controls.Add(Me.lblCount)
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
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.Opacity = 0.7R
        Me.Text = "Puzzle Generator"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents lblCount As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbnTheme As RadioButton
    Friend WithEvents rbnHard As RadioButton
    Friend WithEvents rbnMedium As RadioButton
    Friend WithEvents rbnEasy As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents lblNumPuzzles As Label
    Friend WithEvents Label6 As Label
End Class
