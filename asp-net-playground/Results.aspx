<%@ Page Title="Winner winner chicken dinnner" MasterPageFile="~/Main.Master" Language="C#" AutoEventWireup="true" CodeBehind="Results.aspx.cs" Inherits="asp_net_playground.Results" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <div>
        <h1>And the winner is ...</h1>
        <p><b><%= winner %></b></p>
        <a href="LastNameStanding.aspx">Play again</a>
    </div>
</asp:Content>