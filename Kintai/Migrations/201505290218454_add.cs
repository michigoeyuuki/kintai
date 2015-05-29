namespace Kintai.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AttendanceMonths", "UserID", c => c.Int(nullable: false));
            AddColumn("dbo.AttendanceMonths", "User_Code", c => c.String(maxLength: 128));
            AddColumn("dbo.AttendanceDays", "StartTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.AttendanceDays", "EndTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.AttendanceDays", "RestTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Users", "Password", c => c.String());
            AddColumn("dbo.Users", "RememberMe", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Users", "Code", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Users", "Name", c => c.String());
            DropPrimaryKey("dbo.Users", new[] { "code" });
            AddPrimaryKey("dbo.Users", "Code");
            AddForeignKey("dbo.AttendanceMonths", "User_Code", "dbo.Users", "Code");
            CreateIndex("dbo.AttendanceMonths", "User_Code");
            DropColumn("dbo.AttendanceMonths", "UserCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AttendanceMonths", "UserCode", c => c.Int(nullable: false));
            DropIndex("dbo.AttendanceMonths", new[] { "User_Code" });
            DropForeignKey("dbo.AttendanceMonths", "User_Code", "dbo.Users");
            DropPrimaryKey("dbo.Users", new[] { "Code" });
            AddPrimaryKey("dbo.Users", "code");
            AlterColumn("dbo.Users", "name", c => c.String());
            AlterColumn("dbo.Users", "code", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Users", "RememberMe");
            DropColumn("dbo.Users", "Password");
            DropColumn("dbo.AttendanceDays", "RestTime");
            DropColumn("dbo.AttendanceDays", "EndTime");
            DropColumn("dbo.AttendanceDays", "StartTime");
            DropColumn("dbo.AttendanceMonths", "User_Code");
            DropColumn("dbo.AttendanceMonths", "UserID");
        }
    }
}
