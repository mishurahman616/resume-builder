namespace ResumeBuilder.Domain.Entities
{
    public class Experience : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Position { get; set; }
        public string Organization { get; set; }
        public DateTime JoiningDate { get; set; }
        public DateTime ResignationDate { get; set; }
        public string Responsibilities { get; set; }
        public Guid ResumeId { get; set; }
        public Resume? Resume { get; set; }
    }
}