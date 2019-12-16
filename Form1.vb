
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_Database1__accdb_DataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me._Database1__accdb_DataSet.Table1)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Username As String
        Dim Course As String
        Dim Subject As String

        Username = Me.Username.Text
        Course = Me.Course.Text
        Subject = Me.Subject.Text

        Me.Table1TableAdapter.Insert(Username, Course, Subject)
        Me.Table1TableAdapter.Fill(Me._Database1__accdb_DataSet.Table1)

        MsgBox("Added")
        Username = ""
        Course = ""
        Subject = ""

    End Sub


End Class
