namespace DziennikSzkolny3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAdnotationsUczen1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Uczens", "Imie", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Uczens", "Nazwisko", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Uczens", "Telefon", c => c.String(maxLength: 11));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Uczens", "Telefon", c => c.String());
            AlterColumn("dbo.Uczens", "Nazwisko", c => c.String());
            AlterColumn("dbo.Uczens", "Imie", c => c.String());
        }
    }
}
