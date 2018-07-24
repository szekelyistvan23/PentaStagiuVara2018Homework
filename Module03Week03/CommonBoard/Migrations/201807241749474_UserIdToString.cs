namespace CommonBoard.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserIdToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "UserId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "UserId", c => c.Int(nullable: false));
        }
    }
}
