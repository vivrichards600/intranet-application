Namespace intranet_application
    Public Class HomeController
        Inherits System.Web.Mvc.Controller

        Function Index() As ActionResult
            ViewData("Title") = "Home Page Title"

            Return View()
        End Function


        Function About() As ActionResult
            ViewData("Title") = "About Page Title"

            Return View()
        End Function

    End Class
End Namespace