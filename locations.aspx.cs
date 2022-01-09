using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;
namespace foody
{
    public partial class locations : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
                MySqlConnection sqlconn = new MySqlConnection(mainconn);
                string sqlq = "SELECT * FROM locations ";
                MySqlCommand sqlcmd = new MySqlCommand(sqlq, sqlconn);
                sqlconn.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter(sqlcmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                sqlconn.Close();



                dt.Columns["location"].ColumnName = "Location";
                dt.Columns["Project"].ColumnName = "Project";



                GridView1.DataSource = dt;
                GridView1.DataBind();


                mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
                sqlconn = new MySqlConnection(mainconn);
                string sqlq1 = "SELECT project FROM projects";
                MySqlCommand sqlcmd1 = new MySqlCommand(sqlq1, sqlconn);
                sqlconn.Open();
                MySqlDataAdapter sda1 = new MySqlDataAdapter(sqlcmd1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                projectDDL.DataSource = dt1;
                projectDDL.DataValueField = "project";
                projectDDL.DataBind();
                sqlconn.Close();
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            if (!thereis()) {
                add();
                
            }
            else
            {
                Response.Write("<script>alert('Record Exist.');</script>");
            }
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            if (thereis()==true)
            {
                fill();

            }
            else
            {
                Response.Write("<script>alert('Record Does Not Exist.');</script>");
            }
        }
        void fill() {
         

                string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
                MySqlConnection sqlconn = new MySqlConnection(mainconn);
                string sqlq = "SELECT * FROM locations WHERE id = '" + TextBox1.Text.Trim() + "'";
                MySqlCommand sqlcmd = new MySqlCommand(sqlq, sqlconn);
                sqlconn.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter(sqlcmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count >= 1)
                {


                    foreach (DataRow row in dt.Rows)
                    {
                       
                  
                        TextBox2.Text = row["location"].ToString();
                   
                  
                    projectDDL.SelectedValue = row["project"].ToString();


                }
                }
                sqlconn.Close();
          

        }
        void add()
        {


            string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            MySqlConnection sqlconn = new MySqlConnection(mainconn);
          
            string sqlq = "INSERT INTO locations(location,project) VALUES('" + TextBox2.Text.Trim() + "','" + projectDDL.SelectedItem + "')";

            MySqlCommand sqlcmd = new MySqlCommand(sqlq, sqlconn);
            sqlconn.Open();
            sqlcmd.ExecuteNonQuery();


            sqlconn.Close();
            refresh();
        }
        void refresh()
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            MySqlConnection sqlconn = new MySqlConnection(mainconn);
            string sqlq = "SELECT * FROM locations ";
            MySqlCommand sqlcmd = new MySqlCommand(sqlq, sqlconn);
            sqlconn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            sqlconn.Close();


            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        void up() {
            string mainconn1 = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            MySqlConnection sqlconn1 = new MySqlConnection(mainconn1);
     
            string sqlq1 = "UPDATE locations SET location = '" + TextBox2.Text.Trim() + "', project='" + projectDDL.SelectedItem+ "'WHERE id ='"+ TextBox1.Text.Trim() + "'";
            MySqlCommand sqlcmd1 = new MySqlCommand(sqlq1, sqlconn1);
            sqlconn1.Open();
            sqlcmd1.ExecuteNonQuery();
            sqlconn1.Close();
            refresh();
        }
        void del() {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            MySqlConnection sqlconn = new MySqlConnection(mainconn);


            string sqlq = "DELETE FROM locations WHERE id ='" + TextBox1.Text.Trim() + "'";

            MySqlCommand sqlcmd = new MySqlCommand(sqlq, sqlconn);
            sqlconn.Open();
            sqlcmd.ExecuteNonQuery();
           


            sqlconn.Close();
            refresh();

        }
        bool thereis()
        {
            bool thereis = false;
            string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            MySqlConnection sqlconn = new MySqlConnection(mainconn);
            string sqlq = "SELECT * FROM locations WHERE id = '" + TextBox1.Text.Trim() + "'";
            MySqlCommand sqlcmd = new MySqlCommand(sqlq, sqlconn);
            sqlconn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                thereis = true;
            }
            else { thereis = false; }
            return thereis;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (thereis())
            {

                up();
            }
            else {
                Response.Write("<script>alert('Record Does Not Exist.');</script>");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (thereis()) {

                del();
            }
            else
            {
                Response.Write("<script>alert('Record Does Not Exist.');</script>");
            }
        }
    }
}