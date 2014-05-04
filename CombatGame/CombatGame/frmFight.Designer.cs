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
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlayerOne
            // 
            this.pbPlayerOne.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbPlayerOne.Location = new System.Drawing.Point(534, 356);
            this.pbPlayerOne.Name = "pbPlayerOne";
            this.pbPlayerOne.Size = new System.Drawing.Size(74, 95);
            this.pbPlayerOne.TabIndex = 0;
            this.pbPlayerOne.TabStop = false;
            // 
            // pbPlayerTwo
            // 
            this.pbPlayerTwo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbPlayerTwo.Image = ((System.Drawing.Image)(resources.GetObject("pbPlayerTwo.Image")));
            this.pbPlayerTwo.Location = new System.Drawing.Point(86, 227);
            this.pbPlayerTwo.Name = "pbPlayerTwo";
            this.pbPlayerTwo.Size = new System.Drawing.Size(243, 348);
            this.pbPlayerTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayerTwo.TabIndex = 1;
            this.pbPlayerTwo.TabStop = false;
            // 
            // lblPlayerOneName
            // 
            this.lblPlayerOneName.AutoSize = true;
            this.lblPlayerOneName.Location = new System.Drawing.Point(643, 19);
            this.lblPlayerOneName.Name = "lblPlayerOneName";
            this.lblPlayerOneName.Size = new System.Drawing.Size(35, 13);
            this.lblPlayerOneName.TabIndex = 2;
            this.lblPlayerOneName.Text = "label1";
            // 
            // lblPlayerTwoName
            // 
            this.lblPlayerTwoName.AutoSize = true;
            this.lblPlayerTwoName.Location = new System.Drawing.Point(46, 19);
            this.lblPlayerTwoName.Name = "lblPlayerTwoName";
            this.lblPlayerTwoName.Size = new System.Drawing.Size(35, 13);
            this.lblPlayerTwoName.TabIndex = 3;
            this.lblPlayerTwoName.Text = "label2";
            // 
            // pbarPlayerOne
            // 
            this.pbarPlayerOne.Location = new System.Drawing.Point(521, 46);
            this.pbarPlayerOne.Name = "pbarPlayerOne";
            this.pbarPlayerOne.Size = new System.Drawing.Size(173, 23);
            this.pbarPlayerOne.TabIndex = 4;
            // 
            // pbarPlayerTwo
            // 
            this.pbarPlayerTwo.Location = new System.Drawing.Point(49, 46);
            this.pbarPlayerTwo.Name = "pbarPlayerTwo";
            this.pbarPlayerTwo.Size = new System.Drawing.Size(173, 23);
            this.pbarPlayerTwo.TabIndex = 5;
            // 
            // lblHelthPlayerOne
            // 
            this.lblHelthPlayerOne.AutoSize = true;
            this.lblHelthPlayerOne.Location = new System.Drawing.Point(470, 56);
            this.lblHelthPlayerOne.Name = "lblHelthPlayerOne";
            this.lblHelthPlayerOne.Size = new System.Drawing.Size(35, 13);
            this.lblHelthPlayerOne.TabIndex = 6;
            this.lblHelthPlayerOne.Text = "label3";
            // 
            // lblHealthPlayerTwo
            // 
            this.lblHealthPlayerTwo.AutoSize = true;
            this.lblHealthPlayerTwo.Location = new System.Drawing.Point(244, 56);
            this.lblHealthPlayerTwo.Name = "lblHealthPlayerTwo";
            this.lblHealthPlayerTwo.Size = new System.Drawing.Size(35, 13);
            this.lblHealthPlayerTwo.TabIndex = 7;
            this.lblHealthPlayerTwo.Text = "label4";
            // 
            // frmFight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 607);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFight_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFight_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmFight_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerTwo)).EndInit();
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


    }
}