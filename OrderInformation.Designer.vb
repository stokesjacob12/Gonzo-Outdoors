<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderInformation
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
    Private Sub InitializeComponent1()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cusidTb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cus_database = New System.Windows.Forms.DataGridView()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.cusidComboBox = New System.Windows.Forms.ComboBox()
        Me.findTextBox = New System.Windows.Forms.TextBox()
        Me.soredButton = New System.Windows.Forms.Button()
        Me.mordButton = New System.Windows.Forms.Button()
        Me.memidTb = New System.Windows.Forms.TextBox()
        Me.billNum = New System.Windows.Forms.Label()
        CType(Me.cus_database, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(477, 169)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 133
        Me.Label2.Text = "Order No:"
        '
        'cusidTb
        '
        Me.cusidTb.Enabled = False
        Me.cusidTb.Location = New System.Drawing.Point(598, 186)
        Me.cusidTb.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cusidTb.Name = "cusidTb"
        Me.cusidTb.Size = New System.Drawing.Size(116, 20)
        Me.cusidTb.TabIndex = 132
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(623, 169)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "Customer ID:"
        '
        'cus_database
        '
        Me.cus_database.AllowUserToOrderColumns = True
        Me.cus_database.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.cus_database.Location = New System.Drawing.Point(2, 2)
        Me.cus_database.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cus_database.Name = "cus_database"
        Me.cus_database.Size = New System.Drawing.Size(582, 164)
        Me.cus_database.TabIndex = 130
        '
        'saveButton
        '
        Me.saveButton.Location = New System.Drawing.Point(146, 181)
        Me.saveButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(138, 24)
        Me.saveButton.TabIndex = 129
        Me.saveButton.Text = "Save Order Request"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'cusidComboBox
        '
        Me.cusidComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cusidComboBox.FormattingEnabled = True
        Me.cusidComboBox.Location = New System.Drawing.Point(311, 182)
        Me.cusidComboBox.Name = "cusidComboBox"
        Me.cusidComboBox.Size = New System.Drawing.Size(121, 21)
        Me.cusidComboBox.TabIndex = 138
        '
        'findTextBox
        '
        Me.findTextBox.Location = New System.Drawing.Point(127, 238)
        Me.findTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.findTextBox.Name = "findTextBox"
        Me.findTextBox.Size = New System.Drawing.Size(116, 20)
        Me.findTextBox.TabIndex = 137
        '
        'soredButton
        '
        Me.soredButton.Location = New System.Drawing.Point(2, 237)
        Me.soredButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.soredButton.Name = "soredButton"
        Me.soredButton.Size = New System.Drawing.Size(117, 20)
        Me.soredButton.TabIndex = 136
        Me.soredButton.Text = "Search"
        Me.soredButton.UseVisualStyleBackColor = True
        '
        'mordButton
        '
        Me.mordButton.Location = New System.Drawing.Point(2, 181)
        Me.mordButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.mordButton.Name = "mordButton"
        Me.mordButton.Size = New System.Drawing.Size(117, 20)
        Me.mordButton.TabIndex = 135
        Me.mordButton.Text = "Modify Order"
        Me.mordButton.UseVisualStyleBackColor = True
        '
        'memidTb
        '
        Me.memidTb.Enabled = False
        Me.memidTb.Location = New System.Drawing.Point(452, 186)
        Me.memidTb.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.memidTb.Name = "memidTb"
        Me.memidTb.Size = New System.Drawing.Size(116, 20)
        Me.memidTb.TabIndex = 134
        '
        'billNum
        '
        Me.billNum.AutoSize = True
        Me.billNum.Location = New System.Drawing.Point(-1, 120)
        Me.billNum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.billNum.Name = "billNum"
        Me.billNum.Size = New System.Drawing.Size(0, 13)
        Me.billNum.TabIndex = 128
        '
        'OrderInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 290)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cusidTb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cus_database)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.cusidComboBox)
        Me.Controls.Add(Me.findTextBox)
        Me.Controls.Add(Me.soredButton)
        Me.Controls.Add(Me.mordButton)
        Me.Controls.Add(Me.memidTb)
        Me.Controls.Add(Me.billNum)
        Me.Name = "OrderInformation"
        Me.Text = "OrderInformation"
        CType(Me.cus_database, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cusidTb As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cus_database As System.Windows.Forms.DataGridView
    Friend WithEvents saveButton As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cusidComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents findTextBox As System.Windows.Forms.TextBox
    Friend WithEvents soredButton As System.Windows.Forms.Button
    Friend WithEvents mordButton As System.Windows.Forms.Button
    Friend WithEvents memidTb As System.Windows.Forms.TextBox
    Friend WithEvents billNum As System.Windows.Forms.Label
End Class
