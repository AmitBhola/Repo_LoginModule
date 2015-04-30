<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="LoginModule.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <div class="jumbotron">
        <h1>Login Page</h1>
        <p>
            <asp:Label ID="lbl_UserName" runat="server" Text="Username"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_username" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="lbl_Password" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txt_password" runat="server" TextMode="Password"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="btb_login" runat="server" OnClick="btb_login_Click" Text="Login" />
            </p>
            <p>
                <asp:Label ID="lbl_error" runat="server" Text="Label"></asp:Label>
            </p>
    </div>
    </p>
</asp:Content>
