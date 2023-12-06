using Microsoft.EntityFrameworkCore;
using ResumeBuilder.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Persistence
{
    public interface IApplicationDbContext
    {
         DbSet<Resume> Resumes { get; set; }
         DbSet<Skill> Skills { get; set; }
    }
}
