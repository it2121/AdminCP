using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace foody
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
         


            string cTheFile = HttpContext.Current.Request.Path;

            if (Session["username"] == null)
            {
                 if (!cTheFile.EndsWith("adminlogin.aspx")) {
                    Response.Redirect("adminlogin.aspx", true);
                }
                if (!cTheFile.EndsWith(""))
                {
                    Response.Redirect("adminlogin.aspx", true);
                }

                // 

                //Response.Redirect("adminlogin.aspx");

                LinkButton4.Visible = false;
                LinkButton1.Visible = true;
                projectsB.Visible = false;
                locationsB.Visible = false;
                LinkButton3.Visible = false;
                LinkButton7.Visible = false;
                reportsViewB.Visible = false;
                LinkButton2.Visible = false;
              
                LinkButton4.Visible = false;


            }
            else {
                LinkButton4.Visible = true;
                LinkButton1.Visible = false;
                projectsB.Visible = true;
                locationsB.Visible = true;
                LinkButton3.Visible = true;
                LinkButton7.Visible = true;
                LinkButton2.Visible = true;
                reportsViewB.Visible = true;

                LinkButton4.Visible = true;

            }


        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");
        }

        protected void projectsB_Click(object sender, EventArgs e)
        {
            Response.Redirect("projects.aspx");
        }
        protected void locationsB_Click(object sender, EventArgs e)
        {
            Response.Redirect("locations.aspx");
        }
        protected void LinkButton7_Click(object sender, EventArgs e)
        {

            Response.Redirect("employees.aspx");

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("logininfomanager.aspx");
        }  protected void reportsViewB_Click(object sender, EventArgs e)
        {
            Response.Redirect("reportsView.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("reports.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Session["username"] = null;
            Session["name"] = null;
            Response.Redirect("adminlogin.aspx");
        }

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");

        }
        protected override void OnPreRender(EventArgs e)
        {

            base.OnPreRender(e);

            this.Controls.Add(new LiteralControl(

                String.Format("<meta http-equiv='refresh' content='{0};url={1}'>",

                60 * 60, "adminlogin.aspx")));

        }
    }
}