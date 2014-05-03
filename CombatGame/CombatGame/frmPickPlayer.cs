using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatGame
{
    public partial class frmPickPlayer : Form
    {
        frmMenu MainMenu { get; set; } // formata roditel (MENU)
        frmFight Game;
        PPPBitmap bmBackground;
        public frmPickPlayer(frmMenu menu)
        {
            InitializeComponent();
            MainMenu = menu;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            bmBackground = new PPPBitmap(new Bitmap("backgroundMainMenu.jpg"), "backgroundMainMenu.jpg");

            pb1.BackColor = Color.Red;
            pb2.BackColor = Color.Red;
            pb3.BackColor = Color.Red;
            pb4.BackColor = Color.Red;
            pb1Parent.BackColor = Color.Yellow;
            pb2Parent.BackColor = Color.Green;
            pb3Parent.BackColor = Color.Transparent;
            pb4Parent.BackColor = Color.Transparent;
            Invalidate();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu.Show();
        }

        private void lblStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game = new frmFight();

            Game.Show();

        }

        private void frmPickPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void frmPickPlayer_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmBackground.Bitmap, 0, 0, this.Width, this.Height);
        }
    }
}
