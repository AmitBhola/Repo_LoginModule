<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LandingPage.aspx.cs" Inherits="LoginModule.LandingPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>Enter Service 1
            | Name:
            <asp:Label ID="lbl_name1" runat="server"></asp:Label>
&nbsp;| NickName:
            <asp:Label ID="lbl_nickName1" runat="server"></asp:Label>
&nbsp;| Address:
            <asp:Label ID="lbl_Address1" runat="server"></asp:Label>
        </h1>
        <p class="lead">Service 1 is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p> <asp:Button ID="btn_ser1" runat="server" Text="Button" OnClick="btn_ser1_Click" />&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lbl_error1" runat="server"></asp:Label>
        </p>
    </div>

        <div class="jumbotron">
           
        <h1>Enter Service 2 | Name: <asp:Label ID="lbl_name2" runat="server"></asp:Label>
&nbsp;| NickName:
            <asp:Label ID="lbl_nickName2" runat="server"></asp:Label>
&nbsp;| Address:
            <asp:Label ID="lbl_Address2" runat="server"></asp:Label>
        </h1>
        <p class="lead">Service 2&nbsp; is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><asp:Button ID="btn_ser2" runat="server" Text="Button" OnClick="btn_ser2_Click" />&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lbl_error2" runat="server"></asp:Label>
            </p>
    </div>

        <div class="jumbotron">
        <h1>Enter Service 3 | Name:
            <asp:Label ID="lbl_name3" runat="server"></asp:Label>
&nbsp;| NIckName:
            <asp:Label ID="lbl_nickName3" runat="server"></asp:Label>
&nbsp;| Address:
            <asp:Label ID="lbl_Address3" runat="server"></asp:Label>
        </h1>
        <p class="lead">Service 3 is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p> <asp:Button ID="btn_ser3" runat="server" Text="Button" OnClick="btn_ser3_Click" />&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lbl_error3" runat="server"></asp:Label>
            </p>
    </div>

</asp:Content>
