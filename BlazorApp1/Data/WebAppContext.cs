using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data
{
    public class WebAppContext : DbContext
    {
        public WebAppContext(DbContextOptions<WebAppContext> options) : base(options)
        {
        }

        public DbSet<Studente> studenti {  get; set; }

        internal async Task SaveChangeAsync()
        {
            throw new NotImplementedException();
        }
    }
}
