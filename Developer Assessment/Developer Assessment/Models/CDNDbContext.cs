using Developer_Assessment.Models.Entity.Freelancers;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.Common;
using System.Text.RegularExpressions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Developer_Assessment.Models
{

    public class CDNDbContext : DbContext
    {
        public CDNDbContext(DbContextOptions<CDNDbContext> options)
        : base(options)
        {
        }
        public DbSet<Freelancer> Freelancers { get; set; }  // Your DbSet
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Freelancer>().HasData(
                new Freelancer
                { Id=1,
                    Username = "John Doe",
                    Mail = "john.doe@example.com",
                    PhoneNumber = "123-456-7890",
                    SkillSets = "C#, SQL, ASP.NET",
                    Hobby = "Photography",
                    CreatedTime = DateTime.UtcNow,
                    ModifiedTime = DateTime.UtcNow,
                    isActive = true
                },
                new Freelancer
                { Id=2,
                    Username = "Jane Smith",
                    Mail = "jane.smith@example.com",
                    PhoneNumber = "234-567-8901",
                    SkillSets = "Java, Spring, Hibernate",
                    Hobby = "Cycling",
                    CreatedTime = DateTime.UtcNow,
                    ModifiedTime = DateTime.UtcNow,
                    isActive = true
                },
                new Freelancer
                { Id=3,
                    Username = "Michael Brown",
                    Mail = "michael.brown@example.com",
                    PhoneNumber = "345-678-9012",
                    SkillSets = "Python, Django, AI",
                    Hobby = "Reading",
                    CreatedTime = DateTime.UtcNow,
                    ModifiedTime = DateTime.UtcNow,
                    isActive = true
                }
            );
        }

    }
}