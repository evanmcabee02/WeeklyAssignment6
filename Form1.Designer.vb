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
        Me.lblSurvey = New System.Windows.Forms.Label()
        Me.lstSpeed = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSpeed = New System.Windows.Forms.Button()
        Me.lblAverageSpeed = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblSurvey
        '
        Me.lblSurvey.AutoSize = True
        Me.lblSurvey.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSurvey.Font = New System.Drawing.Font("Segoe UI Black", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurvey.Location = New System.Drawing.Point(387, 30)
        Me.lblSurvey.Name = "lblSurvey"
        Me.lblSurvey.Size = New System.Drawing.Size(443, 45)
        Me.lblSurvey.TabIndex = 1
        Me.lblSurvey.Text = "Internet Speed Test Survey"
        '
        'lstSpeed
        '
        Me.lstSpeed.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSpeed.FormattingEnabled = True
        Me.lstSpeed.ItemHeight = 38
        Me.lstSpeed.Location = New System.Drawing.Point(856, 89)
        Me.lstSpeed.Name = "lstSpeed"
        Me.lstSpeed.Size = New System.Drawing.Size(120, 232)
        Me.lstSpeed.TabIndex = 2
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(693, 437)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(117, 35)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSpeed
        '
        Me.btnSpeed.BackColor = System.Drawing.Color.BurlyWood
        Me.btnSpeed.Font = New System.Drawing.Font("Segoe UI Black", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpeed.Location = New System.Drawing.Point(453, 103)
        Me.btnSpeed.Name = "btnSpeed"
        Me.btnSpeed.Size = New System.Drawing.Size(291, 51)
        Me.btnSpeed.TabIndex = 4
        Me.btnSpeed.Text = "Enter Internet Speed"
        Me.btnSpeed.UseVisualStyleBackColor = False
        '
        'lblAverageSpeed
        '
        Me.lblAverageSpeed.AutoSize = True
        Me.lblAverageSpeed.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAverageSpeed.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageSpeed.Location = New System.Drawing.Point(475, 528)
        Me.lblAverageSpeed.Name = "lblAverageSpeed"
        Me.lblAverageSpeed.Size = New System.Drawing.Size(282, 32)
        Me.lblAverageSpeed.TabIndex = 5
        Me.lblAverageSpeed.Text = "XXXXXXXXXXXX 0000"
        Me.lblAverageSpeed.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WeeklyAssignment6.My.Resources.Resources.speed
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1007, 569)
        Me.Controls.Add(Me.lblAverageSpeed)
        Me.Controls.Add(Me.btnSpeed)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lstSpeed)
        Me.Controls.Add(Me.lblSurvey)
        Me.Name = "Form1"
        Me.Text = "Internet Speed Test Survey for Home Users"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSurvey As Label
    Friend WithEvents lstSpeed As ListBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSpeed As Button
    Friend WithEvents lblAverageSpeed As Label
End Class
