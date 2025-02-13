<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/377780490/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1007374)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF NotificationService - Create Interactive Notifications

[NotificationService](https://docs.devexpress.com/WPF/18138/mvvm-framework/services/predefined-set/notificationservice) allows you to create and display feedback notifications introduced in Windows 10. Feedback notifications can be used to get a quick answer from a user. If the application has already been closed, the user can reopen it on the notification click.

![image](https://user-images.githubusercontent.com/65009440/220361565-f0ace61e-f9e9-42d5-8411-744a519f319e.png)

## Implementation Details

This example illustrates how to use [NotificationService](https://docs.devexpress.com/WPF/18138/mvvm-framework/services/predefined-set/notificationservice):

1. Create ApplicationShortcut: [MainWindow.xaml.cs](./CS/InteractiveNotifications/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/InteractiveNotifications/MainWindow.xaml.vb)).
2. Create ApplicationActivator and register COM-Server: [Activator.cs](./CS/InteractiveNotifications/Activator.cs) (VB: [Activator.vb](./VB/InteractiveNotifications/Activator.vb)).
3. Set ApplicationName and ApplicationId: [MainWindow.xaml](./CS/InteractiveNotifications/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/InteractiveNotifications/MainWindow.xaml)).
4. Create a command that invokes the notification: [MainViewModel.cs](./CS/InteractiveNotifications/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/InteractiveNotifications/MainViewModel.vb)).

   The [NotificationService.CreatePredefinedNotification](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.NotificationService.CreatePredefinedNotification(System.String-System.String-System.String-System.Windows.Media.ImageSource-System.String)?v=22.1) method allows you to specify the notification's id that could be used to identify the notification with wich the user interacts. NotificationActivator passes this id to the **OnActivate** method's **arguments** parameter.

We recommend running the sample without the Visual Studio debugger. The application shortcut will be created on the first application launch in the
*"%APPDATA%\Microsoft\Windows\Start Menu\Programs"* directory. If you move or rename the application file, you will need to manually remove the old shortcut.

**Important!**<br>Enable notifications in the Windows 10 settings before running the sample.

When the sample application is running, click the Create notification button to invoke a popup feedback notification. You can click the notification in the Windows 10 Action Center to restart the sample application once the application is closed.

## Files to Review

* [MainWindow.xaml](./CS/InteractiveNotifications/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/InteractiveNotifications/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/InteractiveNotifications/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/InteractiveNotifications/MainWindow.xaml.vb))
* [MainViewModel.cs](./CS/InteractiveNotifications/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/InteractiveNotifications/MainViewModel.vb))
* [Activator.cs](./CS/InteractiveNotifications/Activator.cs) (VB: [Activator.vb](./VB/InteractiveNotifications/Activator.vb))

## Documentation

* [NotificationService](https://docs.devexpress.com/WPF/18138/mvvm-framework/services/predefined-set/notificationservice)
* [UI Services](https://docs.devexpress.com/WPF/17414/mvvm-framework/services)

## More Examples

* [Display Notifications in MVVM Applications Using the NotificationService](https://github.com/DevExpress-Examples/wpf-display-notifications-using-the-notificationservice)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-notificationservice-create-interactive-notifications&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-notificationservice-create-interactive-notifications&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
