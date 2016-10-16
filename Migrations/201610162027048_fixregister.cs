namespace TicketMeisterIII.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixregister : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "SecurityQuestion", c => c.String());
            AddColumn("dbo.AspNetUsers", "SecurityAnswer", c => c.String());
            DropColumn("dbo.AspNetUsers", "securityQ1");
            DropColumn("dbo.AspNetUsers", "SecirutyA1");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "SecirutyA1", c => c.String());
            AddColumn("dbo.AspNetUsers", "securityQ1", c => c.String());
            DropColumn("dbo.AspNetUsers", "SecurityAnswer");
            DropColumn("dbo.AspNetUsers", "SecurityQuestion");
        }
    }
}
