using System.Data.Entity.Migrations;

namespace Podcaster.Data.Migrations
{
    public partial class PodcastDataAnnotationsUpdate : DbMigration
    {
        public override void Down()
        {
            this.AddColumn("dbo.PodcastEntities", "PodcastId", c => c.Guid(nullable: false));
            this.DropForeignKey("dbo.ApplicationUserPodcastEntities", "PodcastEntity_Id", "dbo.PodcastEntities");
            this.DropPrimaryKey("dbo.PodcastEntities");
            this.AlterColumn("dbo.PodcastEntities", "Title", c => c.String());
            this.AlterColumn("dbo.PodcastEntities", "Description", c => c.String(maxLength: 15));
            this.AlterColumn("dbo.PodcastEntities", "AuthorName", c => c.String(maxLength: 15));
            this.DropColumn("dbo.PodcastEntities", "Id");
            this.AddPrimaryKey("dbo.PodcastEntities", "PodcastId");
            this.RenameIndex(
                table: "dbo.ApplicationUserPodcastEntities",
                name: "IX_PodcastEntity_Id",
                newName: "IX_PodcastEntity_PodcastId");
            this.RenameColumn(
                table: "dbo.ApplicationUserPodcastEntities",
                name: "PodcastEntity_Id",
                newName: "PodcastEntity_PodcastId");
            this.AddForeignKey(
                "dbo.ApplicationUserPodcastEntities",
                "PodcastEntity_PodcastId",
                "dbo.PodcastEntities",
                "PodcastId",
                cascadeDelete: true);
        }

        public override void Up()
        {
            this.DropForeignKey("dbo.ApplicationUserPodcastEntities", "PodcastEntity_PodcastId", "dbo.PodcastEntities");
            this.RenameColumn(
                table: "dbo.ApplicationUserPodcastEntities",
                name: "PodcastEntity_PodcastId",
                newName: "PodcastEntity_Id");
            this.RenameIndex(
                table: "dbo.ApplicationUserPodcastEntities",
                name: "IX_PodcastEntity_PodcastId",
                newName: "IX_PodcastEntity_Id");
            this.DropPrimaryKey("dbo.PodcastEntities");
            this.AddColumn("dbo.PodcastEntities", "Id", c => c.Guid(nullable: false));
            this.AlterColumn("dbo.PodcastEntities", "AuthorName", c => c.String(maxLength: 30));
            this.AlterColumn("dbo.PodcastEntities", "Description", c => c.String(maxLength: 1000));
            this.AlterColumn("dbo.PodcastEntities", "Title", c => c.String(maxLength: 50));
            this.AddPrimaryKey("dbo.PodcastEntities", "Id");
            this.AddForeignKey(
                "dbo.ApplicationUserPodcastEntities",
                "PodcastEntity_Id",
                "dbo.PodcastEntities",
                "Id",
                cascadeDelete: true);
            this.DropColumn("dbo.PodcastEntities", "PodcastId");
        }
    }
}