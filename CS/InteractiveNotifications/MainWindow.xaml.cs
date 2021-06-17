using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Data;

namespace InteractiveNotifications {
    public partial class MainWindow : Window {
        public MainWindow() {
            RegisterApplication();
            InitializeComponent();
        }
        public static void SendActivatorMessage() {
            MessageBox.Show("Activator has been invoked!");
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
