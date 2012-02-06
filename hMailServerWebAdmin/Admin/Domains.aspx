<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Domains.aspx.cs" Inherits="hMailServerWebAdmin.Admin.Domains" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<article class="module width_full">
        <header>
            <h3>
                Domains</h3>
        </header>
        <asp:ListView ID="DomainList" runat="server">
            <LayoutTemplate>
                <div class="tab_container">
                    <div id="tab1" class="tab_content">
                        <table class="tablesorter" cellspacing="0">
                            <thead>
                                <tr>                                    
                                    <th>
                                        Name
                                    </th>
                                    <th>
                                        Active
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
                    <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# "~/Admin/Domain.aspx?ID=" + Eval("ID") %>' Text='<%# Eval("Name") %>' runat="server" />
                    </td>
                    <td>
                    <%# Eval("Active") %>
                    </td>
                </tr>
            </ItemTemplate>
            <EmptyDataTemplate>
                <div class="module_content">
                    <p>
                        No Domains</p>
                </div>
            </EmptyDataTemplate>
        </asp:ListView>
    </article>
</asp:Content>
