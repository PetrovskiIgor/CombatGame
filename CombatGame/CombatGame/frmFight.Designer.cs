namespace CombatGame
{
    partial class frmFight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFight));
            this.pbPlayerOne = new System.Windows.Forms.PictureBox();
            this.pbPlayerTwo = new System.Windows.Forms.PictureBox();
            this.lblPlayerOneName = new System.Windows.Forms.Label();
            this.lblPlayerTwoName = new System.Windows.Forms.Label();
            this.pbarPlayerOne = new System.Windows.Forms.ProgressBar();
            this.pbarPlayerTwo = new System.Windows.Forms.ProgressBar();
            this.lblHelthPlayerOne = new System.Windows.Forms.Label();
            this.lblHealthPlayerTwo = new System.Windows.Forms.Label();
            this.pbMagic2 = new System.Windows.Forms.PictureBox();
            this.pbMagic1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMagic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMagic1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlayerOne
            // 
            this.pbPlayerOne.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbPlayerOne.Image = ((System.Drawing.Image)(resources.GetObject("pbPlayerOne.Image")));
            this.pbPlayerOne.Location = new System.Drawing.Point(661, 393);
            this.pbPlayerOne.Name = "pbPlayerOne";
            this.pbPlayerOne.Size = new System.Drawing.Size(116, 184);
            this.pbPlayerOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayerOne.TabIndex = 0;
            this.pbPlayerOne.TabStop = false;
            // 
            // pbPlayerTwo
            // 
            this.pbPlayerTwo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbPlayerTwo.Image = ((System.Drawing.Image)(resources.GetObject("pbPlayerTwo.Image")));
            this.pbPlayerTwo.Location = new System.Drawing.Point(127, 393);
            this.pbPlayerTwo.Name = "pbPlayerTwo";
            this.pbPlayerTwo.Size = new System.Drawing.Size(83, 184);
            this.pbPlayerTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayerTwo.TabIndex = 1;
            this.pbPlayerTwo.TabStop = false;
            // 
            // lblPlayerOneName
            // 
            this.lblPlayerOneName.AutoSize = true;
            this.lblPlayerOneName.Location = new System.Drawing.Point(877, 19);
            this.lblPlayerOneName.Name = "lblPlayerOneName";
            this.lblPlayerOneName.Size = new System.Drawing.Size(35, 13);
            this.lblPlayerOneName.TabIndex = 2;
            this.lblPlayerOneName.Text = "label1";
            // 
            // lblPlayerTwoName
            // 
            this.lblPlayerTwoName.AutoSize = true;
            this.lblPlayerTwoName.Location = new System.Drawing.Point(163, 19);
            this.lblPlayerTwoName.Name = "lblPlayerTwoName";
            this.lblPlayerTwoName.Size = new System.Drawing.Size(35, 13);
            this.lblPlayerTwoName.TabIndex = 3;
            this.lblPlayerTwoName.Text = "label2";
            // 
            // pbarPlayerOne
            // 
            this.pbarPlayerOne.Location = new System.Drawing.Point(755, 46);
            this.pbarPlayerOne.Name = "pbarPlayerOne";
            this.pbarPlayerOne.Size = new System.Drawing.Size(461, 56);
            this.pbarPlayerOne.TabIndex = 4;
            // 
            // pbarPlayerTwo
            // 
            this.pbarPlayerTwo.Location = new System.Drawing.Point(49, 46);
            this.pbarPlayerTwo.Name = "pbarPlayerTwo";
            this.pbarPlayerTwo.Size = new System.Drawing.Size(461, 56);
            this.pbarPlayerTwo.TabIndex = 5;
            // 
            // lblHelthPlayerOne
            // 
            this.lblHelthPlayerOne.AutoSize = true;
            this.lblHelthPlayerOne.Location = new System.Drawing.Point(1222, 56);
            this.lblHelthPlayerOne.Name = "lblHelthPlayerOne";
            this.lblHelthPlayerOne.Size = new System.Drawing.Size(35, 13);
            this.lblHelthPlayerOne.TabIndex = 6;
            this.lblHelthPlayerOne.Text = "label3";
            // 
            // lblHealthPlayerTwo
            // 
            this.lblHealthPlayerTwo.AutoSize = true;
            this.lblHealthPlayerTwo.Location = new System.Drawing.Point(516, 56);
            this.lblHealthPlayerTwo.Name = "lblHealthPlayerTwo";
            this.lblHealthPlayerTwo.Size = new System.Drawing.Size(35, 13);
            this.lblHealthPlayerTwo.TabIndex = 7;
            this.lblHealthPlayerTwo.Text = "label4";
            // 
            // pbMagic2
            // 
            this.pbMagic2.BackColor = System.Drawing.Color.Transparent;
            this.pbMagic2.Image = ((System.Drawing.Image)(resources.GetObject("pbMagic2.Image")));
            this.pbMagic2.Location = new System.Drawing.Point(428, 334);
            this.pbMagic2.Name = "pbMagic2";
            this.pbMagic2.Size = new System.Drawing.Size(100, 75);
            this.pbMagic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMagic2.TabIndex = 8;
            this.pbMagic2.TabStop = false;
            // 
            // pbMagic1
            // 
            this.pbMagic1.BackColor = System.Drawing.Color.Transparent;
            this.pbMagic1.Image = ((System.Drawing.Image)(resources.GetObject("pbMagic1.Image")));
            this.pbMagic1.Location = new System.Drawing.Point(216, 334);
            this.pbMagic1.Name = "pbMagic1";
            this.pbMagic1.Size = new System.Drawing.Size(100, 75);
            this.pbMagic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMagic1.TabIndex = 9;
            this.pbMagic1.TabStop = false;
            // 
            // frmFight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1370, 709);
            this.Controls.Add(this.pbMagic1);
            this.Controls.Add(this.pbMagic2);
            this.Controls.Add(this.lblHealthPlayerTwo);
            this.Controls.Add(this.lblHelthPlayerOne);
            this.Controls.Add(this.pbarPlayerTwo);
            this.Controls.Add(this.pbarPlayerOne);
            this.Controls.Add(this.lblPlayerTwoName);
            this.Controls.Add(this.lblPlayerOneName);
            this.Controls.Add(this.pbPlayerTwo);
            this.Controls.Add(this.pbPlayerOne);
            this.Name = "frmFight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combat Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFight_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFight_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmFight_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMagic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMagic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlayerOne;
        private System.Windows.Forms.PictureBox pbPlayerTwo;
        private System.Windows.Forms.Label lblPlayerOneName;
        private System.Windows.Forms.Label lblPlayerTwoName;
        private System.Windows.Forms.ProgressBar pbarPlayerOne;
        private System.Windows.Forms.ProgressBar pbarPlayerTwo;
        private System.Windows.Forms.Label lblHelthPlayerOne;
        private System.Windows.Forms.Label lblHealthPlayerTwo;
        private System.Windows.Forms.PictureBox pbMagic2;
        private System.Windows.Forms.PictureBox pbMagic1;


    }
}