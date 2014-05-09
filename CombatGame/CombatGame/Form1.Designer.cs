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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.pbNewGame = new System.Windows.Forms.PictureBox();
            this.pbOptions = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pbNewGameSel = new System.Windows.Forms.PictureBox();
            this.pbOptionsSel = new System.Windows.Forms.PictureBox();
            this.pbExitSel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewGameSel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOptionsSel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExitSel)).BeginInit();
            this.SuspendLayout();
            // 
            // pbNewGame
            // 
            this.pbNewGame.Image = ((System.Drawing.Image)(resources.GetObject("pbNewGame.Image")));
            this.pbNewGame.Location = new System.Drawing.Point(522, 140);
            this.pbNewGame.Name = "pbNewGame";
            this.pbNewGame.Size = new System.Drawing.Size(249, 68);
            this.pbNewGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNewGame.TabIndex = 3;
            this.pbNewGame.TabStop = false;
            this.pbNewGame.Click += new System.EventHandler(this.pbNewGame_Click);
            // 
            // pbOptions
            // 
            this.pbOptions.Image = ((System.Drawing.Image)(resources.GetObject("pbOptions.Image")));
            this.pbOptions.Location = new System.Drawing.Point(522, 235);
            this.pbOptions.Name = "pbOptions";
            this.pbOptions.Size = new System.Drawing.Size(249, 68);
            this.pbOptions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOptions.TabIndex = 4;
            this.pbOptions.TabStop = false;
            this.pbOptions.Click += new System.EventHandler(this.pbOptions_Click);
            // 
            // pbExit
            // 
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(522, 334);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(249, 68);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExit.TabIndex = 5;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // pbNewGameSel
            // 
            this.pbNewGameSel.BackColor = System.Drawing.Color.Maroon;
            this.pbNewGameSel.Location = new System.Drawing.Point(506, 128);
            this.pbNewGameSel.Name = "pbNewGameSel";
            this.pbNewGameSel.Size = new System.Drawing.Size(278, 91);
            this.pbNewGameSel.TabIndex = 6;
            this.pbNewGameSel.TabStop = false;
            // 
            // pbOptionsSel
            // 
            this.pbOptionsSel.BackColor = System.Drawing.Color.Transparent;
            this.pbOptionsSel.Location = new System.Drawing.Point(506, 225);
            this.pbOptionsSel.Name = "pbOptionsSel";
            this.pbOptionsSel.Size = new System.Drawing.Size(278, 91);
            this.pbOptionsSel.TabIndex = 7;
            this.pbOptionsSel.TabStop = false;
            // 
            // pbExitSel
            // 
            this.pbExitSel.BackColor = System.Drawing.Color.Transparent;
            this.pbExitSel.Location = new System.Drawing.Point(506, 322);
            this.pbExitSel.Name = "pbExitSel";
            this.pbExitSel.Size = new System.Drawing.Size(278, 91);
            this.pbExitSel.TabIndex = 8;
            this.pbExitSel.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 606);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.pbOptions);
            this.Controls.Add(this.pbNewGame);
            this.Controls.Add(this.pbNewGameSel);
            this.Controls.Add(this.pbExitSel);
            this.Controls.Add(this.pbOptionsSel);
            this.DoubleBuffered = true;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "x";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMenu_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMenu_KeyDown);
            this.Resize += new System.EventHandler(this.frmMenu_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbNewGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewGameSel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOptionsSel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExitSel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbNewGame;
        private System.Windows.Forms.PictureBox pbOptions;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pbNewGameSel;
        private System.Windows.Forms.PictureBox pbOptionsSel;
        private System.Windows.Forms.PictureBox pbExitSel;

    }
}

