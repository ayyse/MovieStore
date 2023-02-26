namespace MovieStore.Entities
{
    public class Director
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Movie> Movies { get; set; } // bir yönetmenin birden fazla yönettiği film olabilir
    }
}
