using System.Windows.Controls;
using System.Windows;
using System;
using System.Windows.Media.Imaging;
using System.Threading;

namespace MemoryMatch
{
    public partial class Memory : Window
    {
        // declare and initialize variables
        // initialize 12 cards equal to 0; two will equal 1, two will equal 2, etc through 6
        private int card1 = 0, card2 = 0, card3 = 0, card4 = 0, card5 = 0, card6 = 0;
        private int card7 = 0, card8 = 0, card9 = 0, card10 = 0, card11 = 0, card12 = 0;
        private int randomNum  = 0;             // randomly assign cards to images
        private int numMatches = 0;             // counts number of matches when randomizing
        private int counter    = 0;             // used inside the randomization as a counter
        private int mistakes   = 0;             // counts wrong attempts
        private int numSelectedCards       = 0; // will be 0, 1, 2
        private int totalNumMatchesRemoved = 0; // will be 0, 1, 2, 3, 4, 5, 6
        private int firstSelectedCard      = 0; // set it equal to the match number 1-6
        // store the first selected image control and border control
        private Image firstSelectedImage = new Image();
        private Border firstSelectedBorder = new Border();
        public Memory()
        {
            InitializeComponent();

            // set imageLoc and hide 6 matches
            var uriSource = new Uri(@"cardPair.png", UriKind.Relative);
            pbMatch1.Source = new BitmapImage(uriSource);
            pbMatch2.Source = new BitmapImage(uriSource);
            pbMatch3.Source = new BitmapImage(uriSource);
            pbMatch4.Source = new BitmapImage(uriSource);
            pbMatch5.Source = new BitmapImage(uriSource);
            pbMatch6.Source = new BitmapImage(uriSource);

            // call playGame
            playGame();

        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            playGame();
        }

