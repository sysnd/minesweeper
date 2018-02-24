using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minesweeper1
{
    public partial class selectLevel : Form
    {

        public selectLevel()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Main form = new Main(6,6,6);
            this.Hide();
            form.ShowDialog();
            this.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Main form = new Main(8,8,20);
            this.Hide();
            form.ShowDialog();
            this.Close();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Main form = new Main(10, 10, 35);
            this.Hide();
            form.ShowDialog();
            this.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Main form = new Main(6, 6, 6);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Main form = new Main(8, 8, 20);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Main form = new Main(10, 10, 35);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
