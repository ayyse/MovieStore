namespace MovieStore.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Genre> FavGenres { get; set; }
        public List<Order> PurchasedMovies { get; set; }
    }
}
