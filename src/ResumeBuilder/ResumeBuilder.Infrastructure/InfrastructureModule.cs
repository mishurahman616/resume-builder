﻿using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Infrastructure
{
    public class InfrastructureModule : Module
    {
        public InfrastructureModule() { }
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
        }
    }
}
