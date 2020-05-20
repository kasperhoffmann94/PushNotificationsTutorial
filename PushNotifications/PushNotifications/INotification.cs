using System;
using System.Collections.Generic;
using System.Text;

namespace PushNotifications
{
    public interface INotification
    {
        void CreateNotification(string title, string message);
    }
}
