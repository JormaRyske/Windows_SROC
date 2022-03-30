Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel


Public Class SROC_Form
    '------------------------------------------------
    Dim myPort As Array
    Delegate Sub SetTextCallback(ByVal [text] As String) 'Added to prevent threading errors during receiveing of data
    '------------------------------------------------
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBox1.Items.AddRange(myPort)

        Button_Write.Enabled = False

    End Sub
    '------------------------------------------------
    Private Sub ComboBox1_Click(sender As System.Object, e As System.EventArgs) Handles ComboBox1.Click
    End Sub
    '------------------------------------------------
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonConnectArduino.Click
        SerialPort1.PortName = ComboBox1.Text
        SerialPort1.BaudRate = ComboBox2.Text
        SerialPort1.Open()
        ButtonConnectArduino.Enabled = False
        Button_Write.Enabled = True
        ButtonCloseConnection.Enabled = True

    End Sub
    '------------------------------------------------
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button_Write.Click

        SerialPort1.Write(RichTextBox1.Text & vbCr) 'concatenate with \n
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCloseConnection.Click
        SerialPort1.Close()
        ButtonConnectArduino.Enabled = True
        Button_Write.Enabled = False
        ButtonCloseConnection.Enabled = False
    End Sub

    Private Sub SerialPort1_DataReceived(sender As System.Object, e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        ReceivedText(SerialPort1.ReadExisting())
    End Sub

    Private Sub ReceivedText([text] As String) 'input from ReadExisting        
        If Me.RichTextBox2.InvokeRequired Then
            Dim x As New SetTextCallback(AddressOf ReceivedText)
            Me.Invoke(x, New Object() {(text)})
        Else
            Me.RichTextBox2.Text &= [text] 'append text
            ' set the current caret position to the end
            RichTextBox2.SelectionStart = RichTextBox2.Text.Length
            ' scroll it automatically
            RichTextBox2.ScrollToCaret()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonOpenRoof.Click
        SerialPort1.Write("ROOF_OPEN#" & vbCr) 'concatenate with \n
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub ButtonStopRoofMoving_Click(sender As Object, e As EventArgs) Handles ButtonStopRoofMoving.Click
        SerialPort1.Write("ROOF_STOP#" & vbCr) 'concatenate with \n
    End Sub

    Private Sub ButtonCloseRoof_Click(sender As Object, e As EventArgs) Handles ButtonCloseRoof.Click

        SerialPort1.Write("ROOF_CLOSE#" & vbCr) 'concatenate with \n
    End Sub

    Private Sub ButtonLightOn_Click(sender As Object, e As EventArgs) Handles ButtonLightOn.Click
        SerialPort1.Write("LIGHT_ON#" & vbCr) 'concatenate with \n
        ButtonLightOff.Enabled = True
        ButtonLightOn.Enabled = False
    End Sub

    Private Sub ButtonLightOff_Click(sender As Object, e As EventArgs) Handles ButtonLightOff.Click
        SerialPort1.Write("LIGHT_OFF#" & vbCr) 'concatenate with \n
        ButtonLightOff.Enabled = False
        ButtonLightOn.Enabled = True
    End Sub

    Private Sub ButtonTempHumRead_Click(sender As Object, e As EventArgs) Handles ButtonTempHumRead.Click
        SerialPort1.Write("TEMPHUM_READ#" & vbCr) 'concatenate with \n
    End Sub

    Private Sub ButtonIRLedOff_Click(sender As Object, e As EventArgs) Handles ButtonIRLedOff.Click
        SerialPort1.Write("IRLED_OFF#" & vbCr) 'concatenate with \n, Turns on red led, which turns off cameras IR light
        ButtonIRLedAuto.Enabled = True
        ButtonIRLedOff.Enabled = False
    End Sub

    Private Sub ButtonIRLedAuto_Click(sender As Object, e As EventArgs) Handles ButtonIRLedAuto.Click
        SerialPort1.Write("IRLED_AUTO#" & vbCr) 'concatenate with \n, Turns off red led, so cameras IR light works as normally/automatic
        ButtonIRLedAuto.Enabled = False
        ButtonIRLedOff.Enabled = True
    End Sub
End Class
