Imports CustomerMaintenance.MMABooksEntity
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Public Class frmCustomerMaintenance

    Private selectedCustomer As Customer

    Private Sub btnGetCustomer_Click(sender As Object, e As EventArgs) Handles btnGetCustomer.Click
        If Validator.IsPresent(txtCustomerID) AndAlso
                Validator.IsInt32(txtCustomerID) Then
            Dim customerID As Integer = CInt(txtCustomerID.Text)
            Me.GetCustomer(customerID)
        End If
    End Sub

    Private Sub GetCustomer(customerID As Integer)
        Try
            ' Step 6
            ' Code a query to retrieve the selected customer and
            ' store the Customer object in the module-level variable.

            selectedCustomer = (From customer In mmaBooks.Customers
                                Where customer.CustomerID = customerID).Single

            If selectedCustomer Is Nothing Then
                MessageBox.Show("No customer found with this ID> " &
                                "Please try again.", "Customer Not Found")
                Me.ClearControls()
                txtCustomerID.Focus()
            Else
                ' Step 7
                ' Add code to load the State object for the customer
                ' if it isn't already loaded

                If Not mmaBooks.Entry(selectedCustomer).Reference("State").IsLoaded Then
                    mmaBooks.Entry(selectedCustomer).Reference("State").Load()
                End If

                Me.DisplayCustomer()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub

    Private Sub DisplayCustomer()
        txtName.Text = selectedCustomer.Name
        txtAddress.Text = selectedCustomer.Address
        txtCity.Text = selectedCustomer.City
        txtState.Text = selectedCustomer.State.StateName
        txtZipCode.Text = selectedCustomer.ZipCode
        btnModify.Enabled = True
        btnDelete.Enabled = True
    End Sub

    Private Sub ClearControls()
        txtName.Text = ""
        txtAddress.Text = ""
        txtCity.Text = ""
        txtState.Text = ""
        txtZipCode.Text = ""
        btnModify.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim addModifyCustomerForm As New frmAddModifyCustomer
        addModifyCustomerForm.addCustomer = True
        Dim result As DialogResult = addModifyCustomerForm.ShowDialog
        If result = DialogResult.OK Then
            selectedCustomer = addModifyCustomerForm.customer
            txtCustomerID.Text = selectedCustomer.CustomerID.ToString
            Me.DisplayCustomer()
        End If
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        Dim addModifyCustomerForm As New frmAddModifyCustomer
        addModifyCustomerForm.addCustomer = False
        addModifyCustomerForm.customer = selectedCustomer
        Dim result As DialogResult = addModifyCustomerForm.ShowDialog
        If result = DialogResult.OK OrElse result = DialogResult.Retry Then
            selectedCustomer = addModifyCustomerForm.customer
            Me.DisplayCustomer()
        Else
            txtCustomerID.Text = ""
            Me.ClearControls()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As DialogResult =
            MessageBox.Show("Delete " & selectedCustomer.Name & "?",
                "Confirm Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                ' Step 18
                ' Mark the row for deletion.
                ' Update the database.
                mmaBooks.Customers.Remove(selectedCustomer)
                mmaBooks.SaveChanges()

                txtCustomerID.Text = ""
                Me.ClearControls()

                ' Step 22
                ' Add concurrency error handling.

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.GetType.ToString)
            End Try
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
