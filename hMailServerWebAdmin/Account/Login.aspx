<%@ Page Title="Log In" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Login.aspx.cs" Inherits="hMailServerWebAdmin.Account.Login" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <article class="module width_half" style="margin-left: auto; margin-right: auto; float:none" >
        <header>
            <h3>
                Log In</h3>
        </header>
        <div class="module_content">
            <p>
                Please enter your username and password.                
            </p>
            <asp:Login ID="LoginUser" runat="server" EnableViewState="false" RenderOuterTable="false">
            </asp:Login>
        </div>
    </article>
</asp:Content>
