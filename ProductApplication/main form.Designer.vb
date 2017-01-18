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
        Me.CLick_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CLick_btn
        '
        Me.CLick_btn.Location = New System.Drawing.Point(141, 73)
        Me.CLick_btn.Name = "CLick_btn"
        Me.CLick_btn.Size = New System.Drawing.Size(302, 97)
        Me.CLick_btn.TabIndex = 0
        Me.CLick_btn.Text = "Click"
        Me.CLick_btn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 261)
        Me.Controls.Add(Me.CLick_btn)
        Me.Name = "Form1"
        Me.Text = "Main Window"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CLick_btn As Button
End Class
