<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sobre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sobre))
        Me.FlowLayoutPanel10 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel12 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel11 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel9 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel8 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel11.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel10
        '
        Me.FlowLayoutPanel10.BackColor = System.Drawing.Color.RoyalBlue
        Me.FlowLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.FlowLayoutPanel10.Location = New System.Drawing.Point(575, 0)
        Me.FlowLayoutPanel10.Name = "FlowLayoutPanel10"
        Me.FlowLayoutPanel10.Size = New System.Drawing.Size(3, 358)
        Me.FlowLayoutPanel10.TabIndex = 10
        '
        'FlowLayoutPanel12
        '
        Me.FlowLayoutPanel12.BackColor = System.Drawing.Color.RoyalBlue
        Me.FlowLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel12.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel12.Name = "FlowLayoutPanel12"
        Me.FlowLayoutPanel12.Size = New System.Drawing.Size(575, 3)
        Me.FlowLayoutPanel12.TabIndex = 12
        '
        'FlowLayoutPanel11
        '
        Me.FlowLayoutPanel11.BackColor = System.Drawing.Color.RoyalBlue
        Me.FlowLayoutPanel11.Controls.Add(Me.FlowLayoutPanel9)
        Me.FlowLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel11.Location = New System.Drawing.Point(0, 3)
        Me.FlowLayoutPanel11.Name = "FlowLayoutPanel11"
        Me.FlowLayoutPanel11.Size = New System.Drawing.Size(3, 355)
        Me.FlowLayoutPanel11.TabIndex = 13
        '
        'FlowLayoutPanel9
        '
        Me.FlowLayoutPanel9.BackColor = System.Drawing.Color.RoyalBlue
        Me.FlowLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel9.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel9.Name = "FlowLayoutPanel9"
        Me.FlowLayoutPanel9.Size = New System.Drawing.Size(1073, 3)
        Me.FlowLayoutPanel9.TabIndex = 9
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 355)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(572, 3)
        Me.FlowLayoutPanel1.TabIndex = 14
        '
        'FlowLayoutPanel8
        '
        Me.FlowLayoutPanel8.BackColor = System.Drawing.Color.RoyalBlue
        Me.FlowLayoutPanel8.Location = New System.Drawing.Point(3, 30)
        Me.FlowLayoutPanel8.Name = "FlowLayoutPanel8"
        Me.FlowLayoutPanel8.Size = New System.Drawing.Size(578, 3)
        Me.FlowLayoutPanel8.TabIndex = 15
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Biblioteca_EFBD.My.Resources.Resources.bt_close1
        Me.PictureBox1.Location = New System.Drawing.Point(523, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 15)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Biblioteca EFBD - Sobre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(352, 60)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'sobre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Biblioteca_EFBD.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(578, 358)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.FlowLayoutPanel8)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.FlowLayoutPanel11)
        Me.Controls.Add(Me.FlowLayoutPanel12)
        Me.Controls.Add(Me.FlowLayoutPanel10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "sobre"
        Me.Text = "sobre"
        Me.FlowLayoutPanel11.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlowLayoutPanel10 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel12 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel11 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel9 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel8 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
