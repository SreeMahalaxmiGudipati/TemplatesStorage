using TemplatesStorage.Models;
using Microsoft.EntityFrameworkCore;

namespace TemplatesStorage.Data
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions options) : base(options)
        {
        }
        //entity mapping is required to create table in db in model class
        public DbSet<Template> Templatestable { get; set; }
        public DbSet<ProfessionalTemplate> ProfessionalTabel{ get; set; }
        public DbSet<FriendlyTemplate> FriendlyTabel{ get; set; }
        public DbSet<ModernTemplate> ModernTabel{ get; set; }
        public DbSet<ElegantTemplate> ElegantTabel{ get; set; }
        public DbSet<CreativeTemplate> CreativeTabel{ get; set; }
    }
}
