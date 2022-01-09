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
    public partial class reports : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            MySqlConnection sqlconn = new MySqlConnection(mainconn);
            string sqlq = "SELECT * FROM reports ";
            MySqlCommand sqlcmd = new MySqlCommand(sqlq, sqlconn);
            sqlconn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            sqlconn.Close();




            dt.Columns["location"].ColumnName = "Location";
            dt.Columns["date"].ColumnName = "Date";
            dt.Columns["super_name"].ColumnName = "Super Name";
            dt.Columns["emp_name"].ColumnName = "Emp Name";
            dt.Columns["check_in"].ColumnName = "CheckI";
            dt.Columns["check_out"].ColumnName = "CheckO";
            dt.Columns["d_w"].ColumnName = "Wage";
            dt.Columns["long_latta"].ColumnName = "long\\latt";
            dt.Columns["long_latta_check_out"].ColumnName = "long\\latt ChOut";
            dt.Columns["project"].ColumnName = "Project";
            dt.Columns["position"].ColumnName = "Position";
            dt.Columns["car"].ColumnName = "Car";

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        void fill()
        {


            string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            MySqlConnection sqlconn = new MySqlConnection(mainconn);
            string sqlq = "SELECT * FROM reports WHERE id = '" + TextID.Text.Trim() + "'";
            MySqlCommand sqlcmd = new MySqlCommand(sqlq, sqlconn);
            sqlconn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count >= 1)
            {


                foreach (DataRow row in dt.Rows)
                {


                    TextLocation.Text = row["location"].ToString();
                    TextProject.Text = row["project"].ToString();
                    TextSuperName.Text = row["super_name"].ToString();
                    TextEmpName.Text = row["emp_name"].ToString();
                    TextDate.Text = row["date"].ToString();
                    TextChIn.Text = row["check_in"].ToString();
                    TextChOut.Text = row["check_out"].ToString();
                    TextDW.Text = row["d_w"].ToString();
                    TextLongLat.Text = row["long_latta"].ToString();






                }
            }
            sqlconn.Close();


        }

      

        void refresh()
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            MySqlConnection sqlconn = new MySqlConnection(mainconn);
            string sqlq = "SELECT * FROM reports ";
            MySqlCommand sqlcmd = new MySqlCommand(sqlq, sqlconn);
            sqlconn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            sqlconn.Close();
            dt.Columns["location"].ColumnName = "Location";
            dt.Columns["date"].ColumnName = "Date";
            dt.Columns["super_name"].ColumnName = "Super Name";
            dt.Columns["emp_name"].ColumnName = "Emp Name";
            dt.Columns["check_in"].ColumnName = "CheckI";
            dt.Columns["check_out"].ColumnName = "CheckO";
            dt.Columns["d_w"].ColumnName = "Wage";
            dt.Columns["long_latta"].ColumnName = "long\\latt";
            dt.Columns["long_latta_check_out"].ColumnName = "long\\latt ChOut";
            dt.Columns["project"].ColumnName = "Project";
            dt.Columns["position"].ColumnName = "Position";
            dt.Columns["car"].ColumnName = "Car";
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        void up()
        {
            string mainconn1 = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            MySqlConnection sqlconn1 = new MySqlConnection(mainconn1);
        
            string sqlq1 = "UPDATE reports SET  location= '" + TextLocation.Text.Trim() + "', project='" + TextProject.Text.Trim() + "', super_name = '" + TextSuperName.Text.Trim() + "', emp_name='" + TextEmpName.Text.Trim() + "',d_w='" + TextDW.Text.Trim() + "' WHERE id ='" + TextID.Text.Trim() + "'";
            MySqlCommand sqlcmd1 = new MySqlCommand(sqlq1, sqlconn1);
            sqlconn1.Open();
            sqlcmd1.ExecuteNonQuery();
            sqlconn1.Close();
            refresh();
        }
        void del()
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            MySqlConnection sqlconn = new MySqlConnection(mainconn);


            string sqlq = "DELETE FROM reports WHERE id ='" + TextID.Text.Trim() + "'";

            MySqlCommand sqlcmd = new MySqlCommand(sqlq, sqlconn);
            sqlconn.Open();
            sqlcmd.ExecuteNonQuery();
            //Response.Write("<script>alert('The Deleting was Successful.');</script>");


            sqlconn.Close();
            refresh();

        }

        bool thereis()
        {
            bool thereis = false;
            string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            MySqlConnection sqlconn = new MySqlConnection(mainconn);
            string sqlq = "SELECT * FROM reports WHERE id = '" + TextID.Text.Trim() + "'";
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

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

       

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (thereis())
            {

                up();
            }
            else
            {
                Response.Write("<script>alert('Record Does Not Exist.');</script>");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (thereis())
            {

                del();
            }
            else
            {
                Response.Write("<script>alert('Record Does Not Exist.');</script>");
            }
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            if (thereis() == true)
            {
                fill();

            }
            else
            {
                Response.Write("<script>alert('Record Does Not Exist.');</script>");
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }
    }
}