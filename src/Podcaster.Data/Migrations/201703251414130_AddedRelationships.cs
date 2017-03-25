using System.Data.Entity.Migrations;

namespace Podcaster.Data.Migrations
{
    public partial class AddedRelationships : DbMigration
    {
        public override void Down()
        {
            this.DropForeignKey("dbo.AspNetUsers", "Podcast_PodcastId", "dbo.Podcasts");
            this.DropForeignKey("dbo.Episodes", "Podcast_PodcastId", "dbo.Podcasts");
            this.DropIndex("dbo.AspNetUsers", new[] { "Podcast_PodcastId" });
            this.DropIndex("dbo.Episodes", new[] { "Podcast_PodcastId" });
            this.DropColumn("dbo.AspNetUsers", "Podcast_PodcastId");
            this.DropTable("dbo.Podcasts");
            this.DropTable("dbo.Episodes");
        }

        public override void Up()
        {
            this.CreateTable(
                    "dbo.Episodes",
                    c =>
                        new
                            {
                                EpisodeId = c.Guid(nullable: false),
                                Description = c.String(),
                                ImageUrl = c.String(),
                                Title = c.String(),
                                Date = c.DateTime(nullable: false),
                                PodcastId = c.Int(nullable: false),
                                Podcast_PodcastId = c.Guid(),
                            })
                .PrimaryKey(t => t.EpisodeId)
                .ForeignKey("dbo.Podcasts", t => t.Podcast_PodcastId)
                .Index(t => t.Podcast_PodcastId);

            this.CreateTable(
                "dbo.Podcasts",
                c =>
                    new
                        {
                            PodcastId = c.Guid(nullable: false),
                            AuthorName = c.String(),
                            Copyright = c.String(),
                            Description = c.String(),
                            ImageUrl = c.String(),
                            IsExplicit = c.Boolean(nullable: false),
                            Language = c.String(),
                            Pricing = c.Decimal(nullable: false, precision: 18, scale: 2),
                            Title = c.String(),
                        }).PrimaryKey(t => t.PodcastId);

            this.AddColumn("dbo.AspNetUsers", "Podcast_PodcastId", c => c.Guid());
            this.CreateIndex("dbo.AspNetUsers", "Podcast_PodcastId");
            this.AddForeignKey("dbo.AspNetUsers", "Podcast_PodcastId", "dbo.Podcasts", "PodcastId");
        }
    }
}