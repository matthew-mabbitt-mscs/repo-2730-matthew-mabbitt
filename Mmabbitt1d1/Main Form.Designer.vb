﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.lblTotalItems = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDonuts = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtMuffins = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTotalSales
        '
        Me.lblTotalSales.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTotalSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalSales.Location = New System.Drawing.Point(128, 230)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(47, 27)
        Me.lblTotalSales.TabIndex = 13
        Me.lblTotalSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalItems
        '
        Me.lblTotalItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalItems.Location = New System.Drawing.Point(128, 190)
        Me.lblTotalItems.Name = "lblTotalItems"
        Me.lblTotalItems.Size = New System.Drawing.Size(47, 27)
        Me.lblTotalItems.TabIndex = 11
        Me.lblTotalItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(167, 67)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(111, 32)
        Me.txtDate.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(228, 216)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(114, 31)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(228, 148)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(114, 31)
        Me.btnPrint.TabIndex = 7
        Me.btnPrint.Text = "&Print Receipt"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(228, 182)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(114, 31)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "C&lear Screen"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(228, 114)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(114, 31)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 25)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Total items:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "&Muffins:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "&Doughnuts:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(106, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(103, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 46)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Sales Receipt"
        '
        'txtDonuts
        '
        Me.txtDonuts.Location = New System.Drawing.Point(128, 111)
        Me.txtDonuts.Name = "txtDonuts"
        Me.txtDonuts.Size = New System.Drawing.Size(47, 32)
        Me.txtDonuts.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Bakery_Project.My.Resources.Resources.Chef
        Me.PictureBox1.Location = New System.Drawing.Point(22, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 25)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Total sales:"
        '
        'TxtMuffins
        '
        Me.TxtMuffins.Location = New System.Drawing.Point(128, 148)
        Me.TxtMuffins.Name = "TxtMuffins"
        Me.TxtMuffins.Size = New System.Drawing.Size(47, 32)
        Me.TxtMuffins.TabIndex = 5
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 280)
        Me.Controls.Add(Me.TxtMuffins)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtDonuts)
        Me.Controls.Add(Me.lblTotalSales)
        Me.Controls.Add(Me.lblTotalItems)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Meyer's Purple Bakery"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents lblTotalSales As Label
    Friend WithEvents lblTotalItems As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalc As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDonuts As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtMuffins As TextBox
End Class
