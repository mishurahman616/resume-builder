using ResumeBuilder.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Application.Features.Resume.Interfaces
{
    public interface ISkillService
    {
        public bool CreateSkill(Skill skill);
        public bool DeleteSkill(Guid skilId);
        public bool UpdateSkill(Skill skill);
        public Skill FindSkill(Guid skilId);
        IList<Skill> GetAllSkills();
    }
}
