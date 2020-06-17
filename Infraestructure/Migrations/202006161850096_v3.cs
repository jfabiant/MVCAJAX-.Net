﻿namespace Infraestructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Codigo", c => c.String(nullable: false));
            AddColumn("dbo.Students", "LastName", c => c.String(nullable: false));
            AddColumn("dbo.Students", "FechaCreacion", c => c.DateTime());
            AddColumn("dbo.Students", "FechaModificacion", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "FechaModificacion");
            DropColumn("dbo.Students", "FechaCreacion");
            DropColumn("dbo.Students", "LastName");
            DropColumn("dbo.Students", "Codigo");
        }
    }
}
