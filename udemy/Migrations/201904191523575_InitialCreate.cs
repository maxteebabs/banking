namespace udemy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        AccountType = c.String(),
                        DateEntered = c.DateTime(nullable: false),
                        Balance = c.Single(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Deleted = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Firstname = c.String(),
                        Lastname = c.String(),
                        Othernames = c.String(),
                        Occupation = c.String(),
                        Dob = c.DateTime(),
                        Gender = c.String(),
                        Address = c.String(),
                        IsActive = c.String(),
                        DateEntered = c.DateTime(),
                        Deleted = c.DateTime(),
                        Account_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Accounts", t => t.Account_ID)
                .Index(t => t.Account_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "Account_ID", "dbo.Accounts");
            DropIndex("dbo.Customers", new[] { "Account_ID" });
            DropTable("dbo.Customers");
            DropTable("dbo.Accounts");
        }
    }
}
