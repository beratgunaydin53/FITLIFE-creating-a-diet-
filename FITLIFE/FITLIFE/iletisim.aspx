<%@ Page Title="" Language="C#" MasterPageFile="~/anasayfa.master" AutoEventWireup="true" CodeFile="iletisim.aspx.cs" Inherits="iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/iletisim.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="mainbody">
					<asp:Label ID="LblMesajKontrol" runat="server" Font-Size="Larger"></asp:Label>
        <header>
            <h1>Fit Life İletişim</h1>
        </header>
        <section>
            <h2>Bize Ulaşın</h2>
		<p>Eğer bize ulaşmak isterseniz, aşağıdaki formu doldurabilirsiniz.</p> <br />
		<form>
			<label for="adsoyad">Adınız Soyadınız:</label>
			<asp:TextBox ID="txt_adsoyad" runat="server"></asp:TextBox>
			<label for="email">E-posta Adresiniz:</label>	
			<asp:TextBox ID="txt_posta" runat="server" TextMode="Email"></asp:TextBox>
			<label for="konu">Konu:</label>			
			<asp:TextBox ID="txt_konu" runat="server"></asp:TextBox>

			<label for="mesaj">Mesajınız:</label>
			<asp:TextBox ID="txt_mesaj" runat="server" Height="45px" TextMode="MultiLine" Width="100%"></asp:TextBox>
			<asp:Button ID="btn_gonder" runat="server" Text="Gönder" OnClick="BtnGonder_Click" />

		</form>
        </section>
    </div>
</asp:Content>

