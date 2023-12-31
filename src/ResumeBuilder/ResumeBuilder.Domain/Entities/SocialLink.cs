﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Domain.Entities
{
    public class SocialLink
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string? IconUrl { get; set; }
        public Guid ResumeId { get; set; }
        public Resume Resume { get; set; }
    }
}
