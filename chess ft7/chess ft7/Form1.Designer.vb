﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        boardImage = New PictureBox()
        CType(boardImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' boardImage
        ' 
        boardImage.Dock = DockStyle.Fill
        boardImage.Image = CType(resources.GetObject("boardImage.Image"), Image)
        boardImage.Location = New Point(0, 0)
        boardImage.Name = "boardImage"
        boardImage.Size = New Size(400, 399)
        boardImage.SizeMode = PictureBoxSizeMode.StretchImage
        boardImage.TabIndex = 0
        boardImage.TabStop = False
        ' 
        ' Form1
        ' 
        AllowDrop = True
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(400, 399)
        Controls.Add(boardImage)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        Text = "Form1"
        CType(boardImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents boardImage As PictureBox

End Class
