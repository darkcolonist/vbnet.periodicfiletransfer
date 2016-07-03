Imports System.IO
Imports Microsoft.WindowsAPICodePack
Imports Microsoft.WindowsAPICodePack.Taskbar

Public Class frmMain
    Dim total_transfered As Int32 = 0
    Dim iteration As Int32 = 1
    Dim running As Boolean = False

    Private Sub btnToggle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToggle.Click
        Dim hasError As Boolean = False

        If Not Directory.Exists(txtSrc.Text) Then
            MessageBox.Show("source directory doesn't exist!", "error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            hasError = True
        End If

        If Not Directory.Exists(txtTgt.Text) Then
            MessageBox.Show("target directory doesn't exist!", "error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            hasError = True
        End If

        If hasError Then
            txtMessage.Text = "unable to start, some errors need to be fixed!"
            Return
        End If

        txtTimer.Text = txtInterval.Value

        saveSettings()

        If btnToggle.Text.Equals("start") Then
            total_transfered = 0
            iteration = 1
            log("routine started")
            running = True
            btnToggle.Text = "stop"
            txtFilter.ReadOnly = True
            txtInterval.Enabled = False
            txtLimit.Enabled = False
            txtSrc.ReadOnly = True
            txtTgt.ReadOnly = True
        Else
            log("routine stopped: iteration " & iteration & " - " & total_transfered & " file(s)")
            running = False
            btnToggle.Text = "start"
            txtFilter.ReadOnly = False
            txtInterval.Enabled = True
            txtLimit.Enabled = True
            txtSrc.ReadOnly = False
            txtTgt.ReadOnly = False
        End If

    End Sub

    Private Sub transfer_files()
        Dim srcdi As DirectoryInfo = New DirectoryInfo(txtSrc.Text)
        Dim tgtdi As DirectoryInfo = New DirectoryInfo(txtTgt.Text)

        Dim srcfiles = srcdi.GetFiles(txtFilter.Text).OrderBy(Function(x) x.CreationTime)

        Dim limitCounter = 0

        If Not srcfiles.Count = 0 Then
            For Each srcfile As FileInfo In srcfiles
                If limitCounter >= txtLimit.Value Then
                    Exit For
                End If

                ' System.Console.WriteLine(limitCounter & " " & srcfile.CreationTime & " - " & srcfile.FullName)

                Dim source = srcfile.FullName
                Dim target = txtTgt.Text & "\" & srcfile.ToString

                File.Move(source, target)

                log("transfering " & srcfile.ToString & " to " & txtTgt.Text)

                limitCounter = limitCounter + 1
                total_transfered = total_transfered + 1
                txtMessage.Text = "iteration " & iteration & " - " & total_transfered & " file(s)"
            Next

            iteration = iteration + 1
        Else
            log("no files with filter " & txtFilter.Text & " found in source directory")
            txtMessage.Text = "no files with filter " & txtFilter.Text & " found in source directory"
            btnToggle_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer.Tick
        If running Then
            txtStatus.Text = "running"

            txtTimer.Text = txtTimer.Text - 1

            TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal)
            TaskbarManager.Instance.SetProgressValue(txtInterval.Value - txtTimer.Text, txtInterval.Value)

            If txtTimer.Text = 0 Then
                transfer_files()
                txtTimer.Text = txtInterval.Value
            End If
        Else
            TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.NoProgress)
            txtStatus.Text = "idle"
        End If
    End Sub

    Sub log(ByVal text)
        ' Dim time = Date.Now().Hour & ":" & Date.Now().Minute & ":" & Date.Now().Second
        text = Date.Now().ToString("hh:mm:sstt") & ": " & text
        lstLog.Items.Insert(0, text)
    End Sub

    Private Sub saveSettings()
        My.Settings.txtSrc = txtSrc.Text
        My.Settings.txtTgt = txtTgt.Text
        My.Settings.txtLimit = txtLimit.Value
        My.Settings.txtInterval = txtInterval.Value
        My.Settings.txtFilter = txtFilter.Text
        My.Settings.chkAutostart = chkAutostart.Checked
        My.Settings.Save()
    End Sub

    Private Sub loadSettings()
        txtSrc.Text = My.Settings.txtSrc
        txtTgt.Text = My.Settings.txtTgt
        txtLimit.Value = My.Settings.txtLimit
        txtInterval.Value = My.Settings.txtInterval
        txtFilter.Text = My.Settings.txtFilter
        chkAutostart.Checked = My.Settings.chkAutostart
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadSettings()

        lstLog.Items.Clear()
        log("program started")

        If chkAutostart.Checked Then
            btnToggle_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        MessageBox.Show("©2016 periodic file transfer tool " & Environment.NewLine & "by Christian Noel Reyes <me@misty-stix.com>", "about", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


End Class
