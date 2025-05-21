using _29._4._25.Service;
using System;

namespace NotificationApp.Services
{
    public class EmailNotificationService : INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"[Email] Notification sent: {message}");
        }
    }
}