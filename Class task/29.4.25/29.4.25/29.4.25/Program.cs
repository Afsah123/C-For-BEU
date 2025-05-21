using System;
using NotificationApp.Models;
using NotificationApp.Services;
using NotificationApp.Controllers;

namespace NotificationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Services
            var emailService = new EmailNotificationService();
            var smsService = new SmsNotificationService();

            // 2.  Email
            var emailNotifier = new NotificationManager(emailService);
            emailNotifier.Notify("Hello  Email!");

            // 3.  SMS
            var smsNotifier = new NotificationManager(smsService);
            smsNotifier.Notify("Hello SMS!");

            // 4. Bonus: User-based dynamic selection
            var user = new User { Name = "Afsah", PreferredChannel = "SMS" };

            INotificationService chosenService = user.PreferredChannel switch
            {
                "Email" => emailService,
                "SMS" => smsService,
                _ => throw new Exception("Unknown preference.")
            };

            var userNotifier = new NotificationManager(chosenService);
            userNotifier.Notify($"Hi {user.Name}, your notification  sent {user.PreferredChannel}.");
        }
    }
}