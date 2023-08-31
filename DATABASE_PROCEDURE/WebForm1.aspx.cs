using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DATABASE_PROCEDURE
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            cmd = new SqlCommand();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\OneDrive\Documents\Employee_Database.mdf;Integrated Security=True;Connect Timeout=30";
        }   
        protected void insbtn_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Connection = con;
                cmd.CommandText = "EmpPro";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@eid", eidtxt.Text);
                cmd.Parameters.AddWithValue("@ename", enametxt.Text);
                cmd.Parameters.AddWithValue("@ecity", ecitytxt.Text);
                cmd.Parameters.AddWithValue("@esal", esaltxt.Text);
                cmd.Parameters.AddWithValue("@op", 1);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                if (i > 0)
                {
                    Response.Write("Recored Inserted");

                }
                else
                {
                    Response.Write("Somthing Went Wrong");
                }
                eidtxt.Text = "";
                enametxt.Text = "";
                ecitytxt.Text = "";
                esaltxt.Text = "";

            }
            catch(SqlException sqlex)
            {
                Response.Write(sqlex.Message);
            }
            catch(Exception ex) 
            {
                Response.Write(ex.Message);
            }
            
        }
        
        protected void delbtn_Click(object sender, EventArgs e) 
        {
            try
            {
                cmd.Connection = con;
                cmd.CommandText = "EmpPro";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@eid", eidtxt.Text);
                cmd.Parameters.AddWithValue("@op", 2);
                con.Open();

                int i = cmd.ExecuteNonQuery();
                con.Close();
                if (i > 0)
                {
                    Response.Write("Recored Deleted");
                }
                else
                {
                    Response.Write("Something Went Wrong");
                }
                eidtxt.Text = "";
            }
            catch (SqlException sqlex)
            {
                Response.Write(sqlex.Message);
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }

        }
        protected void updbtn_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Connection = con;
                cmd.CommandText = "EmpPro";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@eid",eidtxt.Text);
                cmd.Parameters.AddWithValue("@ename", enametxt.Text);
                cmd.Parameters.AddWithValue("@ecity", ecitytxt.Text);
                cmd.Parameters.AddWithValue("@esal", esaltxt.Text);
                cmd.Parameters.AddWithValue("@op", 3);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();

                if(i > 0) 
                {
                    Response.Write("Recored Updated");
                }
                else
                {
                    Response.Write("Something Went Wrong");
                }
                eidtxt.Text = "";
                enametxt.Text = "";
                ecitytxt.Text = "";
                esaltxt.Text = "";


            }
            catch(SqlException sqlex)
            {
                Response.Write(sqlex.Message);
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void disbtn_Click(Object sender, EventArgs e)
        {
            try
            {
                cmd.Connection = con;
                cmd.CommandText = "EmpPro";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader r;
                cmd.Parameters.AddWithValue("@op", 4);
                con.Open();
                r = cmd.ExecuteReader();
                
                gridv.DataSource= r;
                gridv.DataBind();
                con.Close();
            }
            catch (SqlException sqlex)
            {
                Response.Write(sqlex.Message);
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }

        }
    }
}