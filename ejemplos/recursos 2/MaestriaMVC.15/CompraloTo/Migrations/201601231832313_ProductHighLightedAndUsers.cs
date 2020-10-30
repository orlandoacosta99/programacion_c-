namespace CompraloTo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductHighLightedAndUsers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        email = c.String(nullable: false, maxLength: 200),
                        password = c.String(nullable: false, maxLength: 50),
                        token = c.String(nullable: false, maxLength: 50),
                        createDate = c.DateTime(nullable: false),
                        role = c.Int(nullable: false),
                        customerID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.customers", t => t.customerID)
                .Index(t => t.customerID);
            
            AddColumn("dbo.products", "highlighted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.users", "customerID", "dbo.customers");
            DropIndex("dbo.users", new[] { "customerID" });
            DropColumn("dbo.products", "highlighted");
            DropTable("dbo.users");
        }
    }
}
