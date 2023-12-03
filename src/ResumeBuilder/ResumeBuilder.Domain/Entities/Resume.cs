using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace ResumeBuilder.Domain.Entities
{
    public class Resume : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string ResumeTitle { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? Summary { get; set; }
        public string? ProfileImageUrl { get; set; }
        public ResumeTemplate? Template { get; set; }
        public ICollection <SocialLink>? SocialLinks { get; set; }
        public ICollection<ResumeSkill>? Skills { get; set; }
        public ICollection<Training>? Trainings { get; set; }
        public ICollection<Experience>? Experiences { get; set; }
        public ICollection<Project>? Projects { get; set; }
        public ICollection<Education>? Educations { get; set; }
        public ICollection<Reference>? References { get; set; }
        public ICollection<CustomSection>? CustomSections { get; set; }


    }
}
