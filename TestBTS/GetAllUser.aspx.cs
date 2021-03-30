using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.IO;

namespace TestBTS
{
    public partial class GetAllUser : System.Web.UI.Page
    {
        string connection = ConfigurationManager.ConnectionStrings["DBMS"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Selamat Datang... " + Session["username"];
            readData();
        }

        private void readData()
        {
            try
            {
                using (SqlConnection con1 = new SqlConnection(connection))
                {
                    string sql = @"SELECT * FROM [User]";
                    SqlCommand cmd = new SqlCommand(sql, con1);
                    con1.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    GridView1.DataSource = dr;
                    GridView1.DataBind();
                    int rowcount = GridView1.Rows.Count;

                    if (rowcount == 0)
                    {
                        Response.Write("data kosong");
                    }


                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}