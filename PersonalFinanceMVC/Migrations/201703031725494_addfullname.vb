Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class addfullname
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.AspNetUsers", "FullName", Function(c) c.String(nullable := False))
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.AspNetUsers", "FullName")
        End Sub
    End Class
End Namespace
