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
        Me.btnClick = New System.Windows.Forms.Button()
        Me.txtoutput = New System.Windows.Forms.TextBox()
        Me.lbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClick
        '
        Me.btnClick.Location = New System.Drawing.Point(107, 65)
        Me.btnClick.Name = "btnClick"
        Me.btnClick.Size = New System.Drawing.Size(109, 45)
        Me.btnClick.TabIndex = 0
        Me.btnClick.Text = "Click me"
        Me.btnClick.UseVisualStyleBackColor = True
        '
        'txtoutput
        '
        Me.txtoutput.Location = New System.Drawing.Point(107, 156)
        Me.txtoutput.Name = "txtoutput"
        Me.txtoutput.Size = New System.Drawing.Size(109, 20)
        Me.txtoutput.TabIndex = 1
        Me.txtoutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(141, 140)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(40, 13)
        Me.lbl.TabIndex = 2
        Me.lbl.Text = "OutPut"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 306)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.txtoutput)
        Me.Controls.Add(Me.btnClick)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClick As Button
    Friend WithEvents txtoutput As TextBox
    Friend WithEvents lbl As Label
End Class
