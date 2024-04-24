namespace Ticket.Models
{
    public class Actor_Activity
    {
        public int ActivityId { get; set; }
        public Activity Activity { get; set; }


        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
