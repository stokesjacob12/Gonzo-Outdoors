﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerOrderInformation
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
        Me.components = New System.ComponentModel.Container()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.cus_database = New System.Windows.Forms.DataGridView()
        Me.mordButton = New System.Windows.Forms.Button()
        Me.soredButton = New System.Windows.Forms.Button()
        Me.billNum = New System.Windows.Forms.Label()
        Me.findTextBox = New System.Windows.Forms.TextBox()
        Me.newCus = New System.Windows.Forms.Button()
        Me.CUSTOMERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjectDB1DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjectDB1DataSet = New WindowsApplication1.ProjectDB1DataSet()
        Me.ORDERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CUSTOMERTableAdapter = New WindowsApplication1.ProjectDB1DataSetTableAdapters.CUSTOMERTableAdapter()
        Me.ORDERSTableAdapter = New WindowsApplication1.ProjectDB1DataSetTableAdapters.ORDERSTableAdapter()
        Me.ORDERITEMSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ORDER_ITEMSTableAdapter = New WindowsApplication1.ProjectDB1DataSetTableAdapters.ORDER_ITEMSTableAdapter()
        Me.ProjectDB1DataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.delButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.refreshButton = New System.Windows.Forms.Button()
        CType(Me.cus_database, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDB1DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDB1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDERITEMSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDB1DataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cus_database
        '
        Me.cus_database.AllowUserToOrderColumns = True
        Me.cus_database.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cus_database.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cus_database.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.cus_database.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.cus_database.Location = New System.Drawing.Point(9, 45)
        Me.cus_database.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cus_database.Name = "cus_database"
        Me.cus_database.Size = New System.Drawing.Size(623, 164)
        Me.cus_database.TabIndex = 101
        '
        'mordButton
        '
        Me.mordButton.Location = New System.Drawing.Point(9, 219)
        Me.mordButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.mordButton.Name = "mordButton"
        Me.mordButton.Size = New System.Drawing.Size(104, 20)
        Me.mordButton.TabIndex = 112
        Me.mordButton.Text = "Modify Order"
        Me.mordButton.UseVisualStyleBackColor = True
        '
        'soredButton
        '
        Me.soredButton.Location = New System.Drawing.Point(9, 12)
        Me.soredButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.soredButton.Name = "soredButton"
        Me.soredButton.Size = New System.Drawing.Size(157, 20)
        Me.soredButton.TabIndex = 114
        Me.soredButton.Text = "Search By Order Num:"
        Me.soredButton.UseVisualStyleBackColor = True
        '
        'billNum
        '
        Me.billNum.AutoSize = True
        Me.billNum.Location = New System.Drawing.Point(6, 124)
        Me.billNum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.billNum.Name = "billNum"
        Me.billNum.Size = New System.Drawing.Size(0, 13)
        Me.billNum.TabIndex = 81
        '
        'findTextBox
        '
        Me.findTextBox.Location = New System.Drawing.Point(176, 13)
        Me.findTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.findTextBox.Name = "findTextBox"
        Me.findTextBox.Size = New System.Drawing.Size(116, 20)
        Me.findTextBox.TabIndex = 115
        '
        'newCus
        '
        Me.newCus.Location = New System.Drawing.Point(342, 9)
        Me.newCus.Name = "newCus"
        Me.newCus.Size = New System.Drawing.Size(105, 23)
        Me.newCus.TabIndex = 117
        Me.newCus.Text = "New Customer"
        Me.newCus.UseVisualStyleBackColor = True
        '
        'CUSTOMERBindingSource
        '
        Me.CUSTOMERBindingSource.DataMember = "CUSTOMER"
        Me.CUSTOMERBindingSource.DataSource = Me.ProjectDB1DataSetBindingSource
        '
        'ProjectDB1DataSetBindingSource
        '
        Me.ProjectDB1DataSetBindingSource.DataSource = Me.ProjectDB1DataSet
        Me.ProjectDB1DataSetBindingSource.Position = 0
        '
        'ProjectDB1DataSet
        '
        Me.ProjectDB1DataSet.DataSetName = "ProjectDB1DataSet"
        Me.ProjectDB1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ORDERSBindingSource
        '
        Me.ORDERSBindingSource.DataMember = "ORDERS"
        Me.ORDERSBindingSource.DataSource = Me.ProjectDB1DataSetBindingSource
        '
        'CUSTOMERTableAdapter
        '
        Me.CUSTOMERTableAdapter.ClearBeforeFill = True
        '
        'ORDERSTableAdapter
        '
        Me.ORDERSTableAdapter.ClearBeforeFill = True
        '
        'ORDERITEMSBindingSource
        '
        Me.ORDERITEMSBindingSource.DataMember = "ORDER_ITEMS"
        Me.ORDERITEMSBindingSource.DataSource = Me.ProjectDB1DataSetBindingSource
        '
        'ORDER_ITEMSTableAdapter
        '
        Me.ORDER_ITEMSTableAdapter.ClearBeforeFill = True
        '
        'ProjectDB1DataSetBindingSource1
        '
        Me.ProjectDB1DataSetBindingSource1.DataSource = Me.ProjectDB1DataSet
        Me.ProjectDB1DataSetBindingSource1.Position = 0
        '
        'delButton
        '
        Me.delButton.Location = New System.Drawing.Point(518, 220)
        Me.delButton.Name = "delButton"
        Me.delButton.Size = New System.Drawing.Size(105, 23)
        Me.delButton.TabIndex = 120
        Me.delButton.Text = "Delete Customer"
        Me.delButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(506, 9)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(105, 23)
        Me.exitButton.TabIndex = 121
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'refreshButton
        '
        Me.refreshButton.Location = New System.Drawing.Point(138, 215)
        Me.refreshButton.Name = "refreshButton"
        Me.refreshButton.Size = New System.Drawing.Size(105, 23)
        Me.refreshButton.TabIndex = 122
        Me.refreshButton.Text = "Refresh"
        Me.refreshButton.UseVisualStyleBackColor = True
        '
        'CustomerOrderInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 281)
        Me.ControlBox = False
        Me.Controls.Add(Me.refreshButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.delButton)
        Me.Controls.Add(Me.newCus)
        Me.Controls.Add(Me.findTextBox)
        Me.Controls.Add(Me.soredButton)
        Me.Controls.Add(Me.mordButton)
        Me.Controls.Add(Me.cus_database)
        Me.Controls.Add(Me.billNum)
        Me.Name = "CustomerOrderInformation"
        Me.Text = "Order Entry"
        CType(Me.cus_database, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDB1DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDB1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDERITEMSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDB1DataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cus_database As System.Windows.Forms.DataGridView
    Friend WithEvents mordButton As System.Windows.Forms.Button
    Friend WithEvents soredButton As System.Windows.Forms.Button
    Friend WithEvents billNum As System.Windows.Forms.Label
    Friend WithEvents findTextBox As System.Windows.Forms.TextBox
    Friend WithEvents newCus As System.Windows.Forms.Button
    Friend WithEvents ProjectDB1DataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProjectDB1DataSet As WindowsApplication1.ProjectDB1DataSet
    Friend WithEvents CUSTOMERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CUSTOMERTableAdapter As WindowsApplication1.ProjectDB1DataSetTableAdapters.CUSTOMERTableAdapter
    Friend WithEvents ORDERSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ORDERSTableAdapter As WindowsApplication1.ProjectDB1DataSetTableAdapters.ORDERSTableAdapter
    Friend WithEvents ORDERITEMSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ORDER_ITEMSTableAdapter As WindowsApplication1.ProjectDB1DataSetTableAdapters.ORDER_ITEMSTableAdapter
    Friend WithEvents ProjectDB1DataSetBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents delButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents refreshButton As System.Windows.Forms.Button

End Class
