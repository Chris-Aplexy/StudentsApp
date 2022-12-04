Imports MySql.Data.MySqlClient
Imports Microsoft.Win32



Public Class Form1

    Dim sqlconn As New MySqlConnection
    Dim sqlcmd As New MySqlCommand
    Private myReader As MySqlDataReader
    Dim da As New MySqlDataAdapter
    Dim dt As DataTable = New DataTable()
    Dim results As String
    Dim sql As String

    Dim dbserver As String = "localhost"
    Dim dbusername As String = "root"
    Dim dbpassword As String = "APLEXY"
    Dim db As String = "students"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim closeSession As DialogResult
        closeSession = MessageBox.Show("Confirm exit", "ECE DBMS " +
        "Students Data /Home", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If closeSession = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim saveRecordForm As New Save
        saveRecordForm.Show()
        'Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Dim viewAllRecordsForm As New Search
        Me.Hide()
        viewAllRecordsForm.Show()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sqlconn.ConnectionString = "Server =" + dbserver + ";" + "user id=" + dbusername + ";" + "password =" + dbpassword + ";" + "database =" + db
        sqlconn.Open()

        If sqlconn.State = ConnectionState.Open Then
            MessageBox.Show("connected")
        Else
            MessageBox.Show("Not connected")
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim update As New Form4
        Me.Hide()
        update.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim deleteForm As New DeleteForm
        Me.Hide()
        deleteForm.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim saveOrders As New AddOrderForm
        Me.Hide()
        saveOrders.Show()

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim saveProducts As New SaveProductsForm
        Me.Hide()
        saveProducts.Show()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim closeSession As DialogResult
        closeSession = MessageBox.Show("Are you Sure You Want Close Form ?", "ECE DBMS " +
        "Students Data /Home", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If closeSession = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub
End Class
