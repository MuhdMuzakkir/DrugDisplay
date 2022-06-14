Imports System.Data.SqlClient
Public Class Form1

    Private Sub cmdSubmit_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click
        Dim cn As SqlConnection = New SqlConnection("Server=AHHQWS156\SQLEXPRESS;Database=Medication;User ID=username;Password=password;")
        cn.Open()
        Dim cm As New SqlCommand("SELECT MedName, MedPacking, MIMSClass, ATCClass, Remarks from MedDetails where ID=@param", cn)

        cm.Parameters.AddWithValue("@param", txtID.Text)

        Dim myreader As SqlDataReader
        myreader = cm.ExecuteReader()
        If (myreader.Read()) Then

            txtMedName.Text = myreader("MedName")
            txtMedPacking.Text = myreader("MedPacking")
            txtMIMSClass.Text = myreader("MIMSClass")
            txtATCClass.Text = myreader("ATCClass")
            txtRemarks.Text = myreader("Remarks")
        Else
            MessageBox.Show("No data found")
        End If


        cn.Close()



    End Sub
End Class
