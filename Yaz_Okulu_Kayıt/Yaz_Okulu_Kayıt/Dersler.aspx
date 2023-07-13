<%@ Page Title="" Language="C#" MasterPageFile="~/sablon.Master" AutoEventWireup="true" CodeBehind="Dersler.aspx.cs" Inherits="Yaz_Okulu_Kayıt.Dersler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <style>
        .ortalama {
            margin: 0 auto 0 auto;
            text-align: center;
        }
    </style>
    <form runat="server">
        <div>
            <strong><asp:Label ID="Label1" runat="server" Text="Ders Seçin"></asp:Label></strong>
            <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server"></asp:DropDownList>
        </div>
        <br />
        <div>
            <asp:Label ID="Label2" runat="server" Text="Öğrenci ID"></asp:Label>
            <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <br />
        <div class="ortalama">
        <asp:Button ID="Button1" runat="server" Text="Talep Oluştur" Width="164px" Height="70px" CssClass="btn btn-warning" Font-Size="Large" Style="font-weight: bold;" OnClick="Button1_Click" />
        </div>
    </form>
</asp:Content>
