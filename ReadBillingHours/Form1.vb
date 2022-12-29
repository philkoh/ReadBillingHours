Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        Dim s As String = FileIO.FileSystem.ReadAllText(OpenFileDialog1.FileName)
        s = s.Replace(vbCrLf, vbCr)
        s = s.Replace(vbLf, vbCr)
        Do
            Dim lenBefore As Integer = s.Length
            s = s.Replace(vbCr & vbCr, vbCr)
            If s.Length = lenBefore Then Exit Do
        Loop
        Do
            Dim lenBefore As Integer = s.Length
            s = s.Replace("  ", " ")
            If s.Length = lenBefore Then Exit Do
        Loop
        Dim lines() As String = s.Split(vbCr)
        Dim line As String
        Dim total As Decimal = 0.0
        Dim aggregateHours As Decimal = 0.0
        Dim copyFilepath As String = ""
        Dim copySelectedLines As String = ""
        For Each line In lines
            Dim tr As String = line.Trim
            Dim excludeThisLine As Boolean = False
            If LCase(tr).StartsWith("b") Or LCase(tr).StartsWith("r") Then
                tr = tr.Substring(1)
                If RadioButtonExcludeBorS.Checked Then excludeThisLine = True
            Else
                If RadioButtonOnlyB.Checked Then excludeThisLine = True
            End If
            If LCase(tr).StartsWith("s") Then
                tr = tr.Substring(1)
                If RadioButtonExcludeBorS.Checked Then excludeThisLine = True
            Else
                If RadioButtonOnlyS.Checked Then excludeThisLine = True
            End If


            If tr.Length > 3 Then
                Dim tokens() As String = tr.Split(" ")
                Dim dateString As String = tokens(0)
                If dateString.Contains("/") Then
                    copySelectedLines = copySelectedLines & tr & vbCrLf
                    Dim dateTokens() As String = dateString.Split("/")
                    If dateTokens.Count <> 3 Then
                        MsgBox("Error in line, wrong number of slashes: " & line)
                        Exit Sub
                    End If
                    If tokens.Count <> 1 Then
                        '          MsgBox("Error in line, wrong number of tokens: " & line)
                        '         Exit Sub
                    End If
                    If total > 0 Then
                        TextBox1.AppendText(total.ToString & " hours" & vbCrLf)
                        TextBox2.AppendText("  " & total.ToString & " hours" & vbCrLf)
                    Else
                        TextBox2.AppendText(vbCrLf)
                    End If

                    total = 0
                    TextBox2.AppendText(dateString)
                Else   ' hours
                    If excludeThisLine Then Continue For
                    copySelectedLines = copySelectedLines & tr & vbCrLf

                    Dim firstLetter As String = tr.Substring(0, 1)
                    If Not IsNumeric(firstLetter) Then
                        MsgBox("Error in line, doesnt start with a number: " & line)
                        Exit Sub
                    End If
                    Dim dashTokens() As String = tr.Split("-")
                    If dashTokens.Count = 1 Then
                        MsgBox("Error in line, doesnt have a dash: " & line)
                        Exit Sub
                    End If
                    Dim firstTime As String = dashTokens(0)
                    Dim i As Integer = tr.IndexOf("-") + 1

                    Dim secondTime As String = ""
                    Do
                        Dim lett As String = tr.Substring(i, 1)
                        If Not IsNumeric(lett) And lett <> " " And lett <> ":" Then Exit Do
                        secondTime = secondTime & lett
                        i += 1
                    Loop
                    Dim t1 As Decimal = ReadTime(firstTime, line)
                    Dim t2 As Decimal = ReadTime(secondTime, line)
                    If t1 = t2 Then
                        MsgBox("Error in line, start and end are same: " & line)
                        Exit Sub
                    End If
                    If t1 > t2 Then t1 -= 12.0
                    Dim elapsedHours As Decimal = t2 - t1
                    TextBox1.AppendText("FirstTime=" & firstTime & "=" & t1.ToString & "SecondTime=" & secondTime & "=" & t2.ToString & "Elapsed=" & elapsedHours.ToString & vbCrLf)
                    total += elapsedHours
                    aggregateHours += elapsedHours
                End If
            End If
        Next
        If total > 0 Then
            TextBox1.AppendText(total.ToString & " hours" & vbCrLf)
            TextBox2.AppendText("  " & total.ToString & " hours")
        End If
        TextBox2.AppendText(vbCrLf & "Total hours: " & aggregateHours.ToString & vbCrLf)

        copyFilepath = OpenFileDialog1.FileName & "only"
        If RadioButtonOnlyB.Checked Then copyFilepath = copyFilepath & "BUC.txt"
        If RadioButtonOnlyS.Checked Then copyFilepath = copyFilepath & "STARING.txt"
        If RadioButtonExcludeBorS.Checked Then copyFilepath = copyFilepath & "ESA.txt"

        FileIO.FileSystem.WriteAllText(copyFilepath, copySelectedLines, False)

    End Sub

    Public Function ReadTime(timeStr As String, line As String) As Decimal
        Dim s As String = timeStr.Replace("AM", "")
        s = s.Replace("PM", "")
        If s.Contains(":") Then
            Dim tokens() As String = s.Split(":")
            If tokens.Count <> 2 Then
                MsgBox("Error in time, too many colons:" & timeStr & " in line:" & line)
            End If
            If Not IsNumeric(tokens(0)) Or Not IsNumeric(tokens(1)) Then
                MsgBox("Error in time, not numeric:" & timeStr & " in line:" & line)
            End If
            Dim hr As Integer = CInt(tokens(0))
            Dim mins As Integer = CInt(tokens(1))
            If mins Mod 15 <> 0 Then
                MsgBox("Error in time, not multiple of 15:" & timeStr & " in line:" & line)
            End If
            If hr < 1 Or hr > 12 Then
                MsgBox("Error in time, invalid hour:" & timeStr & " in line:" & line)
            End If
            Return CDec(hr) + CDec(mins) / 60.0
        Else
            If Not IsNumeric(s) Then
                MsgBox("Error in time:" & timeStr & " in line:" & line)
            End If
            Return CDec(s)
        End If


    End Function


End Class
