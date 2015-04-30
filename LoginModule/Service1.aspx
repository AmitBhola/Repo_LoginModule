<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Service1.aspx.cs" Inherits="LoginModule.Service1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1> Welcome
            <asp:Label ID="lbl_name" runat="server"></asp:Label>
&nbsp;From
            <asp:Label ID="lbl_address" runat="server"></asp:Label>
        </h1>
        <p> Privilage Level:
            <asp:Label ID="lbl_privilage" runat="server"></asp:Label>
&nbsp;Start Date:
            <asp:Label ID="lbl_start" runat="server"></asp:Label>
&nbsp;End Date:
            <asp:Label ID="lbl_end" runat="server"></asp:Label>
&nbsp;Policy Name:
            <asp:Label ID="lbl_policy" runat="server"></asp:Label>
        </p>
        <p> &nbsp;</p>
        <p class="lead">Service 1 is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
    </div>

    </asp:Content>
