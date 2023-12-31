﻿using Autofac;
using ResumeBuilder.Persistence.Features.Resume.Interfaces;
using ResumeBuilder.Persistence.Features.Resume.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Persistence
{
    public class PersistenceModule: Module
    {
        private readonly string _connectionString;
        private readonly string _migrationsAssembly;
        public PersistenceModule(string connectionString, string migrationsAssembly ) 
        { 
            _connectionString = connectionString;
            _migrationsAssembly = migrationsAssembly;
        }
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationDbContext>().AsSelf()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationsAssembly", _migrationsAssembly)
                .InstancePerLifetimeScope();
            builder.RegisterType<ApplicationDbContext>().As<IApplicationDbContext>()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationsAssemblyl", _migrationsAssembly)
                .InstancePerLifetimeScope();
            builder.RegisterType<SkillRepository>().As<ISkillRepository>().InstancePerLifetimeScope();
            builder.RegisterType<ResumeRespository>().As<IResumeRepository>().InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}
