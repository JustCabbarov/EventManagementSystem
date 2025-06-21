
using System.Net;
using System.Net.Mail;
using AutoMapper;
using EventMenegmentDL.Entity;
using EventMenegmentDL.Repository.Interfaces;
using EventMenegmentSL.Services.Interfaces;
using EventMenegmentSL.ViewModel;

namespace EventMenegmentSL.Services.Implementation
{
    public class NotificationService : GenericService<NotificationViewModel, Notification>, INotificationService
    {
        private readonly IGenericRepository<Notification> _notificationRepo;
       
        private readonly IMapper _mapper;
      

        public NotificationService(IGenericRepository<Notification> notificationRepo, IMapper mapper) : base(mapper, notificationRepo)
        {
            _notificationRepo = notificationRepo;
            _mapper = mapper;
           
        
        }


     
        

        public async Task SendToAllUsersAsync(string email, string subject, string message)
        {
            var client= new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("alinj@code.edu.az", "yqax vbws yurz nzfw"),
                EnableSsl = true
            };
            await client.SendMailAsync("alinj@code.edu.az", email, subject, message);
        }

    
    }

}
