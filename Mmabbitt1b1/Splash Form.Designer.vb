﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSplash
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
        Me.components = New System.ComponentModel.Container()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PicStorks = New System.Windows.Forms.PictureBox()
        Me.PicIguanas = New System.Windows.Forms.PictureBox()
        Me.TmrExit = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PicStorks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicIguanas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(180, 70)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(136, 28)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Crighton Zoo"
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblMsg.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.ForeColor = System.Drawing.Color.Red
        Me.lblMsg.Location = New System.Drawing.Point(180, 115)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(234, 28)
        Me.lblMsg.TabIndex = 1
        Me.lblMsg.Text = "Come visit our residents!"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(10, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(404, 274)
        Me.Label1.TabIndex = 2
        '
        'PicStorks
        '
        Me.PicStorks.Image = Global.Mmabbitt1b1.My.Resources.Resources.Storks
        Me.PicStorks.Location = New System.Drawing.Point(254, 146)
        Me.PicStorks.Name = "PicStorks"
        Me.PicStorks.Size = New System.Drawing.Size(156, 135)
        Me.PicStorks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicStorks.TabIndex = 4
        Me.PicStorks.TabStop = False
        '
        'PicIguanas
        '
        Me.PicIguanas.Image = Global.Mmabbitt1b1.My.Resources.Resources.Iguanas
        Me.PicIguanas.Location = New System.Drawing.Point(14, 13)
        Me.PicIguanas.Name = "PicIguanas"
        Me.PicIguanas.Size = New System.Drawing.Size(160, 142)
        Me.PicIguanas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicIguanas.TabIndex = 3
        Me.PicIguanas.TabStop = False
        '
        'TmrExit
        '
        Me.TmrExit.Enabled = True
        Me.TmrExit.Interval = 4000
        '
        'FrmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(422, 293)
        Me.ControlBox = False
        Me.Controls.Add(Me.PicStorks)
        Me.Controls.Add(Me.PicIguanas)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmSplash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PicStorks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicIguanas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblMsg As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PicIguanas As PictureBox
    Friend WithEvents PicStorks As PictureBox
    Friend WithEvents TmrExit As Timer
End Class
