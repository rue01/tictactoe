using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool turn = true; //true = X; false =Y
        int turn_count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For rules on how to play the game, search Tic Tac Toe rules in a search engine", "Tic tac toe game rules");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }

            turn = !turn;
            b.Enabled = false; // this blocks the other user from changing first users option
            turn_count++;

            checkForWinner();

        }


        private void checkForWinner()
        {
            bool there_is_a_winner = false;
            
            //horizontal checks
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            {
                there_is_a_winner = true;
            }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                there_is_a_winner = true;
            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                there_is_a_winner = true;
            }


            //vertical checks
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                there_is_a_winner = true;
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                there_is_a_winner = true;
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                there_is_a_winner = true;
            }



            // diagonal checks
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                there_is_a_winner = true;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
            {
                there_is_a_winner = true;
            }
            




            if (there_is_a_winner )
            {
                disabledButtons();

                string winner ="";

                if(turn)
                {
                    winner="O";
                    Player_O_score.Text = (Int32.Parse(Player_O_score.Text) + 1).ToString();
                }
                else
                {
                    winner = "X";
                    Player_X_score.Text = (Int32.Parse(Player_X_score.Text) + 1).ToString();
                }
                
                MessageBox.Show(winner + " wins!", "Yay!");
            } //endif
            else
            {
                if (turn_count == 9)
                {
                    MessageBox.Show(" Draw", "Shame:(");
                    Draw_score.Text = (Int32.Parse(Draw_score.Text) + 1).ToString();
                }
            }

        } //end checkWinner

        private void disabledButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }// end foreach
            }
            catch{ }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            
                foreach (Control c in Controls)
                {
                    try
                   {
                        Button b = (Button)c;
                        b.Enabled = true;
                        b.Text = "";
                    }// end try
                    catch { }
                }// end foreach
        }

        private void display_enter(object sender, EventArgs e)
        {
            if(turn)
                displayturn.Text = "Player X";
            else
                displayturn.Text = "Player O";

        }    
    }
}
