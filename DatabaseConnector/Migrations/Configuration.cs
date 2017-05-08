namespace DatabaseConnector.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DatabaseConnector.MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DatabaseConnector.MyDbContext context)
        {
            if (context.Users.Count() == 0)
            {
                for (int i = 1; i < 21; i++)
                {
                    context.Users.Add(new User
                    {
                        Name = "User" + i,
                        Surname = "Surname" + i,
                        LastName = "LastName" + i,
                        City = "City" + i,
                        Country = "Ukraine",
                        Email = $"useremail{i}@gmail.com",
                        Phone = "11111111" + i
                    });
                }
            }
        }
    }
}
