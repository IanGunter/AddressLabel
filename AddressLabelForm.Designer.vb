<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddressLabelForm
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
        Me.FirstNameTextbox = New System.Windows.Forms.TextBox()
        Me.LastNameTextbox = New System.Windows.Forms.TextBox()
        Me.StreetAddressTextbox = New System.Windows.Forms.TextBox()
        Me.CityTextbox = New System.Windows.Forms.TextBox()
        Me.StateTextbox = New System.Windows.Forms.TextBox()
        Me.ZipCodeTextBox = New System.Windows.Forms.TextBox()
        Me.InputGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DisplayButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.OutputGroupBox = New System.Windows.Forms.GroupBox()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.InputGroupBox.SuspendLayout()
        Me.OutputGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'FirstNameTextbox
        '
        Me.FirstNameTextbox.Location = New System.Drawing.Point(40, 62)
        Me.FirstNameTextbox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.FirstNameTextbox.Name = "FirstNameTextbox"
        Me.FirstNameTextbox.Size = New System.Drawing.Size(532, 31)
        Me.FirstNameTextbox.TabIndex = 0
        '
        'LastNameTextbox
        '
        Me.LastNameTextbox.Location = New System.Drawing.Point(40, 156)
        Me.LastNameTextbox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.LastNameTextbox.Name = "LastNameTextbox"
        Me.LastNameTextbox.Size = New System.Drawing.Size(532, 31)
        Me.LastNameTextbox.TabIndex = 1
        '
        'StreetAddressTextbox
        '
        Me.StreetAddressTextbox.Location = New System.Drawing.Point(40, 246)
        Me.StreetAddressTextbox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.StreetAddressTextbox.Name = "StreetAddressTextbox"
        Me.StreetAddressTextbox.Size = New System.Drawing.Size(532, 31)
        Me.StreetAddressTextbox.TabIndex = 2
        '
        'CityTextbox
        '
        Me.CityTextbox.Location = New System.Drawing.Point(40, 344)
        Me.CityTextbox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.CityTextbox.Name = "CityTextbox"
        Me.CityTextbox.Size = New System.Drawing.Size(532, 31)
        Me.CityTextbox.TabIndex = 3
        '
        'StateTextbox
        '
        Me.StateTextbox.Location = New System.Drawing.Point(40, 438)
        Me.StateTextbox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.StateTextbox.Name = "StateTextbox"
        Me.StateTextbox.Size = New System.Drawing.Size(196, 31)
        Me.StateTextbox.TabIndex = 4
        '
        'ZipCodeTextBox
        '
        Me.ZipCodeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZipCodeTextBox.Location = New System.Drawing.Point(40, 537)
        Me.ZipCodeTextBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ZipCodeTextBox.Name = "ZipCodeTextBox"
        Me.ZipCodeTextBox.Size = New System.Drawing.Size(196, 32)
        Me.ZipCodeTextBox.TabIndex = 5
        '
        'InputGroupBox
        '
        Me.InputGroupBox.Controls.Add(Me.Label6)
        Me.InputGroupBox.Controls.Add(Me.Label5)
        Me.InputGroupBox.Controls.Add(Me.Label4)
        Me.InputGroupBox.Controls.Add(Me.Label3)
        Me.InputGroupBox.Controls.Add(Me.Label2)
        Me.InputGroupBox.Controls.Add(Me.Label1)
        Me.InputGroupBox.Controls.Add(Me.StreetAddressTextbox)
        Me.InputGroupBox.Controls.Add(Me.ZipCodeTextBox)
        Me.InputGroupBox.Controls.Add(Me.FirstNameTextbox)
        Me.InputGroupBox.Controls.Add(Me.StateTextbox)
        Me.InputGroupBox.Controls.Add(Me.LastNameTextbox)
        Me.InputGroupBox.Controls.Add(Me.CityTextbox)
        Me.InputGroupBox.Location = New System.Drawing.Point(46, 23)
        Me.InputGroupBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.InputGroupBox.Name = "InputGroupBox"
        Me.InputGroupBox.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.InputGroupBox.Size = New System.Drawing.Size(786, 596)
        Me.InputGroupBox.TabIndex = 6
        Me.InputGroupBox.TabStop = False
        Me.InputGroupBox.Text = "MailingAddress"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(34, 502)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(196, 31)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Zip Code"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(34, 404)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(196, 31)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "State"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(34, 313)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(196, 31)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "City"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(34, 215)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(196, 31)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Street Address"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(34, 119)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 31)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(34, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 31)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "First Name"
        '
        'DisplayButton
        '
        Me.DisplayButton.Location = New System.Drawing.Point(884, 504)
        Me.DisplayButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.DisplayButton.Name = "DisplayButton"
        Me.DisplayButton.Size = New System.Drawing.Size(204, 94)
        Me.DisplayButton.TabIndex = 7
        Me.DisplayButton.Text = "Display Label"
        Me.DisplayButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(1122, 504)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(194, 94)
        Me.ClearButton.TabIndex = 8
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(1358, 504)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(202, 94)
        Me.ExitButton.TabIndex = 9
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'OutputGroupBox
        '
        Me.OutputGroupBox.Controls.Add(Me.DisplayLabel)
        Me.OutputGroupBox.Location = New System.Drawing.Point(884, 25)
        Me.OutputGroupBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.OutputGroupBox.Name = "OutputGroupBox"
        Me.OutputGroupBox.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.OutputGroupBox.Size = New System.Drawing.Size(676, 433)
        Me.OutputGroupBox.TabIndex = 10
        Me.OutputGroupBox.TabStop = False
        Me.OutputGroupBox.Text = "Address Label"
        '
        'DisplayLabel
        '
        Me.DisplayLabel.Font = New System.Drawing.Font("Sitka Text", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayLabel.Location = New System.Drawing.Point(12, 31)
        Me.DisplayLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(652, 396)
        Me.DisplayLabel.TabIndex = 0
        '
        'AddressLabelForm
        '
        Me.AcceptButton = Me.DisplayButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CancelButton = Me.ClearButton
        Me.ClientSize = New System.Drawing.Size(1600, 650)
        Me.Controls.Add(Me.OutputGroupBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.DisplayButton)
        Me.Controls.Add(Me.InputGroupBox)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "AddressLabelForm"
        Me.Text = "AddressLabelVeiwer"
        Me.InputGroupBox.ResumeLayout(False)
        Me.InputGroupBox.PerformLayout()
        Me.OutputGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FirstNameTextbox As TextBox
    Friend WithEvents LastNameTextbox As TextBox
    Friend WithEvents StreetAddressTextbox As TextBox
    Friend WithEvents CityTextbox As TextBox
    Friend WithEvents StateTextbox As TextBox
    Friend WithEvents ZipCodeTextBox As TextBox
    Friend WithEvents InputGroupBox As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DisplayButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents OutputGroupBox As GroupBox
    Friend WithEvents DisplayLabel As Label
End Class
