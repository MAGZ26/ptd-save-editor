﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container
        Me.b_ImportAccount = New System.Windows.Forms.Button
        Me.tb_Email = New System.Windows.Forms.TextBox
        Me.tb_Pass = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.gb_Profiles = New System.Windows.Forms.GroupBox
        Me.rb_Profile3 = New System.Windows.Forms.RadioButton
        Me.rb_Profile2 = New System.Windows.Forms.RadioButton
        Me.rb_Profile1 = New System.Windows.Forms.RadioButton
        Me.gb_Login = New System.Windows.Forms.GroupBox
        Me.b_SaveAccount = New System.Windows.Forms.Button
        Me.lbl_Status = New System.Windows.Forms.Label
        Me.gb_Data = New System.Windows.Forms.GroupBox
        Me.cb_Jynx = New System.Windows.Forms.CheckBox
        Me.cb_ShinyGeodude = New System.Windows.Forms.CheckBox
        Me.nud_Challenge = New System.Windows.Forms.NumericUpDown
        Me.Label11 = New System.Windows.Forms.Label
        Me.b_EditInv = New System.Windows.Forms.Button
        Me.b_SaveProfile = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.nud_Attempted = New System.Windows.Forms.NumericUpDown
        Me.nud_Unlocked = New System.Windows.Forms.NumericUpDown
        Me.gb_Pokemon = New System.Windows.Forms.GroupBox
        Me.lbl_MaxExp = New System.Windows.Forms.Label
        Me.lbl_MaxLevel = New System.Windows.Forms.Label
        Me.gb_GenerateCode = New System.Windows.Forms.GroupBox
        Me.b_CopyCode = New System.Windows.Forms.Button
        Me.tb_SecurityCode = New System.Windows.Forms.TextBox
        Me.tb_PreviewCode = New System.Windows.Forms.TextBox
        Me.b_GenerateCode = New System.Windows.Forms.Button
        Me.lbl_NotYetImplemented = New System.Windows.Forms.Label
        Me.b_Events = New System.Windows.Forms.Button
        Me.b_Duplicate = New System.Windows.Forms.Button
        Me.b_DelPoke = New System.Windows.Forms.Button
        Me.b_AddPoke = New System.Windows.Forms.Button
        Me.b_PokeDown = New System.Windows.Forms.Button
        Me.b_PokeUp = New System.Windows.Forms.Button
        Me.gb_Moves = New System.Windows.Forms.GroupBox
        Me.rb_SelMove4 = New System.Windows.Forms.RadioButton
        Me.rb_SelMove2 = New System.Windows.Forms.RadioButton
        Me.rb_SelMove3 = New System.Windows.Forms.RadioButton
        Me.rb_SelMove1 = New System.Windows.Forms.RadioButton
        Me.cb_Move4 = New System.Windows.Forms.ComboBox
        Me.cb_Move3 = New System.Windows.Forms.ComboBox
        Me.cb_Move2 = New System.Windows.Forms.ComboBox
        Me.cb_Move1 = New System.Windows.Forms.ComboBox
        Me.cb_Shiny = New System.Windows.Forms.CheckBox
        Me.lbl_ID = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.nud_Level = New System.Windows.Forms.NumericUpDown
        Me.b_SavePoke = New System.Windows.Forms.Button
        Me.cb_Specie = New System.Windows.Forms.ComboBox
        Me.lb_Team = New System.Windows.Forms.ListBox
        Me.tb_Exp = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.rb_Blue = New System.Windows.Forms.RadioButton
        Me.rb_Red = New System.Windows.Forms.RadioButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.nud_Badges = New System.Windows.Forms.NumericUpDown
        Me.Label5 = New System.Windows.Forms.Label
        Me.tb_Money = New System.Windows.Forms.TextBox
        Me.tb_Name = New System.Windows.Forms.TextBox
        Me.lbl_Name = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.b_DelOrCreateProfile = New System.Windows.Forms.Button
        Me.lbl_ProgramVersion = New System.Windows.Forms.Label
        Me.llbl_Website = New System.Windows.Forms.LinkLabel
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.gb_Profiles.SuspendLayout()
        Me.gb_Login.SuspendLayout()
        Me.gb_Data.SuspendLayout()
        CType(Me.nud_Challenge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_Attempted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_Unlocked, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_Pokemon.SuspendLayout()
        Me.gb_GenerateCode.SuspendLayout()
        Me.gb_Moves.SuspendLayout()
        CType(Me.nud_Level, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.nud_Badges, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'b_ImportAccount
        '
        Me.b_ImportAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.b_ImportAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_ImportAccount.Location = New System.Drawing.Point(260, 11)
        Me.b_ImportAccount.Name = "b_ImportAccount"
        Me.b_ImportAccount.Size = New System.Drawing.Size(75, 23)
        Me.b_ImportAccount.TabIndex = 20
        Me.b_ImportAccount.Text = "Charger"
        Me.b_ImportAccount.UseVisualStyleBackColor = True
        '
        'tb_Email
        '
        Me.tb_Email.AcceptsReturn = True
        Me.tb_Email.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_Email.Location = New System.Drawing.Point(49, 13)
        Me.tb_Email.Name = "tb_Email"
        Me.tb_Email.Size = New System.Drawing.Size(205, 20)
        Me.tb_Email.TabIndex = 0
        '
        'tb_Pass
        '
        Me.tb_Pass.AcceptsReturn = True
        Me.tb_Pass.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_Pass.Location = New System.Drawing.Point(49, 39)
        Me.tb_Pass.Name = "tb_Pass"
        Me.tb_Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_Pass.Size = New System.Drawing.Size(205, 20)
        Me.tb_Pass.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "E-mail :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Pass :"
        '
        'gb_Profiles
        '
        Me.gb_Profiles.Controls.Add(Me.rb_Profile3)
        Me.gb_Profiles.Controls.Add(Me.rb_Profile2)
        Me.gb_Profiles.Controls.Add(Me.rb_Profile1)
        Me.gb_Profiles.Enabled = False
        Me.gb_Profiles.Location = New System.Drawing.Point(359, 12)
        Me.gb_Profiles.Name = "gb_Profiles"
        Me.gb_Profiles.Size = New System.Drawing.Size(66, 78)
        Me.gb_Profiles.TabIndex = 100
        Me.gb_Profiles.TabStop = False
        Me.gb_Profiles.Text = "Profil"
        '
        'rb_Profile3
        '
        Me.rb_Profile3.AutoSize = True
        Me.rb_Profile3.Location = New System.Drawing.Point(6, 56)
        Me.rb_Profile3.Name = "rb_Profile3"
        Me.rb_Profile3.Size = New System.Drawing.Size(57, 17)
        Me.rb_Profile3.TabIndex = 2
        Me.rb_Profile3.Tag = "3"
        Me.rb_Profile3.Text = "Profil 3"
        Me.rb_Profile3.UseVisualStyleBackColor = True
        '
        'rb_Profile2
        '
        Me.rb_Profile2.AutoSize = True
        Me.rb_Profile2.Location = New System.Drawing.Point(6, 35)
        Me.rb_Profile2.Name = "rb_Profile2"
        Me.rb_Profile2.Size = New System.Drawing.Size(57, 17)
        Me.rb_Profile2.TabIndex = 1
        Me.rb_Profile2.Tag = "2"
        Me.rb_Profile2.Text = "Profil 2"
        Me.rb_Profile2.UseVisualStyleBackColor = True
        '
        'rb_Profile1
        '
        Me.rb_Profile1.AutoSize = True
        Me.rb_Profile1.Location = New System.Drawing.Point(6, 14)
        Me.rb_Profile1.Name = "rb_Profile1"
        Me.rb_Profile1.Size = New System.Drawing.Size(57, 17)
        Me.rb_Profile1.TabIndex = 0
        Me.rb_Profile1.Tag = "1"
        Me.rb_Profile1.Text = "Profil 1"
        Me.rb_Profile1.UseVisualStyleBackColor = True
        '
        'gb_Login
        '
        Me.gb_Login.Controls.Add(Me.b_SaveAccount)
        Me.gb_Login.Controls.Add(Me.lbl_Status)
        Me.gb_Login.Controls.Add(Me.Label1)
        Me.gb_Login.Controls.Add(Me.b_ImportAccount)
        Me.gb_Login.Controls.Add(Me.Label2)
        Me.gb_Login.Controls.Add(Me.tb_Email)
        Me.gb_Login.Controls.Add(Me.tb_Pass)
        Me.gb_Login.Location = New System.Drawing.Point(12, 12)
        Me.gb_Login.Name = "gb_Login"
        Me.gb_Login.Size = New System.Drawing.Size(341, 78)
        Me.gb_Login.TabIndex = 0
        Me.gb_Login.TabStop = False
        Me.gb_Login.Text = "Login"
        '
        'b_SaveAccount
        '
        Me.b_SaveAccount.Enabled = False
        Me.b_SaveAccount.Location = New System.Drawing.Point(260, 37)
        Me.b_SaveAccount.Name = "b_SaveAccount"
        Me.b_SaveAccount.Size = New System.Drawing.Size(75, 23)
        Me.b_SaveAccount.TabIndex = 44
        Me.b_SaveAccount.Text = "Enregistrer"
        Me.b_SaveAccount.UseVisualStyleBackColor = True
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Status.Location = New System.Drawing.Point(46, 61)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(0, 13)
        Me.lbl_Status.TabIndex = 43
        '
        'gb_Data
        '
        Me.gb_Data.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_Data.Controls.Add(Me.cb_Jynx)
        Me.gb_Data.Controls.Add(Me.cb_ShinyGeodude)
        Me.gb_Data.Controls.Add(Me.nud_Challenge)
        Me.gb_Data.Controls.Add(Me.Label11)
        Me.gb_Data.Controls.Add(Me.b_EditInv)
        Me.gb_Data.Controls.Add(Me.b_SaveProfile)
        Me.gb_Data.Controls.Add(Me.Label9)
        Me.gb_Data.Controls.Add(Me.Label8)
        Me.gb_Data.Controls.Add(Me.nud_Attempted)
        Me.gb_Data.Controls.Add(Me.nud_Unlocked)
        Me.gb_Data.Controls.Add(Me.gb_Pokemon)
        Me.gb_Data.Controls.Add(Me.GroupBox4)
        Me.gb_Data.Controls.Add(Me.Label6)
        Me.gb_Data.Controls.Add(Me.nud_Badges)
        Me.gb_Data.Controls.Add(Me.Label5)
        Me.gb_Data.Controls.Add(Me.tb_Money)
        Me.gb_Data.Controls.Add(Me.tb_Name)
        Me.gb_Data.Controls.Add(Me.lbl_Name)
        Me.gb_Data.Controls.Add(Me.Label4)
        Me.gb_Data.Enabled = False
        Me.gb_Data.Location = New System.Drawing.Point(12, 96)
        Me.gb_Data.Name = "gb_Data"
        Me.gb_Data.Size = New System.Drawing.Size(413, 418)
        Me.gb_Data.TabIndex = 200
        Me.gb_Data.TabStop = False
        Me.gb_Data.Text = "Données"
        '
        'cb_Jynx
        '
        Me.cb_Jynx.AutoSize = True
        Me.cb_Jynx.Location = New System.Drawing.Point(257, 99)
        Me.cb_Jynx.Name = "cb_Jynx"
        Me.cb_Jynx.Size = New System.Drawing.Size(109, 17)
        Me.cb_Jynx.TabIndex = 84
        Me.cb_Jynx.Text = "Lippoutou obtenu"
        Me.cb_Jynx.UseVisualStyleBackColor = True
        '
        'cb_ShinyGeodude
        '
        Me.cb_ShinyGeodude.AutoSize = True
        Me.cb_ShinyGeodude.Location = New System.Drawing.Point(257, 84)
        Me.cb_ShinyGeodude.Name = "cb_ShinyGeodude"
        Me.cb_ShinyGeodude.Size = New System.Drawing.Size(135, 17)
        Me.cb_ShinyGeodude.TabIndex = 83
        Me.cb_ShinyGeodude.Text = "Racaillou Shiny obtenu"
        Me.cb_ShinyGeodude.UseVisualStyleBackColor = True
        '
        'nud_Challenge
        '
        Me.nud_Challenge.Location = New System.Drawing.Point(205, 91)
        Me.nud_Challenge.Name = "nud_Challenge"
        Me.nud_Challenge.Size = New System.Drawing.Size(40, 20)
        Me.nud_Challenge.TabIndex = 82
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(86, 93)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 13)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = """Challenges"" terminés :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'b_EditInv
        '
        Me.b_EditInv.Location = New System.Drawing.Point(145, 13)
        Me.b_EditInv.Name = "b_EditInv"
        Me.b_EditInv.Size = New System.Drawing.Size(84, 23)
        Me.b_EditInv.TabIndex = 30
        Me.b_EditInv.Text = "Éditer Objets..."
        Me.b_EditInv.UseVisualStyleBackColor = True
        '
        'b_SaveProfile
        '
        Me.b_SaveProfile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.b_SaveProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_SaveProfile.Location = New System.Drawing.Point(319, 13)
        Me.b_SaveProfile.Name = "b_SaveProfile"
        Me.b_SaveProfile.Size = New System.Drawing.Size(88, 23)
        Me.b_SaveProfile.TabIndex = 80
        Me.b_SaveProfile.Text = "Sauver Profil"
        Me.b_SaveProfile.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(119, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 13)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Niveaux tentés :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(99, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 13)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Niveaux débloqués :"
        '
        'nud_Attempted
        '
        Me.nud_Attempted.Location = New System.Drawing.Point(205, 41)
        Me.nud_Attempted.Name = "nud_Attempted"
        Me.nud_Attempted.Size = New System.Drawing.Size(40, 20)
        Me.nud_Attempted.TabIndex = 40
        '
        'nud_Unlocked
        '
        Me.nud_Unlocked.Location = New System.Drawing.Point(205, 66)
        Me.nud_Unlocked.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.nud_Unlocked.Name = "nud_Unlocked"
        Me.nud_Unlocked.Size = New System.Drawing.Size(40, 20)
        Me.nud_Unlocked.TabIndex = 50
        '
        'gb_Pokemon
        '
        Me.gb_Pokemon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_Pokemon.Controls.Add(Me.lbl_MaxExp)
        Me.gb_Pokemon.Controls.Add(Me.lbl_MaxLevel)
        Me.gb_Pokemon.Controls.Add(Me.gb_GenerateCode)
        Me.gb_Pokemon.Controls.Add(Me.lbl_NotYetImplemented)
        Me.gb_Pokemon.Controls.Add(Me.b_Events)
        Me.gb_Pokemon.Controls.Add(Me.b_Duplicate)
        Me.gb_Pokemon.Controls.Add(Me.b_DelPoke)
        Me.gb_Pokemon.Controls.Add(Me.b_AddPoke)
        Me.gb_Pokemon.Controls.Add(Me.b_PokeDown)
        Me.gb_Pokemon.Controls.Add(Me.b_PokeUp)
        Me.gb_Pokemon.Controls.Add(Me.gb_Moves)
        Me.gb_Pokemon.Controls.Add(Me.cb_Shiny)
        Me.gb_Pokemon.Controls.Add(Me.lbl_ID)
        Me.gb_Pokemon.Controls.Add(Me.Label7)
        Me.gb_Pokemon.Controls.Add(Me.Label3)
        Me.gb_Pokemon.Controls.Add(Me.nud_Level)
        Me.gb_Pokemon.Controls.Add(Me.b_SavePoke)
        Me.gb_Pokemon.Controls.Add(Me.cb_Specie)
        Me.gb_Pokemon.Controls.Add(Me.lb_Team)
        Me.gb_Pokemon.Controls.Add(Me.tb_Exp)
        Me.gb_Pokemon.Location = New System.Drawing.Point(6, 110)
        Me.gb_Pokemon.Name = "gb_Pokemon"
        Me.gb_Pokemon.Size = New System.Drawing.Size(401, 302)
        Me.gb_Pokemon.TabIndex = 70
        Me.gb_Pokemon.TabStop = False
        Me.gb_Pokemon.Text = "Pokémon"
        '
        'lbl_MaxExp
        '
        Me.lbl_MaxExp.AutoSize = True
        Me.lbl_MaxExp.Location = New System.Drawing.Point(302, 68)
        Me.lbl_MaxExp.Name = "lbl_MaxExp"
        Me.lbl_MaxExp.Size = New System.Drawing.Size(0, 13)
        Me.lbl_MaxExp.TabIndex = 106
        '
        'lbl_MaxLevel
        '
        Me.lbl_MaxLevel.AutoSize = True
        Me.lbl_MaxLevel.Location = New System.Drawing.Point(294, 43)
        Me.lbl_MaxLevel.Name = "lbl_MaxLevel"
        Me.lbl_MaxLevel.Size = New System.Drawing.Size(81, 13)
        Me.lbl_MaxLevel.TabIndex = 105
        Me.lbl_MaxLevel.Text = "Max = 36 (v2.7)"
        '
        'gb_GenerateCode
        '
        Me.gb_GenerateCode.Controls.Add(Me.b_CopyCode)
        Me.gb_GenerateCode.Controls.Add(Me.tb_SecurityCode)
        Me.gb_GenerateCode.Controls.Add(Me.tb_PreviewCode)
        Me.gb_GenerateCode.Controls.Add(Me.b_GenerateCode)
        Me.gb_GenerateCode.Location = New System.Drawing.Point(97, 230)
        Me.gb_GenerateCode.Name = "gb_GenerateCode"
        Me.gb_GenerateCode.Size = New System.Drawing.Size(298, 50)
        Me.gb_GenerateCode.TabIndex = 104
        Me.gb_GenerateCode.TabStop = False
        Me.gb_GenerateCode.Text = "Générer un code   (Trading -> Recieve Trade Pokemon)"
        '
        'b_CopyCode
        '
        Me.b_CopyCode.Enabled = False
        Me.b_CopyCode.Location = New System.Drawing.Point(269, 19)
        Me.b_CopyCode.Name = "b_CopyCode"
        Me.b_CopyCode.Size = New System.Drawing.Size(23, 23)
        Me.b_CopyCode.TabIndex = 3
        Me.b_CopyCode.Text = "C"
        Me.ToolTip1.SetToolTip(Me.b_CopyCode, "Copier le code dans le presse-papiers.")
        Me.b_CopyCode.UseVisualStyleBackColor = True
        '
        'tb_SecurityCode
        '
        Me.tb_SecurityCode.Location = New System.Drawing.Point(228, 21)
        Me.tb_SecurityCode.Name = "tb_SecurityCode"
        Me.tb_SecurityCode.ReadOnly = True
        Me.tb_SecurityCode.Size = New System.Drawing.Size(35, 20)
        Me.tb_SecurityCode.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.tb_SecurityCode, """Security Code""")
        '
        'tb_PreviewCode
        '
        Me.tb_PreviewCode.Location = New System.Drawing.Point(87, 21)
        Me.tb_PreviewCode.Name = "tb_PreviewCode"
        Me.tb_PreviewCode.ReadOnly = True
        Me.tb_PreviewCode.Size = New System.Drawing.Size(135, 20)
        Me.tb_PreviewCode.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.tb_PreviewCode, """Preview Code""")
        '
        'b_GenerateCode
        '
        Me.b_GenerateCode.Location = New System.Drawing.Point(6, 19)
        Me.b_GenerateCode.Name = "b_GenerateCode"
        Me.b_GenerateCode.Size = New System.Drawing.Size(75, 23)
        Me.b_GenerateCode.TabIndex = 0
        Me.b_GenerateCode.Text = "Générer"
        Me.ToolTip1.SetToolTip(Me.b_GenerateCode, "Générer un code pour un Pokémon en utilisant les valeurs courantes.")
        Me.b_GenerateCode.UseVisualStyleBackColor = True
        '
        'lbl_NotYetImplemented
        '
        Me.lbl_NotYetImplemented.AutoSize = True
        Me.lbl_NotYetImplemented.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NotYetImplemented.ForeColor = System.Drawing.Color.OrangeRed
        Me.lbl_NotYetImplemented.Location = New System.Drawing.Point(110, 43)
        Me.lbl_NotYetImplemented.Name = "lbl_NotYetImplemented"
        Me.lbl_NotYetImplemented.Size = New System.Drawing.Size(61, 26)
        Me.lbl_NotYetImplemented.TabIndex = 103
        Me.lbl_NotYetImplemented.Text = "Pas encore" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "dans le jeu."
        Me.lbl_NotYetImplemented.Visible = False
        '
        'b_Events
        '
        Me.b_Events.Location = New System.Drawing.Point(320, 12)
        Me.b_Events.Name = "b_Events"
        Me.b_Events.Size = New System.Drawing.Size(75, 23)
        Me.b_Events.TabIndex = 102
        Me.b_Events.Text = "Events..."
        Me.b_Events.UseVisualStyleBackColor = True
        '
        'b_Duplicate
        '
        Me.b_Duplicate.Location = New System.Drawing.Point(243, 172)
        Me.b_Duplicate.Name = "b_Duplicate"
        Me.b_Duplicate.Size = New System.Drawing.Size(67, 23)
        Me.b_Duplicate.TabIndex = 101
        Me.b_Duplicate.Text = "Dupliquer"
        Me.b_Duplicate.UseVisualStyleBackColor = True
        '
        'b_DelPoke
        '
        Me.b_DelPoke.Location = New System.Drawing.Point(170, 201)
        Me.b_DelPoke.Name = "b_DelPoke"
        Me.b_DelPoke.Size = New System.Drawing.Size(67, 23)
        Me.b_DelPoke.TabIndex = 90
        Me.b_DelPoke.Text = "Supprimer"
        Me.b_DelPoke.UseVisualStyleBackColor = True
        '
        'b_AddPoke
        '
        Me.b_AddPoke.Location = New System.Drawing.Point(170, 172)
        Me.b_AddPoke.Name = "b_AddPoke"
        Me.b_AddPoke.Size = New System.Drawing.Size(67, 23)
        Me.b_AddPoke.TabIndex = 80
        Me.b_AddPoke.Text = "Ajouter"
        Me.b_AddPoke.UseVisualStyleBackColor = True
        '
        'b_PokeDown
        '
        Me.b_PokeDown.Location = New System.Drawing.Point(97, 201)
        Me.b_PokeDown.Name = "b_PokeDown"
        Me.b_PokeDown.Size = New System.Drawing.Size(67, 23)
        Me.b_PokeDown.TabIndex = 70
        Me.b_PokeDown.Text = "Descendre"
        Me.b_PokeDown.UseVisualStyleBackColor = True
        '
        'b_PokeUp
        '
        Me.b_PokeUp.Location = New System.Drawing.Point(97, 172)
        Me.b_PokeUp.Name = "b_PokeUp"
        Me.b_PokeUp.Size = New System.Drawing.Size(67, 23)
        Me.b_PokeUp.TabIndex = 60
        Me.b_PokeUp.Text = "Monter"
        Me.b_PokeUp.UseVisualStyleBackColor = True
        '
        'gb_Moves
        '
        Me.gb_Moves.Controls.Add(Me.rb_SelMove4)
        Me.gb_Moves.Controls.Add(Me.rb_SelMove2)
        Me.gb_Moves.Controls.Add(Me.rb_SelMove3)
        Me.gb_Moves.Controls.Add(Me.rb_SelMove1)
        Me.gb_Moves.Controls.Add(Me.cb_Move4)
        Me.gb_Moves.Controls.Add(Me.cb_Move3)
        Me.gb_Moves.Controls.Add(Me.cb_Move2)
        Me.gb_Moves.Controls.Add(Me.cb_Move1)
        Me.gb_Moves.Location = New System.Drawing.Point(97, 91)
        Me.gb_Moves.Name = "gb_Moves"
        Me.gb_Moves.Size = New System.Drawing.Size(260, 75)
        Me.gb_Moves.TabIndex = 50
        Me.gb_Moves.TabStop = False
        Me.gb_Moves.Text = "Attaques"
        '
        'rb_SelMove4
        '
        Me.rb_SelMove4.AutoSize = True
        Me.rb_SelMove4.Location = New System.Drawing.Point(138, 49)
        Me.rb_SelMove4.Name = "rb_SelMove4"
        Me.rb_SelMove4.Size = New System.Drawing.Size(14, 13)
        Me.rb_SelMove4.TabIndex = 80
        Me.rb_SelMove4.TabStop = True
        Me.rb_SelMove4.UseVisualStyleBackColor = True
        '
        'rb_SelMove2
        '
        Me.rb_SelMove2.AutoSize = True
        Me.rb_SelMove2.Location = New System.Drawing.Point(138, 22)
        Me.rb_SelMove2.Name = "rb_SelMove2"
        Me.rb_SelMove2.Size = New System.Drawing.Size(14, 13)
        Me.rb_SelMove2.TabIndex = 60
        Me.rb_SelMove2.TabStop = True
        Me.rb_SelMove2.UseVisualStyleBackColor = True
        '
        'rb_SelMove3
        '
        Me.rb_SelMove3.AutoSize = True
        Me.rb_SelMove3.Location = New System.Drawing.Point(6, 49)
        Me.rb_SelMove3.Name = "rb_SelMove3"
        Me.rb_SelMove3.Size = New System.Drawing.Size(14, 13)
        Me.rb_SelMove3.TabIndex = 70
        Me.rb_SelMove3.TabStop = True
        Me.rb_SelMove3.UseVisualStyleBackColor = True
        '
        'rb_SelMove1
        '
        Me.rb_SelMove1.AutoSize = True
        Me.rb_SelMove1.Location = New System.Drawing.Point(6, 22)
        Me.rb_SelMove1.Name = "rb_SelMove1"
        Me.rb_SelMove1.Size = New System.Drawing.Size(14, 13)
        Me.rb_SelMove1.TabIndex = 50
        Me.rb_SelMove1.TabStop = True
        Me.rb_SelMove1.UseVisualStyleBackColor = True
        '
        'cb_Move4
        '
        Me.cb_Move4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Move4.FormattingEnabled = True
        Me.cb_Move4.Location = New System.Drawing.Point(158, 46)
        Me.cb_Move4.Name = "cb_Move4"
        Me.cb_Move4.Size = New System.Drawing.Size(96, 21)
        Me.cb_Move4.TabIndex = 30
        Me.cb_Move4.Tag = "4"
        '
        'cb_Move3
        '
        Me.cb_Move3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Move3.FormattingEnabled = True
        Me.cb_Move3.Location = New System.Drawing.Point(26, 46)
        Me.cb_Move3.Name = "cb_Move3"
        Me.cb_Move3.Size = New System.Drawing.Size(96, 21)
        Me.cb_Move3.TabIndex = 20
        Me.cb_Move3.Tag = "3"
        '
        'cb_Move2
        '
        Me.cb_Move2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Move2.FormattingEnabled = True
        Me.cb_Move2.Location = New System.Drawing.Point(158, 19)
        Me.cb_Move2.Name = "cb_Move2"
        Me.cb_Move2.Size = New System.Drawing.Size(96, 21)
        Me.cb_Move2.TabIndex = 10
        Me.cb_Move2.Tag = "2"
        '
        'cb_Move1
        '
        Me.cb_Move1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Move1.FormattingEnabled = True
        Me.cb_Move1.Location = New System.Drawing.Point(26, 19)
        Me.cb_Move1.Name = "cb_Move1"
        Me.cb_Move1.Size = New System.Drawing.Size(96, 21)
        Me.cb_Move1.TabIndex = 0
        Me.cb_Move1.Tag = "1"
        '
        'cb_Shiny
        '
        Me.cb_Shiny.AutoSize = True
        Me.cb_Shiny.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cb_Shiny.Location = New System.Drawing.Point(198, 20)
        Me.cb_Shiny.Name = "cb_Shiny"
        Me.cb_Shiny.Size = New System.Drawing.Size(52, 17)
        Me.cb_Shiny.TabIndex = 40
        Me.cb_Shiny.Text = "Shiny"
        Me.cb_Shiny.UseVisualStyleBackColor = True
        '
        'lbl_ID
        '
        Me.lbl_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_ID.AutoSize = True
        Me.lbl_ID.Location = New System.Drawing.Point(94, 282)
        Me.lbl_ID.Name = "lbl_ID"
        Me.lbl_ID.Size = New System.Drawing.Size(24, 13)
        Me.lbl_ID.TabIndex = 47
        Me.lbl_ID.Text = "ID :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(199, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Exp. :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(199, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Niveau :"
        '
        'nud_Level
        '
        Me.nud_Level.Location = New System.Drawing.Point(248, 39)
        Me.nud_Level.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nud_Level.Name = "nud_Level"
        Me.nud_Level.Size = New System.Drawing.Size(40, 20)
        Me.nud_Level.TabIndex = 20
        Me.nud_Level.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'b_SavePoke
        '
        Me.b_SavePoke.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.b_SavePoke.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_SavePoke.Location = New System.Drawing.Point(284, 201)
        Me.b_SavePoke.Name = "b_SavePoke"
        Me.b_SavePoke.Size = New System.Drawing.Size(111, 23)
        Me.b_SavePoke.TabIndex = 100
        Me.b_SavePoke.Text = "Sauver Pokémon"
        Me.b_SavePoke.UseVisualStyleBackColor = True
        '
        'cb_Specie
        '
        Me.cb_Specie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cb_Specie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_Specie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Specie.FormattingEnabled = True
        Me.cb_Specie.Location = New System.Drawing.Point(97, 19)
        Me.cb_Specie.Name = "cb_Specie"
        Me.cb_Specie.Size = New System.Drawing.Size(85, 21)
        Me.cb_Specie.TabIndex = 10
        '
        'lb_Team
        '
        Me.lb_Team.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lb_Team.FormattingEnabled = True
        Me.lb_Team.Location = New System.Drawing.Point(6, 19)
        Me.lb_Team.Name = "lb_Team"
        Me.lb_Team.Size = New System.Drawing.Size(85, 277)
        Me.lb_Team.TabIndex = 0
        '
        'tb_Exp
        '
        Me.tb_Exp.Location = New System.Drawing.Point(235, 65)
        Me.tb_Exp.MaxLength = 9
        Me.tb_Exp.Name = "tb_Exp"
        Me.tb_Exp.Size = New System.Drawing.Size(61, 20)
        Me.tb_Exp.TabIndex = 30
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rb_Blue)
        Me.GroupBox4.Controls.Add(Me.rb_Red)
        Me.GroupBox4.Location = New System.Drawing.Point(251, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(65, 65)
        Me.GroupBox4.TabIndex = 60
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Version"
        '
        'rb_Blue
        '
        Me.rb_Blue.AutoSize = True
        Me.rb_Blue.Location = New System.Drawing.Point(6, 42)
        Me.rb_Blue.Name = "rb_Blue"
        Me.rb_Blue.Size = New System.Drawing.Size(52, 17)
        Me.rb_Blue.TabIndex = 1
        Me.rb_Blue.TabStop = True
        Me.rb_Blue.Text = "Bleue"
        Me.rb_Blue.UseVisualStyleBackColor = True
        '
        'rb_Red
        '
        Me.rb_Red.AutoSize = True
        Me.rb_Red.Location = New System.Drawing.Point(6, 19)
        Me.rb_Red.Name = "rb_Red"
        Me.rb_Red.Size = New System.Drawing.Size(57, 17)
        Me.rb_Red.TabIndex = 0
        Me.rb_Red.TabStop = True
        Me.rb_Red.Text = "Rouge"
        Me.rb_Red.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Argent :"
        '
        'nud_Badges
        '
        Me.nud_Badges.Location = New System.Drawing.Point(57, 66)
        Me.nud_Badges.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.nud_Badges.Name = "nud_Badges"
        Me.nud_Badges.Size = New System.Drawing.Size(30, 20)
        Me.nud_Badges.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Badges :"
        '
        'tb_Money
        '
        Me.tb_Money.Location = New System.Drawing.Point(52, 40)
        Me.tb_Money.MaxLength = 9
        Me.tb_Money.Name = "tb_Money"
        Me.tb_Money.Size = New System.Drawing.Size(61, 20)
        Me.tb_Money.TabIndex = 10
        '
        'tb_Name
        '
        Me.tb_Name.AcceptsReturn = True
        Me.tb_Name.BackColor = System.Drawing.SystemColors.Control
        Me.tb_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Name.Location = New System.Drawing.Point(39, 14)
        Me.tb_Name.MaxLength = 8
        Me.tb_Name.Name = "tb_Name"
        Me.tb_Name.Size = New System.Drawing.Size(100, 20)
        Me.tb_Name.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.tb_Name, "Presser Entrée pour valider ou Échap pour annuler.")
        Me.tb_Name.Visible = False
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Name.Location = New System.Drawing.Point(38, 16)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(0, 13)
        Me.lbl_Name.TabIndex = 43
        Me.ToolTip1.SetToolTip(Me.lbl_Name, "Double-cliquer pour changer, puis presser Entrée pour valider ou Échap pour annul" & _
                "er.")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Nom :"
        '
        'b_DelOrCreateProfile
        '
        Me.b_DelOrCreateProfile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.b_DelOrCreateProfile.Enabled = False
        Me.b_DelOrCreateProfile.Location = New System.Drawing.Point(334, 144)
        Me.b_DelOrCreateProfile.Name = "b_DelOrCreateProfile"
        Me.b_DelOrCreateProfile.Size = New System.Drawing.Size(85, 23)
        Me.b_DelOrCreateProfile.TabIndex = 1000
        Me.b_DelOrCreateProfile.Tag = "Del"
        Me.b_DelOrCreateProfile.Text = "Effacer Profil"
        Me.b_DelOrCreateProfile.UseVisualStyleBackColor = True
        '
        'lbl_ProgramVersion
        '
        Me.lbl_ProgramVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_ProgramVersion.AutoSize = True
        Me.lbl_ProgramVersion.Location = New System.Drawing.Point(12, 517)
        Me.lbl_ProgramVersion.Name = "lbl_ProgramVersion"
        Me.lbl_ProgramVersion.Size = New System.Drawing.Size(287, 13)
        Me.lbl_ProgramVersion.TabIndex = 1001
        Me.lbl_ProgramVersion.Text = "Pokémon Tower Defense Save Editor v{version} - by M@T"
        '
        'llbl_Website
        '
        Me.llbl_Website.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.llbl_Website.AutoSize = True
        Me.llbl_Website.Location = New System.Drawing.Point(12, 530)
        Me.llbl_Website.Name = "llbl_Website"
        Me.llbl_Website.Size = New System.Drawing.Size(82, 13)
        Me.llbl_Website.TabIndex = 1003
        Me.llbl_Website.TabStop = True
        Me.llbl_Website.Text = "PTD v2.7 alpha"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 552)
        Me.Controls.Add(Me.llbl_Website)
        Me.Controls.Add(Me.lbl_ProgramVersion)
        Me.Controls.Add(Me.b_DelOrCreateProfile)
        Me.Controls.Add(Me.gb_Data)
        Me.Controls.Add(Me.gb_Login)
        Me.Controls.Add(Me.gb_Profiles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Pokémon Tower Defense Save Editor v{version} - by M@T"
        Me.gb_Profiles.ResumeLayout(False)
        Me.gb_Profiles.PerformLayout()
        Me.gb_Login.ResumeLayout(False)
        Me.gb_Login.PerformLayout()
        Me.gb_Data.ResumeLayout(False)
        Me.gb_Data.PerformLayout()
        CType(Me.nud_Challenge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_Attempted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_Unlocked, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_Pokemon.ResumeLayout(False)
        Me.gb_Pokemon.PerformLayout()
        Me.gb_GenerateCode.ResumeLayout(False)
        Me.gb_GenerateCode.PerformLayout()
        Me.gb_Moves.ResumeLayout(False)
        Me.gb_Moves.PerformLayout()
        CType(Me.nud_Level, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.nud_Badges, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents b_ImportAccount As System.Windows.Forms.Button
    Friend WithEvents tb_Email As System.Windows.Forms.TextBox
    Friend WithEvents tb_Pass As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gb_Profiles As System.Windows.Forms.GroupBox
    Friend WithEvents rb_Profile3 As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Profile2 As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Profile1 As System.Windows.Forms.RadioButton
    Friend WithEvents gb_Login As System.Windows.Forms.GroupBox
    Friend WithEvents gb_Data As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Name As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tb_Name As System.Windows.Forms.TextBox
    Friend WithEvents nud_Badges As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tb_Money As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_Blue As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Red As System.Windows.Forms.RadioButton
    Friend WithEvents gb_Pokemon As System.Windows.Forms.GroupBox
    Friend WithEvents lb_Team As System.Windows.Forms.ListBox
    Friend WithEvents lbl_Status As System.Windows.Forms.Label
    Friend WithEvents cb_Specie As System.Windows.Forms.ComboBox
    Friend WithEvents b_SavePoke As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nud_Level As System.Windows.Forms.NumericUpDown
    Friend WithEvents tb_Exp As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_ID As System.Windows.Forms.Label
    Friend WithEvents cb_Shiny As System.Windows.Forms.CheckBox
    Friend WithEvents gb_Moves As System.Windows.Forms.GroupBox
    Friend WithEvents cb_Move4 As System.Windows.Forms.ComboBox
    Friend WithEvents cb_Move3 As System.Windows.Forms.ComboBox
    Friend WithEvents cb_Move2 As System.Windows.Forms.ComboBox
    Friend WithEvents cb_Move1 As System.Windows.Forms.ComboBox
    Friend WithEvents rb_SelMove4 As System.Windows.Forms.RadioButton
    Friend WithEvents rb_SelMove2 As System.Windows.Forms.RadioButton
    Friend WithEvents rb_SelMove3 As System.Windows.Forms.RadioButton
    Friend WithEvents rb_SelMove1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents nud_Attempted As System.Windows.Forms.NumericUpDown
    Friend WithEvents nud_Unlocked As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents b_SaveProfile As System.Windows.Forms.Button
    Friend WithEvents b_EditInv As System.Windows.Forms.Button
    Friend WithEvents b_SaveAccount As System.Windows.Forms.Button
    Friend WithEvents b_PokeDown As System.Windows.Forms.Button
    Friend WithEvents b_PokeUp As System.Windows.Forms.Button
    Friend WithEvents b_DelPoke As System.Windows.Forms.Button
    Friend WithEvents b_AddPoke As System.Windows.Forms.Button
    Friend WithEvents b_DelOrCreateProfile As System.Windows.Forms.Button
    Friend WithEvents lbl_ProgramVersion As System.Windows.Forms.Label
    Friend WithEvents llbl_Website As System.Windows.Forms.LinkLabel
    Friend WithEvents nud_Challenge As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cb_ShinyGeodude As System.Windows.Forms.CheckBox
    Friend WithEvents b_Duplicate As System.Windows.Forms.Button
    Friend WithEvents b_Events As System.Windows.Forms.Button
    Friend WithEvents lbl_NotYetImplemented As System.Windows.Forms.Label
    Friend WithEvents cb_Jynx As System.Windows.Forms.CheckBox
    Friend WithEvents gb_GenerateCode As System.Windows.Forms.GroupBox
    Friend WithEvents b_GenerateCode As System.Windows.Forms.Button
    Friend WithEvents tb_SecurityCode As System.Windows.Forms.TextBox
    Friend WithEvents tb_PreviewCode As System.Windows.Forms.TextBox
    Friend WithEvents b_CopyCode As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lbl_MaxLevel As System.Windows.Forms.Label
    Friend WithEvents lbl_MaxExp As System.Windows.Forms.Label

End Class