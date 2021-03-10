using GnomShop.Domain;
using GnomShop.Domain.Repositories.EF;
using GnomShop.Domain.Repositories.Interfaces;
using GnomShop.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GnomShop
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }               

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            Configuration.Bind("Project", new Config());

            //Связываем интерфейсы и их реализацию (можем заменить реализацию интерфейса EF на любую другую реализацию ORM системы)
            services.AddTransient<IPageTitleRepository, EFPageTitleRepository>();
            services.AddTransient<IProductItemRepository, EFProductItemRepository>();
            services.AddTransient<ISizeRepository, EFSizeRepository>();
            services.AddTransient<IMainSliderContent, EFMainSliderContent>();
            services.AddTransient<ICategoriesOfTheMonth, EFCategoriesOfTheMonth>();
            services.AddTransient<IDisplayedProducts, EFDisplayedProducts>();
            services.AddTransient<ICategory, EFCategory>();
            services.AddTransient<DataManager>();

            //Подключем контекст БД
            services.AddDbContext<CatalogDbContext>(x => x.UseSqlServer(Config.ConnectionString));

            //Определение требований для Identity системы
            services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {
                options.User.RequireUniqueEmail = true;
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireDigit = true;
            }).AddEntityFrameworkStores<CatalogDbContext>().AddDefaultTokenProviders();

            //Настройка куки для аутентификация
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = "Authorization";
                options.Cookie.HttpOnly = true;
                options.LoginPath = "/account/login";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true;
            });
            services.AddAuthorization(x => x.AddPolicy("AdminArea", policy => { policy.RequireRole("admin"); }));

            //Добавление MVC и сервисы для него
            services.AddControllersWithViews(x => x.Conventions.Add(new AdminAreaAuthorization("Admin", "AdminArea")))
                .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider(); ;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "admin", 
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                    );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
