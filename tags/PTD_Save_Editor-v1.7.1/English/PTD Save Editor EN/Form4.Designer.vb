﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gb_Achieve1 = New System.Windows.Forms.GroupBox
        Me.cb_Achieve1_4 = New System.Windows.Forms.CheckBox
        Me.cb_Achieve1_3 = New System.Windows.Forms.CheckBox
        Me.cb_Achieve1_2 = New System.Windows.Forms.CheckBox
        Me.cb_Achieve1_1 = New System.Windows.Forms.CheckBox
        Me.b_Validate = New System.Windows.Forms.Button
        Me.b_Cancel = New System.Windows.Forms.Button
        Me.gb_Achieve1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_Achieve1
        '
        Me.gb_Achieve1.Controls.Add(Me.cb_Achieve1_4)
        Me.gb_Achieve1.Controls.Add(Me.cb_Achieve1_3)
        Me.gb_Achieve1.Controls.Add(Me.cb_Achieve1_2)
        Me.gb_Achieve1.Controls.Add(Me.cb_Achieve1_1)
        Me.gb_Achieve1.Location = New System.Drawing.Point(12, 12)
        Me.gb_Achieve1.Name = "gb_Achieve1"
        Me.gb_Achieve1.Size = New System.Drawing.Size(213, 65)
        Me.gb_Achieve1.TabIndex = 0
        Me.gb_Achieve1.TabStop = False
        Me.gb_Achieve1.Text = "Shiny Hunter 1"
        '
        'cb_Achieve1_4
        '
        Me.cb_Achieve1_4.AutoSize = True
        Me.cb_Achieve1_4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cb_Achieve1_4.Location = New System.Drawing.Point(13, 42)
        Me.cb_Achieve1_4.Name = "cb_Achieve1_4"
        Me.cb_Achieve1_4.Size = New System.Drawing.Size(54, 17)
        Me.cb_Achieve1_4.TabIndex = 0
        Me.cb_Achieve1_4.Tag = "3"
        Me.cb_Achieve1_4.Text = "Zubat"
        Me.cb_Achieve1_4.UseVisualStyleBackColor = True
        '
        'cb_Achieve1_3
        '
        Me.cb_Achieve1_3.AutoSize = True
        Me.cb_Achieve1_3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cb_Achieve1_3.Location = New System.Drawing.Point(137, 19)
        Me.cb_Achieve1_3.Name = "cb_Achieve1_3"
        Me.cb_Achieve1_3.Size = New System.Drawing.Size(70, 17)
        Me.cb_Achieve1_3.TabIndex = 0
        Me.cb_Achieve1_3.Tag = "2"
        Me.cb_Achieve1_3.Text = "Geodude"
        Me.cb_Achieve1_3.UseVisualStyleBackColor = True
        '
        'cb_Achieve1_2
        '
        Me.cb_Achieve1_2.AutoSize = True
        Me.cb_Achieve1_2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cb_Achieve1_2.Location = New System.Drawing.Point(73, 19)
        Me.cb_Achieve1_2.Name = "cb_Achieve1_2"
        Me.cb_Achieve1_2.Size = New System.Drawing.Size(58, 17)
        Me.cb_Achieve1_2.TabIndex = 0
        Me.cb_Achieve1_2.Tag = "1"
        Me.cb_Achieve1_2.Text = "Pidgey"
        Me.cb_Achieve1_2.UseVisualStyleBackColor = True
        '
        'cb_Achieve1_1
        '
        Me.cb_Achieve1_1.AutoSize = True
        Me.cb_Achieve1_1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cb_Achieve1_1.Location = New System.Drawing.Point(6, 19)
        Me.cb_Achieve1_1.Name = "cb_Achieve1_1"
        Me.cb_Achieve1_1.Size = New System.Drawing.Size(61, 17)
        Me.cb_Achieve1_1.TabIndex = 0
        Me.cb_Achieve1_1.Tag = "0"
        Me.cb_Achieve1_1.Text = "Rattata"
        Me.cb_Achieve1_1.UseVisualStyleBackColor = True
        '
        'b_Validate
        '
        Me.b_Validate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.b_Validate.Location = New System.Drawing.Point(12, 83)
        Me.b_Validate.Name = "b_Validate"
        Me.b_Validate.Size = New System.Drawing.Size(75, 23)
        Me.b_Validate.TabIndex = 1
        Me.b_Validate.Text = "Validate"
        Me.b_Validate.UseVisualStyleBackColor = True
        '
        'b_Cancel
        '
        Me.b_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.b_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.b_Cancel.Location = New System.Drawing.Point(150, 83)
        Me.b_Cancel.Name = "b_Cancel"
        Me.b_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.b_Cancel.TabIndex = 2
        Me.b_Cancel.Text = "Cancel"
        Me.b_Cancel.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AcceptButton = Me.b_Validate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.b_Cancel
        Me.ClientSize = New System.Drawing.Size(237, 118)
        Me.Controls.Add(Me.b_Cancel)
        Me.Controls.Add(Me.b_Validate)
        Me.Controls.Add(Me.gb_Achieve1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form4"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Achievements"
        Me.gb_Achieve1.ResumeLayout(False)
        Me.gb_Achieve1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gb_Achieve1 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_Achieve1_4 As System.Windows.Forms.CheckBox
    Friend WithEvents cb_Achieve1_3 As System.Windows.Forms.CheckBox
    Friend WithEvents cb_Achieve1_2 As System.Windows.Forms.CheckBox
    Friend WithEvents cb_Achieve1_1 As System.Windows.Forms.CheckBox
    Friend WithEvents b_Validate As System.Windows.Forms.Button
    Friend WithEvents b_Cancel As System.Windows.Forms.Button
End Class
