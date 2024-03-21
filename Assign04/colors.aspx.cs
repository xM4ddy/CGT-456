using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assign04
{
    public partial class colors : Page
    {
        bool firstValueChanged; // bool T/F to display bitwise stuff

        protected void Page_Load(object sender, EventArgs e)
        {
            // Page_Load runs each postback (round trip to server)
            if (!Page.IsPostBack)
            {
                // initial page load - run once on initialization
                // If it is a postback, dont execute below
                firstValueChanged = false;     // no changed values
                bit1.Enabled = false;          // disable bit1
                bit2.Enabled = false;          // disable bit2
                bit3.Enabled = false;          // disable bit3
                bitwiseResult.Enabled = false; // disable textbox
                bit1.Visible = false;          // don't display bit1
                bit2.Visible = false;          // don't display bit2
                bit3.Visible = false;          // don't display bit3 
                bitEqual.Visible = false;      // hide equal sign
                bitwiseResult.Visible = false; // don't display textbox
            }
        } // end Page_Load function

        public void valueChanged(object sender, EventArgs e)
        {
            // declare vars for bit values 
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            int num6 = 0;
            int num7 = 0;
            int num8 = 0;

            string color = "";

            firstValueChanged = true; // bool T/F to display bitwise stuff

            DropDownList dl;
            dl = (DropDownList)sender;

            // check which dropdown was changed
            if (dl.ID.Contains("red"))
            {
                // red dropdown was changed
                num8 = Convert.ToInt16(red8.SelectedValue);
                num7 = Convert.ToInt16(red7.SelectedValue);
                num6 = Convert.ToInt16(red6.SelectedValue);
                num5 = Convert.ToInt16(red5.SelectedValue);
                num4 = Convert.ToInt16(red4.SelectedValue);
                num3 = Convert.ToInt16(red3.SelectedValue);
                num2 = Convert.ToInt16(red2.SelectedValue);
                num1 = Convert.ToInt16(red1.SelectedValue);

                // set color pram for next function
                color = "red";
            }
            else if (dl.ID.Contains("blue"))
            {
                // blue dropdown was changed
                num8 = Convert.ToInt16(blue8.SelectedValue);
                num7 = Convert.ToInt16(blue7.SelectedValue);
                num6 = Convert.ToInt16(blue6.SelectedValue);
                num5 = Convert.ToInt16(blue5.SelectedValue);
                num4 = Convert.ToInt16(blue4.SelectedValue);
                num3 = Convert.ToInt16(blue3.SelectedValue);
                num2 = Convert.ToInt16(blue2.SelectedValue);
                num1 = Convert.ToInt16(blue1.SelectedValue);

                // set color pram for next function
                color = "blue";
            }
            else if (dl.ID.Contains("green"))
            {
                // green dropdown was changed
                num8 = Convert.ToInt16(green8.SelectedValue);
                num7 = Convert.ToInt16(green7.SelectedValue);
                num6 = Convert.ToInt16(green6.SelectedValue);
                num5 = Convert.ToInt16(green5.SelectedValue);
                num4 = Convert.ToInt16(green4.SelectedValue);
                num3 = Convert.ToInt16(green3.SelectedValue);
                num2 = Convert.ToInt16(green2.SelectedValue);
                num1 = Convert.ToInt16(green1.SelectedValue);

                // set color pram for next function
                color = "green";
            }

            // calc decimal value
            calculateDecimal(color, num1, num2, num3, num4, num5, num6, num7, num8);

            // change bg color
            changeColor();

            if (firstValueChanged)
            {
                // first DropDownList was changed, show bitwise controls
                bit1.Enabled = true;
                bit2.Enabled = true;
                bit3.Enabled = true;
                bit1.Visible = true;
                bit2.Visible = true;
                bit3.Visible = true;
                bitEqual.Visible = true;
                bitwiseResult.Visible = true;

                bitwise(sender, e); // calc bitwise value after change

            }
        } // end valueChanged function

        //function to calc decimal value
        public void calculateDecimal(string color, int b1, int b2, int b3, int b4, int b5, int b6, int b7, int b8)
        {
            // declare vars and set equal to decimal value of binary numbers
            int total = b1 + (b2 * 2) + (b3 * 4) + (b4 * 8) + (b5 * 16) + (b6 * 32) + (b7 * 64) + (b8 * 128);

            // convert total into hex using .ToString("X2") (hex padding to produce a 2 digit number) and print total to box
            // https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings#XFormatString
            if (color == "red")
            {
                rHexText.Text = total.ToString("X2");
                rDecText.Text = total.ToString("D2");
            }
            else if (color == "green")
            {
                gHexText.Text = total.ToString("X2");
                gDecText.Text = total.ToString("D2");
            }
            else if (color == "blue")
            {
                bHexText.Text = total.ToString("X2");
                bDecText.Text = total.ToString();
            }
        } //end calculateDecimal

        public void changeColor()
        {
            // declare vars 
            string rcolor, bcolor, gcolor;

            // set colors to zero if not entered (uses ternary statements)
            // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator
            // red
            rcolor = rHexText.Text.Equals("") ? "00" : rHexText.Text.ToString();

            // green
            gcolor = gHexText.Text.Equals("") ? "00" : gHexText.Text.ToString();

            // blue
            bcolor = bHexText.Text.Equals("") ? "00" : bHexText.Text.ToString();

            // change color of box bg
            bgColor.BackColor = System.Drawing.ColorTranslator.FromHtml("#" + rcolor + gcolor + bcolor);
        } // end changeColor 

        // bitwise functions 
        public void bitwise(object sender, EventArgs e)
        {
            // only calc bitwise value if operands and an operator have been chosen
            if (!bit1.SelectedValue.Equals("--") && !bit2.SelectedValue.Equals("--") && !bit3.SelectedValue.Equals("--"))
            {
                int num1 = 0;
                int num2 = 0;
                int result = 0;

                // find value of first number
                if (bit1.SelectedValue.Equals("R"))
                {
                    num1 = Convert.ToByte(rDecText.Text);
                }
                if (bit1.SelectedValue.Equals("G"))
                {
                    num1 = Convert.ToByte(gDecText.Text);
                }
                if (bit1.SelectedValue.Equals("B"))
                {
                    num1 = Convert.ToByte(bDecText.Text);
                }

                // find value of second number
                if (bit3.SelectedValue.Equals("R"))
                {
                    num2 = Convert.ToByte(rDecText.Text);
                }
                if (bit3.SelectedValue.Equals("G"))
                {
                    num2 = Convert.ToByte(gDecText.Text);
                }
                if (bit3.SelectedValue.Equals("B"))
                {
                    num2 = Convert.ToByte(bDecText.Text);
                }

                // do calcs
                if (bit2.SelectedValue.Equals("&"))
                {
                    result = num1 & num2;
                }
                if (bit2.SelectedValue.Equals("|"))
                {
                    result = num1 | num2;
                }
                if (bit2.SelectedValue.Equals("^"))
                {
                    result = num1 ^ num2;
                }

                // return result (uses string formatting and padding)
                // https://learn.microsoft.com/en-us/dotnet/api/system.convert.tostring?view=net-5.0#system-convert-tostring(system-int64-system-int32)
                // https://learn.microsoft.com/en-us/dotnet/api/system.string.padleft
                bitwiseResult.Text = Convert.ToString(result, 2).PadLeft(8, '0');
            }
        } // end bitwise function
    }
}
