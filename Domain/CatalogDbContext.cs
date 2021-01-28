using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using GnomShop.Models;
using GnomShop.Services;
using Microsoft.EntityFrameworkCore;

namespace GnomShop.Domain
{
    public class CatalogDbContext : IdentityDbContext<IdentityUser>
    {
        public CatalogDbContext(DbContextOptions<CatalogDbContext> options) : base(options) { }

        public DbSet<Image> Images { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<PageTitle> PageTitles { get; set; }
        public DbSet<ProductItem> ProductItems { get; set; }        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "96ba8f64-053a-4574-a0bb-b73ecc88c761",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "4c6e757b-ecb2-40a8-94fe-a2d3ecca28ca",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = Config.CompanyEmail,
                NormalizedEmail = Config.CompanyEmail,
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "gnomsemik"),
                SecurityStamp = string.Empty
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "96ba8f64-053a-4574-a0bb-b73ecc88c761",
                UserId = "4c6e757b-ecb2-40a8-94fe-a2d3ecca28ca"
            });

            builder.Entity<PageTitle>().HasData(new PageTitle
            {
                Id = new Guid("94b842cd-7976-4dfb-b071-7a5cbab4617a"),
                CodeWord = "PageIndex",
                Title = "Главная"
            });

            builder.Entity<PageTitle>().HasData(new PageTitle
            {
                Id = new Guid("8773f462-a492-4654-8945-b97204271824"),
                CodeWord = "PageCatalog",
                Title = "Каталог"
            });

            builder.Entity<PageTitle>().HasData(new PageTitle
            {
                Id = new Guid("6fd4e3f7-f892-407b-ac03-e4354f834dc0"),
                CodeWord = "PageContacts",
                Title = "Контакты"
            });

            builder.Entity<PageTitle>().HasData(new PageTitle
            {
                Id = new Guid("ea285ed5-1f80-4cbe-91d7-4d07e0a861b8"),
                CodeWord = "PageAbout",
                Title = "О нас"
            });
        }

    }
}
