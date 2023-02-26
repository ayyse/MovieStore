namespace MovieStore.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public DateTime YearOfConstruction { get; set; }

        public int GenreId { get; set; }
        public Genre Genre { get; set; } // bir filmin bir türü olur

        public int DirectorId { get; set; }
        public Director Director { get; set; } // bir filmin bir yönetmeni olur

        public List<Actor>? Actors { get; set; } // bir filmin birden fazla oyuncusu olabilir
    }
}
