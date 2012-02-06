<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Domain.aspx.cs" Inherits="hMailServerWebAdmin.Admin.Domain" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <article class="module width_full">
        <header>
            <ul class="tabs">
                <li><a href="#tab1">General</a></li>
                <li><a href="#tab3">Signature</a></li>
                <li><a href="#tab4">Limits</a></li>
                <li><a href="#tab5">DKIM Signing</a></li>
                <li><a href="#tab6">Advanced</a></li>
            </ul>
        </header>
        <div class="tab_container">
            <div id="tab1" class="tab_content">
                <div class="module_content">
                    Domain:
                    <asp:TextBox ID="DomainName" runat="server"></asp:TextBox>
                    Enabled:
                    <asp:CheckBox ID="Enabled" runat="server" />
                </div>
            </div>
            <div id="tab3" class="tab_content">
                <p>
                    Tab3</p>
            </div>
            <div id="tab4" class="tab_content">
                <p>
                    Tab1</p>
            </div>
            <div id="tab5" class="tab_content">
            </div>
            <div id="tab6" class="tab_content">
            </div>
        </div>
        <footer>
            <div class="submit_link">
                <asp:Button ID="Button1" runat="server" Text="Save" />
            </div>
        </footer>
    </article>
    <article class="module width_full">
        <header>
        </header>
        
            <table class="tablesorter" cellspacing="0">
                <tbody>
                    <tr>
                        <td>
                            <asp:HyperLink runat="server" ID="AccountLink" Text="Accounts" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:HyperLink runat="server" ID="Aliases" Text="Aliases" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:HyperLink runat="server" ID="DistributionLists" Text="Distribution Lists" />
                        </td>
                    </tr>
                </tbody>
            </table>
        
    </article>
</asp:Content>
