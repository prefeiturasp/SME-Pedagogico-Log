using Microsoft.EntityFrameworkCore;

namespace SME.Pedagogico.Log.Contexts
{
    public class SmeLogContext : DbContext
    {
        #region ==================== ATTRIBUTES ====================

        private string connectionString = "Server=localhost;Port=5432;Database=smeLogDB;Username=postgres;Password=39162604;";

        public DbSet<Models.Action> Actions { get; set; }
        public DbSet<Models.Application> Applications { get; set; }
        public DbSet<Models.Connection> Connections { get; set; }
        public DbSet<Models.Entry> Entries { get; set; }
        public DbSet<Models.Permission> Permissions { get; set; }
        public DbSet<Models.User> Users { get; set; }

        #endregion ==================== ATTRIBUTES ====================

        #region ==================== CONSTRUCTORS ====================

        public SmeLogContext()
            : base()
        { }

        public SmeLogContext(string connectionString)
            : base()
        {
            this.connectionString = connectionString;
        }

        #endregion ==================== CONSTRUCTORS ====================

        #region ==================== METHODS ====================

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
        }

        #endregion ==================== METHODS ====================
    }
}