Imports System.ComponentModel
Imports System.IO
'git remote set-url origin https://github.com/kwishnu/PuzzleArrayGenerator.git


Public Class Form1
    Public strPuzzleType As String = "Medium"
    Public clipboardContents As String = ""
    Public strClipboard As String = ""
    Public started As Boolean = False
    Public onWord As Boolean = True
    Public detectingOnChange As Boolean = True
    Public Class PuzzString
        Public strPuzzle As String
        Public Sub New(strPuzzle As String)
            Me.strPuzzle = strPuzzle
        End Sub
        Public Sub setValue(strPuzzle As String)
            Me.strPuzzle = strPuzzle
        End Sub
    End Class


    'Make string for insertion into mongo database (insertMany)
    Private Sub btnMakeDatabaseString_Click(sender As Object, e As EventArgs) Handles btnMakeDatabaseString.Click
        If txtPackName.Text.Length < 1 Then
            MsgBox("Please enter the Pack's name")
            Return
        End If


        Dim puzzleString As String = ""
        Dim filePath As String = "D:\FragMental Puzzles\puzzles\" + txtPackName.Text + "\puzzles.txt"
        Dim allPuzzles As New List(Of PuzzString)
        Dim c As Integer = 0

        Try
            Dim sr As StreamReader = New StreamReader(filePath)
            Do While sr.Peek() >= 0
                puzzleString = sr.ReadLine()
                allPuzzles.Add(New PuzzString(puzzleString))
            Loop
            sr.Close()
        Catch err As Exception
            Console.WriteLine("The file could not be read:   ")
            Console.WriteLine(err.Message)
        End Try

        Dim outPath As String = "D:\FragMental Puzzles\mongoStrings\" + txtPackName.Text + "_insertString.txt"
        If Not File.Exists(outPath) Then
            File.Create(outPath).Dispose()
        End If

        Try
            Dim sw As StreamWriter = File.CreateText(outPath)
            sw.WriteLine("db.dataP.insertMany([")
            For Each puzzle In allPuzzles
                c = c + 1
                sw.WriteLine("	{")
                'sw.WriteLine("  pnum:" + Convert.ToString(c))
                sw.WriteLine("  pack:""" + txtPackName.Text.Trim() + """,")
                sw.WriteLine("  puzz:" + puzzle.strPuzzle)
                If c = CType(txtNumPuzzles.Text, Integer) Then
                    sw.WriteLine("	}")
                Else
                    sw.WriteLine("	},")
                End If
            Next
            sw.WriteLine("])")
            sw.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
    Private Sub btnPuzzStrArray_Click(sender As Object, e As EventArgs) Handles btnPuzzStrArray.Click
        Dim puzzleString As String = ""
        Dim filePath As String = "D:\FragMental Puzzles\puzzleStrings\" + strPuzzleType + "\puzzles.txt"
        Dim allPuzzles As New List(Of PuzzString)

        Try
            Dim sr As StreamReader = New StreamReader(filePath)
            Do While sr.Peek() >= 0
                puzzleString = sr.ReadLine()
                allPuzzles.Add(New PuzzString(puzzleString))
            Loop
            sr.Close()
        Catch err As Exception
            Console.WriteLine("The file could not be read:   ")
            Console.WriteLine(err.Message)
        End Try

        Dim outPath As String = "C:\Users\Diane\AndroidStudioProjects\Fragmental\puzzleArray.txt"

        Try
            Dim sw As StreamWriter = File.CreateText(outPath)

            sw.WriteLine("module.exports = [")

            For Each puzzle In allPuzzles
                sw.WriteLine("	{")
                sw.WriteLine("  puzzle: " + puzzle.strPuzzle)
                sw.WriteLine("	}")
            Next

            sw.WriteLine("];")
            sw.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub



    Private Sub btnMakePuzzlePack_Click(sender As Object, e As EventArgs) Handles btnMakePuzzlePack.Click
        If txtPackName.Text.Length < 1 Then
            MsgBox("Please enter the Pack's name")
            Return
        End If
        Dim allPuzzles As New List(Of String)
        Dim randomizedPuzzles As New List(Of String)
        Dim directoryPath As String = "D:\FragMental Puzzles\material\workingFiles\" + txtPackName.Text + "\"
        Dim directoryPathout As String = "D:\FragMental Puzzles\puzzles\" + txtPackName.Text + "\"
        Dim filePathout As String = directoryPathout + "puzzles.txt"

        If (Not Directory.Exists(directoryPathout)) Then
            Directory.CreateDirectory(directoryPathout)
        End If
        If Not File.Exists(filePathout) Then
            File.Create(filePathout).Dispose()
        End If

        Dim di As New DirectoryInfo(directoryPath)
        ' Get a reference to each file in the directory.
        Dim fi As FileInfo() = di.GetFiles()
        Dim fileinfo As FileInfo
        Dim frag As String = ""
        Dim fullPath As String = ""
        Dim strPuzzle As String = ""
        For Each fileinfo In fi
            fullPath = fileinfo.DirectoryName + "\" + fileinfo.Name
            frag = fileinfo.Name.Substring(0, fileinfo.Name.Length - 4)
            strPuzzle = makePuzzleString(fullPath, frag)
            allPuzzles.Add(New String(strPuzzle))
        Next fileinfo

        randomizedPuzzles = Shuffle(allPuzzles)
        Try
            Dim sw As StreamWriter = File.CreateText(filePathout)
            For Each puzzle In randomizedPuzzles
                sw.WriteLine(puzzle)
            Next
            sw.Close()
        Catch ex As Exception
            MsgBox(ex)
        End Try


    End Sub


    'Make puzzle string from file bearing txtFragment.Text's name
    Private Sub btnFragmentate_Click(sender As Object, e As EventArgs) Handles btnFragmentate.Click
        Dim filePath As String = "D:\FragMental Puzzles\puzzleStrings\" + strPuzzleType + "\" + txtFragment.Text + ".txt"
        Dim filePathout As String = "D:\FragMental Puzzles\puzzleStrings\" + strPuzzleType + "\puzzles.txt"
        Dim PuzzString As String = makePuzzleString(filePath, txtFragment.Text)
        Try
            Dim sw As StreamWriter = File.AppendText(filePathout)
            sw.WriteLine(PuzzString)
            sw.Close()
            txtFragment.Text = ""
            lblCount.Text = "0"
            lblNumPuzzles.Text = Convert.ToString(Convert.ToInt32(lblNumPuzzles.Text) + 1)
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub


    'Make puzzle delimited string to add to puzzle pack
    Public Function makePuzzleString(filePath As String, keyFrag As String)
        Dim puzzleString As String = ""
        Dim allLines As String()
        Dim allWords As String()
        Dim allClues As String()
        Dim position As Integer()
        Dim fragLength As Integer = keyFrag.Length
        Dim arrayCount As Integer = 0

        Try
            Dim sr As StreamReader = New StreamReader(filePath)
            Do While sr.Peek() >= 0
                puzzleString = sr.ReadLine()
                ReDim Preserve allLines(0 To arrayCount)
                allLines(arrayCount) = puzzleString
                arrayCount = arrayCount + 1
            Loop
            sr.Close()
        Catch err As Exception
            Console.WriteLine("The file could not be read:   ")
            Console.WriteLine(err.Message)
        End Try

        Dim arrayLength As Integer = arrayCount - 1
        Dim numFrags(0 To arrayLength, 0 To 1) As Integer
        ReDim position(0 To arrayLength)
        ReDim allWords(0 To arrayLength)
        ReDim allClues(0 To arrayLength)
        For i As Integer = 0 To arrayLength
            Dim splitLine As String() = allLines(i).Split("|")
            Dim str As String = splitLine(0).ToLower
            str = Replace(str, keyFrag, "^",, 1)
            allWords(i) = str
            allClues(i) = splitLine(1)
        Next

        Dim totalNumFrags As Integer = 0
        Dim Rand As New Random()
        Dim num As Integer = 0
        Dim loopCount As Integer = 0

        Do
            totalNumFrags = 0
            For j As Integer = 0 To arrayLength
                If (allWords(j).IndexOf("^") = 0) Then 'at beginning of word:
                    position(j) = 0
                ElseIf (allWords(j).IndexOf("^") = allWords(j).Length - 1) Then 'at end of word:
                    position(j) = 1
                Else 'somewhere in the middle of the word:
                    position(j) = 2
                End If
            Next
            Console.WriteLine("starting...")

            For m As Integer = 0 To arrayLength
                Dim r As Integer = 0
                Dim s As Integer = 0

                If position(m) = 2 Then
                    Select Case allWords(m).IndexOf("^")
                        Case 2
                            numFrags(m, 0) = 1
                            totalNumFrags += 1
                            Select Case allWords(m).Length
                                Case 5, 6
                                    numFrags(m, 1) = 1
                                    totalNumFrags = totalNumFrags + 1
                                Case 7
                                    r = Rand.Next(1, 3)
                                    numFrags(m, 1) = r
                                    totalNumFrags = totalNumFrags + r
                                Case 8
                                    numFrags(m, 1) = 2
                                    totalNumFrags = totalNumFrags + 2
                                Case 9, 10
                                    r = Rand.Next(2, 4)
                                    numFrags(m, 1) = r
                                    totalNumFrags = totalNumFrags + r
                                Case 11
                                    r = Rand.Next(2, 5)
                                    numFrags(m, 1) = r
                                    totalNumFrags = totalNumFrags + r
                            End Select
                        Case 3
                            numFrags(m, 0) = 1
                            totalNumFrags += 1
                            Select Case allWords(m).Length
                                Case 6, 7
                                    numFrags(m, 1) = 1
                                    totalNumFrags = totalNumFrags + 1
                                Case 8
                                    r = Rand.Next(1, 3)
                                    numFrags(m, 1) = r
                                    totalNumFrags = totalNumFrags + r
                                Case 9
                                    numFrags(m, 1) = 2
                                    totalNumFrags = totalNumFrags + 2
                                Case 10, 11
                                    r = Rand.Next(2, 4)
                                    numFrags(m, 1) = r
                                    totalNumFrags = totalNumFrags + r
                            End Select
                        Case 4
                            Select Case allWords(m).Length
                                Case 7, 8
                                    numFrags(m, 1) = 1
                                    r = Rand.Next(1, 3)
                                    numFrags(m, 0) = r
                                    totalNumFrags = totalNumFrags + r + 1
                                Case 9, 10
                                    r = Rand.Next(1, 3)
                                    s = Rand.Next(1, 3)
                                    numFrags(m, 0) = r
                                    numFrags(m, 1) = s
                                    totalNumFrags = totalNumFrags + r + s
                                Case 11
                                    r = Rand.Next(1, 3)
                                    s = Rand.Next(2, 4)
                                    numFrags(m, 0) = r
                                    numFrags(m, 1) = s
                                    totalNumFrags = totalNumFrags + r + s
                            End Select
                        Case 5
                            Select Case allWords(m).Length
                                Case 8, 9
                                    numFrags(m, 1) = 1
                                    numFrags(m, 0) = 2
                                    totalNumFrags = totalNumFrags + 3
                                Case 10
                                    r = Rand.Next(1, 3)
                                    numFrags(m, 0) = 2
                                    numFrags(m, 1) = r
                                    totalNumFrags = totalNumFrags + r + 2
                                Case 11
                                    numFrags(m, 0) = 2
                                    numFrags(m, 1) = 2
                                    totalNumFrags = totalNumFrags + 4
                            End Select
                        Case 6
                            Select Case allWords(m).Length
                                Case 9, 10
                                    numFrags(m, 1) = 1
                                    r = Rand.Next(2, 4)
                                    numFrags(m, 0) = r
                                    totalNumFrags = totalNumFrags + r + 1
                                Case 11
                                    r = Rand.Next(2, 4)
                                    s = Rand.Next(1, 3)
                                    numFrags(m, 0) = r
                                    numFrags(m, 1) = s
                                    totalNumFrags = totalNumFrags + r + s
                            End Select
                        Case 7
                            Select Case allWords(m).Length
                                Case 10, 11
                                    numFrags(m, 1) = 1
                                    r = Rand.Next(2, 4)
                                    numFrags(m, 0) = r
                                    totalNumFrags = totalNumFrags + r + 1
                            End Select

                        Case 8
                            Select Case allWords(m).Length
                                Case 10, 11
                                    numFrags(m, 1) = 1
                                    r = Rand.Next(2, 5)
                                    numFrags(m, 0) = r
                                    totalNumFrags = totalNumFrags + r + 1
                            End Select
                    End Select

                Else
                    Select Case allWords(m).Length
                        Case 3, 4
                            num = 1
                        Case 5
                            num = Rand.Next(1, 3)
                        Case 6
                            num = 2
                        Case 7, 8
                            num = Rand.Next(2, 4)
                        Case 9
                            num = Rand.Next(2, 5)
                        Case 10
                            num = Rand.Next(3, 5)
                        Case 11
                            num = Rand.Next(3, 6)
                    End Select
                    Console.WriteLine(num)

                    totalNumFrags = totalNumFrags + num
                    If position(m) = 0 Then
                        numFrags(m, 0) = 0
                        numFrags(m, 1) = num
                    Else
                        numFrags(m, 1) = 0
                        numFrags(m, 0) = num
                    End If
                End If
                If loopCount = 199 Then
                    MsgBox("Timed Out" + allWords(m))
                    Exit Function
                End If
            Next
            Console.WriteLine(totalNumFrags)
            loopCount += 1
        Loop Until totalNumFrags = 20 Or loopCount = 200


        Dim delimWords(0 To arrayLength) As String
        For n As Integer = 0 To arrayLength
            Dim skipToNextOccurence As Boolean = If(allWords(n).IndexOf("^") = 1, True, False)

            Dim strLeftSide = ""
            If position(n) = 0 Then
                delimWords(n) = "^" + fragmentateString(allWords(n).Substring(1), numFrags(n, 1)) + ":" + allClues(n)
            ElseIf position(n) = 1 Then
                Dim strBack As String = fragmentateString(allWords(n).Substring(0, allWords(n).Length - 1), numFrags(n, 0))
                delimWords(n) = strBack.Substring(1) + "|^:" + allClues(n)
            Else
                Dim firstHalf As String = ""
                Dim secondHalf As String = ""
                firstHalf = fragmentateString(allWords(n).Substring(0, allWords(n).IndexOf("^")), numFrags(n, 0))
                secondHalf = fragmentateString(allWords(n).Substring(allWords(n).IndexOf("^") + 1), numFrags(n, 1))
                delimWords(n) = firstHalf.Substring(1) + "|^" + secondHalf + ":" + allClues(n)
            End If
        Next
        Dim puzzString As String = keyFrag + "~" + Join(delimWords, "**")
        puzzString = puzzString.Replace("'", "\'")
        puzzString = "'" + puzzString + "'"

        Return puzzString

    End Function



    Public Function fragmentateString(str As String, n As Integer)
        'Break str into n fragments...
        Dim rnd As New Random()
        Dim arrangements As Integer = 0
        Dim strToReturn As String = ""

        Select Case str.Length
            Case 2, 3
                strToReturn = "|" + str
            Case 4
                strToReturn = If(n = 1, ("|" + str), ("|" + str.Substring(0, 2) + "|" + str.Substring(2)))
            Case 5
                strToReturn = If(n = 1, ("|" + str.Substring(0, 2) + "|" + str.Substring(2)), ("|" + str.Substring(0, 3) + "|" + str.Substring(3)))
            Case 6
                If (n = 2) Then
                    arrangements = rnd.Next(1, 4)
                    Select Case arrangements
                        Case 1
                            strToReturn = "|" + str.Substring(0, 3) + "|" + str.Substring(3)
                        Case 2
                            strToReturn = "|" + str.Substring(0, 2) + "|" + str.Substring(2)
                        Case 3
                            strToReturn = "|" + str.Substring(0, 4) + "|" + str.Substring(4)
                    End Select
                Else
                    strToReturn = "|" + str.Substring(0, 2) + "|" + str.Substring(2, 2) + "|" + str.Substring(4)
                End If
            Case 7
                If (n = 2) Then
                    arrangements = rnd.Next(1, 3)
                    Select Case arrangements
                        Case 1
                            strToReturn = "|" + str.Substring(0, 3) + "|" + str.Substring(3)
                        Case 2
                            strToReturn = "|" + str.Substring(0, 4) + "|" + str.Substring(4)
                    End Select
                Else
                    arrangements = rnd.Next(1, 4)
                    Select Case arrangements
                        Case 1
                            strToReturn = "|" + str.Substring(0, 2) + "|" + str.Substring(2, 2) + "|" + str.Substring(4)
                        Case 2
                            strToReturn = "|" + str.Substring(0, 2) + "|" + str.Substring(2, 3) + "|" + str.Substring(5)
                        Case 3
                            strToReturn = "|" + str.Substring(0, 3) + "|" + str.Substring(3, 2) + "|" + str.Substring(5)
                    End Select
                End If
            Case 8
                Select Case n
                    Case 2
                        strToReturn = "|" + str.Substring(0, 4) + "|" + str.Substring(4)
                    Case 3
                        strToReturn = breakInThree(str)
                    Case 4
                        strToReturn = "|" + str.Substring(0, 2) + "|" + str.Substring(2, 2) + "|" + str.Substring(4, 2) + "|" + str.Substring(6)
                End Select
            Case 9
                Select Case n
                    Case 3
                        strToReturn = breakInThree(str)
                    Case 4
                        strToReturn = breakInFour(str)
                End Select
            Case 10, 11
                Select Case n
                    Case 3
                        strToReturn = breakInThree(str)
                    Case 4
                        strToReturn = breakInFour(str)
                    Case 5
                        strToReturn = breakInFive(str)
                End Select
        End Select

        Return strToReturn
    End Function
    Public Function breakInTwo(strSent As String)
        Dim strToReturn As String = ""
        Dim rnd As New Random()
        Dim x As Integer = 0
        Select Case strSent.Length
            Case 4
                strToReturn = "|" + strSent.Substring(0, 2) + "|" + strSent.Substring(2)
            Case 5
                x = rnd.Next(1, 3)
                strToReturn = If(x = 1, ("|" + strSent.Substring(0, 2) + "|" + strSent.Substring(2)), ("|" + strSent.Substring(0, 3) + "|" + strSent.Substring(3)))
            Case 6
                x = rnd.Next(1, 4)
                Select Case x
                    Case 1
                        strToReturn = "|" + strSent.Substring(0, 3) + "|" + strSent.Substring(3)
                    Case 2
                        strToReturn = "|" + strSent.Substring(0, 2) + "|" + strSent.Substring(2)
                    Case 3
                        strToReturn = "|" + strSent.Substring(0, 4) + "|" + strSent.Substring(4)
                End Select
            Case 7
                x = rnd.Next(1, 3)
                Select Case x
                    Case 1
                        strToReturn = "|" + strSent.Substring(0, 3) + "|" + strSent.Substring(3)
                    Case 2
                        strToReturn = "|" + strSent.Substring(0, 4) + "|" + strSent.Substring(4)
                End Select
            Case 8
                strToReturn = "|" + strSent.Substring(0, 4) + "|" + strSent.Substring(4)
        End Select

        Return strToReturn
    End Function
    Public Function breakInThree(strSent As String)
        Dim strToReturn As String = ""
        Dim rnd As New Random()
        Dim x As Integer = 0
        Select Case strSent.Length
            Case 6
                strToReturn = "|" + strSent.Substring(0, 2) + "|" + strSent.Substring(2, 2) + "|" + strSent.Substring(4)
            Case 7
                x = rnd.Next(1, 4)
                Select Case x
                    Case 1
                        strToReturn = "|" + strSent.Substring(0, 2) + "|" + strSent.Substring(2, 2) + "|" + strSent.Substring(4)
                    Case 2
                        strToReturn = "|" + strSent.Substring(0, 2) + "|" + strSent.Substring(2, 3) + "|" + strSent.Substring(5)
                    Case 3
                        strToReturn = "|" + strSent.Substring(0, 3) + "|" + strSent.Substring(3, 2) + "|" + strSent.Substring(5)
                End Select
            Case 8
                x = rnd.Next(1, 4)
                Select Case x
                    Case 1
                        strToReturn = "|" + strSent.Substring(0, 2) + breakInTwo(strSent.Substring(2))
                    Case 2
                        strToReturn = "|" + strSent.Substring(0, 3) + breakInTwo(strSent.Substring(3))
                    Case 3
                        strToReturn = "|" + strSent.Substring(0, 4) + breakInTwo(strSent.Substring(4))
                End Select
            Case 9
                x = rnd.Next(1, 4)
                Select Case x
                    Case 1
                        strToReturn = "|" + strSent.Substring(0, 2) + breakInTwo(strSent.Substring(2))
                    Case 2
                        strToReturn = "|" + strSent.Substring(0, 3) + breakInTwo(strSent.Substring(3))
                    Case 3
                        strToReturn = "|" + strSent.Substring(0, 4) + breakInTwo(strSent.Substring(4))
                End Select
            Case 10
                x = rnd.Next(1, 4)
                Select Case x
                    Case 1
                        strToReturn = "|" + strSent.Substring(0, 2) + breakInTwo(strSent.Substring(2))
                    Case 2
                        strToReturn = "|" + strSent.Substring(0, 3) + breakInTwo(strSent.Substring(3))
                    Case 3
                        strToReturn = "|" + strSent.Substring(0, 4) + breakInTwo(strSent.Substring(4))
                End Select
        End Select

        Return strToReturn
    End Function
    Public Function breakInFour(strSent As String)
        Dim strToReturn As String = ""
        Dim rnd As New Random()
        Dim x As Integer = 0
        Select Case strSent.Length
            Case 8
                strToReturn = "|" + strSent.Substring(0, 2) + breakInThree(strSent.Substring(2))
            Case 9
                x = rnd.Next(1, 3)
                Select Case x
                    Case 1
                        strToReturn = "|" + strSent.Substring(0, 2) + breakInThree(strSent.Substring(2))
                    Case 2
                        strToReturn = "|" + strSent.Substring(0, 3) + breakInThree(strSent.Substring(3))
                End Select
            Case 10
                x = rnd.Next(1, 4)
                Select Case x
                    Case 1
                        strToReturn = "|" + strSent.Substring(0, 2) + breakInThree(strSent.Substring(2))
                    Case 2
                        strToReturn = "|" + strSent.Substring(0, 3) + breakInThree(strSent.Substring(3))
                    Case 3
                        strToReturn = "|" + strSent.Substring(0, 4) + breakInThree(strSent.Substring(4))
                End Select
        End Select

        Return strToReturn
    End Function
    Public Function breakInFive(strSent As String)
        Dim strToReturn As String = ""
        strToReturn = "|" + strSent.Substring(0, 2) + breakInFour(strSent.Substring(2))
        Return strToReturn
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        strClipboard = Clipboard.GetText()
        If (started = True) Then
            If Not (String.Equals(strClipboard, clipboardContents)) Then
                If (onWord = True) Then
                    txtWord.Text = strClipboard.ToLower
                    onWord = False
                Else
                    Dim array() As Char = strClipboard.Trim.ToCharArray
                    array(0) = Char.ToUpper(array(0))
                    Dim strNew As New String(array)
                    txtClue.Text = strNew
                    Me.Focus()
                    btnEnter.Focus()
                    onWord = True
                End If
                clipboardContents = strClipboard
            End If
        Else
            clipboardContents = strClipboard
            started = True
        End If
    End Sub
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If txtFragment.Text.Length < 1 Then
            MsgBox("Please enter letters in the Fragment box")
            Return
        End If
        If txtWord.Text.Length > 12 Then
            MsgBox("That word is more than 12 letters")
            Return
        End If

        Dim outPath As String = "D:\FragMental Puzzles\puzzleStrings\" + strPuzzleType + "\" + txtFragment.Text + ".txt"

        If Not File.Exists(outPath) Then
            File.Create(outPath).Dispose()
        End If

        Try
            Dim sw As StreamWriter = File.AppendText(outPath)
            Dim outString As String = txtWord.Text.ToLower.Trim + "|" + txtClue.Text.Trim
            sw.WriteLine(outString)
            sw.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        lblCount.Text = Convert.ToString(Convert.ToInt32(lblCount.Text) + txtWord.Text.Length - txtFragment.Text.Length)
        onWord = True
        txtWord.Text = ""
        txtClue.Text = ""
        txtWord.Focus()
    End Sub
    Private Sub txtWord_TextChanged(sender As Object, e As EventArgs) Handles txtWord.TextChanged
        If (detectingOnChange) Then
            txtClue.Focus()
        End If
    End Sub
    Private Sub btnTwoWords_Click(sender As Object, e As EventArgs) Handles btnTwoWords.Click
        Dim wordText() As String = txtWord.Text.Split(" ")
        Dim strNew As String = String.Join("", wordText)
        txtWord.Text = strNew
        txtClue.Text += " (2 words)"
    End Sub
    Private Sub btnThreeWords_Click(sender As Object, e As EventArgs) Handles btnThreeWords.Click
        Dim wordText() As String = txtWord.Text.Split(" ")
        Dim strNew As String = String.Join("", wordText)
        txtWord.Text = strNew
        txtClue.Text += " (3 words)"
    End Sub
    Private Sub btnAddSnippet_Click(sender As Object, e As EventArgs) Handles btnAddSnippet.Click
        Dim array() As Char = txtClue.Text.ToCharArray
        array(0) = Char.ToLower(array(0))
        Dim strNew As New String(array)

        txtClue.Text = txtSnippet.Text + " " + strNew
    End Sub
    Private Sub btnDisableOnChange_Click(sender As Object, e As EventArgs) Handles btnDisableOnChange.Click
        If (detectingOnChange) Then
            detectingOnChange = False
            btnDisableOnChange.Text = "Reset"
        Else
            detectingOnChange = True
            btnDisableOnChange.Text = "Allow entry..."
        End If
        txtWord.Focus()
    End Sub
    Private Sub rbnEasy_CheckedChanged(sender As Object, e As EventArgs) Handles rbnEasy.CheckedChanged
        If rbnEasy.Checked = True Then
            strPuzzleType = "Easy"
        End If
    End Sub
    Private Sub rbnMedium_CheckedChanged(sender As Object, e As EventArgs) Handles rbnMedium.CheckedChanged
        If rbnMedium.Checked = True Then
            strPuzzleType = "Medium"
        End If

    End Sub
    Private Sub rbnHard_CheckedChanged(sender As Object, e As EventArgs) Handles rbnHard.CheckedChanged
        If rbnHard.Checked = True Then
            strPuzzleType = "Hard"
        End If

    End Sub
    Private Sub rbnTheme_CheckedChanged(sender As Object, e As EventArgs) Handles rbnTheme.CheckedChanged
        If rbnTheme.Checked = True Then
            strPuzzleType = "Theme"
        End If

    End Sub
    Private Sub lblCount_Click(sender As Object, e As EventArgs) Handles lblCount.Click
        lblCount.Text = "0"
    End Sub
    Private Sub lblNumPuzzles_Click(sender As Object, e As EventArgs) Handles lblNumPuzzles.Click
        lblNumPuzzles.Text = Convert.ToString(Convert.ToInt32(lblNumPuzzles.Text) + 1)
    End Sub
    Private Sub lblNumPuzzles_DoubleClick(sender As Object, e As EventArgs) Handles lblNumPuzzles.DoubleClick
        lblNumPuzzles.Text = "0"
    End Sub




    'Remove duplicates from list of words, confine lengths to 4=>12 characters, add pipe:

    Private Sub btnRemoveDups_Click(sender As Object, e As EventArgs) Handles btnRemoveDups.Click
        Dim puzzleString As String = ""
        Dim filePath As String = "D:\FragMental Puzzles\material\wordlist.txt"
        Dim filePathout As String = "D:\FragMental Puzzles\material\_wordlist.txt"
        Dim rightLength As New List(Of String)
        Dim allLines As New List(Of String)

        Try
            Dim sr As StreamReader = New StreamReader(filePath)
            Do While sr.Peek() >= 0
                puzzleString = sr.ReadLine()
                puzzleString = puzzleString.Trim
                puzzleString = puzzleString.Replace("'s", "s")

                If puzzleString.Length > 3 And puzzleString.Length < 13 And puzzleString.IndexOf("'") < 0 Then
                    puzzleString = puzzleString.ToLower

                    'If String.IsNullOrEmpty(splitToCheck(1)) Then
                    '    splitToCheck(1) = "***"
                    'End If

                    'Dim array() As Char = splitToCheck(1).ToCharArray
                    'array(0) = Char.ToUpper(array(0))
                    'Dim wordPlusclue As New String(array)

                    'wordPlusclue = splitToCheck(0) + "|" + wordPlusclue
                    'puzzleString = puzzleString + "|" + "Clue"

                    rightLength.Add(New String(puzzleString))
                End If

            Loop
            sr.Close()
        Catch err As Exception
            Console.WriteLine("The file could not be read:   ")
            Console.WriteLine(err.Message)
        End Try

        For Each word In rightLength
            If (String.Equals(puzzleString.Substring(1, 1).ToUpper, puzzleString.Substring(1, 1)) = False) Then
                allLines.Add(New String(word))
            End If
        Next

        Dim noDupList As List(Of String) = removeDuplicates(allLines)
        If Not File.Exists(filePathout) Then
            File.Create(filePathout).Dispose()
        End If

        Try
            Dim sw As StreamWriter = File.CreateText(filePathout)

            For Each line In allLines
                sw.WriteLine(line)
            Next
            sw.Close()
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub


    Private Sub btnCreatePuzzleFiles_Click(sender As Object, e As EventArgs) Handles btnCreatePuzzleFiles.Click
        Dim letterCombos() As String = {"al", "an", "ar", "as", "at", "ea", "en", "es", "ha", "he", "hi", "in", "is", "it", "le", "me", "nd", "ne", "nt", "on", "or", "ou", "re", "se", "st", "te", "th", "ti", "to", "ve", "wa", "and", "are", "but", "era", "ere", "eve", "for", "had", "hat", "hen", "her", "hin", "his", "ith", "not", "ome", "sho", "ted", "ter", "tha", "the", "thi", "ver"}
        Dim usedCombos(50) As String
        Dim onThisPuzzle As Integer = 0
        Dim keyFrag As String = ""
        Dim filePath As String = "D:\FragMental Puzzles\material\wordlist.txt"
        Dim filePathout As String = ""
        Dim directoryPath As String = ""
        Dim letterCount As Integer = 0
        Dim wordsThatWork As New List(Of String)

        Do
            Do
                Dim tryThisCombo As String = letterCombos(New Random().Next(0, letterCombos.Length - 1))
                If Not usedCombos.Contains(tryThisCombo) Then
                    keyFrag = tryThisCombo
                    usedCombos(onThisPuzzle) = keyFrag
                    onThisPuzzle = onThisPuzzle + 1
                End If
            Loop Until keyFrag.Length > 0
            Try
                Dim sr As StreamReader = New StreamReader(filePath)
                Dim checkThisWord As String = ""
                Do While sr.Peek() >= 0 And letterCount < 58
                    checkThisWord = sr.ReadLine()
                    checkThisWord = checkThisWord.Trim
                    If checkThisWord.Length - keyFrag.Length > 1 Then
                        If checkThisWord.IndexOf(keyFrag) > -1 Then
                            If checkThisWord.Substring(0, keyFrag.Length) = keyFrag Or checkThisWord.Substring(checkThisWord.Length - keyFrag.Length) = keyFrag Then
                                If checkThisWord.IndexOf(keyFrag) <> 1 And checkThisWord.IndexOf(keyFrag) <> checkThisWord.Length - (keyFrag.Length + 1) Then
                                    wordsThatWork.Add(New String(checkThisWord))
                                    letterCount += checkThisWord.Length - keyFrag.Length
                                End If
                            End If
                        End If
                    End If
                Loop
                letterCount = 0
                sr.Close()
            Catch err As Exception
                Console.WriteLine("The file could not be read:   ")
                Console.WriteLine(err.Message)
            End Try

            directoryPath = "D:\FragMental Puzzles\material\workingFiles\" + txtPackName.Text + "\"
            filePathout = directoryPath + keyFrag + ".txt"

            If (Not Directory.Exists(directoryPath)) Then
                Directory.CreateDirectory(directoryPath)
            End If
            If Not File.Exists(filePathout) Then
                File.Create(filePathout).Dispose()
            End If

            Try
                Dim sw As StreamWriter = File.CreateText(filePathout)

                For Each line In wordsThatWork
                    sw.WriteLine(line + "|Clue")
                Next
                sw.Close()
            Catch ex As Exception
                MsgBox(ex)
            End Try
            wordsThatWork.Clear()
            'RandomizeFile(filePath)
        Loop Until onThisPuzzle = 50
    End Sub



    Public Function RandomizeFile(path)

        Dim puzzleString As String = ""
        Dim filePath As String = path
        Dim filePathout As String = "D:\FragMental Puzzles\material\wordlist.txt"

        Dim allLines As New List(Of PuzzString)

        Try
            Dim sr As StreamReader = New StreamReader(filePath)
            Do While sr.Peek() >= 0
                puzzleString = sr.ReadLine()
                allLines.Add(New PuzzString(puzzleString))
            Loop
            sr.Close()
        Catch err As Exception
            Console.WriteLine("The file could not be read:   ")
            Console.WriteLine(err.Message)
        End Try

        allLines = ShuffleList(allLines)

        Try
            Dim sw As StreamWriter = File.CreateText(filePathout)

            For Each line In allLines
                sw.WriteLine(line.strPuzzle)
            Next
            sw.Close()
        Catch ex As Exception
        End Try


    End Function

    Function Shuffle(Of T)(collection As IEnumerable(Of T)) As List(Of T)
        Dim r As Random = New Random()
        Shuffle = collection.OrderBy(Function(a) r.Next()).ToList()
        Return Shuffle
    End Function
    Public Function ShuffleList(datalist)

        Dim x As Integer
        Dim r As Random = New Random()
        Dim str As String

        For i As Integer = datalist.Count - 1 To 0 Step -1
            x = Math.Floor(r.NextDouble() * (i + 1)) 'r.Next(0, i)
            str = datalist(x).strPuzzle
            datalist(x).setValue(datalist(i).strPuzzle)
            datalist(i).setValue(str)
        Next i
        Return datalist

    End Function

    Private Shared Function removeDuplicates(inputList As List(Of String)) As List(Of String)
        Dim uniqueStore As New Dictionary(Of String, Integer)()
        Dim finalList As New List(Of String)()
        For Each currValue As String In inputList
            If Not uniqueStore.ContainsKey(currValue) Then
                uniqueStore.Add(currValue, 0)
                finalList.Add(currValue)
            End If
        Next
        Return finalList
    End Function

    Private Sub btnRandomize_Click(sender As Object, e As EventArgs) Handles btnRandomize.Click
        RandomizeFile("D:\FragMental Puzzles\material\_wordlist.txt")
    End Sub



    'If Not File.Exists(outPath) Then
    '        File.Create(outPath).Dispose()
    'End If

End Class
