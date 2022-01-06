namespace teachercoolapi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcoursetablecolumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.courses", "createdon", c => c.DateTime(nullable: false,defaultValueSql:"getdate()"));
            AddColumn("dbo.courses", "guid", c => c.Guid(nullable: false, defaultValueSql: "newid()"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.courses", "guid");
            DropColumn("dbo.courses", "createdon");
        }
    }
}
