namespace Snehulak
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.background = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.openBacColor = new System.Windows.Forms.PictureBox();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.openSnowColor = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openBacColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openSnowColor)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.background.Location = new System.Drawing.Point(152, 12);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(636, 350);
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            this.background.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(21, 28);
            this.trackBar1.Maximum = 80;
            this.trackBar1.Minimum = 15;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 334);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TabStop = false;
            this.trackBar1.Value = 15;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // openBacColor
            // 
            this.openBacColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.openBacColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.openBacColor.Location = new System.Drawing.Point(31, 28);
            this.openBacColor.Name = "openBacColor";
            this.openBacColor.Size = new System.Drawing.Size(28, 25);
            this.openBacColor.TabIndex = 2;
            this.openBacColor.TabStop = false;
            this.openBacColor.Click += new System.EventHandler(this.openBacColor_Click);
            // 
            // openSnowColor
            // 
            this.openSnowColor.BackColor = System.Drawing.SystemColors.Control;
            this.openSnowColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.openSnowColor.Location = new System.Drawing.Point(15, 17);
            this.openSnowColor.Name = "openSnowColor";
            this.openSnowColor.Size = new System.Drawing.Size(28, 25);
            this.openSnowColor.TabIndex = 2;
            this.openSnowColor.TabStop = false;
            this.openSnowColor.Click += new System.EventHandler(this.openSnowColor_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.openSnowColor);
            this.panel1.Controls.Add(this.openBacColor);
            this.panel1.Location = new System.Drawing.Point(72, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(65, 71);
            this.panel1.TabIndex = 3;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(152, 378);
            this.trackBar2.Maximum = 300;
            this.trackBar2.Minimum = -300;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(636, 45);
            this.trackBar2.TabIndex = 4;
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.background);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openBacColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openSnowColor)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox openColor;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox openBacColor;
        private System.Windows.Forms.PictureBox openSnowColor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBar2;
    }
}

