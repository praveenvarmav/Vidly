namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Type", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Type");
        }
    }
}
