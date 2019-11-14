namespace OmerSeyfettinApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class yeniden : DbMigration
    {
        public override void Up()
        {
            
            
            CreateTable(
                "dbo.UserPosts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DocumentId = c.String(),
                        Document = c.String(),
                        AspNetUsers_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.AspNetUsers_Id)
                .Index(t => t.AspNetUsers_Id);
            
            CreateTable(
                "dbo.Docs",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DocBytes = c.Binary(),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
           
            
        }
        
        public override void Down()
        {
          
        }
    }
}
