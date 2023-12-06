using Microsoft.EntityFrameworkCore;
using ResumeBuilder.Application.Features.Resume.Interfaces;
using ResumeBuilder.Domain.Entities;
using ResumeBuilder.Persistence;
using ResumeBuilder.Persistence.Features.Resume.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Application.Features.Resume.Services
{
    public class SkillService : ISkillService
    {
        private readonly ISkillRepository _skillRepository;
        public SkillService(ISkillRepository skillRepository)
        {
            _skillRepository = skillRepository;
            
        }
        public bool CreateSkill(Skill skill)
        {
            _skillRepository.Create(skill);
            return _skillRepository.Save();
        }

        public bool DeleteSkill(Guid skilId)
        {
            _skillRepository.Delete(skilId);
            return _skillRepository.Save();
        }

        public Skill FindSkill(Guid skilId)
        {
            return _skillRepository.GetById(skilId);
        }

        public IList<Skill> GetAllSkills()
        {
            return _skillRepository.GetAll();
        }

        public bool UpdateSkill(Skill skill)
        {
            _skillRepository.Edit(skill);
            return _skillRepository.Save();
        }
    }
}
