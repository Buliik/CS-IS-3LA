<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/ThePage.Master" AutoEventWireup="true" CodeBehind="Strelby.aspx.cs" Inherits="WF.Forms.Strelby" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
            <asp:BoundField DataField="Zacatek" HeaderText="Zacatek" SortExpression="Zacatek" />
            <asp:BoundField DataField="Konec" HeaderText="Konec" SortExpression="Konec" />
            <asp:BoundField DataField="Prostor" HeaderText="Prostor" SortExpression="Prostor" />
            <asp:BoundField DataField="Zakaznik" HeaderText="Zakaznik" SortExpression="Zakaznik" />
            <asp:BoundField DataField="Zamestnanec" HeaderText="Zamestnanec" SortExpression="Zamestnanec" />
            <asp:BoundField DataField="Zbran" HeaderText="Zbran" SortExpression="Zbran" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetDTOs" TypeName="Bul0056.Aggregates.DTOManager"></asp:ObjectDataSource>
</asp:Content>
