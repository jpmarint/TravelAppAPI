namespace TravelAppAPI.Models
{
    public class Room
    {
        public int Id { get; set; }
        public bool isActive { get; set; } = true;
        public required int Capacity { get; set; }
        public required RoomType Type { get; set; }
        public string Description { get; set; } = string.Empty;
        public required decimal BasePrice { get; set; }
        public required decimal Taxes { get; set; }
        public string Location { get; set; } = string.Empty;
        public required Hotel Hotel { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
