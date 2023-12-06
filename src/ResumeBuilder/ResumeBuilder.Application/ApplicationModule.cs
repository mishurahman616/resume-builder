using Autofac;
using ResumeBuilder.Application.Features.Resume.Interfaces;
using ResumeBuilder.Application.Features.Resume.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Application
{
    public class ApplicationModule:Module
    {
        public ApplicationModule() { }
        protected override void Load(ContainerBuilder cb)
        {
            cb.RegisterType<ResumeService>().As<IResumeService>().InstancePerLifetimeScope();
            cb.RegisterType<SkillService>().As<ISkillService>().InstancePerLifetimeScope();
            base.Load(cb);
        }
    }
}
