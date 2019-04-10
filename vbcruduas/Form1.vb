Imports MySql.Data.MySqlClient
Public Class Form1

    Dim addnewFlag As Boolean
    Dim editFlag As Boolean
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadData()
        showdata()
        setButton(False)
    End Sub
    Sub loadData()
        Dbmodule.koneksi_mysql()
        dgMatakuliah.DataSource = Dbmodule.getAllRecords("mtkuliah")
    End Sub
    Sub showdata()
        txtKdmk.Text = dgMatakuliah.Item("kdmk", dgMatakuliah.CurrentRow.Index).Value
        txtNama_matakuliah.Text = dgMatakuliah.Item("nama_mk", dgMatakuliah.CurrentRow.Index).Value
        txtSks.Text = dgMatakuliah.Item("sks", dgMatakuliah.CurrentRow.Index).Value
        txtSmst.Text = dgMatakuliah.Item("smst", dgMatakuliah.CurrentRow.Index).Value

        Locktext(False)
    End Sub
    Sub ClearText()
        txtKdmk.Text() = ""
        txtNama_matakuliah.Text() = ""
        txtSks.Text() = ""
        txtSmst.Text() = ""
        Locktext(True)
    End Sub
    Sub Locktext(ByVal isenable As Boolean)
        txtKdmk.Enabled() = isenable
        txtNama_matakuliah.Enabled() = isenable
        txtSks.Enabled() = isenable
        txtSmst.Enabled() = isenable
    End Sub
    Sub setButton(ByVal aktif As Boolean)
        btnAdd.Enabled = Not aktif
        BtnEdit.Enabled = Not aktif
        btnDelete.Enabled = Not aktif
        btnCancel.Enabled = aktif
        btnSave.Enabled = aktif
    End Sub

    Private Sub dgMatakuliah_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgMatakuliah.CellContentClick
        showdata()

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ClearText()
        txtKdmk.Focus()
        Locktext(True)
        setButton(True)
        addnewFlag = True
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If addnewFlag Then
            Dbmodule.insert(txtKdmk.Text,txtNama_matakuliah.Text,txtSks.Text,txtSmst.Text)
        Else
            Dbmodule.edit(txtKdmk.Text, txtNama_matakuliah.Text, txtSks.Text, txtSmst.Text)
        End If
        loadData()
        Locktext(False)
        setButton(False)
        addnewFlag = False
        editFlag = False
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        Locktext(True)
        setButton(True)
        editFlag = True
    End Sub

   
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dbmodule.delete(txtKdmk.Text)
        loadData()
        showdata()
        Locktext(False)
        setButton(False)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ClearText()
    End Sub
End Class
