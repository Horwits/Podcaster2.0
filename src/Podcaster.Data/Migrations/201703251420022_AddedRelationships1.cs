using System.Data.Entity.Migrations;

namespace Podcaster.Data.Migrations
{
    public partial class AddedRelationships1 : DbMigration
    {
        public override void Down()
        {
            this.DropForeignKey("dbo.Episodes", "PodcastId", "dbo.Podcasts");
            this.DropIndex("dbo.Episodes", new[] { "PodcastId" });
            this.AlterColumn("dbo.Episodes", "PodcastId", c => c.Guid());
            this.AlterColumn("dbo.Episodes", "PodcastId", c => c.Int(nullable: false));
            this.RenameColumn(table: "dbo.Episodes", name: "PodcastId", newName: "Podcast_PodcastId");
            this.AddColumn("dbo.Episodes", "PodcastId", c => c.Int(nullable: false));
            this.CreateIndex("dbo.Episodes", "Podcast_PodcastId");
            this.AddForeignKey("dbo.Episodes", "Podcast_PodcastId", "dbo.Podcasts", "PodcastId");
        }

        public override void Up()
        {
            this.DropForeignKey("dbo.Episodes", "Podcast_PodcastId", "dbo.Podcasts");
            this.DropIndex("dbo.Episodes", new[] { "Podcast_PodcastId" });
            this.DropColumn("dbo.Episodes", "PodcastId");
            this.RenameColumn(table: "dbo.Episodes", name: "Podcast_PodcastId", newName: "PodcastId");
            this.AlterColumn("dbo.Episodes", "PodcastId", c => c.Guid(nullable: false));
            this.AlterColumn("dbo.Episodes", "PodcastId", c => c.Guid(nullable: false));
            this.CreateIndex("dbo.Episodes", "PodcastId");
            this.AddForeignKey("dbo.Episodes", "PodcastId", "dbo.Podcasts", "PodcastId", cascadeDelete: true);
        }
    }
}