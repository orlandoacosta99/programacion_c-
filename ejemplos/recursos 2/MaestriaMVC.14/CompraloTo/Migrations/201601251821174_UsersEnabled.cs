namespace CompraloTo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UsersEnabled : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.users", "activated", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.users", "activated");
        }
    }
}
