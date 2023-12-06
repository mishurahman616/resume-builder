using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Domain.Entities
{
    public class Training
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Organization { get; set; }
        public Guid ResumeId { get; set; }
        public Resume Resume { get; set; }
    }
}
