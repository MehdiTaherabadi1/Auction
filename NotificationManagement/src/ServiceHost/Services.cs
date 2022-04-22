using Microsoft.Extensions.DependencyInjection;
using NotificationManagement.Application;
using NotificationManagement.Application.Contracts;

namespace ServiceHost
{
    public static class Services
    {
        public static void AddNotification(this IServiceCollection services)
        {
            //Bootstraper.WireUp(container);
            services.AddScoped<INotificationService, NotificationService>();
        }
    }
}
