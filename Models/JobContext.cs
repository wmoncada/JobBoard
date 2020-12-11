using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace JobBoard.Models
{
    public class JobContext : DbContext
    {
        public DbSet<Job> Jobs { get; set; }
        public JobContext(DbContextOptions<JobContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var Jobs = generateJobs();

            modelBuilder.Entity<Job>().HasData(Jobs.ToArray());

        }
        
        private List<Job> generateJobs()
        {
            List<Job> jobs = new List<Job>();

            for (int i = 0; i < 50; i++)
            {
                jobs.Add(new Job(id: Guid.NewGuid().ToString(), title: "Test Job " + (i + 1), desc: "This is the test job", created: DateTime.Today, expires: DateTime.Today.Add(new System.TimeSpan(36, 0, 0, 0))));
            }

            return jobs;
            /*
            return new List<Job>() {
                new Job(id: Guid.NewGuid().ToString(),title: "Test Job 1",desc: "This is the test job",created: DateTime.Today,expires: DateTime.Today.Add(new System.TimeSpan(36, 0, 0, 0))),
            new Job(id: Guid.NewGuid().ToString(),title: "Test Job 2",desc: "This is the test job",created: DateTime.Today,expires: DateTime.Today.Add(new System.TimeSpan(15, 0, 0, 0))),
            new Job(id: Guid.NewGuid().ToString(),title: "Test Job 3",desc: "This is the test job",created: DateTime.Today,expires: DateTime.Today.Add(new System.TimeSpan(30, 0, 0, 0))),
            new Job(id: Guid.NewGuid().ToString(),title: "Test Job 4",desc: "This is the test job",created: DateTime.Today,expires: DateTime.Today.Add(new System.TimeSpan(25, 0, 0, 0))),
            new Job(id: Guid.NewGuid().ToString(),title: "Test Job 5",desc: "This is the test job",created: DateTime.Today,expires: DateTime.Today.Add(new System.TimeSpan(25, 0, 0, 0)))
            };
            */
        }
        
    }
}