namespace Podcaster.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PodcastDataAnnotationsUpdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ApplicationUserPodcastEntities", "PodcastEntity_PodcastId", "dbo.PodcastEntities");
            RenameColumn(table: "dbo.ApplicationUserPodcastEntities", name: "PodcastEntity_PodcastId", newName: "PodcastEntity_Id");
            RenameIndex(table: "dbo.ApplicationUserPodcastEntities", name: "IX_PodcastEntity_PodcastId", newName: "IX_PodcastEntity_Id");
            DropPrimaryKey("dbo.PodcastEntities");
            AddColumn("dbo.PodcastEntities", "Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.PodcastEntities", "AuthorName", c => c.String(maxLength: 30));
            AlterColumn("dbo.PodcastEntities", "Description", c => c.String(maxLength: 1000));
            AlterColumn("dbo.PodcastEntities", "Title", c => c.String(maxLength: 50));
            AddPrimaryKey("dbo.PodcastEntities", "Id");
            AddForeignKey("dbo.ApplicationUserPodcastEntities", "PodcastEntity_Id", "dbo.PodcastEntities", "Id", cascadeDelete: true);
            DropColumn("dbo.PodcastEntities", "PodcastId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PodcastEntities", "PodcastId", c => c.Guid(nullable: false));
            DropForeignKey("dbo.ApplicationUserPodcastEntities", "PodcastEntity_Id", "dbo.PodcastEntities");
            DropPrimaryKey("dbo.PodcastEntities");
            AlterColumn("dbo.PodcastEntities", "Title", c => c.String());
            AlterColumn("dbo.PodcastEntities", "Description", c => c.String(maxLength: 15));
            AlterColumn("dbo.PodcastEntities", "AuthorName", c => c.String(maxLength: 15));
            DropColumn("dbo.PodcastEntities", "Id");
            AddPrimaryKey("dbo.PodcastEntities", "PodcastId");
            RenameIndex(table: "dbo.ApplicationUserPodcastEntities", name: "IX_PodcastEntity_Id", newName: "IX_PodcastEntity_PodcastId");
            RenameColumn(table: "dbo.ApplicationUserPodcastEntities", name: "PodcastEntity_Id", newName: "PodcastEntity_PodcastId");
            AddForeignKey("dbo.ApplicationUserPodcastEntities", "PodcastEntity_PodcastId", "dbo.PodcastEntities", "PodcastId", cascadeDelete: true);
        }
    }
}
