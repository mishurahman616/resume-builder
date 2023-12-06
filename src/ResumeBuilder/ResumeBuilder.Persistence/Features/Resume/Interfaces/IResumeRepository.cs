using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Persistence.Features.Resume.Interfaces
{
    public interface IResumeRepository: IRepository<Domain.Entities.Resume, Guid>
    {

    }
}
