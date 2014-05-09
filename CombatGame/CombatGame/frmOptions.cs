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
        public static bool musicOn = true; //da se proveri dali e true pred da se pusti muzika vo bilo koja forma
        public static bool soundOn = true; //da se proveri dali e true pred da se stavat efekti vo frmFight
        public int pickOption; //0 za Music, 1 za Sound, 2 za Back 
        

        public frmOptions(frmMenu menu)
        {
            InitializeComponent();
            MainMenu  = menu;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            optionsBackground = new PPPBitmap(new Bitmap("CombatGameBackground.gif"), "CombatGameBackground.gif");
            pickOption = 0;
            Invalidate();
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {
           // this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
           // this.WindowState = FormWindowState.Maximized;
            pickOption = 0;
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            pickOption = 0;
            changeParentPictureBox();
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

        //Menuva music od on vo off i obratno
        private void changeMusicOnOff()
        {
            if (musicOn)
            {
                pbMusic.Image = Image.FromFile("imgMusicOff.png");
                MainMenu.wplayer.controls.stop();
                musicOn = false;
            }
            else
            {
                pbMusic.Image = Image.FromFile("imgMusicOn.png");
                MainMenu.wplayer.controls.play();
                musicOn = true;
            }
        }


        private void changeSound(object sender, EventArgs e)
        {
            changeSoundOnOff();
        }

        private void frmOptions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                changeSelected(false);
            }
            else if (e.KeyCode == Keys.Up)
            {
                changeSelected(true);
            }
            else if (e.KeyCode == Keys.Left)
            {
                changeSelected(false);
            }
            else if (e.KeyCode == Keys.Right)
            {
                changeSelected(true);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                actOnEnter();
            }
        }

        private void actOnEnter()
        {
            if (pickOption == 0)
            {
                changeMusicOnOff();
            }
            if (pickOption == 1)
            {
                changeSoundOnOff();
            }
            if (pickOption == 2)
            {
                pickOption = 0;
                changeParentPictureBox();
                this.Hide();
                MainMenu.Show();
            }
        }

        //Go menuva pickOption i selektiraniot PictureBox
        private void changeSelected(bool up)
        {
            if (up)
            {
                pickOption--;
                pickOption = (pickOption + 3) % 3;
            }
            else
            {
                pickOption++;
                pickOption = pickOption % 3;
            }
            changeParentPictureBox();
        }

        //Go menuva selektiraniot PictureBox
        private void changeParentPictureBox()
        {
            pbParentBack.BackColor = Color.Transparent;
            pbParentMusic.BackColor = Color.Transparent;
            pbParentSound.BackColor = Color.Transparent;
            if (pickOption == 0)
            {
                pbParentMusic.BackColor = Color.Maroon;
            }
            if (pickOption == 1)
            {
                pbParentSound.BackColor = Color.Maroon;
            }
            if (pickOption == 2)
            {
                pbParentBack.BackColor = Color.Maroon;
            }
        }

        private void changeMusic(object sender, EventArgs e)
        {
            changeMusicOnOff();
        }

        //Menuva sound od on vo off i obratno
        private void changeSoundOnOff()
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
