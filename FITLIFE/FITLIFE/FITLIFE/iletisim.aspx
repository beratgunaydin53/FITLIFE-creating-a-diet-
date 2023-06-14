<%@ Page Title="" Language="C#" MasterPageFile="~/anasayfa.master" AutoEventWireup="true" CodeFile="iletisim.aspx.cs" Inherits="iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/iletisim.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="mainbody">
        <header>
            <h1>Fit Life İletişim</h1>
        </header>
        <section>
            <h2>Bize Ulaşın</h2>
		<p>Eğer bize ulaşmak isterseniz, aşağıdaki formu doldurabilirsiniz.</p> <br />
		<form>
			<label for="adsoyad">Adınız Soyadınız:</label>
			<input type="text" id="adsoyad" name="adsoyad" required>

			<label for="email">E-posta Adresiniz:</label>
			<input type="email" id="email" name="email" required>

			<label for="konu">Konu:</label>
			<input type="text" id="konu" name="konu" required>

			<label for="mesaj">Mesajınız:</label>
			<textarea id="mesaj" name="mesaj" rows="8" required></textarea>

			<input type="submit" value="Gönder">
		</form>
        </section>
    </div>
</asp:Content>

