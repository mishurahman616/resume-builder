using Microsoft.EntityFrameworkCore;
using ResumeBuilder.Persistence.Features.Resume.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Persistence.Features.Resume.Repositories
{
    using CV =ResumeBuilder.Domain.Entities.Resume;
    public class ResumeRespository : Repository<CV, Guid>, IRepository<CV, Guid>, IResumeRepository
    {
        public ResumeRespository(IApplicationDbContext context) : base((DbContext)context)
        {
            
        }

        
    }
}
