using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZStrongDesktop
{
    public partial class Form1 : Form
    {
        public static string genWord = "abcdef";
        public static string pass = "";
        public static int genNum = 0;
        public static char[,] genGrid = new char[6, 6];
        public static bool shorty = false;
        public static bool special = false;
        public static bool random = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void PassGen(string word, int num)
        {
            word = wordBox.Text;
            word.ToLower();

            if (random == true)
            {
                RandPassGrid(genGrid, num);
            }
            else
            {
                PassGrid(genGrid, word, num);
            }

            Alphabet(genGrid, num);

            PassBuild(genGrid, num);

            PassShift(pass, num);

            if (special == false)
            {
                FinalPass(pass, num);
            }

            passBox.Text = pass;
        }

        private void PassGrid(char[,] grid, string word, int num)
        {
            pass = "";

            for (int i = 0; i < 6; i++)
            {
                grid[0,i] = word[i];
            }
        }

        private void RandPassGrid(char[,] grid, int num)
        {
            Random rand = new Random();
            char holder;

            pass = "";

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    holder = (char)rand.Next(97, 123);
                    grid[i, j] = holder;
                }
            }
        }

        private void Alphabet(char[,] grid, int num)
        {
            char gridHolder;

            for (int i = 1; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    gridHolder = grid[i - 1, j];
                    gridHolder = (char)((int)gridHolder + (int)num);

                    if (gridHolder > 122)
                    {
                        gridHolder = (char)((int)gridHolder - 26);
                    }

                    grid[i, j] = gridHolder;
                }
            }
        }

        private void PassBuild(char[,] grid, int pnum)
        {
            int passLength = 0;
            int row = 0;
            int col = 0;

            pass = "";

            if (shorty == false)
            {
                passLength = 12;
            }
            else
            {
                passLength = 8;
            }

            for (int i = 0; i < passLength; i++)
            {
                col = col + pnum;

                while (col > 5)
                {
                    row++;
                    col = col - 6;
                }
                while (row > 5)
                {
                    col++;
                    row = row - 6;

                    if (col > 5)
                    {
                        col = col - 6;
                    }
                }

                pass = pass + grid[row, col];
            }
        }

        private void PassShift(string pword, int pnum)
        {
            bool even = false;
            int spacer = 0;
            char[] passWord = new char[pword.Length - 1];

            passWord = pword.ToCharArray();
            pass = "";

            if (pnum % 2 == 0)
            {
                even = true;
            }

            if (even == true)
            {
                passWord[0] = char.ToUpper(passWord[0]);
            }
            else
            {
                passWord[1] = char.ToUpper(passWord[1]);
            }

            for (int i = 0; i < 4; i++)
            {
                spacer = spacer + pnum;

                if (spacer > (pword.Length - 1))
                {
                    spacer = spacer - pword.Length;
                }

                passWord[spacer] = char.ToUpper(passWord[spacer]);
            }

            for (int i = 0; i < pword.Length; i++)
            {
                if (i == pnum)
                {
                    int numholder = pnum * 2;

                    if (numholder > 9)
                    {
                        numholder = numholder - 10;
                    }

                    String charnum = numholder.ToString();
                    passWord[i - 1] = charnum[0];
                }
            }

            for (int i = 0; i < pword.Length; i++)
            {
                pass = pass + passWord[i];
            }
        }

        private void FinalPass(string pword, int pnum)
        {
            char[] passWord = new char[pword.Length - 1];

            passWord = pword.ToCharArray();
            pass = "";

            if (pnum == 0)
            {
                pnum = 10;
            }

            if (shorty == true)
            {
                pnum = pnum / 2;
            }

            for (int i = 0; i < pword.Length; i++)
            {
                if (i == pnum)
                {
                    passWord[i] = '-';
                }

                if (i == pnum * 2)
                {
                    passWord[i] = '_';
                }
            }

            for (int i = 0; i < pword.Length; i++)
            {
                pass = pass + passWord[i];
            }
        }

        private void genButton_Click(object sender, EventArgs e)
        {
            string wordHolder = wordBox.Text;
            string numHolder = numBox.Text;
            int wordLength = wordHolder.Length;
            int numLength = numHolder.Length;
            char numCheck = numHolder[0];

            if ((wordLength > 5 && numLength == 1) && (numCheck > 47 && numCheck < 58))
            {
                PassGen(wordHolder, int.Parse(numHolder));
            }
            else
            {
                passBox.Text = "Invalid input!";
            }
        }

        private void shortCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (shorty == false)
            {
                shorty = true;
            }
            else
            {
                shorty = false;
            }
        }

        private void specialCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (special == false)
            {
                special = true;
            }
            else
            {
                special = false;
            }
        }

        private void randCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (random == false)
            {
                random = true;
            }
            else
            {
                random = false;
            }
        }

        private void usingEZStrongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void otherVersionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void donateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }
    }
}
