using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace minesweeper1
{
    public partial class Main : Form
    {
        private int r, c, m;
        Button[,] buttons;
        int[,] array;
        int[] numbers;
        int clicks;
        int cl;
        int seconds;
        bool[,] pause;

        public Main(int R, int C, int M)
        {
            InitializeComponent();
            r = R;
            c = C;
            m = M;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            buttons = new Button[r, c];
                for (int i = 0; i < r; i++)
                {
                    for (int j = 0; j < c; j++)
                    {
                        Button button = new Button();

                        button.Size = new Size(25, 25);
                        button.Location = new Point(55 + (i * 25), 70 + (j * 25));
                        button.Name = string.Format("button r{0}c{1}", i, j);
                        button.Text = "";
                        button.ForeColor = Color.MediumAquamarine;
                        button.Font = new Font(button.Font.FontFamily, 10,FontStyle.Bold);
                        button.TextAlign = ContentAlignment.TopCenter;
                        button.FlatStyle = FlatStyle.Flat;
                        button.BackColor = Color.White;
                        //button.BackgroundImage = Properties.Resources.showing_gallery_for_triangle_png_transparent_7fujAH_clipart;
                        //button.BackgroundImageLayout = ImageLayout.Stretch;

                        button.Click += (s, ex) =>
                        {
                            ButtonClick(button, array);
                        };
                     
                        button.MouseDown += (s2, ex2) =>
                        {
                            if (ex2.Button == MouseButtons.Right && button.Text == "")
                            {
                                button.Text = "M";
                            }
                            else if (ex2.Button == MouseButtons.Right && button.Text == "M")
                            {
                                button.Text = "";
                            }
                        };
                       
                        buttons[i, j] = button;
                        this.Controls.Add(button);
                    }
                }

                switch (r*c)
                {
                    case 36: this.Size = new Size(280, 280);
                        break;
                    case 64: this.Size = new Size(340, 340);
                        break;
                    case 100: this.Size = new Size(400, 400); 
                        break;
                    default:
                        break;
                }

            pause = new bool[r, c];

            arrNull(array);
            boolNull(pause);
            MinesGeneration(m);
            Detector(array);

            timer1.Interval = 1000;
            timer1.Start();
            
        }
        private void PictureBombs(int[,] arr)
        {
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    if (arr[row, col] == -1)
                    {
                        buttons[row, col].BackgroundImage = Properties.Resources.bomb__1_;
                        buttons[row, col].BackgroundImageLayout = ImageLayout.Zoom;
                    }
                    else
                    {
                        continue;
                    }
                        
                }
            }
        }
        private void ButtonClick(Button current, int[,] arr)
        {
            numbers = current.Name.ToString().Split(new string[] { "button r", "c" }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int row = numbers[0];
            int col = numbers[1];
            if(current.Text=="M")
            {
                return;
            }
            if (arr[row, col] == -1)
            {
                timer1.Stop();
                PictureBombs(array);
                if (MessageBox.Show("Wanna try again?", "Oops! Sorry!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Main.ActiveForm.Hide();
                    selectLevel formObject = new selectLevel();
                    formObject.ShowDialog();
                }
                else
                {
                    Application.Exit();
                }

            }
            else if(arr[row,col]==0)
            {
                current.Text = arr[row, col].ToString();
                current.Enabled = false;
                clicks++;
                OpenField(current, buttons);
                pause[row, col] = true;
            }
            else
            {
                current.Text = arr[row, col].ToString();
                current.Enabled = false;
                clicks++;
                pause[row, col] = true;
            }
            ForTheWin();
        }
        private void boolNull(bool[,] p)
        {
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    p[i,j]=false;
                }
            }
        }
        private void arrNull(int[,] arr)
        {
            array = new int[r, c];
            arr = array;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = 0;
                }
            }
        }

        private void MinesGeneration(int mines)
        {
            mines = m;
            Random bombRC = new Random();
            int counter = 0;
            array = new int[r, c];
            try
            {
                while (counter < mines)
                {
                    int rBomb = bombRC.Next(0, r);
                    int cBomb = bombRC.Next(0, c);
                    if (array[rBomb, cBomb] != -1)
                    {
                        array[rBomb, cBomb] = -1;
                        counter++;
                    }
                    else if (array[rBomb, cBomb] == -1)
                    {
                        continue;
                    }
                        //buttons[rBomb, cBomb].Text = array[rBomb, cBomb].ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Test");
                throw;
            }

        }

        private void Detector(int[,] arr)
        {
            arr = array;
            int mineCount;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    mineCount = 0;
                    if (arr[i, j] != -1)
                    {
                    //I = 0 check
                        if (i == 0)
                        {
                            if (j == 0)
                            {
                                if (arr[i + 1, j] == -1)
                                {
                                    mineCount++;
                                }
                                if (arr[i, j + 1] == -1)
                                {
                                    mineCount++;
                                }
                                if (arr[i + 1, j + 1] == -1)
                                {
                                    mineCount++;
                                }
                            }
                            else if (j == arr.GetLength(1) - 1)
                            {
                                if (arr[i, j - 1] == -1)
                                {
                                    mineCount++;
                                }
                                if (arr[i + 1, j - 1] == -1)
                                {
                                    mineCount++;
                                }
                                if (arr[i + 1, j] == -1)
                                {
                                    mineCount++;
                                }
                            }
                            else
                            {
                                if (arr[i, j - 1] == -1)
                                {
                                    mineCount++;
                                }
                                if (arr[i + 1, j - 1] == -1)
                                {
                                    mineCount++;
                                }
                                if (arr[i + 1, j] == -1)
                                {
                                    mineCount++;
                                }
                                if (arr[i + 1, j + 1] == -1)
                                {
                                    mineCount++;
                                }
                                if (arr[i, j + 1] == -1)
                                {
                                    mineCount++;
                                }
                            }
                        }
                        //I=r-1 check
                        if (i == arr.GetLength(0) - 1)
                        {
                            if (j == 0)
                            {
                                if (arr[i - 1, j] == -1)
                                {
                                    mineCount++;
                                }
                                if (arr[i - 1, j + 1] == -1)
                                {
                                    mineCount++;
                                }
                                if (arr[i, j + 1] == -1)
                                {
                                    mineCount++;
                                }
                            }
                            else if (j == arr.GetLength(1) - 1)
                            {
                                if (arr[i, j - 1] == -1)
                                {
                                    mineCount++;
                                }
                                if (arr[i - 1, j - 1] == -1)
                                {
                                    mineCount++;
                                }
                                if (arr[i - 1, j] == -1)
                                {
                                    mineCount++;
                                }
                            }
                            else
                            {
                                if (arr[i, j - 1] == -1)
                                {
                                    mineCount++;
                                }
                                if (arr[i - 1, j - 1] == -1)
                                {
                                    mineCount++;
                                }
                                if (arr[i - 1, j] == -1)
                                {
                                    mineCount++;
                                }
                                if (arr[i - 1, j + 1] == -1)
                                {
                                    mineCount++;
                                }
                                if (arr[i, j + 1] == -1)
                                {
                                    mineCount++;
                                }
                            }
                        }
                        //J=0 check
                        if (j == 0)
                        {
                            if(i!=0 && i!=arr.GetLength(0)-1)
                            {
                                if (arr[i - 1, j] == -1)
                                {
                                    mineCount++;
                                }
                                if (arr[i - 1, j + 1] == -1)
                                {
                                    mineCount++;
                                }
                                if (arr[i, j + 1] == -1)
                                {
                                    mineCount++;
                                }
                                if (arr[i + 1, j + 1] == -1)
                                {
                                    mineCount++;
                                }
                                if (arr[i + 1, j] == -1)
                                {
                                    mineCount++;
                                }
                            }
                        }
                        //J=c-1 check
                        if (j == arr.GetLength(1) - 1)
                        {
                           if(i!=0 && i!=arr.GetLength(1)-1)
                            {
                                if (arr[i - 1, j] == -1)
                                {
                                    mineCount++;
                                }
                                if (arr[i - 1, j - 1] == -1)
                                {
                                    mineCount++;
                                }
                                if (arr[i, j - 1] == -1)
                                {
                                    mineCount++;
                                }
                                if (arr[i + 1, j - 1] == -1)
                                {
                                    mineCount++;
                                }
                                if (arr[i + 1, j] == -1)
                                {
                                    mineCount++;
                                }
                            }
                        }
                        if (i != 0 && j != 0 && i != arr.GetLength(0) - 1 && j != arr.GetLength(1) - 1)
                        {
                            if (arr[i, j - 1] == -1)
                            {
                                mineCount++;
                            }
                            if (arr[i - 1, j - 1] == -1)
                            {
                                mineCount++;
                            }
                            if (arr[i - 1, j] == -1)
                            {
                                mineCount++;
                            }
                            if (arr[i - 1, j + 1] == -1)
                            {
                                mineCount++;
                            }
                            if (arr[i, j + 1] == -1)
                            {
                                mineCount++;
                            }
                            if (arr[i + 1, j + 1] == -1)
                            {
                                mineCount++;
                            }
                            if (arr[i + 1, j] == -1)
                            {
                                mineCount++;
                            }
                            if (arr[i + 1, j - 1] == -1)
                            {
                                mineCount++;
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                    arr[i, j] += mineCount;
                }
            }
        }

        private void OpenField(Button btn1, Button[,] btns)
        {
            numbers = btn1.Name.ToString().Split(new string[] { "button r", "c" }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int row = numbers[0];
            int col = numbers[1];
            if (row == 0)
            {
                if (col == 0)
                {
                    btns[row, col + 1].PerformClick();
                    btns[row, col + 1].Enabled = false;

                    btns[row + 1, col].PerformClick();
                    btns[row + 1, col].Enabled = false;

                    btns[row + 1, col + 1].PerformClick();
                    btns[row + 1, col + 1].Enabled = false;
                }
                else if (col == btns.GetLength(1) - 1)
                {
                    btns[row + 1, col].PerformClick();
                    btns[row + 1, col].Enabled = false;

                    btns[row + 1, col - 1].PerformClick();
                    btns[row + 1, col - 1].Enabled = false;

                    btns[row, col - 1].PerformClick();
                    btns[row, col - 1].Enabled = false;
                }
                else
                {
                    btns[row, col - 1].PerformClick();
                    btns[row, col - 1].Enabled = false;

                    btns[row, col + 1].PerformClick();
                    btns[row, col + 1].Enabled = false;

                    btns[row + 1, col - 1].PerformClick();
                    btns[row + 1, col - 1].Enabled = false;

                    btns[row + 1, col].PerformClick();
                    btns[row + 1, col].Enabled = false;

                    btns[row + 1, col + 1].PerformClick();
                    btns[row + 1, col + 1].Enabled = false;
                }
            }
            else if (row == btns.GetLength(0) - 1)
            {
                if (col == 0)
                {
                    btns[row, col + 1].PerformClick();
                    btns[row, col + 1].Enabled = false;

                    btns[row - 1, col].PerformClick();
                    btns[row - 1, col].Enabled = false;

                    btns[row - 1, col + 1].PerformClick();
                    btns[row - 1, col + 1].Enabled = false;
                }
                else if (col == btns.GetLength(1) - 1)
                {
                    btns[row - 1, col].PerformClick();
                    btns[row - 1, col].Enabled = false;

                    btns[row - 1, col - 1].PerformClick();
                    btns[row - 1, col - 1].Enabled = false;

                    btns[row, col - 1].PerformClick();
                    btns[row, col - 1].Enabled = false;
                }
                else
                {
                    btns[row, col - 1].PerformClick();
                    btns[row, col - 1].Enabled = false;

                    btns[row, col + 1].PerformClick();
                    btns[row, col + 1].Enabled = false;

                    btns[row - 1, col - 1].PerformClick();
                    btns[row - 1, col - 1].Enabled = false;

                    btns[row - 1, col].PerformClick();
                    btns[row - 1, col].Enabled = false;

                    btns[row - 1, col + 1].PerformClick();
                    btns[row - 1, col + 1].Enabled = false;
                }
            }
            else if (col == 0)
            {
                btns[row, col + 1].PerformClick();
                btns[row, col + 1].Enabled = false;

                btns[row - 1, col].PerformClick();
                btns[row - 1, col].Enabled = false;

                btns[row - 1, col + 1].PerformClick();
                btns[row - 1, col + 1].Enabled = false;

                btns[row + 1, col].PerformClick();
                btns[row + 1, col].Enabled = false;

                btns[row + 1, col + 1].PerformClick();
                btns[row + 1, col + 1].Enabled = false;
            }
            else if (col == btns.GetLength(1) - 1)
            {
                btns[row, col - 1].PerformClick();
                btns[row, col - 1].Enabled = false;

                btns[row - 1, col].PerformClick();
                btns[row - 1, col].Enabled = false;

                btns[row - 1, col - 1].PerformClick();
                btns[row - 1, col - 1].Enabled = false;

                btns[row + 1, col].PerformClick();
                btns[row + 1, col].Enabled = false;

                btns[row + 1, col - 1].PerformClick();
                btns[row + 1, col - 1].Enabled = false;
            }
            else
            {
                btns[row, col - 1].PerformClick();
                btns[row, col - 1].Enabled = false;

                btns[row, col + 1].PerformClick();
                btns[row, col + 1].Enabled = false;

                btns[row - 1, col - 1].PerformClick();
                btns[row - 1, col - 1].Enabled = false;

                btns[row - 1, col].PerformClick();
                btns[row - 1, col].Enabled = false;

                btns[row - 1, col + 1].PerformClick();
                btns[row - 1, col + 1].Enabled = false;

                btns[row + 1, col - 1].PerformClick();
                btns[row + 1, col - 1].Enabled = false;

                btns[row + 1, col].PerformClick();
                btns[row + 1, col].Enabled = false;

                btns[row + 1, col + 1].PerformClick();
                btns[row + 1, col + 1].Enabled = false;
            }
        }
       private void ForTheWin()
       {
           if (clicks == (r * c)-m)
           {
                   timer1.Stop();                  
               if(MessageBox.Show("You won! Continue?","Winner!",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
               {
                   selectLevel newf = new selectLevel();
                   this.Hide();
                   newf.ShowDialog();
                   this.Close();
               }
               else
               {
                   Application.Exit();
               }
           }
       }

       private void timer1_Tick(object sender, EventArgs e)
       {
               seconds++;
               lbl1.Text = string.Format("You have played for :");
               lblTime.Text = string.Format("{0} s", seconds).ToString();
           
       }

       private void changeLevelToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.Hide();
           selectLevel view = new selectLevel();
           view.ShowDialog();
           
       }

       private void pauseGameToolStripMenuItem_Click(object sender, EventArgs e)
       {
           cl++;
           timer1.Stop();
           pauseGameToolStripMenuItem.Text = "Resume";
           for (int i = 0; i < r; i++)
           {
               for (int j = 0; j < c; j++)
               {
                       buttons[i, j].Enabled = false;
               }
           }
           if(cl==2)
           {
               timer1.Start();
               pauseGameToolStripMenuItem.Text = "Pause Game";
               for (int i = 0; i < r; i++)
               {
                   for (int j = 0; j < c; j++)
                   {
                       if (pause[i, j] == true)
                       {
                           buttons[i, j].Enabled = false;
                       }
                       else
                       {
                           buttons[i, j].Enabled = true;
                       }
                   }
               }
               cl = 0;
           }

       }

       private void helpToolStripMenuItem_Click(object sender, EventArgs e)
       {
           System.Diagnostics.Process.Start("http://www.minesweeper.info/wiki/Strategy");
       }
      
    }
}
    



