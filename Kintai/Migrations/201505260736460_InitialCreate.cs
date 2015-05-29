namespace Kintai.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AttendanceMonths",
                c => new
                    {
                        Month = c.Int(nullable: false, identity: true),
                        UserCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Month);
            
            CreateTable(
                "dbo.AttendanceDays",
                c => new
                    {
                        AttendanceMonthId = c.Int(nullable: false, identity: true),
                        Day = c.Int(nullable: false),
                        UserCode = c.Int(nullable: false),
                        AttendanceMonth_Month = c.Int(),
                    })
                .PrimaryKey(t => t.AttendanceMonthId)
                .ForeignKey("dbo.AttendanceMonths", t => t.AttendanceMonth_Month)
                .Index(t => t.AttendanceMonth_Month);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        code = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.code);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.AttendanceDays", new[] { "AttendanceMonth_Month" });
            DropForeignKey("dbo.AttendanceDays", "AttendanceMonth_Month", "dbo.AttendanceMonths");
            DropTable("dbo.Users");
            DropTable("dbo.AttendanceDays");
            DropTable("dbo.AttendanceMonths");
        }
    }
}
