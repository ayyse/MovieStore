namespace MovieStore.Entities
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ActorMovie> ActorMovies { get; set; } // bir oyuncunun birden fazla filmi olabilir 
    }
}
