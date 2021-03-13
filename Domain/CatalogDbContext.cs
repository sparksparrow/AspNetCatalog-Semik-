using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using GnomShop.Models;
using GnomShop.Services;
using Microsoft.EntityFrameworkCore;
using GnomShop.Models.DbEntities;

namespace GnomShop.Domain
{
    public class CatalogDbContext : IdentityDbContext<IdentityUser>
    {
        public CatalogDbContext(DbContextOptions<CatalogDbContext> options) : base(options) { }

        public DbSet<Image> Images { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<PageTitle> PageTitles { get; set; }
        public DbSet<ProductItem> ProductItems { get; set; }
        public DbSet<MainSliderContent> MainSliderContents { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoriesOfTheMonth> CategoriesOfTheMonths { get; set; }
        public DbSet<DisplayedProducts> DisplayedProducts { get; set; }

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
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "1"),
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

            builder.Entity<MainSliderContent>().HasData(new MainSliderContent
            {
                Id = new Guid("533effa6-5734-4a7b-a0df-bfe7cd1f70ec"),
                Title = "Все по честному",
                Description = "Покупаем и продаем по справедливым ценам."
            });

            builder.Entity<MainSliderContent>().HasData(new MainSliderContent
            {
                Id = new Guid("22526841-1fbd-4cf0-a47d-3633b34b8203"),
                Title = "Красиво - не значит дрого",
                Description = "Мы находим и придумываем самые оригинальные модели."
            });

            builder.Entity<MainSliderContent>().HasData(new MainSliderContent
            {
                Id = new Guid("2db8e5d3-f584-4cc3-b7ff-29a8f2c1e5fd"),
                Title = "Всегда на связи",
                Description = "Наши контакты вы можете найти на сайте"
            });

            builder.Entity<Category>().HasData(new Category
            {
                Id = new Guid("ad7dc04e-c931-4cb3-ae77-ee424e1bdfa4"),
                ProductItemType = default,
                CategoriesOfTheMonthId = new Guid("c47769a0-9fa9-49ed-b498-5ccc2fb0fad2")
            });

            builder.Entity<Category>().HasData(new Category
            {
                Id = new Guid("a6289bfa-f30e-436b-b8e7-3037d2324a95"),
                ProductItemType = default,
                CategoriesOfTheMonthId = new Guid("c47769a0-9fa9-49ed-b498-5ccc2fb0fad2")
            });

            builder.Entity<Category>().HasData(new Category
            {
                Id = new Guid("ff210f50-7193-4f8e-8189-0521fdad28d2"),
                ProductItemType = default,
                CategoriesOfTheMonthId = new Guid("c47769a0-9fa9-49ed-b498-5ccc2fb0fad2")
            });

            builder.Entity<CategoriesOfTheMonth>().HasData(new CategoriesOfTheMonth
            {
                Id = new Guid("c47769a0-9fa9-49ed-b498-5ccc2fb0fad2"),
                Title = "Категории месяца",
                Description = "Популярно на данный момент."
            }) ;

            builder.Entity<DisplayedProducts>().HasData(new DisplayedProducts
            {
                Id = new Guid("75870a12-4373-430b-ba0a-896f12ededa5"),
                Title = "Лучшие продукты",
                Description = "Здесь мы выбираем самые оригинальные модели"
            });
        }   
    }
}
