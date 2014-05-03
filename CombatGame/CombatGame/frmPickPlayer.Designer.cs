namespace CombatGame
{
    partial class frmPickPlayer
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
            this.lblBack = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.pb1Parent = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb2Parent = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb3Parent = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb4Parent = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb1Parent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2Parent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3Parent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4Parent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Location = new System.Drawing.Point(38, 450);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(35, 13);
            this.lblBack.TabIndex = 0;
            this.lblBack.Text = "BACK";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(645, 450);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(43, 13);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "START";
            this.lblStart.Click += new System.EventHandler(this.lblStart_Click);
            // 
            // pb1Parent
            // 
            this.pb1Parent.Location = new System.Drawing.Point(29, 36);
            this.pb1Parent.Name = "pb1Parent";
            this.pb1Parent.Size = new System.Drawing.Size(184, 155);
            this.pb1Parent.TabIndex = 2;
            this.pb1Parent.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(41, 55);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(154, 119);
            this.pb1.TabIndex = 3;
            this.pb1.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(258, 55);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(154, 119);
            this.pb2.TabIndex = 5;
            this.pb2.TabStop = false;
            // 
            // pb2Parent
            // 
            this.pb2Parent.Location = new System.Drawing.Point(246, 36);
            this.pb2Parent.Name = "pb2Parent";
            this.pb2Parent.Size = new System.Drawing.Size(184, 155);
            this.pb2Parent.TabIndex = 4;
            this.pb2Parent.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(470, 55);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(154, 119);
            this.pb3.TabIndex = 7;
            this.pb3.TabStop = false;
            // 
            // pb3Parent
            // 
            this.pb3Parent.Location = new System.Drawing.Point(458, 36);
            this.pb3Parent.Name = "pb3Parent";
            this.pb3Parent.Size = new System.Drawing.Size(184, 155);
            this.pb3Parent.TabIndex = 6;
            this.pb3Parent.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.Location = new System.Drawing.Point(684, 55);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(154, 119);
            this.pb4.TabIndex = 9;
            this.pb4.TabStop = false;
            // 
            // pb4Parent
            // 
            this.pb4Parent.Location = new System.Drawing.Point(672, 36);
            this.pb4Parent.Name = "pb4Parent";
            this.pb4Parent.Size = new System.Drawing.Size(184, 155);
            this.pb4Parent.TabIndex = 8;
            this.pb4Parent.TabStop = false;
            // 
            // frmPickPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 482);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb4Parent);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb3Parent);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb2Parent);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.pb1Parent);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblBack);
            this.Name = "frmPickPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PICK A PLAYER";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPickPlayer_FormClosing);
            this.Load += new System.EventHandler(this.frmPickPlayer_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmPickPlayer_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pb1Parent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2Parent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3Parent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4Parent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.PictureBox pb1Parent;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb2Parent;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb3Parent;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb4Parent;
    }
}