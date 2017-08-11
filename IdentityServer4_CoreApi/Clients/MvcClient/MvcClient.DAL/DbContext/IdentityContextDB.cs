using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MvcClient.Domain.Models;

namespace MvcClient.DAL.DbContext
{
    public class IdentityContextDB: IdentityDbContext<User>
    {
        public IdentityContextDB(DbContextOptions<IdentityContextDB> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
