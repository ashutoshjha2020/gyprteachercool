namespace teachercoolapi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcoursetable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.courses",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        edition = c.String(),
                        name = c.String(),
                        details = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.questionbanks", "courseid", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.questionbanks", "courseid");
            DropTable("dbo.courses");
        }
    }
}
