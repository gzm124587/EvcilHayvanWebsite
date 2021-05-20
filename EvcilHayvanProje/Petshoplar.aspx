<%@ Page Title="" Language="C#" MasterPageFile="~/TemplateWithoutForm.Master" AutoEventWireup="true" CodeBehind="Petshoplar.aspx.cs" Inherits="EvcilHayvanProje.Petshoplar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

       <div class="background-primary padding text-left">
        <asp:Label ID="Label1" runat="server" style="margin-left:250px; font-weight:bold; color:black;" Text=""></asp:Label>     
         <asp:TextBox ID="TextBox_Arama" runat="server"  style="" placeholder="Aranacak adres" title="Arama"></asp:TextBox>  
        <asp:Button ID="Button_Ara" runat="server" Text="ARA" OnClick="Button_Ara_Click" />
      </div>
    <hr />
    <table style="margin-left:270px; width:1035px">
        <thead>
            <tr>
                <th style="width: 250px;">İsim</th>
                <th>Telefon</th>
                <th>Adres</th>
                <th>Harita</th>

            </tr>
        </thead>
        <tbody >
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
