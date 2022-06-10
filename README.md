<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/377780490/22.1.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1007374)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/InteractiveNotifications/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/InteractiveNotifications/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/InteractiveNotifications/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/InteractiveNotifications/MainWindow.xaml.vb))
* [MainViewModel.cs](./CS/InteractiveNotifications/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/InteractiveNotifications/MainViewModel.vb))
* [Activator.cs](./CS/InteractiveNotifications/Activator.cs) (VB: [Activator.vb](./VB/InteractiveNotifications/Activator.vb))
<!-- default file list end -->
# How to use NotificationService to create interactive notifications


NotificationService allows you to create and display feedback notifications introduced in Windows 10. Feedback notifications can be used to get a quick answer from a user. If the application has already been closed, the user can reopen it on the notification click.

This example illustrates how to use [NotificationService](https://docs.devexpress.com/WPF/18138/mvvm-framework/services/predefined-set/notificationservice). The service is implemented in three steps:

1. Create ApplicationShortcut: [MainWindow.xaml.cs](./CS/InteractiveNotifications/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/InteractiveNotifications/MainWindow.xaml.vb)).
2. Create ApplicationActivator and register COM-Server: [Activator.cs](./CS/InteractiveNotifications/Activator.cs) (VB: [Activator.vb](./VB/InteractiveNotifications/Activator.vb)).
3. Set ApplicationName and ApplicationId: [MainWindow.xaml](./CS/InteractiveNotifications/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/InteractiveNotifications/MainWindow.xaml))

We recommend running the sample without the Visual Studio debugger. The application shortcut will be created on the first application launch in the
<em>"%APPDATA%\Microsoft\Windows\Start Menu\Programs"</em> directory. If you move or rename the application file, you will need to manually remove the old shortcut.

**Important!**<br>Enable notifications in the Windows 10 settings before running the sample.

When the sample application is running, click the Create notification button to invoke a popup feedback notification. You can click the notification in the Windows 10 Action Center to restart the sample application once the application is closed.
<br/>
