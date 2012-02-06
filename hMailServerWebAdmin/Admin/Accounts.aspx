<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Accounts.aspx.cs" Inherits="hMailServerWebAdmin.Admin.Accounts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <article class="module width_full">
        <header>
            <h3>
                Accounts for
                <asp:Label ID="DomainName" runat="server" Text="Label" /></h3>
        </header>
        <asp:ListView ID="AccountList" runat="server">
            <LayoutTemplate>
                <div class="tab_container">
                    <div id="tab1" class="tab_content">
                        <table class="tablesorter" cellspacing="0">
                            <thead>
                                <tr>                                    
                                    <th>
                                        Address
                                    </th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr runat="server" id="itemPlaceholder" />
                            </tbody>
                        </table>
                    </div>
                </div>
            </LayoutTemplate>
            <ItemTemplate>
                <tr id="Tr1" runat="server">                    
                    <td>
                        <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# "~/Admin/Domain.aspx?ID=" + Eval("ID") %>'
                            Text='<%# Eval("Address") %>' runat="server" />
                    </td>
                </tr>
            </ItemTemplate>
            <EmptyDataTemplate>
                <div class="module_content">
                    <p>
                        No Accounts</p>
                </div>
            </EmptyDataTemplate>
        </asp:ListView>
    </article>
</asp:Content>
