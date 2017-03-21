Imports System.Net

Public Class Toolkit


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("C:\Windows\System32\SystemPropertiesProtection")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Restore Point was created")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Restore Point was created")
            writeFile.Close()

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Process.Start("msinfo32")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "System information was read")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("System information was read")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Process.Start("C:\TechTools\cc")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Ccleaner was run to remove temp files and remove temp files on computer")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Ccleaner was run to remove temp files and remove temp files on computer")
            writeFile.Close()

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("inetcpl.cpl")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Internet Properties was opened to check for proxy settings, reset to clear settings caused by adware, and checked for security")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Internet Properties was opened to check for proxy settings, reset to clear settings caused by adware, and checked for security")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Process.Start("C:\TechTools\geek")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Geek Uninstaller was run to perform a remove a large amount of programs and files left from uninstalled programs")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Geek Uninstaller was run to perform a remove a large amount of programs and files left from uninstalled programs")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("C:\TechTools\SA6BWRSMED559B6F854E")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Webroot was installed on the computer")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Webroot was installed on the computer")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("C:\TechTools\matrix")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "System Diagnostic was ran to check for inconsistency")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("System Diagnostic was ran to check for inconsistency")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        'Message box 1
        Dim result1 As DialogResult = MessageBox.Show("Clear Event Logs?", _
      "Event Logs?", _
          MessageBoxButtons.YesNo)

        'Message box 2
        Dim result2 As DialogResult = MessageBox.Show("Get work Form?", _
         "Whats Been Done", _
         MessageBoxButtons.YesNo)


        'Message box 3
        Dim result3 As DialogResult = MessageBox.Show("Send Work Complete Page?", _
        "Work Complete", _
        MessageBoxButtons.YesNo)

        'Message box 4
        Dim result4 As DialogResult = MessageBox.Show("Uninstall Toolkit?", _
      "Uninstall?", _
          MessageBoxButtons.YesNo)

        ' Message box 1 results
        ' Here are the Clear Event Logs results
        If result1 = DialogResult.Yes Then Process.Start("C:\TechTools\ev.bat")
        result1 = DialogResult.No
        MessageBox.Show("Event Logs not cleared") 'Another dialog.

        'Message box 2 results
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If result2 = DialogResult.Yes Then
            Process.Start("C:\TechTools\done.txt")
            result2 = DialogResult.No
            MessageBox.Show("Work Form Saved") 'Another dialog.

        End If
        'Message box 3 results
        If result3 = DialogResult.Yes Then Process.Start("C:\TechTools\Work Completed")
        result3 = DialogResult.No
        MessageBox.Show("Work Not Yet Completed") 'Another dialog.


        ' Message box 4 results
        ' Here are the Clear Event Logs results
        If result4 = DialogResult.Yes & result1 = DialogResult.No & result2 = DialogResult.No & result3 = DialogResult.No Then My.Computer.FileSystem.DeleteDirectory("C:\Tools", _
FileIO.DeleteDirectoryOption.DeleteAllContents)
        result4 = DialogResult.No
        MessageBox.Show("Toolkit still on computer")
        'Another dialog.
        If result4 = DialogResult.Yes Then End

        'Process.Start("C:\TechTools\ev")
        'Process.Start("C:\Work Completed")
        'Process.Start("C:\TechTools\done.txt")

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Process.Start("C:\TechTools\TTWIP")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Work in Progress Screen was sent to remote computer")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Work in Progress Screen was sent to remote computer")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("C:\TechTools\Contact Us")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Request was sent for customer to call us back")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Request was sent for customer to call us back")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("C:\TechTools\autoruns")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Autoruns was ran to configure what programs are configured to run during system bootup or login, and shows you the entries in the order Windows processes them")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Autoruns was ran to configure what programs are configured to run during system bootup or login, and shows you the entries in the order Windows processes them")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("C:\TechTools\BlueScreenView")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Blue Screen view was run to check for stop errors codes")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Blue Screen view was run to check for stop errors codes")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("https://www.malwarebytes.org/antiexploit/")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Malwarebytes Anti Exploit was installed to help protect browsers and applications from spyware and vulnerabilities")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Malwarebytes Anti Exploit was installed to help protect browsers and applications from spyware and vulnerabilities")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("C:\TechTools\NPE")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Norton Power Eraser was used to scan for rootkits")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Norton Power Eraser was used to scan for rootkits")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("C:\TechTools\RogueKiller")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "RogueKiller was used to remove rootkits and stop services caused by infection")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("RogueKiller was used to remove rootkits and stop services caused by infection")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If System.IO.File.Exists("C:\TechTools\SystemRestoreExplorer") = True Then
            Process.Start("C:\TechTools\SystemRestoreExplorer")
        Else
            Process.Start("http://nicbedford.co.uk/files/InstallSystemRestoreExplorer.msi")
        End If
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "System Restore Explorer was ran to recover specific fodlers using Volume Shadow Copy")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("System Restore Explorer was ran to recover specific fodlers using Volume Shadow Copy")
            writeFile.Close()
        End If

    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("C:\TechTools\CintRep")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "CintRep was used to repair Internet  Explorer and troubleshoot network issues")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("CintRep was used to repair Internet  Explorer and troubleshoot network issues")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("http://support.microsoft.com/fixit")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Microsoft Fixit Center webpage was opened to find quick fixit tool")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Microsoft Fixit Center webpage was opened to find quick fixit tool")
            writeFile.Close()
        End If

    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("osk")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Onscreen Keyboard was opened")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Onscreen Keyboard was opened")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("msconfig")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Msconfig was opened")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Msconfig was opened")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("C:\TechTools\tweaking")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Tweaking was used to fix windows components commonly damaged by viruses and mlaware")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Tweaking was used to fix windows components commonly damaged by viruses and mlaware")
            writeFile.Close()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If ComboBox1.SelectedItem = "ESET" Then Process.Start("C:\TechTools\ESETUninstaller")
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Eset Uninstaller was used to remove ESET antivirus")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Eset Uninstaller was used to remove ESET antivirus")
            writeFile.Close()
        End If

        If ComboBox1.SelectedItem = "Mcafee" Then Process.Start("C:\TechTools\MCPR")
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Mcafee uninstaller was used to remove all mcafee products")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Mcafee uninstaller was used to remove all mcafee products")
            writeFile.Close()
        End If

        If ComboBox1.SelectedItem = "Microsoft Security Essentials" Then Process.Start("C:\TechTools\ms-essentials-remove")
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Microsoft Security Essentials was uninstalled")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Microsoft Security Essentials was uninstalled")
            writeFile.Close()
        End If

        If ComboBox1.SelectedItem = "Norton" Then Process.Start("C:\TechTools\Norton-Removal-Tool")
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Norton Removal Tool was used")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Norton Removal Tool was used")
            writeFile.Close()
        End If

        If ComboBox1.SelectedItem = "Panda" Then Process.Start("C:\TechTools\UNINSTALLER_08")
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Panda Antivirus removal tool was used")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Panda Antivirus removal tool was used")
            writeFile.Close()
        End If

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If ComboBox2.SelectedItem = "Rkill" Then Process.Start("C:\TechTools\rkill")
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Rkill was ran to stop and remove bad services infected by viruses")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Rkill was ran to stop and remove bad services infected by viruses")
            writeFile.Close()
        End If

        If ComboBox2.SelectedItem = "MB Chameleon" Then Process.Start("C:\TechTools\MBchameleon")
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Mbam Chameleon was ran to stop services and remove trojans")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Mbam Chameleon was ran to stop services and remove trojans")
            writeFile.Close()
        End If

        If ComboBox2.SelectedItem = "MB Antirootkit" Then Process.Start("C:\TechTools\mbar")
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Mbar was ran to scan for rootkits")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Mbar was ran to scan rootkits")
            writeFile.Close()
        End If

        If ComboBox2.SelectedItem = "NOrton Power Eraser" Then Process.Start("C:\TechTools\NPE")
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Norton Power Eraser was run to remve rootkits")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Norton Power Eraser was run to remve rootkits")
            writeFile.Close()
        End If

        If ComboBox2.SelectedItem = "Spybot S&D" Then Process.Start("C:\TechTools\")
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Spyboy was ran on computer")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Spybot was ran on computer")
            writeFile.Close()
        End If

        If ComboBox2.SelectedItem = "TDSS" Then Process.Start("C:\TechTools\tdsskiller")
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Kaspersky TDSS Killer was ran")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Kaspersky TDSS Killer was ran")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("C:\TechTools\KeyFinderInstaller")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Product keys was used to recover and save Microsoft and Windows software license keys")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Product keys was used to recover and save Microsoft and Windows software license keys")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button19_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Process.Start("C:\TechTools\mbamstartup")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Malwarebytes was installed")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Malwarebytes was installed")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("wscui.cpl")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Action Center was opened and checked")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Action Center was opened and checked")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("taskmgr")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Task Manager was opened")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Task Manager was opened")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("services.msc")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Windows Services List was opened to start,stop,disable, or restart services on remote computer")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Windows Services List was opened to start,stop,disable, or restart services on remote computer")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("control")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Control Panel was opened")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Control Panel was opened")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("powercfg.cpl")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Power Options were opened to change display and power settings")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Power Options were opened to change display and power settings")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("appwiz.cpl")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Add/Remove Programs was opened to uninstall programs and windows updates")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Add/Remove Programs was opened to uninstall programs and windows updates")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("sysdm.cpl")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "System Properties was opened")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("System Properties was opened")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("firewall.cpl")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Windows Firewall was opened")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Windows Firewall was opened")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("devmgmt.msc")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Device Manager was opened")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Device Manager was opened")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("C:\TechTools\HDTune")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "HDTune was used to check that health or remote hard drive and scan for errors in boot sectors of remote hdd")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("HDTune was used to check that health or remote hard drive and scan for errors in boot sectors of remote hdd")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button42.Click
        Process.Start("C:\TechTools\MbamGUI")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Malwarebytes was opened on computer")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Malwarebytes was opened on computer")
            writeFile.Close()
        End If

    End Sub

    Private Sub Button47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button47.Click
        Process.Start("C:\TechTools\adwcleaner")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "ADWCleaner was ran")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("ADWCleaner was ran")
            writeFile.Close()
        End If

    End Sub

    Private Sub Button48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button48.Click
        Process.Start("http://java.com/en/download/")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Java webpage was opened to update java")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Java webpage was opened to update java")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("C:\TechTools\recuva")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Recuva was installed to recover lost or deleted files")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Recuva was installed to recover lost or deleted files")
            writeFile.Close()
        End If

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub Button46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button46.Click
        Process.Start("http://get.adobe.com/flashplayer/")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Flashplayer webpage was opened to udpate Adobe Flashplayer")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Flashplayer webpage was opened to udpate Adobe Flashplayer")
            writeFile.Close()
        End If
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ComboBox3.SelectedItem = "Support" Then Process.Start("http://www.google.com")
        If ComboBox3.SelectedItem = "Printers" Then Process.Start("http://www.google.com")
        If ComboBox3.SelectedItem = "Drivers" Then Process.Start("http://www.google.com")

    End Sub

    Private Sub ComboBox12_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ComboBox12.SelectedItem = "" Then Process.Start("")

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        If ComboBox4.SelectedItem = "Default Gateway" Then Process.Start("http://192.168.0.1")
        If ComboBox4.SelectedItem = "Asus" Then Process.Start("http://support.asus.com/FAQ/detail.aspx?SLanguage=en&m=rt-n13u&p=11&s=2&os=&hashedid=O8alKdC7I2FAs2FQ&no=1FBEE9DD-59BC-0D5D-09F8-485369DCDE3A")
        If ComboBox4.SelectedItem = "Belkin" Then Process.Start("http://www.belkin.com/us/support-article?articleNum=10829")
        If ComboBox4.SelectedItem = "Cisco" Then Process.Start("http://www.cisco.com/c/en/us/td/docs/routers/access/cisco_router_and_security_device_manager/software/quick/guide/SDMq7.html")
        If ComboBox4.SelectedItem = "DLink" Then Process.Start("http://www.support.dlink.com/emulators/dir615_revb/221/login.htm")
        If ComboBox4.SelectedItem = "Motorola" Then Process.Start("http://portforward.com/default_username_password/Motorola.htm")
        If ComboBox4.SelectedItem = "Netgear" Then Process.Start("http://kb.netgear.com/app/answers/detail/a_id/1148/~/default-web-interface-password-for-netgear-devices")
        If ComboBox4.SelectedItem = "ROUTER PASSWORDS" Then Process.Start("http://www.routerpasswords.com/")
        If ComboBox4.SelectedItem = "Trendnet" Then Process.Start("http://trendnet.com/emulators/TEW-633GR/")
        If ComboBox4.SelectedItem = "Other" Then Process.Start("http://www.answersthatwork.com/Download_Area/ATW_Library/Networking/Network__4-List_of_default_Router_Admin_Passwords_and_IP_addresses.pdf")
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.SelectedItem = "Fixit Center" Then Process.Start("http://support.microsoft.com/fixit/")
        If ComboBox3.SelectedItem = "Support.Microsoft" Then Process.Start("http://www.support.microsoft.com")
        If ComboBox3.SelectedItem = "Technet" Then Process.Start("http://technet.microsoft.com/en-US/")
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        If ComboBox5.SelectedItem = "Homepage" Then Process.Start("http://us.acer.com/ac/en/US/content/home")
        If ComboBox5.SelectedItem = "Drivers and Manuals" Then Process.Start("http://us.acer.com/ac/en/US/content/drivers")
        If ComboBox5.SelectedItem = "Support" Then Process.Start("http://www.acer.com/worldwide/support/")
        If ComboBox5.SelectedItem = "Tablets" Then Process.Start("http://us.acer.com/ac/en/US/content/group/tablets")
        If ComboBox5.SelectedItem = "Laptops" Then Process.Start("http://us.acer.com/ac/en/US/content/group/laptops")
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox6.SelectedIndexChanged
        If ComboBox6.SelectedItem = "Homepage" Then Process.Start("http://www.alienware.com/")
        If ComboBox6.SelectedItem = "Desktop" Then Process.Start("http://www.alienware.com/Landings/desktops.aspx")
        If ComboBox6.SelectedItem = "Drivers" Then Process.Start("http://support.alienware.com/Support_Pages/Restricted_Pages/driver_downloads.aspx")
        If ComboBox6.SelectedItem = "Gaming Services" Then Process.Start("http://www.alienware.com/gamingservices/")
        If ComboBox6.SelectedItem = "Laptops" Then Process.Start("http://www.alienware.com/Landings/laptops.aspx")
    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox7.SelectedIndexChanged
        If ComboBox7.SelectedItem = "Homepage" Then Process.Start("https://www.asus.com/us/")
        If ComboBox7.SelectedItem = "Drivers" Then Process.Start("http://support.asus.com/download/options.aspx?SLanguage=en&type=1")
        If ComboBox7.SelectedItem = "Downloads" Then Process.Start("http://www.service.asus.com/#!downloads/c1wax")
        If ComboBox7.SelectedItem = "Support" Then Process.Start("http://support.asus.com/ServiceHome.aspx?SLanguage=en")
    End Sub

    Private Sub ComboBox9_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox9.SelectedIndexChanged
        If ComboBox9.SelectedItem = "Homepage" Then Process.Start("http://www.dell.com/")
        If ComboBox9.SelectedItem = "Drivers & Downloads" Then Process.Start("http://www.dell.com/support/home/us/en/04?c=us&l=en&s=bsd")
        If ComboBox9.SelectedItem = "Product Search" Then Process.Start("http://www.dell.com/support/drivers/us/en/19/ProductSelector")
        If ComboBox9.SelectedItem = "Support" Then Process.Start("http://www.dell.com/support/contents/us/en/04/category/Product-Support/Self-support-Knowledgebase/software-and-downloads?c=us&l=en&s=bsd&~ck=mn")

    End Sub

    Private Sub ComboBox10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox10.SelectedIndexChanged
        If ComboBox10.SelectedItem = "Homepage" Then Process.Start("http://www.emachines.com/ec/en/US/content/home")
        If ComboBox10.SelectedItem = "Download Center" Then Process.Start("http://www.emachines.com/ec/en/US/content/drivers")
        If ComboBox10.SelectedItem = "Support" Then Process.Start("http://www.emachines.com/ec/en/US/content/support")

    End Sub

    Private Sub ComboBox11_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox11.SelectedIndexChanged
        If ComboBox11.SelectedItem = "Homepage" Then Process.Start("http://us.gateway.com/gw/en/US/content/home")
        If ComboBox11.SelectedItem = "Desktop" Then Process.Start("http://us.gateway.com/gw/en/US/content/group/desktops")
        If ComboBox11.SelectedItem = "Displays" Then Process.Start("http://us.gateway.com/gw/en/US/content/group/monitors")
        If ComboBox11.SelectedItem = "Drivers and Download" Then Process.Start("http://us.gateway.com/gw/en/US/content/drivers-downloads")
        If ComboBox11.SelectedItem = "Notebooks" Then Process.Start("http://us.gateway.com/gw/en/US/content/group/notebooks")
        If ComboBox11.SelectedItem = "Support" Then Process.Start("http://us.gateway.com/gw/en/US/content/support-overview")
    End Sub

    Private Sub ComboBox12_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox12.SelectedIndexChanged
        If ComboBox12.SelectedItem = "Homepage" Then Process.Start("http://www.hp.com/country/us/en/hho/welcome.html")
        If ComboBox12.SelectedItem = "Drivers and Download" Then Process.Start("http://www8.hp.com/us/en/drivers.html")
        If ComboBox12.SelectedItem = "Support" Then Process.Start("http://www8.hp.com/us/en/contact-hp/contact.html")
        If ComboBox12.SelectedItem = "Utilities" Then Process.Start("http://h10025.www1.hp.com/ewfrf/wc/softwareDownloadIndex?cc=us&lc=en&softwareitem=ob-109908-1")
    End Sub

    Private Sub ComboBox14_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox14.SelectedIndexChanged
        If ComboBox14.SelectedItem = "Homepage" Then Process.Start("http://www.toshiba.com/tai/")
        If ComboBox14.SelectedItem = "Support and Drivers" Then Process.Start("http://support.toshiba.com/")
    End Sub

    Private Sub ComboBox16_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox16.SelectedIndexChanged
        If ComboBox16.SelectedItem = "Homepage" Then Process.Start("http://www.samsung.com/us/")
        If ComboBox16.SelectedItem = "Drivers and Support" Then Process.Start("http://www.samsung.com/us/support/downloads")
        If ComboBox16.SelectedItem = "Kies Software" Then Process.Start("http://www.samsung.com/in/support/usefulsoftware/KIES/JSP")
    End Sub

    Private Sub Button49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button49.Click
        Process.Start("http://www.apple.com/itunes/download/")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Itunes page was opened to download or install latest version of Itunes")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Itunes page was opened to download or install latest version of Itunes")
            writeFile.Close()
        End If

    End Sub

    Private Sub Button50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button50.Click
        Process.Start("http://ninite.com/")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Itunes page was opened to download or install latest version of Itunes")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Itunes page was opened to download or install latest version of Itunes")
            writeFile.Close()
        End If

    End Sub

    Private Sub Button51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox8_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox8.SelectedIndexChanged
        If ComboBox8.SelectedItem = "ALL POP AND SMTP" Then Process.Start("http://www.serversmtp.com/en/server-pop-smtp")
        If ComboBox8.SelectedItem = "Inbox Repair Tool" Then Process.Start("http://support.microsoft.com/kb/272227")
        If ComboBox8.SelectedItem = "POP Setup" Then Process.Start("http://www.networksolutions.com/support/step-by-step-pop-setup-instructions/#3")
        If ComboBox8.SelectedItem = "Outlook POP and IMAP" Then Process.Start("http://products.secureserver.net/email/email_outlook.htm")
        If ComboBox8.SelectedItem = "Scanpst repair tip" Then Process.Start("http://www.howto-outlook.com/faq/usingscanpst.htm")
        If ComboBox8.SelectedItem = "Thunderbird manul config" Then Process.Start("https://support.mozilla.org/en-US/kb/manual-account-configuration")

    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("C:\Windows\system32\rstrui.exe")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Itunes page was opened to download or install latest version of Itunes")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Itunes page was opened to download or install latest version of Itunes")
            writeFile.Close()
        End If
    End Sub

    Private Sub CheckBox41_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub WhatsBeenDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Toolkit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Process.Start("C:\TechTools\done.txt")
        Else

            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            MsgBox("Nothing has been done yet")
            writeFile.Close()


        End If



    End Sub

    Private Sub Button51_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Computer.Network.DownloadFile("https://drive.google.com/#folders/0B_xFz3heWW-JMkV5aWY4a0R3eDg", "C:\TechTools\Norton-Removal-Tool")
        Dim FILE_NAME As String = "C:\TechTools\Norton-Removal-Tool"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Process.Start("C:\TechTools\Norton-Removal-Tool")
        Else

        End If

        Dim writeFile As IO.StreamWriter
        writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
        MsgBox("File not downloaded yet")
        writeFile.Close()
    End Sub


    Private Sub Button7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Process.Start("C:\TechTools\matrix")
    End Sub

    Private Sub Button13_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Dim FileToDelete As String

        FileToDelete = "C:\TechTools\done.txt"

        If System.IO.File.Exists(FileToDelete) = True Then

            System.IO.File.Delete(FileToDelete)
            MsgBox("Work order cleared")

        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button41_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("C:\TechTools\BlueScreenView")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Blue Screen view was run to check for stop errors codes")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Blue Screen view was run to check for stop errors codes")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("C:\TechTools\autoruns")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Autoruns was ran to configure what programs are configured to run during system bootup or login, and shows you the entries in the order Windows processes them")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Autoruns was ran to configure what programs are configured to run during system bootup or login, and shows you the entries in the order Windows processes them")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button51_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("C:\TechTools\CintRep")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "CintRep was used to repair Internet  Explorer and troubleshoot network issues")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("CintRep was used to repair Internet  Explorer and troubleshoot network issues")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("C:\TechTools\NPE")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Norton Power Eraser was used to scan for rootkits")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Norton Power Eraser was used to scan for rootkits")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button16_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("C:\TechTools\HDTune")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "HDTune was used to check that health or remote hard drive and scan for errors in boot sectors of remote hdd")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("HDTune was used to check that health or remote hard drive and scan for errors in boot sectors of remote hdd")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("C:\TechTools\KeyFinderInstaller")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Product keys was used to recover and save Microsoft and Windows software license keys")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Product keys was used to recover and save Microsoft and Windows software license keys")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("C:\TechTools\recuva")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Recuva was installed to recover lost or deleted files")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Recuva was installed to recover lost or deleted files")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("C:\TechTools\RogueKiller")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "RogueKiller was used to remove rootkits and stop services caused by infection")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("RogueKiller was used to remove rootkits and stop services caused by infection")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("osk")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Onscreen Keyboard was opened")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Onscreen Keyboard was opened")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("msconfig")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Msconfig was opened")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Msconfig was opened")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("powercfg.cpl")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Power Options were opened to change display and power settings")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Power Options were opened to change display and power settings")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("wscui.cpl")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Action Center was opened and checked")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Action Center was opened and checked")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("appwiz.cpl")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Add/Remove Programs was opened to uninstall programs and windows updates")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Add/Remove Programs was opened to uninstall programs and windows updates")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("firewall.cpl")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Windows Firewall was opened")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Windows Firewall was opened")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("devmgmt.msc")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Device Manager was opened")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Device Manager was opened")
            writeFile.Close()
        End If
    End Sub

    Private Sub Button58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("sysdm.cpl")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "System Properties was opened")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("System Properties was opened")
            writeFile.Close()
        End If
    End Sub

    Private Sub Label21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Process.Start("C:\TechTools\Quick Nav")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Quick Nav tools were ran")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Quick Nav tools were ran")
            writeFile.Close()

        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Process.Start("C:\TechTools\Quick Nav")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Quick Nav tools")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Quick Nav tools")
            writeFile.Close()

        End If
    End Sub

    Private Sub Button16_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Process.Start("C:\TechTools\done.txt")
        Else

            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            MsgBox("Nothing has been done yet")
            writeFile.Close()


        End If
    End Sub

    Private Sub Button18_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Process.Start("C:\TechTools\Advanced Tools")
        Dim FILE_NAME As String = "C:\TechTools\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Advanced Tools were ran during the repair")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Advanced Tools were ran during the repair")
            writeFile.Close()
        End If
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Process.Start("https://twitter.com/TechGameTeddy")

    End Sub

    Private Sub recuva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles recuva.Click
        Dim download = New WebClient
        Dim CheckState = My.Computer.FileSystem.FileExists("C:\FASTFIXKIT\rcsetup151.exe")

        If CheckState = True Then Process.Start("C:\FASTFIXKIT\rcsetup151.exe")
        If CheckState = False Then My.Computer.Network.DownloadFile("http://download.piriform.com/rcsetup151.exe", "C:\FASTFIXKIT\rcsetup151.exe")

        '  Process.Start("C:\FASTFIXKIT\recuva")
        Dim FILE_NAME As String = "C:\FASTFIXKIT\done.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.Write(vbNewLine & "Recuva was installed to recover lost or deleted files")
            objWriter.Close()
        Else
            Dim writeFile As IO.StreamWriter
            writeFile = IO.File.CreateText(FILE_NAME) 'Creates a new file
            writeFile.WriteLine("Recuva was installed to recover lost or deleted files")
            writeFile.Close()
        End If
    End Sub
End Class
