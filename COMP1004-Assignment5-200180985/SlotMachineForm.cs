/// <summary>
/// Applicaiton: Slot Machine
/// Author: Mark Chipp (original code template by Tom Tsiliopolous
/// Student ID: 200180985
/// Last modified: 4-Dec-2016
/// Description: This is a Stargate themed slot machine game where users can bet credits and dial-to-win!
/// </summary>

using COMP1004_Assignment5_200180985.Properties;
using System;
using System.Threading;
using System.Windows.Forms;

namespace COMP1004_Assignment5_200180985
{
    ///////////////////////\\\\\\\\\\\\\\\\\\\\\\\
    ///////////////////CLASSES\\\\\\\\\\\\\\\\\\\\
    ///////////////////////\\\\\\\\\\\\\\\\\\\\\\\

    public partial class SlotMachineForm : Form
    {
        private int playerMoney = 1000;
        private int winnings = 0;
        private int jackpot = 5000;
        private float turn = 0.0f;
        private int playerBet = 0;
        private float winNumber = 0.0f;
        private float lossNumber = 0.0f;
        private string[] spinResult;
        private string fruits = "";
        private float winRatio = 0.0f;
        private float lossRatio = 0.0f;
        private int grapes = 0;
        private int bananas = 0;
        private int oranges = 0;
        private int cherries = 0;
        private int bars = 0;
        private int bells = 0;
        private int sevens = 0;
        private int blanks = 0;

        private Random random = new Random();

        private Boolean _isSpinning = false;

        public SlotMachineForm()
        {
            InitializeComponent();
            UpdateLabels();
        }

        ///////////////////////\\\\\\\\\\\\\\\\\\\\\\\
        ///////////////////FUNCTIONS\\\\\\\\\\\\\\\\\\
        ///////////////////////\\\\\\\\\\\\\\\\\\\\\\\

        /* Utility function to show Player Stats */
        private void showPlayerStats()
        {
            winRatio = winNumber / turn;
            lossRatio = lossNumber / turn;
            string stats = "";
            stats += ("Jackpot: " + jackpot + "\n");
            stats += ("Player Money: " + playerMoney + "\n");
            stats += ("Turn: " + turn + "\n");
            stats += ("Wins: " + winNumber + "\n");
            stats += ("Losses: " + lossNumber + "\n");
            stats += ("Win Ratio: " + (winRatio * 100) + "%\n");
            stats += ("Loss Ratio: " + (lossRatio * 100) + "%\n");
            MessageBox.Show(stats, "Player Stats");
        }

        /* Utility function to reset all fruit tallies*/
        private void resetFruitTally()
        {
            grapes = 0;
            bananas = 0;
            oranges = 0;
            cherries = 0;
            bars = 0;
            bells = 0;
            sevens = 0;
            blanks = 0;
        }

        /* Utility function to reset the player stats */
        private void resetAll()
        {
            PictureBox[] reels = { ReelOnePictureBox, ReelTwoPictureBox, ReelThreePictureBox, ReelFourPictureBox, ReelFivePictureBox,
                                    ReelSixPictureBox, ReelSevenPictureBox };

            playerMoney = 1000;
            winnings = 0;
            jackpot = 5000;
            turn = 0;
            playerBet = 0;
            winNumber = 0;
            lossNumber = 0;
            winRatio = 0.0f;
            UpdateLabels();
            
            foreach(PictureBox reel in reels)
            {
                reel.Image = Resources.blank;
            }
        }

