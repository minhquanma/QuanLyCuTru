namespace QuanLyCuTru.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateIdentity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NguoiDungs", "IdentityId", c => c.String(maxLength: 128));
            AlterColumn("dbo.NguoiDungs", "HoTen", c => c.String(nullable: false));
            AlterColumn("dbo.NguoiDungs", "SinhNhat", c => c.DateTime(nullable: false));
            CreateIndex("dbo.NguoiDungs", "IdentityId", unique: true);
            AddForeignKey("dbo.NguoiDungs", "IdentityId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NguoiDungs", "IdentityId", "dbo.AspNetUsers");
            DropIndex("dbo.NguoiDungs", new[] { "IdentityId" });
            AlterColumn("dbo.NguoiDungs", "SinhNhat", c => c.DateTime());
            AlterColumn("dbo.NguoiDungs", "HoTen", c => c.String());
            DropColumn("dbo.NguoiDungs", "IdentityId");
        }
    }
}
