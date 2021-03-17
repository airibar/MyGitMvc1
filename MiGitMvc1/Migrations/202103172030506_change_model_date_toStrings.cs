namespace MiGitMvc1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change_model_date_toStrings : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OneTasks", "DateCreation", c => c.DateTime());
            AlterColumn("dbo.OneTasks", "DateStart", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OneTasks", "DateStart", c => c.DateTime(nullable: false));
            AlterColumn("dbo.OneTasks", "DateCreation", c => c.DateTime(nullable: false));
        }
    }
}
