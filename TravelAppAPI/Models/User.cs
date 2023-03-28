namespace TravelAppAPI.Models
{
    public class User
    {
        public required int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }  
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required DocumentType DocType { get; set; }
        public required string DocumentNumber { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
