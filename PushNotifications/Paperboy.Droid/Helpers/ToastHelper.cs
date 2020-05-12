using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using Android.Media;
using Android.Graphics;

namespace Paperboy.Droid.Helpers
{
    public static class ToastHelper
    {
        public static void ProcessNotification(Paperboy.Droid.GcmService service, NotificationManager notificationManager, Intent uiIntent, NotificationCompat.Builder builder, string title, string description, Bitmap largeIcon)
        {

            var notification = builder.SetContentIntent(PendingIntent.GetActivity(service, 0, uiIntent, 0))
                    .SetSmallIcon(Resource.Drawable.icon)
                    .SetLargeIcon(largeIcon)
                    .SetTicker(title)
                    .SetContentTitle(title)
                    .SetContentText(description)

                    .SetSound(RingtoneManager.GetDefaultUri(RingtoneType.Notification))
                    .SetAutoCancel(true).Build();


            notificationManager.Notify(1, notification);
        }

    }
}