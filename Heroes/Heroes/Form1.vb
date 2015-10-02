Public Class Form1

    Structure Heroes
        Dim character As String
        Dim name As String
        Dim movie As String
        Dim year As Integer
    End Structure

    Dim heroe() As Heroes

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgHeroes.CellContentClick


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Place data of heroes into an array
        Dim Heroes() As String = IO.File.ReadAllLines("heroes.csv")
        Dim query = From line In Heroes
                    Let data = line.Split(","c)
                    Let character = data(0)
                    Let name = data(1)
                    Let movie = data(2)
                    Let year = data(3)
        Select character, name, movie, year
        dgHeroes.DataSource = query.ToList
        dgHeroes.CurrentCell = Nothing
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tbChar.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sw As IO.StreamWriter = IO.File.AppendText("heroes.csv")
        sw.WriteLine(tbActor.Text & (","c) & tbChar.Text & (","c) & tbMovie.Text & (","c) & tbYear.Text)
        sw.Close()
        MessageBox.Show("New Heroe has been written to the file!")
    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        'sort the file by movie
        Dim Heroes() As String = IO.File.ReadAllLines("heroes.csv")
        Dim query = From line In Heroes
                    Let data = line.Split(","c)
                    Let character = data(0)
                    Let name = data(1)
                    Let movie = data(2)
                    Let year = data(3)
        Select movie, character, name, year
        dgHeroes.DataSource = query.ToList
        dgHeroes.CurrentCell = Nothing
    End Sub
End Class
