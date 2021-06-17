using DevExpress.Mvvm.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InteractiveNotifications {
    [Guid("5A430E6E-2E66-4A46-BBFA-A5CC432673A0"), ComVisible(true)]
    public class CustomNotificationActivator : ToastNotificationActivator {
        public override void OnActivate(string arguments, Dictionary<string, string> data) {
            Application.Current.Dispatcher.Invoke(() => {
                MainWindow.SendActivatorMessage();
            });
        }
    }
}