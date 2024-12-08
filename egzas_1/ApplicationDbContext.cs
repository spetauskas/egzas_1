
using egzas_1.InitialData;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace egzas_1
{
    public class ApplicationDbContext : DbContext
    {
        public bool SkipSeeding { get; set; } = false;

        private readonly IConfiguration _configuration;

        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options,
            IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Account> Accounts { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seeding data if SkipSeeding is false
            if (!SkipSeeding)
            {
                modelBuilder.Entity<Account>()
                    .HasData(AccountInitialDataSeed.Accounts);
                modelBuilder.Entity<User>()
                    .HasData(UsersInitialDataSeed.Users);
            }


            //// Configure relationships with fluent API
            //modelBuilder.Entity<User>()
            //    .HasOne(u => u.Account)
            //    .WithOne(a => a.User)
            //    .HasForeignKey<User>(u => u.AccountId);
            //    //.OnDelete(DeleteBehavior.Cascade); // or .Restrict based on your requirements


        }
    }
}
