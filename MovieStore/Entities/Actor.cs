namespace MovieStore.Entities
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Movie> Movies { get; set; } // bir oyuncunun birden fazla filmi olabilir 
    }
}
