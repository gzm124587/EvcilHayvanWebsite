<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="VeterinerArama.aspx.cs" Inherits="EvcilHayvanProje.VeterinerArama" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <hr />
            <table style="margin-left: 270px; width: 1035px">
        <thead>
            <tr>
                <th style="width: 250px;">İsim</th>
                <th>Telefon</th>
                <th>Adres</th>
                <th>Harita</th>

            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("isim")%></td>
                        <td><%# Eval("telefon") %></td>
                        <td><%# Eval("geneladres") %></td>
                        <td><%# Eval("harita") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
    <hr />
</asp:Content>
