namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Authors", "AuthorImage", c => c.String(maxLength: 300));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Authors", "AuthorImage", c => c.String(maxLength: 100));
        }
    }
}
