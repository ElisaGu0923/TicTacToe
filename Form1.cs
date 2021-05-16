using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_Game
{
    public partial class Form1 : Form
    {
        Boolean checker;
        int plusOne;
        int round=0;

        void Enable_False()
        {
            btnTic1.Enabled = false;
            btnTic2.Enabled = false;
            btnTic3.Enabled = false;
            btnTic4.Enabled = false;
            btnTic5.Enabled = false;
            btnTic6.Enabled = false;
            btnTic7.Enabled = false;
            btnTic8.Enabled = false;
            btnTic9.Enabled = false;
            round = 0;
        }

        void ResetToDefault()
        {
            btnTic1.Text = "";
            btnTic2.Text = "";
            btnTic3.Text = "";
            btnTic4.Text = "";
            btnTic5.Text = "";
            btnTic6.Text = "";
            btnTic7.Text = "";
            btnTic8.Text = "";
            btnTic9.Text = "";
            btnTic1.BackColor = Color.WhiteSmoke;
            btnTic2.BackColor = Color.WhiteSmoke;
            btnTic3.BackColor = Color.WhiteSmoke;
            btnTic4.BackColor = Color.WhiteSmoke;
            btnTic5.BackColor = Color.WhiteSmoke;
            btnTic6.BackColor = Color.WhiteSmoke;
            btnTic7.BackColor = Color.WhiteSmoke;
            btnTic8.BackColor = Color.WhiteSmoke;
            btnTic9.BackColor = Color.WhiteSmoke;
            btnTic1.Enabled = true;
            btnTic2.Enabled = true;
            btnTic3.Enabled = true;
            btnTic4.Enabled = true;
            btnTic5.Enabled = true;
            btnTic6.Enabled = true;
            btnTic7.Enabled = true;
            btnTic8.Enabled = true;
            btnTic9.Enabled = true;
            round = 0;
        }

        void score()
        {
            Boolean Xwins = false;
            Boolean Owins = false;
            if (btnTic1.Text == "X" && btnTic2.Text == "X" && btnTic3.Text == "X")
            {
                btnTic1.BackColor = Color.PowderBlue;
                btnTic2.BackColor = Color.PowderBlue;
                btnTic3.BackColor = Color.PowderBlue;
                Xwins = true;
            } else if (btnTic4.Text == "X" && btnTic5.Text == "X" && btnTic6.Text == "X")
            {
                btnTic4.BackColor = Color.PowderBlue;
                btnTic5.BackColor = Color.PowderBlue;
                btnTic6.BackColor = Color.PowderBlue;
                Xwins = true;
            } else if (btnTic7.Text == "X" && btnTic8.Text == "X" && btnTic9.Text == "X")
            {
                btnTic7.BackColor = Color.PowderBlue;
                btnTic8.BackColor = Color.PowderBlue;
                btnTic9.BackColor = Color.PowderBlue;
                Xwins = true;
            } else if (btnTic1.Text == "X" && btnTic4.Text == "X" && btnTic7.Text == "X")
            {
                btnTic1.BackColor = Color.PowderBlue;
                btnTic4.BackColor = Color.PowderBlue;
                btnTic7.BackColor = Color.PowderBlue;
                Xwins = true;
            } else if (btnTic2.Text == "X" && btnTic5.Text == "X" && btnTic8.Text == "X")
            {
                btnTic2.BackColor = Color.PowderBlue;
                btnTic5.BackColor = Color.PowderBlue;
                btnTic8.BackColor = Color.PowderBlue;
                Xwins = true;
            } else if (btnTic3.Text == "X" && btnTic6.Text == "X" && btnTic9.Text == "X")
            {
                btnTic3.BackColor = Color.PowderBlue;
                btnTic6.BackColor = Color.PowderBlue;
                btnTic9.BackColor = Color.PowderBlue;
                Xwins = true;
            } else if (btnTic1.Text == "X" && btnTic5.Text == "X" && btnTic9.Text == "X")
            {
                btnTic1.BackColor = Color.PowderBlue;
                btnTic5.BackColor = Color.PowderBlue;
                btnTic9.BackColor = Color.PowderBlue;
                Xwins = true;
            } else if (btnTic3.Text == "X" && btnTic5.Text == "X" && btnTic7.Text == "X")
            {
                btnTic3.BackColor = Color.PowderBlue;
                btnTic5.BackColor = Color.PowderBlue;
                btnTic7.BackColor = Color.PowderBlue;
                Xwins = true;
            } else if (btnTic1.Text == "O" && btnTic2.Text == "O" && btnTic3.Text == "O")
            {
                btnTic1.BackColor = Color.Crimson;
                btnTic2.BackColor = Color.Crimson;
                btnTic3.BackColor = Color.Crimson;
                Owins = true;
            }
            else if (btnTic4.Text == "O" && btnTic5.Text == "O" && btnTic6.Text == "O")
            {
                btnTic4.BackColor = Color.Crimson;
                btnTic5.BackColor = Color.Crimson;
                btnTic6.BackColor = Color.Crimson;
                Owins = true;
            }
            else if (btnTic7.Text == "O" && btnTic8.Text == "O" && btnTic9.Text == "O")
            {
                btnTic7.BackColor = Color.Crimson;
                btnTic8.BackColor = Color.Crimson;
                btnTic9.BackColor = Color.Crimson;
                Owins = true;
            }
            else if (btnTic1.Text == "O" && btnTic4.Text == "O" && btnTic7.Text == "O")
            {
                btnTic1.BackColor = Color.Crimson;
                btnTic4.BackColor = Color.Crimson;
                btnTic7.BackColor = Color.Crimson;
                Owins = true;
            }
            else if (btnTic2.Text == "O" && btnTic5.Text == "O" && btnTic8.Text == "O")
            {
                btnTic2.BackColor = Color.Crimson;
                btnTic5.BackColor = Color.Crimson;
                btnTic8.BackColor = Color.Crimson;
                Owins = true;
            }
            else if (btnTic3.Text == "O" && btnTic6.Text == "O" && btnTic9.Text == "O")
            {
                btnTic3.BackColor = Color.Crimson;
                btnTic6.BackColor = Color.Crimson;
                btnTic9.BackColor = Color.Crimson;
                Owins = true;
            }
            else if (btnTic1.Text == "O" && btnTic5.Text == "O" && btnTic9.Text == "O")
            {
                btnTic1.BackColor = Color.Crimson;
                btnTic5.BackColor = Color.Crimson;
                btnTic9.BackColor = Color.Crimson;
                Owins = true;
            }
            else if (btnTic3.Text == "O" && btnTic5.Text == "O" && btnTic7.Text == "O")
            {
                btnTic3.BackColor = Color.Crimson;
                btnTic5.BackColor = Color.Crimson;
                btnTic7.BackColor = Color.Crimson;
                Owins = true;
            }

            if (Xwins)
            {
                MessageBox.Show("The Winner is Player X!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // int.parse() converts string to int
                plusOne = int.Parse(lblPlayerX.Text) + 1;
                lblPlayerX.Text = Convert.ToString(plusOne);
                Enable_False();

            }
            else if (Owins)
            {
                MessageBox.Show("The Winner is Player O!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerO.Text) + 1;
                lblPlayerO.Text = Convert.ToString(plusOne);
                Enable_False();

            }
            else if (round == 9)
            {
                MessageBox.Show("Try Again!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_False();

            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTic1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic1.Text = "X";
                checker = true;
            } else
            {
                btnTic1.Text = "O";
                checker = false;
            }
            round++;
            btnTic1.Enabled = false;
            score();
        }

        private void btnTic2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic2.Text = "X";
                checker = true;
            }
            else
            {
                btnTic2.Text = "O";
                checker = false;
            }
            round++;
            btnTic2.Enabled = false;
            score();
        }

        private void btnTic3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic3.Text = "X";
                checker = true;
            }
            else
            {
                btnTic3.Text = "O";
                checker = false;
            }
            round++;
            btnTic3.Enabled = false;
            score();
        }

        private void btnTic4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic4.Text = "X";
                checker = true;
            }
            else
            {
                btnTic4.Text = "O";
                checker = false;
            }
            round++;
            btnTic4.Enabled = false;
            score();
        }

        private void btnTic5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic5.Text = "X";
                checker = true;
            }
            else
            {
                btnTic5.Text = "O";
                checker = false;
            }
            round++;
            btnTic5.Enabled = false;
            score();
        }

        private void btnTic6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic6.Text = "X";
                checker = true;
            }
            else
            {
                btnTic6.Text = "O";
                checker = false;
            }
            round++;
            btnTic6.Enabled = false;
            score();
        }

        private void btnTic7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic7.Text = "X";
                checker = true;
            }
            else
            {
                btnTic7.Text = "O";
                checker = false;
            }
            round++;
            btnTic7.Enabled = false;
            score();
        }

        private void btnTic8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic8.Text = "X";
                checker = true;
            }
            else
            {
                btnTic8.Text = "O";
                checker = false;
            }
            round++;
            btnTic8.Enabled = false;
            score();
        }

        private void btnTic9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic9.Text = "X";
                checker = true;
            }
            else
            {
                btnTic9.Text = "O";
                checker = false;
            }
            round++;
            btnTic9.Enabled = false;
            score();
        }

        // Exit
        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // New Game
        private void button12_Click(object sender, EventArgs e)
        {
            ResetToDefault();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblPlayerX.Text = "0";
            lblPlayerO.Text = "0";
            ResetToDefault();
        }
    }
}
