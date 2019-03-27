<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/ThePage.Master" AutoEventWireup="true" CodeBehind="NRez.aspx.cs" Inherits="WF.Forms.NRez" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div style="padding: 5px;">
        Datum a čas rezervace: 
    <asp:TextBox ID="TextBox1" runat="server"/>       
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Vyplnte datum"></asp:RequiredFieldValidator>
    </div>

    <div style="padding: 5px;">
        Zbraň: 
    <asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>
    </div>

    <div style="padding: 5px;">
        Prostor: 
    <asp:DropDownList ID="DropDownList2" runat="server">
    </asp:DropDownList>
    </div>

    <div style="padding: 5px;"> <asp:Button ID="Button1" runat="server" Text="Provést" /> </div>
    


</asp:Content>
