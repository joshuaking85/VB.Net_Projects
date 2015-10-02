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
        Me.dgHeroes = New System.Windows.Forms.DataGridView()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tbChar = New System.Windows.Forms.TextBox()
        Me.tbActor = New System.Windows.Forms.TextBox()
        Me.tbMovie = New System.Windows.Forms.TextBox()
        Me.tbYear = New System.Windows.Forms.TextBox()
        Me.btnSort = New System.Windows.Forms.Button()
        CType(Me.dgHeroes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgHeroes
        '
        Me.dgHeroes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgHeroes.Location = New System.Drawing.Point(12, 2)
        Me.dgHeroes.Name = "dgHeroes"
        Me.dgHeroes.Size = New System.Drawing.Size(542, 173)
        Me.dgHeroes.TabIndex = 0
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(12, 192)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(118, 22)
        Me.btnDisplay.TabIndex = 1
        Me.btnDisplay.Text = "Show List"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 262)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Character"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 292)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Actor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 318)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Movie"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 348)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Year"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(248, 308)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tbChar
        '
        Me.tbChar.Location = New System.Drawing.Point(113, 259)
        Me.tbChar.Name = "tbChar"
        Me.tbChar.Size = New System.Drawing.Size(100, 20)
        Me.tbChar.TabIndex = 7
        '
        'tbActor
        '
        Me.tbActor.Location = New System.Drawing.Point(113, 289)
        Me.tbActor.Name = "tbActor"
        Me.tbActor.Size = New System.Drawing.Size(100, 20)
        Me.tbActor.TabIndex = 8
        '
        'tbMovie
        '
        Me.tbMovie.Location = New System.Drawing.Point(113, 315)
        Me.tbMovie.Name = "tbMovie"
        Me.tbMovie.Size = New System.Drawing.Size(100, 20)
        Me.tbMovie.TabIndex = 9
        '
        'tbYear
        '
        Me.tbYear.Location = New System.Drawing.Point(113, 344)
        Me.tbYear.Name = "tbYear"
        Me.tbYear.Size = New System.Drawing.Size(100, 20)
        Me.tbYear.TabIndex = 10
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(193, 191)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(100, 23)
        Me.btnSort.TabIndex = 11
        Me.btnSort.Text = "Sort By Movie"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 379)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.tbYear)
        Me.Controls.Add(Me.tbMovie)
        Me.Controls.Add(Me.tbActor)
        Me.Controls.Add(Me.tbChar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.dgHeroes)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgHeroes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgHeroes As System.Windows.Forms.DataGridView
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tbChar As System.Windows.Forms.TextBox
    Friend WithEvents tbActor As System.Windows.Forms.TextBox
    Friend WithEvents tbMovie As System.Windows.Forms.TextBox
    Friend WithEvents tbYear As System.Windows.Forms.TextBox
    Friend WithEvents btnSort As System.Windows.Forms.Button

End Class
