Imports MySql.Data.MySqlClient
Module Dbmodule
    Const STR_CONN = "server=localhost;user id=root;database=akademik"
    Dim DBcon As New MySqlConnection
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim ds As New DataSet


    Sub koneksi_mysql()
        If DBcon.State = Data.ConnectionState.Open Then DBcon.Close()
        Try
            DBcon.ConnectionString = STR_CONN
            DBcon.Open()

        Catch ex As MySqlException
            MsgBox("Gagal Koneksi" & vbCrLf & ex.Message)
        End Try
    End Sub

    Function getAllRecords(ByVal tblname As String) As DataTable
        cmd = New MySqlCommand("select * from " & tblname, DBcon)
        da = New MySqlDataAdapter(cmd)
        ds.Tables.Clear()
        da.Fill(ds, "ds_" & tblname)

        Return ds.Tables("ds_" & tblname)
        da.Dispose()
        cmd.Dispose()

    End Function

    Function insert(ByVal kdmk As String, ByVal nama_mk As String, ByVal sks As String, ByVal smst As String) As Boolean
        Dim sql As String

        sql = "Insert into mtkuliah(kdmk,nama_mk,sks,smst) values (@kdmk,@nama_mk,@sks,@smst)"

        cmd = New MySqlCommand(sql)
        cmd.Connection = DBcon
        cmd.Parameters.AddWithValue("@kdmk", kdmk)
        cmd.Parameters.AddWithValue("@nama_mk", nama_mk)
        cmd.Parameters.AddWithValue("@sks", sks)
        cmd.Parameters.AddWithValue("@smst", smst)
        Return cmd.ExecuteNonQuery
        cmd.Dispose()
    End Function

    Function edit(ByVal kdmk As String, ByVal nama_mk As String, ByVal sks As String, ByVal smst As String) As Boolean
        Dim sql As String

        sql = "update mtkuliah set nama_mk=@nama_mk,sks=@sks,smst=@smst where kdmk=@kdmk"

        cmd = New MySqlCommand(sql)
        cmd.Connection = DBcon
        cmd.Parameters.AddWithValue("@kdmk", kdmk)
        cmd.Parameters.AddWithValue("@nama_mk", nama_mk)
        cmd.Parameters.AddWithValue("@sks", sks)
        cmd.Parameters.AddWithValue("@smst", smst)
        Return cmd.ExecuteNonQuery
        cmd.Dispose()
    End Function
    Function delete(ByVal kdmk As String) As Boolean
        Dim sql As String

        sql = "delete from mtkuliah where kdmk=@kdmk"

        cmd = New MySqlCommand(sql)
        cmd.Connection = DBcon
        cmd.Parameters.AddWithValue("@kdmk", kdmk)

        Return cmd.ExecuteNonQuery
        cmd.Dispose()
    End Function

End Module
