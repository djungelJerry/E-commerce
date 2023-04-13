using Microsoft.EntityFrameworkCore;

namespace MVC.E_Commerce
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }
    }
}
