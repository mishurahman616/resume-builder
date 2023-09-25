using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Domain.Entities
{
    public class ResumeTemplate:IEntity<Guid>
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public string? ThumbnailImageName { get; set; }
        public ICollection<Resume>? Resumes { get; set; }
    }
}
