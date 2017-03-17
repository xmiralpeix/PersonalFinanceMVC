Imports System.Web
Imports System.Web.Mvc
Imports Microsoft.AspNet.Identity.Owin


Namespace Controllers
    Public Class RoleController
        Inherits Controller

        Private _roleManager As ApplicationRoleManager

        Public Sub New()

        End Sub


        Public Sub New(ByVal roleManager As ApplicationRoleManager)
            _roleManager = roleManager
        End Sub

        Public Property RoleManager As ApplicationRoleManager
            Get
                Return If(_roleManager IsNot Nothing, _roleManager, HttpContext.GetOwinContext.Get(Of ApplicationRoleManager))

            End Get
            Private Set(value As ApplicationRoleManager)
                _roleManager = value
            End Set
        End Property

        ' GET: Role
        Function Index() As ActionResult

            Dim list As New List(Of roleviewmodel)()

            For Each role In RoleManager.Roles
                list.Add(New roleviewmodel(role))
            Next

            Return View(list)

        End Function


        Public Function Create() As ActionResult
            Return View()
        End Function

        <HttpPost>
        Public Async Function Create(model As RoleViewModel) As Threading.Tasks.Task(Of ActionResult)

            Dim role As New ApplicationRole With {.Name = model.Name}
            Await RoleManager.CreateAsync(role)

            Return RedirectToAction("Index")

        End Function

        Public Async Function Edit(ByVal id As String) As Threading.Tasks.Task(Of ActionResult)

            Dim role = Await RoleManager.FindByIdAsync(id)

            Return View(New RoleViewModel(role))

        End Function

        <HttpPost>
        Public Async Function Edit(ByVal model As RoleViewModel) As Threading.Tasks.Task(Of ActionResult)

            Dim role As New ApplicationRole With {.Id = model.Id, .Name = model.Name}
            Await RoleManager.UpdateAsync(role)

            Return RedirectToAction("Index")

        End Function


        Public Async Function Details(id As String) As Threading.Tasks.Task(Of ActionResult)

            Dim role = Await RoleManager.FindByIdAsync(id)

            Return View(New RoleViewModel(role))

        End Function

        Public Async Function Delete(id As String) As Threading.Tasks.Task(Of ActionResult)
            Dim role = Await RoleManager.FindByIdAsync(id)

            Return View(New RoleViewModel(role))

        End Function

        Public Async Function DeleteConfirmed(id As String) As Threading.Tasks.Task(Of ActionResult)
            Dim role = Await RoleManager.FindByIdAsync(id)
            Await RoleManager.DeleteAsync(role)

            Return RedirectToAction("Index")
        End Function



    End Class
End Namespace