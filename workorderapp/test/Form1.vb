Public Class Form1

    Private Sub TESTBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TESTBindingNavigatorSaveItem.Click
        'Used to validate data, edit, and update data.
        Me.Validate()
        Me.TESTBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TESTDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TESTDataSet.TEST' table. You can move, or remove it, as needed.
        Me.TESTTableAdapter.Fill(Me.TESTDataSet.TEST)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Close application
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TESTBindingSource.AddNew()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Try
            TESTBindingSource.EndEdit()
            TESTTableAdapter.Update(TESTDataSet.TEST)
            MessageBox.Show("Data Saved")
        Catch ex As Exception
            MessageBox.Show("Error occured while saving")
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        TESTBindingSource.RemoveCurrent()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form2.Show()
    End Sub
End Class
