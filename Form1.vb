Imports System.Security.Cryptography

Public Class Form1

    Public Fragen(15, 7) As String
    Public FrageNr As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrageNr = 1
        'Fragen
        Fragen(1, 1) = "Zu vorgerückter Stunde beeilten sich die Wanderer, damit sie es noch vor Einbruch der Dunkelheit bis zum nächsten ...?"
        Fragen(2, 1) = "Wühlt der Hund mit seinem Gesicht im Schnee, ist er danach sozusagen ...?"
        Fragen(3, 1) = "Wem während des Einkaufs der Drahtesel gestohlen wird, der steht vor dem Laden erst mal völlig ...?"
        Fragen(4, 1) = "Wovon findet man die Version mit 'W' am Anfang beim Einkaufen oft im selben Regal?"
        Fragen(5, 1) = "Welche Präposition ist auch für Weinkenner nicht weit hergeholt?"
        Fragen(6, 1) = "Was stieg mit Jahresbeginn 2023 auf 250 Euro im Monat?"
        Fragen(7, 1) = "Wer gehört zu den Kolleginnen von Merle Frohms, Giulia Gwinn, Lina Magull, Sara Däbritz und Marina Hegering?"
        Fragen(8, 1) = "Wer ist ständiger Begleiter von Wednesday aus der Addams Family, der derzeit wohl angesagtesten Serien-Teenagerin?"
        Fragen(9, 1) = "Wie nennt der Engländer seine Vermieterin?"
        Fragen(10, 1) = "Abstimmungskrimi in Washington: Wer brauchte 2023 ganze 15 Wahlgänge, um Sprecher des Repräsentantenhauses zu werden??"
        Fragen(11, 1) = "Welche Videospielreihe wird nach fast 30 Jahren ab 2023 nicht mehr von EA SPORTS unter diesem Namen weitergeführt?"
        Fragen(12, 1) = "Im Medizinerlatein heißt ...?"
        Fragen(13, 1) = "Auf wie viele heutige Staaten verteilen sich die Standorte der sieben Weltwunder der Antike?"
        Fragen(14, 1) = "Bibi Blocksberg heißt eigentlich ...?"
        Fragen(15, 1) = "Wo fand 2016 zum bislang letzten Mal ein Formel-1-Rennen um den Großen Preis von Europa statt?     "

        'Antworten
        Fragen(1, 2) = "Klein stätte"
        Fragen(1, 3) = "Siedlunngen"
        Fragen(1, 4) = "Ort schafften"
        Fragen(1, 5) = "Kuh dörfer"

        Fragen(2, 2) = "erbarmungslos"
        Fragen(2, 3) = "abgebrüht"
        Fragen(2, 4) = "unnachgiebig"
        Fragen(2, 5) = "kaltschnäuzig"

        Fragen(3, 2) = "schutslos"
        Fragen(3, 3) = "radlos"
        Fragen(3, 4) = "plahnlos"
        Fragen(3, 5) = "hillflos"

        Fragen(4, 2) = "Vollmilchschokolade"
        Fragen(4, 3) = "Vollkornbrot"
        Fragen(4, 4) = "Vollwaschmittel"
        Fragen(4, 5) = "Vollwertmüsli"

        Fragen(5, 2) = "mosel"
        Fragen(5, 3) = "ahr"
        Fragen(5, 4) = "nahe"
        Fragen(5, 5) = "rhein"

        Fragen(6, 2) = "Rundfunkbeitrag"
        Fragen(6, 3) = "Hundesteuer"
        Fragen(6, 4) = "Kindergeld"
        Fragen(6, 5) = "m²-Mietpreis in München"

        Fragen(7, 2) = "Annalena Baerbock"
        Fragen(7, 3) = "Alexandra Popp"
        Fragen(7, 4) = "Jil Sander"
        Fragen(7, 5) = "Cornelia Poletto"

        Fragen(8, 2) = "Laufendes Näschen"
        Fragen(8, 3) = "Eiskaltes Händchen"
        Fragen(8, 4) = "Zuckendes Äuglein"
        Fragen(8, 5) = "Stinkendes Füßchen"

        Fragen(9, 2) = "landlady"
        Fragen(9, 3) = "villagequeen"
        Fragen(9, 4) = "citymadam"
        Fragen(9, 5) = "townmiss"

        Fragen(10, 2) = "Nixon"
        Fragen(10, 3) = "Eisenhower"
        Fragen(10, 4) = "McCarthy"
        Fragen(10, 5) = "Hoover"

        Fragen(11, 2) = "Grand Theft Auto"
        Fragen(11, 3) = "Die Sims"
        Fragen(11, 4) = "FIFA"
        Fragen(11, 5) = "Super Mario Kart"

        Fragen(12, 2) = "die Aschelhöhle Axilla"
        Fragen(12, 3) = "die Kniekehle Knillia"
        Fragen(12, 4) = "die Ohrmuschel Orilla"
        Fragen(12, 5) = "der Bauchnabel Nabilla"

        Fragen(13, 2) = "zwei"
        Fragen(13, 3) = "drei"
        Fragen(13, 4) = "vier"
        Fragen(13, 5) = "fünf"

        Fragen(14, 2) = "Barbara"
        Fragen(14, 3) = "Brigitte"
        Fragen(14, 4) = "Bianca"
        Fragen(14, 5) = "Beatrix"

        Fragen(15, 2) = "Baku"
        Fragen(15, 3) = "Valencia"
        Fragen(15, 4) = "Nürburgring"
        Fragen(15, 5) = "Spa-Francorchamps"
        'Richtige Antwort
        Fragen(1, 6) = "C"
        Fragen(2, 6) = "D"
        Fragen(3, 6) = "B"
        Fragen(4, 6) = "C"
        Fragen(5, 6) = "C"
        Fragen(6, 6) = "C"
        Fragen(7, 6) = "B"
        Fragen(8, 6) = "B"
        Fragen(9, 6) = "A"
        Fragen(10, 6) = "C"
        Fragen(11, 6) = "C"
        Fragen(12, 6) = "A"
        Fragen(13, 6) = "C"
        Fragen(14, 6) = "B"
        Fragen(15, 6) = "A"

        'value
        Fragen(1, 7) = "50"
        Fragen(2, 7) = "100"
        Fragen(3, 7) = "200"
        Fragen(4, 7) = "300"
        Fragen(5, 7) = "500"
        Fragen(6, 7) = "1000"
        Fragen(7, 7) = "2000"
        Fragen(8, 7) = "4000"
        Fragen(9, 7) = "8000"
        Fragen(10, 7) = "16000"
        Fragen(11, 7) = "32000"
        Fragen(12, 7) = "64000"
        Fragen(13, 7) = "125000"
        Fragen(14, 7) = "500000"
        Fragen(15, 7) = "1000000"

    End Sub

    Public Function TryAnswer(ByVal answer As String) As Boolean
        CMD_Aufhoeren.Enabled = False
        If Fragen(FrageNr, 6) = answer Then
            CorrectAnswer()
            Return True
        End If

        WrongAnswer()
        Return False
    End Function

    Public Sub WrongAnswer()
        CMD_AntwortA.Enabled = False
        CMD_AntwortB.Enabled = False
        CMD_AntwortC.Enabled = False
        CMD_AntwortD.Enabled = False
        FrageNr = 1
        EndGame(False)
        CMD_Weiter.Text = "Versuche es erneut"

    End Sub
    Public Sub CorrectAnswer()
        CMD_AntwortA.Enabled = False
        CMD_AntwortB.Enabled = False
        CMD_AntwortC.Enabled = False
        CMD_AntwortD.Enabled = False

        FrageNr = FrageNr + 1
        If FrageNr >= 16 Then
            EndGame(True)
        Else
            CMD_Weiter.Visible = True
        End If
    End Sub

    Public Sub EndGame(ByVal win As Boolean)

        CMD_Weiter.Visible = True

        LBL_Telefon_Joker.Text = ""
        LBL_Zuschauer_Joker.Text = ""

        If win Then
            TXT_Frage.Text = "Du hast gewonnen!"
            FrageNr = 1
            CMD_Weiter.Text = "Nochmal Spielen"
        Else
            TXT_Frage.Text = "Du hast verloren!"
        End If
    End Sub

    Public Sub LoadData()

        CMD_AntwortA.Enabled = True
        CMD_AntwortB.Enabled = True
        CMD_AntwortC.Enabled = True
        CMD_AntwortD.Enabled = True

        CMD_AntwortA.Visible = True
        CMD_AntwortB.Visible = True
        CMD_AntwortC.Visible = True
        CMD_AntwortD.Visible = True

        CMD_50_50_Joker.Visible = True
        CMD_Telefon_Joker.Visible = True
        CMD_Zuschauer_Joker.Visible = True
        LBL_Joker.Visible = True

        LBL_Telefon_Joker.Text = ""
        LBL_Zuschauer_Joker.Text = ""

        CMD_Aufhoeren.Visible = True
        CMD_Start.Visible = False
        TXT_Frage.Visible = True
        LBL_FrageNr.Visible = True
        LBL_Gewinn.Visible = True

        Dim AntwortA As String
        Dim AntwortB As String
        Dim AntwortC As String
        Dim AntwortD As String

        TXT_Frage.Text = Fragen(FrageNr, 1)
        AntwortA = "A: " + Fragen(FrageNr, 2)
        AntwortB = "B: " + Fragen(FrageNr, 3)
        AntwortC = "C: " + Fragen(FrageNr, 4)
        AntwortD = "D: " + Fragen(FrageNr, 5)

        CMD_AntwortA.Text = AntwortA
        CMD_AntwortB.Text = AntwortB
        CMD_AntwortC.Text = AntwortC
        CMD_AntwortD.Text = AntwortD

        CMD_AntwortA.BackColor = Color.DodgerBlue
        CMD_AntwortB.BackColor = Color.DodgerBlue
        CMD_AntwortC.BackColor = Color.DodgerBlue
        CMD_AntwortD.BackColor = Color.DodgerBlue

        CMD_Weiter.Text = "Weiter"
        LBL_FrageNr.Text = "Frage: " + Str(FrageNr)
        LBL_Gewinn.Text = Fragen(FrageNr, 7) + " €"
        CMD_Aufhoeren.Enabled = True

    End Sub

    Private Sub CMD_AntwortA_Click(sender As Object, e As EventArgs) Handles CMD_AntwortA.Click
        If TryAnswer("A") Then
            CMD_AntwortA.BackColor = Color.Green
        Else
            CMD_AntwortA.BackColor = Color.Red
        End If
    End Sub

    Private Sub CMD_AntwortB_Click(sender As Object, e As EventArgs) Handles CMD_AntwortB.Click
        If TryAnswer("B") Then
            CMD_AntwortB.BackColor = Color.Green
        Else
            CMD_AntwortB.BackColor = Color.Red
        End If
    End Sub

    Private Sub CMD_AntwortC_Click(sender As Object, e As EventArgs) Handles CMD_AntwortC.Click
        If TryAnswer("C") Then
            CMD_AntwortC.BackColor = Color.Green
        Else
            CMD_AntwortC.BackColor = Color.Red
        End If
    End Sub

    Private Sub CMD_AntwortD_Click(sender As Object, e As EventArgs) Handles CMD_AntwortD.Click
        If TryAnswer("D") Then
            CMD_AntwortD.BackColor = Color.Green
        Else
            CMD_AntwortD.BackColor = Color.Red
        End If
    End Sub

    Private Sub CMD_Start_Click(sender As Object, e As EventArgs) Handles CMD_Start.Click
        LoadData()
    End Sub

    Private Sub CMD_Weiter_Click(sender As Object, e As EventArgs) Handles CMD_Weiter.Click
        If CMD_Weiter.Text = "Weiter" Then
            LoadData()
        Else
            FrageNr = 1
            LoadData()
            CMD_50_50_Joker.Enabled = True
            CMD_Telefon_Joker.Enabled = True
            CMD_Zuschauer_Joker.Enabled = True
        End If

    End Sub

    Private Sub CMD_50_50_Joker_Click(sender As Object, e As EventArgs) Handles CMD_50_50_Joker.Click
        CMD_50_50_Joker.Enabled = False
        Randomize()
        Dim wrongAnswer1 As String = "ABCD"(Int(Rnd() * 4))
        Dim wrongAnswer2 As String = "ABCD"(Int(Rnd() * 4))

        While wrongAnswer1 = Fragen(FrageNr, 6)
            wrongAnswer1 = "ABCD"(Int(Rnd() * 4))
        End While

        While wrongAnswer2 = Fragen(FrageNr, 6) Or wrongAnswer2 = wrongAnswer1
            wrongAnswer2 = "ABCD"(Int(Rnd() * 4))
        End While

        If wrongAnswer1 = "A" Then
            CMD_AntwortA.Visible = False
        ElseIf wrongAnswer1 = "B" Then
            CMD_AntwortB.Visible = False
        ElseIf wrongAnswer1 = "C" Then
            CMD_AntwortC.Visible = False
        ElseIf wrongAnswer1 = "D" Then
            CMD_AntwortD.Visible = False
        End If

        If wrongAnswer2 = "A" Then
            CMD_AntwortA.Visible = False
        ElseIf wrongAnswer2 = "B" Then
            CMD_AntwortB.Visible = False
        ElseIf wrongAnswer2 = "C" Then
            CMD_AntwortC.Visible = False
        ElseIf wrongAnswer2 = "D" Then
            CMD_AntwortD.Visible = False
        End If

    End Sub

    Private Sub CMD_Telefon_Joker_Click(sender As Object, e As EventArgs) Handles CMD_Telefon_Joker.Click
        Dim Answer As String
        CMD_Telefon_Joker.Enabled = False
        If Rnd() < 0.9 Then
            Answer = Fragen(FrageNr, 6)
        Else
            Answer = "ABCD"(Int(Rnd() * 4))
            While Answer = Fragen(FrageNr, 6)
                Answer = "ABCD"(Int(Rnd() * 4))
            End While
        End If

        LBL_Telefon_Joker.Text = Answer

    End Sub

    Private Sub CMD_Zuschauer_Joker_Click(sender As Object, e As EventArgs) Handles CMD_Zuschauer_Joker.Click
        Dim Answer As String
        CMD_Zuschauer_Joker.Enabled = False
        If Rnd() < 0.4 Then
            Answer = Fragen(FrageNr, 6)
        Else
            Answer = "ABCD"(Int(Rnd() * 4))
            While Answer = Fragen(FrageNr, 6)
                Answer = "ABCD"(Int(Rnd() * 4))
            End While
        End If

        LBL_Zuschauer_Joker.Text = Answer
    End Sub

    Private Sub CMD_Aufhoeren_Click(sender As Object, e As EventArgs) Handles CMD_Aufhoeren.Click

        CMD_AntwortA.Visible = False
        CMD_AntwortB.Visible = False
        CMD_AntwortC.Visible = False
        CMD_AntwortD.Visible = False
        CMD_50_50_Joker.Visible = False
        CMD_Telefon_Joker.Visible = False
        CMD_Zuschauer_Joker.Visible = False
        LBL_Joker.Visible = False
        LBL_Gewinn.Visible = False

        If FrageNr > 1 Then
            TXT_Frage.Text = "Du hast Aufgehört und " + Fragen(FrageNr - 1, 7) + " € gewonnen"
        Else
            TXT_Frage.Text = "Du hast Aufgehört und kein Geld gewonnen"
        End If

        CMD_Weiter.Visible = True
        CMD_Weiter.Text = "Nochmal Spielen"


    End Sub
End Class
