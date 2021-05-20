using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EvcilHayvanProje
{
    public partial class YaziEkle : System.Web.UI.Page
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
            if (TextBox_Baslik.Text=="" || TextBox_Icerik.Text=="" || FileUpload1.FileName=="")
            {
                Response.Write("<script language='JavaScript'>alert('Boş alan bırakmayınız.');</script>");
            }
            else
            {
                FileUpload1.SaveAs(Server.MapPath("/img/") + FileUpload1.FileName);
                objConn.Open();
                OleDbCommand objCmd = new OleDbCommand("insert into Yazi(baslik,yonetici_id,resim,icerik) values(=@a,@b,@x,@y)", objConn);
                objCmd.Parameters.AddWithValue("@a", TextBox_Baslik.Text);
                objCmd.Parameters.AddWithValue("@b", Convert.ToInt32(Session["admin"].ToString()));
                objCmd.Parameters.AddWithValue("@x", "/img/" + FileUpload1.FileName);
                objCmd.Parameters.AddWithValue("@y", TextBox_Icerik.Text);
                objCmd.ExecuteNonQuery();
                objConn.Close();
                Response.Write("<script language='JavaScript'>alert('Kayıt Başarılı');</script>");
                TextBox_Baslik.Text = "";
                TextBox_Icerik.Text = "";
                
            }


        }
    }
}