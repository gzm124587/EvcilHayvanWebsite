<%@ Page Title="" Language="C#" MasterPageFile="~/AdminDefault.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EvcilHayvanProje.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- MAIN -->
    <main role="main">
        <!-- Content -->
        <article>
            <header class="background-primary text-center">
                <br />
                <h1 class="text-white margin-bottom-0 text-size-20 text-thin text-line-height-1">GİRİŞ</h1>
                <br />
            </header>

            <br />

            <div style="text-align: center">

                <form id="Form1" method="post" runat="server" class="customform text-white">
                    <div class="s-12">
                        <asp:TextBox ID="TextBox_Email" runat="server" class="required email border-radius text-dark" placeholder="E-mail adresi" title="E-mail adresiniz" Width="250px"></asp:TextBox>
                    </div>

                    <div class="s-12">
                        <asp:TextBox ID="TextBox_Sifre" runat="server" class="required message border-radius text-dark" placeholder="Şifre" TextMode="Password" Width="250px">*</asp:TextBox>
                    </div>
                    <div class="s-12">
                        <asp:Button ID="Button_Send" runat="server" Text="GİRİŞ YAP" class="submit-form button background-primary border-radius " Width="250px" OnClick="Button_Send_Click" />
                    </div>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox_Email" ErrorMessage="*Email Hatalı" Font-Size="Medium" class="text-dark" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </form>

            </div>

        </article>

    </main>



</asp:Content>
