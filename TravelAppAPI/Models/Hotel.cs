namespace TravelAppAPI.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string Description { get; set; } = string.Empty;
        public required string Address { get; set; } = string.Empty;
        public bool isActive { get; set; } = true;
        public required User User { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
