Imports System.IO
Imports System.Xml
Imports System.Linq

Public Class Form1
    'Dim customerData As XElement = XElement.Load("customers.xml")

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Writing selected items and miles to XML file
        'Dim writeStart As Boolean
        'If Not IO.File.Exists("repair.xml") Then writeStart = True
        Dim xmlFile As IO.FileStream = New IO.FileStream("repair.xml", FileMode.Create) ', IO.FileMode.Append
        Dim myXMLtextWriter As New XmlTextWriter(xmlFile, System.Text.Encoding.Default)


        With myXMLtextWriter
            .Formatting = Formatting.Indented
            .Indentation = 3
            .IndentChar = CChar(" ")
            'If writeStart Then 
            .WriteStartDocument()
            .WriteStartElement("Maintenance")

            If cbOil.Checked = True Then
                Items_Serviced.cbOilServ.Visible = True
                Items_Serviced.Label7.Visible = True
                .WriteStartElement("service")
                .WriteElementString("type", "Oil Change")
                .WriteEndElement()
            Else
                Items_Serviced.cbOilServ.Visible = False
                Items_Serviced.Label7.Visible = False
            End If
            If cbTire.Checked = True Then
                Items_Serviced.cbTireServ.Visible = True
                Items_Serviced.Label8.Visible = True
                .WriteStartElement("service")
                .WriteElementString("type", "Tire Rotation")
                .WriteEndElement()
            Else
                Items_Serviced.cbTireServ.Visible = False
                Items_Serviced.Label8.Visible = False
            End If
            If cbTrans.Checked = True Then
                Items_Serviced.cbTransServ.Visible = True
                Items_Serviced.Label9.Visible = True
                .WriteStartElement("service")
                .WriteElementString("type", "Transmission Fluid")
                .WriteEndElement()
            Else
                Items_Serviced.cbTransServ.Visible = False
                Items_Serviced.Label9.Visible = False
            End If
            If cbBrakes.Checked = True Then
                Items_Serviced.cbBrakesServ.Visible = True
                Items_Serviced.Label10.Visible = True
                .WriteStartElement("service")
                .WriteElementString("type", "Brake Check")
                .WriteEndElement()
            Else
                Items_Serviced.cbBrakesServ.Visible = False
                Items_Serviced.Label10.Visible = False
            End If
            If cbOther.Checked = True Then
                Items_Serviced.cbOtherServ.Visible = True
                Items_Serviced.Label2.Visible = True
                .WriteStartElement("service")
                .WriteElementString("type", "Other Maintenance")
                .WriteEndElement()
            Else
                Items_Serviced.cbOtherServ.Visible = False
                Items_Serviced.Label2.Visible = False
            End If
            If cmbMileage.SelectedItem = "1000" Then
                .WriteStartElement("service")
                .WriteElementString("type", "1000")
                .WriteEndElement()
            ElseIf cmbMileage.SelectedItem = "3000" Then
                .WriteStartElement("service")
                .WriteElementString("type", "3000")
                .WriteEndElement()
            ElseIf cmbMileage.SelectedItem = "5000" Then
                .WriteStartElement("service")
                .WriteElementString("type", "5000")
                .WriteEndElement()
            ElseIf cmbMileage.SelectedItem = "10000" Then
                .WriteStartElement("service")
                .WriteElementString("type", "10000")
                .WriteEndElement()
            ElseIf cmbMileage.SelectedItem = "20000+" Then
                .WriteStartElement("service")
                .WriteElementString("type", "20000+")
                .WriteEndElement()
            End If
                .WriteEndElement()
                .Close()
            MessageBox.Show("Repair List Created")
        End With

        Dim oilPrice, tirePrice, transPrice, otherPrice, brakesPrice, sum As Double
        'Check which items are selected and use price
        If cbOil.Checked = True Then
            oilPrice = 29.99
        Else : oilPrice = 0
        End If
        If cbTire.Checked = True Then
            tirePrice = 19.99
        Else : tirePrice = 0
        End If
        If cbTrans.Checked = True Then
            transPrice = 25.0
        Else : transPrice = 0
        End If
        If cbBrakes.Checked = True Then
            brakesPrice = 69.99
        Else : brakesPrice = 0
        End If
        If cbOther.Checked = True Then
            otherPrice = 50
        Else : otherPrice = 0
        End If
        ' Add Total Price
        sum = oilPrice + tirePrice + transPrice + otherPrice + brakesPrice
        lblTotal.Text = "$" & sum

        'Displays to datgrid... only it's not working :(
        Dim serviceData As XElement = XElement.Load("repair.xml")
        Dim query = From service In serviceData.Descendants("service")
            Let type = service.<type>.Value
            Let miles = service.<type>.Value
            Order By type Ascending
            Where type.StartsWith("")
                Select type, miles
        Selected_Services.DataGridView1.DataSource = query.ToList
        Selected_Services.DataGridView1.CurrentCell = Nothing
        Selected_Services.DataGridView1.Columns("type").HeaderText = "Repairs"
        Selected_Services.DataGridView1.Columns("miles").HeaderText = "Miles Since Last Appointment"
        Selected_Services.Show()
        'Items_Serviced.Show()
    End Sub
    

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub cmbMileage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMileage.SelectedIndexChanged
        ' Displays what should be repaired/inspected since last visit.
        If cmbMileage.SelectedItem = "1000" Then
            MsgBox("No maintenance required since last visit")
        ElseIf cmbMileage.SelectedItem = "3000" Then
            MsgBox("Oil will need to be checked and serviced. Tires also need to be rotated")
        ElseIf cmbMileage.SelectedItem = "5000" Then
            MsgBox("Oil and Transmission Fluid needs to be checked and serviced")
        ElseIf cmbMileage.SelectedItem = "10000" Then
            MsgBox("Oil, Transmission Fluid and tires should be rotated")
        ElseIf cmbMileage.SelectedItem = "20000+" Then
            MsgBox("Vehicle should be fully inspected and serviced")
        End If
    End Sub
End Class
