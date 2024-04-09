<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        cb_month = New ComboBox()
        lbl_selected_month_savings = New Label()
        btn_display_stats = New Button()
        lbl_average_savings = New Label()
        lbl_largest_savings = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.smarthome
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(374, 264)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(438, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(292, 100)
        Label1.TabIndex = 1
        Label1.Text = "Smart Home" & vbCrLf & "Electric Savings"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' cb_month
        ' 
        cb_month.FormattingEnabled = True
        cb_month.Location = New Point(525, 166)
        cb_month.Name = "cb_month"
        cb_month.Size = New Size(121, 23)
        cb_month.TabIndex = 2
        ' 
        ' lbl_selected_month_savings
        ' 
        lbl_selected_month_savings.AutoSize = True
        lbl_selected_month_savings.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_selected_month_savings.Location = New Point(282, 314)
        lbl_selected_month_savings.Name = "lbl_selected_month_savings"
        lbl_selected_month_savings.Size = New Size(271, 30)
        lbl_selected_month_savings.TabIndex = 3
        lbl_selected_month_savings.Text = "The electric savings for  is:"
        lbl_selected_month_savings.TextAlign = ContentAlignment.MiddleCenter
        lbl_selected_month_savings.Visible = False
        ' 
        ' btn_display_stats
        ' 
        btn_display_stats.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btn_display_stats.Location = New Point(298, 347)
        btn_display_stats.Name = "btn_display_stats"
        btn_display_stats.Size = New Size(239, 39)
        btn_display_stats.TabIndex = 4
        btn_display_stats.Text = "Display Statistics"
        btn_display_stats.UseVisualStyleBackColor = True
        ' 
        ' lbl_average_savings
        ' 
        lbl_average_savings.AutoSize = True
        lbl_average_savings.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        lbl_average_savings.Location = New Point(262, 389)
        lbl_average_savings.Name = "lbl_average_savings"
        lbl_average_savings.Size = New Size(310, 30)
        lbl_average_savings.TabIndex = 5
        lbl_average_savings.Text = "The average monthly savings: "
        lbl_average_savings.TextAlign = ContentAlignment.MiddleCenter
        lbl_average_savings.Visible = False
        ' 
        ' lbl_largest_savings
        ' 
        lbl_largest_savings.AutoSize = True
        lbl_largest_savings.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        lbl_largest_savings.Location = New Point(208, 428)
        lbl_largest_savings.Name = "lbl_largest_savings"
        lbl_largest_savings.Size = New Size(419, 30)
        lbl_largest_savings.TabIndex = 6
        lbl_largest_savings.Text = "had the most significant monthly savings"
        lbl_largest_savings.TextAlign = ContentAlignment.MiddleCenter
        lbl_largest_savings.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AntiqueWhite
        ClientSize = New Size(800, 511)
        Controls.Add(lbl_largest_savings)
        Controls.Add(lbl_average_savings)
        Controls.Add(btn_display_stats)
        Controls.Add(lbl_selected_month_savings)
        Controls.Add(cb_month)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Fart Home Application"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cb_month As ComboBox
    Friend WithEvents lbl_selected_month_savings As Label
    Friend WithEvents btn_display_stats As Button
    Friend WithEvents lbl_average_savings As Label
    Friend WithEvents lbl_largest_savings As Label

End Class
