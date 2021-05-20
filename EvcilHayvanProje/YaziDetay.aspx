<%@ Page Title="" Language="C#" MasterPageFile="~/TemplateWithoutForm.Master" AutoEventWireup="true" runat="server" CodeBehind="YaziDetay.aspx.cs" Inherits="EvcilHayvanProje.YaziDetay" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString3 %>" ProviderName="<%$ ConnectionStrings:ConnectionString3.ProviderName %>" SelectCommand="SELECT * FROM [Yazi] inner join Yonetici on Yonetici.yonetici_id = Yazi.yonetici_id WHERE ([yazi_id] = ?)">
        <SelectParameters>
            <asp:QueryStringParameter Name="yazi_id" QueryStringField="yazi" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>




    <asp:FormView ID="FormView1" runat="server" DataKeyNames="yazi_id" DataSourceID="SqlDataSource1">
        <ItemTemplate>


            <article>

                <div class="section background-white">
                    <div class="line">
                        <div class="margin text-center">
                            <div class="s-12 margin-bottom">
                                <div class="padding-2x block-bordered border-radius">
                                    <div align="center">
                                        <img src="<%# Eval("resim") %>" style="height: 150px; width: 350px;" />
                                    </div>
                                    <br />
                                    <h2 class="text-thin"><%# Eval("baslik") %></h2>

                                    <p class="margin-bottom-30" style="text-align:left"><%# Eval("icerik") %></p>

                                   
                                    <p style="text-align: right; font-size:medium;"><b><%#Eval("isim")%> <%#Eval("soyisim")%></b></p>
                                </div>
                            </div>
        </ItemTemplate>
    </asp:FormView>

</asp:Content>
