using ResumeBuilder.Application.Features.Resume.DTO;

namespace ResumeBuilder.Application.Features.Resume.Services
{
    using CV = ResumeBuilder.Domain.Entities.Resume;
    public interface IResumeService
    {
        void CreateResume(CV resume);
        void UpdateResume(CV resume);
        void DeleteResume(Guid resumeId);
        CV FindResume(Guid resumeId);
        IList<ResumeListDTO> GetResumes();
    }
}
