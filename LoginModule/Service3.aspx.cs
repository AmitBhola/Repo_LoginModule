using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginModule
{
    public partial class Service3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // Check if the page has been Validated
            try
            {
                if (!(bool)Session["Validated"])
                {
                    
                }
            }
            catch (Exception ex)
            {
                Response.Redirect("~/LoginPage.aspx");
            }
            lbl_address.Text = Session["Address"].ToString();
            lbl_end.Text = Session["PolicyEnd"].ToString();
            lbl_name.Text = Session["UserName"].ToString();
            lbl_policy.Text = Session["PolicyName"].ToString();
            lbl_privilage.Text = Session["PolicyPrivilages"].ToString();
            lbl_start.Text = Session["PolicyStart"].ToString();
        }
    }
}