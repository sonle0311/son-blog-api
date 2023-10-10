using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace SonBlog.Data
{
    public class SonBlogContextFactory : IDesignTimeDbContextFactory<SonBlogContext>
    {
        public SonBlogContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json")
                 .Build();
            var builder = new DbContextOptionsBuilder<SonBlogContext>();
            builder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            return new SonBlogContext(builder.Options);
        }
    }
}
