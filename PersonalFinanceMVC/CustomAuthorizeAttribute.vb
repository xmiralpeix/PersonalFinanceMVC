
<AttributeUsage(AttributeTargets.Method)>
Public Class CustomAuthorizeAttribute
    Inherits AuthorizeAttribute


    Public Property ViewName As String

    Public Sub New()
        ViewName = "AuthorizeFailed"
    End Sub

    Public Overrides Sub OnAuthorization(filterContext As AuthorizationContext)
        MyBase.OnAuthorization(filterContext)

        IsUserAuthorized(filterContext)

    End Sub

    Public Sub IsUserAuthorized(filterContext As AuthorizationContext)

        If filterContext.Result Is Nothing Then
            Return
        End If

        If filterContext.HttpContext.User.Identity.IsAuthenticated Then
            Dim dic As New ViewDataDictionary()
            dic.Add("Message", "You don't have sufficient privileges for this operation!")

            Dim res As New ViewResult() With {.ViewName = Me.ViewName, .ViewData = dic}

            filterContext.Result = res

        End If

    End Sub

End Class
