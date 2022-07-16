namespace StudentCodeFirst1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Gender = c.String(),
                        DateOfBirth = c.DateTime(),
                    })
                .PrimaryKey(t => t.StudentId);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        SubjectId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Grade = c.String(),
                        Students_StudentId = c.Int(),
                    })
                .PrimaryKey(t => t.SubjectId)
                .ForeignKey("dbo.Students", t => t.Students_StudentId)
                .Index(t => t.Students_StudentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subjects", "Students_StudentId", "dbo.Students");
            DropIndex("dbo.Subjects", new[] { "Students_StudentId" });
            DropTable("dbo.Subjects");
            DropTable("dbo.Students");
        }
    }
}
