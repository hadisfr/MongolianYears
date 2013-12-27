<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmy
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtyear = New System.Windows.Forms.TextBox
        Me.Enter = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lbln = New System.Windows.Forms.Label
        Me.pic = New System.Windows.Forms.PictureBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.mnuabout = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuend = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtyear)
        Me.GroupBox1.Controls.Add(Me.Enter)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 66)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "سال"
        '
        'txtyear
        '
        Me.txtyear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtyear.Location = New System.Drawing.Point(87, 22)
        Me.txtyear.Name = "txtyear"
        Me.txtyear.Size = New System.Drawing.Size(167, 20)
        Me.txtyear.TabIndex = 1
        Me.txtyear.Text = "1"
        '
        'Enter
        '
        Me.Enter.Location = New System.Drawing.Point(6, 19)
        Me.Enter.Name = "Enter"
        Me.Enter.Size = New System.Drawing.Size(75, 23)
        Me.Enter.TabIndex = 2
        Me.Enter.Text = "تأیید"
        Me.Enter.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.pic)
        Me.GroupBox2.Controls.Add(Me.lbln)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 97)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(260, 168)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "اطلاعات"
        '
        'lbln
        '
        Me.lbln.AutoSize = True
        Me.lbln.Font = New System.Drawing.Font("B Nazanin", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbln.Location = New System.Drawing.Point(198, 71)
        Me.lbln.Name = "lbln"
        Me.lbln.Size = New System.Drawing.Size(0, 30)
        Me.lbln.TabIndex = 2
        '
        'pic
        '
        Me.pic.Location = New System.Drawing.Point(6, 19)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(133, 143)
        Me.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic.TabIndex = 3
        Me.pic.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuabout, Me.mnuend})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuabout
        '
        Me.mnuabout.Name = "mnuabout"
        Me.mnuabout.Size = New System.Drawing.Size(108, 20)
        Me.mnuabout.Text = "درباره سال شمار..."
        '
        'mnuend
        '
        Me.mnuend.Name = "mnuend"
        Me.mnuend.Size = New System.Drawing.Size(44, 20)
        Me.mnuend.Text = "خروج"
        '
        'frmmy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 277)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmmy"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "سال شماری ختا و اویغور (مغولی)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtyear As System.Windows.Forms.TextBox
    Friend WithEvents Enter As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbln As System.Windows.Forms.Label
    Friend WithEvents pic As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuabout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuend As System.Windows.Forms.ToolStripMenuItem

End Class
