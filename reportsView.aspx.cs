using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;
using Excel = Microsoft.Office.Interop.Excel;


namespace foody
{
    public partial class reportsView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                empNameDDL.Enabled = false;
                date.Enabled = false;
                superNameDDL.Enabled = false;
                projectDDL.Enabled = false;
                locationsDDL.Enabled = false;

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

                string sqlql = "SELECT location FROM locations";
                sqlcmd = new MySqlCommand(sqlql, sqlconn);
                sqlconn.Open();
                sda = new MySqlDataAdapter(sqlcmd);
                dt = new DataTable();
                sda.Fill(dt);
                locationsDDL.DataSource = dt;
                locationsDDL.DataValueField = "location";

                locationsDDL.DataBind();
                sqlconn.Close();

                string sqlqs = "SELECT name FROM logininfo";
                sqlcmd = new MySqlCommand(sqlqs, sqlconn);
                sqlconn.Open();
                sda = new MySqlDataAdapter(sqlcmd);
                dt = new DataTable();
                sda.Fill(dt);
                superNameDDL.DataSource = dt;
                superNameDDL.DataValueField = "name";

                superNameDDL.DataBind();
                sqlconn.Close();

                string sqlqe = "SELECT name FROM employees";
                sqlcmd = new MySqlCommand(sqlqe, sqlconn);
                sqlconn.Open();
                sda = new MySqlDataAdapter(sqlcmd);
                dt = new DataTable();
                sda.Fill(dt);
                empNameDDL.DataSource = dt;
                empNameDDL.DataValueField = "name";

                empNameDDL.DataBind();
                sqlconn.Close();



            }



        }
        protected void OnOffDate(object sender, EventArgs e) {

            date.Enabled = DateChB.Checked;


        }  
        protected void OnOffFromToDate(object sender, EventArgs e) {

            dateFrom.Enabled = FromToChB.Checked;
            dateTo.Enabled = FromToChB.Checked;


        }
        protected void OnOffPRO(object sender, EventArgs e)
        {

            projectDDL.Enabled = projectCHB.Checked;


        }
        protected void OnOffLOC(object sender, EventArgs e)
        {

            locationsDDL.Enabled = locationsCHB.Checked;


        }
        protected void OnOffSUPER(object sender, EventArgs e)
        {

            superNameDDL.Enabled = superNameCHB.Checked;


        }
        protected void OnOffEMP(object sender, EventArgs e)
        {

            empNameDDL.Enabled = empNameCHB.Checked;


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






        string getFilter()
        {
            string dateSt = "";
            string projectSt = "";
            string locationSt = "";
            string superSt = "";
            string empSt = "";
            string FromTo = "";
            if (DateChB.Checked)
            {
                dateSt = " AND date = '" + date.Text.Trim() + "'";
            }
            if (projectCHB.Checked)
            {
                projectSt = " AND project ='" + projectDDL.SelectedItem + "'";
            }
            if (locationsCHB.Checked)
            {
                locationSt = " AND location ='" + locationsDDL.SelectedItem + "'";
            }
            if (superNameCHB.Checked)
            {
                superSt = " AND super_name	='" + superNameDDL.SelectedItem + "'";
            }
            if (empNameCHB.Checked)
            {
                empSt = " AND emp_name = '" + empNameDDL.SelectedItem + "'";
            }  
            if (FromToChB.Checked)
            {
             //   "AND date between '"+dateFrom.Text.Trim()+"' and '"+ dateTo.Text.Trim() + "'order by date desc"
                empSt = "AND date between '" + dateFrom.Text.Trim() + "' and '" + dateTo.Text.Trim() + "'";
            }

            string Filter = dateSt + projectSt + locationSt + superSt + empSt;

            return Filter;
        }
       

        protected void Button1_Click(object sender, EventArgs e)
        {
           

            string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            MySqlConnection sqlconn = new MySqlConnection(mainconn);




            string sqlq = "SELECT * FROM reports WHERE id LIKE '%' " + getFilter() + "";
           
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

     
        protected void Export_Click(object sender, EventArgs e)
        {
      
            string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            MySqlConnection sqlconn = new MySqlConnection(mainconn);
            string sqlq = "SELECT * FROM reports WHERE id LIKE '%' " + getFilter() + ""; ;
            MySqlCommand sqlcmd = new MySqlCommand(sqlq, sqlconn);
            sqlconn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter(sqlcmd);

            DataTable dt = new DataTable();
            DataSet ds = new DataSet();

            sda.Fill(ds);

            
            sqlconn.Close();
            int x = 0;
            DataTable dtCloned = ds.Tables[0].Clone();
            dtCloned.Columns[2].DataType = typeof(string);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                dtCloned.ImportRow(row);
            }
            DataSet dss = new DataSet();
            ds.Tables.RemoveAt(0);
            ds.Tables.Add(dtCloned);

            int fullcost = 0;

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string value5 = row[5].ToString();
                string value6 = row[6].ToString();

                if (row[5].ToString().Length < 1)
                {
                    ds.Tables[0].Rows[x][5] = "%";
                }
                if (row[6].ToString().Length < 1)
                {
                    ds.Tables[0].Rows[x][6] = "%";
                }

                fullcost += Int16.Parse(ds.Tables[0].Rows[x][7]+"");

                x++;
                    }
            Response.Write("<script>alert('The Excel File Saved at Downloads - " + fullcost + " ');</script>");

            


            DateTime now = DateTime.Now;
            string hourMinute = DateTime.Now.ToString("HH-mm-ss");

            ExcelLibrary.DataSetHelper.CreateWorkbook("C:\\Users\\"+ Environment.UserName + "\\Downloads\\ Reprts " + hourMinute + ".xlsx", ds);
            Response.Write("<script>alert('The Excel File Saved at Downloads - "+ hourMinute + " ');</script>");

            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }
    }
}