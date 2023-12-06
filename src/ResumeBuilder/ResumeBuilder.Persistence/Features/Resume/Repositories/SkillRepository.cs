using Microsoft.EntityFrameworkCore;
using ResumeBuilder.Domain.Entities;
using ResumeBuilder.Persistence.Features.Resume.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Persistence.Features.Resume.Repositories
{
    public class SkillRepository : Repository<Skill, Guid>, ISkillRepository
    {
        public SkillRepository(IApplicationDbContext context) : base((DbContext)context)
        {
        }
    }
}
