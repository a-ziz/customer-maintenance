Imports CustomerMaintenance.MMABooksEntity
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Public Class frmAddModifyCustomer
    Public addCustomer As Boolean
    Public customer As Customer

    Private Sub frmAddModifyCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LoadComboBox()
        If addCustomer Then
            Me.Text = "Add Customer"
            cboStates.SelectedIndex = -1
        Else
            Me.Text = "Modify Customer"
            Me.DisplayCustomerData()
        End If
    End Sub

    Private Sub LoadComboBox()
        Try
            ' Step 10
            ' Code a query to retrieve the required information from
            ' the States table, and sort the results by state name.
            ' Bind the State combo box to the query results.

            Dim states = (From state In mmaBooks.States
                          Order By state.StateName
                          Select state).ToList()
            cboStates.DataSource = states
            cboStates.DisplayMember = "StateName"
            cboStates.ValueMember = "StateCode"

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub

    Private Sub DisplayCustomerData()
        txtName.Text = customer.Name
        txtAddress.Text = customer.Address
        txtCity.Text = customer.City
        cboStates.SelectedValue = customer.StateCode
        txtZipCode.Text = customer.ZipCode
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        If IsValidData() Then
            If addCustomer Then
                customer = New Customer
                Me.PutCustomerData(customer)

                ' Step 12
                ' Add the new customer to the collection of customers.
                mmaBooks.Customers.Add(customer)
                Try
                    ' Update the database.
                    mmaBooks.SaveChanges()
                    Me.DialogResult = DialogResult.OK
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.GetType.ToString)
                End Try
            Else
                Me.PutCustomerData(customer)
                Try

                    ' Step 15
                    ' Update the database.
                    mmaBooks.SaveChanges()

                    Me.DialogResult = DialogResult.OK

                    ' Step 22
                    ' Add concurrency error handling.

                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.GetType.ToString)
                End Try
            End If
        End If
    End Sub

    Private Function IsValidData() As Boolean
        Return Validator.IsPresent(txtName) AndAlso
           Validator.IsPresent(txtAddress) AndAlso
           Validator.IsPresent(txtCity) AndAlso
           Validator.IsPresent(cboStates) AndAlso
           Validator.IsPresent(txtZipCode) AndAlso
           Validator.IsInt32(txtZipCode)
    End Function

    Private Sub PutCustomerData(customer As Customer)
        customer.Name = txtName.Text
        customer.Address = txtAddress.Text
        customer.City = txtCity.Text
        customer.StateCode = cboStates.SelectedValue.ToString
        customer.ZipCode = txtZipCode.Text
    End Sub
End Class