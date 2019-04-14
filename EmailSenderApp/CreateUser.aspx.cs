using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmailSenderApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["EmailSenderApp_DBConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_createuser_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "select * from user_details";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                string email = txt_email.Text;
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(email);
                string query2 = "insert into user_details (usr_name, nme, email, mobile_no, pwd) Values ('" + txt_username.Text + "','" + txt_name.Text + "','" + txt_email.Text + "','" + txt_mobile.Text + "','" + txt_pwd.Text + "')";
                SqlCommand cmdd = new SqlCommand(query2, conn);
                //int count = 0;
                bool isok = false;
                if (dr.Read())
                {
                    if (dr[1].Equals(txt_username.Text))
                    {
                        lblUserCreate.Text = "Username Already Exist!!!";
                        txt_username.Text = "";
                    }
                    else if (dr[3].Equals(txt_email.Text))
                    {
                        lblUserCreate.Text = "Email Already Exist!!!";
                        txt_email.Text = "";
                    }
                    else if (dr[4].Equals(txt_mobile.Text))
                    {
                        lblUserCreate.Text = "Mobile Already Exist!!!";
                        txt_mobile.Text = "";
                    }
                    else if (txt_mobile.Text.Length > 10)
                    {
                        lblUserCreate.Text = "Mobile Number Should not more than 10 Digits!!";
                        txt_mobile.Text = "";
                    }
                    else if (txt_pwd.Text != txt_cnf_pwd.Text)
                    {
                        lblUserCreate.Text = "Passwords Dosen't Match!!";
                        txt_cnf_pwd.Text = "";
                        txt_pwd.Text = "";
                    }
                    else if (match.Success)
                    {
                        //dr.Close();
                        //cmdd.ExecuteNonQuery();
                        //lblUserCreate.Text = "User Created Successfully!!!!";
                        isok = true;
                    }

                }
                else
                {
                    
                   if (txt_mobile.Text.Length > 10)
                    {
                        lblUserCreate.Text = "Mobile Number Should not more than 10 Digits!!";
                        txt_mobile.Text = "";
                    }
                    else if (txt_pwd.Text != txt_cnf_pwd.Text)
                    {
                        lblUserCreate.Text = "Passwords Dosen't Match!!";
                        txt_cnf_pwd.Text = "";
                        txt_pwd.Text = "";
                    }
                    else if(match.Success)
                    {
                        dr.Close();
                        cmdd.ExecuteNonQuery();
                        lblUserCreate.Text = "User Created Successfully!!!!";
                    }
                }
                if (isok==true)
                {
                    dr.Close();
                    cmdd.ExecuteNonQuery();
                    lblUserCreate.Text = "User Created Successfully!!!!";
                }
               cmdd.Dispose();
                dr.Close();
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
            
            
        }
    }
}