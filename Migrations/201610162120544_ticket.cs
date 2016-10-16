namespace TicketMeisterIII.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ticket : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        ticketID = c.Int(nullable: false, identity: true),
                        customerID = c.String(),
                        subject = c.String(nullable: false),
                        response = c.String(),
                        date = c.String(),
                        open = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ticketID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tickets");
        }
    }
}
