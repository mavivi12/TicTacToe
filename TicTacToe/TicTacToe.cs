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
        bool playerturn = true; //true = 1st player turns; false = 2nd player turns
        int playerturn_count = 0;
        bool MayNanaloNaBa = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (playerturn)
                b.Text = "X";
            else
                b.Text = "O";

            playerturn = !playerturn; //change player
            b.Enabled = false; //one click only per button
            playerturn_count++; //incrementation

            WinnerChecker();
        }

        private void WinnerChecker()
        {
            //Checking horizontally
            if ((button1.Text == button2.Text) && (button2.Text == button3.Text) && (!button1.Enabled))
                MayNanaloNaBa = true;
            else if ((button4.Text == button5.Text) && (button5.Text == button6.Text) && (!button4.Enabled))
                MayNanaloNaBa = true;
            else if ((button7.Text == button8.Text) && (button8.Text == button9.Text) && (!button7.Enabled))
                MayNanaloNaBa = true;

            //Checking vertically
            else if ((button1.Text == button4.Text) && (button4.Text == button7.Text) && (!button1.Enabled))
                MayNanaloNaBa = true;
            else if((button2.Text == button5.Text) && (button5.Text == button8.Text) && (!button2.Enabled))
                MayNanaloNaBa = true;
            else if((button3.Text == button6.Text) && (button6.Text == button9.Text) && (!button3.Enabled))
                MayNanaloNaBa = true;

            //Checking Diagonally
            else if((button1.Text == button5.Text) && (button5.Text == button9.Text) && (!button1.Enabled))
                MayNanaloNaBa = true;
            else if((button3.Text == button5.Text) && (button5.Text == button7.Text) && (!button3.Enabled))
                MayNanaloNaBa = true;

            if (MayNanaloNaBa)
            {
                string Panalo;
                if (playerturn)
                    Panalo = "O";
                else
                    Panalo = "X";

                MessageBox.Show(Panalo + " Wins!", "Congratulations!");

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            else if (playerturn_count == 9)
                {
                    MessageBox.Show("Draw!", "No Winner!");
                }
        }//may nanalo na

        private void NewGameContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            Application.Restart();
        }

        private void AboutContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Developed by Marvic Macarubbo (2021).\nEnjoy the Tic-Tac-Toe Game!", "Tic-Tac-Toe About");
        }

        private void ExitContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            this.Close();
        }
    }
}
