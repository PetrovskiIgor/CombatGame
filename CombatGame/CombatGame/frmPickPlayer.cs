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

        PictureBox[][] pb;
        bool[] takenPb;
        int numPlayers;

        Player[] players;
        Magic[] magicTricks;

        int currPosFirst;
        int currPosSec;

        bool firstDone;
        bool secDone;


        public frmPickPlayer(frmMenu menu)
        {
            InitializeComponent();
            MainMenu = menu;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            bmBackground = new PPPBitmap(new Bitmap("backgroundMainMenu.jpg"), "backgroundMainMenu.jpg");
            numPlayers = 4;

            pb1.Image = Image.FromFile("imgVikiPeeva.jpg");
            pb2.Image = Image.FromFile("imgPetrovPetre.jpg");
            pb3.Image = Image.FromFile("imgIgorPetrovski.jpg");
            pb4.Image = Image.FromFile("imgDavidHorny.jpg");

       
            firstDone = false;
            secDone = false;




            takenPb = new bool[numPlayers];
            players = new Player[numPlayers];
            magicTricks = new Magic[numPlayers * 3];
            pb = new PictureBox[numPlayers][];
            pb[0] = new PictureBox[2];
            pb[1] = new PictureBox[2];
            pb[2] = new PictureBox[2];
            pb[3] = new PictureBox[2];

            

            pb[0][0] = pb1; pb[0][1] = pb1Parent;
            pb[1][0] = pb2; pb[1][1] = pb2Parent;
            pb[2][0] = pb3; pb[2][1] = pb3Parent;
            pb[3][0] = pb4; pb[3][1] = pb4Parent;
            

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

            players[0] = new Player("Viki","Zestoka",magicTricks[0],magicTricks[1],magicTricks[2]);
            players[1] = new Player("Petre", "Petre doagja od gradot Radovis.", magicTricks[3], magicTricks[4], magicTricks[5]);
            players[2] = new Player("Igor", "Jas sum Igor Petrovski, dzverot Tetovski.", magicTricks[6], magicTricks[7], magicTricks[8]);
            players[3] = new Player("David", "Jas sum Horny i mnogu sum crazy!", magicTricks[9], magicTricks[10], magicTricks[11]);


            rtbFirstPlayer.Text = players[currPosFirst].Description;
            rtbSecPlayer.Text = players[currPosSec].Description;



            pb1.BackColor = Color.Transparent;
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
            firstDone = true; // nepotrebno, no neka stoi
            secDone = true;// nepotrebno, no neka stoi
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


        private int moveInNextField(int player, int otherPlayer, bool firstPlayer, bool left)
        {
            takenPb[player] = false;

           
                player = left?(((player == 0) ? numPlayers - 1 : (player - 1))):((player + 1) % numPlayers);
            

            while (takenPb[player])
            {
                player = left ? (((player == 0) ? numPlayers - 1 : (player - 1))) : ((player + 1) % numPlayers);
            }

            for (int i = 0; i < numPlayers; i++)
            {
                if(i != otherPlayer)
                pb[i][1].BackColor = Color.Transparent;
            }
            takenPb[player] = true;
            takenPb[player] = true;
            pb[player][1].BackColor = firstPlayer?Color.Yellow:Color.Green;
           
            return player;
        }

        

        private void frmPickPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (firstDone && secDone)
                {
                    this.Hide();
                    Game = new frmFight(players[currPosFirst], players[currPosSec]);

                    Game.Show();
                }
                else
                {
                    if (!firstDone)
                    {

                        pb[currPosFirst][1].BackColor = Color.White;
                        firstDone = true;
                    }
                    else // secDone == false
                    {
                        pb[currPosSec][1].BackColor = Color.White;
                        secDone = true;
                    }
                }
            }
            else if(e.KeyCode == Keys.Left)
            {
                if(!firstDone)
                {
                    currPosFirst = moveInNextField(currPosFirst, currPosSec, true, true);
                    rtbFirstPlayer.Text = players[currPosFirst].Description;
                }
                
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (!firstDone)
                {
                    currPosFirst = moveInNextField(currPosFirst, currPosSec, true, false);
                    rtbFirstPlayer.Text = players[currPosFirst].Description;
                }
               
            }
            else if (e.KeyCode == Keys.A)
            {
                if (!secDone)
                {
                    currPosSec = moveInNextField(currPosSec, currPosFirst, false, true);
                    rtbSecPlayer.Text = players[currPosSec].Description;
                }
               
            }
            else if (e.KeyCode == Keys.D)
            {
                if (!secDone)
                {
                    currPosSec = moveInNextField(currPosSec, currPosFirst, false, false);
                    rtbSecPlayer.Text = players[currPosSec].Description;
                }
                
            }
            
        }

        private void frmPickPlayer_Resize(object sender, EventArgs e)
        {
            Validate();
        }
    }
}
