Public Class Form1
    Dim heroData As XElement = XElement.Load("Heroes.xml")


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim query = From hro In heroData.Descendants("hero")
                    Let name = hro.<name>.Value
                    Let team = hro.<team>.Value
                    Let power = hro.<power>.Value
                    Let faction = hro.<faction>.Value
                    Where team = ListBox1.Text
                    Select team, name, power, faction
        DataGridView1.DataSource = query.ToList
        DataGridView1.CurrentCell = Nothing
        DataGridView1.Columns("name").HeaderText = "Name"
        DataGridView1.Columns("team").HeaderText = "Team"
        DataGridView1.Columns("power").HeaderText = "Power"
        DataGridView1.Columns("faction").HeaderText = "Faction"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query = From hro In heroData.Descendants("hero")
        Let team = hro.<team>.Value
        Order By team
        Select team
        Distinct
        For Each group In query
            ListBox1.Items.Add(group)
        Next
    End Sub
End Class
