<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="DistributionList.aspx.cs" Inherits="hMailServerWebAdmin.Admin.DistributionList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <article class="module width_full">
        <header>
            <h3>
                Distribution List for
                <asp:Label ID="DistributionListName" runat="server" Text="Label" /></h3>
        </header>
        <asp:ListView ID="AddressList" runat="server">
            <LayoutTemplate>
                <div class="tab_container">
                    <div id="tab1" class="tab_content">
                        <table class="tablesorter" cellspacing="0">
                            <thead>
                                <tr>
                                    <th>
                                        Address
                                    </th>
                                    <th>
                                        Actions
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
                        <asp:Label runat="server" Text='<%# Eval("RecipientAddress") %>' />
                    </td>
                    <td>
                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/icn_trash.png" Text="Trash" CommandName="Delete" CommandArgument='<%# Eval("RecipientAddress") %>' />
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
