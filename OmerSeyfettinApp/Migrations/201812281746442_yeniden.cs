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
                        Baslik = c.String(),
                        Metin = c.Binary(),
                        AspNetUsers_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.AspNetUsers_Id)
                .Index(t => t.AspNetUsers_Id);
            
           
            
        }
        
        public override void Down()
        {
           
        }
    }
}
