namespace QuanLyCuTru.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNguoiDungPhoneNumber : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NguoiDungs", "DienThoai", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.NguoiDungs", "DienThoai");
        }
    }
}
