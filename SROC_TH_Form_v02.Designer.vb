<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SROC_Form
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
        Me.ButtonConnectArduino = New System.Windows.Forms.Button()
        Me.Button_Write = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonCloseConnection = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ButtonOpenRoof = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonStopRoofMoving = New System.Windows.Forms.Button()
        Me.ButtonCloseRoof = New System.Windows.Forms.Button()
        Me.ButtonLightOn = New System.Windows.Forms.Button()
        Me.ButtonLightOff = New System.Windows.Forms.Button()
        Me.ButtonTempHumRead = New System.Windows.Forms.Button()
        Me.ButtonIRLedOff = New System.Windows.Forms.Button()
        Me.ButtonIRLedAuto = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonConnectArduino
        '
        Me.ButtonConnectArduino.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonConnectArduino.Location = New System.Drawing.Point(37, 155)
        Me.ButtonConnectArduino.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonConnectArduino.Name = "ButtonConnectArduino"
        Me.ButtonConnectArduino.Size = New System.Drawing.Size(114, 70)
        Me.ButtonConnectArduino.TabIndex = 0
        Me.ButtonConnectArduino.Text = "Connect Arduino Controller"
        Me.ButtonConnectArduino.UseVisualStyleBackColor = True
        '
        'Button_Write
        '
        Me.Button_Write.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button_Write.Location = New System.Drawing.Point(1070, 75)
        Me.Button_Write.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_Write.Name = "Button_Write"
        Me.Button_Write.Size = New System.Drawing.Size(123, 93)
        Me.Button_Write.TabIndex = 1
        Me.Button_Write.Text = "Send special command"
        Me.Button_Write.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 46)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(160, 33)
        Me.ComboBox1.TabIndex = 3
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RichTextBox1.Location = New System.Drawing.Point(836, 75)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(226, 93)
        Me.RichTextBox1.TabIndex = 4
        Me.RichTextBox1.Text = ""
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RichTextBox2.Location = New System.Drawing.Point(836, 229)
        Me.RichTextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(357, 198)
        Me.RichTextBox2.TabIndex = 5
        Me.RichTextBox2.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(831, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Special command to Arduino"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(831, 200)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(261, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Received msgs from Arduino"
        '
        'ButtonCloseConnection
        '
        Me.ButtonCloseConnection.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonCloseConnection.Location = New System.Drawing.Point(37, 247)
        Me.ButtonCloseConnection.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonCloseConnection.Name = "ButtonCloseConnection"
        Me.ButtonCloseConnection.Size = New System.Drawing.Size(114, 71)
        Me.ButtonCloseConnection.TabIndex = 8
        Me.ButtonCloseConnection.Text = "Close connection"
        Me.ButtonCloseConnection.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM6"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"9600", "38400", "57600", "115200"})
        Me.ComboBox2.Location = New System.Drawing.Point(12, 114)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(160, 33)
        Me.ComboBox2.TabIndex = 9
        '
        'ButtonOpenRoof
        '
        Me.ButtonOpenRoof.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonOpenRoof.Location = New System.Drawing.Point(345, 25)
        Me.ButtonOpenRoof.Name = "ButtonOpenRoof"
        Me.ButtonOpenRoof.Size = New System.Drawing.Size(186, 88)
        Me.ButtonOpenRoof.TabIndex = 10
        Me.ButtonOpenRoof.Text = "OPEN ROOF"
        Me.ButtonOpenRoof.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Arduino Com port"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Port speed"
        '
        'ButtonStopRoofMoving
        '
        Me.ButtonStopRoofMoving.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonStopRoofMoving.Location = New System.Drawing.Point(345, 164)
        Me.ButtonStopRoofMoving.Name = "ButtonStopRoofMoving"
        Me.ButtonStopRoofMoving.Size = New System.Drawing.Size(186, 88)
        Me.ButtonStopRoofMoving.TabIndex = 13
        Me.ButtonStopRoofMoving.Text = "STOP ROOF MOVING"
        Me.ButtonStopRoofMoving.UseVisualStyleBackColor = True
        '
        'ButtonCloseRoof
        '
        Me.ButtonCloseRoof.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonCloseRoof.Location = New System.Drawing.Point(345, 299)
        Me.ButtonCloseRoof.Name = "ButtonCloseRoof"
        Me.ButtonCloseRoof.Size = New System.Drawing.Size(186, 88)
        Me.ButtonCloseRoof.TabIndex = 14
        Me.ButtonCloseRoof.Text = "CLOSE ROOF"
        Me.ButtonCloseRoof.UseVisualStyleBackColor = True
        '
        'ButtonLightOn
        '
        Me.ButtonLightOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonLightOn.Location = New System.Drawing.Point(584, 25)
        Me.ButtonLightOn.Name = "ButtonLightOn"
        Me.ButtonLightOn.Size = New System.Drawing.Size(186, 46)
        Me.ButtonLightOn.TabIndex = 15
        Me.ButtonLightOn.Text = "Light ON"
        Me.ButtonLightOn.UseVisualStyleBackColor = True
        '
        'ButtonLightOff
        '
        Me.ButtonLightOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonLightOff.Location = New System.Drawing.Point(584, 77)
        Me.ButtonLightOff.Name = "ButtonLightOff"
        Me.ButtonLightOff.Size = New System.Drawing.Size(186, 46)
        Me.ButtonLightOff.TabIndex = 16
        Me.ButtonLightOff.Text = "Light OFF"
        Me.ButtonLightOff.UseVisualStyleBackColor = True
        '
        'ButtonTempHumRead
        '
        Me.ButtonTempHumRead.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonTempHumRead.Location = New System.Drawing.Point(584, 164)
        Me.ButtonTempHumRead.Name = "ButtonTempHumRead"
        Me.ButtonTempHumRead.Size = New System.Drawing.Size(186, 46)
        Me.ButtonTempHumRead.TabIndex = 17
        Me.ButtonTempHumRead.Text = "Temp C Hum %"
        Me.ButtonTempHumRead.UseVisualStyleBackColor = True
        '
        'ButtonIRLedOff
        '
        Me.ButtonIRLedOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonIRLedOff.Location = New System.Drawing.Point(584, 247)
        Me.ButtonIRLedOff.Name = "ButtonIRLedOff"
        Me.ButtonIRLedOff.Size = New System.Drawing.Size(186, 69)
        Me.ButtonIRLedOff.TabIndex = 18
        Me.ButtonIRLedOff.Text = "IR Led Off (RedLedOn)"
        Me.ButtonIRLedOff.UseVisualStyleBackColor = True
        '
        'ButtonIRLedAuto
        '
        Me.ButtonIRLedAuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonIRLedAuto.Location = New System.Drawing.Point(584, 322)
        Me.ButtonIRLedAuto.Name = "ButtonIRLedAuto"
        Me.ButtonIRLedAuto.Size = New System.Drawing.Size(186, 71)
        Me.ButtonIRLedAuto.TabIndex = 19
        Me.ButtonIRLedAuto.Text = "IR Led Auto (RedLedOff)"
        Me.ButtonIRLedAuto.UseVisualStyleBackColor = True
        '
        'SROC_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1228, 482)
        Me.Controls.Add(Me.ButtonIRLedAuto)
        Me.Controls.Add(Me.ButtonIRLedOff)
        Me.Controls.Add(Me.ButtonTempHumRead)
        Me.Controls.Add(Me.ButtonLightOff)
        Me.Controls.Add(Me.ButtonLightOn)
        Me.Controls.Add(Me.ButtonCloseRoof)
        Me.Controls.Add(Me.ButtonStopRoofMoving)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonOpenRoof)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ButtonCloseConnection)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button_Write)
        Me.Controls.Add(Me.ButtonConnectArduino)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SROC_Form"
        Me.Text = "SROC Sliding Roof Observatory Controller v0.2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonConnectArduino As System.Windows.Forms.Button
    Friend WithEvents Button_Write As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonCloseConnection As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonOpenRoof As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonStopRoofMoving As Button
    Friend WithEvents ButtonCloseRoof As Button
    Friend WithEvents ButtonLightOn As Button
    Friend WithEvents ButtonLightOff As Button
    Friend WithEvents ButtonTempHumRead As Button
    Friend WithEvents ButtonIRLedOff As Button
    Friend WithEvents ButtonIRLedAuto As Button
End Class
