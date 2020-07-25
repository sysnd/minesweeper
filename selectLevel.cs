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

        private void EasyPictureBox_Click(object sender, EventArgs e)
        {
            Main form = new Main(6,6,6);
            this.Hide();
            form.ShowDialog();
            this.Close();

        }

        private void MediumPictureBox_Click(object sender, EventArgs e)
        {
            Main form = new Main(8,8,20);
            this.Hide();
            form.ShowDialog();
            this.Close();

        }

        private void HardPictureBox_Click(object sender, EventArgs e)
        {
            Main form = new Main(10, 10, 35);
            this.Hide();
            form.ShowDialog();
            this.Close();

        }

        private void EasyLabel_Click(object sender, EventArgs e)
        {
            Main form = new Main(6, 6, 6);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void MediumLabel_Click(object sender, EventArgs e)
        {
            Main form = new Main(8, 8, 20);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void HardLabel_Click(object sender, EventArgs e)
        {
            Main form = new Main(10, 10, 35);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
