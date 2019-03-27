<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/ThePage.Master" AutoEventWireup="true" CodeBehind="Zbrane.aspx.cs" Inherits="WF.Forms.Zbrane" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="idZbr" DataSourceID="SqlDataSource1" ShowFooter="True">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:TemplateField HeaderText="idZbr" InsertVisible="False" SortExpression="idZbr">
                <EditItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("idZbr") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("idZbr") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:LinkButton ID="LinkButtonInsert" ValidationGroup="INSERT" OnClick="LinkButtonInsert_Click" runat="server">Insert</asp:LinkButton>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Nazev" SortExpression="Nazev">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Nazev") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="UPDATE" runat="server" ErrorMessage="Nazev is required field" ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("Nazev") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txtNazev" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ValidationGroup="INSERT" runat="server" ErrorMessage="Nazev is required field" ControlToValidate="txtNazev" ForeColor="Red"></asp:RequiredFieldValidator>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Typ_zbrane" SortExpression="Typ_zbrane">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Typ_zbrane") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ValidationGroup="UPDATE" runat="server" ErrorMessage="Typ is required field" ControlToValidate="TextBox2" ForeColor="Red"></asp:RequiredFieldValidator>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("Typ_zbrane") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txtTyp" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ValidationGroup="INSERT" runat="server" ErrorMessage="Typ is required field" ControlToValidate="txtTyp" ForeColor="Red"></asp:RequiredFieldValidator>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Raze" SortExpression="Raze">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Raze") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ValidationGroup="UPDATE" runat="server" ErrorMessage="Raze is required field" ControlToValidate="TextBox3" ForeColor="Red"></asp:RequiredFieldValidator>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("Raze") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txtRaze" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ValidationGroup="INSERT" runat="server" ErrorMessage="Raze is required field" ControlToValidate="txtRaze" ForeColor="Red"></asp:RequiredFieldValidator>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Rok_vyroby" SortExpression="Rok_vyroby">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("Rok_vyroby") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ValidationGroup="UPDATE" runat="server" ErrorMessage="Rok is required field" ControlToValidate="TextBox4" ForeColor="Red"></asp:RequiredFieldValidator>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" Text='<%# Bind("Rok_vyroby") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txtRok" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" ValidationGroup="INSERT" runat="server" ErrorMessage="Rok is required field" ControlToValidate="txtRok" ForeColor="Red"></asp:RequiredFieldValidator>
                </FooterTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
        <RowStyle BackColor="White" ForeColor="#003399" />
        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
        <SortedAscendingCellStyle BackColor="#EDF6F6" />
        <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
        <SortedDescendingCellStyle BackColor="#D6DFDF" />
        <SortedDescendingHeaderStyle BackColor="#002876" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:bul0056ConnectionString %>" DeleteCommand="DELETE FROM [Zbran] WHERE [idZbr] = @idZbr" InsertCommand="INSERT INTO [Zbran] ([Nazev], [Typ_zbrane], [Raze], [Rok_vyroby]) VALUES (@Nazev, @Typ_zbrane, @Raze, @Rok_vyroby)" SelectCommand="SELECT * FROM [Zbran]" UpdateCommand="UPDATE [Zbran] SET [Nazev] = @Nazev, [Typ_zbrane] = @Typ_zbrane, [Raze] = @Raze, [Rok_vyroby] = @Rok_vyroby WHERE [idZbr] = @idZbr">
        <DeleteParameters>
            <asp:Parameter Name="idZbr" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Nazev" Type="String" />
            <asp:Parameter Name="Typ_zbrane" Type="String" />
            <asp:Parameter Name="Raze" Type="Double" />
            <asp:Parameter Name="Rok_vyroby" Type="Int32" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Nazev" Type="String" />
            <asp:Parameter Name="Typ_zbrane" Type="String" />
            <asp:Parameter Name="Raze" Type="Double" />
            <asp:Parameter Name="Rok_vyroby" Type="Int32" />
            <asp:Parameter Name="idZbr" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>
