namespace SchoolAPI.Models
{
    public abstract class BaseEntity
    {
        public string Id { get; set; }
        public DateTimeOffset CreateAt { get; set; }

        public BaseEntity()
        {
            this.Id = Guid.NewGuid().ToString();
            this.CreateAt = DateTime.Now;
        }
    }
}
