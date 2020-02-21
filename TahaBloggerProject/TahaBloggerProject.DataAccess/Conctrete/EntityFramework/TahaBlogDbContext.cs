using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TahaBloggerProject.Entities.Models;


namespace TahaBloggerProject.DataAccess.Conctrete.EntityFramework
{
   public  class TahaBlogDbContext : DbContext
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

        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Post> Posts { get; set; }
  
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<PostImage> PostImages { get; set; }
    }
}
