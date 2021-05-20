using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EvcilHayvanProje
{
    public partial class Yazilar : System.Web.UI.Page
    {
        OleDbConnection objConn = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=" + HttpContext.Current.Server.MapPath("/App_Data/EvcilHayvan.accdb"));
        protected void Page_Load(object sender, EventArgs e)
        {
            YaziGetir();
        }

        private void YaziGetir()
        {
            OleDbCommand objCmd = new OleDbCommand("Select * from Yazi inner join Yonetici on Yonetici.yonetici_id = Yazi.yonetici_id");
            objCmd.Connection = objConn;
            OleDbDataAdapter objDataAdapter = new OleDbDataAdapter(objCmd);
            DataTable objDt = new DataTable();
            objConn.Open();
            objDataAdapter.Fill(objDt);
            objConn.Close();
            Repeater1.DataSource = objDt;
            Repeater1.DataBind();
        }

        protected void Button_Ara_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Arama.aspx?arananKelime=" + TextBox_Arama.Text);
        }
    }
}