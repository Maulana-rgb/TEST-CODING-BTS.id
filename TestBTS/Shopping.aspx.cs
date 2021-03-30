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
    public partial class Shopping : System.Web.UI.Page
    {
        string connection = ConfigurationManager.ConnectionStrings["DBMS"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                readData();
            }
            
        }

        private void readData()
        {
            try
            {
                using (SqlConnection con1 = new SqlConnection(connection))
                {
                    string sql = @"SELECT * FROM [shopping]";
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

        protected void CreateBTN_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con1 = new SqlConnection(connection))
                {
                    string sql = @"INSERT INTO [shopping](name, createdate) VALUES(@name, GETDATE())";
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.InsertCommand = new SqlCommand(sql, con1);
                    con1.Open();
                    da.InsertCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = NameTB.Text;
                    
                    da.InsertCommand.ExecuteNonQuery();
                    con1.Close();

                    Response.Write("DATA ANDA BERHASIL DIMASUKKAN");
                    readData();
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void SearchBTN_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn2 = new SqlConnection(connection))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM [shopping] WHERE id = " + SearchNameTB.Text , conn2);
                    conn2.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    GridView1.DataSource = rdr;
                    GridView1.DataBind();
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}