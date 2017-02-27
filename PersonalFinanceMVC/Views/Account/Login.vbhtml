@ModelType LoginViewModel
@Code
    ViewBag.Title = "Log in"
    Layout = Nothing
End Code


<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>AdminLTE 2 | Log in</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
    <!-- Bootstrap 3.3.6 -->
    <link rel="stylesheet" href="/bootstrap/css/bootstrap.min.css">
    <!-- Font Awesome -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.5.0/css/font-awesome.min.css">
    <!-- Ionicons -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/ionicons/2.0.1/css/ionicons.min.css">
    <!-- Theme style -->
    <link rel="stylesheet" href="/dist/css/AdminLTE.min.css">
    <!-- iCheck -->
    <link rel="stylesheet" href="/plugins/iCheck/square/blue.css">
    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
    <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
    <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>
<body class="hold-transition login-page">
    <div class="login-box">
        <div class="login-logo">
            <a href="../../index2.html"><b>Admin</b>LTE</a>
        </div>
        <!-- /.login-logo -->
        <div class="login-box-body">
            <p class="login-box-msg">Sign in to start your session</p>

            <section id="loginForm">
                @Using Html.BeginForm("Login", "Account", New With {.ReturnUrl = ViewBag.ReturnUrl}, FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
                    @Html.AntiForgeryToken()
                    @<text>
                        <h4>Use a local account to log in.</h4>
                        <hr />
                        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})

                        <div class="form-group has-feedback">                         
                            
                                @Html.TextBoxFor(Function(m) m.UserName, New With {.class = "form-control", .placeholder = "User Name"})
                                @Html.ValidationMessageFor(Function(m) m.UserName, "", New With {.class = "text-danger"})
                                <span class="glyphicon glyphicon-envelope form-control-feedback"></span>
                            
                        </div>
                       

                        <div class="form-group has-feedback">                          
                           
                                @Html.PasswordFor(Function(m) m.Password, New With {.class = "form-control"})
                                @Html.ValidationMessageFor(Function(m) m.Password, "", New With {.class = "text-danger"})
                                <span class="glyphicon glyphicon-lock form-control-feedback"></span>
                           
                        </div>

                <div class="row">
                    <div class="col-xs-8">
                        <div class="checkbox icheck">
                            <label>
                                @Html.CheckBoxFor(Function(m) m.RememberMe)
                                @Html.LabelFor(Function(m) m.RememberMe)
                            </label>      
                        </div>
                    </div>

                    <div class="col-xs-4">
                        <input type="submit" value="Log in" class="btn btn-primary btn-block btn-flat" />
                    </div>

                </div>
                   

                   
                    <p>
                        @Html.ActionLink("Register as a new user", "Register")
                    </p>
                    @* Enable this once you have account confirmation enabled for password reset functionality
            <p>
                @Html.ActionLink("Forgot your password?", "ForgotPassword")
            </p> *@

                    </text>
                End Using
</section>


            @*'<form action="../../index2.html" method="post">
                '    <div class="form-group has-feedback">
                '        <input type="email" class="form-control" placeholder="Email">
                '        <span class="glyphicon glyphicon-envelope form-control-feedback"></span>
                '    </div>
                '    <div class="form-group has-feedback">
                '        <input type="password" class="form-control" placeholder="Password">
                '        <span class="glyphicon glyphicon-lock form-control-feedback"></span>
                '    </div>
                '    <div class="row">
                '        <div class="col-xs-8">
                '            <div class="checkbox icheck">
                '                <label>
                '                    <input type="checkbox"> Remember Me
                '                </label>
                '            </div>
                '        </div>
                '        <!-- /.col -->
                '        <div class="col-xs-4">
                '            <button type="submit" class="btn btn-primary btn-block btn-flat">Sign In</button>
                '        </div>
                '        <!-- /.col -->
                '    </div>
                '</form>*@

            @*<div Class="social-auth-links text-center">
                    <p>- Or -</p>
                    <a href = "#" Class="btn btn-block btn-social btn-facebook btn-flat">
                        <i Class="fa fa-facebook"></i> Sign in using
                        Facebook
                    </a>
                    <a href = "#" Class="btn btn-block btn-social btn-google btn-flat">
                        <i Class="fa fa-google-plus"></i> Sign in using
                        Google+
                    </a>
                </div>*@
            <!-- /.social-auth-links -->
            @*<a href = "#" > I forgot my password</a><br>
                <a href = "register.html" Class="text-center">Register a New membership</a>*@
        </div>
        <!-- /.login-box-body -->
    </div>
    <!-- /.login-box -->
    <!-- jQuery 2.2.3 -->
    <Script src="/plugins/jQuery/jquery-2.2.3.min.js"></Script>
    <!-- Bootstrap 3.3.6 -->
    <Script src="/bootstrap/js/bootstrap.min.js"></Script>
    <!-- iCheck -->
    <Script src="/plugins/iCheck/icheck.min.js"></Script>

    <script>
        $(function () {
            $('input').iCheck({
                checkboxClass: 'icheckbox_square-blue',
                radioClass: 'iradio_square-blue',
                increaseArea: '20%' // optional
            });
        });
    </script>

</body>
</html>




@*<h2>@ViewBag.Title.</h2>
    <div class="row">
        <div class="col-md-8">
            <section id="loginForm">
                @Using Html.BeginForm("Login", "Account", New With { .ReturnUrl = ViewBag.ReturnUrl }, FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
                    @Html.AntiForgeryToken()
                    @<text>
                    <h4>Use a local account to log in.</h4>
                    <hr />
                    @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
                    <div class="form-group">
                        @Html.LabelFor(Function(m) m.Email, New With {.class = "col-md-2 control-label"})
                        <div class="col-md-10">
                            @Html.TextBoxFor(Function(m) m.Email, New With {.class = "form-control"})
                            @Html.ValidationMessageFor(Function(m) m.Email, "", New With {.class = "text-danger"})
                        </div>
                    </div>
                    <div class="form-group">
                        @Html.LabelFor(Function(m) m.Password, New With {.class = "col-md-2 control-label"})
                        <div class="col-md-10">
                            @Html.PasswordFor(Function(m) m.Password, New With {.class = "form-control"})
                            @Html.ValidationMessageFor(Function(m) m.Password, "", New With {.class = "text-danger"})
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <div class="checkbox">
                                @Html.CheckBoxFor(Function(m) m.RememberMe)
                                @Html.LabelFor(Function(m) m.RememberMe)
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <input type="submit" value="Log in" class="btn btn-default" />
                        </div>
                    </div>
                    <p>
                        @Html.ActionLink("Register as a new user", "Register")
                    </p>
                    @* Enable this once you have account confirmation enabled for password reset functionality
                        <p>
                            @Html.ActionLink("Forgot your password?", "ForgotPassword")
                        </p>
                    </text>
                End Using
            </section>
        </div>
        <div class="col-md-4">
            <section id="socialLoginForm">
                @Html.Partial("_ExternalLoginsListPartial", New ExternalLoginListViewModel With {.ReturnUrl = ViewBag.ReturnUrl})
            </section>
        </div>

    </div>

    @Section Scripts
        @Scripts.Render("~/bundles/jqueryval")
    End Section*@
