Imports System.IO  'Import system library

Public Class Form1

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Add to file
        Dim person As String = tbName.Text
        If person <> "" Then
            If IsInFile(person) Then
                MessageBox.Show(person & " is already in file.", " Alert")
            Else
                Dim sw As StreamWriter = File.AppendText("Names.txt")
                sw.WriteLine(person)
                sw.Close()
                MessageBox.Show(person & " added to file.", "Name Added")
                tbName.Clear()
                tbName.Focus()
            End If
        Else
            MessageBox.Show("You must enter a name.", "Info Incomplete!")
        End If
    End Sub

    Private Sub btnQuery_Click(sender As Object, e As EventArgs) Handles btnQuery.Click
        'determine if person is in file
        Dim person As String = tbName.Text
        If person <> "" Then
            If IsInFile(person) Then
                MessageBox.Show(person & " is in the file.", "YES")
            Else
                MessageBox.Show(person & " is NOT in the file.", "NO")
            End If
        Else
            MessageBox.Show("You must enter a name.", "Info Incomplete")
        End If
        tbName.Clear()
        tbName.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'remove a person from the list
        Dim person As String = tbName.Text
        If person <> "" Then
            If IsInFile(person) Then
                'code the remove process
                Dim sr As StreamReader = File.OpenText("Names.txt")
                Dim sw As StreamWriter = File.CreateText("temp.txt")
                Dim individual As String
                Do Until sr.EndOfStream
                    individual = sr.ReadLine
                    If individual <> person Then
                        sw.WriteLine(individual)
                    End If
                Loop
                sr.Close()
                sw.Close()
                File.Delete("Names.txt")
                File.Move("temp.txt", "Names.txt")
                MessageBox.Show(person & " removed from file.", "Name Removed")
            Else
                MessageBox.Show(person & " is not in the file.", "Name Not Found")
            End If
        Else
            MessageBox.Show("You must enter a name.", "Info Incomplete")
        End If
        tbName.Clear()
        tbName.Focus()
    End Sub

    Function IsInFile(person As String) As Boolean
        'Determine if person is in file named names.txt
        If File.Exists("Names.txt") Then
            Dim sr As StreamReader = File.OpenText("Names.txt")
            Dim individual As String
            Do Until sr.EndOfStream
                individual = sr.ReadLine
                If individual = person Then
                    sr.Close()
                    Return True
                End If
            Loop
            sr.Close()
        End If
        Return False
    End Function
End Class
