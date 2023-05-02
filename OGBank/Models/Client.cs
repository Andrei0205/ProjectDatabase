namespace OGBank.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public float Balance { get; set; }

        public string Address { get; set; }

    }
}
