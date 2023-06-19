<%@ Page Language="C#" AutoEventWireup="true" CodeFile="kontrol_panel.aspx.cs" Inherits="kontrol_panel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/kontrolpanel.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
<h2>Kontrol Paneli</h2>

<form action="/action_page.php" method="post">
  <div class="imgcontainer">
    <img src="img/149071.png" alt="Avatar" class="avatar" width="100px" height="300px">
  </div>

  <div class="container">
    <label for="uname"><b>Kullanıcı Adı</b></label>
      <asp:TextBox ID="txt_kullanıciAdi" runat="server" type="text" placeholder="Kullanıcı Adınızı Giriniz"></asp:TextBox>
    <label for="psw"><b>Şifre</b></label>
      <asp:TextBox ID="txt_sifre" type="password" placeholder="Şifrenizi Giriniz" runat="server"></asp:TextBox> 
      <asp:Button ID="btn_gonder" runat="server" Text="Giriş" OnClick="btn_gonder_Click" />
      <asp:Label ID="lbl_mesaj" runat="server" Font-Size="Larger" ForeColor="Red"></asp:Label>
  </div>
</form>
    </form>
</body>
</html>
