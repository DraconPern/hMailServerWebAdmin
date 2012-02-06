<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DistributionLists.aspx.cs" Inherits="hMailServerWebAdmin.Admin.DistributionLists" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<article class="module width_full">
        <header>
            <h3>
                Distribution Lists for <asp:Label ID="DomainName" runat="server" Text="Label" /></h3>
        </header>
        <asp:ListView ID="DistributionList" runat="server">
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
                    <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# "~/Admin/DistributionList.aspx?Address=" + Eval("Address") %>' Text='<%# Eval("Address") %>' runat="server" />
                    </td>                    
                </tr>
            </ItemTemplate>
            <EmptyDataTemplate>
                <div class="module_content">
                    <p>
                        No Distribution List</p>
                </div>
            </EmptyDataTemplate>
        </asp:ListView>
    </article>
</asp:Content>
