Imports System.Data
Imports System.Data.SqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As SqlConnection = New SqlConnection("Data Source=AJ\SQLEXPRESS01;Initial Catalog=vbloginform;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select * from login where username='" + +"' and password='" + +"'", conn)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()

        sda.Fill(dt)

        If (dt.Rows.Count > 0) Then
            MessageBox.Show("login success", "infromation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
