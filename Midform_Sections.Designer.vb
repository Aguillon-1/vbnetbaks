<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Midform_Sections
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.SectionFormat1 = New CMS_Frontend.sectionFormat()
        Me.SuspendLayout()
        '
        'SectionFormat1
        '
        Me.SectionFormat1.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.SectionFormat1.Location = New System.Drawing.Point(15, 16)
        Me.SectionFormat1.Name = "SectionFormat1"
        Me.SectionFormat1.Size = New System.Drawing.Size(359, 126)
        Me.SectionFormat1.TabIndex = 0
        '
        'Midform_Sections
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SectionFormat1)
        Me.Name = "Midform_Sections"
        Me.Size = New System.Drawing.Size(1530, 778)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SectionFormat1 As sectionFormat
End Class
