Imports MySql.Data.MySqlClient
Imports Microsoft.Win32

Public Class AddOrderForm

    Dim orderDate As String
    Dim deliveryDate As String
    Dim customerId As String
    Dim customerName As String
    Dim productID As String


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

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        customerId = TextBox4.Text
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        customerName = TextBox5.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim closeSession As DialogResult
        closeSession = MessageBox.Show("Confirm exit", "ECE DBMS " +
        "Students Data /Orders", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If closeSession = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sqlconn.ConnectionString = "Server =" + dbserver + ";" + "user id=" + dbusername + ";" + "password =" + dbpassword + ";" + "database =" + db
        'rst getting the customer name
        '
        '
        ' sqlconn.Open()
        '
        ' sql = "SELECT customer_name FROM students.customer WHERE customerId = " + customerId
        '
        ' With sqlcmd
        '     .Connection = sqlconn
        '     .CommandText = sql
        ' End With
        '
        ' da.SelectCommand = sqlcmd
        '
        ' 'customerName = da.SelectCommand
        '
        ' sqlconn.Close()
        '
        ' Catch ex As Exception
        '     MsgBox(ex.Message)
        '
        ' End Try
        ''end 

        Dim result As Integer
        Dim values As String
        values = "(" + "'" + customerId + "','" + productID + "','" + customerName + "','" + orderDate + "','" + deliveryDate + "'" + ");"
        Try
            sqlconn.Open()
            With sqlcmd
                .Connection = sqlconn
                .CommandText = "INSERT INTO `orders` (`customerId`, `product_Id`,`customer_name`, `orderDate`, `deliveryDate`) VALUES" + values
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
        TextBox3.Text = String.Empty
        TextBox2.Text = String.Empty

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        productID = TextBox1.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        orderDate = TextBox2.Text
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        deliveryDate = TextBox3.Text
    End Sub

    Private Sub AddOrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim bachToHome As New Form1
        Me.Hide()
        bachToHome.Show()

    End Sub
End Class