Public Class Form1

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim sr = New IO.StreamReader("USStates.txt")
        Dim abbrev As String = mtbAbbrev.Text.ToUpper
        Dim line As String
        Dim foundFlag As Boolean = False

        Do Until foundFlag Or sr.EndOfStream
            line = sr.ReadLine
            If line.Split(","c)(1) = abbrev Then
                tbName.Text = line.Split(","c)(0)
                foundFlag = True
            End If
        Loop
        If Not foundFlag Then
            Dim str As String = " is not a valid state abbreviation."
            MessageBox.Show(mtbAbbrev.Text.ToUpper & str, "Error")
            mtbAbbrev.Clear()
            mtbAbbrev.Focus()
        End If
        sr.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sw As IO.StreamWriter = IO.File.AppendText("USSstates.txt")
        sw.WriteLine(tbNewState.Text.ToUpper & "," & mtbStateAbbrev.Text.ToUpper & ",6555,564654231")
        sw.Close()
        MessageBox.Show("New State written to file, yo!")
    End Sub
End Class
