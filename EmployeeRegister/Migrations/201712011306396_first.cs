namespace EmployeeRegister.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmpIds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdNumber = c.Int(nullable: false),
                        country = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EmpIds");
        }
    }
}
