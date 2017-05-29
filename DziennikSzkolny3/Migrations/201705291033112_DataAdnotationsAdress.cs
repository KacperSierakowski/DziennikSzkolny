namespace DziennikSzkolny3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAdnotationsAdress : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Adres", "Kraj", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Adres", "Miejscowosc", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Adres", "Ulica", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Adres", "NumerBudynku", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Adres", "NumerBudynku", c => c.String());
            AlterColumn("dbo.Adres", "Ulica", c => c.String());
            AlterColumn("dbo.Adres", "Miejscowosc", c => c.String());
            AlterColumn("dbo.Adres", "Kraj", c => c.String());
        }
    }
}
