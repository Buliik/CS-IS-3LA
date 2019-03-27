<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/ThePage.Master" AutoEventWireup="true" CodeBehind="MujProfil.aspx.cs" Inherits="WF.Forms.MujProfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>  
        Jméno: 
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </div>

    <div>
        Příjmení: 
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </div>
    
    <div>
        Email: 
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    </div>

    <div>
    <asp:Button ID="Button1" runat="server" Text="Požádat o zrušení profilu." />
    </div>
</asp:Content>
