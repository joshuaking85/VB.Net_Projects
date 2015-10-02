Public Class Form1

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click

        'sort the file Age.txt (or text) by ages...
        Dim agestAtInaug() As String = IO.File.ReadAllLines("Age.txt")
        Dim query = From line In agestAtInaug
                    Let name = line.Split(","c)(0)
                    Let age = CInt(line.Split(","c)(1))
                    Order By age
                    Select name, age
        dgvOutput.DataSource = query.ToList
        dgvOutput.CurrentCell = Nothing

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'sort the file Age.txt (or text) by ages...
        Dim agestAtInaug() As String = IO.File.ReadAllLines("Age.txt")
        Dim query = From line In agestAtInaug
                    Let name = line.Split(","c)(0)
                    Let age = CInt(line.Split(","c)(1))
                    Order By age
                    Select line
        IO.File.WriteAllLines("Sorted.csv", query)
    End Sub
End Class
