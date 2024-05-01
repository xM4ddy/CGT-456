using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1
{
    public partial class WebForm1 : Page
    {
        static string ventStatus = "OFF";
        static string state = "idle";
        static int cookTime;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (cookTime >= 0) {
                display.Text = getTime();
            }
        }
        protected void tick(object sender, EventArgs e)
        {
            if (cookTime <= 1)
            {
                state = "idle";
            }

            if (state == "idle")
            {
                display.Text = getTime();
            }

            if (state == "cooking" && cookTime > 0)
            {
                cookTime--;
                display.Text = sToTime(cookTime).ToString();
            }
        }
        protected void changeVent()
        {
            switch (ventStatus)
            {
                case "OFF":
                    ventStatus = "LOW";
                    break;
                case "LOW":
                    ventStatus = "HIGH";
                    break;
                case "HIGH":
                    ventStatus = "OFF";
                    break;
            }
        }
        protected string getTime()
        {
            return DateTime.Now.ToString("h:mm");
        }
        protected string sToTime(int s)
        {
            TimeSpan t = TimeSpan.FromSeconds(s);

            return string.Format("{0:D2}:{1:D2}", t.Minutes, t.Seconds);
        }
        protected void foodBtn(object sender, EventArgs e)
        {
            Button myBtn = (Button)sender;

            display.Text = myBtn.Text.ToString();

            switch (myBtn.Text.ToString())
            {
                case "popcorn":
                    cookTime = 160;
                    break;
                case "potato":
                    cookTime = 300;
                    break;
                case "pizza":
                    cookTime = 60;
                    break;
                case "veggies":
                    cookTime = 360;
                    break;
            }
            state = "cooking";
        }

        protected void controlBtn(object sender, EventArgs e)
        {
            Button myBtn;
            myBtn = (Button)sender;

            if (myBtn.Text.ToString() == "vent")
            {
                changeVent();
                display.Text = ventStatus;
            }
            else if (myBtn.Text.ToString() == "stop")
            {
                display.Text = "STOP";
                cookTime = 0;
                state = "idle";
            }
            else if (myBtn.Text.ToString() == "add30s")
            {
                cookTime += 30;
                state = "cooking";
            }
        }
        protected void numpadClick(object sender, ImageMapEventArgs e)
        {
            int number = Convert.ToInt32(e.PostBackValue.Trim());
            
            if (state == "idle" && number < 7)
            {
                cookTime = number * 60;
                state = "cooking";
            }
        }
    }
}