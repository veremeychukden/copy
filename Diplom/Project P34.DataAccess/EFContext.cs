using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project_P34.DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_P34.DataAccess
{
    public class EFContext : IdentityDbContext<User>
    {
        public EFContext(DbContextOptions<EFContext> options): base(options) { }

        public DbSet<Cart> carts { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Commentaries> commentaries { get; set; }
        public DbSet<Images> images { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Subcategory> subCategories { get; set; }
        public DbSet<UserMoreInfo> userMoreInfos { get; set; }
        public DbSet<ViewedProducts> viewedProducts { get; set; }
        public DbSet<WishList> wishLists { get; set; }
      



        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasOne(u => u.UserMoreInfo)
                .WithOne(t => t.User)
                .HasForeignKey<UserMoreInfo>(ui => ui.Id);

            builder.Entity<Commentaries>().HasOne(pt => pt.UserMoreInfo)
            .WithMany(p => p.Commentariess)
      .HasForeignKey(pt => pt.UserId);

            base.OnModelCreating(builder);
        }


    }
}
