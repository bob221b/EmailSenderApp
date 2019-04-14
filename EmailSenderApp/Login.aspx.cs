using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmailSenderApp
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["EmailSenderApp_DBConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "select * from user_details";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr[1].Equals(txt_usr_nme.Text) && dr[2].Equals(txt_usr_pwd.Text))
            {
                
            }
            else
            {
                lbl_msg_fail.Text = "Oops...Login Failed!!! Please enter correct Username & Password";
            }

        }

        protected void btn_nav_createuser_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateUser.aspx");
        }
    }
}