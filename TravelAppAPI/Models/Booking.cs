namespace TravelAppAPI.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public required DateTime CheckInDate { get; set; }
        public required DateTime CheckOutDate { get; set; }
        public int NumberOfGuests { get; set; }
        public required Room Room { get; set; }
        public required User User { get; set; }
        public required Contact Contact { get; set; }
    }
}
