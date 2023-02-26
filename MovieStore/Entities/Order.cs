namespace MovieStore.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; } // satın alan müşteri

        public int MovieId { get; set; }
        public List<Movie> Movie { get; set; } // satın alınan filmler
    }
}
