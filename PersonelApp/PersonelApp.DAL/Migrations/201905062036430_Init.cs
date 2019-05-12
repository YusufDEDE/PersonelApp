namespace PersonelApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Dept_Name = c.String(),
                        CreatedTime = c.DateTime(),
                        UpdateTime = c.DateTime(),
                        MyProperty = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Personels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        DepatmentID = c.Int(nullable: false),
                        Department_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.Department_Id)
                .Index(t => t.Department_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Personels", "Department_Id", "dbo.Departments");
            DropIndex("dbo.Personels", new[] { "Department_Id" });
            DropTable("dbo.Personels");
            DropTable("dbo.Departments");
        }
    }
}
