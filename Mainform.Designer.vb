<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainform
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.calendarButton = New System.Windows.Forms.Button()
        Me.announcementButton = New System.Windows.Forms.Button()
        Me.notesButton = New System.Windows.Forms.Button()
        Me.uploadButton = New System.Windows.Forms.Button()
        Me.helpButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.sectionButton = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Section1 = New CMS_Frontend.Section()
        Me.Help1 = New CMS_Frontend.Help()
        Me.Upload1 = New CMS_Frontend.Upload()
        Me.Notes1 = New CMS_Frontend.Notes()
        Me.Announcement1 = New CMS_Frontend.Announcement()
        Me.Calendar1 = New CMS_Frontend.Calendar()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel3)
        Me.FlowLayoutPanel1.Controls.Add(Me.calendarButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.announcementButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.notesButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.uploadButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.helpButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.exitButton)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(219, 864)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(216, 102)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(85, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CMS"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.CMS_Frontend.My.Resources.Resources.UCC_removebg_preview
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Location = New System.Drawing.Point(3, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(71, 83)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.CMS_Frontend.My.Resources.Resources.UCC_CSD_removebg_preview
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(141, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 83)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Location = New System.Drawing.Point(0, 102)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(219, 9)
        Me.Panel3.TabIndex = 4
        '
        'calendarButton
        '
        Me.calendarButton.FlatAppearance.BorderSize = 0
        Me.calendarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calendarButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.calendarButton.Location = New System.Drawing.Point(0, 111)
        Me.calendarButton.Margin = New System.Windows.Forms.Padding(0)
        Me.calendarButton.Name = "calendarButton"
        Me.calendarButton.Size = New System.Drawing.Size(213, 42)
        Me.calendarButton.TabIndex = 5
        Me.calendarButton.Text = "Calendar"
        Me.calendarButton.UseVisualStyleBackColor = True
        '
        'announcementButton
        '
        Me.announcementButton.FlatAppearance.BorderSize = 0
        Me.announcementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.announcementButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.announcementButton.Location = New System.Drawing.Point(0, 153)
        Me.announcementButton.Margin = New System.Windows.Forms.Padding(0)
        Me.announcementButton.Name = "announcementButton"
        Me.announcementButton.Size = New System.Drawing.Size(213, 42)
        Me.announcementButton.TabIndex = 6
        Me.announcementButton.Text = "Announcement"
        Me.announcementButton.UseVisualStyleBackColor = True
        '
        'notesButton
        '
        Me.notesButton.FlatAppearance.BorderSize = 0
        Me.notesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.notesButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.notesButton.Location = New System.Drawing.Point(0, 195)
        Me.notesButton.Margin = New System.Windows.Forms.Padding(0)
        Me.notesButton.Name = "notesButton"
        Me.notesButton.Size = New System.Drawing.Size(213, 42)
        Me.notesButton.TabIndex = 7
        Me.notesButton.Text = "Notes"
        Me.notesButton.UseVisualStyleBackColor = True
        '
        'uploadButton
        '
        Me.uploadButton.FlatAppearance.BorderSize = 0
        Me.uploadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.uploadButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.uploadButton.Location = New System.Drawing.Point(0, 237)
        Me.uploadButton.Margin = New System.Windows.Forms.Padding(0)
        Me.uploadButton.Name = "uploadButton"
        Me.uploadButton.Size = New System.Drawing.Size(213, 42)
        Me.uploadButton.TabIndex = 8
        Me.uploadButton.Text = "Upload"
        Me.uploadButton.UseVisualStyleBackColor = True
        '
        'helpButton
        '
        Me.helpButton.FlatAppearance.BorderSize = 0
        Me.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.helpButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.helpButton.Location = New System.Drawing.Point(0, 279)
        Me.helpButton.Margin = New System.Windows.Forms.Padding(0)
        Me.helpButton.Name = "helpButton"
        Me.helpButton.Size = New System.Drawing.Size(213, 42)
        Me.helpButton.TabIndex = 9
        Me.helpButton.Text = "Help"
        Me.helpButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.FlatAppearance.BorderSize = 0
        Me.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.exitButton.Location = New System.Drawing.Point(0, 321)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(0)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(213, 42)
        Me.exitButton.TabIndex = 10
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel2.Controls.Add(Me.sectionButton)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(219, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1317, 81)
        Me.Panel2.TabIndex = 3
        '
        'sectionButton
        '
        Me.sectionButton.FlatAppearance.BorderSize = 0
        Me.sectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sectionButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sectionButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.sectionButton.Location = New System.Drawing.Point(521, 3)
        Me.sectionButton.Name = "sectionButton"
        Me.sectionButton.Size = New System.Drawing.Size(156, 75)
        Me.sectionButton.TabIndex = 6
        Me.sectionButton.Text = "BSCS 2B"
        Me.sectionButton.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.CMS_Frontend.My.Resources.Resources.Ellipse_1
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Location = New System.Drawing.Point(1103, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(62, 84)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(1168, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Last Name, First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 16)
        Me.Label3.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.CMS_Frontend.My.Resources.Resources.Ringing_Bell_Notification
        Me.Button2.Location = New System.Drawing.Point(1010, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 75)
        Me.Button2.TabIndex = 3
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.CMS_Frontend.My.Resources.Resources.Home_2
        Me.Button1.Location = New System.Drawing.Point(916, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 75)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Section1)
        Me.Panel4.Controls.Add(Me.Help1)
        Me.Panel4.Controls.Add(Me.Upload1)
        Me.Panel4.Controls.Add(Me.Notes1)
        Me.Panel4.Controls.Add(Me.Announcement1)
        Me.Panel4.Controls.Add(Me.Calendar1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(219, 81)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1317, 783)
        Me.Panel4.TabIndex = 4
        '
        'Section1
        '
        Me.Section1.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Section1.Location = New System.Drawing.Point(1, 0)
        Me.Section1.MaximumSize = New System.Drawing.Size(1313, 778)
        Me.Section1.MinimumSize = New System.Drawing.Size(1313, 778)
        Me.Section1.Name = "Section1"
        Me.Section1.Size = New System.Drawing.Size(1313, 778)
        Me.Section1.TabIndex = 0
        '
        'Help1
        '
        Me.Help1.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Help1.Location = New System.Drawing.Point(-1, 0)
        Me.Help1.MaximumSize = New System.Drawing.Size(1313, 778)
        Me.Help1.MinimumSize = New System.Drawing.Size(1313, 778)
        Me.Help1.Name = "Help1"
        Me.Help1.Size = New System.Drawing.Size(1313, 778)
        Me.Help1.TabIndex = 5
        '
        'Upload1
        '
        Me.Upload1.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Upload1.Location = New System.Drawing.Point(-1, 0)
        Me.Upload1.MaximumSize = New System.Drawing.Size(1313, 778)
        Me.Upload1.MinimumSize = New System.Drawing.Size(1313, 778)
        Me.Upload1.Name = "Upload1"
        Me.Upload1.Size = New System.Drawing.Size(1313, 778)
        Me.Upload1.TabIndex = 4
        '
        'Notes1
        '
        Me.Notes1.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Notes1.Location = New System.Drawing.Point(0, 0)
        Me.Notes1.MaximumSize = New System.Drawing.Size(1313, 778)
        Me.Notes1.MinimumSize = New System.Drawing.Size(1313, 778)
        Me.Notes1.Name = "Notes1"
        Me.Notes1.Size = New System.Drawing.Size(1313, 778)
        Me.Notes1.TabIndex = 3
        '
        'Announcement1
        '
        Me.Announcement1.Location = New System.Drawing.Point(1, 0)
        Me.Announcement1.MaximumSize = New System.Drawing.Size(1313, 778)
        Me.Announcement1.MinimumSize = New System.Drawing.Size(1313, 778)
        Me.Announcement1.Name = "Announcement1"
        Me.Announcement1.Size = New System.Drawing.Size(1313, 778)
        Me.Announcement1.TabIndex = 2
        '
        'Calendar1
        '
        Me.Calendar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Calendar1.Location = New System.Drawing.Point(7, 4)
        Me.Calendar1.MaximumSize = New System.Drawing.Size(1313, 778)
        Me.Calendar1.MinimumSize = New System.Drawing.Size(1313, 778)
        Me.Calendar1.Name = "Calendar1"
        Me.Calendar1.Size = New System.Drawing.Size(1313, 778)
        Me.Calendar1.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(219, 9)
        Me.Panel5.TabIndex = 5
        '
        'Mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1536, 864)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1536, 864)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1536, 864)
        Me.Name = "Mainform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents calendarButton As Button
    Friend WithEvents announcementButton As Button
    Friend WithEvents notesButton As Button
    Friend WithEvents uploadButton As Button
    Friend WithEvents helpButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents exitButton As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Section1 As Section
    Friend WithEvents Help1 As Help
    Friend WithEvents Upload1 As Upload
    Friend WithEvents Notes1 As Notes
    Friend WithEvents Announcement1 As Announcement
    Friend WithEvents Calendar1 As Calendar
    Friend WithEvents sectionButton As Button
    Friend WithEvents Panel5 As Panel
End Class
