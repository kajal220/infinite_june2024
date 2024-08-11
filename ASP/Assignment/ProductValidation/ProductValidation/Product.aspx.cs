using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductValidation
{
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
            }
        }
        protected void ddlCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = ddlCars.SelectedItem;
            if (selectedItem != null && !string.IsNullOrEmpty(selectedItem.Value))
            {
                imgCar.ImageUrl = selectedItem.Attributes["C:\\Batch_june2024\\ASP\\Tesla.jpg"];
                imgCar.Visible = true;
                lblPrice.Text = $"Price: ${selectedItem.Attributes["79999"]}";
            }
            
        }

        protected void btnGetPrice_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string familyName = txtFamilyName.Text.Trim();
            string address = txtAddress.Text.Trim();
            string city = txtCity.Text.Trim();
            string zipCode = txtZipCode.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();

            string errors = ValidateFields(name, familyName, address, city, zipCode, phone, email);

            lblValidationErrors.Text = errors;

            if (string.IsNullOrEmpty(errors))
            {
                lblValidationErrors.Text = ""; // Clear validation errors
                ddlCars_SelectedIndexChanged(sender, e); // Update image and price
            }
        }

        private string ValidateFields(string name, string familyName, string address, string city, string zipCode, string phone, string email)
        {
            string errors = "";

            // Validate that name and family name are different
            if (name.Equals(familyName, StringComparison.OrdinalIgnoreCase))
            {
                errors += "Name cannot be the same as Family Name.<br/>";
            }

            // Validate address
            if (address.Length < 2)
            {
                errors += "Address must be at least 2 letters long.<br/>";
            }

            // Validate city
            if (city.Length < 2)
            {
                errors += "City must be at least 2 letters long.<br/>";
            }

            // Validate zip-code
            if (zipCode.Length != 5 || !IsDigitsOnly(zipCode))
            {
                errors += "Zip-Code must be exactly 5 digits.<br/>";
            }

            // Validate phone number
            if (!IsValidPhoneNumber(phone))
            {
                errors += "Phone number must be in the format XX-XXXXXXX or XXX-XXXXXXX.<br/>";
            }

            // Validate email
            if (!IsValidEmail(email))
            {
                errors += "Email must be valid.<br/>";
            }

            return errors;
        }

        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsValidPhoneNumber(string phone)
        {
            // Validate phone number formats: XX-XXXXXXX or XXX-XXXXXXX
            if ((phone.Length == 10 && phone[2] == '-' && IsDigitsOnly(phone.Substring(0, 2)) && IsDigitsOnly(phone.Substring(3))) ||
                (phone.Length == 12 && phone[3] == '-' && IsDigitsOnly(phone.Substring(0, 3)) && IsDigitsOnly(phone.Substring(4))))
            {
                return true;
            }
            return false;
        }

        private bool IsValidEmail(string email)
        {
            // Simple email validation: Check if it contains "@" and "."
            int atIndex = email.IndexOf('@');
            int dotIndex = email.LastIndexOf('.');

            return atIndex > 0 && dotIndex > atIndex + 1 && dotIndex < email.Length - 1;
        }
    }
}