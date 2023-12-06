using ResumeBuilder.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Persistence.Features.Resume.Interfaces
{
    public interface ISkillRepository: IRepository<Skill, Guid>
    {

    }
}
