using EmailManager.Model;
using Microsoft.EntityFrameworkCore;

namespace EmailManager.Repository
{
    public class AppDbContext : DbContext
    {
        #region Properties

        public virtual DbSet<Message> Messages { get; set; }

        #endregion

        #region Constructors

        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {

        }

        #endregion
    }
}
