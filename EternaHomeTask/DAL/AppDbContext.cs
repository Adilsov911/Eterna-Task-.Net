using EternaHomeTask.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaHomeTask.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions <AppDbContext> options) : base(options)
        {

        }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Search> Searches { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Home> Homes { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<PricingService> PricingServices { get; set; }
    }
}
