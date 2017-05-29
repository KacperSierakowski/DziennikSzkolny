namespace DziennikSzkolny3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAdnotationsUczen : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ocenas", "Komentarz", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ocenas", "Komentarz", c => c.String());
        }
    }
}
