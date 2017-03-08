Public Class HomeController
    Inherits System.Web.Mvc.Controller

    <CustomAuthorize()>
    Function Index() As ActionResult
        Return View()
    End Function

    <CustomAuthorize()>
    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    <CustomAuthorize(Roles:="Admin,User")>
    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."
        Return View()
    End Function

End Class
