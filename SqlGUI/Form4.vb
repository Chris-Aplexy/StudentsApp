Imports MySql.Data.MySqlClient
Imports Microsoft.Win32

Public Class Form4

    Dim sqlconn As New MySqlConnection
    Dim sqlcmd As New MySqlCommand
    Private myReader As MySqlDataReader
    Dim da As New MySqlDataAdapter
    Dim dt As DataTable = New DataTable()
    Dim results As String
    Dim sql As String

    Dim firstName As String
    Dim studentNumber As String

    Dim dbserver As String = "localhost"
    Dim dbusername As String = "root"
    Dim dbpassword As String = "APLEXY"
    Dim dbStudents As String = "students"

    Dim ID As String

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        firstName = TextBox1.Text
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        studentNumber = TextBox8.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim closeSession As DialogResult
        closeSession = MessageBox.Show("Confirm exit", "ECE DBMS " +
        "Students Data /Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If closeSession = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

        ID = TextBox3.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        sqlconn.ConnectionString = "Server =" + dbserver + ";" + "user id=" + dbusername + ";" + "password =" + dbpassword + ";" + "database =" + dbStudents

        Dim result As Integer
        Dim values As String
        values = "(" + "'" + firstName + "','" + studentNumber + "'" + ");"
        Try
            sqlconn.Open()
            With sqlcmd
                .Connection = sqlconn
                .CommandText = "Update customer set customerName = " + "'" + firstName + "', " + "student_number=" + "'" + studentNumber + "'" + "where student_number = " + "'" + ID + "'"

                result = .ExecuteNonQuery()

                If result > 0 Then
                    MsgBox("New record has been added Successfully!")
                    Me.Close()

                Else
                    MsgBox("No record has been added Successfully!")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlconn.Close()

        End Try

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim backtohome As New Form1
        Me.Hide()
        backtohome.Show()

    End Sub
End Class