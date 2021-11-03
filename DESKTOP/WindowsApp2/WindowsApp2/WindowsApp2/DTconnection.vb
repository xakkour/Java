Imports MySql.Data.MySqlClient
Public Class DTconnection
    Dim connect As New MySqlConnection("server='localhost';uid='root';pwd='';database='test2'")
    Public Function open() As MySqlConnection
        Try
            connect.Open()
            MsgBox("connected...")
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Return connect

    End Function
    Public Function close() As MySqlConnection
        Try
            connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Return connect

    End Function

End Class