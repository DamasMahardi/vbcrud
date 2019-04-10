<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgMatakuliah = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtKdmk = New System.Windows.Forms.MaskedTextBox()
        Me.txtNama_matakuliah = New System.Windows.Forms.MaskedTextBox()
        Me.txtSks = New System.Windows.Forms.MaskedTextBox()
        Me.txtSmst = New System.Windows.Forms.MaskedTextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.dgMatakuliah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgMatakuliah
        '
        Me.dgMatakuliah.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMatakuliah.Location = New System.Drawing.Point(3, 12)
        Me.dgMatakuliah.Name = "dgMatakuliah"
        Me.dgMatakuliah.Size = New System.Drawing.Size(742, 148)
        Me.dgMatakuliah.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 223)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kode Matakuliah"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 289)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Matakuliah"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 342)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Jumlah SKS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(64, 391)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Semester"
        '
        'txtKdmk
        '
        Me.txtKdmk.Location = New System.Drawing.Point(281, 216)
        Me.txtKdmk.Name = "txtKdmk"
        Me.txtKdmk.Size = New System.Drawing.Size(227, 20)
        Me.txtKdmk.TabIndex = 5
        '
        'txtNama_matakuliah
        '
        Me.txtNama_matakuliah.Location = New System.Drawing.Point(281, 282)
        Me.txtNama_matakuliah.Name = "txtNama_matakuliah"
        Me.txtNama_matakuliah.Size = New System.Drawing.Size(227, 20)
        Me.txtNama_matakuliah.TabIndex = 6
        '
        'txtSks
        '
        Me.txtSks.Location = New System.Drawing.Point(281, 339)
        Me.txtSks.Name = "txtSks"
        Me.txtSks.Size = New System.Drawing.Size(144, 20)
        Me.txtSks.TabIndex = 7
        '
        'txtSmst
        '
        Me.txtSmst.Location = New System.Drawing.Point(281, 384)
        Me.txtSmst.Name = "txtSmst"
        Me.txtSmst.Size = New System.Drawing.Size(144, 20)
        Me.txtSmst.TabIndex = 8
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(292, 446)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(61, 27)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add New"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(368, 447)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(69, 26)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(443, 447)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(65, 26)
        Me.BtnEdit.TabIndex = 11
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(518, 446)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(68, 27)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(601, 446)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(61, 26)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 495)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtSmst)
        Me.Controls.Add(Me.txtSks)
        Me.Controls.Add(Me.txtNama_matakuliah)
        Me.Controls.Add(Me.txtKdmk)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgMatakuliah)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgMatakuliah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgMatakuliah As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtKdmk As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtNama_matakuliah As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtSks As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtSmst As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button

End Class
