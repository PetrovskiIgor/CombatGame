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
            // frmFight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 482);
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

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlayerOne;
        private System.Windows.Forms.PictureBox pbPlayerTwo;


    }
}