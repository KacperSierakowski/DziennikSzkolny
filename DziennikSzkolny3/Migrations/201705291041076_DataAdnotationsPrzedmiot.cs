namespace DziennikSzkolny3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAdnotationsPrzedmiot : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Przedmiots", "Nazwa_Przedmiotu", c => c.String(nullable: false, maxLength: 15));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Przedmiots", "Nazwa_Przedmiotu", c => c.String());
        }
    }
}
