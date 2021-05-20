<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="Arama.aspx.cs" Inherits="EvcilHayvanProje.Arama" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <hr />
        <table style="margin-left:270px; width:1035px">
        <thead>
            <tr>
                <th style="width: 500px;">#</th>
                <th>Yazar</th>
                <th>Konu</th>
                <th></th>

            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td>
                            <img src="<%# Eval("resim") %>" style="height: 150px; width: 350px;" /></td>
                        <td><%#Eval("isim")%> <%#Eval("soyisim")%></a></td>
                        <td><%# Eval("baslik") %></td>
                        <td><b><a class="button border-radius background-primary text-size-12 text-white text-strong" href="<%# "/YaziDetay.aspx?yazi="+Eval("yazi_id") %>">DEVAMI</a></b></td>
                        
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
    <hr />
</asp:Content>
