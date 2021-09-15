Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim input As String
        Dim speak = CreateObject("sapi.spvoice")

        input = TextBox2.Text

        input = input.ToLower()
        If input.Contains("hi") Then
            TextBox1.AppendText("Hello" & vbNewLine)
            speak.speak("Hello")

        ElseIf input.Contains("say my name") Then
            TextBox1.AppendText("Mr Rohit" & vbNewLine)
            speak.speak("Your name is Mr Rohit")
        ElseIf input.Contains("who created you") Then
            TextBox1.AppendText("I'm created by Mr Rohit" & vbNewLine)
            speak.speak("I'm created by Mr Rohit")

        ElseIf input.Contains("open notepad") Then
            TextBox1.AppendText("Notepad Open Successfully" & vbNewLine)
            System.Diagnostics.Process.Start("notepad")
            speak.speak("Notepad Open Successfully")

        ElseIf input.Contains("open cmd") Then
            TextBox1.AppendText("Command Prompt Open Successfully" & vbNewLine)
            System.Diagnostics.Process.Start("cmd")
            speak.speak("Command Prompt Open Successfully")

        ElseIf input.Contains("open youtube") Then
            TextBox1.AppendText("Youtube Open Successfully" & vbNewLine)
            System.Diagnostics.Process.Start("https://www.youtube.com/")
            speak.speak("Youtube Open Successfully")

        ElseIf input.Contains("play ganesh ji song") Then
            TextBox1.AppendText("ganesh ji song stared playing Successfully" & vbNewLine)
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=QG4sWECfQJ8&list=RDMMQG4sWECfQJ8&start_radio=1")
            speak.speak("ganesh ji song  stared playing Successfully")

        ElseIf input.Contains("open chrome") Then
            TextBox1.AppendText("Chrome opened successfully" & vbNewLine)
            System.Diagnostics.Process.Start("https://www.google.com/")
            speak.speak("Chrome opened successfully")
        ElseIf input.Contains("whatsapp") Then
            TextBox1.AppendText("Whatsapp opened successfully" & vbNewLine)
            System.Diagnostics.Process.Start("https://web.whatsapp.com/")
            speak.speak("WhatsApp opened successfully")
        ElseIf input.Contains("coding blocks") Then
            TextBox1.AppendText("Coding blocks opened successfully" & vbNewLine)
            System.Diagnostics.Process.Start("https://ide.codingblocks.com/")
            speak.speak("Coding Blocks opened successfully")
        ElseIf input.Contains("repeat me") Then
            input = input.Replace("repeat me", "")
            speak.speak(input)



        ElseIf input.Contains("close") Then
            TextBox1.AppendText("Thanks Visit again" & vbNewLine)

            speak.speak("Ok Goodbye")
            Me.Close()
        Else
            TextBox1.AppendText("Wrong Command" & vbNewLine)
            speak.speak("Oops you have given wrong command")



        End If
        TextBox2.Text = ""



    End Sub
End Class
