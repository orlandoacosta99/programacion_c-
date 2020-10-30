namespace CompraloTo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using CompraloTo.Domain;

    internal sealed class Configuration : DbMigrationsConfiguration<CompraloTo.DB.GlobalDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CompraloTo.DB.GlobalDbContext context)
        {

            context.Set<User>().AddOrUpdate(

                m => m.email,
                new User() {
                    email = "mopicus@hotmail.com",
                    password = "1234", activated = true,
                    createDate = DateTime.Now,
                    role = UserRole.Admin,
                    token = "", }

            );

            context.Set<ProductCategory>().AddOrUpdate(
                m => m.name,
                new ProductCategory() { name = "Productos para la playa" }
            );

            context.Set<ProductCategory>().AddOrUpdate(
                m => m.name,
                new ProductCategory() { name = "Móviles" }
            );

            context.Set<ProductCategory>().AddOrUpdate(
                m => m.name,
                new ProductCategory() { name = "Electrodomésticos" }
            );


        }
    }
}
