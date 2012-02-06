<%@ Page Title="Status" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="hMailServerWebAdmin.Admin.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<article class="module width_full">
        <header>
            <h3>
                Home</h3>
        </header>
        <div class="module_content">
        Server Information:  Version:
            <asp:Label ID="Version" runat="server" Text="Label"></asp:Label>

        </div>
        </article>
</asp:Content>
