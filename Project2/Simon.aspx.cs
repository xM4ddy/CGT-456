using System;
using System.Timers;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Simon {
    public partial class Simon : Page {
        protected void Page_Load(object sender, EventArgs e) { // called on page load and postbacks
            if (Session["inited"] == null) {                   // prevent re-initing on postback
                HideButtons(true);                             // hide play buttons and show start button
                scoreCount.Visible = false;                    // hide score if they havent played yet
                scoreCount.InnerText = 0.ToString();           // reset score
                int[] moves = new int[100];                    // create array of 100 ints for the moves
                Random rnd = new Random();                     // init rand

                for (int i = 0; i < moves.Length; i++) { // gen 100 new moves and put in array
                    moves[i] = rnd.Next(0, 4);           // rand num 0 through 3 for a move
                }

                Session["inited"] = true;   // if initialization has happened
                Session["moves"] = moves;   // array of 100 moves (Highest Score Ever Is 84!)
                Session["steps"] = 0;       // number of steps that have been shown for the level
                Session["inputSteps"] = 0;  // number of input steps for the user for the level
                Session["level"] = 1;       // current level / how many steps for the current level
                Session["showing"] = false; // if the steps are being show to the user currently
            }
        } // end Page_Load()

        protected void Tick(object sender, EventArgs e) { // runs every 1s when showing moves
            if (Convert.ToBoolean(Session["showing"])) {  // if the game is showing moves
                button_red.Attributes.Remove("class");    // reset button class
                button_green.Attributes.Remove("class");  // reset button class
                button_yellow.Attributes.Remove("class"); // reset button class
                button_blue.Attributes.Remove("class");   // reset button class

                int[] moves = Session["moves"] as int[];  // get the array of moves as ints

                if (Convert.ToInt32(Session["steps"]) < Convert.ToInt32(Session["level"])) { // if num steps less than level
                    switch (moves[Convert.ToInt32(Session["steps"])]) {       // add the class to the button to show step
                        case 0:
                            button_green.Attributes.Add("class", "active");   // add "active" class to button
                            break;
                        case 1:
                            button_red.Attributes.Add("class", "active");     // add "active" class to button
                            break;
                        case 2:
                            button_yellow.Attributes.Add("class", "active");  // add "active" class to button
                            break;
                        case 3:
                            button_blue.Attributes.Add("class", "active");    // add "active" class to button
                            break;
                    }
                    Session["steps"] = Convert.ToInt32(Session["steps"]) + 1; // ittr num of shown steps
                }
                else { // all the steps have been shown
                    button_green.Attributes.Add("class", "playerButton");  // re add class to make css interactive
                    button_red.Attributes.Add("class", "playerButton");    // re add class to make css interactive
                    button_yellow.Attributes.Add("class", "playerButton"); // re add class to make css interactive
                    button_blue.Attributes.Add("class", "playerButton");   // re add class to make css interactive
                    Session["showing"] = false;                            // set showing to false
                    Timer.Interval = 999999999;                            // high interval so css doesn't flicker
                }
            }
        }  // end Tick()

        protected void Start(object sender, EventArgs e) { // starts or resets game
            Timer.Interval = 600;     // set interval to 1s
            Session["inited"] = null;  // let init run again
            Page_Load(null, null);     // call pageload to force init
            HideButtons(false);        // show play buttons and hide start button
            scoreCount.Visible = true; // show score count again
            Session["showing"] = true; // showing steps now
        } // end Start()

        protected void HideButtons(Boolean hide) { // hide and show buttons
            button_blue.Visible = button_red.Visible = button_yellow.Visible = button_green.Visible = !hide; // play buttons
            StartButton.Visible = hide;                                                                      // start button
        } // end HideButtons()

        protected void BtnClicked(object sender, EventArgs e) {
            if (Convert.ToBoolean(Session["showing"]) == false) { // if the game isnt showing the user moves i.e. game is playable
                int[] moves = Session["moves"] as int[]; // get moves array
                Button clickedButton = (Button)sender;   // get clicked button

                if (Convert.ToInt32(clickedButton.Text) == moves[Convert.ToInt32(Session["inputSteps"])]) { // check if the button was the right move
                    Session["inputSteps"] = Convert.ToInt32(Session["inputSteps"]) + 1; // if the move was right add one to get ready to check next move
                }
                else { // else the user clicked the wrong button and the game should end
                    scoreCount.InnerHtml = "GAME OVER<br />SCORE: " + Session["level"].ToString(); // show final score
                    HideButtons(true);                                                             // hide play buttons and show start button
                }
                if (Convert.ToInt32(Session["inputSteps"]) == Convert.ToInt32(Session["level"])) { // if the user has done all steps for the level correctly
                    Session["steps"] = 0;                                     // set steps back to 0 for current level
                    Session["inputSteps"] = 0;                                // set number of inputed steps back to 0
                    Session["level"] = Convert.ToInt32(Session["level"]) + 1; // add one to the level
                    scoreCount.InnerText = Session["level"].ToString();       // update score
                    Session["showing"] = true;                                // go back to the game showing moves
                    Timer.Interval = 600;                                    // set times interval back to the normal for showing moves
                }
            }
        } // end BtnClicked()
    }
}
