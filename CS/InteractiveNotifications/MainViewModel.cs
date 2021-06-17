using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DevExpress.Mvvm;

namespace InteractiveNotifications {
    public class MainViewModel {
        protected virtual INotificationService NotificationService => null;

        public void ShowNotification() {
            string text1 = "Lorem ipsum dolor sit amet integer fringilla, dui eget ultrices cursus, justo tellus.";
            string text2 = "In ornare ante magna, eget volutpat mi bibendum a. Nam ut ullamcorper libero. Pellentesque habitant.";
            string text3 = "Quisque sapien odio, mollis tincidunt est id, fringilla euismod neque. Aenean adipiscing lorem dui, nec. ";
            INotification notification = NotificationService.CreatePredefinedNotification(text1, text2, text3);
            Show(notification);
        }

        void Show(INotification notification) {
            CreateLogLine("Showing...");
            notification.ShowAsync().ContinueWith(OnNotificationShown, TaskScheduler.FromCurrentSynchronizationContext());
        }
        void OnNotificationShown(Task<NotificationResult> task) {
            try {
                switch(task.Result) {
                    case NotificationResult.Activated:
                        CreateLogLine("Activated");
                        break;
                    case NotificationResult.TimedOut:
                        CreateLogLine("Timed out");
                        break;
                    case NotificationResult.UserCanceled:
                        CreateLogLine("Canceled by user");
                        break;
                    case NotificationResult.Dropped:
                        CreateLogLine("Dropped (the queue is full)");
                        break;
                }
            } catch(AggregateException e) {
                CreateLogLine("Error: " + e.InnerException.Message);
            }
        }

        void CreateLogLine(string text) {
            System.Diagnostics.Debug.WriteLine(text);
        }
    }
}
