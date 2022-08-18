namespace SchoolAPI.Models
{
    public class Class
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }

        public Class()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
