using CaseFiles.Data;
using CaseFiles.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaseFiles.DataAccess.Data
{
    public class DbInitializer : IDbInitializer
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;

        public DbInitializer(ApplicationDbContext db, UserManager<IdentityUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        public async void Initialize()
        {
            try
            {
                if(_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
            }
            catch (Exception e)
            {

            }

            _userManager.CreateAsync(new ApplicationUser
            {
                UserName = "explorer@casefiles.com",
                Email = "explorer@casefiles.com",
                Name = "Explorer",
                EmailConfirmed = true
            }, "Letmein123!").GetAwaiter().GetResult();

            await _db.SaveChangesAsync();
        }
    }
}
