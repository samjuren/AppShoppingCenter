namespace AppShoppingCenter.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public TimeOnly Duration { get; set; }

        public string Cover { get; set; } = null!;
        public string Trailer { get; set; } = null!;
    }
}
