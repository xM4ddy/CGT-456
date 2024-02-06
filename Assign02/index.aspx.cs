using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assign02
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            myName.Text = "Maddy O Wilcox";
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string strFirstName = fName.Text.ToString();
            string strLastName = lName.Text.ToString();
            string strCity = city.Text.ToString();
            string strZip = zip.Text.ToString();
            string strState = state.SelectedValue.ToString();

            results.Text = "First Name: " + strFirstName + "<br/>";
            results.Text += "Last Name: " + strLastName + "<br/>";
            results.Text += "City: " + strCity + "<br/>";
            results.Text += "State: " + strState + "<br/>";
            results.Text += "Zip: " + strZip + "<br/>";

            results.Style.Add("display", "block");
        }
    }
}