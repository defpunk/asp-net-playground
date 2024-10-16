<%@ Page Title="Last Name Standing" MasterPageFile="~/Main.Master" Language="C#" AutoEventWireup="true" CodeBehind="LastNameStanding.aspx.cs" Inherits="asp_net_playground.LastNameStanding" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <div>
        <h1>What will the last name standing be?</h1>
        <p>The currently selected name is <b><%= selectedName %></b></p>
        Enter a new name: <input id="txtName" runat="server" />
        <button id="btnUpdate" runat="server">Update Name</button>
        <button id="btnDone" runat="server">Done</button>
    </div>
</asp:Content>