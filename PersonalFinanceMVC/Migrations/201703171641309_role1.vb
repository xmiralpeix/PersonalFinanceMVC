Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class role1
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.RoleViewModels",
                Function(c) New With
                    {
                        .Id = c.String(nullable := False, maxLength := 128),
                        .Name = c.String()
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
        End Sub
        
        Public Overrides Sub Down()
            DropTable("dbo.RoleViewModels")
        End Sub
    End Class
End Namespace
