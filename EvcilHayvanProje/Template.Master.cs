using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EvcilHayvanProje
{
    public partial class Template : System.Web.UI.MasterPage
    {
        OleDbConnection objConn = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=" + HttpContext.Current.Server.MapPath("/App_Data/EvcilHayvan.accdb"));
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button_Send_Click(object sender, EventArgs e)
        {
            if (TextBox_Message.Text == "" || TextBox_Email.Text == "" || TextBox_Name.Text == "")
            {
                Response.Write("<script language='JavaScript'>alert('Boş kısım bırakmayınız.');</script>");
            }
            else
            {
                objConn.Open();
                OleDbCommand objCmd = new OleDbCommand("insert into İletisim(email,isim,mesaj) values(@a,@b,@c)", objConn);
                objCmd.Parameters.AddWithValue("@a", TextBox_Email.Text);
                objCmd.Parameters.AddWithValue("@b", TextBox_Name.Text);
                objCmd.Parameters.AddWithValue("@c", TextBox_Message.Text);
                objCmd.ExecuteNonQuery();
                objConn.Close();
                Response.Write("<script language='JavaScript'>alert('Mesaj Gönderildi.');</script>");
                TextBox_Email.Text = "";
                TextBox_Name.Text = "";
                TextBox_Message.Text = "";
            }
          
        }
    }
}