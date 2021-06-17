Imports System.Windows
Imports DevExpress.Data

Namespace InteractiveNotifications
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			RegisterApplication()
			InitializeComponent()
		End Sub
		Public Shared Sub SendActivatorMessage()
			MessageBox.Show("Activator has been invoked!")
		End Sub
		Public Shared ReadOnly Property ApplicationID() As String
			Get
				Return String.Format("InteractiveNotifications_{0}", AssemblyInfo.VersionShort.Replace(".", "_"))
			End Get
		End Property
		Public Shared ReadOnly Property ApplicationName() As String
			Get
				Return "Interactive Notifications"
			End Get
		End Property
		Private Sub RegisterApplication()
			If Not ShellHelper.IsApplicationShortcutExist(ApplicationName) Then
				ShellHelper.RegisterComServer(GetType(CustomNotificationActivator))
				ShellHelper.TryCreateShortcut(ApplicationID, ApplicationName, Nothing, GetType(CustomNotificationActivator))
			End If
		End Sub
	End Class
End Namespace
