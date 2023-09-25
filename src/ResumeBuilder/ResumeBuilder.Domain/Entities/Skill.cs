namespace ResumeBuilder.Domain.Entities
{
    public class Skill:IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int? SkillLevel { get; set; }
        public ICollection<ResumeSkill>? Resumes { get; set; }
    }
}