        private void playGame()
        {
            // re-initialize variables:
            card1 = 0;
            card2 = 0;
            card3 = 0;
            card4 = 0;
            card5 = 0;
            card6 = 0;
            card7 = 0;
            card8 = 0;
            card9 = 0;
            card10 = 0;
            card11 = 0;
            card12 = 0;
            randomNum  = 0;
            numMatches = 0;
            counter    = 0;
            mistakes   = 0;
            numSelectedCards       = 0;
            totalNumMatchesRemoved = 0; // will be 0,1,2, 3,4, 5,6
            firstSelectedCard      = 0;
            firstSelectedBorder    = new Border();
            firstSelectedImage     = new Image();

            // hide congrats! and play again
            lblCongrats.Visibility  = Visibility.Hidden;
            btnPlayAgain.Visibility = Visibility.Hidden;

            // show all 12 cards
            pbBorder1.Visibility  = Visibility.Visible;
            pbBorder2.Visibility  = Visibility.Visible;
            pbBorder3.Visibility  = Visibility.Visible;
            pbBorder4.Visibility  = Visibility.Visible;
            pbBorder5.Visibility  = Visibility.Visible;
            pbBorder6.Visibility  = Visibility.Visible;
            pbBorder7.Visibility  = Visibility.Visible;
            pbBorder8.Visibility  = Visibility.Visible;
            pbBorder9.Visibility  = Visibility.Visible;
            pbBorder10.Visibility = Visibility.Visible;
            pbBorder11.Visibility = Visibility.Visible;
            pbBorder12.Visibility = Visibility.Visible;

            // hide the 6 matches in the upper right
            pbMatch1.Visibility = Visibility.Hidden;
            pbMatch2.Visibility = Visibility.Hidden;
            pbMatch3.Visibility = Visibility.Hidden;
            pbMatch4.Visibility = Visibility.Hidden;
            pbMatch5.Visibility = Visibility.Hidden;
            pbMatch6.Visibility = Visibility.Hidden;

            // show the card backs
            var uriSource = new Uri(@"cardBack.png", UriKind.Relative);

            pictureBox1.Source  = new BitmapImage(uriSource);
            pictureBox2.Source  = new BitmapImage(uriSource);
            pictureBox3.Source  = new BitmapImage(uriSource);
            pictureBox4.Source  = new BitmapImage(uriSource);
            pictureBox5.Source  = new BitmapImage(uriSource);
            pictureBox6.Source  = new BitmapImage(uriSource);
            pictureBox7.Source  = new BitmapImage(uriSource);
            pictureBox8.Source  = new BitmapImage(uriSource);
            pictureBox9.Source  = new BitmapImage(uriSource);
            pictureBox10.Source = new BitmapImage(uriSource);
            pictureBox11.Source = new BitmapImage(uriSource);
            pictureBox12.Source = new BitmapImage(uriSource);

            // clear mistakes
            lblMistakes.Content = "";

            Random r = new Random();

            // have 12 cards, need 6 matches; loop until 6 matches.
            while (numMatches < 6)
            {
                randomNum = r.Next(1, 13);

                switch (randomNum)
                {
                    case 1:
                        if (card1 == 0)
                        {
                            card1 = numMatches + 1;
                            counter++;
                        }
                        break;
                    case 2:
                        if (card2 == 0)
                        {
                            card2 = numMatches + 1;
                            counter++;
                        }
                        break;
                    case 3:
                        if (card3 == 0)
                        {
                            card3 = numMatches + 1;
                            counter++;
                        }
                        break;
                    case 4:
                        if (card4 == 0)
                        {
                            card4 = numMatches + 1;
                            counter++;
                        }
                        break;
                    case 5:
                        if (card5 == 0)
                        {
                            card5 = numMatches + 1;
                            counter++;
                        }
                        break;
                    case 6:
                        if (card6 == 0)
                        {
                            card6 = numMatches + 1;
                            counter++;
                        }
                        break;
                    case 7:
                        if (card7 == 0)
                        {
                            card7 = numMatches + 1;
                            counter++;
                        }
                        break;
                    case 8:
                        if (card8 == 0)
                        {
                            card8 = numMatches + 1;
                            counter++;
                        }
                        break;
                    case 9:
                        if (card9 == 0)
                        {
                            card9 = numMatches + 1;
                            counter++;
                        }
                        break;
                    case 10:
                        if (card10 == 0)
                        {
                            card10 = numMatches + 1;
                            counter++;
                        }
                        break;
                    case 11:
                        if (card11 == 0)
                        {
                            card11 = numMatches + 1;
                            counter++;
                        }
                        break;
                    case 12:
                        if (card12 == 0)
                        {
                            card12 = numMatches + 1;
                            counter++;
                        }
                        break;
                }

                if (counter == 2)
                {
                    numMatches++;
                    counter = 0;
                }

            }
        }
        private void displayMatches()
        {
            // display number of matches
            for (int x = 1; x <= totalNumMatchesRemoved; x++)
            {
                switch (x)
                {
                    case 1:
                        pbMatch1.Visibility = Visibility.Visible;
                        break;
                    case 2:
                        pbMatch2.Visibility = Visibility.Visible;
                        break;
                    case 3:
                        pbMatch3.Visibility = Visibility.Visible;
                        break;
                    case 4:
                        pbMatch4.Visibility = Visibility.Visible;
                        break;
                    case 5:
                        pbMatch5.Visibility = Visibility.Visible;
                        break;
                    case 6:
                        pbMatch6.Visibility = Visibility.Visible;
                        break;
                }
            }
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            // create new Image control & surrounding border
            Image currentImage = new Image();
            Border currentBorder = new Border();

            // cast the sender to image control
            currentImage = (Image)sender;

            // increment numSelected cards
            numSelectedCards++;

            // declare and initialize to something
            var uriSource = new Uri(@"match1.png", UriKind.Relative);

            // create a variable for current card
            int currentCard = 0;

            // determine card based on image clicked
            // determine surrounding border based image clicked
            if (currentImage.Name == "pictureBox1")
            {
                currentCard = card1;
                currentBorder = pbBorder1;
            }
            else if (currentImage.Name == "pictureBox2")
            {
                currentCard = card2;
                currentBorder = pbBorder2;
            }
            else if (currentImage.Name == "pictureBox3")
            {
                currentCard = card3;
                currentBorder = pbBorder3;
            }
            else if (currentImage.Name == "pictureBox4")
            {
                currentCard = card4;
                currentBorder = pbBorder4;
            }
            else if (currentImage.Name == "pictureBox5")
            {
                currentCard = card5;
                currentBorder = pbBorder5;
            }
            else if (currentImage.Name == "pictureBox6")
            {
                currentCard = card6;
                currentBorder = pbBorder6;
            }
            else if (currentImage.Name == "pictureBox7")
            {
                currentCard = card7;
                currentBorder = pbBorder7;
            }
            else if (currentImage.Name == "pictureBox8")
            {
                currentCard = card8;
                currentBorder = pbBorder8;
            }
            else if (currentImage.Name == "pictureBox9")
            {
                currentCard = card9;
                currentBorder = pbBorder9;
            }
            else if (currentImage.Name == "pictureBox10")
            {
                currentCard = card10;
                currentBorder = pbBorder10;
            }
            else if (currentImage.Name == "pictureBox11")
            {
                currentCard = card11;
                currentBorder = pbBorder11;
            }
            else if (currentImage.Name == "pictureBox12")
            {
                currentCard = card12;
                currentBorder = pbBorder12;
            }

            // check picture to display
            if (currentCard == 1)
            {
                uriSource = new Uri(@"match1.png", UriKind.Relative);
            }
            else if (currentCard == 2)
            {
                uriSource = new Uri(@"match2.png", UriKind.Relative);
            }
            else if (currentCard == 3)
            {
                uriSource = new Uri(@"match3.png", UriKind.Relative);
            }
            else if (currentCard == 4)
            {
                uriSource = new Uri(@"match4.png", UriKind.Relative);
            }
            else if (currentCard == 5)
            {
                uriSource = new Uri(@"match5.png", UriKind.Relative);
            }
            else if (currentCard == 6)
            {
                uriSource = new Uri(@"match6.png", UriKind.Relative);
            }

            // put source into clicked currentImage
            currentImage.Source = new BitmapImage(uriSource);

            // check if two cards selected
            if (numSelectedCards == 2)
            {
                Thread.Sleep(100);
                WpfApplication.DoEvents();
                Thread.Sleep(100);
                WpfApplication.DoEvents();
                Thread.Sleep(1200);
                WpfApplication.DoEvents();

                // check if the first card is the same as the second
                if (firstSelectedCard == currentCard)
                {
                    // correct choice, remove from the screen
                    // set visibility to Hidden
                    currentBorder.Visibility = Visibility.Hidden;
                    firstSelectedBorder.Visibility = Visibility.Hidden;

                    // increment totalNumMatchesRemoved
                    totalNumMatchesRemoved++;

                    // display number of matches
                    displayMatches();

                    // check if all matches have been removed
                    if (totalNumMatchesRemoved == 6)
                    {
                        lblCongrats.Visibility = Visibility.Visible;
                        btnPlayAgain.Visibility = Visibility.Visible;
                    }
                }
                else
                {
                    // wrong choice; increment mistake
                    mistakes++;
                    lblMistakes.Content = mistakes.ToString();

                    // set UriSource back to the cardBack
                    uriSource = new Uri(@"cardBack.png", UriKind.Relative);

                    pictureBox1.Source = new BitmapImage(uriSource);
                    pictureBox2.Source = new BitmapImage(uriSource);
                    pictureBox3.Source = new BitmapImage(uriSource);
                    pictureBox4.Source = new BitmapImage(uriSource);
                    pictureBox5.Source = new BitmapImage(uriSource);
                    pictureBox6.Source = new BitmapImage(uriSource);
                    pictureBox7.Source = new BitmapImage(uriSource);
                    pictureBox8.Source = new BitmapImage(uriSource);
                    pictureBox9.Source = new BitmapImage(uriSource);
                    pictureBox10.Source = new BitmapImage(uriSource);
                    pictureBox11.Source = new BitmapImage(uriSource);
                    pictureBox12.Source = new BitmapImage(uriSource);
                }
                // reset number of selected cards to 0
                numSelectedCards = 0; // reset # selected cards
                firstSelectedCard = 0; // reset first
                firstSelectedBorder = new Border(); // reset first Borde
                firstSelectedImage = new Image(); // reset first Image
            }
            else if (firstSelectedCard == 0)
            {
                firstSelectedCard = currentCard;
                firstSelectedImage = currentImage;
                firstSelectedBorder = currentBorder;
            }
        }
    }
}
