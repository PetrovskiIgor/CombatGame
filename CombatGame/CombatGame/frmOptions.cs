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
    public partial class frmOptions : Form
    {
        public frmMenu MainMenu {get; set;} // ova e formata roditel (Menu)
        PPPBitmap optionsBackground;
        public static bool musicOn; //da se proveri dali e true pred da se pusti muzika vo bilo koja forma
        public static bool soundOn; //da se proveri dali e true pred da se stavat efekti vo frmFight

        public frmOptions(frmMenu menu)
        {
            InitializeComponent();
            MainMenu  = menu;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            optionsBackground = new PPPBitmap(new Bitmap("backgroundMainMenu.jpg"), "backgroundMainMenu.jpg");
            musicOn = true;
            soundOn = true;
            Invalidate();
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {

        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu.Show();
        }

        private void frmOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmOptions_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            e.Graphics.DrawImage(this.optionsBackground.Bitmap, 0, 0, this.Width, this.Height);
        }

        private void frmOptionsResize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void changeMusicOnOff(object sender, EventArgs e)
        {
            if (musicOn)
            {
                pbMusic.Image = Image.FromFile("imgMusicOff.png");
                musicOn = false;
            }
            else
            {
                pbMusic.Image = Image.FromFile("imgMusicOn.png");
                musicOn = true;
            }
        }

        private void changeSound(object sender, EventArgs e)
        {
            if (soundOn)
            {
                pbSound.Image = Image.FromFile("imgSoundOff.png");
                soundOn = false;
            }
            else
            {
                pbSound.Image = Image.FromFile("imgSoundOn.png");
                soundOn = true;

            }
        }
    }
}
