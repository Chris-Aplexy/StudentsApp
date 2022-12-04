Imports MySql.Data.MySqlClient
Imports Microsoft.Win32
Public Class SaveProductsForm

    Dim sqlconn As New MySqlConnection
    Dim sqlcmd As New MySqlCommand
    Private myReader As MySqlDataReader
    Dim results As String
    Dim sql As String

    Dim dbserver As String = "localhost"
    Dim dbusername As String = "root"
    Dim dbpassword As String = "APLEXY"
    Dim db As String = "students"

    Dim productName As String
    Dim productCode As String
    Dim productPrice As String
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        productName = TextBox4.Text
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        productCode = TextBox1.Text
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        productPrice = TextBox5.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim closeSession As DialogResult
        closeSession = MessageBox.Show("Confirm exit", "ECE DBMS " +
        "Students Data /Products", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If closeSession = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sqlconn.ConnectionString = "Server =" + dbserver + ";" + "user id=" + dbusername + ";" + "password =" + dbpassword + ";" + "database =" + db

        Dim result As Integer
        Dim values As String
        values = "(" + "'" + productName + "','" + productCode + "','" + productPrice + "'" + ");"
        Try
            sqlconn.Open()
            With sqlcmd
                .Connection = sqlconn
                .CommandText = "INSERT INTO `products` (`product_name`, `product_code`,`marked_price`) VALUES" + values
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

        TextBox1.Text = String.Empty
        TextBox4.Text = String.Empty
        TextBox5.Text = String.Empty


    End Sub
End Class