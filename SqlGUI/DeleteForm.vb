Imports MySql.Data.MySqlClient
Imports Microsoft.Win32

Public Class DeleteForm
    Dim sqlconn As New MySqlConnection
    Dim sqlcmd As New MySqlCommand
    Private myReader As MySqlDataReader
    Dim da As New MySqlDataAdapter
    Dim dt As DataTable = New DataTable()
    Dim results As String
    Dim sql As String

    Dim firstName As String
    Dim lastName As String
    Dim email As String
    Dim password As String
    Dim studentNumber As String
    Dim programName As String

    Dim dbserver As String = "localhost"
    Dim dbusername As String = "root"
    Dim dbpassword As String = "APLEXY"
    Dim dbStudents As String = "students"

    Dim ID As String
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ID = TextBox1.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        sqlconn.ConnectionString = "Server =" + dbserver + ";" + "user id=" + dbusername + ";" + "password =" + dbpassword + ";" + "database =" + dbStudents

        Dim result As Integer
        Dim values As String
        values = "(" + "'" + firstName + "','" + studentNumber + "'" + ");"
        Try
            sqlconn.Open()
            With sqlcmd
                .Connection = sqlconn
                .CommandText = "DELETE FROM customer where student_number =" + "'" + ID + "'"

                result = .ExecuteNonQuery()

                If result > 0 Then
                    MsgBox("Record has Successfuly been deleted!")
                    Me.Close()

                Else
                    MsgBox("No record has been deleted. Try again!")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlconn.Close()

        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        sqlconn.ConnectionString = "Server =" + dbserver + ";" + "user id=" + dbusername + ";" + "password =" + dbpassword + ";" + "database =" + dbStudents

        Dim result As Integer
        Dim values As String
        values = "(" + "'" + firstName + "','" + studentNumber + "'" + ");"
        Try
            sqlconn.Open()
            With sqlcmd
                .Connection = sqlconn
                .CommandText = "DELETE FROM products where productId =" + "'" + ID + "'"

                result = .ExecuteNonQuery()

                If result > 0 Then
                    MsgBox("Record has Successfuly been deleted!")
                    Me.Close()

                Else
                    MsgBox("No record has been deleted. Try again!")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlconn.Close()

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sqlconn.ConnectionString = "Server =" + dbserver + ";" + "user id=" + dbusername + ";" + "password =" + dbpassword + ";" + "database =" + dbStudents

        Dim result As Integer
        Dim values As String
        values = "(" + "'" + firstName + "','" + studentNumber + "'" + ");"
        Try
            sqlconn.Open()
            With sqlcmd
                .Connection = sqlconn
                .CommandText = "DELETE FROM orders where orderId =" + "'" + ID + "'"

                result = .ExecuteNonQuery()

                If result > 0 Then
                    MsgBox("Record has Successfuly been deleted!")
                    Me.Close()

                Else
                    MsgBox("No record has been deleted. Try again!")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlconn.Close()

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim closeSession As DialogResult
        closeSession = MessageBox.Show("Are You Sure You Want To Exit?", "ECE DBMS " +
        "Students Data /Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If closeSession = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub DeleteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub
End Class