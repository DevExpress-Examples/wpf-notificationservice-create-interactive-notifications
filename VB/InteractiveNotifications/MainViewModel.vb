Imports System
Imports System.Threading.Tasks
Imports DevExpress.Mvvm

Namespace InteractiveNotifications

    Public Class MainViewModel

        Protected Overridable ReadOnly Property NotificationService As INotificationService
            Get
                Return Nothing
            End Get
        End Property

        Public Sub ShowNotification()
            Dim text1 As String = "Lorem ipsum dolor sit amet integer fringilla, dui eget ultrices cursus, justo tellus."
            Dim text2 As String = "In ornare ante magna, eget volutpat mi bibendum a. Nam ut ullamcorper libero. Pellentesque habitant."
            Dim text3 As String = "Quisque sapien odio, mollis tincidunt est id, fringilla euismod neque. Aenean adipiscing lorem dui, nec. "
            Dim notification As INotification = NotificationService.CreatePredefinedNotification(text1, text2, text3)
            Show(notification)
        End Sub

        Private Sub Show(ByVal notification As INotification)
            CreateLogLine("Showing...")
            notification.ShowAsync().ContinueWith(New Action(Of Task(Of NotificationResult))(AddressOf OnNotificationShown), TaskScheduler.FromCurrentSynchronizationContext())
        End Sub

        Private Sub OnNotificationShown(ByVal task As Task(Of NotificationResult))
            Try
                Select Case task.Result
                    Case NotificationResult.Activated
                        CreateLogLine("Activated")
                    Case NotificationResult.TimedOut
                        CreateLogLine("Timed out")
                    Case NotificationResult.UserCanceled
                        CreateLogLine("Canceled by user")
                    Case NotificationResult.Dropped
                        CreateLogLine("Dropped (the queue is full)")
                End Select
            Catch e As AggregateException
                CreateLogLine("Error: " & e.InnerException.Message)
            End Try
        End Sub

        Private Sub CreateLogLine(ByVal text As String)
            System.Diagnostics.Debug.WriteLine(text)
        End Sub
    End Class
End Namespace
