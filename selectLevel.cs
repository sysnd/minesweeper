using System;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class SelectLevel : Form
    {

        public SelectLevel()
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
