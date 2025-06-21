using EventMenegmentDL.Entity;

namespace EventMenegmentSL.ViewModel
{
    public class ParticipationViewModel
    {
        public int IvitationId { get; set; }
        public DateTime CheckInTime { get; set; }
        public int SeatNumber { get; set; }

        public Invitation Invitation { get; set; }
    }
}
