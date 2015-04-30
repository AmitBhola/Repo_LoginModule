using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using EncryptionAndEncodingHelper;

namespace LoginModule
{
    public partial class LoginPage : System.Web.UI.Page
    {
        private EncryptionAndEncoding eeh = new EncryptionAndEncoding("0123456789ABCDEF", "ABCDEFGH");
        private ServiceReference1.Service1Client sfc = new ServiceReference1.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btb_login_Click(object sender, EventArgs e)
        {
            string data = String.Format("{0}:{1}",txt_username.Text,txt_password.Text);
            string sentData = eeh.EncryptAndEncodeText(data);
            //lbl_EncDataSent.Text = sentData;
            ServiceReference1.CompositeType c = new ServiceReference1.CompositeType();
            c.BoolValue = false;
            c.EncryptedAndEncodedText = sentData;
            c =  sfc.GetDataUsingDataContract(c);
           

            if (c.BoolValue)
            {
                //navigate to next page
                lbl_error.Text = "The username password combination is valid";
                // Add Values to the session
                Session.Add("UserName",c.UserName);
                Session.Add("UserNickName",c.UserNickName);
                Session.Add("Address",c.UserAddr);
                Session.Add("Validated",true);

                //Move to the Landing Page
                Response.Redirect("~/LandingPage.aspx");
               
            }
            else{
                lbl_error.Text = "The username password combination is not valid";
            }

            
        
        }
    }
}