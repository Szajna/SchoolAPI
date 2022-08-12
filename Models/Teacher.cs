namespace SchoolAPI.Models
{
    public class Teacher
    {
        public string Id { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public DateTime Birthdate { get; set; }
        public string Address { get; set; } = string.Empty;
        public string PostCode { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;

        public Teacher()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
