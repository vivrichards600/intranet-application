<!DOCTYPE html>
<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <link href="@Href("~/Assets/Stylesheets/Styles.css")" rel="stylesheet" type="text/css" />
    <title>@ViewData("Title")</title>
</head>
<body>
    <header>
<div class="global-header" id="global-header">
        <div class="header-wrapper">
            <div class="content">
                <div class="header-global">
                    <div class="header-logo">
                        <a class="logo" href="#" title=
                        "Go to the homepage">Simple Intranet App</a>
                    </div>
                </div>

                <div class="header-proposition">
                    <div class="content">
                        <div class="proposition-menu">
                            @Html.ActionLink("Home", "Index", "Home")
                            @Html.ActionLink("About", "About", "Home")
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div><!--end header-->
</header>
  
  
  <div id="main">
        <div class="app vehicles-acquire-online">
            <div class="section-content">
		 @RenderSection("featured", required:=False)
               @RenderBody()
        </div>
        </div>
        </div>
        
</body>
</html>
