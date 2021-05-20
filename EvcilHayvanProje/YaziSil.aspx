<%@ Page Title="" Language="C#" MasterPageFile="~/AdminDefault.Master" AutoEventWireup="true" CodeBehind="YaziSil.aspx.cs" Inherits="EvcilHayvanProje.YaziSil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <style type="text/css">
        .tbx {
            display: block;
            width: 100%;
            height: 34px;
            padding: 6px 12px;
            font-size: 14px;
            line-height: 1.42857143;
            color: #555;
            background-color: #fff;
            background-image: none;
            border: 1px solid #ccc;
            border-radius: 4px;
            -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, .075);
            box-shadow: inset 0 1px 1px rgba(0, 0, 0, .075);
            -webkit-transition: border-color ease-in-out .15s, -webkit-box-shadow ease-in-out .15s;
            -o-transition: border-color ease-in-out .15s, box-shadow ease-in-out .15s;
            transition: border-color ease-in-out .15s, box-shadow ease-in-out .15s;
        }

        .btn {
            display: inline-block;
            padding: 6px 12px;
            margin-bottom: 0;
            font-size: 14px;
            font-weight: normal;
            line-height: 1.42857143;
            text-align: center;
            white-space: nowrap;
            vertical-align: middle;
            -ms-touch-action: manipulation;
            touch-action: manipulation;
            cursor: pointer;
            -webkit-user-select: none;
            -moz-user-select: none;
            -ms-user-select: none;
            user-select: none;
            background-image: none;
            border: 1px solid transparent;
            border-radius: 4px;
            color: #fff;
            background-color: #d9534f;
            border-color: #d43f3a;
            
        }
    </style>

    <header class="background-primary text-center">
        <br />
        <h1 class="text-white margin-bottom-0 text-size-20 text-thin text-line-height-1">YAZI SİL</h1>
        <br />
    </header>
    <div style="width:250px; margin-left:625px;">
    <form runat="server">
    
        <asp:Label ID="Label1" runat="server" style="margin-left:250px; font-weight:bold; color:black;" Text=""></asp:Label>     
         <asp:TextBox ID="TextBox_Sil" runat="server"  class="tbx" placeholder="Silinecek id" title="Sil"></asp:TextBox>  
       <div style="text-align:right; margin-top:5px;">
        <asp:Button ID="Button_Sil" runat="server" Text="SİL"  class="btn" OnClick="Button_Sil_Click" />
      </div>
        </form>
    </div>
    <hr />

        <table style="margin-left:270px; width:1035px">
        <thead>
            <tr>
                <th> ID </th>
                <th style="width: 500px;">#</th>
                <th>Yazar</th>
                <th>Konu</th>
                <th></th>

            </tr>
        </thead>
        <tbody >
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td> <%# Eval("yazi_id") %> </td>
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
