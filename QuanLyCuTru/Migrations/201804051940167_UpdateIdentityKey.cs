namespace QuanLyCuTru.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateIdentityKey : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.NguoiDungs", new[] { "IdentityId" });
            CreateIndex("dbo.NguoiDungs", "IdentityId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.NguoiDungs", new[] { "IdentityId" });
            CreateIndex("dbo.NguoiDungs", "IdentityId", unique: true);
        }
    }
}
