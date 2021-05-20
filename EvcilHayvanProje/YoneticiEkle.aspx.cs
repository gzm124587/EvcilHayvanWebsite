using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EvcilHayvanProje
{
    public partial class YoneticiEkle : System.Web.UI.Page
    {
        OleDbConnection objConn = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=" + HttpContext.Current.Server.MapPath("/App_Data/EvcilHayvan.accdb"));
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToString(Session["admin"]) == "")
            {
                Response.Redirect("Login.aspx");
                Response.End();
            }
        }

        protected void Button_Ekle_Click(object sender, EventArgs e)
        {
            if (TextBox_Isim.Text == "" || TextBox_Soyisim.Text == "" || TextBox_Email.Text == "" || TextBox_Sifre.Text == "")
            {
                Response.Write("<script language='JavaScript'>alert('Boş alan bırakmayınız.');</script>");
            }
            else
            {
                objConn.Open();
                OleDbCommand objCmd = new OleDbCommand("insert into Yonetici(isim,soyisim,email,şifre) values(@a,@b,@c,@d)", objConn);
                objCmd.Parameters.AddWithValue("@a", TextBox_Isim.Text);
                objCmd.Parameters.AddWithValue("@b", TextBox_Soyisim.Text);
                objCmd.Parameters.AddWithValue("@c", TextBox_Email.Text);
                objCmd.Parameters.AddWithValue("@d", TextBox_Sifre.Text);
                objCmd.ExecuteNonQuery();
                objConn.Close();
                Response.Write("<script language='JavaScript'>alert('Yönetici Kaydedildi.');</script>");
                TextBox_Isim.Text = "";
                TextBox_Soyisim.Text = "";
                TextBox_Email.Text = "";
                TextBox_Sifre.Text = "";
            }

        }
    }
}