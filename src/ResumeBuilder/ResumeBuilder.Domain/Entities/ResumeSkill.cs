namespace ResumeBuilder.Domain.Entities
{
    public class ResumeSkill
    {
        public Guid SkillId { get; set; }
        public Skill Skill { get; set; }
        public Guid ResumeId { get; set; }
        public Resume Resume { get; set; }
    }
}