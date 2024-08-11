﻿using System;
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
                string name = txtName.Text;
                string familyName = txtFamilyName.Text;
                string address = txtAddress.Text;
                string city = txtCity.Text;
                string zipCode = txtZipCode.Text;
                string phone = txtPhone.Text;
                string email = txtEmail.Text;

                Response.Write($"<p>Details submitted:<br>Name: {name}<br>Family Name: {familyName}<br>Address: {address}<br>City: {city}<br>Zip Code: {zipCode}<br>Phone: {phone}<br>Email: {email}</p>");
            }
           
        }
    }
   
}
