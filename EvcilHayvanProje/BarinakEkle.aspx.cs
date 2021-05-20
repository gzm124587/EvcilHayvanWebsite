using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EvcilHayvanProje
{
    public partial class BarinakEkle : System.Web.UI.Page
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
            if (TextBox_Isim.Text == "" || TextBox_Telefon.Text == "" || TextBox_Adres.Text == "" || TextBox_Harita.Text == "")
            {
                Response.Write("<script language='JavaScript'>alert('Boş alan bırakmayınız.');</script>");
            }
            else
            {
                objConn.Open();
                OleDbCommand objCmd = new OleDbCommand("insert into Sirket(isim,telefon,geneladres,harita,kategori_id) values(@a,@b,@c,@d,3)", objConn);
                objCmd.Parameters.AddWithValue("@a", TextBox_Isim.Text);
                objCmd.Parameters.AddWithValue("@b", TextBox_Telefon.Text);
                objCmd.Parameters.AddWithValue("@c", TextBox_Adres.Text);
                objCmd.Parameters.AddWithValue("@d", TextBox_Harita.Text);
                objCmd.ExecuteNonQuery();
                objConn.Close();
                Response.Write("<script language='JavaScript'>alert('Barınak Kaydedildi.');</script>");
                TextBox_Isim.Text = "";
                TextBox_Telefon.Text = "";
                TextBox_Adres.Text = "";
                TextBox_Harita.Text = "";
            }

        }
    }
}