using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacTest
{
    public partial class NewForm : Form
    {
        public NewForm()
        {
            InitializeComponent();
        }

        public String player = "";
        public int count = 0;
        public Boolean win = false;
        public String winner = "";

        public void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void btnPlay_Click(object sender, EventArgs e)
        {
            CreateBoard();
        }

        public void CreateBoard()
        {
            pnlBoard.Visible = true;
            player = "X";
            btnPlay.Enabled = false;
            CurrentPlayer();
        }

        public void CurrentPlayer()
        {
            if (player == "X")
            {
                lblP1.Visible = true;
                lblP2.Visible = false;
            }
            else
            {
                lblP2.Visible = true;
                lblP1.Visible = false;
            }
        }


        public void ChangePlayer()
        {
            if (player == "X")
            {
                player = "O";
            }
            else
            {
                player = "X";
            }
        }

        public void MakeMove(Button btn)
        {
            btn.Text = player;
            ChangePlayer();
            CurrentPlayer();
            SpaceInUse(btn);
            CheckForWinner();
            if (win == true)
            {
                MessageBox.Show(winner + " wins! Game over!");
                Close();
            }
            count++;
            if (count == 9)
            {
                MessageBox.Show("No winner! Game over!");
                Close();
            }
        }

        public void CheckForWinner()
        {
            //Row 1
            if (btnlawfulgood.Text == "X" && btnneutralgood.Text == "X" && btnchaoticgood.Text == "X")
            {
                win = true;
                winner = "Player 1";
            }
            else if (btnlawfulgood.Text == "O" && btnneutralgood.Text == "O" && btnchaoticgood.Text == "O")
            {
                win = true;
                winner = "Player 2";
            }

            //Row 2
            else if (btnlawfulneutral.Text == "X" && btntrueneutral.Text == "X" && btnchaoticneutral.Text == "X")
            {
                win = true;
                winner = "Player 1";
            }
            else if (btnlawfulneutral.Text == "O" && btntrueneutral.Text == "O" && btnchaoticneutral.Text == "O")
            {
                win = true;
                winner = "Player 2";
            }

            //Row 3
            else if (btnlawfulevil.Text == "X" && btnneutralevil.Text == "X" && btnchaoticevil.Text == "X")
            {
                win = true;
                winner = "Player 1";
            }
            else if (btnlawfulevil.Text == "O" && btnneutralevil.Text == "O" && btnchaoticevil.Text == "O")
            {
                win = true;
                winner = "Player 2";
            }

            //Column 1
            else if (btnlawfulgood.Text == "X" && btnlawfulneutral.Text == "X" && btnlawfulevil.Text == "X")
            {
                win = true;
                winner = "Player 1";
            }
            else if (btnlawfulgood.Text == "O" && btnlawfulneutral.Text == "O" && btnlawfulevil.Text == "O")
            {
                win = true;
                winner = "Player 2";
            }

            //Column 2
            else if (btnneutralgood.Text == "X" && btntrueneutral.Text == "X" && btnneutralevil.Text == "X")
            {
                win = true;
                winner = "Player 1";
            }
            else if (btnneutralgood.Text == "O" && btntrueneutral.Text == "O" && btnneutralevil.Text == "O")
            {
                win = true;
                winner = "Player 2";
            }

            //Coulmn 3
            else if (btnchaoticgood.Text == "X" && btnchaoticneutral.Text == "X" && btnchaoticevil.Text == "X")
            {
                win = true;
                winner = "Player 1";
            }
            else if (btnchaoticgood.Text == "O" && btnchaoticneutral.Text == "O" && btnchaoticevil.Text == "O")
            {
                win = true;
                winner = "Player 2";
            }

            //Diagonal 1
            else if (btnlawfulgood.Text == "X" && btntrueneutral.Text == "X" && btnchaoticevil.Text == "X")
            {
                win = true;
                winner = "Player 1";
            }
            else if (btnlawfulgood.Text == "O" && btntrueneutral.Text == "O" && btnchaoticevil.Text == "O")
            {
                win = true;
                winner = "Player 2";
            }

            //Diagonal 2
            else if (btnchaoticgood.Text == "X" && btntrueneutral.Text == "X" && btnlawfulevil.Text == "X")
            {
                win = true;
                winner = "Player 1";
            }
            else if (btnchaoticgood.Text == "O" && btntrueneutral.Text == "O" && btnlawfulevil.Text == "O")
            {
                win = true;
                winner = "Player 2";
            }

            else
            {
                win = false;
            }
        }

        public void SpaceInUse(Button btn)
        {
            btn.Enabled = false;
        }

        public void btnlawfulgood_Click(object sender, EventArgs e)
        {
            MakeMove(btnlawfulgood);
        }

        public void btnneutralgood_Click(object sender, EventArgs e)
        {
            MakeMove(btnneutralgood);
        }

        public void btnchaoticgood_Click(object sender, EventArgs e)
        {
            MakeMove(btnchaoticgood);
        }

        public void btnlawfulneutral_Click(object sender, EventArgs e)
        {
            MakeMove(btnlawfulneutral);
        }

        public void btntrueneutral_Click(object sender, EventArgs e)
        {
            MakeMove(btntrueneutral);
        }

        public void btnchaoticneutral_Click(object sender, EventArgs e)
        {
            MakeMove(btnchaoticneutral);
        }

        public void btnlawfulevil_Click(object sender, EventArgs e)
        {
            MakeMove(btnlawfulevil);
        }

        public void btnneutralevil_Click(object sender, EventArgs e)
        {
            MakeMove(btnneutralevil);
        }

        public void btnchaoticevil_Click(object sender, EventArgs e)
        {
            MakeMove(btnchaoticevil);
        }

    }
}