namespace DeltaXApi.Models
{
    public class MovieActor
    {
        public MovieActor(int movieID, int actorID)
        {
        ActorID= actorID;
        MovieID = movieID;
        }
        public int ActorID { get; set; }
        public int MovieID { get; set; }
        public Movie Movie { get; set; }
        public Actor Actor { get; set; }
    }
    
}