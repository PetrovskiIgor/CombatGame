namespace CombatGame
{
    partial class frmMenu
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
            this.lblNewGame = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNewGame
            // 
            this.lblNewGame.BackColor = System.Drawing.Color.Transparent;
            this.lblNewGame.Location = new System.Drawing.Point(144, 142);
            this.lblNewGame.Name = "lblNewGame";
            this.lblNewGame.Size = new System.Drawing.Size(446, 52);
            this.lblNewGame.TabIndex = 0;
            this.lblNewGame.Text = "NEW GAME";
            this.lblNewGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNewGame.Click += new System.EventHandler(this.lblNewGame_Click);
            // 
            // lblOptions
            // 
            this.lblOptions.BackColor = System.Drawing.Color.Transparent;
            this.lblOptions.Location = new System.Drawing.Point(144, 223);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(446, 52);
            this.lblOptions.TabIndex = 1;
            this.lblOptions.Text = "OPTIONS";
            this.lblOptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOptions.Click += new System.EventHandler(this.lblOptions_Click);
            // 
            // lblExit
            // 
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Location = new System.Drawing.Point(144, 324);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(446, 52);
            this.lblExit.TabIndex = 2;
            this.lblExit.Text = "EXIT";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 482);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.lblNewGame);
            this.DoubleBuffered = true;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "x";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMenu_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNewGame;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Label lblExit;

    }
}

