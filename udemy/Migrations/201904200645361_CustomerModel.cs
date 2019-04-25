namespace udemy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Firstname", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Firstname", c => c.String());
        }
    }
}
