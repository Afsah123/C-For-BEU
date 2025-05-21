using NotificationApp.Services;

namespace NotificationApp.Controllers
{
    public class NotificationManager
    {
        private readonly INotificationService _notificationService;

        public NotificationManager(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void Notify(string message)
        {
            _notificationService.SendNotification(message);
        }
    }
}