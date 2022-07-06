using CrazyBooks_DataAccess.Data;
using CrazyBooks_Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrazyBooks_DataAccess.Initializer;
using CrazyBooks_Models.Models;

namespace CrazyBooks_DataAccess.Initializer
{
    public class DbInitializer : IDbInitializer
    {
        private readonly CrazyBooksDbContext _db;

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public DbInitializer(CrazyBooksDbContext db, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _roleManager = roleManager;
            _userManager = userManager;
        }


        public void Initialize()
        {
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
            }
            catch (Exception ex)
            {

            }

            var roleStore = new RoleStore<IdentityRole>(_db);

            if (_db.Roles.Any(r => r.Name == AppConstants.SuperAdminRole)) return;

            _roleManager.CreateAsync(new IdentityRole(AppConstants.SuperAdminRole)).GetAwaiter().GetResult();
            _roleManager.CreateAsync(new IdentityRole(AppConstants.PublisherRole)).GetAwaiter().GetResult();
            IdentityResult identityResult = _roleManager.CreateAsync(new IdentityRole(AppConstants.AuthorRole)).GetAwaiter().GetResult();


            _userManager.CreateAsync(new ApplicationUser
            {
                UserName = "Grimm@CrazyBook.ca",
                Email = "Grimm@CrazyBook.ca",
                EmailConfirmed = true,
                PhoneNumber = "111111111111",
                NickName = "SuperGrimm"
            }, "Lecture1234*").GetAwaiter().GetResult();

            ApplicationUser user1 = (ApplicationUser)_db.Users.FirstOrDefault(u => u.Email == "Grimm@CrazyBook.ca");
            _userManager.AddToRoleAsync(user1, AppConstants.SuperAdminRole).GetAwaiter().GetResult();

            _userManager.CreateAsync(new ApplicationUser
            {
                UserName = "A_Cover@JaiLu.ca",
                Email = "A_Cover@JaiLu.ca",
                EmailConfirmed = true,
                PhoneNumber = "2222222222",
                NickName = "Agathe"
            }, "Lecture1234*").GetAwaiter().GetResult();

            ApplicationUser user2 = (ApplicationUser)_db.Users.FirstOrDefault(u => u.Email == "A_Cover@JaiLu.ca");
            _userManager.AddToRoleAsync(user2, AppConstants.PublisherRole).GetAwaiter().GetResult();

            _userManager.CreateAsync(new ApplicationUser
            {
                UserName = "J_Lambert@Cheneliere.ca",
                Email = "J_Lambert@Cheneliere.ca",
                EmailConfirmed = true,
                PhoneNumber = "3333333333",
                NickName = "JulesLam"
            }, "Lecture1234*").GetAwaiter().GetResult();

            ApplicationUser user3 = (ApplicationUser)_db.Users.FirstOrDefault(u => u.Email == "J_Lambert@Cheneliere.ca");
            _userManager.AddToRoleAsync(user3, AppConstants.PublisherRole).GetAwaiter().GetResult();

            _userManager.CreateAsync(new ApplicationUser
            {
                UserName = "NoraRobert@gmail.ca",
                Email = "NoraRobert@gmail.ca",
                EmailConfirmed = true,
                PhoneNumber = "4444444444",
                NickName = "Nora"
            }, "Lecture1234*").GetAwaiter().GetResult();

            ApplicationUser user4 = (ApplicationUser)_db.Users.FirstOrDefault(u => u.Email == "NoraRobert@gmail.ca");
            _userManager.AddToRoleAsync(user4, AppConstants.AuthorRole).GetAwaiter().GetResult();

            _userManager.CreateAsync(new ApplicationUser
            {
                UserName = "BernardTurgeon@gmail.ca",
                Email = "BernardTurgeon@gmail.ca",
                EmailConfirmed = true,
                PhoneNumber = "5555555555",
                NickName = "Berny"
            }, "Lecture1234*").GetAwaiter().GetResult();

            ApplicationUser user5 = (ApplicationUser)_db.Users.FirstOrDefault(u => u.Email == "BernardTurgeon@gmail.ca");
            _userManager.AddToRoleAsync(user5, AppConstants.AuthorRole).GetAwaiter().GetResult();
        }
    }
}
