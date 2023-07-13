<%@ Page Title="" Language="C#" MasterPageFile="~/sablon.Master" AutoEventWireup="true" CodeBehind="OgrKayıt.aspx.cs" Inherits="Yaz_Okulu_Kayıt.AnaSayfa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <style>
        .ortalama {
            margin: 0 auto 0 auto;
            text-align: center;
        }
    </style>
    <form id="Form1" runat="server">
        <div>
            <div class="form-group">
                <div>
                    <strong>
                        <asp:Label for="TextBox1" runat="server" Text="Öğrenci Adı"></asp:Label></strong>
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <br />
                <div>
                    <strong>
                        <asp:Label for="TextBox2" runat="server" Text="Öğrenci Soyadı"></asp:Label></strong>
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <br />
                <div>
                    <strong>
                        <asp:Label for="TextBox3" runat="server" Text="Öğrenci Numarası"></asp:Label></strong>
                    <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <br />
                <div>
                    <strong>
                        <asp:Label for="TextBox4" runat="server" Text="Öğrenci Şifresi"></asp:Label></strong>
                    <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                </div>
                <br />
                <div>
                    <strong>
                        <asp:Label for="TextBox5" runat="server" Text="Öğrenci Fotoğrafı"></asp:Label></strong>
                    <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <br />
                <div>
                    <strong>
                        <asp:Label for="TextBox6" runat="server" Text="Öğrenci Bakiyesi"></asp:Label></strong>
                    <asp:TextBox ID="TextBox6" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <br />
            </div>

            <div class="ortalama">
                <asp:Button ID="Button1" runat="server" Text="Kaydet" Height="75px" OnClick="Button1_Click" Width="164px" CssClass="btn btn-info" Font-Size="Large" Style="font-weight: bold;" />
            </div>
        </div>
    </form>
</asp:Content>
