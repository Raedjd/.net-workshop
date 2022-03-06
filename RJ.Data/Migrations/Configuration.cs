namespace RJ.Data.Migrations
{
    using RJ.Domaine;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RJ.Data.RJContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RJ.Data.RJContext context)
        {   //--------------------------------------semaine6-----------------------------//

            //start a test
            Category cat = new Category() { Name = "electronic" };
            context.add(cat);
            context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
