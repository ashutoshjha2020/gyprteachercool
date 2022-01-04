namespace teachercoolapi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newtable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.books",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        edition = c.String(),
                        publisher = c.String(),
                        diemension = c.String(),
                        weight = c.String(),
                        details = c.String(),
                        downloadlink = c.String(),
                        listprice = c.Decimal(nullable: false, precision: 18, scale: 2,defaultValue:0),
                        currentprice = c.Decimal(nullable: false, precision: 18, scale: 2, defaultValue: 0),
                        isused = c.Int(nullable: false, defaultValue: 0),
                        currency = c.String(),
                        totdownload = c.Int(nullable: false, defaultValue: 0),
                        writer = c.String(),
                        coverimg = c.String(),
                        isfree = c.Int(nullable: false, defaultValue: 0),
                        isbn = c.String(),
                        isbn13 = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.questionbanks",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        question = c.String(),
                        metakeywords = c.String(),
                        metadescription = c.String(),
                        metatitle = c.String(),
                        shortanswer = c.String(),
                        fullanswer = c.Decimal(nullable: false, precision: 18, scale: 2, defaultValue: 0),
                        price = c.Decimal(nullable: false, precision: 18, scale: 2, defaultValue: 0),
                        isexchange = c.Int(nullable: false, defaultValue: 0),
                        guid = c.Guid(nullable: false, defaultValueSql: "newid()"),
                        createdon = c.DateTime(nullable: false,defaultValueSql:"getdate()"),
                        createdip = c.String(),
                        createdby = c.Int(nullable: false, defaultValue: 0),
                        updatedon = c.DateTime(),
                        updatedip = c.String(),
                        updatedby = c.Int(nullable: false, defaultValue: 0),
                        isactive = c.Int(nullable: false, defaultValue: 0),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.studentcourses",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        stuid = c.Int(nullable: false),
                        school = c.String(),
                        course = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.studentpreschools",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        stuid = c.Int(nullable: false),
                        schooltype = c.String(),
                        name = c.String(),
                        attendfrommonth = c.Int(nullable: false, defaultValue: 0),
                        attendfromyear = c.Int(nullable: false, defaultValue: 0),
                        attendtomonth = c.Int(nullable: false, defaultValue: 0),
                        attendtoyear = c.Int(nullable: false, defaultValue: 0),
                        majors = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.students",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        fname = c.String(),
                        lname = c.String(),
                        dob = c.DateTime(),
                        phone = c.String(),
                        altphone = c.String(),
                        email = c.String(),
                        address = c.String(),
                        city = c.String(),
                        state = c.String(),
                        country = c.String(),
                        zip = c.String(),
                        profimage = c.String(),
                        college = c.String(),
                        gradeyear = c.Int(nullable: false, defaultValue: 0),
                        majors = c.String(),
                        gpa = c.String(),
                        gender = c.String(),
                        religions = c.String(),
                        heritage = c.String(),
                        languages = c.String(),
                        ethnicity = c.String(),
                        millitary = c.String(),
                        citizenship = c.String(),
                        disabilities = c.String(),
                        academicinterest = c.String(),
                        sports = c.String(),
                        password = c.String(),
                        createdon = c.DateTime(nullable: false, defaultValueSql: "getdate()"),
                        createdip = c.String(),
                        updatedon = c.DateTime(),
                        updatedip = c.String(),
                        guid = c.Guid(nullable: false,defaultValueSql:"newid()"),
                        isactive = c.Int(nullable: false, defaultValue: 0),
                        emailotp = c.String(),
                        otpcreatedon = c.DateTime(nullable: false, defaultValueSql: "getdate()"),
                        isotpverified = c.Int(nullable: false, defaultValue: 0),
                        subscriptionid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.studenttutorchats",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        stuid = c.Int(nullable: false),
                        teacherid = c.Int(nullable: false),
                        ismsgfromteacher = c.Int(nullable: false, defaultValue: 0),
                        ismsgfromstudent = c.Int(nullable: false, defaultValue: 0),
                        isread = c.Int(nullable: false, defaultValue: 0),
                        msg = c.String(),
                        createdon = c.DateTime(nullable: false,defaultValueSql:"getdate()"),
                        isdeleted = c.Int(nullable: false, defaultValue: 0),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.subscriptions",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        details = c.String(),
                        price = c.Decimal(nullable: false, precision: 18, scale: 2, defaultValue: 0),
                        validdays = c.Int(nullable: false, defaultValue: 0),
                        guid = c.Guid(nullable: false,defaultValueSql:"newid()"),
                        createdon = c.DateTime(nullable: false, defaultValueSql: "getdate()"),
                        isactive = c.Int(nullable: false, defaultValue: 0),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.teachers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        username = c.String(),
                        password = c.String(),
                        phone = c.String(),
                        altphone = c.String(),
                        email = c.String(),
                        address = c.String(),
                        city = c.String(),
                        state = c.String(),
                        country = c.String(),
                        zip = c.String(),
                        profimage = c.String(),
                        qualification = c.String(),
                        languages = c.String(),
                        currency = c.String(),
                        earnexpect = c.Decimal(nullable: false, precision: 18, scale: 2, defaultValue: 0),
                        writingstyle = c.String(),
                        dedicatedhours = c.String(),
                        isassignmentexp = c.Int(nullable: false, defaultValue: 0),
                        isknowstyle = c.Int(nullable: false, defaultValue: 0),
                        isknowplagrism = c.Int(nullable: false, defaultValue: 0),
                        isavldemoassignment = c.Int(nullable: false, defaultValue: 0),
                        createdon = c.DateTime(nullable: false,defaultValueSql:"getdate()"),
                        createdip = c.String(),
                        updatedon = c.DateTime(),
                        updatedip = c.String(),
                        guid = c.Guid(nullable: false,defaultValueSql:"newid()"),
                        isactive = c.Int(nullable: false, defaultValue: 0),
                        emailotp = c.String(),
                        otpcreatedon = c.DateTime(nullable: false,defaultValueSql:"getdate()"),
                        isotpverified = c.Int(nullable: false, defaultValue: 0),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.teachers");
            DropTable("dbo.subscriptions");
            DropTable("dbo.studenttutorchats");
            DropTable("dbo.students");
            DropTable("dbo.studentpreschools");
            DropTable("dbo.studentcourses");
            DropTable("dbo.questionbanks");
            DropTable("dbo.books");
        }
    }
}
