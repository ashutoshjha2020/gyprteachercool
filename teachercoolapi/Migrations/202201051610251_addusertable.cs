namespace teachercoolapi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addusertable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(maxLength: 150),
                        mobile = c.String(),
                        altmobile = c.String(),
                        email = c.String(),
                        username = c.String(),
                        password = c.String(),
                        profileimg = c.String(),
                        categoryid = c.Int(nullable: false,defaultValue:0),
                        isactive = c.Int(nullable: false, defaultValue: 0),
                        createdby = c.Int(nullable: false, defaultValue: 0),
                        createdon = c.DateTime(nullable: false,defaultValueSql:"getdate()"),
                        createdip = c.String(),
                        updatedip = c.String(),
                        updatedby = c.Int(nullable: false, defaultValue: 0),
                        updatedon = c.DateTime(),
                        guid = c.Guid(nullable: false, defaultValueSql: "newid()"),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.usercategories",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(maxLength: 100),
                        details = c.String(),
                        isactive = c.Int(nullable: false,defaultValue:0),
                        createdby = c.Int(nullable: false, defaultValue: 0),
                        createdon = c.DateTime(nullable: false, defaultValueSql: "getdate()"),
                        createdip = c.String(),
                        updatedip = c.String(),
                        updatedby = c.Int(nullable: false, defaultValue: 0),
                        updatedon = c.DateTime(),
                        guid = c.Guid(nullable: false, defaultValueSql: "newid()"),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.usercategories");
            DropTable("dbo.users");
        }
    }
}
