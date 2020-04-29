using Microsoft.EntityFrameworkCore;
using TahaBloggerProject.Core.Entities.Concrete;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.DataAccess.Conctrete.EntityFramework
{
    public class TahaBlogDbContext : DbContext
    {
        public TahaBlogDbContext()
        {
        }

        public TahaBlogDbContext(DbContextOptions<TahaBlogDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=TahasBlogDb;Integrated Security=True;");
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Like> Like { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<OperationClaim> OperationClaim { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaim { get; set; }


        public DbSet<User> User { get; set; }
        public DbSet<UserRole> UserRole { get; set; }

        public DbSet<PostImage> PostImage { get; set; }
    }
}