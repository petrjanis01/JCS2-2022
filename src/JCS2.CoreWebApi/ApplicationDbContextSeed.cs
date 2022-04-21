using System;
using System.Linq;
using JCS2.CoreWebApi.Entities;

namespace JCS2.CoreWebApi
{
    public static class ApplicationDbContextSeed
    {
        private static ApplicationDbContext _context;

        public static void SeedDatabase(ApplicationDbContext context)
        {
            _context = context;

            CreateUsers();
        }

        private static void CreateUsers()
        {
            if (_context.Users.Any())
            {
                return;
            }

            var rnd = new Random();

            for (var i = 0; i < 20; i++)
            {
                var user = new User { Name = $"User {i}", BirthDate = DateTime.Now.AddYears(-rnd.Next(10, 40)) };
                _context.Users.Add(user);
            }

            _context.SaveChanges();
        }
    }
}
