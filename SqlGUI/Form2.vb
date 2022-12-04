Imports MySql.Data.MySqlClient
Imports Microsoft.Win32

Public Class Save

    Dim sqlconn As New MySqlConnection
    Dim sqlcmd As New MySqlCommand
    Private myReader As MySqlDataReader
    Dim results As String
    Dim sql As String


    Dim customerName As String
    Dim studentNumber As String
    Dim programName As String

    Dim dbserver As String = "localhost"
    Dim dbusername As String = "root"
    Dim dbpassword As String = "APLEXY"
    Dim db As String = "students"


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim closeSession As DialogResult
        closeSession = MessageBox.Show("Are you sure you want to Exit ?", "ECE DBMS " +
        "Students Data /Home", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If closeSession = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        customerName = TextBox1.Text
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        studentNumber = TextBox8.Text
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sqlconn.ConnectionString = "Server =" + dbserver + ";" + "user id=" + dbusername + ";" + "password =" + dbpassword + ";" + "database =" + db

        Dim result As Integer
        Dim values As String
        values = "(" + "'" + customerName + "','" + studentNumber + "'" + ");"
        Try
            sqlconn.Open()
            With sqlcmd
                .Connection = sqlconn
                .CommandText = "INSERT INTO `customer` (`customerName`, `student_number`) VALUES" + values
                result = .ExecuteNonQuery()

                If result > 0 Then
                    MsgBox("New record has been added Successfully!")
                    Me.Close()

                Else
                    MsgBox("No record has been added!")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlconn.Close()

        End Try


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim backtohome As New Form1
        Me.Hide()
        backtohome.Show()

        TextBox1.Text = String.Empty
        TextBox8.Text = String.Empty
    End Sub
End Class