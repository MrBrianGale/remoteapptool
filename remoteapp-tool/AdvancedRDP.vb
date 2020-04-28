Public Class AdvancedRDP
    Private loadDefaults As Boolean = True
    Private MicSetting As Int16
    Private SpeakerSetting As Int16
    Private PreviousMicSetting As Int16
    Private PreviousSpeakerSetting As Int16

    Public Sub ShowAdvancedConfig()
        If (loadDefaults) Then
            PopulateDropdowns()
            LoadDefaultValues()
        Else
            LoadPrevious()
        End If
        StorePrevious()
        Me.Show()
    End Sub

    Public Function GetMicSettings()
        Return MicSetting
    End Function

    Public Function GetSpeakerSettings()
        Return SpeakerSetting
    End Function

    Private Sub StorePrevious()
        PreviousMicSetting = MicSetting
        PreviousSpeakerSetting = SpeakerSetting
    End Sub

    Private Sub LoadPrevious()
        If (MicSetting = 0) Then
            MicrophoneSettings.SelectedItem = "Disabled"
        Else
            MicrophoneSettings.SelectedItem = "Enabled"
        End If
        If (SpeakerSetting = 2) Then
            SpeakerSettings.SelectedItem = "Disabled"
        ElseIf (SpeakerSetting = 1) Then
            SpeakerSettings.SelectedItem = "Remote"
        Else
            SpeakerSettings.SelectedItem = "Local"
        End If
    End Sub
    Private Sub LoadDefaultValues()
        loadDefaults = False
        MicrophoneSettings.SelectedItem = "Disabled"
        SpeakerSettings.SelectedItem = "Local"
    End Sub
    Private Sub PopulateDropdowns()
        Dim MicrophoneToolTip As New ToolTip()
        MicrophoneToolTip.AutoPopDelay = 0
        MicrophoneToolTip.InitialDelay = 0
        MicrophoneToolTip.ReshowDelay = 0
        MicrophoneToolTip.SetToolTip(MicrophoneSettings, "Disabled will set it to disable audio capture from the local device.  Enabled will enable audio capture from the local device and redirection to an audio application in the remote session." + vbNewLine + "Default Disabled")
        MicrophoneToolTip.SetToolTip(MicLabel, "Disabled will set it to disable audio capture from the local device.  Enabled will enable audio capture from the local device and redirection to an audio application in the remote session." + vbNewLine + "Default Local")

        Dim SpeakerToolTip As New ToolTip()
        SpeakerToolTip.AutoPopDelay = 0
        SpeakerToolTip.InitialDelay = 0
        SpeakerToolTip.ReshowDelay = 0
        SpeakerToolTip.SetToolTip(SpeakerSettings, "Disabled will disable all audio playback.  Local will bring all audio from the remote machine to the local machine.  Remote will play audio on the remote machine.")
        SpeakerToolTip.SetToolTip(SpeakerLabel, "Disabled will disable all audio playback.  Local will bring all audio from the remote machine to the local machine.  Remote will play audio on the remote machine.")

        MicrophoneSettings.Items.Add("Disabled")
        MicrophoneSettings.Items.Add("Enabled")

        'MicrophoneSettings.Text = "Disabled will set it to disable audio capture from the local device.  Enabled will enable audio capture from the local device and redirection to an audio application in the remote session."
        SpeakerSettings.Items.Add("Disabled")
        SpeakerSettings.Items.Add("Local")
        SpeakerSettings.Items.Add("Remote")
        'SpeakerSettings.Text = "Disabled will disable all audio playback.  Local will bring all audio from the remote machine to the local machine.  Remote will play audio on the remote machine."
    End Sub



    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        Me.Visible = False
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        MicSetting = PreviousMicSetting
        SpeakerSetting = PreviousSpeakerSetting
        Me.Visible = False
    End Sub

    Private Sub MicrophoneSettings_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MicrophoneSettings.SelectedIndexChanged
        If (MicrophoneSettings.SelectedItem = "Disabled") Then
            MicSetting = 0
        Else
            MicSetting = 1
        End If
    End Sub

    Private Sub SpeakerSettings_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SpeakerSettings.SelectedIndexChanged
        If (SpeakerSettings.SelectedItem = "Disabled") Then
            SpeakerSetting = 2
        ElseIf (SpeakerSettings.SelectedItem = "Remote") Then
            SpeakerSetting = 1
        Else
            SpeakerSetting = 0
        End If
    End Sub
End Class