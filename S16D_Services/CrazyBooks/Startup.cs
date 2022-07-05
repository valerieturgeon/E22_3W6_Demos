using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrazyBooks_DataAccess.Data;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Options;
using CrazyBooks_Services.Interfaces;
using CrazyBooks_Services;
using Microsoft.AspNetCore.Identity;
using CrazyBooks_Models.Models;

namespace CrazyBooks
{
    public class Startup
    {
        // TODO 01: Ajoutez les cultures supportées ici
        private CultureInfo[] supportedCultures = new[]
          {
                new CultureInfo("en-US"),
                new CultureInfo("fr-CA"),
                new CultureInfo("es-ES")
            };

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IAuthorsService, AuthorsService>();
            services.AddScoped<IBooksService, BooksService>();
            services.AddScoped<IPublishersService, PublishersService>();
            services.AddScoped<ISubjectsService, SubjectsService>();

           
            // TODO 03: Configurer le service AVEC AddControllersWithViews
            #region Localization
            services.AddLocalization(options => options.ResourcesPath = "Resources");
            services.AddControllersWithViews().AddRazorRuntimeCompilation()
                    .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
           
              // i18n Pour modèle de données la méthode fichiers ressources séparés
            //.AddDataAnnotationsLocalization();

            // i18n Pour modèle de données la méthode Ressources partagées
            .AddDataAnnotationsLocalization(options =>
            {
                options.DataAnnotationLocalizerProvider = (type, factory) =>
                    factory.Create(typeof(SharedResource)); //nom de la classe créée vide, attention au PATH
            });
            services.AddRazorPages();

            services.Configure<RequestLocalizationOptions>(options =>
            {
                options.DefaultRequestCulture = new RequestCulture(culture: "en-US", uiCulture: "en-US");
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
            });

            #endregion
            services.AddDbContext<CrazyBooksDbContext>(options =>
           options.UseSqlServer(
           Configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentity<IdentityUser, IdentityRole>()
              .AddEntityFrameworkStores<CrazyBooksDbContext>().AddDefaultUI();

            #region Configuration pour Session
            services.AddHttpContextAccessor();
            services.AddSession(Options =>
            {
                Options.IdleTimeout = TimeSpan.FromMinutes(10);
                Options.Cookie.HttpOnly = true;
                Options.Cookie.IsEssential = true;
            });
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // TODO 04:Récupération des options de localisation 
            var locOptions = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>();
            app.UseRequestLocalization(locOptions.Value);

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

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
