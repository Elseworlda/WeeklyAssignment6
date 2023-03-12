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
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.btnEnterSpeeds = New System.Windows.Forms.Button()
        Me.lstSpeeds = New System.Windows.Forms.ListBox()
        Me.lblAverageSpeed = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(265, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(384, 32)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Internet Speed Test Survey"
        '
        'btnEnterSpeeds
        '
        Me.btnEnterSpeeds.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnEnterSpeeds.Location = New System.Drawing.Point(371, 63)
        Me.btnEnterSpeeds.Name = "btnEnterSpeeds"
        Me.btnEnterSpeeds.Size = New System.Drawing.Size(201, 45)
        Me.btnEnterSpeeds.TabIndex = 2
        Me.btnEnterSpeeds.Text = "Enter Internet Speed"
        Me.btnEnterSpeeds.UseVisualStyleBackColor = False
        '
        'lstSpeeds
        '
        Me.lstSpeeds.FormattingEnabled = True
        Me.lstSpeeds.ItemHeight = 16
        Me.lstSpeeds.Location = New System.Drawing.Point(658, 67)
        Me.lstSpeeds.Name = "lstSpeeds"
        Me.lstSpeeds.Size = New System.Drawing.Size(116, 196)
        Me.lstSpeeds.TabIndex = 3
        '
        'lblAverageSpeed
        '
        Me.lblAverageSpeed.AutoSize = True
        Me.lblAverageSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageSpeed.Location = New System.Drawing.Point(391, 406)
        Me.lblAverageSpeed.Name = "lblAverageSpeed"
        Me.lblAverageSpeed.Size = New System.Drawing.Size(205, 20)
        Me.lblAverageSpeed.TabIndex = 4
        Me.lblAverageSpeed.Text = "Average Internet Speed"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(560, 340)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(98, 24)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblAverageSpeed)
        Me.Controls.Add(Me.lstSpeeds)
        Me.Controls.Add(Me.btnEnterSpeeds)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeader As Label
    Friend WithEvents btnEnterSpeeds As Button
    Friend WithEvents lstSpeeds As ListBox
    Friend WithEvents lblAverageSpeed As Label
    Friend WithEvents btnClear As Button
End Class
