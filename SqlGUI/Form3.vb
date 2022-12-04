
Imports MySql.Data.MySqlClient
Imports Microsoft.Win32

Public Class Search
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
    Dim dbStudents As String = "students"

    Dim studentNumber As String

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        studentNumber = TextBox1.Text

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        sqlconn.ConnectionString = "Server =" + dbserver + ";" + "user id=" + dbusername + ";" + "password =" + dbpassword + ";" + "database =" + dbStudents

        Try
            sqlconn.Open()

            sql = "SELECT * FROM students.customer WHERE student_number = " + studentNumber

            With sqlcmd
                .Connection = sqlconn
                .CommandText = sql
            End With

            da.SelectCommand = sqlcmd

            da.Fill(dt)
            DataGridView1.DataSource = dt


            sqlconn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim closeSession As DialogResult
        closeSession = MessageBox.Show("Confirm exit", "ECE DBMS " +
        "Students Data /Search", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If closeSession = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim home As New Form1
        Me.Hide()
        home.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sqlconn.ConnectionString = "Server =" + dbserver + ";" + "user id=" + dbusername + ";" + "password =" + dbpassword + ";" + "database =" + dbStudents

        Try
            sqlconn.Open()

            sql = "SELECT * FROM students.customer"

            With sqlcmd
                .Connection = sqlconn
                .CommandText = sql
            End With

            da.SelectCommand = sqlcmd

            da.Fill(dt)
            DataGridView1.DataSource = dt


            sqlconn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        sqlconn.ConnectionString = "Server =" + dbserver + ";" + "user id=" + dbusername + ";" + "password =" + dbpassword + ";" + "database =" + dbStudents

        Try
            sqlconn.Open()

            sql = "SELECT * FROM students.orders"

            With sqlcmd
                .Connection = sqlconn
                .CommandText = sql
            End With

            da.SelectCommand = sqlcmd

            da.Fill(dt)
            DataGridView1.DataSource = dt


            sqlconn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        sqlconn.ConnectionString = "Server =" + dbserver + ";" + "user id=" + dbusername + ";" + "password =" + dbpassword + ";" + "database =" + dbStudents

        Try
            sqlconn.Open()

            sql = "SELECT * FROM students.products"

            With sqlcmd
                .Connection = sqlconn
                .CommandText = sql
            End With

            da.SelectCommand = sqlcmd

            da.Fill(dt)
            DataGridView1.DataSource = dt


            sqlconn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        sqlconn.ConnectionString = "Server =" + dbserver + ";" + "user id=" + dbusername + ";" + "password =" + dbpassword + ";" + "database =" + dbStudents

        Try
            sqlconn.Open()

            sql = "SELECT * FROM students.products WHERE productId = " + studentNumber

            With sqlcmd
                .Connection = sqlconn
                .CommandText = sql
            End With

            da.SelectCommand = sqlcmd

            da.Fill(dt)
            DataGridView1.DataSource = dt


            sqlconn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        sqlconn.ConnectionString = "Server =" + dbserver + ";" + "user id=" + dbusername + ";" + "password =" + dbpassword + ";" + "database =" + dbStudents

        Try
            sqlconn.Open()

            sql = "SELECT * FROM students.orders WHERE orderId = " + studentNumber

            With sqlcmd
                .Connection = sqlconn
                .CommandText = sql
            End With

            da.SelectCommand = sqlcmd

            da.Fill(dt)
            DataGridView1.DataSource = dt


            sqlconn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
End Class