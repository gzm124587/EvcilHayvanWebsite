﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EvcilHayvanProje
{
    public partial class YaziSil : System.Web.UI.Page
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

        protected void Button_Sil_Click(object sender, EventArgs e)
        {
            if (TextBox_Sil.Text == "")
            {
                Response.Write("<script language='JavaScript'>alert('Boş alan bırakmayınız.');</script>");
            }
            else
            {
                objConn.Open();
                OleDbCommand objCmd = new OleDbCommand("delete from Yazi where yazi_id=@a", objConn);
                objCmd.Parameters.AddWithValue("@a", TextBox_Sil.Text);
                objCmd.ExecuteNonQuery();
                objConn.Close();
                Response.Write("<script language='JavaScript'>alert('Silindi.');</script>");
                TextBox_Sil.Text = "";
                YaziGetir();
            }
        }
    }
}