Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports System.Windows
Imports DevExpress.Mvvm.UI

Namespace InteractiveNotifications

    <Guid("5A430E6E-2E66-4A46-BBFA-A5CC432673A0"), ComVisible(True)>
    Public Class CustomNotificationActivator
        Inherits ToastNotificationActivator

        Public Overrides Sub OnActivate(ByVal arguments As String, ByVal data As Dictionary(Of String, String))
            Call Application.Current.Dispatcher.Invoke(Sub() MainWindow.SendActivatorMessage(arguments))
        End Sub
    End Class
End Namespace
