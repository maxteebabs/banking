namespace udemy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerAccount : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Customers", name: "Account_ID", newName: "AccountID");
            RenameIndex(table: "dbo.Customers", name: "IX_Account_ID", newName: "IX_AccountID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Customers", name: "IX_AccountID", newName: "IX_Account_ID");
            RenameColumn(table: "dbo.Customers", name: "AccountID", newName: "Account_ID");
        }
    }
}
