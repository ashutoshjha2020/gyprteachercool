namespace teachercoolapi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addschooltable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.schools",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        country = c.String(),
                        details = c.String(),
                        guid = c.Guid(nullable: false,defaultValueSql:"newid()"),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.schools");
        }
    }
}
