using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace MvcClient.Domain.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}
