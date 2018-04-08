namespace QuanLyCuTru.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateRelationShips : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.NguoiDungs", "SoNha", c => c.String(nullable: false));
            AlterColumn("dbo.NguoiDungs", "Duong", c => c.String(nullable: false));
            AlterColumn("dbo.NguoiDungs", "Phuong", c => c.String(nullable: false));
            AlterColumn("dbo.NguoiDungs", "Quan", c => c.String(nullable: false));
            AlterColumn("dbo.NguoiDungs", "ThanhPho", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NguoiDungs", "ThanhPho", c => c.String());
            AlterColumn("dbo.NguoiDungs", "Quan", c => c.String());
            AlterColumn("dbo.NguoiDungs", "Phuong", c => c.String());
            AlterColumn("dbo.NguoiDungs", "Duong", c => c.String());
            AlterColumn("dbo.NguoiDungs", "SoNha", c => c.String());
        }
    }
}
