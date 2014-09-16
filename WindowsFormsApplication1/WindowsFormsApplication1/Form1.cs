//To Do. 
//Code Turn System
//Add Ai random choice, Develope to smarter choices
//Add Rules.
//Add Win and Lose.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmOandX : Form
    {
        board boardDeafault = new board();

        public frmOandX()
        {
            InitializeComponent();

        }

        private void btnGrid0_Click(object sender, EventArgs e)
        {

            if (validate("grid0"))
            {
                btnGrid0.Text = "X";
            }
            else
            {
                errorMessage(1);
            }
        }

        private void btnGrid1_Click(object sender, EventArgs e)
        {

            if (validate("grid1"))
            {
                btnGrid1.Text = "X";
            }
            else
            {
                errorMessage(1);
            }

        }

        private void btnGrid2_Click(object sender, EventArgs e)
        {
            if (validate("grid2"))
            {
                btnGrid2.Text = "X";
            }
            else
            {
                errorMessage(1);
            }

        }

        private void btnGrid3_Click(object sender, EventArgs e)
        {
            if (validate("grid3"))
            {
                btnGrid3.Text = "X";
            }
            else
            {
                errorMessage(1);
            }

        }

        private void btnGrid4_Click(object sender, EventArgs e)
        {
            if (validate("grid4"))
            {
                btnGrid4.Text = "X";
            }
            else
            {
                errorMessage(1);
            }

        }

        private void btnGrid5_Click(object sender, EventArgs e)
        {
            if (validate("grid5"))
            {
                btnGrid5.Text = "X";
            }
            else
            {
                errorMessage(1);
            }

        }

        private void btnGrid6_Click(object sender, EventArgs e)
        {
            if (validate("grid6"))
            {
                btnGrid6.Text = "X";
            }
            else
            {
                errorMessage(1);
            }

        }

        private void btnGrid7_Click(object sender, EventArgs e)
        {
            if (validate("grid7"))
            {
                btnGrid7.Text = "X";
            }
            else
            {
                errorMessage(1);
            }

        }

        private void btnGrid8_Click(object sender, EventArgs e)
        {
            if (validate("grid8"))
            {
                btnGrid8.Text = "X";;
            }
            else
            {
                errorMessage(1);
            }

        }

        public void errorMessage(int code)
        {
            switch (code)
            {
                case 1:
                    MessageBox.Show("Square Already Taken.");
                    break;
                default:
                    MessageBox.Show("Unknown Error.");
                    break;

            }

        }


        public bool validate(string grid)
        {
            //MessageBox.Show("Validate Enter.");

            switch (grid)
            {
                case "grid0":
                    if (boardDeafault.grid0 == "")
                    {
                        //MessageBox.Show("True.");
                        boardDeafault.grid0 = "X";
                        return true;
                    }
                    break;

                case "grid1":
                    if (boardDeafault.grid1 == "")
                    {
                        boardDeafault.grid1 = "X";
                        return true;
                    }
                    break;

                case "grid2":
                    if (boardDeafault.grid2 == "")
                    {
                        boardDeafault.grid2 = "X";
                        return true;
                    }
                    break;

                case "grid3":
                    if (boardDeafault.grid3 == "")
                    {
                        boardDeafault.grid3 = "X";
                        return true;
                    }
                    break;

                case "grid4":
                    if (boardDeafault.grid4 == "")
                    {
                        boardDeafault.grid4 = "X";
                        return true;
                    }
                    break;

                case "grid5":
                    if (boardDeafault.grid5 == "")
                    {
                        boardDeafault.grid5 = "X";
                        return true;
                    }
                    break;

                case "grid6":
                    if (boardDeafault.grid6 == "")
                    {
                        boardDeafault.grid6 = "X";
                        return true;
                    }
                    break;

                case "grid7":
                    if (boardDeafault.grid7 == "")
                    {
                        boardDeafault.grid7 = "X";
                        return true;
                    }
                    break;

                case "grid8":
                    if (boardDeafault.grid8 == "")
                    {
                        boardDeafault.grid8 = "X";
                        return true;
                    }
                    break;

                default:
                    return false;
                    break;
            }

            return false;
        }


    }


    public class board
    {
        //Below varibles should be changed to be protected via accessor methods.
        public string grid0 { get; set; }
        public string grid1 { get; set; }
        public string grid2 { get; set; }
        public string grid3 { get; set; }
        public string grid4 { get; set; }
        public string grid5 { get; set; }
        public string grid6 { get; set; }
        public string grid7 { get; set; }
        public string grid8 { get; set; }

        public board()
        {
            grid0 = "";
            grid1 = "";
            grid2 = "";
            grid3 = "";
            grid4 = "";
            grid5 = "";
            grid6 = "";
            grid7 = "";
            grid8 = "";

        }



    }



}
