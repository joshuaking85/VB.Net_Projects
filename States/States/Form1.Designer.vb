<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.mtbAbbrev = New System.Windows.Forms.MaskedTextBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.mtStateAbbrev = New System.Windows.Forms.MaskedTextBox()
        Me.tbNewState = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "State Abbreviation:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 285)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "State Name:"
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(107, 285)
        Me.tbName.Name = "tbName"
        Me.tbName.ReadOnly = True
        Me.tbName.Size = New System.Drawing.Size(165, 20)
        Me.tbName.TabIndex = 3
        '
        'mtbAbbrev
        '
        Me.mtbAbbrev.Location = New System.Drawing.Point(116, 13)
        Me.mtbAbbrev.Mask = "LL"
        Me.mtbAbbrev.Name = "mtbAbbrev"
        Me.mtbAbbrev.Size = New System.Drawing.Size(27, 20)
        Me.mtbAbbrev.TabIndex = 3
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(12, 78)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(260, 23)
        Me.btnFind.TabIndex = 4
        Me.btnFind.Text = "Find Name of State"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'mtStateAbbrev
        '
        Me.mtStateAbbrev.Location = New System.Drawing.Point(40, 144)
        Me.mtStateAbbrev.Mask = "LL"
        Me.mtStateAbbrev.Name = "mtStateAbbrev"
        Me.mtStateAbbrev.Size = New System.Drawing.Size(32, 20)
        Me.mtStateAbbrev.TabIndex = 5
        '
        'tbNewState
        '
        Me.tbNewState.Location = New System.Drawing.Point(116, 144)
        Me.tbNewState.Name = "tbNewState"
        Me.tbNewState.Size = New System.Drawing.Size(139, 20)
        Me.tbNewState.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(19, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(253, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Add A New Imaginary State"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 329)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbNewState)
        Me.Controls.Add(Me.mtStateAbbrev)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.mtbAbbrev)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbName As System.Windows.Forms.TextBox
    Friend WithEvents mtbAbbrev As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents mtStateAbbrev As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tbNewState As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
