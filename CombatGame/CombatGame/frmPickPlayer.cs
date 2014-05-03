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
        bool[] takenPb;
        int numPlayers;

        Player[] players;
        Magic[] magicTricks;
        int currPosFirst;
        int currPosSec;


        public frmPickPlayer(frmMenu menu)
        {
            InitializeComponent();
            MainMenu = menu;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            bmBackground = new PPPBitmap(new Bitmap("backgroundMainMenu.jpg"), "backgroundMainMenu.jpg");
            numPlayers = 4;

            takenPb = new bool[numPlayers];
            players = new Player[numPlayers];
            magicTricks = new Magic[numPlayers * 3];

            takenPb[0] = takenPb[1] = true;
            currPosFirst = 0;
            currPosSec = 1;

            for (int i = 2; i < numPlayers; i++)
            {
                takenPb[i] = false;
            }

            for (int i = 0; i < numPlayers * 3; i++)
            {
                magicTricks[i] = new Magic();
            }

            players[0] = new Player();
            players[1] = new Player();
            players[2] = new Player();
            players[3] = new Player();




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
            Game = new frmFight(players[currPosFirst],players[currPosSec]);

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

        private void frmPickPlayer_Load(object sender, EventArgs e)
        {

        }
    }
}
