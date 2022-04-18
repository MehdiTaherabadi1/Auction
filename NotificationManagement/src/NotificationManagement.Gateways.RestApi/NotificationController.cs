using Mapster;
using Microsoft.AspNetCore.Mvc;
using NotificationManagement.Application.Contracts;
using NotificationManagement.Messages;

namespace NotificationManagement.Gateways.RestApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }


        [Route("/api/[controller]/Periodic")]
        public IActionResult Post([FromBody] PeriodicNotificationMessage notification)
        {
            _notificationService.Save(notification.Adapt<SendPeriodicNotification>());
            return Ok();
        }

        [Route("/api/[controller]//Scheduled")]
        public IActionResult Post([FromBody] SchedulesNotificationMessage notification)
        {
            _notificationService.Save(notification.Adapt<SendSchedulesNotification>());
            return Ok();
        }
    }
}
