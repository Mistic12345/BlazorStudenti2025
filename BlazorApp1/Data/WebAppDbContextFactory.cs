using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BlazorApp1.Data
{
    public class WebAppDbContextFactory : IDesignTimeDbContextFactory<WebAppContext>
    {
        public WebAppContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<WebAppContext>();
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-UR3NLOV\\SQLEXPRESS01;Initial Catalog=_SDb001;Integrated Security=True;Trust Server Certificate=True;");

            return new WebAppContext(optionsBuilder.Options);
        }
    }
}
