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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NyX_Theme1 = New SMS_Sender_By_MONSTERMC.NYX_Theme()
        Me.NyX_ControlBox1 = New SMS_Sender_By_MONSTERMC.NYX_ControlBox()
        Me.CrystalClearTabControl1 = New SMS_Sender_By_MONSTERMC.CrystalClearTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SendSMSButton = New SMS_Sender_By_MONSTERMC.NYX_Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SmsMasseg = New SMS_Sender_By_MONSTERMC.CrystalClearTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PhoneNumber = New SMS_Sender_By_MONSTERMC.CrystalClearTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.NyX_Button1 = New SMS_Sender_By_MONSTERMC.NYX_Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSMS = New SMS_Sender_By_MONSTERMC.CrystalClearTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNumber = New SMS_Sender_By_MONSTERMC.CrystalClearTextBox()
        Me.btnConnect = New SMS_Sender_By_MONSTERMC.NYX_Button()
        Me.ComPort = New SMS_Sender_By_MONSTERMC.ThirteenComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.YoutubeButton = New SMS_Sender_By_MONSTERMC.NYX_Button()
        Me.BloggerButton = New SMS_Sender_By_MONSTERMC.NYX_Button()
        Me.DiscordButton = New SMS_Sender_By_MONSTERMC.NYX_Button()
        Me.TelegramButton = New SMS_Sender_By_MONSTERMC.NYX_Button()
        Me.NyX_Theme1.SuspendLayout()
        Me.CrystalClearTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'NyX_Theme1
        '
        Me.NyX_Theme1.Animated = True
        Me.NyX_Theme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.NyX_Theme1.Colors = New SMS_Sender_By_MONSTERMC.Bloom(-1) {}
        Me.NyX_Theme1.Controls.Add(Me.NyX_ControlBox1)
        Me.NyX_Theme1.Controls.Add(Me.CrystalClearTabControl1)
        Me.NyX_Theme1.Customization = ""
        Me.NyX_Theme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NyX_Theme1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.NyX_Theme1.Image = Nothing
        Me.NyX_Theme1.Location = New System.Drawing.Point(0, 0)
        Me.NyX_Theme1.Movable = True
        Me.NyX_Theme1.Name = "NyX_Theme1"
        Me.NyX_Theme1.NoRounding = False
        Me.NyX_Theme1.Sizable = True
        Me.NyX_Theme1.Size = New System.Drawing.Size(422, 359)
        Me.NyX_Theme1.SmartBounds = True
        Me.NyX_Theme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.NyX_Theme1.TabIndex = 0
        Me.NyX_Theme1.Text = "SMS Sender By MONSTERMC"
        Me.NyX_Theme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.NyX_Theme1.Transparent = False
        '
        'NyX_ControlBox1
        '
        Me.NyX_ControlBox1.Colors = New SMS_Sender_By_MONSTERMC.Bloom(-1) {}
        Me.NyX_ControlBox1.Customization = ""
        Me.NyX_ControlBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.NyX_ControlBox1.Image = Nothing
        Me.NyX_ControlBox1.Location = New System.Drawing.Point(370, 3)
        Me.NyX_ControlBox1.Name = "NyX_ControlBox1"
        Me.NyX_ControlBox1.NoRounding = False
        Me.NyX_ControlBox1.Size = New System.Drawing.Size(44, 20)
        Me.NyX_ControlBox1.TabIndex = 15
        Me.NyX_ControlBox1.Text = "NyX_ControlBox1"
        Me.NyX_ControlBox1.Transparent = False
        '
        'CrystalClearTabControl1
        '
        Me.CrystalClearTabControl1.Controls.Add(Me.TabPage1)
        Me.CrystalClearTabControl1.Controls.Add(Me.TabPage2)
        Me.CrystalClearTabControl1.Controls.Add(Me.TabPage3)
        Me.CrystalClearTabControl1.Location = New System.Drawing.Point(12, 31)
        Me.CrystalClearTabControl1.Name = "CrystalClearTabControl1"
        Me.CrystalClearTabControl1.SelectedIndex = 0
        Me.CrystalClearTabControl1.Size = New System.Drawing.Size(402, 325)
        Me.CrystalClearTabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.SendSMSButton)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.SmsMasseg)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.PhoneNumber)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(394, 296)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Free SMS"
        '
        'SendSMSButton
        '
        Me.SendSMSButton.Colors = New SMS_Sender_By_MONSTERMC.Bloom(-1) {}
        Me.SendSMSButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SendSMSButton.Customization = ""
        Me.SendSMSButton.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.SendSMSButton.Image = Nothing
        Me.SendSMSButton.Location = New System.Drawing.Point(147, 230)
        Me.SendSMSButton.Name = "SendSMSButton"
        Me.SendSMSButton.NoRounding = False
        Me.SendSMSButton.Size = New System.Drawing.Size(100, 25)
        Me.SendSMSButton.TabIndex = 5
        Me.SendSMSButton.Text = "Send"
        Me.SendSMSButton.Transparent = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(104, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 27)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "1 SMS Per Day!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(94, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Text To Send:"
        '
        'SmsMasseg
        '
        Me.SmsMasseg.Colors = New SMS_Sender_By_MONSTERMC.Bloom(-1) {}
        Me.SmsMasseg.Customization = ""
        Me.SmsMasseg.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SmsMasseg.Image = Nothing
        Me.SmsMasseg.Location = New System.Drawing.Point(97, 187)
        Me.SmsMasseg.MaxLength = 32767
        Me.SmsMasseg.Multiline = False
        Me.SmsMasseg.Name = "SmsMasseg"
        Me.SmsMasseg.NoRounding = False
        Me.SmsMasseg.ReadOnly = False
        Me.SmsMasseg.Size = New System.Drawing.Size(206, 24)
        Me.SmsMasseg.TabIndex = 2
        Me.SmsMasseg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SmsMasseg.Transparent = False
        Me.SmsMasseg.UseSystemPasswordChar = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(94, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Phone Number(ex. ""+1xxxxxxxxxx""):"
        '
        'PhoneNumber
        '
        Me.PhoneNumber.Colors = New SMS_Sender_By_MONSTERMC.Bloom(-1) {}
        Me.PhoneNumber.Customization = ""
        Me.PhoneNumber.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.PhoneNumber.Image = Nothing
        Me.PhoneNumber.Location = New System.Drawing.Point(97, 124)
        Me.PhoneNumber.MaxLength = 32767
        Me.PhoneNumber.Multiline = False
        Me.PhoneNumber.Name = "PhoneNumber"
        Me.PhoneNumber.NoRounding = False
        Me.PhoneNumber.ReadOnly = False
        Me.PhoneNumber.Size = New System.Drawing.Size(206, 24)
        Me.PhoneNumber.TabIndex = 0
        Me.PhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PhoneNumber.Transparent = False
        Me.PhoneNumber.UseSystemPasswordChar = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.NyX_Button1)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.txtSMS)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.lblStatus)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.txtNumber)
        Me.TabPage2.Controls.Add(Me.btnConnect)
        Me.TabPage2.Controls.Add(Me.ComPort)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(394, 296)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "SMS Via GSM Modem"
        '
        'NyX_Button1
        '
        Me.NyX_Button1.Colors = New SMS_Sender_By_MONSTERMC.Bloom(-1) {}
        Me.NyX_Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NyX_Button1.Customization = ""
        Me.NyX_Button1.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.NyX_Button1.Image = Nothing
        Me.NyX_Button1.Location = New System.Drawing.Point(188, 265)
        Me.NyX_Button1.Name = "NyX_Button1"
        Me.NyX_Button1.NoRounding = False
        Me.NyX_Button1.Size = New System.Drawing.Size(100, 25)
        Me.NyX_Button1.TabIndex = 14
        Me.NyX_Button1.Text = "SEND"
        Me.NyX_Button1.Transparent = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Gray
        Me.Label8.Location = New System.Drawing.Point(6, 219)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 15)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "MESSAGE"
        '
        'txtSMS
        '
        Me.txtSMS.Colors = New SMS_Sender_By_MONSTERMC.Bloom(-1) {}
        Me.txtSMS.Customization = ""
        Me.txtSMS.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txtSMS.Image = Nothing
        Me.txtSMS.Location = New System.Drawing.Point(122, 152)
        Me.txtSMS.MaxLength = 32767
        Me.txtSMS.Multiline = True
        Me.txtSMS.Name = "txtSMS"
        Me.txtSMS.NoRounding = False
        Me.txtSMS.ReadOnly = False
        Me.txtSMS.Size = New System.Drawing.Size(257, 110)
        Me.txtSMS.TabIndex = 12
        Me.txtSMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtSMS.Transparent = True
        Me.txtSMS.UseSystemPasswordChar = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(6, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "MOBILE NUMBER"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.ForeColor = System.Drawing.Color.IndianRed
        Me.lblStatus.Location = New System.Drawing.Point(122, 101)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(112, 15)
        Me.lblStatus.TabIndex = 10
        Me.lblStatus.Text = "NOT CONNECTED"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(6, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Text To Send:"
        '
        'txtNumber
        '
        Me.txtNumber.Colors = New SMS_Sender_By_MONSTERMC.Bloom(-1) {}
        Me.txtNumber.Customization = ""
        Me.txtNumber.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txtNumber.Image = Nothing
        Me.txtNumber.Location = New System.Drawing.Point(122, 122)
        Me.txtNumber.MaxLength = 32767
        Me.txtNumber.Multiline = False
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.NoRounding = False
        Me.txtNumber.ReadOnly = False
        Me.txtNumber.Size = New System.Drawing.Size(257, 24)
        Me.txtNumber.TabIndex = 8
        Me.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNumber.Transparent = True
        Me.txtNumber.UseSystemPasswordChar = False
        '
        'btnConnect
        '
        Me.btnConnect.Colors = New SMS_Sender_By_MONSTERMC.Bloom(-1) {}
        Me.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConnect.Customization = ""
        Me.btnConnect.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.btnConnect.Image = Nothing
        Me.btnConnect.Location = New System.Drawing.Point(279, 54)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.NoRounding = False
        Me.btnConnect.Size = New System.Drawing.Size(100, 25)
        Me.btnConnect.TabIndex = 7
        Me.btnConnect.Text = "CONNECT"
        Me.btnConnect.Transparent = False
        '
        'ComPort
        '
        Me.ComPort.AccentColor = System.Drawing.Color.DodgerBlue
        Me.ComPort.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ComPort.ColorScheme = SMS_Sender_By_MONSTERMC.ThirteenComboBox.ColorSchemes.Dark
        Me.ComPort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComPort.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.ComPort.ForeColor = System.Drawing.Color.White
        Me.ComPort.FormattingEnabled = True
        Me.ComPort.Location = New System.Drawing.Point(122, 53)
        Me.ComPort.Name = "ComPort"
        Me.ComPort.Size = New System.Drawing.Size(111, 26)
        Me.ComPort.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(129, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(250, 22)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Send SMS Via GSM Modem"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.YoutubeButton)
        Me.TabPage3.Controls.Add(Me.BloggerButton)
        Me.TabPage3.Controls.Add(Me.DiscordButton)
        Me.TabPage3.Controls.Add(Me.TelegramButton)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(394, 296)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "About"
        '
        'YoutubeButton
        '
        Me.YoutubeButton.Colors = New SMS_Sender_By_MONSTERMC.Bloom(-1) {}
        Me.YoutubeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.YoutubeButton.Customization = ""
        Me.YoutubeButton.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.YoutubeButton.Image = Nothing
        Me.YoutubeButton.Location = New System.Drawing.Point(23, 201)
        Me.YoutubeButton.Name = "YoutubeButton"
        Me.YoutubeButton.NoRounding = False
        Me.YoutubeButton.Size = New System.Drawing.Size(100, 25)
        Me.YoutubeButton.TabIndex = 11
        Me.YoutubeButton.Text = "Youtube"
        Me.YoutubeButton.Transparent = False
        '
        'BloggerButton
        '
        Me.BloggerButton.Colors = New SMS_Sender_By_MONSTERMC.Bloom(-1) {}
        Me.BloggerButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BloggerButton.Customization = ""
        Me.BloggerButton.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.BloggerButton.Image = Nothing
        Me.BloggerButton.Location = New System.Drawing.Point(264, 201)
        Me.BloggerButton.Name = "BloggerButton"
        Me.BloggerButton.NoRounding = False
        Me.BloggerButton.Size = New System.Drawing.Size(100, 25)
        Me.BloggerButton.TabIndex = 10
        Me.BloggerButton.Text = "Blogger"
        Me.BloggerButton.Transparent = False
        '
        'DiscordButton
        '
        Me.DiscordButton.Colors = New SMS_Sender_By_MONSTERMC.Bloom(-1) {}
        Me.DiscordButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DiscordButton.Customization = ""
        Me.DiscordButton.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.DiscordButton.Image = Nothing
        Me.DiscordButton.Location = New System.Drawing.Point(264, 112)
        Me.DiscordButton.Name = "DiscordButton"
        Me.DiscordButton.NoRounding = False
        Me.DiscordButton.Size = New System.Drawing.Size(100, 25)
        Me.DiscordButton.TabIndex = 9
        Me.DiscordButton.Text = "Discord"
        Me.DiscordButton.Transparent = False
        '
        'TelegramButton
        '
        Me.TelegramButton.Colors = New SMS_Sender_By_MONSTERMC.Bloom(-1) {}
        Me.TelegramButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TelegramButton.Customization = ""
        Me.TelegramButton.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.TelegramButton.Image = Nothing
        Me.TelegramButton.Location = New System.Drawing.Point(23, 112)
        Me.TelegramButton.Name = "TelegramButton"
        Me.TelegramButton.NoRounding = False
        Me.TelegramButton.Size = New System.Drawing.Size(100, 25)
        Me.TelegramButton.TabIndex = 8
        Me.TelegramButton.Text = "Telegram"
        Me.TelegramButton.Transparent = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 359)
        Me.Controls.Add(Me.NyX_Theme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SMS Sender By MONSTERMC"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.NyX_Theme1.ResumeLayout(False)
        Me.CrystalClearTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NyX_Theme1 As NYX_Theme
    Friend WithEvents CrystalClearTabControl1 As CrystalClearTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SmsMasseg As CrystalClearTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PhoneNumber As CrystalClearTextBox
    Friend WithEvents SendSMSButton As NYX_Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ComPort As ThirteenComboBox
    Friend WithEvents btnConnect As NYX_Button
    Friend WithEvents NyX_Button1 As NYX_Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSMS As CrystalClearTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNumber As CrystalClearTextBox
    Friend WithEvents NyX_ControlBox1 As NYX_ControlBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents YoutubeButton As NYX_Button
    Friend WithEvents BloggerButton As NYX_Button
    Friend WithEvents DiscordButton As NYX_Button
    Friend WithEvents TelegramButton As NYX_Button
End Class
