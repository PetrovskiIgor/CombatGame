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
            this.pbPlayerOne = new System.Windows.Forms.PictureBox();
            this.pbPlayerTwo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlayerOne
            // 
            this.pbPlayerOne.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbPlayerOne.Location = new System.Drawing.Point(108, 308);
            this.pbPlayerOne.Name = "pbPlayerOne";
            this.pbPlayerOne.Size = new System.Drawing.Size(74, 95);
            this.pbPlayerOne.TabIndex = 0;
            this.pbPlayerOne.TabStop = false;
            // 
            // pbPlayerTwo
            // 
            this.pbPlayerTwo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbPlayerTwo.Location = new System.Drawing.Point(453, 308);
            this.pbPlayerTwo.Name = "pbPlayerTwo";
            this.pbPlayerTwo.Size = new System.Drawing.Size(70, 95);
            this.pbPlayerTwo.TabIndex = 1;
            this.pbPlayerTwo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(658, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(28, 46);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(173, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(520, 46);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(173, 23);
            this.progressBar2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // frmFight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 482);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;


    }
}