        /* Check to see if the player won the jackpot */
        private void checkJackPot()
        {
            /* compare two random values */
            var jackPotTry = this.random.Next(51) + 1;
            var jackPotWin = this.random.Next(51) + 1;

            if (jackPotTry == jackPotWin)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.sgjackpot);
                player.Play();
                MessageBox.Show("You Won the $" + jackpot + " Jackpot!!", "Jackpot!!");
                playerMoney += jackpot;
                jackpot = 1000;
            }
        }

        /* Utility function to show a win message and increase player money */
        private void showWinMessage()
        {
            playerMoney += winnings;
            //MessageBox.Show("You Won: $" + winnings, "Winner!"); // uncomment this line for debugging
            resetFruitTally();
            checkJackPot();
        }

        /* Utility function to show a loss message and reduce player money */
        private void showLossMessage()
        {
            playerMoney -= playerBet;
            //MessageBox.Show("You Lost!", "Loss!"); // uncomment this line for debugging
            resetFruitTally();
        }

        /* Utility function to check if a value falls within a range of bounds */
        private bool checkRange(int value, int lowerBounds, int upperBounds)
        {
            return (value >= lowerBounds && value <= upperBounds) ? true : false;
        }

        /* When this function is called it determines the betLine results.
    e.g. Bar - Orange - Banana */
        private string[] Reels()
        {
            string[] betLine = { " ", " ", " ", " ", " ", " ", " " };
            int[] outCome = { 0, 0, 0, 0, 0, 0, 0 };

            // create a list of the reel images to by updated dynamically as each reel is selected
            PictureBox[] reels = { ReelOnePictureBox, ReelTwoPictureBox, ReelThreePictureBox, ReelFourPictureBox,
                                    ReelFivePictureBox, ReelSixPictureBox, ReelSevenPictureBox };

            for (var spin = 0; spin < 7; spin++)
            {

                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.lockedchev);
                
                Application.DoEvents(); //allow windows to execute all pending tasks
                Thread.Sleep(1250);

                player.Play();


                outCome[spin] = this.random.Next(65) + 1;

                Random rand = new Random();

                if (rand.Next(1, 101) <= 18)
                {  // 18%% probability
                    betLine[spin] = "blank";
                    // reel for current spin updates with appropriate image
                    reels[spin].Image = Resources.blank;
                    blanks++;
                }
                else if (checkRange(outCome[spin], 28, 37))
                { // 15.4% probability
                    betLine[spin] = "Chevron 1";
                    // reel for current spin updates with appropriate image
                    reels[spin].Image = Resources.icon_1;
                    grapes++;
                }
                else if (checkRange(outCome[spin], 38, 46))
                { // 13.8% probability
                    betLine[spin] = "Chevron 2";
                    // reel for current spin updates with appropriate image
                    reels[spin].Image = Resources.icon_2;
                    bananas++;
                }
                else if (checkRange(outCome[spin], 47, 54))
                { // 12.3% probability
                    betLine[spin] = "Chevron 3";
                    // reel for current spin updates with appropriate image
                    reels[spin].Image = Resources.icon_3;
                    oranges++;
                }
                else if (checkRange(outCome[spin], 55, 59))
                { //  7.7% probability
                    betLine[spin] = "Chevron 4";
                    // reel for current spin updates with appropriate image
                    reels[spin].Image = Resources.icon_4;
                    cherries++;
                }
                else if (checkRange(outCome[spin], 60, 62))
                { //  4.6% probability
                    betLine[spin] = "Chevron 5";
                    // reel for current spin updates with appropriate image
                    reels[spin].Image = Resources.x302;
                    bars++;
                }
                else if (checkRange(outCome[spin], 63, 64))
                { //  3.1% probability
                    betLine[spin] = "Chevron 6";
                    // reel for current spin updates with appropriate image
                    reels[spin].Image = Resources.x304;
                    bells++;
                }
                else if (checkRange(outCome[spin], 65, 65))
                { //  1.5% probability
                    betLine[spin] = "Chevron 7";
                    // reel for current spin updates with appropriate image
                    reels[spin].Image = Resources.SGC_Logo;
                    sevens++;
                }
            }
            _isSpinning = false;
            return betLine;
        }

        /* This function calculates the player's winnings, if any */
        private void determineWinnings()
        {
            if (blanks == 0)
            {
                if (grapes == 3)
                {
                    winnings = playerBet * 10;
                }
                else if (bananas == 3)
                {
                    winnings = playerBet * 20;
                }
                else if (oranges == 3)
                {
                    winnings = playerBet * 30;
                }
                else if (cherries == 3)
                {
                    winnings = playerBet * 40;
                }
                else if (bars == 3)
                {
                    winnings = playerBet * 50;
                }
                else if (bells == 3)
                {
                    winnings = playerBet * 75;
                }
                else if (sevens == 3)
                {
                    winnings = playerBet * 100;
                }
                else if (grapes == 2)
                {
                    winnings = playerBet * 2;
                }
                else if (bananas == 2)
                {
                    winnings = playerBet * 2;
                }
                else if (oranges == 2)
                {
                    winnings = playerBet * 3;
                }
                else if (cherries == 2)
                {
                    winnings = playerBet * 4;
                }
                else if (bars == 2)
                {
                    winnings = playerBet * 5;
                }
                else if (bells == 2)
                {
                    winnings = playerBet * 10;
                }
                else if (sevens == 2)
                {
                    winnings = playerBet * 20;
                }
                else if (sevens == 1)
                {
                    winnings = playerBet * 5;
                }
                else
                {
                    winnings = playerBet * 1;
                }
                winNumber++;
                showWinMessage();
            }
            else
            {
                lossNumber++;
                showLossMessage();
            }
        }

        /* updates all labels for player money, current bet, jackpot and winnings */
        private void UpdateLabels()
        {
            MoneyLabel.Text = playerMoney.ToString();
            BetLabel.Text = playerBet.ToString();
            JackpotLabel.Text = jackpot.ToString();
            WinningsLabel.Text = winnings.ToString();
        }

        ///////////////////////\\\\\\\\\\\\\\\\\\\\\\\
        /////////////////EVENT HANDLERS\\\\\\\\\\\\\\\
        ///////////////////////\\\\\\\\\\\\\\\\\\\\\\\

        private void SpinPictureBox_Click(object sender, EventArgs e)
        {
            if (_isSpinning == false)
            {
                //playerBet = 10; // default bet amount

                if (playerMoney == 0)
                {
                    if (MessageBox.Show("You ran out of Money! \nDo you want to play again?", "Out of Money!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        resetAll();
                        //showPlayerStats();
                    }
                }
                else if (playerBet > playerMoney)
                {
                    MessageBox.Show("You don't have enough Money to place that bet.", "Insufficient Funds");
                }
                else if (playerBet <= 0)
                {
                    MessageBox.Show("All bets must be a positive $ amount, and above 0.", "Incorrect Bet");
                }
                else if (playerBet <= playerMoney)
                {
                    _isSpinning = true;
                    spinResult = Reels();
                    //fruits = spinResult[0] + " - " + spinResult[1] + " - " + spinResult[2]; // uncomment this line for debugging
                    //MessageBox.Show(fruits); // uncomment this line for debugging
                    determineWinnings();
                    turn++;
                    //showPlayerStats(); // uncomment this line for debugging
                }
                else
                {
                    MessageBox.Show("Please enter a valid bet amount");
                }

                // now update our labels
                UpdateLabels();
            }
            else
            {
                MessageBox.Show("Please wait for your current spin to end");
            }
        }

        // event handler handles exiting application when power picturebox is clicked
        private void ExitPictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // event handler handles resetting the game when the reset picturebox is clicked
        private void ResetPictureBox_Click(object sender, EventArgs e)
        {
            resetAll();
        }

        private void Bet1PictureBox_Click(object sender, EventArgs e)
        {
            playerBet += 1;
            UpdateLabels();
        }

        private void Bet2PictureBox_Click(object sender, EventArgs e)
        {
            playerBet += 2;
            UpdateLabels();
        }

        private void Bet5PictureBox_Click(object sender, EventArgs e)
        {
            playerBet += 5;
            UpdateLabels();
        }

        private void Bet10PictureBox_Click(object sender, EventArgs e)
        {
            playerBet += 10;
            UpdateLabels();
        }

        private void Bet25PictureBox_Click(object sender, EventArgs e)
        {
            playerBet += 25;
            UpdateLabels();
        }

        private void Bet50PictureBox_Click(object sender, EventArgs e)
        {
            playerBet += 50;
            UpdateLabels();
        }

        private void Bet100PictureBox_Click(object sender, EventArgs e)
        {
            playerBet += 100;
            UpdateLabels();
        }

        private void Bet500PictureBox_Click(object sender, EventArgs e)
        {
            playerBet += 500;
            UpdateLabels();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            playerBet = 0;
            UpdateLabels();
        }
    }
}
