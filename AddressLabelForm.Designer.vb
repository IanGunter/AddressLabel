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
        Me.FirstNameTextbox.Location = New System.Drawing.Point(20, 32)
        Me.FirstNameTextbox.Name = "FirstNameTextbox"
        Me.FirstNameTextbox.Size = New System.Drawing.Size(268, 20)
        Me.FirstNameTextbox.TabIndex = 0
        '
        'LastNameTextbox
        '
        Me.LastNameTextbox.Location = New System.Drawing.Point(20, 81)
        Me.LastNameTextbox.Name = "LastNameTextbox"
        Me.LastNameTextbox.Size = New System.Drawing.Size(268, 20)
        Me.LastNameTextbox.TabIndex = 1
        '
        'StreetAddressTextbox
        '
        Me.StreetAddressTextbox.Location = New System.Drawing.Point(20, 128)
        Me.StreetAddressTextbox.Name = "StreetAddressTextbox"
        Me.StreetAddressTextbox.Size = New System.Drawing.Size(268, 20)
        Me.StreetAddressTextbox.TabIndex = 2
        '
        'CityTextbox
        '
        Me.CityTextbox.Location = New System.Drawing.Point(20, 179)
        Me.CityTextbox.Name = "CityTextbox"
        Me.CityTextbox.Size = New System.Drawing.Size(268, 20)
        Me.CityTextbox.TabIndex = 3
        '
        'StateTextbox
        '
        Me.StateTextbox.Location = New System.Drawing.Point(20, 228)
        Me.StateTextbox.Name = "StateTextbox"
        Me.StateTextbox.Size = New System.Drawing.Size(100, 20)
        Me.StateTextbox.TabIndex = 4
        '
        'ZipCodeTextBox
        '
        Me.ZipCodeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZipCodeTextBox.Location = New System.Drawing.Point(20, 279)
        Me.ZipCodeTextBox.Name = "ZipCodeTextBox"
        Me.ZipCodeTextBox.Size = New System.Drawing.Size(100, 20)
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
        Me.InputGroupBox.Location = New System.Drawing.Point(23, 12)
        Me.InputGroupBox.Name = "InputGroupBox"
        Me.InputGroupBox.Size = New System.Drawing.Size(393, 310)
        Me.InputGroupBox.TabIndex = 6
        Me.InputGroupBox.TabStop = False
        Me.InputGroupBox.Text = "MailingAddress"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(17, 261)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Zip Code"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(17, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "State"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(17, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "City"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(17, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Street Address"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(17, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(17, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "First Name"
        '
        'DisplayButton
        '
        Me.DisplayButton.Location = New System.Drawing.Point(442, 262)
        Me.DisplayButton.Name = "DisplayButton"
        Me.DisplayButton.Size = New System.Drawing.Size(102, 49)
        Me.DisplayButton.TabIndex = 7
        Me.DisplayButton.Text = "Display Label"
        Me.DisplayButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(561, 262)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(97, 49)
        Me.ClearButton.TabIndex = 8
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(679, 262)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(101, 49)
        Me.ExitButton.TabIndex = 9
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'OutputGroupBox
        '
        Me.OutputGroupBox.Controls.Add(Me.DisplayLabel)
        Me.OutputGroupBox.Location = New System.Drawing.Point(442, 13)
        Me.OutputGroupBox.Name = "OutputGroupBox"
        Me.OutputGroupBox.Size = New System.Drawing.Size(338, 225)
        Me.OutputGroupBox.TabIndex = 10
        Me.OutputGroupBox.TabStop = False
        Me.OutputGroupBox.Text = "Address Label"
        '
        'DisplayLabel
        '
        Me.DisplayLabel.Font = New System.Drawing.Font("Sitka Text", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayLabel.Location = New System.Drawing.Point(6, 16)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(326, 206)
        Me.DisplayLabel.TabIndex = 0
        '
        'AddressLabelForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 338)
        Me.Controls.Add(Me.OutputGroupBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.DisplayButton)
        Me.Controls.Add(Me.InputGroupBox)
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
