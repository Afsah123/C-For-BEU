using System;

namespace NotificationApp.Services
{
    public class SmsNotificationService : INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"[SMS] Notification sent: {message}");
        }
    }
}