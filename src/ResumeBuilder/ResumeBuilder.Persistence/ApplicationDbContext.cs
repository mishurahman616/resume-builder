using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResumeBuilder.Domain.Entities;
using System.Text.Json.Serialization;
using System.Text.Json;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ResumeBuilder.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        private readonly string _connectionString;
        private readonly string _migrationsAssembly;
        public ApplicationDbContext(string connectionString, string migrationsAssembly)
        {
            _connectionString = connectionString;
            _migrationsAssembly = migrationsAssembly;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString, x => x.MigrationsAssembly(_migrationsAssembly));
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ResumeSkill>()
                .HasKey(rs => new { rs.ResumeId, rs.SkillId });
            builder.Entity<ResumeSkill>()
                .HasOne(rs => rs.Resume)
                .WithMany(rs => rs.Skills)
                .HasForeignKey(rs => rs.ResumeId);
            builder.Entity<ResumeSkill>()
                .HasOne(rs => rs.Skill)
                .WithMany(rs => rs.Resumes)
                .HasForeignKey(rs => rs.SkillId);
            base.OnModelCreating(builder);
            
        }
        protected DbSet<Resume> Resumes { get; set; }
    }
}
