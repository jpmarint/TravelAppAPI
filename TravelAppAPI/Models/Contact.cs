namespace TravelAppAPI.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public required string ContactName { get; set; }
        public required string ContactLastName { get; set; }
        public required string ContactEmail { get; set; }
        public required string PhoneNumber { get; set; }
    }
}
