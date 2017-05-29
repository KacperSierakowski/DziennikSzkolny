namespace DziennikSzkolny3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAdnotationsNauczyciel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Nauczyciels", "Imie", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Nauczyciels", "Nazwisko", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Nauczyciels", "Telefon", c => c.String(maxLength: 11));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Nauczyciels", "Telefon", c => c.String());
            AlterColumn("dbo.Nauczyciels", "Nazwisko", c => c.String());
            AlterColumn("dbo.Nauczyciels", "Imie", c => c.String());
        }
    }
}
