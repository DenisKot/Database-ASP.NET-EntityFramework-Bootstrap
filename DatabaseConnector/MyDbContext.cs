namespace DatabaseConnector
{
    using System.Data.Entity;

    public class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("name=MyDbContext")
        {
        }

        public virtual DbSet<User> Users { get; set; }
    }
}