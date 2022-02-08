using System.Windows;
using DevExpress.Data;

namespace InteractiveNotifications {
    public partial class MainWindow : Window {
        public MainWindow() {
            RegisterApplication();
            InitializeComponent();
        }
        public static void SendActivatorMessage(string arguments) {
            MessageBox.Show("Activator invoked! Notification id = " + arguments);
        }
        public static string ApplicationID {
            get { return string.Format("InteractiveNotifications_{0}", AssemblyInfo.VersionShort.Replace(".", "_")); }
        }
        public static string ApplicationName {
            get { return "Interactive Notifications"; }
        }
        void RegisterApplication() {
            if(!ShellHelper.IsApplicationShortcutExist(ApplicationName)) {
                ShellHelper.RegisterComServer(typeof(CustomNotificationActivator));
                ShellHelper.TryCreateShortcut(ApplicationID, ApplicationName, null, typeof(CustomNotificationActivator));
            }
        }
    }
}
