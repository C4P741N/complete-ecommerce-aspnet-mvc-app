namespace eTickets.Models
{
    public class Actor_Movie
    {//Joining relationship table for one is to many 
        public int MovieId { get; set; }

        public Movie Movie { get; set; }

        public int ActorId { get; set; }

        public Actor Actor { get; set; }
    }
}
