namespace DziennikSzkolny3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAdnotationsKlasa : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Klasas", "Nazwa", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Klasas", "Nazwa", c => c.String());
        }
    }
}
