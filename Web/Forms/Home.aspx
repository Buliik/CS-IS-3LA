<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/ThePage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WF.Forms.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div>
        Email: 
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Required Field"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
            ControlToValidate="TextBox1" ErrorMessage="Invalid Email Format"></asp:RegularExpressionValidator>
    </div>

    <div>
        ID: 
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>        
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Required Field"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" Operator="DataTypeCheck" Type="Integer" 
 ControlToValidate="TextBox2" ErrorMessage="Number required"></asp:CompareValidator>
    </div>

    <div>
    <asp:Button ID="Button1" runat="server" Text="Log in" />
    </div>
</asp:Content>
