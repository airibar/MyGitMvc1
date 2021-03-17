namespace MiGitMvc1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Adding_StartedDate_andStatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OneTasks", "DateStart", c => c.DateTime(nullable: false));
            AddColumn("dbo.OneTasks", "Status", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.OneTasks", "Status");
            DropColumn("dbo.OneTasks", "DateStart");
        }
    }
}
