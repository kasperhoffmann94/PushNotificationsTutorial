using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using UserNotifications;

namespace PushNotifications.iOS
{
    public class NotificationDelegate : UNUserNotificationCenterDelegate
    {

        public NotificationDelegate()
        {

        }

        public override void WillPresentNotification(UNUserNotificationCenter center, UNNotification notification, Action<UNNotificationPresentationOptions> completionHandler)
        {
            Console.WriteLine("Active Notification: {0}", notification);
            completionHandler(UNNotificationPresentationOptions.Alert | UNNotificationPresentationOptions.Sound);
        }
        public override void DidReceiveNotificationResponse(UNUserNotificationCenter center, UNNotificationResponse response, Action completionHandler)
        {
            switch (response.ActionIdentifier)
            {
                case "reply":

                    break;
                default:

                    if (response.IsDefaultAction)
                    {

                    }
                    else if (response.IsDismissAction)
                    {

                    }
                    break;
            }


            completionHandler();
        }

        public void RegisterNotification(string title, string body)
        {
            UNUserNotificationCenter center = UNUserNotificationCenter.Current;
            UNMutableNotificationContent notificationContent = new UNMutableNotificationContent();

            notificationContent.Title = title;
            notificationContent.Body = body;

            notificationContent.Sound = UNNotificationSound.Default;

            UNTimeIntervalNotificationTrigger trigger = UNTimeIntervalNotificationTrigger.CreateTrigger(1, false);

            UNNotificationRequest request = UNNotificationRequest.FromIdentifier("FiveSecond", notificationContent, trigger);

            center.AddNotificationRequest(request, (NSError obj) =>
            {

            });
        }

    }
}