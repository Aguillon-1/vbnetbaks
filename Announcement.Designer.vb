<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Announcement
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.AnnouncementFormat1 = New CMS_Frontend.AnnouncementFormat()
        Me.SuspendLayout()
        '
        'AnnouncementFormat1
        '
        Me.AnnouncementFormat1.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.AnnouncementFormat1.Location = New System.Drawing.Point(31, 27)
        Me.AnnouncementFormat1.Name = "AnnouncementFormat1"
        Me.AnnouncementFormat1.Size = New System.Drawing.Size(1245, 159)
        Me.AnnouncementFormat1.TabIndex = 0
        '
        'Announcement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.AnnouncementFormat1)
        Me.MaximumSize = New System.Drawing.Size(1313, 778)
        Me.MinimumSize = New System.Drawing.Size(1313, 778)
        Me.Name = "Announcement"
        Me.Size = New System.Drawing.Size(1313, 778)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AnnouncementFormat1 As AnnouncementFormat
End Class
