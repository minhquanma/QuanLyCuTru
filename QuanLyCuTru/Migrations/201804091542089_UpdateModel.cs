namespace QuanLyCuTru.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CuTrus", "DienThoai", c => c.String(nullable: false));
            AlterColumn("dbo.CuTrus", "SoNha", c => c.String(nullable: false));
            AlterColumn("dbo.CuTrus", "Duong", c => c.String(nullable: false));
            AlterColumn("dbo.CuTrus", "Phuong", c => c.String(nullable: false));
            AlterColumn("dbo.CuTrus", "Quan", c => c.String(nullable: false));
            AlterColumn("dbo.CuTrus", "ThanhPho", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CuTrus", "ThanhPho", c => c.String());
            AlterColumn("dbo.CuTrus", "Quan", c => c.String());
            AlterColumn("dbo.CuTrus", "Phuong", c => c.String());
            AlterColumn("dbo.CuTrus", "Duong", c => c.String());
            AlterColumn("dbo.CuTrus", "SoNha", c => c.String());
            AlterColumn("dbo.CuTrus", "DienThoai", c => c.String());
        }
    }
}
