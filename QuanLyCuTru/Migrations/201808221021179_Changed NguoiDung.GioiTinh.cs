namespace QuanLyCuTru.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedNguoiDungGioiTinh : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.NguoiDungs", "GioiTinh", c => c.Short(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NguoiDungs", "GioiTinh", c => c.Boolean(nullable: false));
        }
    }
}
