using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using PushNotifications.iOS;
using UIKit;
using UserNotifications;

[assembly: Xamarin.Forms.Dependency(typeof(NotificationHelper))]
namespace PushNotifications.iOS
{
    public class NotificationHelper : INotification
    {
        public void CreateNotification(string title, string message)
        {
            new NotificationDelegate().RegisterNotification(title, message);
        }
    }
}