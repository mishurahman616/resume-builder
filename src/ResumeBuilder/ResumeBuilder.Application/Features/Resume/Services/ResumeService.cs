using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using ResumeBuilder.Application.Features.Resume.DTO;
using ResumeBuilder.Application.Features.Resume.Interfaces;
using ResumeBuilder.Domain.Entities;
using ResumeBuilder.Persistence.Features.Resume.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Application.Features.Resume.Services
{
    public class ResumeService : IResumeService
    {
        private readonly IResumeRepository _resumeRepository;
        public ResumeService(IResumeRepository resumeRepository) 
        {
            _resumeRepository = resumeRepository;
        }
        public bool CreateResume(Domain.Entities.Resume resume)
        {
            _resumeRepository.Create(resume);
            return _resumeRepository.Save();
        }

        public bool DeleteResume(Guid resumeId)
        {
            _resumeRepository.Delete(resumeId);
            return _resumeRepository.Save();
        }

        public Domain.Entities.Resume FindResume(Guid resumeId)
        {
            return _resumeRepository.GetById(resumeId);
        }

        public IList<ResumeDTO> GetResumes()
        {
            return _resumeRepository.GetAll().Select(x=>new ResumeDTO { Id=x.Id, Name=x.ResumeTitle}).ToList();
        }

        public bool UpdateResume(Domain.Entities.Resume resume)
        {
            _resumeRepository.Edit(resume);
            return _resumeRepository.Save();
        }
    }
}
