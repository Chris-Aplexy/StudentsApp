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
        Me.MySqlConnection1 = New MySql.Data.MySqlClient.MySqlConnection()
        Me.CustomInstaller1 = New MySql.Data.MySqlClient.CustomInstaller()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(40, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Chartreuse
        Me.Button3.Location = New System.Drawing.Point(692, 488)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 34)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "TestConnection"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Orange
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(678, 239)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(105, 45)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "Add Customer"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Orange
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(679, 136)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(104, 45)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "Delete Data"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Orange
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(679, 85)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(104, 45)
        Me.Button6.TabIndex = 22
        Me.Button6.Text = "View Data"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Cyan
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Black
        Me.Button7.Location = New System.Drawing.Point(673, 28)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(109, 35)
        Me.Button7.TabIndex = 24
        Me.Button7.Text = "HOME"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(614, 105)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(0, 13)
        Me.LinkLabel1.TabIndex = 25
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Orange
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(678, 188)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(104, 45)
        Me.Button8.TabIndex = 27
        Me.Button8.Text = "Update Data"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Orange
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(679, 288)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 45)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Add  Order(s)"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Orange
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(679, 339)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 45)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "Add Products"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.ForeColor = System.Drawing.Color.DarkRed
        Me.Button9.Location = New System.Drawing.Point(3, 488)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(158, 34)
        Me.Button9.TabIndex = 30
        Me.Button9.Text = "CLOSE FORM"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(796, 25)
        Me.ToolStrip1.TabIndex = 31
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(12, 22)
        Me.ToolStripLabel1.Text = "\"
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Tan
        Me.Button10.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(0, 24)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(667, 50)
        Me.Button10.TabIndex = 32
        Me.Button10.Text = "ECE 2020 DBMS || Customer Management System" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BackgroundImage = Global.SqlGUI.My.Resources.Resources.table4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(796, 522)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "CUSTOMER DATA FORM"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MySqlConnection1 As MySql.Data.MySqlClient.MySqlConnection
    Friend WithEvents CustomInstaller1 As MySql.Data.MySqlClient.CustomInstaller
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button8 As Button
    Friend WithEvents Button1 As Button
    Private WithEvents Button2 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents Button10 As Button
End Class
