Imports System.Web.Mvc

Imports Microsoft.VisualStudio.TestTools.UnitTesting.Web

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports intranet_application.intranet_application



'''<summary>
'''This is a test class for HomeControllerTest and is intended
'''to contain all HomeControllerTest Unit Tests
'''</summary>
<TestClass()> _
Public Class HomeControllerTest


    <TestMethod()> Public Sub Index()
        ' Arrange
        Dim controller As New HomeController()

        ' Act
        Dim result As ViewResult = DirectCast(controller.Index(), ViewResult)

        ' Assert
        Dim viewData As ViewDataDictionary = result.ViewData
        Assert.AreEqual("Home Page Title", viewData("Title"))

    End Sub


    <TestMethod()> Public Sub About()
        ' Arrange
        Dim controller As New HomeController()

        ' Act
        Dim result As ViewResult = DirectCast(controller.About(), ViewResult)

        ' Assert
        Dim viewData As ViewDataDictionary = result.ViewData
        Assert.AreEqual("About Page Title", viewData("Title"))

    End Sub
  
End Class
