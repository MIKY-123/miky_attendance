Imports System.Data.SqlClient
Imports System.IO
Public Class otherApplication
    Private Sub otherApplication_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub comboboxLoad()
        Dim connectionString As String = "Data Source=your_server;Initial Catalog=your_database;Integrated Security=True"

        ' Define your query
        Dim query As String = "SELECT id, sector FROM bus_sector"

        ' Create a new DataTable
        Dim dtbus_sector As New DataTable()

        ' Use a Using block to ensure the connection is closed and disposed properly
        Using conx As New SqlConnection(connectionString)
            Try
                ' Open the connection
                conx.Open()

                ' Create a SqlDataAdapter to fetch the data
                Using dtabus_sector As New SqlDataAdapter(query, conx)
                    ' Fill the DataTable with the results from the database
                    dtabus_sector.Fill(dtbus_sector)
                End Using

            Catch ex As Exception
                ' Handle any exceptions (logging, displaying message, etc.)
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using

        ' Bind the data to the BunifuDropdown
        ' BunifuDropdownlocation.DataSource = dtbus_sector
        '  BunifuDropdownlocation.DisplayMember = "sector" ' Column to display
        ' BunifuDropdownlocation.ValueMember = "id" ' Column to use as the value
        BunifuDropdownlocation.selectedIndex = -1 ' Optionally set no initial selection

    End Sub


End Class