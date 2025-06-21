using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventMenegmentDL.Entity;

namespace EventMenegmentSL.ViewModel
{
    public class UserInvitationViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
      public    string Location { get; set; }
        public DateTime EventDate { get; set; }
      public string EventName { get; set; }
        public int InvitationId { get; set; }
        public Invitation Invitation { get; set; }

        public string? UserId { get; set; }
        public AppUser? User { get; set; }

        public DateTime SentAt { get; set; }
     
    }
}
