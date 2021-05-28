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
            b.Enabled = false;
            playerturn_count++;

            WinnerChecker();
        }

        private void FileContextMenuStrip_Click(object sender, EventArgs e)
        {

        }

        private void HelpContextMenuStrip_Click(object sender, EventArgs e)
        {

        }

        private void AboutContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Developed by Marvic Macarubbo (2021).\n Enjoy the Tic-Tac-Toe Game!", "Tic-Tac-Toe About");
        }

        private void ExitContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            Application.Exit();
        }

        private void NewGameContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }

        private void WinnerChecker()
        {
            bool MayNanaloNaBa = false;

            //Checking horizontally
            if ((button1.Text == button2.Text) && (button2.Text == button3.Text) && (!button1.Enabled))
                MayNanaloNaBa = true;
            if ((button4.Text == button5.Text) && (button8.Text == button6.Text) && (!button4.Enabled))
                MayNanaloNaBa = true;
            if ((button7.Text == button8.Text) && (button8.Text == button9.Text) && (!button7.Enabled))
                MayNanaloNaBa = true;

            //Checking vertically
            if ((button1.Text == button4.Text) && (button4.Text == button7.Text) && (!button1.Enabled))
                MayNanaloNaBa = true;
            if ((button2.Text == button5.Text) && (button5.Text == button8.Text) && (!button2.Enabled))
                MayNanaloNaBa = true;
            if ((button3.Text == button6.Text) && (button6.Text == button9.Text) && (!button3.Enabled))
                MayNanaloNaBa = true;

            //Checking Diagonally
            if ((button1.Text == button5.Text) && (button5.Text == button9.Text) && (!button1.Enabled))
                MayNanaloNaBa = true;
            if ((button3.Text == button5.Text) && (button5.Text == button7.Text) && (!button3.Enabled))
                MayNanaloNaBa = true;

            if (MayNanaloNaBa)
            {
                string Panalo;
                if (playerturn)
                    Panalo = "O";
                else
                    Panalo = "X";

                MessageBox.Show(Panalo + " Wins!", "Congratulations!");
            }
            else
            {
                if (playerturn_count == 9)
                    MessageBox.Show("Draw!", "No Winner!");
            }
        }//may nanalo na

        private void Stop_Na()
        {
            if else
        }
    }
}
