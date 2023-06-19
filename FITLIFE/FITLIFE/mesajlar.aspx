<%@ Page Title="" Language="C#" MasterPageFile="~/anasayfa.master" AutoEventWireup="true" CodeFile="mesajlar.aspx.cs" Inherits="mesajlar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="gv_mesajlar" runat="server" OnRowCommand="gv_mesajlar_RowCommand" >
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="sil" Text="Sil" />
        </Columns>
    </asp:GridView>

</asp:Content>

