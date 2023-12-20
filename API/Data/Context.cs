using API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class Context : IdentityDbContext<user>
    {
        public Context(DbContextOptions<Context> options) : base(options) 
        {

        }
    }
}
