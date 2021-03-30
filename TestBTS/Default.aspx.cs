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
    public partial class Default : System.Web.UI.Page
    {
        string connection = ConfigurationManager.ConnectionStrings["DBMS"].ConnectionString;
        int tmp;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SignInBTN_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn1 = new SqlConnection(connection))
                {
                    tmp = 0;

                    string sql = @"SELECT * FROM [User]";
                    SqlCommand cmd = new SqlCommand(sql, conn1);
                    conn1.Open();
                    SqlDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        string usernameRead = (string)read["username"];
                        string emailRead = (string)read["email"];
                        string passwordRead = (string)read["password"];

                        if (EmailTB.Text == emailRead && PassTB.Text == passwordRead)
                        {
                            tmp = 1;
                            Session["username"] = usernameRead;
                            Session["email"] = emailRead;
                            Session["password"] = passwordRead;
                            Response.Redirect("GetAllUser.aspx");
                         
                        }
                    }
                    if (tmp != 1)
                    {
                        Response.Write("username atau password salah");
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void SingUpBTN_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx");
        }
    }
}