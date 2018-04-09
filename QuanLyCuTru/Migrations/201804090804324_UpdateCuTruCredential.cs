namespace QuanLyCuTru.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCuTruCredential : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CuTrus", "Email", c => c.String());
            AddColumn("dbo.CuTrus", "DienThoai", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CuTrus", "DienThoai");
            DropColumn("dbo.CuTrus", "Email");
        }
    }
}
