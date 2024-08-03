Imports System.Data.SqlClient
Imports System.IO

Module ModPoint

    'Dim dir As String = My.Computer.FileSystem.CurrentDirectory + "\connection.txt"
    'Dim reader As StreamReader = New StreamReader(dir, True)
    'Dim line As String

    '   Public conx As SqlConnection = New SqlConnection("Data Source=DESKTOP-GC5K2R1,1433; Network Library=DBMSSOCN; Initial Catalog=money6; User ID=sa; Password=dartmic26; ")
    Public conx As SqlConnection = New SqlConnection("Data Source=(local);  Initial Catalog=[attendance];User ID=sa; Password=dartmic26; ")


    Sub Main()
        'Try
        '    line = reader.ReadLine
        '    reader.Close()

        '    MessageBox.Show(line)
        'Catch ex As Exception

        '    MsgBox("An SQL Error Has Occurred - Details: " + "(" + ex.Message + ")")
        'End Try

    End Sub


End Module
