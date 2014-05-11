using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace CombatGame
{
    public partial class frmMenu : Form
    {
        frmPickPlayer fPickPlayer;
        frmOptions fOptions;
        PPPBitmap bmBackground;
        int pickAForm; // 0 znachi na enter da se selektira NewGame, 1 Options, 2 Exit

        Image imgNewGame = Image.FromFile("imgNewGame2.png");
       

        Image imgOptions = Image.FromFile("imgOptions2.png");

        Image imgExit = Image.FromFile("imgExit.png");
        public WindowsMediaPlayer wplayer;
        public IWMPPlaylist playlistMenu;
        public IWMPPlaylist playlistFight;

        public frmMenu()
        {
            InitializeComponent();
          

            bmBackground = new PPPBitmap(new Bitmap("CombatGameBackground.gif"), "CombatGameBackground.gif");
            
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
           // this.pbNewGame.Image = imgNewGameSelected;
            wplayer = new WindowsMediaPlayer();
            playlistMenu = wplayer.playlistCollection.newPlaylist("Playlist Menu");
            playlistFight = wplayer.playlistCollection.newPlaylist("Playlist Fight");
            playlistMenu.appendItem(wplayer.newMedia("Eye Of The Tiger Instrumental.mp3"));
            playlistFight.appendItem(wplayer.newMedia("Hardest Gangsta beat ever.mp3"));
            wplayer.currentPlaylist = playlistMenu;
            wplayer.settings.setMode("loop", true);
            wplayer.controls.play();

            pickAForm = 0;
            Invalidate();
            
           
        }

        private void lblNewGame_Click(object sender, EventArgs e)
        {
            
           
        }

        private void lblOptions_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void frmMenu_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            e.Graphics.DrawImage(bmBackground.Bitmap, 0, 0, this.Width, this.Height);
        }

        private void pbOptions_Click(object sender, EventArgs e)
        {
            if(fOptions == null)
                fOptions = new frmOptions(this);
            this.Hide();
            fOptions.Show();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbNewGame_Click(object sender, EventArgs e)
        {
            //if(fPickPlayer == null)
                fPickPlayer = new frmPickPlayer(this);
            this.Hide();
            fPickPlayer.Show();
        }

        private void frmMenu_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

       

       
        private void selectForm(Boolean up)
        {
            if (up)
            {
                if (pickAForm == 0)
                {
                    pickAForm = 2;
                }
                else
                {
                    pickAForm--;
                }
            }
            else
            {
                pickAForm = (pickAForm + 1) % 3;
            }
            
            pbNewGame.Image = imgNewGame;
            pbOptions.Image = imgOptions;
            pbExit.Image = imgExit;


            pbNewGameSel.BackColor = Color.Transparent;
            pbOptionsSel.BackColor = Color.Transparent;
            pbExitSel.BackColor = Color.Transparent;

            if (pickAForm == 0)
            {
                
                pbNewGameSel.BackColor = Color.Maroon;
            }
            else if (pickAForm == 1)
            {
                
                pbOptionsSel.BackColor = Color.Maroon;
            }
            else if (pickAForm == 2)
            {
                
                pbExitSel.BackColor = Color.Maroon;
            }
            else
            {
                // ne smee da vleze ovde
                MessageBox.Show("IMA GRESHKAA!!!");
            }
        }

        

        private void frmMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                actOnEnter();
                
            }
           if (e.KeyCode == Keys.Up)
            {
                selectForm(true); 

            }
            else if (e.KeyCode == Keys.Down)
            {
                selectForm(false); 
            }
            else if (e.KeyCode == Keys.Left)
            {
                selectForm(true);
            }
            else if (e.KeyCode == Keys.Right)
            {
                selectForm(false); 
            }
        }

        


        private void actOnEnter()
        {
            if (pickAForm == 0)
            {
               
                    fPickPlayer = new frmPickPlayer(this);
                
                this.Hide();
                fPickPlayer.Show();
            }
            else if (pickAForm == 1)
            {
                if (fOptions == null)
                {
                    fOptions = new frmOptions(this);
                }
                this.Hide();
                fOptions.Show();
            }
            else if (pickAForm == 2)
            {
                this.Close();
            }
        }
       

        

        
    }
}
