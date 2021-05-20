using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EvcilHayvanProje
{
    public partial class Login : System.Web.UI.Page
    {
        OleDbConnection objConn = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=" + HttpContext.Current.Server.MapPath("/App_Data/EvcilHayvan.accdb"));
        OleDbDataReader dr;
        OleDbCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToString(Session["admin"]) != "")
            {
                Response.Redirect("AdminHPage.aspx");
                Response.End();
            }  
        }

        protected void btnGiris_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button_Send_Click(object sender, EventArgs e)
        {
            OleDbCommand db_komut;
            objConn.Open();
            string sorgu = "SELECT COUNT(*) FROM Yonetici WHERE email=@a and şifre=@sifre";
            db_komut = new OleDbCommand(sorgu, objConn);
            db_komut.Parameters.Add("@a", OleDbType.VarChar).Value = TextBox_Email.Text;
            db_komut.Parameters.Add("@sifre", OleDbType.VarChar).Value = TextBox_Sifre.Text;
            int kayitsayisi = (int)db_komut.ExecuteScalar();
            objConn.Close();
            objConn = null;
            if (kayitsayisi <= 0)
            {
                Response.Write("<script language='JavaScript'>alert('Kullanıcı adı veya Şifre Yanlış');</script>");
            }
            else
            {
                IDBUL();
                Response.Write("<script language='JavaScript'>alert('Giriş yapıldı.');</script>");
                Response.Redirect("AdminHPage.aspx");
                Response.End();
            }
        }

        private void IDBUL()
        {
            objConn = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=" + HttpContext.Current.Server.MapPath("/App_Data/EvcilHayvan.accdb"));
            cmd = new OleDbCommand();
            objConn.Open();
            cmd.Connection = objConn;
            cmd.CommandText = "SELECT yonetici_id FROM Yonetici where email=@a";
            cmd.Parameters.AddWithValue("@a", TextBox_Email.Text);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Session["admin"] = dr["yonetici_id"];

            }
            objConn.Close();
        }
    }
}