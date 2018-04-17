namespace QuanLyCuTru.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCuTruModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CuTrus", "NgayHetHan", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CuTrus", "NgayHetHan", c => c.DateTime());
        }
    }
}
