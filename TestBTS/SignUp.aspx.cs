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
    public partial class SignUp : System.Web.UI.Page
    {
        string connection = ConfigurationManager.ConnectionStrings["DBMS"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SignUpBTN_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con1 = new SqlConnection(connection))
                {
                    string sql = @"INSERT INTO [User](username, password, email, phone, country, city, postcode, name, address) VALUES(@username, @password, @email, @phone, @country, @city, @postcode, @name, @address)";
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.InsertCommand = new SqlCommand(sql, con1);
                    con1.Open();
                    da.InsertCommand.Parameters.Add("@username", SqlDbType.NVarChar).Value = UsernameTB.Text;
                    da.InsertCommand.Parameters.Add("@password", SqlDbType.NVarChar).Value = PassTB.Text;
                    da.InsertCommand.Parameters.Add("@email", SqlDbType.NVarChar).Value = EmailTB.Text;
                    da.InsertCommand.Parameters.Add("@phone", SqlDbType.NVarChar).Value = PhoneTB.Text;
                    da.InsertCommand.Parameters.Add("@country", SqlDbType.NVarChar).Value = CountryTB.Text;
                    da.InsertCommand.Parameters.Add("@city", SqlDbType.NVarChar).Value = CityTB.Text;
                    da.InsertCommand.Parameters.Add("@postcode", SqlDbType.NVarChar).Value = PostTB.Text;
                    da.InsertCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = NameTB.Text;
                    da.InsertCommand.Parameters.Add("@address", SqlDbType.NVarChar).Value = AddressTB.Text;
                    da.InsertCommand.ExecuteNonQuery();
                    con1.Close();

                    Response.Write("DATA ANDA BERHASIL DIMASUKKAN");
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}