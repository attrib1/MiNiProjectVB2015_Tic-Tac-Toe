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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_Reset = New System.Windows.Forms.Button()
        Me.scoreP2 = New System.Windows.Forms.Label()
        Me.scoreP1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.showTurnplay = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AxShockwaveFlash1 = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.B3 = New System.Windows.Forms.Button()
        Me.C1 = New System.Windows.Forms.Button()
        Me.B2 = New System.Windows.Forms.Button()
        Me.C2 = New System.Windows.Forms.Button()
        Me.B1 = New System.Windows.Forms.Button()
        Me.C3 = New System.Windows.Forms.Button()
        Me.A3 = New System.Windows.Forms.Button()
        Me.A2 = New System.Windows.Forms.Button()
        Me.A1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_Reset)
        Me.GroupBox1.Controls.Add(Me.scoreP2)
        Me.GroupBox1.Controls.Add(Me.scoreP1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.showTurnplay)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(577, 387)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 171)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'btn_Reset
        '
        Me.btn_Reset.Location = New System.Drawing.Point(30, 142)
        Me.btn_Reset.Name = "btn_Reset"
        Me.btn_Reset.Size = New System.Drawing.Size(75, 23)
        Me.btn_Reset.TabIndex = 6
        Me.btn_Reset.Text = "Reset"
        Me.btn_Reset.UseVisualStyleBackColor = True
        '
        'scoreP2
        '
        Me.scoreP2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.scoreP2.Cursor = System.Windows.Forms.Cursors.Default
        Me.scoreP2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.scoreP2.Location = New System.Drawing.Point(89, 98)
        Me.scoreP2.Name = "scoreP2"
        Me.scoreP2.Size = New System.Drawing.Size(73, 38)
        Me.scoreP2.TabIndex = 5
        Me.scoreP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'scoreP1
        '
        Me.scoreP1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.scoreP1.Cursor = System.Windows.Forms.Cursors.Default
        Me.scoreP1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.scoreP1.Location = New System.Drawing.Point(30, 98)
        Me.scoreP1.Name = "scoreP1"
        Me.scoreP1.Size = New System.Drawing.Size(58, 38)
        Me.scoreP1.TabIndex = 4
        Me.scoreP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Location = New System.Drawing.Point(89, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Player2"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Location = New System.Drawing.Point(30, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Player1"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'showTurnplay
        '
        Me.showTurnplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.showTurnplay.Cursor = System.Windows.Forms.Cursors.Default
        Me.showTurnplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.showTurnplay.Location = New System.Drawing.Point(30, 44)
        Me.showTurnplay.Name = "showTurnplay"
        Me.showTurnplay.Size = New System.Drawing.Size(132, 36)
        Me.showTurnplay.TabIndex = 1
        Me.showTurnplay.Text = "Player : 1"
        Me.showTurnplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Location = New System.Drawing.Point(30, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Turn"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AxShockwaveFlash1
        '
        Me.AxShockwaveFlash1.Enabled = True
        Me.AxShockwaveFlash1.Location = New System.Drawing.Point(149, 6)
        Me.AxShockwaveFlash1.Name = "AxShockwaveFlash1"
        Me.AxShockwaveFlash1.OcxState = CType(resources.GetObject("AxShockwaveFlash1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxShockwaveFlash1.Size = New System.Drawing.Size(500, 350)
        Me.AxShockwaveFlash1.TabIndex = 10
        '
        'B3
        '
        Me.B3.Location = New System.Drawing.Point(238, 95)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(95, 67)
        Me.B3.TabIndex = 5
        Me.B3.UseVisualStyleBackColor = True
        '
        'C1
        '
        Me.C1.Location = New System.Drawing.Point(34, 168)
        Me.C1.Name = "C1"
        Me.C1.Size = New System.Drawing.Size(95, 67)
        Me.C1.TabIndex = 6
        Me.C1.UseVisualStyleBackColor = True
        '
        'B2
        '
        Me.B2.Location = New System.Drawing.Point(137, 95)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(95, 67)
        Me.B2.TabIndex = 4
        Me.B2.UseVisualStyleBackColor = True
        '
        'C2
        '
        Me.C2.Location = New System.Drawing.Point(137, 168)
        Me.C2.Name = "C2"
        Me.C2.Size = New System.Drawing.Size(95, 67)
        Me.C2.TabIndex = 7
        Me.C2.UseVisualStyleBackColor = True
        '
        'B1
        '
        Me.B1.ForeColor = System.Drawing.Color.Transparent
        Me.B1.Location = New System.Drawing.Point(34, 95)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(95, 67)
        Me.B1.TabIndex = 3
        Me.B1.UseVisualStyleBackColor = True
        '
        'C3
        '
        Me.C3.Location = New System.Drawing.Point(238, 168)
        Me.C3.Name = "C3"
        Me.C3.Size = New System.Drawing.Size(95, 67)
        Me.C3.TabIndex = 8
        Me.C3.UseVisualStyleBackColor = True
        '
        'A3
        '
        Me.A3.BackColor = System.Drawing.Color.Transparent
        Me.A3.Location = New System.Drawing.Point(238, 19)
        Me.A3.Name = "A3"
        Me.A3.Size = New System.Drawing.Size(95, 67)
        Me.A3.TabIndex = 2
        Me.A3.UseVisualStyleBackColor = False
        '
        'A2
        '
        Me.A2.Location = New System.Drawing.Point(137, 19)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(95, 67)
        Me.A2.TabIndex = 1
        Me.A2.UseVisualStyleBackColor = True
        '
        'A1
        '
        Me.A1.ForeColor = System.Drawing.Color.DarkRed
        Me.A1.Location = New System.Drawing.Point(34, 19)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(95, 67)
        Me.A1.TabIndex = 0
        Me.A1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.C3)
        Me.Panel1.Controls.Add(Me.A3)
        Me.Panel1.Controls.Add(Me.C2)
        Me.Panel1.Controls.Add(Me.B1)
        Me.Panel1.Controls.Add(Me.C1)
        Me.Panel1.Controls.Add(Me.B2)
        Me.Panel1.Controls.Add(Me.B3)
        Me.Panel1.Controls.Add(Me.A2)
        Me.Panel1.Controls.Add(Me.A1)
        Me.Panel1.Location = New System.Drawing.Point(118, 387)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(387, 245)
        Me.Panel1.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ClientSize = New System.Drawing.Size(875, 679)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.AxShockwaveFlash1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents showTurnplay As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents scoreP2 As Label
    Friend WithEvents scoreP1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_Reset As Button
    Friend WithEvents AxShockwaveFlash1 As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents B3 As Button
    Friend WithEvents C1 As Button
    Friend WithEvents B2 As Button
    Friend WithEvents C2 As Button
    Friend WithEvents B1 As Button
    Friend WithEvents C3 As Button
    Friend WithEvents A3 As Button
    Friend WithEvents A2 As Button
    Friend WithEvents A1 As Button
    Friend WithEvents Panel1 As Panel
End Class
