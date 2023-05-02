using marlin_challenge_back_end.Data.Map;
using marlin_challenge_back_end.Models;
using Microsoft.EntityFrameworkCore;
namespace marlin_challenge_back_end.Data
{
    public class MarlinDbContext : DbContext
    {
   
        public MarlinDbContext(DbContextOptions<MarlinDbContext> options) : base(options) 
        {
        
        }

        public DbSet<PostModel> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PostMap());
            base.OnModelCreating(modelBuilder);
        }

    }
}
