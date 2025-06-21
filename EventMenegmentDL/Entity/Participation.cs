namespace EventMenegmentDL.Entity
{
    public class Participation : BaseEntity
    {
        public int IvitationId { get; set; }
        public DateTime CheckInTime { get; set; }
        public int SeatNumber { get; set; }

        public Invitation Invitation { get; set; }
    }

}
