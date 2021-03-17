namespace MiGitMvc1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change_model_date_toStrings1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OneTasks", "DateCreation", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OneTasks", "DateCreation", c => c.DateTime());
        }
    }
}
