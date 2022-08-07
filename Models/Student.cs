namespace SchoolAPI.Models
{
    public class Student
    {
        public string Id { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty ;
        public DateTime Birthdate { get; set; }
        public string Address { get; set; } = string.Empty;
        public string PostCode { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string FatherName { get; set; } = string.Empty;

        public Student()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
