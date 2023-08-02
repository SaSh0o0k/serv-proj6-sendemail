namespace ClientManagementApp3.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"{FullName} - {PhoneNumber} - {Email}";
        }
    }
}
