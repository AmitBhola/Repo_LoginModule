using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginModule
{
    public partial class LandingPage : System.Web.UI.Page
    {
        private ServiceReference1.Service1Client sfc = new ServiceReference1.Service1Client();

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
        }

        protected void btn_ser1_Click(object sender, EventArgs e)
        {
            //Call the function to validate the policies for the user
            validatePolicies("app1");
            // Redirect the user to the Service 1 Landing page with the appropriate policies
        }

        protected void btn_ser2_Click(object sender, EventArgs e)
        {
            //Call the function to validate the policies for the user
            validatePolicies("app2");
            // Redirect the user to the Service 2 Landing page with the appropriate policies
        }

        protected void btn_ser3_Click(object sender, EventArgs e)
        {
            //Call the function to validate the policies for the user
            validatePolicies("app3");
            // Redirect the user to the Service 3 Landing page with the appropriate policies
        }

        private void validatePolicies(string appname)
        {
            ServiceReference1.PolicyType p = new ServiceReference1.PolicyType();
            p.BoolValue = false;
            p.Appname = appname;
            p.Username = Session["UserName"].ToString();
            p = sfc.GetPolicyUsingDataContract(p);

            if (p.BoolValue)
            {
                // valid
                //Add policy values to session
                Session.Add("PolicyName", p.PolicyName);
                Session.Add("PolicyPrivilages", p.Privilages);
                Session.Add("PolicyStart", p.StartDate);
                Session.Add("PolicyEnd", p.EndDate);

                switch (appname)
                {
                    case "app1": Response.Redirect("~/Service1.aspx"); break;
                    case "app2": Response.Redirect("~/Service2.aspx"); break;
                    case "app3": Response.Redirect("~/Service3.aspx"); break;
                    default: lbl_error1.Text = "Weird Error occurred"; break;

                }
            }
            else
            {
                switch (appname)
                {
                    case "app1": lbl_error1.Text = "Access Denied"; break;
                    case "app2": lbl_error2.Text = "Access Denied"; break;
                    case "app3": lbl_error3.Text = "Access Denied"; break;
                    default: lbl_error1.Text = "Wierd Error occurred"; break;

                }
            }
        }
    }
}