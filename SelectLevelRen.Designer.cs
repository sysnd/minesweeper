namespace Minesweeper
{
    partial class SelectLevelRen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectLevelRen));
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.EasyPictureBox = new System.Windows.Forms.PictureBox();
            this.MediumPictureBox = new System.Windows.Forms.PictureBox();
            this.HardPictureBox = new System.Windows.Forms.PictureBox();
            this.EasyLabel = new System.Windows.Forms.Label();
            this.MediumLabel = new System.Windows.Forms.Label();
            this.HardLabel = new System.Windows.Forms.Label();
            this.EasyFieldSizeLabel = new System.Windows.Forms.Label();
            this.EasyMinesLabel = new System.Windows.Forms.Label();
            this.MediumMinesLabel = new System.Windows.Forms.Label();
            this.MediumFieldSizeLabel = new System.Windows.Forms.Label();
            this.HardMinesLabel = new System.Windows.Forms.Label();
            this.HardFieldSizeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EasyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediumPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HardPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLabel.Font = new System.Drawing.Font("Modern No. 20", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.White;
            this.WelcomeLabel.Location = new System.Drawing.Point(228, 26);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(462, 34);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome! Please choose a level!";
            // 
            // EasyPictureBox
            // 
            this.EasyPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.EasyPictureBox.Image = global::Minesweeper.Properties.Resources.Bomb_SelectLevel;
            this.EasyPictureBox.Location = new System.Drawing.Point(5, 105);
            this.EasyPictureBox.Name = "EasyPictureBox";
            this.EasyPictureBox.Size = new System.Drawing.Size(259, 258);
            this.EasyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EasyPictureBox.TabIndex = 1;
            this.EasyPictureBox.TabStop = false;
            this.EasyPictureBox.Click += new System.EventHandler(this.EasyPictureBox_Click);
            // 
            // MediumPictureBox
            // 
            this.MediumPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.MediumPictureBox.Image = global::Minesweeper.Properties.Resources.Bomb_SelectLevel;
            this.MediumPictureBox.Location = new System.Drawing.Point(309, 105);
            this.MediumPictureBox.Name = "MediumPictureBox";
            this.MediumPictureBox.Size = new System.Drawing.Size(259, 258);
            this.MediumPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MediumPictureBox.TabIndex = 2;
            this.MediumPictureBox.TabStop = false;
            this.MediumPictureBox.Click += new System.EventHandler(this.MediumPictureBox_Click);
            // 
            // HardPictureBox
            // 
            this.HardPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.HardPictureBox.Image = global::Minesweeper.Properties.Resources.Bomb_SelectLevel;
            this.HardPictureBox.Location = new System.Drawing.Point(632, 105);
            this.HardPictureBox.Name = "HardPictureBox";
            this.HardPictureBox.Size = new System.Drawing.Size(259, 258);
            this.HardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HardPictureBox.TabIndex = 3;
            this.HardPictureBox.TabStop = false;
            this.HardPictureBox.Click += new System.EventHandler(this.HardPictureBox_Click);
            // 
            // EasyLabel
            // 
            this.EasyLabel.AutoSize = true;
            this.EasyLabel.BackColor = System.Drawing.Color.Navy;
            this.EasyLabel.Font = new System.Drawing.Font("Viner Hand ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EasyLabel.ForeColor = System.Drawing.Color.White;
            this.EasyLabel.Location = new System.Drawing.Point(13, 256);
            this.EasyLabel.Name = "EasyLabel";
            this.EasyLabel.Size = new System.Drawing.Size(88, 45);
            this.EasyLabel.TabIndex = 4;
            this.EasyLabel.Text = "Easy";
            this.EasyLabel.Click += new System.EventHandler(this.EasyLabel_Click);
            // 
            // MediumLabel
            // 
            this.MediumLabel.AutoSize = true;
            this.MediumLabel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.MediumLabel.Font = new System.Drawing.Font("Viner Hand ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediumLabel.ForeColor = System.Drawing.Color.White;
            this.MediumLabel.Location = new System.Drawing.Point(317, 256);
            this.MediumLabel.Name = "MediumLabel";
            this.MediumLabel.Size = new System.Drawing.Size(130, 45);
            this.MediumLabel.TabIndex = 5;
            this.MediumLabel.Text = "Medium";
            this.MediumLabel.Click += new System.EventHandler(this.MediumLabel_Click);
            // 
            // HardLabel
            // 
            this.HardLabel.AutoSize = true;
            this.HardLabel.Font = new System.Drawing.Font("Viner Hand ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HardLabel.ForeColor = System.Drawing.Color.White;
            this.HardLabel.Location = new System.Drawing.Point(640, 256);
            this.HardLabel.Name = "HardLabel";
            this.HardLabel.Size = new System.Drawing.Size(90, 45);
            this.HardLabel.TabIndex = 6;
            this.HardLabel.Text = "Hard";
            this.HardLabel.Click += new System.EventHandler(this.HardLabel_Click);
            // 
            // EasyFieldSizeLabel
            // 
            this.EasyFieldSizeLabel.AutoSize = true;
            this.EasyFieldSizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.EasyFieldSizeLabel.Font = new System.Drawing.Font("Modern No. 20", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EasyFieldSizeLabel.ForeColor = System.Drawing.Color.White;
            this.EasyFieldSizeLabel.Location = new System.Drawing.Point(1, 392);
            this.EasyFieldSizeLabel.Name = "EasyFieldSizeLabel";
            this.EasyFieldSizeLabel.Size = new System.Drawing.Size(124, 21);
            this.EasyFieldSizeLabel.TabIndex = 7;
            this.EasyFieldSizeLabel.Text = "Field Size: 6x6";
            // 
            // EasyMinesLabel
            // 
            this.EasyMinesLabel.AutoSize = true;
            this.EasyMinesLabel.BackColor = System.Drawing.Color.Transparent;
            this.EasyMinesLabel.Font = new System.Drawing.Font("Modern No. 20", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EasyMinesLabel.ForeColor = System.Drawing.Color.White;
            this.EasyMinesLabel.Location = new System.Drawing.Point(2, 413);
            this.EasyMinesLabel.Name = "EasyMinesLabel";
            this.EasyMinesLabel.Size = new System.Drawing.Size(84, 21);
            this.EasyMinesLabel.TabIndex = 8;
            this.EasyMinesLabel.Text = "Mines: 10";
            // 
            // MediumMinesLabel
            // 
            this.MediumMinesLabel.AutoSize = true;
            this.MediumMinesLabel.BackColor = System.Drawing.Color.Transparent;
            this.MediumMinesLabel.Font = new System.Drawing.Font("Modern No. 20", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediumMinesLabel.ForeColor = System.Drawing.Color.White;
            this.MediumMinesLabel.Location = new System.Drawing.Point(305, 413);
            this.MediumMinesLabel.Name = "MediumMinesLabel";
            this.MediumMinesLabel.Size = new System.Drawing.Size(84, 21);
            this.MediumMinesLabel.TabIndex = 10;
            this.MediumMinesLabel.Text = "Mines: 30";
            // 
            // MediumFieldSizeLabel
            // 
            this.MediumFieldSizeLabel.AutoSize = true;
            this.MediumFieldSizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.MediumFieldSizeLabel.Font = new System.Drawing.Font("Modern No. 20", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediumFieldSizeLabel.ForeColor = System.Drawing.Color.White;
            this.MediumFieldSizeLabel.Location = new System.Drawing.Point(304, 392);
            this.MediumFieldSizeLabel.Name = "MediumFieldSizeLabel";
            this.MediumFieldSizeLabel.Size = new System.Drawing.Size(124, 21);
            this.MediumFieldSizeLabel.TabIndex = 9;
            this.MediumFieldSizeLabel.Text = "Field Size: 8x8";
            // 
            // HardMinesLabel
            // 
            this.HardMinesLabel.AutoSize = true;
            this.HardMinesLabel.BackColor = System.Drawing.Color.Transparent;
            this.HardMinesLabel.Font = new System.Drawing.Font("Modern No. 20", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HardMinesLabel.ForeColor = System.Drawing.Color.White;
            this.HardMinesLabel.Location = new System.Drawing.Point(629, 413);
            this.HardMinesLabel.Name = "HardMinesLabel";
            this.HardMinesLabel.Size = new System.Drawing.Size(84, 21);
            this.HardMinesLabel.TabIndex = 12;
            this.HardMinesLabel.Text = "Mines: 55";
            // 
            // HardFieldSizeLabel
            // 
            this.HardFieldSizeLabel.AutoSize = true;
            this.HardFieldSizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.HardFieldSizeLabel.Font = new System.Drawing.Font("Modern No. 20", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HardFieldSizeLabel.ForeColor = System.Drawing.Color.White;
            this.HardFieldSizeLabel.Location = new System.Drawing.Point(628, 392);
            this.HardFieldSizeLabel.Name = "HardFieldSizeLabel";
            this.HardFieldSizeLabel.Size = new System.Drawing.Size(142, 21);
            this.HardFieldSizeLabel.TabIndex = 11;
            this.HardFieldSizeLabel.Text = "Field Size: 10x10";
            // 
            // SelectLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 464);
            this.Controls.Add(this.HardMinesLabel);
            this.Controls.Add(this.HardFieldSizeLabel);
            this.Controls.Add(this.MediumMinesLabel);
            this.Controls.Add(this.MediumFieldSizeLabel);
            this.Controls.Add(this.EasyMinesLabel);
            this.Controls.Add(this.EasyFieldSizeLabel);
            this.Controls.Add(this.HardLabel);
            this.Controls.Add(this.MediumLabel);
            this.Controls.Add(this.EasyLabel);
            this.Controls.Add(this.HardPictureBox);
            this.Controls.Add(this.MediumPictureBox);
            this.Controls.Add(this.EasyPictureBox);
            this.Controls.Add(this.WelcomeLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectLevel";
            this.Text = "Select Level";
            ((System.ComponentModel.ISupportInitialize)(this.EasyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediumPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HardPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.PictureBox MediumPictureBox;
        private System.Windows.Forms.PictureBox HardPictureBox;
        private System.Windows.Forms.Label EasyLabel;
        private System.Windows.Forms.Label MediumLabel;
        private System.Windows.Forms.Label HardLabel;
        private System.Windows.Forms.Label EasyFieldSizeLabel;
        private System.Windows.Forms.Label EasyMinesLabel;
        private System.Windows.Forms.Label MediumMinesLabel;
        private System.Windows.Forms.Label MediumFieldSizeLabel;
        private System.Windows.Forms.Label HardMinesLabel;
        private System.Windows.Forms.Label HardFieldSizeLabel;
        private System.Windows.Forms.PictureBox EasyPictureBox;
    }
}