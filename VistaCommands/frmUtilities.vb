Imports System
Imports System.Windows.Forms
Imports System.Threading
Imports System.IO
Imports System.Data

Public Class frmUtilities
    Inherits Form
    Dim ans As String
    Dim fileArgs As String
    Dim path As String = "C:\Windows\System32\"

    Private Sub btnAddRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRemove.Click
        fileArgs = "shell32.dll,Control_RunDLL appwiz.cpl,,0"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub

    Private Sub btnContAdvisor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContAdvisor.Click
        fileArgs = "msrating.dll,RatingSetupUI"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub

    Private Sub btnControlPanel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnControlPanel.Click
        fileArgs = "shell32.dll,Control_RunDLL"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub
    'MessageBox Idea by : Hans Dietriech
    Private Sub btnDeleteTIF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteTIF.Click
        ans = CStr(MsgBox("Are you sure you want to delete these files?", MsgBoxStyle.YesNo, "Ready to Delete Files?"))
        If CDbl(ans) = vbYes Then
            fileArgs = "InetCpl.cpl,ClearMyTracksByProcess 8"
            cmdProcess.StartInfo.Arguments = fileArgs
            cmdProcess.StartInfo.WorkingDirectory = path
            cmdProcess.StartInfo.FileName = "RunDll32.exe"
            cmdProcess.Start()
            cmdProcess.WaitForExit()

            Me.Show()
        Else
            MessageBox.Show("Process Cancelled!")
            Exit Sub
        End If
    End Sub
    'MessageBox Idea by : Hans Dietriech
    Private Sub btnDeleteCookies_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteCookies.Click
        ans = CStr(MsgBox("Are you sure you want to delete these files?", MsgBoxStyle.YesNo, "Ready to Delete Files?"))
        If CDbl(ans) = vbYes Then
            fileArgs = "InetCpl.cpl,ClearMyTracksByProcess 2"
            cmdProcess.StartInfo.Arguments = fileArgs
            cmdProcess.StartInfo.WorkingDirectory = path
            cmdProcess.StartInfo.FileName = "RunDll32.exe"
            cmdProcess.Start()
            cmdProcess.WaitForExit()

            Me.Show()
        Else
            MessageBox.Show("Process Cancelled!")
            Exit Sub
        End If
    End Sub
    'MessageBox Idea by : Hans Dietriech
    Private Sub btnDelHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelHistory.Click
        ans = CStr(MsgBox("Are you sure you want to delete these files?", MsgBoxStyle.YesNo, "Ready to Delete Files?"))
        If CDbl(ans) = vbYes Then
            fileArgs = "InetCpl.cpl,ClearMyTracksByProcess 1"
            cmdProcess.StartInfo.Arguments = fileArgs
            cmdProcess.StartInfo.WorkingDirectory = path
            cmdProcess.StartInfo.FileName = "RunDll32.exe"
            cmdProcess.Start()
            cmdProcess.WaitForExit()

            Me.Show()
        Else
            MessageBox.Show("Process Cancelled!")
            Exit Sub
        End If
    End Sub
    'MessageBox Idea by : Hans Dietriech
    Private Sub btnDelFormData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelFormData.Click
        ans = CStr(MsgBox("Are you sure you want to delete these files?", MsgBoxStyle.YesNo, "Ready to Delete Files?"))
        If CDbl(ans) = vbYes Then
            fileArgs = "InetCpl.cpl,ClearMyTracksByProcess 16"
            cmdProcess.StartInfo.Arguments = fileArgs
            cmdProcess.StartInfo.WorkingDirectory = path
            cmdProcess.StartInfo.FileName = "RunDll32.exe"
            cmdProcess.Start()
            cmdProcess.WaitForExit()

            Me.Show()
        Else
            MessageBox.Show("Process Cancelled!")
            Exit Sub
        End If
    End Sub
    'MessageBox Idea by : Hans Dietriech
    Private Sub btnDelPW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelPW.Click
        ans = CStr(MsgBox("Are you sure you want to delete these files?", MsgBoxStyle.YesNo, "Ready to Delete Files?"))
        If CDbl(ans) = vbYes Then
            fileArgs = "InetCpl.cpl,ClearMyTracksByProcess 32"
            cmdProcess.StartInfo.Arguments = fileArgs
            cmdProcess.StartInfo.WorkingDirectory = path
            cmdProcess.StartInfo.FileName = "RunDll32.exe"
            cmdProcess.Start()
            cmdProcess.WaitForExit()

            Me.Show()
        Else
            MessageBox.Show("Process Cancelled!")
            Exit Sub
        End If
    End Sub
    'MessageBox Idea by : Hans Dietriech
    Private Sub btnDeleteAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteAll.Click
        ans = CStr(MsgBox("Are you sure you want to delete these files?", MsgBoxStyle.YesNo, "Ready to Delete Files?"))
        If CDbl(ans) = vbYes Then
            fileArgs = "InetCpl.cpl,ClearMyTracksByProcess 255"
            cmdProcess.StartInfo.Arguments = fileArgs
            cmdProcess.StartInfo.WorkingDirectory = path
            cmdProcess.StartInfo.FileName = "RunDll32.exe"
            cmdProcess.Start()
            cmdProcess.WaitForExit()

            Me.Show()
        Else
            MessageBox.Show("Process Cancelled!")
            Exit Sub
        End If
    End Sub
    'MessageBox Idea by : Hans Dietriech
    Private Sub btnDeleteAll2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteAll2.Click
        ans = CStr(MsgBox("Are you sure you want to delete these files?", MsgBoxStyle.YesNo, "Ready to Delete Files?"))
        If CDbl(ans) = vbYes Then
            fileArgs = "InetCpl.cpl,ClearMyTracksByProcess 4351"
            cmdProcess.StartInfo.Arguments = fileArgs
            cmdProcess.StartInfo.WorkingDirectory = path
            cmdProcess.StartInfo.FileName = "RunDll32.exe"
            cmdProcess.Start()
            cmdProcess.WaitForExit()

            Me.Show()
        Else
            MessageBox.Show("Process Cancelled!")
            Exit Sub
        End If
    End Sub

    Private Sub btnDateTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDateTime.Click
        fileArgs = "shell32.dll,Control_RunDLL timedate.cpl"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub

    Private Sub btnDisplaySettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplaySettings.Click
        fileArgs = "shell32.dll,Control_RunDLL access.cpl,,3"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub

    Private Sub btnDeviceManager_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeviceManager.Click
        fileArgs = "devmgr.dll DeviceManager_Execute"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub

    Private Sub btnFolderOptsGen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFolderOptsGen.Click
        fileArgs = "shell32.dll,Options_RunDLL 0"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub

    Private Sub btnFolderOptsFileTypes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFolderOptsFileTypes.Click
        fileArgs = "shell32.dll,Control_Options 2"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub

    Private Sub btnFolderOptsSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFolderOptsSearch.Click
        fileArgs = "shell32.dll,Options_RunDLL 2"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub

    Private Sub btnFolderOptsView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFolderOptsView.Click
        fileArgs = "shell32.dll,Options_RunDLL 7"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub

    Private Sub btnForgottenPWWiz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForgottenPWWiz.Click
        fileArgs = "keymgr.dll,PRShowSaveWizardExW"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub

    Private Sub btnHibernate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHibernate.Click
        fileArgs = "powrprof.dll,SetSuspendState"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub

    Private Sub btnInternetProps_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInternetProps.Click
        fileArgs = "Shell32.dll,Control_RunDLL Inetcpl.cpl,,6"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub

    Private Sub btnKeyboardProps_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyboardProps.Click
        fileArgs = "shell32.dll,Control_RunDLL main.cpl @1"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub

    Private Sub btnLockScreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLockScreen.Click
        fileArgs = "user32.dll,LockWorkStation"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub

    Private Sub btnSwapMouseBtns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSwapMouseBtns.Click
        fileArgs = "User32.dll,SwapMouseButton"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub

    Private Sub btnMouseProps_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMouseProps.Click
        fileArgs = "Shell32.dll,Control_RunDLL main.cpl @0,0"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub

    Private Sub btnMapNetworkDrive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMapNetworkDrive.Click
        fileArgs = "Shell32.dll,SHHelpShortcuts_RunDLL Connect"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub

    Private Sub btnNetworkConnections_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNetworkConnections.Click
        fileArgs = "shell32.dll,Control_RunDLL ncpa.cpl"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub

    Private Sub btnOrginizeIEFavourites_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrginizeIEFavourites.Click
        fileArgs = "shdocvw.dll,DoOrganizeFavDlg"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub

    Private Sub btnOpenWith_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenWith.Click
        MessageBox.Show("This function has been cancelled.")
        Exit Sub
        'fileArgs = "Shell32.dll,OpenAs_RunDLL Any_File-name.ext"
        'cmdProcess.StartInfo.Arguments = fileArgs
        'cmdProcess.StartInfo.WorkingDirectory = path
        'cmdProcess.StartInfo.FileName = "RunDll32.exe"
        'cmdProcess.Start()
        'cmdProcess.WaitForExit()
        '
        'Me.Show()
    End Sub

    Private Sub btnPrinterUserInterface_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrinterUserInterface.Click
        fileArgs = "Printui.dll,PrintUIEntry /?"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub

    Private Sub btnPrinterManagementFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrinterManagementFolder.Click
        fileArgs = "Shell32.dll,SHHelpShortcuts_RunDLL PrintersFolder"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub

    Private Sub btnPowerOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPowerOptions.Click
        fileArgs = "Shell32.dll,Control_RunDLL powercfg.cpl"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub

    Private Sub btnProcessIdleTasks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcessIdleTasks.Click
        fileArgs = "advapi32.dll,ProcessIdleTasks"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub

    Private Sub btnRegional_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegional.Click
        fileArgs = "Shell32.dll,Control_RunDLL Intl.cpl,,0"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub

    Private Sub btnUsernamesPasswords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsernamesPasswords.Click
        fileArgs = "keymgr.dll,KRShowKeyMgr"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub

    Private Sub btnSafelyRemoveHW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSafelyRemoveHW.Click
        fileArgs = "Shell32.dll,Control_RunDLL HotPlug.dll"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub

    Private Sub btnSoundProperties_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSoundProperties.Click
        fileArgs = "Shell32.dll,Control_RunDLL Mmsys.cpl,,0"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub

    Private Sub btnSystemProperties_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSystemProperties.Click
        fileArgs = "Shell32.dll,Control_RunDLL Sysdm.cpl,,3"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub

    Private Sub btnSysPropAdv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSysPropAdv.Click
        fileArgs = "shell32.dll,Control_RunDLL sysdm.cpl,,4"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub

    Private Sub btnAutoUpdates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAutoUpdates.Click
        fileArgs = "shell32.dll,Control_RunDLL sysdm.cpl,,5"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub

    Private Sub btntaskBarProperties_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntaskBarProperties.Click
        fileArgs = "shell32.dll,Options_RunDLL 1"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub

    Private Sub btnUserAccounts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserAccounts.Click
        fileArgs = "shell32.dll,Control_RunDLL nusrmgr.cpl"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub

    Private Sub btnUnplugEject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnplugEject.Click
        fileArgs = "shell32.dll,Control_RunDLL hotplug.dll"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub

    Private Sub btnSecurityCenter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSecurityCenter.Click
        fileArgs = "shell32.dll,Control_RunDLL wscui.cpl"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub

    Private Sub btnWindowsAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWindowsAbout.Click
        fileArgs = "SHELL32.DLL,ShellAboutW"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub

    Private Sub btnFontsFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFontsFolder.Click
        fileArgs = "Shell32.dll,SHHelpShortcuts_RunDLL FontsFolder"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub

    Private Sub btnWindowsFirewall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWindowsFirewall.Click
        fileArgs = "shell32.dll,Control_RunDLL firewall.cpl"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub

    Private Sub btnWirelessNetworkSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWirelessNetworkSetup.Click
        fileArgs = "shell32.dll,Control_RunDLL NetSetup.cpl,@0,WNSW"
        cmdProcess.StartInfo.Arguments = fileArgs
        cmdProcess.StartInfo.WorkingDirectory = path
        cmdProcess.StartInfo.FileName = "RunDll32.exe"
        cmdProcess.Start()
        cmdProcess.WaitForExit()

        Me.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub
End Class
