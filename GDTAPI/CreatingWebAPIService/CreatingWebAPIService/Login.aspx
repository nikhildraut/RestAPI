<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" EnableEventValidation="false" Inherits="DevetchAPI.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>GDTAPI</title>
    <link rel="icon" type="image/png" href="Img/favicon.ico" />
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
    <link href="assets/css/bootstrap.css" rel="stylesheet">

    <!--[if lt IE 9]>
          <script src="//html5shim.googlecode.com/svn/trunk/html5.js"></script>
        <![endif]-->
  
    <link href="assets/css/google-plus.css" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-top: 5%;">

            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">

                        <h2 class="text-center">
                            <img src="img/devtechlogo.png" style="margin-left:-8% !important" ><br>
                            <hr />
                            Login</h2>
                    </div>
                    <div class="modal-body">
                        <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red"></asp:Label>
                        <form class="form col-md-12 center-block">
                            <div class="form-group">
                                <%--<input class="form-control input-lg" placeholder="Username" type="text">--%>
                                <asp:TextBox ID="txtusername" class="form-control input-lg" placeholder="Username" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <%--<input class="form-control input-lg" placeholder="Password" type="password">--%>
                                <asp:TextBox ID="txtpassword" class="form-control input-lg" TextMode=Password placeholder="Password" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <%-- <button class="btn btn-primary btn-lg btn-block">Sign In</button>--%>
                                <asp:Button ID="btnlogin" class="btn btn-primary btn-lg btn-block" OnClick="btnlogin_Click" runat="server" Text="Login" />
                            </div>
                        </form>
                    </div>

                </div>
            </div>

        </div>
    </form>
</body>
</html>
