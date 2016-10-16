namespace TicketMeisterIII.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tickets", "description");
        }
    }
}
