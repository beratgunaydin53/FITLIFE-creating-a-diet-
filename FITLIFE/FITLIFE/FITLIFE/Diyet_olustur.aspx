<%@ Page Title="" Language="C#" MasterPageFile="~/anasayfa.master" AutoEventWireup="true" CodeFile="Diyet_olustur.aspx.cs" Inherits="Diyet_olustur" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/Anasayfa.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <script type="text/javascript">
    function OnlyNumbers(event) {
        var charCode = (event.which) ? event.which : event.keyCode;
        if (charCode > 31 && (charCode < 48 || charCode > 57)) {
            return false;
        }
        return true;
    }
    </script>
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lbl_cins" runat="server" Text="Cinsiyet:" Font-Size="Larger"></asp:Label>
            </td>
            <td>
                &nbsp;&nbsp;
               <asp:DropDownList ID="ddl_cins" runat="server">
                   <asp:ListItem>Seçiniz...</asp:ListItem>
                   <asp:ListItem>Erkek</asp:ListItem>
                   <asp:ListItem>Kadın</asp:ListItem>
                </asp:DropDownList>
            &nbsp;
                <asp:Label ID="lbl_bosCins" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lbl_yas" runat="server" Text="Yaş:" Font-Size="Larger"></asp:Label>
            </td>
            <td>
                &nbsp;&nbsp;
                <asp:TextBox ID="txt_yas" runat="server" onkeypress="return OnlyNumbers(event)"></asp:TextBox>
            &nbsp;
                <asp:Label ID="lbl_yasBos" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lbl_boy" runat="server" Text="Boy:" Font-Size="Larger"></asp:Label>
            </td>
            <td>
                &nbsp;&nbsp;
                <asp:TextBox ID="txt_boy" runat="server" onkeypress="return OnlyNumbers(event)"></asp:TextBox>
            &nbsp;
                <asp:Label ID="lbl_boyBos" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lbl_kilo" runat="server" Text="Kilo:" Font-Size="Larger"></asp:Label>
            </td>
            <td>
                &nbsp;&nbsp;
                <asp:TextBox ID="txt_kilo" runat="server" onkeypress="return OnlyNumbers(event)"></asp:TextBox>
            &nbsp;
                <asp:Label ID="lbl_kiloBos" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lbl_gün" runat="server" Text="Günde Kaç Adım Atıyorsunuz" Font-Size="Larger"></asp:Label>
            </td>
            <td>
                &nbsp;&nbsp;
                <asp:DropDownList ID="ddl_adimlar" runat="server">
                    <asp:ListItem>Seçiniz...</asp:ListItem>
                    <asp:ListItem>0-1000</asp:ListItem>
                    <asp:ListItem>1000-5000</asp:ListItem>
                    <asp:ListItem>5000-10000</asp:ListItem>
                    <asp:ListItem>10000-20000</asp:ListItem>
                    <asp:ListItem>20000 ve Üzeri</asp:ListItem>
                </asp:DropDownList>
            &nbsp;
                <asp:Label ID="lbl_adimBos" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>

            </td>
            <td>
                &nbsp;&nbsp;
                <asp:Button ID="btn_dytOlustur" runat="server" Text="Diyet Oluştur" Font-Size="Larger" Height="40px" Width="154px" OnClick="btn_dytOlustur_Click" />
            </td>
        </tr>
    </table>
    <br />
    <br />
    <asp:Label runat="server" ID="lbl_almasiGerekenler" Font-Size="Larger" Visible="False"></asp:Label>
    <br />
    <asp:Label runat="server" Text="Uyarı:" ID="lbl_uyari" Font-Size="Larger" ForeColor="Red" Visible="False"></asp:Label>
        <br />
    <br />
    <Table>
        <tr>
            <td><asp:Label ID="lblSabah" runat="server" Text="(08:00-09:00)  Sabah Öğünü" Visible="False"></asp:Label> </td>
            <td><asp:GridView ID="gvSabah" runat="server" Visible="False"></asp:GridView></td>
            <td><asp:Button ID="btn_SabahDegis" runat="server" Text="Öğünü Değiştir" OnClick="btn_SabahDegis_Click" Visible="False" /></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblAraSabah" runat="server" Text="(10:00-11:00)   Ara Öğün" Visible="False"></asp:Label></td>
            <td><asp:GridView ID="gvAraSabah" runat="server" Visible="False"></asp:GridView> </td>
            <td><asp:Button ID="btn_AraSabahDegis" runat="server" Text="Öğünü Değiştir" OnClick="btn_AraSabahDegis_Click" Visible="False" /></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblOgle" runat="server" Text="(12:00-13:00)  Öğle Öğünü" Visible="False"></asp:Label> </td>
            <td><asp:GridView ID="gvOgle" runat="server" Visible="False"></asp:GridView> </td>
            <td><asp:Button ID="btn_OgleDegis" runat="server" Text="Öğünü Değiştir" OnClick="btn_OgleDegis_Click" Visible="False" /> </td>
        </tr>
        <tr>
            <td><asp:Label ID="lblAraOgle" runat="server" Text="(15:00-16:00)  Ara Öğün" Visible="False"></asp:Label> </td>
            <td><asp:GridView ID="gvAraOgle" runat="server" Visible="False"></asp:GridView> </td>
            <td><asp:Button ID="btn_AraOgleDegis" runat="server" Text="Öğünü Değiştir" OnClick="btn_AraOgleDegis_Click" Visible="False" /> </td>
        </tr>
        <tr>
            <td><asp:Label ID="lblAksam" runat="server" Text="(18:00-19:00)  Akşam Öğünü" Visible="False"></asp:Label></td>
            <td> <asp:GridView ID="gvAksam" runat="server" Visible="False"></asp:GridView> </td>
            <td> <asp:Button ID="btn_AksamDegis" runat="server" Text="Öğünü Değiştir" OnClick="btn_AksamDegis_Click" Visible="False" /> </td>
        </tr>
        <tr>
            <td><asp:Label ID="lblAksamAra" runat="server" Text="(20:00-21:00)  Ara Öğün" Visible="False"></asp:Label> </td>
            <td><asp:GridView ID="gvAksamAra" runat="server" Visible="False"></asp:GridView> </td>
            <td> <asp:Button ID="btn_AksamAraDegis" runat="server" Text="Öğünü Değiştir" OnClick="btn_AksamAraDegis_Click" Visible="False" /> </td>
        </tr>
        <tr>
            <td> </td>
            <td></td>
            <td><asp:Button ID="btnPrint" runat="server" Text="Sayfayı Yazdır" OnClick="btnPrint_Click" Font-Size="Larger" Width="130px" Visible="False" />  </td>
        </tr>
    </Table>
</asp:Content>

