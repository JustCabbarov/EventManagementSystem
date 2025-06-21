using EventMenegmentDL.Entity;
using EventMenegmentSL.ViewModel;

namespace EventMenegmentSL.Services.Interfaces
{
    public interface INotificationService : IGenericService<NotificationViewModel, Notification>
    {





        
        Task SendToAllUsersAsync(string email, string subject, string message);


        


    }
}
