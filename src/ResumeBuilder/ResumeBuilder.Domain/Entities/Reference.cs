namespace ResumeBuilder.Domain.Entities
{
    public class Reference : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Organization { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Guid ResumeId { get; set; }
        public Resume? Resume { get; set; }
    }
}