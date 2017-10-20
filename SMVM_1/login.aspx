<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="SMVM_1.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">


    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">

    <!-- Optional theme -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous">

    <!-- Latest compiled and minified JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
    
    <script type="text/javascript">
       function comprueba() {
           return confirm("Confirme el postback");

       }
    </script>
    <title>SMVM</title>

</head>
<body>

    <div class="container">
        <div class="row">
            <div class="col-sm-6 col-md-4 col-md-offset-4">
                <br />
                <br />
                <img class="profile-img" src="https://www.inspectionsupport.net/wp-content/uploads/2014/07/LoginRed.jpg"
                    alt="">
                <h1 class="text-center login-title">Sistema de Gestion</h1>
                <br />
                <div class="account-wall">


                    <form class="form-signin" runat="server">

                        <asp:TextBox ID="txtUsu" runat="server" type="text" class="form-control" placeholder="Usuario" required autofocus></asp:TextBox>
                        <br />
                        <asp:TextBox ID="txtPw" runat="server" type="password" class="form-control" placeholder="Contraseña" required></asp:TextBox>
                        <br />
                        <asp:Button ID="btnIngreso" runat="server" Text="Ingreso" class="btn btn-lg btn-primary btn-block" OnClick="btnIngreso_Click" OnClientClick="return true;"/>
                        <%--<asp:Button ID="btnIngreso" runat="server" class="btn btn-lg btn-primary btn-block">Ingresar</asp:Button>--%>


                        <%--<label class="checkbox pull-left">
                    <input type="checkbox" value="remember-me">
                    Remember me
                </label>--%>
                        <%--<a href="#" class="pull-right need-help">Need help? </a><span class="clearfix"></span>--%>
                    </form>
                </div>
                <br />
                <asp:Label ID="ERROR" runat="server" ForeColor="Red" Font-Bold="true"></asp:Label>
                <%--<a href="#" class="text-center new-account">Crear Nuevo Usuario</a>--%>
            </div>
        </div>
    </div>
</body>
</html>
