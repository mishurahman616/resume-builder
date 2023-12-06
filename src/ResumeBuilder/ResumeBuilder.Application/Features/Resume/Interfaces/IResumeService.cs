using ResumeBuilder.Application.Features.Resume.DTO;

namespace ResumeBuilder.Application.Features.Resume.Interfaces
{
    using CV = Domain.Entities.Resume;
    public interface IResumeService
    {
        bool CreateResume(CV resume);
        bool UpdateResume(CV resume);
        bool DeleteResume(Guid resumeId);
        CV FindResume(Guid resumeId);
        IList<ResumeDTO> GetResumes();
    }
}
