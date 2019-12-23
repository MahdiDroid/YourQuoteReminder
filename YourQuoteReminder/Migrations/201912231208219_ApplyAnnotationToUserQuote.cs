namespace YourQuoteReminder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationToUserQuote : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Quotes", "UserQuote", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Quotes", "UserQuote", c => c.String());
        }
    }
}
