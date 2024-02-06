using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assign03
{
    public partial class calc2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void StoreDisplay(string fromDisplay)
        {
            Session["operand"] = fromDisplay.ToString();
        }

        protected void BtnClicked(object sender, EventArgs e)
        {
            System.Web.UI.WebControls.Button myBtn;
            myBtn = (System.Web.UI.WebControls.Button)sender;

            display.Text = myBtn.Text.ToString();
            StoreDisplay(myBtn.Text.ToString());
        }

        protected void OperationClicked(object sender, EventArgs e)
        {
            Session["operand1"] = Session["operand"];

            System.Web.UI.WebControls.Button myBtn;
            myBtn = (System.Web.UI.WebControls.Button)sender;

            Session["operation"] = myBtn.Text.ToString();
        }

        protected void BtnEqual_Click(object sender, EventArgs e)
        {
            Session["operand2"] = Session["operand"];

            if (Session["operation"].ToString() == "+")
            {
                display.Text = (Convert.ToInt32(Session["operand1"].ToString()) + Convert.ToInt32(Session["operand2"].ToString())).ToString();
            }
            else if (Session["operation"].ToString() == "-")
            {
                display.Text = (Convert.ToInt32(Session["operand1"].ToString()) - Convert.ToInt32(Session["operand2"].ToString())).ToString();
            }
            else if (Session["operation"].ToString() == "*")
            {
                display.Text = (Convert.ToInt32(Session["operand1"].ToString()) * Convert.ToInt32(Session["operand2"].ToString())).ToString();
            }
            else if (Session["operation"].ToString() == "/")
            {
                display.Text = (Convert.ToInt32(Session["operand1"].ToString()) / Convert.ToInt32(Session["operand2"].ToString())).ToString();
            }
        }

        protected void BtnClear_Click(object sender, EventArgs e)
        {
            display.Text = "";
            Session["operation"] = "";
            Session["operand1"] = "";
            Session["operand2"] = "";
            Session["displayedValue"] = "";
        }
    }
}