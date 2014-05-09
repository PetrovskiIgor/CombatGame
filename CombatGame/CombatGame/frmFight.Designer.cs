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
            this.lblPlayerOneName = new System.Windows.Forms.Label();
            this.lblPlayerTwoName = new System.Windows.Forms.Label();
            this.lblHelthPlayerOne = new System.Windows.Forms.Label();
            this.lblHealthPlayerTwo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPlayerOneName
            // 
            this.lblPlayerOneName.AutoSize = true;
            this.lblPlayerOneName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerOneName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerOneName.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblPlayerOneName.Location = new System.Drawing.Point(877, 19);
            this.lblPlayerOneName.Name = "lblPlayerOneName";
            this.lblPlayerOneName.Size = new System.Drawing.Size(70, 25);
            this.lblPlayerOneName.TabIndex = 2;
            this.lblPlayerOneName.Text = "label1";
            // 
            // lblPlayerTwoName
            // 
            this.lblPlayerTwoName.AutoSize = true;
            this.lblPlayerTwoName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerTwoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTwoName.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblPlayerTwoName.Location = new System.Drawing.Point(163, 19);
            this.lblPlayerTwoName.Name = "lblPlayerTwoName";
            this.lblPlayerTwoName.Size = new System.Drawing.Size(70, 25);
            this.lblPlayerTwoName.TabIndex = 3;
            this.lblPlayerTwoName.Text = "label2";
            // 
            // lblHelthPlayerOne
            // 
            this.lblHelthPlayerOne.AutoSize = true;
            this.lblHelthPlayerOne.BackColor = System.Drawing.Color.Transparent;
            this.lblHelthPlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelthPlayerOne.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblHelthPlayerOne.Location = new System.Drawing.Point(1222, 56);
            this.lblHelthPlayerOne.Name = "lblHelthPlayerOne";
            this.lblHelthPlayerOne.Size = new System.Drawing.Size(70, 25);
            this.lblHelthPlayerOne.TabIndex = 6;
            this.lblHelthPlayerOne.Text = "label3";
            // 
            // lblHealthPlayerTwo
            // 
            this.lblHealthPlayerTwo.AutoSize = true;
            this.lblHealthPlayerTwo.BackColor = System.Drawing.Color.Transparent;
            this.lblHealthPlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealthPlayerTwo.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblHealthPlayerTwo.Location = new System.Drawing.Point(516, 56);
            this.lblHealthPlayerTwo.Name = "lblHealthPlayerTwo";
            this.lblHealthPlayerTwo.Size = new System.Drawing.Size(70, 25);
            this.lblHealthPlayerTwo.TabIndex = 7;
            this.lblHealthPlayerTwo.Text = "label4";
            // 
            // frmFight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1370, 709);
            this.Controls.Add(this.lblHealthPlayerTwo);
            this.Controls.Add(this.lblHelthPlayerOne);
            this.Controls.Add(this.lblPlayerTwoName);
            this.Controls.Add(this.lblPlayerOneName);
            this.Name = "frmFight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combat Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFight_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmFight_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFight_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmFight_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerOneName;
        private System.Windows.Forms.Label lblPlayerTwoName;
        private System.Windows.Forms.Label lblHelthPlayerOne;
        private System.Windows.Forms.Label lblHealthPlayerTwo;


    }
}