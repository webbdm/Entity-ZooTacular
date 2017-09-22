namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ZooTacular : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animals",
                c => new
                    {
                        AnimalId = c.Int(nullable: false, identity: true),
                        Nickname = c.String(),
                        Species = c.String(),
                        ZookeeperId = c.Int(nullable: false),
                        EnvironmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AnimalId);
            
            CreateTable(
                "dbo.Environments",
                c => new
                    {
                        EnvironmentId = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        Strength = c.Int(nullable: false),
                        New = c.Boolean(nullable: false),
                        TempControlled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.EnvironmentId);
            
            CreateTable(
                "dbo.Zookeepers",
                c => new
                    {
                        ZookeeperId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        AnimalId = c.Int(nullable: false),
                        FullTime = c.Boolean(nullable: false),
                        Rookie = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ZookeeperId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Zookeepers");
            DropTable("dbo.Environments");
            DropTable("dbo.Animals");
        }
    }
}
