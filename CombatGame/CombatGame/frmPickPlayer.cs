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

        Image imgPlayerOne = Image.FromFile("imgPlayerOne.png");  // koga korisnikot kje gi bira igracite nad slikite
        Image imgPlayerTwo = Image.FromFile("imgPlayerTwo.png"); // da se azurira

        

        public frmPickPlayer(frmMenu menu)
        {
            InitializeComponent();
            MainMenu = menu;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            bmBackground = new PPPBitmap(new Bitmap("CombatGameBackground.gif"), "CombatGameBackground.gif");
            numPlayers = 4;

            pb1.Image = Image.FromFile("imgVikiPeeva.jpg");
            pb2.Image = Image.FromFile("imgPetrovPetre.jpg");
            pb3.Image = Image.FromFile("imgIgorPetrovski.jpg");
            pb4.Image = Image.FromFile("imgDavidHorny.jpg");

       
            firstDone = false;
            secDone = false;




            takenPb = new bool[numPlayers];
            players = new Player[numPlayers];
            magicTricks = new Magic[3];
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

            magicTricks[0] = new Magic("Fire", 10, Image.FromFile("imgFireMagicTrans.png"), Image.FromFile("imgFireMagicTrans.png"),30);
            magicTricks[1] = new Magic("Hurricane", 10, Image.FromFile("imgHurrucainVerticalTrans.png"), Image.FromFile("imgHurrucainVerticalTrans.png"), 30);
            magicTricks[2] = new Magic("Lightning", 10, Image.FromFile("imgLightningMagicTrans.png"), Image.FromFile("imgLightningMagicTrans.png"), 30);
           
            

            players[0] = new Player("Viki","Zestoka",magicTricks[0],magicTricks[1],magicTricks[2]);
            players[1] = new Player("Petre", "Petre doagja od gradot Radovis.", magicTricks[0], magicTricks[1], magicTricks[2]);
            players[2] = new Player("Igor", "Jas sum Igor Petrovski, dzverot Tetovski.", magicTricks[0], magicTricks[1], magicTricks[2]);
            players[3] = new Player("David", "Jas sum Horny i mnogu sum crazy!", magicTricks[0], magicTricks[1], magicTricks[2]);
            this.fillPlayersImages();

            players[0].SetCurrentImage(true);
            players[1].SetCurrentImage(false);
            players[2].SetCurrentImage(true);
            players[3].SetCurrentImage(false);


            
           



            pb1.BackColor = Color.Transparent;
            pb2.BackColor = Color.Red;
            pb3.BackColor = Color.Red;
            pb4.BackColor = Color.Red;
            pb1Parent.BackColor = Color.Yellow;
            pb2Parent.BackColor = Color.Green;
            pb3Parent.BackColor = Color.Transparent;
            pb4Parent.BackColor = Color.Transparent;




            lblPlayerOneDesc.Text = players[0].Description;
            lblPlayerTwoDesc.Text = players[1].Description;

            Invalidate();
        }

        private void fillPlayersImages()
        {
                // IGOR
                players[2].imgAttack = Image.FromFile("igorUdar.png");
                players[2].imgDefense = Image.FromFile("igorGard.png");
                players[2].imgStand = Image.FromFile("igorStand.png");
                players[2].imgAttackLeg = Image.FromFile("igorNoga.png");
                players[2].imgKneel = Image.FromFile("igorKleci.png");
                players[2].imgDead = Image.FromFile("igorLezi.png");

                players[2].imgAttackD = Image.FromFile("igorUdarD.png");
                players[2].imgDefenseD = Image.FromFile("igorGardD.png");
                players[2].imgStandD = Image.FromFile("igorStandD.png");
                players[2].imgAttackLegD = Image.FromFile("igorNogaD.png");
                players[2].imgKneelD = Image.FromFile("igorKleciD.png");
                players[2].imgDeadD = Image.FromFile("igorLeziD.png");

            
                

                // VIKI
                players[0].imgAttack = Image.FromFile("vikiPunch.png");
                players[0].imgDefense = Image.FromFile("vikiDefense.png");
                players[0].imgStand = Image.FromFile("vikiStand.png");
                players[0].imgAttackLeg = Image.FromFile("vikiLeg.png");
                players[0].imgKneel = Image.FromFile("vikiKneel.png");
                players[0].imgDead = Image.FromFile("vikiDead.png");

                players[0].imgAttackD = Image.FromFile("vikiPunchD.png");
                players[0].imgDefenseD = Image.FromFile("vikiDefenseD.png");
                players[0].imgStandD = Image.FromFile("vikiStandD.png");
                players[0].imgAttackLegD = Image.FromFile("vikiLegD.png");
                players[0].imgKneelD = Image.FromFile("vikiKneelD.png");
                players[0].imgDeadD = Image.FromFile("vikiDeadD.png");
            
                
                // PETRE
                players[1].imgAttack = Image.FromFile("petreUdarTrans.png");
                players[1].imgDefense = Image.FromFile("petreGardTrans.png");
                players[1].imgStand = Image.FromFile("petreStandTrans.png");
                players[1].imgAttackLeg = Image.FromFile("petreNogaTrans.png");
                players[1].imgKneel = Image.FromFile("petreKleciSecenaTrans.png");
                players[1].imgDead = Image.FromFile("petreLezi.png");

                players[1].imgAttackD = Image.FromFile("petreUdarTransD.png");
                players[1].imgDefenseD = Image.FromFile("petreGardTransD.png");
                players[1].imgStandD = Image.FromFile("petreStandTransD.png");
                players[1].imgAttackLegD = Image.FromFile("petreNogaTransD.png");
                players[1].imgKneelD = Image.FromFile("petreKleciSecenaTransD.png");
                players[1].imgDeadD = Image.FromFile("petreLeziD.png");
            
                // HORNY
            
                players[3].imgAttack = Image.FromFile("DavidPunch.png");
                players[3].imgDefense = Image.FromFile("DavidDefense.png");
                players[3].imgStand = Image.FromFile("DavidStand.png");
                players[3].imgAttackLeg = Image.FromFile("DavidNogaTrans.png");
                players[3].imgKneel = Image.FromFile("DavidKleciTrans.png");
                players[3].imgDead = Image.FromFile("DavidDeadTrans.png");

                players[3].imgAttackD = Image.FromFile("DavidPunchD.png");
                players[3].imgDefenseD = Image.FromFile("DavidDefenseD.png");
                players[3].imgStandD = Image.FromFile("DavidStandD.png");
                players[3].imgAttackLegD = Image.FromFile("DavidNogaTransD.png");
                players[3].imgKneelD = Image.FromFile("DavidKleciTransD.png");
                players[3].imgDeadD = Image.FromFile("DavidDeadTransD.png");
            
        }

        

        private void lblStart_Click(object sender, EventArgs e)
        {

            
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
                    if (frmOptions.musicOn)
                    {
                        MainMenu.wplayer.currentPlaylist = MainMenu.playlistFight;
                    }
                    else
                    {
                        MainMenu.wplayer.controls.stop();
                    }
                    this.Hide();


                    Game = new frmFight(players[currPosFirst], players[currPosSec],this.MainMenu);

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
                    
                    lblPlayerOneDesc.Text = players[currPosFirst].Description;
                    
                    putAbovePictureBox(currPosFirst, true);
                }
                
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (!firstDone)
                {
                    currPosFirst = moveInNextField(currPosFirst, currPosSec, true, false);
                    
                    putAbovePictureBox(currPosFirst, true);
                    lblPlayerOneDesc.Text = players[currPosFirst].Description;
           
                }
               
            }
            else if (e.KeyCode == Keys.A)
            {
                if (!secDone)
                {
                    currPosSec = moveInNextField(currPosSec, currPosFirst, false, true);
                     
                    lblPlayerTwoDesc.Text = players[currPosSec].Description;
                    putAbovePictureBox(currPosSec, false);
                }
               
            }
            else if (e.KeyCode == Keys.D)
            {
                if (!secDone)
                {
                    currPosSec = moveInNextField(currPosSec, currPosFirst, false, false);
                     
                    lblPlayerTwoDesc.Text = players[currPosSec].Description;
                    putAbovePictureBox(currPosSec, false);
                }
                
            }
            
        }
        // funkcijata koja pravi da se pojavi player one/ player two nad selektiran igrac
        private void putAbovePictureBox(int player, bool firstPlayer)
        {
           
            pbAbove1.BackColor = Color.Transparent;
            pbAbove2.BackColor = Color.Transparent;
            pbAbove3.BackColor = Color.Transparent;
            pbAbove4.BackColor = Color.Transparent;

            if (0 != currPosFirst && 0 != currPosSec) pbAbove1.Image = null;
            if (1 != currPosFirst && 1 != currPosSec) pbAbove2.Image = null;
            if (2 != currPosFirst && 2 != currPosSec) pbAbove3.Image = null;
            if (3 != currPosFirst && 3 != currPosSec) pbAbove4.Image = null;
            
           
            if (player == 0)
            {
               
                if (firstPlayer)pbAbove1.Image = imgPlayerOne;
                else            pbAbove1.Image = imgPlayerTwo;
            }
            else if (player == 1)
            {
                
                if (firstPlayer) pbAbove2.Image = imgPlayerOne;
                else             pbAbove2.Image = imgPlayerTwo;
            }
            else if (player == 2)
            {
               
                if (firstPlayer) pbAbove3.Image = imgPlayerOne;
                else pbAbove3.Image = imgPlayerTwo;
            }
            else if (player == 3)
            {
               
                if (firstPlayer) pbAbove4.Image = imgPlayerOne;
                else pbAbove4.Image = imgPlayerTwo;
            }
        }

        private void frmPickPlayer_Resize(object sender, EventArgs e)
        {
            Validate();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu.Show();
        }

        private void pbStart_Click(object sender, EventArgs e)
        {
            if (firstDone && secDone)
            {
                this.Hide();

                Game = new frmFight(players[currPosFirst], players[currPosSec],MainMenu);
                if (frmOptions.musicOn)
                {
                    MainMenu.wplayer.currentPlaylist = MainMenu.playlistFight;
                }
                else
                {
                    MainMenu.wplayer.controls.stop();
                }

                Game.Show();
            }
        }
    }
}
