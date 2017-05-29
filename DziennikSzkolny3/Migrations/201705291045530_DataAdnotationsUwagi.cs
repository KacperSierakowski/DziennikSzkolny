namespace DziennikSzkolny3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAdnotationsUwagi : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Uwagis", "Uwaga", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Uwagis", "Uwaga", c => c.String());
        }
    }
}
