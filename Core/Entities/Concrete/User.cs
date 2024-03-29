namespace Core.Entities.Concrete
{
    public class User : IEntity
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool Status { get; set; }
        public string? oneSignalId { get; set; }
        public string? UserStatus { get; set; }
        public byte[]? Image { get; set; }
        public DateTime? RegisterDate { get; set; }
    }
}
