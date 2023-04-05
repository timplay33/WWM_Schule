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
        TXT_Frage = New TextBox()
        CMD_Start = New Button()
        CMD_AntwortC = New Button()
        CMD_AntwortB = New Button()
        CMD_AntwortD = New Button()
        LBL_FrageNr = New Label()
        LBL_Gewinn = New Label()
        CMD_Weiter = New Button()
        CMD_50_50_Joker = New Button()
        CMD_Telefon_Joker = New Button()
        LBL_Telefon_Joker = New Label()
        LBL_Zuschauer_Joker = New Label()
        CMD_Zuschauer_Joker = New Button()
        LBL_Joker = New Label()
        CMD_AntwortA = New Button()
        CMD_Aufhoeren = New Button()
        SuspendLayout()
        ' 
        ' TXT_Frage
        ' 
        TXT_Frage.Location = New Point(12, 200)
        TXT_Frage.Name = "TXT_Frage"
        TXT_Frage.Size = New Size(776, 23)
        TXT_Frage.TabIndex = 1
        TXT_Frage.Visible = False
        ' 
        ' CMD_Start
        ' 
        CMD_Start.FlatAppearance.BorderSize = 0
        CMD_Start.Location = New Point(176, 146)
        CMD_Start.Name = "CMD_Start"
        CMD_Start.Size = New Size(451, 150)
        CMD_Start.TabIndex = 2
        CMD_Start.Text = "Starten"
        CMD_Start.UseVisualStyleBackColor = True
        ' 
        ' CMD_AntwortC
        ' 
        CMD_AntwortC.FlatAppearance.BorderSize = 0
        CMD_AntwortC.FlatStyle = FlatStyle.Flat
        CMD_AntwortC.Location = New Point(12, 302)
        CMD_AntwortC.Name = "CMD_AntwortC"
        CMD_AntwortC.Size = New Size(382, 67)
        CMD_AntwortC.TabIndex = 7
        CMD_AntwortC.Text = "C"
        CMD_AntwortC.UseVisualStyleBackColor = True
        CMD_AntwortC.Visible = False
        ' 
        ' CMD_AntwortB
        ' 
        CMD_AntwortB.FlatAppearance.BorderSize = 0
        CMD_AntwortB.FlatStyle = FlatStyle.Flat
        CMD_AntwortB.Location = New Point(406, 229)
        CMD_AntwortB.Name = "CMD_AntwortB"
        CMD_AntwortB.Size = New Size(382, 67)
        CMD_AntwortB.TabIndex = 9
        CMD_AntwortB.Text = "B"
        CMD_AntwortB.UseVisualStyleBackColor = True
        CMD_AntwortB.Visible = False
        ' 
        ' CMD_AntwortD
        ' 
        CMD_AntwortD.FlatAppearance.BorderSize = 0
        CMD_AntwortD.FlatStyle = FlatStyle.Flat
        CMD_AntwortD.Location = New Point(406, 302)
        CMD_AntwortD.Name = "CMD_AntwortD"
        CMD_AntwortD.Size = New Size(382, 67)
        CMD_AntwortD.TabIndex = 10
        CMD_AntwortD.Text = "D"
        CMD_AntwortD.UseVisualStyleBackColor = True
        CMD_AntwortD.Visible = False
        ' 
        ' LBL_FrageNr
        ' 
        LBL_FrageNr.AutoSize = True
        LBL_FrageNr.Location = New Point(12, 9)
        LBL_FrageNr.Name = "LBL_FrageNr"
        LBL_FrageNr.Size = New Size(42, 15)
        LBL_FrageNr.TabIndex = 11
        LBL_FrageNr.Text = "Frage: "
        LBL_FrageNr.Visible = False
        ' 
        ' LBL_Gewinn
        ' 
        LBL_Gewinn.AutoSize = True
        LBL_Gewinn.Location = New Point(12, 169)
        LBL_Gewinn.Name = "LBL_Gewinn"
        LBL_Gewinn.Size = New Size(13, 15)
        LBL_Gewinn.TabIndex = 12
        LBL_Gewinn.Text = "€"
        LBL_Gewinn.Visible = False
        ' 
        ' CMD_Weiter
        ' 
        CMD_Weiter.FlatAppearance.BorderSize = 0
        CMD_Weiter.Location = New Point(621, 389)
        CMD_Weiter.Name = "CMD_Weiter"
        CMD_Weiter.Size = New Size(167, 49)
        CMD_Weiter.TabIndex = 13
        CMD_Weiter.Text = "Weiter"
        CMD_Weiter.UseVisualStyleBackColor = True
        CMD_Weiter.Visible = False
        ' 
        ' CMD_50_50_Joker
        ' 
        CMD_50_50_Joker.FlatAppearance.BorderSize = 0
        CMD_50_50_Joker.Location = New Point(713, 31)
        CMD_50_50_Joker.Name = "CMD_50_50_Joker"
        CMD_50_50_Joker.Size = New Size(75, 23)
        CMD_50_50_Joker.TabIndex = 14
        CMD_50_50_Joker.Text = "50:50"
        CMD_50_50_Joker.UseVisualStyleBackColor = True
        CMD_50_50_Joker.Visible = False
        ' 
        ' CMD_Telefon_Joker
        ' 
        CMD_Telefon_Joker.FlatAppearance.BorderSize = 0
        CMD_Telefon_Joker.Location = New Point(713, 60)
        CMD_Telefon_Joker.Name = "CMD_Telefon_Joker"
        CMD_Telefon_Joker.Size = New Size(75, 23)
        CMD_Telefon_Joker.TabIndex = 15
        CMD_Telefon_Joker.Text = "Telefon"
        CMD_Telefon_Joker.UseVisualStyleBackColor = True
        CMD_Telefon_Joker.Visible = False
        ' 
        ' LBL_Telefon_Joker
        ' 
        LBL_Telefon_Joker.AutoSize = True
        LBL_Telefon_Joker.Location = New Point(688, 64)
        LBL_Telefon_Joker.Name = "LBL_Telefon_Joker"
        LBL_Telefon_Joker.Size = New Size(10, 15)
        LBL_Telefon_Joker.TabIndex = 16
        LBL_Telefon_Joker.Text = " "
        ' 
        ' LBL_Zuschauer_Joker
        ' 
        LBL_Zuschauer_Joker.AutoSize = True
        LBL_Zuschauer_Joker.Location = New Point(688, 93)
        LBL_Zuschauer_Joker.Name = "LBL_Zuschauer_Joker"
        LBL_Zuschauer_Joker.Size = New Size(10, 15)
        LBL_Zuschauer_Joker.TabIndex = 18
        LBL_Zuschauer_Joker.Text = " "
        ' 
        ' CMD_Zuschauer_Joker
        ' 
        CMD_Zuschauer_Joker.FlatAppearance.BorderSize = 0
        CMD_Zuschauer_Joker.Location = New Point(713, 89)
        CMD_Zuschauer_Joker.Name = "CMD_Zuschauer_Joker"
        CMD_Zuschauer_Joker.Size = New Size(75, 23)
        CMD_Zuschauer_Joker.TabIndex = 17
        CMD_Zuschauer_Joker.Text = "Zuschauer"
        CMD_Zuschauer_Joker.UseVisualStyleBackColor = True
        CMD_Zuschauer_Joker.Visible = False
        ' 
        ' LBL_Joker
        ' 
        LBL_Joker.AutoSize = True
        LBL_Joker.Location = New Point(729, 13)
        LBL_Joker.Name = "LBL_Joker"
        LBL_Joker.Size = New Size(34, 15)
        LBL_Joker.TabIndex = 19
        LBL_Joker.Text = "Joker"
        LBL_Joker.Visible = False
        ' 
        ' CMD_AntwortA
        ' 
        CMD_AntwortA.FlatAppearance.BorderSize = 0
        CMD_AntwortA.FlatStyle = FlatStyle.Flat
        CMD_AntwortA.ForeColor = SystemColors.ControlText
        CMD_AntwortA.Location = New Point(12, 229)
        CMD_AntwortA.Name = "CMD_AntwortA"
        CMD_AntwortA.Size = New Size(382, 67)
        CMD_AntwortA.TabIndex = 21
        CMD_AntwortA.Text = "A"
        CMD_AntwortA.UseVisualStyleBackColor = True
        CMD_AntwortA.Visible = False
        ' 
        ' CMD_Aufhoeren
        ' 
        CMD_Aufhoeren.FlatAppearance.BorderSize = 0
        CMD_Aufhoeren.Location = New Point(12, 389)
        CMD_Aufhoeren.Name = "CMD_Aufhoeren"
        CMD_Aufhoeren.Size = New Size(167, 49)
        CMD_Aufhoeren.TabIndex = 22
        CMD_Aufhoeren.Text = "Aufhören"
        CMD_Aufhoeren.UseVisualStyleBackColor = True
        CMD_Aufhoeren.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DodgerBlue
        ClientSize = New Size(800, 450)
        Controls.Add(CMD_Aufhoeren)
        Controls.Add(CMD_AntwortA)
        Controls.Add(LBL_Joker)
        Controls.Add(LBL_Zuschauer_Joker)
        Controls.Add(CMD_Zuschauer_Joker)
        Controls.Add(LBL_Telefon_Joker)
        Controls.Add(CMD_Telefon_Joker)
        Controls.Add(CMD_50_50_Joker)
        Controls.Add(CMD_Weiter)
        Controls.Add(LBL_Gewinn)
        Controls.Add(LBL_FrageNr)
        Controls.Add(CMD_AntwortD)
        Controls.Add(CMD_AntwortB)
        Controls.Add(CMD_AntwortC)
        Controls.Add(CMD_Start)
        Controls.Add(TXT_Frage)
        Name = "Form1"
        Text = "Wer Wird Milionär"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TXT_Frage As TextBox
    Friend WithEvents CMD_Start As Button
    Friend WithEvents CMD_AntwortC As Button
    Friend WithEvents CMD_AntwortB As Button
    Friend WithEvents CMD_AntwortD As Button
    Friend WithEvents LBL_FrageNr As Label
    Friend WithEvents LBL_Gewinn As Label
    Friend WithEvents CMD_Weiter As Button
    Friend WithEvents CMD_50_50_Joker As Button
    Friend WithEvents CMD_Telefon_Joker As Button
    Friend WithEvents LBL_Telefon_Joker As Label
    Friend WithEvents LBL_Zuschauer_Joker As Label
    Friend WithEvents CMD_Zuschauer_Joker As Button
    Friend WithEvents LBL_Joker As Label
    Friend WithEvents CMD_AntwortA As Button
    Friend WithEvents CMD_Aufhoeren As Button
End Class
