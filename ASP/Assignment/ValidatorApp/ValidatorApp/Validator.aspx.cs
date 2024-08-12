using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ValidatorApp
{
    public partial class Validator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
         protected void btnCheck_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                // If the page is valid, you can process the form data here
                string name = TextName.Text;
                string familyName = TextFName.Text;
                string address = TextAddr.Text;
                string city = TextCity.Text;
                string zipCode = TextZip.Text;
                string phone = TextPhone.Text;
                string email = TextEmail.Text;

                // For demonstration purposes, show a success message
                // You can replace this with logic to save data or perform other actions
                Response.Write("<script>alert('Validation successful!');</script>");
            }
            else
            {
                // If the page is not valid, the ValidationSummary will display the errors
                Response.Write("<script>alert('Validation failed! Please correct the errors and try again.');</script>");
            }
        }
    }
}
   

