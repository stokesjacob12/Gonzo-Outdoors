Imports System
Imports System.Data.OleDb
Imports System.Windows.Forms


Public Class OrderInformation

    Private Sub OrderInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New OleDbConnection
        Dim query As String
        Dim ordCmd As OleDbCommand = New OleDbCommand





        ' RUN QUERY
        query = "SELECT * FROM ORDER_ITEMS"

        ordCmd.CommandText = query
        connection.ConnectionString = My.Settings.ProjectDB1ConnectionString1
        ordCmd.Connection = connection
        connection.Open()

        ordCmd.ExecuteNonQuery()


        Call InitializeComponent()


    End Sub
    Private Sub SearchCustomer(Name As String)
        Dim connection As New OleDbConnection
        Dim query As String
        Dim ordCmd As OleDbCommand = New OleDbCommand

        ' Add search query parameters using wildcards in search strings
        ordCmd.Parameters.Add(New OleDbParameter("OrdNum", Name)) 'finds name somewhere in that string

        'run query variable is passed through search criteria
        query = "SELECT ORDERS.OrdNum, CUSTOMER.custID, CUSTOMER.lName, CUSTOMER.fname, ORDERS.OrderTotal, CUSTOMER.billAddress1, ORDERS.Order Status " &
                      "FROM ORDERS " &
                      "INNER JOIN CUSTOMER" &
                      "ON ORDERS.custID=CUSTOMER.custID" &
                      "WHERE ORDERS.OrdNum=" & Name
        connection.ConnectionString = My.Settings.ProjectDB1ConnectionString1

        ordCmd.CommandText = query
        ordCmd.Connection = connection
        ordCmd.ExecuteNonQuery()


    End Sub

    Private Sub soredButton_Click(sender As Object, e As EventArgs) Handles soredButton.Click
        SearchCustomer(findTextBox.Text)
    End Sub

    Private Sub mordButton_Click(sender As Object, e As EventArgs) Handles mordButton.Click

    End Sub
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cusidTb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cus_database = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.findTextBox = New System.Windows.Forms.TextBox()
        Me.soredButton = New System.Windows.Forms.Button()
        Me.mordButton = New System.Windows.Forms.Button()
        Me.memidTb = New System.Windows.Forms.TextBox()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.billNum = New System.Windows.Forms.Label()
        Me.cusidComboBox = New System.Windows.Forms.ComboBox()
        CType(Me.cus_database, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(488, 179)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "Order No:"
        '
        'cusidTb
        '
        Me.cusidTb.Enabled = False
        Me.cusidTb.Location = New System.Drawing.Point(609, 196)
        Me.cusidTb.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cusidTb.Name = "cusidTb"
        Me.cusidTb.Size = New System.Drawing.Size(116, 20)
        Me.cusidTb.TabIndex = 121
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(634, 179)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "Customer ID:"
        '
        'cus_database
        '
        Me.cus_database.AllowUserToOrderColumns = True
        Me.cus_database.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.cus_database.Location = New System.Drawing.Point(13, 12)
        Me.cus_database.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cus_database.Name = "cus_database"
        Me.cus_database.Size = New System.Drawing.Size(582, 164)
        Me.cus_database.TabIndex = 119
        '
        'OpenFileDialog1
        '
        '
        'findTextBox
        '
        Me.findTextBox.Location = New System.Drawing.Point(138, 248)
        Me.findTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.findTextBox.Name = "findTextBox"
        Me.findTextBox.Size = New System.Drawing.Size(116, 20)
        Me.findTextBox.TabIndex = 126
        '
        'soredButton
        '
        Me.soredButton.Location = New System.Drawing.Point(13, 247)
        Me.soredButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.soredButton.Name = "soredButton"
        Me.soredButton.Size = New System.Drawing.Size(117, 20)
        Me.soredButton.TabIndex = 125
        Me.soredButton.Text = "Search"
        Me.soredButton.UseVisualStyleBackColor = True
        '
        'mordButton
        '
        Me.mordButton.Location = New System.Drawing.Point(13, 191)
        Me.mordButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.mordButton.Name = "mordButton"
        Me.mordButton.Size = New System.Drawing.Size(117, 20)
        Me.mordButton.TabIndex = 124
        Me.mordButton.Text = "Modify Order"
        Me.mordButton.UseVisualStyleBackColor = True
        '
        'memidTb
        '
        Me.memidTb.Enabled = False
        Me.memidTb.Location = New System.Drawing.Point(463, 196)
        Me.memidTb.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.memidTb.Name = "memidTb"
        Me.memidTb.Size = New System.Drawing.Size(116, 20)
        Me.memidTb.TabIndex = 123
        '
        'saveButton
        '
        Me.saveButton.Location = New System.Drawing.Point(157, 191)
        Me.saveButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(138, 24)
        Me.saveButton.TabIndex = 118
        Me.saveButton.Text = "Save Order Request"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'billNum
        '
        Me.billNum.AutoSize = True
        Me.billNum.Location = New System.Drawing.Point(10, 130)
        Me.billNum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.billNum.Name = "billNum"
        Me.billNum.Size = New System.Drawing.Size(0, 13)
        Me.billNum.TabIndex = 117
        '
        'cusidComboBox
        '
        Me.cusidComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cusidComboBox.FormattingEnabled = True
        Me.cusidComboBox.Location = New System.Drawing.Point(322, 192)
        Me.cusidComboBox.Name = "cusidComboBox"
        Me.cusidComboBox.Size = New System.Drawing.Size(121, 21)
        Me.cusidComboBox.TabIndex = 127
        '
        'OrderInformation
        '
        Me.ClientSize = New System.Drawing.Size(757, 322)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cusidTb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cus_database)
        Me.Controls.Add(Me.cusidComboBox)
        Me.Controls.Add(Me.findTextBox)
        Me.Controls.Add(Me.soredButton)
        Me.Controls.Add(Me.mordButton)
        Me.Controls.Add(Me.memidTb)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.billNum)
        Me.Name = "OrderInformation"
        CType(Me.cus_database, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

  
End Class