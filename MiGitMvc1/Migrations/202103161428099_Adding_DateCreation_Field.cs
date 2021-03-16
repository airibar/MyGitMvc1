namespace MiGitMvc1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Adding_DateCreation_Field : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OneTasks", "DateCreation", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.OneTasks", "DateCreation");
        }
    }
}
