Imports System.ComponentModel
Imports System.IO
'git remote set-url origin https://github.com/kwishnu/PuzzleArrayGenerator.git


Public Class Form1

    Public outputFileName As String = "C:\Users\Diane\AndroidStudioProjects\Fragmental\puzzle_data.txt"
    Public strPuzzleData As String = ""
    Public arrOfFragCombos = {{({2, 2}), ({2, 2}), ({2, 2}), ({2, 2}), ({2, 2}), ({2, 2})}, {({2, 3}), ({2, 3}), ({2, 3}), ({2, 3}), ({2, 3}), ({2, 3})}, {({2, 2, 2}), ({3, 3}), ({2, 2, 2}), ({2, 2, 2}), ({3, 3}), ({3, 3})}, {({2, 2, 3}), ({2, 2, 3}), ({2, 2, 3}), ({2, 2, 3}), ({2, 2, 3}), ({2, 2, 3})}, {({2, 2, 2, 2}), ({2, 3, 3}), ({2, 2, 4}), ({2, 2, 4}), ({2, 2, 2, 2}), ({2, 3, 3})}, {({2, 2, 2, 3}), ({2, 3, 4}), ({3, 3, 3}), ({2, 2, 2, 3}), ({2, 3, 4}), ({3, 3, 3})}, {({2, 2, 2, 2, 2}), ({2, 2, 3, 3}), ({2, 2, 2, 4}), ({2, 2, 2, 4}), ({2, 2, 3, 3}), ({2, 2, 3, 3})}, {({2, 2, 2, 2, 3}), ({2, 2, 3, 4}), ({2, 3, 3, 3}), ({2, 2, 3, 4}), ({2, 3, 3, 3}), ({2, 3, 3, 3})}, {({2, 2, 2, 3, 3}), ({2, 3, 3, 4}), ({2, 2, 4, 4}), ({3, 3, 3, 3}), ({3, 3, 3, 3}), ({2, 3, 3, 4})}}
    Public strArrOfFragCombos = {{"2, 2", "2, 2", "2, 2", "2, 2", "2, 2", "2, 2"}, {"2, 3", "2, 3", "2, 3", "2, 3", "2, 3", "2, 3"}, {"2, 2, 2", "3, 3", "2, 2, 2", "2, 2, 2", "3, 3", "3, 3"}, {"2, 2, 3", "2, 2, 3", "2, 2, 3", "2, 2, 3", "2, 2, 3", "2, 2, 3"}, {"2, 2, 2, 2", "2, 3, 3", "2, 2, 4", "2, 2, 4", "2, 2, 2, 2", "2, 3, 3"}, {"2, 2, 2, 3", "2, 3, 4", "3, 3, 3", "2, 2, 2, 3", "2, 3, 4", "3, 3, 3"}, {"2, 2, 2, 2, 2", "2, 2, 3, 3", "2, 2, 2, 4", "2, 2, 2, 4", "2, 2, 3, 3", "2, 2, 3, 3"}, {"2, 2, 2, 2, 3", "2, 2, 3, 4", "2, 3, 3, 3", "2, 2, 3, 4", "2, 3, 3, 3", "2, 3, 3, 3"}, {"2, 2, 2, 3, 3", "2, 3, 3, 4", "2, 2, 4, 4", "3, 3, 3, 3", "3, 3, 3, 3", "2, 3, 3, 4"}}

    Public Class PuzzString
        Public strPuzzle As String
        Public Sub New(strPuzzle As String)
            Me.strPuzzle = strPuzzle
        End Sub
        Public Sub setValue(strPuzzle As String)
            Me.strPuzzle = strPuzzle
        End Sub
    End Class

    Structure Pair
        Dim word As String
        Dim clue As String
    End Structure

    Class PuzzPair
        Public word As String
        Public clue As String
        Public flag As Integer
        Public Sub New(word As String, clue As String, flag As Integer)
            Me.word = word
            Me.clue = clue
            Me.flag = flag
        End Sub
        Public Sub setFlag(value As Integer)
            Me.flag = value
        End Sub

    End Class

    Structure puzzleFrag
        Public frag As String
        Public Sub New(frag As String)
            Me.frag = frag
        End Sub
    End Structure

    Class numbers
        Public num As Integer
        Public Sub New(num As Integer)
            Me.num = num
        End Sub
        Public Sub setNum(sent As Integer)
            Me.num = sent
        End Sub
    End Class

    Class wordParameters
        Public wordLength As Integer
        Public fragArrangement() As Integer
        Public listIndex As Integer
        Public Sub New(wordLength As Integer, fragArrangement() As Integer, listIndex As Integer)
            Me.wordLength = wordLength
            Me.fragArrangement = fragArrangement
            Me.listIndex = listIndex
        End Sub
        Public Sub changeIndex(value As Integer)
            Me.listIndex = value
        End Sub
        Public Sub changeArrangement(value() As Integer)
            Me.fragArrangement = value
        End Sub
    End Class


    Private Sub btnCullPuzzleData_Click(sender As Object, e As EventArgs) Handles btnCullPuzzleData.Click
        Dim strXWord As String = ""
        Dim theWord, theClue As String

        Try
            Using sr As New StreamReader("C:\Users\Diane\AndroidStudioProjects\Fragmental\list_of_words.txt")
                strXWord = sr.ReadToEnd()
            End Using
        Catch err As Exception
            Console.WriteLine("The file could not be read:   ")
            Console.WriteLine(err.Message)
        End Try

        Dim strFrags As String() = strXWord.Split("|")
        Dim wordClueList(2600) As Pair
        Dim count As Integer = 0

        For Each frag In strFrags
            If (frag.IndexOf("^") > 3) Then
                theWord = frag.Substring(0, frag.IndexOf("^"))
                theClue = frag.Substring(frag.IndexOf("^") + 1, frag.IndexOf("~") - frag.IndexOf("^") - 1)
                wordClueList(count).word = theWord
                wordClueList(count).clue = theClue
                count = count + 1
            End If
        Next

        Try
            Dim sw As StreamWriter = File.AppendText(outputFileName)
            For i As Integer = 0 To wordClueList.Count - 1
                sw.WriteLine(wordClueList(i).word + "|" + wordClueList(i).clue)
            Next
            sw.Close()
        Catch ex As Exception
        End Try



    End Sub

    Private Sub btnWordDefinitions_Click(sender As Object, e As EventArgs) Handles btnWordDefinitions.Click
        Dim crosswordFilePath As String = "C:\Users\Diane\AndroidStudioProjects\Fragmental\list_of_words.txt"
        Dim dictionary As String = "C:\Users\Diane\AndroidStudioProjects\Fragmental\websters_dictionary.txt"
        Dim wordList As New List(Of PuzzString)
        Dim strWord As String = ""
        Dim strDictionary As String = ""

        Try
            Using sr As New StreamReader(dictionary)
                strDictionary = sr.ReadToEnd()
            End Using
        Catch err As Exception
            Console.WriteLine("The file could not be read:   ")
            Console.WriteLine(err.Message)
        End Try

        Try
            Dim sr As StreamReader = New StreamReader(crosswordFilePath)
            Do While sr.Peek() >= 0
                strWord = sr.ReadLine()
                strWord = strWord.Trim

                If strWord.Length > 3 And strWord.Length < 13 And Not String.IsNullOrWhiteSpace(strWord) Then
                    wordList.Add(New PuzzString(strWord))
                End If
            Loop
            sr.Close()
        Catch err As Exception
            Console.WriteLine("The file could not be read:   ")
            Console.WriteLine(err.Message)
        End Try


        Dim noDupList As List(Of PuzzString) = wordList.Distinct().ToList

        Dim theWord As String = ""

        Try
            'Dim characterAfter As String = strDictionary.Substring(strDictionary.IndexOf(theWord) + theWord.Length, 1)
            'Dim characterBefore As String = strDictionary.Substring(strDictionary.IndexOf(theWord) - 1, 1)

            Dim theDefinition As String = ""

            For Each word In noDupList
                theWord = word.strPuzzle
                theWord = theWord.ToUpper.Trim
                Dim wordPipeDefinition As String = theWord + "|Nada"
                Dim theWordCheck As String = vbLf + theWord + vbCrLf
                Dim startOfWord As Integer = strDictionary.IndexOf(theWordCheck)
                'startOfWord = strDictionary.IndexOf(theWordCheck, startOfWord + 1)

                'Dim addOne As Integer = 1

                'Do
                '    startOfWord = strDictionary.IndexOf(theWord, addOne)
                '    addOne += startOfWord

                '    wordPlus2 = strDictionary.Substring(startOfWord - 1, theWord.Length + 2)
                'Loop Until (wordPlus2.IndexOf(vbCr) > -1 And wordPlus2.IndexOf(vbLf) > -1)

                If (startOfWord > -1) Then
                    theDefinition = strDictionary.Substring(startOfWord + 1, 500)
                    theDefinition = theDefinition.Replace("\r\n", String.Empty).Replace("\n", String.Empty).Replace(vbCrLf, String.Empty)
                    Dim startOfDefn = theDefinition.IndexOf("Defn: ")
                    Dim startOf1 = theDefinition.IndexOf("1. ")
                    Dim lengthToUse As Integer = 0


                    If (startOfDefn > -1 And startOfDefn < 120) Then
                        If (theDefinition.IndexOf(".", startOfDefn + 7) > -1) Then
                            wordPipeDefinition = theWord.ToLower + "|" + theDefinition.Substring(startOfDefn + 6, (theDefinition.IndexOf(".", startOfDefn + 7) - (startOfDefn + 6)))
                        Else
                            wordPipeDefinition = theWord.ToLower + "|" + theDefinition.Substring(startOfDefn + 6)
                        End If

                    ElseIf (startOf1 > -1) Then
                        If (theDefinition.IndexOf(".", startOf1 + 4) > -1) Then
                            wordPipeDefinition = theWord.ToLower + "|" + theDefinition.Substring(startOf1 + 3, (theDefinition.IndexOf(".", startOf1 + 4) - (startOf1 + 3)))
                        Else
                            wordPipeDefinition = theWord.ToLower + "|" + theDefinition.Substring(startOf1 + 3)
                        End If
                    Else
                        wordPipeDefinition = theWord.ToLower + "|" + "No definition found**************************************************"

                    End If
                End If

                word.setValue(wordPipeDefinition)
            Next

            Dim outPath As String = "C:\Users\Diane\AndroidStudioProjects\Fragmental\wordPlusDefinition.txt"

            If Not System.IO.File.Exists(outPath) Then
                System.IO.File.Create(outPath).Dispose()
            End If

            Try
                Dim sw As StreamWriter = File.AppendText(outPath)
                For Each item In noDupList
                    sw.WriteLine(item.strPuzzle)

                    item.setValue("")
                Next
                sw.Close()

            Catch ex As Exception
                MsgBox("Failed on " + ex.ToString)

            End Try

        Catch ex As Exception
            MsgBox("Failed on " + theWord)
        End Try
        For Each item In wordList
            item.setValue("")
        Next



    End Sub


    Private Sub move_to_file_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim strWordPlusClue As String = ""
        Dim theFrag As String = txtFragment.Text.Trim
        Dim sourcePath As String = "C:\Users\Diane\AndroidStudioProjects\Fragmental\test.txt"
        Dim outPath As String = "C:\Users\Diane\AndroidStudioProjects\Fragmental\_" + theFrag + ".txt"
        Dim wordClueSource As New List(Of PuzzString)
        Dim wordClueOut As New List(Of PuzzString)

        Try
            Dim sr As StreamReader = New StreamReader(sourcePath)
            Do While sr.Peek() >= 0
                strWordPlusClue = sr.ReadLine()
                Dim splitOnPipe() As String = strWordPlusClue.Split("|")
                Dim wordHalf As String = splitOnPipe(0)
                If (wordHalf.IndexOf(theFrag) > -1 And wordHalf.Substring(0, theFrag.Length) = theFrag) Or (wordHalf.Substring(wordHalf.Length - theFrag.Length, theFrag.Length) = theFrag) Or (wordHalf.IndexOf(theFrag) > theFrag.Length And wordHalf.IndexOf(theFrag) < wordHalf.Length - (theFrag.Length + 2)) Then
                    wordClueOut.Add(New PuzzString(strWordPlusClue))
                Else
                    wordClueSource.Add(New PuzzString(strWordPlusClue))
                End If
            Loop
            sr.Close()
        Catch err As Exception
            Console.WriteLine("The file could not be read:   ")
            Console.WriteLine(err.Message)
        End Try


        Try
            Dim sw As StreamWriter = File.AppendText(outPath)
            For Each item In wordClueOut
                sw.WriteLine(item.strPuzzle)
            Next

            sw.Close()
        Catch ex As Exception

        End Try

        Try
            Dim sx As StreamWriter = File.CreateText(sourcePath)
            For Each item2 In wordClueSource
                sx.WriteLine(item2.strPuzzle)
            Next

            sx.Close()
        Catch ex As Exception

        End Try




    End Sub


    Private Sub btnMakeArray_Click(sender As Object, e As EventArgs) Handles btnMakeArray.Click

        Dim strWordPlusClue As String = ""
        Dim crosswordFilePath As String = "C:\Users\Diane\AndroidStudioProjects\Fragmental\puzzle_data.txt"
        Dim wordClueList As New List(Of PuzzPair)

        Try
            Dim sr As StreamReader = New StreamReader(crosswordFilePath)
            Do While sr.Peek() >= 0
                strWordPlusClue = sr.ReadLine()
                Dim splitOnPipe() As String = strWordPlusClue.Split("|")
                wordClueList.Add(New PuzzPair(splitOnPipe(0), splitOnPipe(1), 0))
            Loop
            sr.Close()
        Catch err As Exception
            Console.WriteLine("The file could not be read:   ")
            Console.WriteLine(err.Message)
        End Try


        Dim outPath As String = "C:\Users\Diane\AndroidStudioProjects\Fragmental\_" + txtFragment.Text + ".txt"

        If Not System.IO.File.Exists(outPath) Then
            System.IO.File.Create(outPath).Dispose()
        End If

        Try
            Dim sw As StreamWriter = File.AppendText(outPath)
            Dim frag As String = txtFragment.Text
            For Each item In wordClueList
                If (item.word.Length > frag.Length + 1 And item.word.Substring(0, frag.Length) = frag) Or (item.word.Substring(item.word.Length - frag.Length, frag.Length) = frag) Or (item.word.IndexOf(frag) > frag.Length And item.word.IndexOf(frag) < item.word.Length - (frag.Length + 2)) Then
                    Dim both As String = item.word.ToLower + "|" + item.clue
                    sw.WriteLine(both)
                End If
            Next

            sw.Close()
        Catch ex As Exception

        End Try



    End Sub


    Private Sub btnMakePuzzString_Click(sender As Object, e As EventArgs) Handles btnMakePuzzString.Click
        Dim strWordPlusClue As String = ""
        Dim keyFrag As String = txtFragment.Text
        Dim keyFragLength As Integer = txtFragment.Text.Length
        Dim filePath As String = "C:\Users\Diane\AndroidStudioProjects\Fragmental\wordlist.txt"   '_" + keyFrag + ".txt"
        Dim wordClueList As New List(Of PuzzPair)

        Try
            Dim sr As StreamReader = New StreamReader(filePath)
            Do While sr.Peek() >= 0
                strWordPlusClue = sr.ReadLine()
                Dim splitOnPipe() As String = strWordPlusClue.Split("|")
                wordClueList.Add(New PuzzPair(splitOnPipe(0), splitOnPipe(1), 0))
            Loop
            sr.Close()
        Catch err As Exception
            Console.WriteLine("The file could not be read:   ")
            Console.WriteLine(err.Message)
        End Try

        Dim arrOfNumberOfWords() As Integer = {9, 12}
        Dim Rand As New Random()
        Dim Index As Integer = Rand.Next(0, arrOfNumberOfWords.Length - 1)
        Dim numberOfWords As Integer = arrOfNumberOfWords(Index) 'Picks either 12 or 15 for number of words
        Dim accumNumFragmentsIs20 As Boolean = False
        Dim keyFragLengthPresent As Boolean = False
        Dim listOfWordLengths As New List(Of wordParameters)

        Do Until accumNumFragmentsIs20
            For makeCombo As Integer = 0 To numberOfWords - 1
                Do Until keyFragLengthPresent
                    Dim i1 As Integer = Rand.Next(0, 8) '0 to 8, representing length of word from 4 to 12
                    Dim i2 As Integer = Rand.Next(0, 5) '0 to 5, => 6 different arrangements of fragments

                    If (strArrOfFragCombos(i1, i2).indexof(keyFragLength.ToString) > -1) Then
                        listOfWordLengths.Add(New wordParameters(i1 + 4, arrOfFragCombos(i1, i2), -1))
                        keyFragLengthPresent = True
                    End If
                Loop
                keyFragLengthPresent = False
            Next 'Now have listOfWordLengths, Check if total number of fragments = 20:

            Dim totalFrags As Integer = 0
            For checkTotal As Integer = 0 To numberOfWords - 1
                totalFrags += listOfWordLengths(checkTotal).fragArrangement.Length
            Next

            If (totalFrags = 20 + numberOfWords) Then
                accumNumFragmentsIs20 = True
            Else
                listOfWordLengths.Clear()
            End If
        Loop

        'Dim threeWithoutFrag As New List(Of numbers) 'Pick three random words that won't necessarily contain keyFrag
        'For ccc As Integer = 0 To listOfWordLengths.Count - 1
        '    threeWithoutFrag.Add(New numbers(ccc))
        'Next
        'threeWithoutFrag = ShuffleNumList(threeWithoutFrag)
        'For cc As Integer = 3 To listOfWordLengths.Count - 1
        '    threeWithoutFrag.RemoveAt(3)
        'Next

        'Dim gotoNextWord As Boolean = False

        For j As Integer = 0 To listOfWordLengths.Count - 1
            For loopThroughList As Integer = 0 To wordClueList.Count - 1
                'If (gotoNextWord) Then
                '    gotoNextWord = False
                '    Exit For
                'End If

                Dim wordToCheck As String = Nothing

                If (wordClueList(loopThroughList).flag = 0) Then 'we haven't looked at this word yet
                    wordToCheck = wordClueList(loopThroughList).word
                Else
                    Continue For
                End If

                'If (threeWithoutFrag(0).num = j Or threeWithoutFrag(1).num = j Or threeWithoutFrag(2).num = j) Then 'Won't require these three words to contain keyFrag

                '    For internalLoop As Integer = 0 To wordClueList.Count - 1
                '        Dim aWord As String = Nothing
                '        If (wordClueList(internalLoop).flag = 0) Then 'we haven't looked at this word yet
                '            aWord = wordClueList(internalLoop).word
                '        Else
                '            Continue For
                '        End If
                '        If (aWord.Length = listOfWordLengths(j).wordLength) Then
                '            wordClueList(internalLoop).setFlag(1)
                '            listOfWordLengths(j).changeIndex(internalLoop)
                '            gotoNextWord = True
                '            Exit For
                '        End If
                '    Next
                'End If

                If (wordToCheck.Substring(0, keyFragLength) = keyFrag) Or (wordToCheck.Substring(wordToCheck.Length - keyFragLength, keyFragLength) = keyFrag) Or (wordToCheck.IndexOf(keyFrag) > keyFragLength And wordToCheck.IndexOf(keyFrag) < wordToCheck.Length - (keyFragLength + 2)) Then
                    wordToCheck = Replace(wordToCheck, keyFrag, "^",, 1)
                    If (wordToCheck.Length + (keyFragLength - 1) = listOfWordLengths(j).wordLength) Then 'this word is the right length

                        Dim newArrangement() As Integer = Nothing

                        If (wordToCheck.IndexOf("^") = 0 Or wordToCheck.IndexOf("^") = wordToCheck.Length - 1) Then 'fragment is at beginning or end of the word
                            Do While (wordToCheck.IndexOf("^") = 0 And listOfWordLengths(j).fragArrangement(0) <> keyFragLength)
                                newArrangement = listOfWordLengths(j).fragArrangement
                                newArrangement = Shuffle(newArrangement)
                                listOfWordLengths(j).changeArrangement(newArrangement)
                            Loop
                            Do While (wordToCheck.IndexOf("^") = wordToCheck.Length - 1 And listOfWordLengths(j).fragArrangement(listOfWordLengths(j).fragArrangement.Length - 1) <> keyFragLength)
                                newArrangement = listOfWordLengths(j).fragArrangement
                                newArrangement = Shuffle(newArrangement)
                                listOfWordLengths(j).changeArrangement(newArrangement)
                            Loop
                            wordClueList(loopThroughList).setFlag(1)
                            listOfWordLengths(j).changeIndex(loopThroughList)
                            Exit For
                        End If

                        'Fragment is somewhere in middle of word: find division arrangement that fits word and fragment
                        Dim sections() As String = wordToCheck.Split("^")

                        Select Case sections(0).Length

                            Case 2
                                Select Case keyFrag.Length
                                    Case 2
                                        Select Case listOfWordLengths(j).fragArrangement.Length
                                            Case 2
                                                Continue For
                                            Case 3
                                                Select Case sections(1).Length
                                                    Case 2
                                                        newArrangement = {2, 2, 2}
                                                    Case 3
                                                        newArrangement = {2, 2, 3}
                                                    Case 4
                                                        newArrangement = {2, 2, 4}
                                                End Select
                                            Case 4
                                                Select Case sections(1).Length
                                                    Case 4
                                                        newArrangement = {2, 2, 2, 2}
                                                    Case 5
                                                        newArrangement = {2, 2, 2, 3}
                                                    Case 6
                                                        newArrangement = {2, 2, 3, 3}
                                                    Case 7
                                                        newArrangement = {2, 2, 3, 4}
                                                    Case 8
                                                        newArrangement = {2, 2, 4, 4}
                                                End Select
                                            Case 5
                                                Select Case sections(1).Length
                                                    Case 6
                                                        newArrangement = {2, 2, 2, 2, 2}
                                                    Case 7
                                                        newArrangement = {2, 2, 2, 2, 3}
                                                    Case 8
                                                        newArrangement = {2, 2, 2, 3, 3}
                                                End Select
                                            Case 6
                                                Select Case sections(1).Length
                                                    Case 8
                                                        newArrangement = {2, 2, 2, 2, 2, 2}
                                                End Select
                                        End Select
                                    Case 3
                                        Select Case listOfWordLengths(j).fragArrangement.Length
                                            Case 3
                                                Select Case sections(1).Length
                                                    Case 3
                                                        newArrangement = {2, 3, 3}
                                                    Case 4
                                                        newArrangement = {2, 3, 4}
                                                End Select
                                            Case 4
                                                Select Case sections(1).Length
                                                    Case 6
                                                        newArrangement = {2, 3, 3, 3}
                                                End Select
                                        End Select
                                End Select
                            Case 3
                                Select Case keyFrag.Length
                                    Case 2
                                        Select Case listOfWordLengths(j).fragArrangement.Length
                                            Case 3
                                                Select Case sections(1).Length
                                                    Case 2
                                                        newArrangement = {3, 2, 2}
                                                    Case 3
                                                        newArrangement = {3, 2, 3}
                                                    Case 4
                                                        newArrangement = {3, 2, 4}
                                                End Select
                                            Case 4
                                                Select Case sections(1).Length
                                                    Case 4
                                                        newArrangement = {3, 2, 2, 2}
                                                    Case 5
                                                        newArrangement = {3, 2, 2, 3}
                                                    Case 6
                                                        newArrangement = {3, 2, 3, 3}
                                                    Case 7
                                                        newArrangement = {3, 2, 3, 4}
                                                End Select
                                            Case 5
                                                Select Case sections(1).Length
                                                    Case 6
                                                        newArrangement = {3, 2, 2, 2, 2}
                                                    Case 7
                                                        newArrangement = {3, 2, 2, 2, 3}
                                                End Select
                                        End Select
                                    Case 3
                                        Select Case listOfWordLengths(j).fragArrangement.Length
                                            Case 3
                                                Select Case sections(1).Length
                                                    Case 3
                                                        newArrangement = {3, 3, 3}
                                                End Select
                                            Case 4
                                                Select Case sections(1).Length
                                                    Case 6
                                                        newArrangement = {3, 2, 3, 3}
                                                    Case 7
                                                        newArrangement = {3, 2, 3, 4}
                                                End Select
                                        End Select
                                End Select

                            Case 4
                                Select Case keyFrag.Length
                                    Case 2
                                        Select Case listOfWordLengths(j).fragArrangement.Length
                                            Case 3
                                                Select Case sections(1).Length
                                                    Case 2
                                                        newArrangement = {4, 2, 2}
                                                    Case 3
                                                        newArrangement = {4, 2, 3}
                                                End Select
                                            Case 4
                                                Select Case sections(1).Length
                                                    Case 2
                                                        newArrangement = {2, 2, 2, 2}
                                                    Case 3
                                                        newArrangement = {2, 2, 2, 3}
                                                    Case 4
                                                        newArrangement = {2, 2, 2, 4}
                                                End Select
                                            Case 5
                                                Select Case sections(1).Length
                                                    Case 4
                                                        newArrangement = {2, 2, 2, 2, 2}
                                                    Case 5
                                                        newArrangement = {2, 2, 2, 2, 3}
                                                    Case 6
                                                        newArrangement = {2, 2, 2, 3, 3}
                                                End Select
                                        End Select
                                    Case 3
                                        Select Case listOfWordLengths(j).fragArrangement.Length
                                            Case 3
                                                Select Case sections(1).Length
                                                    Case 2
                                                        newArrangement = {4, 3, 2}
                                                End Select
                                            Case 4
                                                Select Case sections(1).Length
                                                    Case 2
                                                        newArrangement = {2, 2, 3, 2}
                                                    Case 3
                                                        newArrangement = {2, 2, 3, 3}
                                                    Case 4
                                                        newArrangement = {2, 2, 3, 4}
                                                    Case 5
                                                        newArrangement = {4, 3, 3, 2}
                                                End Select
                                            Case 5
                                                Select Case sections(1).Length
                                                    Case 5
                                                        newArrangement = {2, 2, 3, 3, 2}
                                                End Select
                                        End Select
                                End Select
                            Case 5
                                Select Case keyFrag.Length
                                    Case 2
                                        Select Case listOfWordLengths(j).fragArrangement.Length
                                            Case 3
                                                newArrangement = {3, 2, 4}
                                            Case 4
                                                Select Case sections(1).Length
                                                    Case 2
                                                        newArrangement = {3, 2, 2, 2}
                                                    Case 3
                                                        newArrangement = {2, 3, 2, 3}
                                                    Case 4
                                                        newArrangement = {3, 2, 2, 4}
                                                    Case 5
                                                        Continue For
                                                End Select
                                            Case 5
                                                Select Case sections(1).Length
                                                    Case 3
                                                        Continue For
                                                    Case 4
                                                        Continue For
                                                    Case 5
                                                        newArrangement = {2, 3, 2, 3, 2}
                                                End Select
                                        End Select
                                    Case 3
                                        Select Case listOfWordLengths(j).fragArrangement.Length
                                            Case 4
                                                Select Case sections(1).Length
                                                    Case 2
                                                        newArrangement = {2, 3, 3, 2}
                                                    Case 3
                                                        newArrangement = {3, 2, 3, 3}
                                                    Case 4
                                                        newArrangement = {3, 2, 3, 4}
                                                End Select
                                            Case 5
                                                Select Case sections(1).Length
                                                    Case 2
                                                        newArrangement = {2, 3, 3, 2}
                                                    Case 3
                                                        newArrangement = {3, 2, 3, 3}
                                                    Case 4
                                                        newArrangement = {3, 2, 3, 4}
                                                End Select
                                        End Select
                                    Case 6
                                        Select Case keyFrag.Length
                                            Case 2
                                                Select Case listOfWordLengths(j).fragArrangement.Length
                                                    Case 4
                                                        Select Case sections(1).Length
                                                            Case 2
                                                                newArrangement = {3, 3, 2, 2}
                                                            Case 3
                                                                newArrangement = {2, 4, 2, 3}
                                                            Case 4
                                                                newArrangement = {4, 2, 2, 4}
                                                        End Select
                                                    Case 5
                                                        Select Case sections(1).Length
                                                            Case 4
                                                                newArrangement = {3, 3, 2, 2, 2}
                                                        End Select
                                                End Select
                                            Case 3
                                                Select Case listOfWordLengths(j).fragArrangement.Length
                                                    Case 4
                                                        Select Case sections(1).Length
                                                            Case 2
                                                                newArrangement = {3, 3, 3, 2}
                                                            Case 3
                                                                newArrangement = {2, 4, 3, 3}
                                                        End Select
                                                    Case 5
                                                        Select Case sections(1).Length
                                                            Case 2
                                                                newArrangement = {2, 2, 2, 3, 2}
                                                            Case 3
                                                                newArrangement = {2, 2, 2, 3, 3}
                                                        End Select
                                                End Select
                                        End Select

                                    Case 7
                                        Select Case keyFrag.Length
                                            Case 2
                                                Select Case listOfWordLengths(j).fragArrangement.Length
                                                    Case 4
                                                        Select Case sections(1).Length
                                                            Case 2
                                                                newArrangement = {4, 3, 2, 2}
                                                            Case 3
                                                                newArrangement = {3, 4, 2, 3}
                                                            Case 4
                                                                newArrangement = {4, 3, 2, 4}
                                                        End Select
                                                    Case 5
                                                        Select Case sections(1).Length
                                                            Case 2
                                                                newArrangement = {2, 3, 2, 2, 2}
                                                            Case 3
                                                                newArrangement = {3, 2, 2, 2, 3}
                                                        End Select
                                                End Select
                                            Case 3
                                                Select Case listOfWordLengths(j).fragArrangement.Length
                                                    Case 4
                                                        newArrangement = {3, 4, 3, 2}
                                                    Case 5
                                                        newArrangement = {2, 3, 2, 3, 2}
                                                End Select
                                        End Select

                                    Case 8
                                        Select Case keyFrag.Length
                                            Case 2
                                                Select Case listOfWordLengths(j).fragArrangement.Length
                                                    Case 4
                                                        newArrangement = {4, 4, 2, 2}
                                                    Case 5
                                                        newArrangement = {2, 3, 2, 2, 2}
                                                End Select
                                        End Select
                                    Case Else
                                        Continue For
                                End Select
                        End Select

                        If Not newArrangement Is Nothing Then
                            wordClueList(loopThroughList).setFlag(1)
                            listOfWordLengths(j).changeIndex(loopThroughList)
                            listOfWordLengths(j).changeArrangement(newArrangement)

                            Exit For
                        End If
                    End If
                End If
            Next
        Next



        Dim puzzleStringsFilePath As String = "C:\Users\Diane\AndroidStudioProjects\Fragmental\puzzleStrings.txt"
        Dim outPathUsed As String = "C:\Users\Diane\AndroidStudioProjects\Fragmental\_used.txt"
        Dim outPathKeep As String = "C:\Users\Diane\AndroidStudioProjects\Fragmental\_out3.txt"

        Try
            Dim sw As StreamWriter = File.AppendText(puzzleStringsFilePath)
            Dim strOut As String = txtFragment.Text + "~"
            Dim theWord As String = ""
            Dim theClue As String = ""

            For Each item In listOfWordLengths 'last chance to try to assign remaining words...
                If (item.listIndex < 0) Then
                    Dim aWord As String = Nothing
                    For loopx As Integer = 0 To wordClueList.Count - 1
                        aWord = ""
                        If (wordClueList(loopx).flag = 0) Then 'we haven't looked at this word yet
                            aWord = wordClueList(loopx).word
                        Else
                            Continue For
                        End If
                        If (item.wordLength = aWord.Length And aWord.IndexOf(keyFrag) < 0) Then
                            wordClueList(loopx).setFlag(1)
                            item.changeIndex(loopx)
                            Exit For
                        End If
                    Next

                End If




                theWord = ""
                If (item.listIndex > -1) Then
                    theWord = wordClueList(item.listIndex).word
                    theWord = Replace(theWord, keyFrag, "^",, 1)

                    theClue = wordClueList(item.listIndex).clue
                Else
                    For plusses As Integer = 0 To item.wordLength - 1
                        theWord += "+"
                    Next
                    theClue = "??????"
                End If
                Dim theLetters() = theWord.ToCharArray()
                Dim fragsCounter As Integer = 0
                Dim itemsCounter As Integer = 0

                For Each indexNum In item.fragArrangement
                    itemsCounter = itemsCounter + 1


                    For loopFragLength As Integer = 0 To indexNum - 1
                        strOut += theLetters(fragsCounter)
                        If theLetters(fragsCounter) = "^" Then
                            fragsCounter = fragsCounter + 1
                            Exit For
                        End If
                        fragsCounter = fragsCounter + 1

                    Next
                    If itemsCounter < item.fragArrangement.Length Then
                        strOut += "|"
                    End If
                Next

                strOut = strOut + ":" + theClue + "**"
            Next

            Dim AsteRisk() As Char = {"*"}
            Dim output As String = strOut.TrimEnd(AsteRisk)
            output = output.Replace("'", "\'")
            output = "'" + output + "'"

            sw.WriteLine(output)
            sw.Close()
        Catch ex As Exception
        End Try


        Dim usedStrings As New List(Of PuzzString)
        Dim keepStrings As New List(Of PuzzString)
        Dim bunchOfNumbers As New Dictionary(Of Integer, Integer)
        Dim keyCount As Integer = 0

        For member As Integer = 0 To listOfWordLengths.Count - 1
            If (listOfWordLengths(member).listIndex) > -1 Then
                Dim strPuz As String = wordClueList(listOfWordLengths(member).listIndex).word + "|" + wordClueList(listOfWordLengths(member).listIndex).clue
                usedStrings.Add(New PuzzString(strPuz))
                bunchOfNumbers.Add(keyCount, listOfWordLengths(member).listIndex)
                keyCount = keyCount + 1
            End If
        Next

        Try
            Dim sy As StreamWriter = File.AppendText(outPathUsed)
            For Each line In usedStrings
                sy.WriteLine(line.strPuzzle)
            Next
            sy.Close()
        Catch ex As Exception
        End Try

        'Try
        '    Dim sz As StreamWriter = File.CreateText(outPathKeep)
        '    Dim counter As Integer = 0

        '    For Each strLine In wordClueList
        '        If Not bunchOfNumbers.ContainsValue(counter) Then
        '            sz.WriteLine(strLine.word + "|" + strLine.clue)
        '        End If
        '        counter = counter + 1
        '    Next
        '    sz.Close()
        'Catch ex As Exception
        'End Try
    End Sub


    Private Sub btnRandomizeFile_Click(sender As Object, e As EventArgs) Handles btnRandomizeFile.Click

        Dim puzzleString As String = ""
        Dim filePath As String = "C:\Users\Diane\AndroidStudioProjects\FragMental\wordlist.txt"
        Dim filePathOut As String = "C:\Users\Diane\AndroidStudioProjects\FragMental\wordlist.txt"
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
            Dim sw As StreamWriter = File.CreateText(filePathOut)

            For Each line In allLines
                sw.WriteLine(line.strPuzzle)
            Next
            sw.Close()
        Catch ex As Exception
        End Try


    End Sub




    Private Sub btnPuzzStrArray_Click(sender As Object, e As EventArgs) Handles btnPuzzStrArray.Click
        Dim puzzleString As String = ""
        Dim filePath As String = "C:\Users\Diane\AndroidStudioProjects\Fragmental\puzzleStrings.txt"
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
        End Try
    End Sub

    Private Sub btnFragmentate_Click(sender As Object, e As EventArgs) Handles btnFragmentate.Click
        Dim puzzleString As String = ""
        Dim filePath As String = "C:\Users\Diane\AndroidStudioProjects\Fragmental\_" + txtFragment.Text + ".txt"
        Dim filePathout As String = "C:\Users\Diane\AndroidStudioProjects\Fragmental\work_file.txt"
        Dim allLines As String()
        Dim allWords As String()
        Dim allClues As String()
        Dim position As Integer()
        Dim keyFrag As String = txtFragment.Text
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
                            Select Case allWords(m).Length
                                Case 5, 6
                                    numFrags(m, 1) = 1
                                    totalNumFrags = totalNumFrags + 2
                                Case 7, 8
                                    r = Rand.Next(1, 3)
                                    numFrags(m, 1) = r
                                    totalNumFrags = totalNumFrags + r + 1
                                Case 9, 10
                                    r = Rand.Next(2, 4)
                                    numFrags(m, 1) = r
                                    totalNumFrags = totalNumFrags + r + 1
                                Case 11
                                    r = Rand.Next(2, 5)
                                    numFrags(m, 1) = r
                                    totalNumFrags = totalNumFrags + r + 1
                            End Select
                        Case 3
                            numFrags(m, 0) = 1
                            Select Case allWords(m).Length
                                Case 6, 7
                                    numFrags(m, 1) = 1
                                    totalNumFrags = totalNumFrags + 2
                                Case 8, 9
                                    r = Rand.Next(1, 2)
                                    numFrags(m, 1) = r
                                    totalNumFrags = totalNumFrags + r + 1
                                Case 10, 11
                                    r = Rand.Next(2, 4)
                                    numFrags(m, 1) = r
                                    totalNumFrags = totalNumFrags + r + 1
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
                                    r = Rand.Next(1, 3)
                                    numFrags(m, 0) = r
                                    totalNumFrags = totalNumFrags + r + 1
                                Case 10, 11
                                    r = Rand.Next(1, 3)
                                    s = Rand.Next(1, 3)
                                    numFrags(m, 0) = r
                                    numFrags(m, 1) = s
                                    totalNumFrags = totalNumFrags + r + s
                            End Select
                        Case 6
                            Select Case allWords(m).Length
                                Case 9, 10
                                    numFrags(m, 1) = 1
                                    r = Rand.Next(2, 3)
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
            Next
            Console.WriteLine(totalNumFrags)
        Loop Until totalNumFrags = 20

        Dim delimWords(0 To arrayLength) As String

        For n As Integer = 0 To arrayLength
            Dim strLeftSide = ""
            If position(n) = 0 Then
                delimWords(n) = "^" + fragmentateString(allWords(n).Substring(1), numFrags(n, 1)) + ":" + allClues(n)
            ElseIf position(n) = 1 Then
                delimWords(n) = fragmentateString(allWords(n).Substring(0, allWords(n).Length - 1), numFrags(n, 0)) + ":" + allClues(n)
            Else
                delimWords(n) = fragmentateString(allWords(n).Substring(1), numFrags(n, 1)) + "^" + fragmentateString(allWords(n).Substring(0, allWords(n).Length - 1), numFrags(n, 0)) + ":" + allClues(n)
            End If
        Next
        Dim puzzString As String = keyFrag + "~" + Join(delimWords, "**")
        puzzString = puzzString.Replace("'", "\'")
        puzzString = "'" + puzzString + "'"


        Try
            Dim sw As StreamWriter = File.AppendText(filePathout)
            sw.WriteLine(puzzString)
            sw.Close()
        Catch ex As Exception
            MsgBox(ex)
        End Try



    End Sub

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
            Case 10
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



    'Remove duplicates from list of words, confine lengths to 4=>12 characters, add pipe:

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim puzzleString As String = ""
        Dim filePath As String = "C:\Users\Diane\AndroidStudioProjects\Fragmental\new_test.txt"
        Dim filePathout As String = "C:\Users\Diane\AndroidStudioProjects\Fragmental\new_test.txt"
        Dim allLines As New List(Of String)

        Try
            Dim sr As StreamReader = New StreamReader(filePath)
            Do While sr.Peek() >= 0
                puzzleString = sr.ReadLine()
                puzzleString = puzzleString.Trim

                'Dim splitToCheck() As String = puzzleString.Split("|")
                If puzzleString.Length > 3 And puzzleString.Length < 13 And puzzleString.IndexOf("'") < 0 Then
                    'puzzleString = puzzleString.ToLower

                    'If String.IsNullOrEmpty(splitToCheck(1)) Then
                    '    splitToCheck(1) = "***"
                    'End If

                    'Dim array() As Char = splitToCheck(1).ToCharArray
                    'array(0) = Char.ToUpper(array(0))
                    'Dim wordPlusclue As New String(array)

                    'wordPlusclue = splitToCheck(0) + "|" + wordPlusclue
                    'puzzleString = puzzleString + "|" + "Clue"

                    allLines.Add(New String(puzzleString))
                End If

            Loop
            sr.Close()
        Catch err As Exception
            Console.WriteLine("The file could not be read:   ")
            Console.WriteLine(err.Message)
        End Try

        'Dim noDupList As List(Of String) = removeDuplicates(allLines)
        If Not System.IO.File.Exists(filePathout) Then
            System.IO.File.Create(filePathout).Dispose()
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

    Public Function ShuffleNumList(numbs)

        Dim x As Integer
        Dim r As Random = New Random()
        Dim ii As Integer

        For i As Integer = numbs.Count - 1 To 0 Step -1
            x = Math.Floor(r.NextDouble() * (i + 1)) 'r.Next(0, i)
            ii = numbs(x).num
            numbs(x).setNum(numbs(i).num)
            numbs(i).setNum(ii)
        Next i
        Return numbs

    End Function

    Public Function Shuffle(data)

        Dim x, swap As Integer
        Dim r As Random = New Random()

        For i As Integer = 0 To data.GetUpperBound(0)
            x = r.Next(0, i)
            swap = data(x)
            data(x) = data(i)
            data(i) = swap
        Next i
        Return data

    End Function

    Public clipboardContents As String = ""
    Public strClipboard As String = ""
    Public started As Boolean = False
    Public onWord As Boolean = True
    Public detectingOnChange As Boolean = True


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        strClipboard = System.Windows.Forms.Clipboard.GetText()
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
        Dim outPath As String = "C:\Users\Diane\AndroidStudioProjects\FragMental\_art.txt"
        Try
            Dim sw As StreamWriter = File.AppendText(outPath)
            Dim outString As String = txtWord.Text.ToLower.Trim + "|" + txtClue.Text.Trim
            sw.WriteLine(outString)
            sw.Close()
        Catch ex As Exception
        End Try
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










    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    '    Dim puzzleString As String = ""
    '    Dim filePath As String = "C:\Users\Diane\AndroidStudioProjects\Fragmental\famous_people.txt"
    '    Dim filePathout As String = "C:\Users\Diane\AndroidStudioProjects\Fragmental\_names.txt"
    '    Dim allLines As New List(Of PuzzString)

    '    Try
    '        Dim sr As StreamReader = New StreamReader(filePath)
    '        Do While sr.Peek() >= 0
    '            puzzleString = sr.ReadLine()
    '            Dim split() As String = puzzleString.Split(",")
    '            allLines.Add(New PuzzString(split(1)))
    '        Loop
    '        sr.Close()
    '    Catch err As Exception
    '        Console.WriteLine("The file could not be read:   ")
    '        Console.WriteLine(err.Message)
    '    End Try


    '    Try
    '        Dim sw As StreamWriter = File.CreateText(filePathout)

    '        For Each line In allLines
    '            sw.WriteLine(line.strPuzzle)
    '        Next
    '        sw.Close()
    '    Catch ex As Exception
    '    End Try



    'End Sub


    '    Function shuffleArray(array) {
    '    For (var i = array.length - 1; i > 0; i--) {
    '        var j = Math.Floor(Math.random() * (i + 1));
    '        var temp = array[i];
    '        array[i] = array[j];
    '        array[j] = temp;
    '    }
    '    Return array;
    '}




End Class
