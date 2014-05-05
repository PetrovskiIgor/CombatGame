using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatGame
{
    public partial class frmFight : Form
    {
        
        //SoundPlayer soundPlayer;
        Player playerOne;
        Player playerTwo;
        Magic playerOneMagic;
        Magic playerTwoMagic;
        bool a, s, d, left, right, down;
        bool f, g, enter, add;
        bool gameIsFinished;
        Timer timer;
        public static int INTERVAL = 10;


        public frmFight(Player first, Player second)
        {
            InitializeComponent();


            // za da go prepoznae file-ot  EyeOfTheTiger.wav
            //
            // EyeOfTheTiger.wav vo properties Copy to Output directory: copy if newer!!!
            //if(frmOptions.musicOn)
            //    soundPlayer = new SoundPlayer("EyeOfTheTiger.wav");

            playerOne = first;
            playerOne.pbPlayer = pbPlayerOne;
            playerOne.DirectionPlayer = Direction.LEFT;
            
            

            playerTwo = second;
            playerTwo.pbPlayer = pbPlayerTwo;
            playerTwo.DirectionPlayer = Direction.RIGHT;

           
            
            




            this.lblPlayerOneName.Text = playerOne.Name;
            this.lblPlayerTwoName.Text = playerTwo.Name;
            //if(soundPlayer != null)
            //    soundPlayer.Play();
            timer = new Timer();
            timer.Interval = INTERVAL;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            update();
            this.DoubleBuffered = true;


            // funkcija koja gi postavuva transparentnite sliki

            fillPictureBoxes();

            pbIntersection.Parent = pbPlayerTwo;
            pbIntersection.BackColor = Color.Transparent;
            
            
        }


        private void fillPictureBoxes()
        {

            if (playerOne.Name.Equals("Igor"))
            {
                playerOne.imgAttack = Image.FromFile("igorUdarD.png");
                playerOne.imgDefense = Image.FromFile("igorGardD.png");
                playerOne.imgStand = Image.FromFile("igorStandD.png");
                playerOne.imgAttackLeg = Image.FromFile("igorNogaD.png");
                playerOne.imgKneel = Image.FromFile("igorKleciD.png");
                playerOne.imgDead = Image.FromFile("igorLeziD.png");

            }
            else if (playerOne.Name.Equals("Viki"))
            {
                playerOne.imgAttack = Image.FromFile("vikiPunchD.png");
                playerOne.imgDefense = Image.FromFile("vikiDefenseD.png");
                playerOne.imgStand = Image.FromFile("vikiStandD.png");
                playerOne.imgAttackLeg = Image.FromFile("vikiLegD.png");
                playerOne.imgKneel = Image.FromFile("vikiKneelD.png");
                playerOne.imgDead = Image.FromFile("vikiDeadD.png");
            }


    
            
                playerTwo.imgAttack = Image.FromFile("petreUdarTrans.png");
                playerTwo.imgDefense = Image.FromFile("petreGardTrans.png");
                playerTwo.imgStand = Image.FromFile("petreStandTrans.png");
                playerTwo.imgAttackLeg = Image.FromFile("petreNogaTrans.png");
                playerTwo.imgKneel = Image.FromFile("petreKleciSecenaTrans.png");
            
        }


        public void update()
        {
            if(playerTwo.Health==0)
            {
                gameIsFinished = true;
                pbarPlayerTwo.Value = 0;
                pbarPlayerOne.Value = playerOne.Health;


                // TREBA DA SE DOPOLNI ( DA SE OZNACHI KRAJ NA IGRATA)

            }
            else if (playerOne.Health == 0)
            {
                gameIsFinished = true;
                pbarPlayerOne.Value = 0;
                pbarPlayerTwo.Value = playerTwo.Health;

                // TREBA DA SE DOPOLNI ( DA SE OZNACHI KRAJ NA IGRATA)
            }
            else { 
                this.pbarPlayerOne.Value = playerOne.Health;
                this.pbarPlayerTwo.Value = playerTwo.Health;
            }   
            
            this.lblHelthPlayerOne.Text = playerOne.Health.ToString() + "%";
            this.lblHealthPlayerTwo.Text = playerTwo.Health.ToString() + "%";
        }


        private void frmFight_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmFight_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.W)
            {
                playerTwo.IsJumped = true;
            }
            else if(e.KeyCode==Keys.Up)
            {
                playerOne.IsJumped = true;
            }
            else if (e.KeyCode==Keys.A)
            {
                playerTwo.ChangeState(State.MOVINGLEFT);
                a = true;
            }
            else if(e.KeyCode==Keys.D)
            {
                playerTwo.ChangeState(State.MOVINGRIGHT);
                d = true;
            }
            else if (e.KeyCode==Keys.S)
            {
                playerTwo.ChangeState(State.KNEEL);
            }
            else if(e.KeyCode==Keys.Left)
            {
                playerOne.ChangeState(State.MOVINGLEFT);
                left = true;
            }
            else if (e.KeyCode==Keys.Right)
            {
                playerOne.ChangeState(State.MOVINGRIGHT);
                right = true;
            }
            else if(e.KeyCode==Keys.Down)
            {
                down = true;
                playerOne.ChangeState(State.KNEEL);
            }
            else if(e.KeyCode== Keys.F)
            {
                if (!f)
                {
                    f = true;
                    playerTwo.ChangeState(State.ATTACK);
                    if (playerTwo.Attack(playerOne))
                        playerOne.DecreaseHealth(Player.HandPower);
                }
            }
            else if (e.KeyCode==Keys.G)
            {
                if (!g)
                {
                    g = true;
                    playerTwo.ChangeState(State.ATTACKLEG);
                    if (playerTwo.AttackLeg(playerOne))
                        playerOne.DecreaseHealth(Player.LegPower);
                }
            }
            else if(e.KeyCode==Keys.V)
            {
                playerTwo.ChangeState(State.ATTACKMAGIC);
                playerTwoMagic=playerTwo.AttackMagic();
                playerTwoMagic.PicBoxImage = pbMagic2;
              
            }
            else if(e.KeyCode==Keys.H)
            {
                playerTwo.ChangeState(State.DEFENSE);
            }
            else if(e.KeyCode==Keys.Enter)
            {
                if (!enter)
                {
                    enter = true;
                    playerOne.ChangeState(State.ATTACK);
                    if (playerOne.Attack(playerTwo))
                        playerTwo.DecreaseHealth(Player.HandPower);
                }
            }
            else if(e.KeyCode==Keys.Add)
            {
                if (!add)
                {
                    add = true;
                    playerOne.ChangeState(State.ATTACKLEG);
                    if (playerOne.AttackLeg(playerTwo))
                        playerTwo.DecreaseHealth(Player.LegPower);
                }
            }
            else if(e.KeyCode==Keys.NumPad1)
            {

                playerOne.ChangeState(State.ATTACKMAGIC);
                playerOneMagic = playerOne.AttackMagic();
                playerOneMagic.PicBoxImage = pbMagic1;
                //pbMagic1.BackColor = Color.Transparent;
                //pbMagic1.Image = playerOne.magicList.ElementAt(0).MagicImageLeft;
            }
            else if (e.KeyCode==Keys.NumPad0)
            {
                playerOne.ChangeState(State.DEFENSE);
            }
            
        }

        private void frmFight_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.A)
            {
                a = false;
                playerTwo.ChangeState(State.STAND);
            }
            else if (e.KeyCode==Keys.D)
            {
                d = false;
                playerTwo.ChangeState(State.STAND);
            }
            else if(e.KeyCode==Keys.S)
            {
                s = false;
                playerTwo.ChangeState(State.STAND);
            }
            else if(e.KeyCode==Keys.Left)
            {
                left = false;
                playerOne.ChangeState(State.STAND);
            }
            else if(e.KeyCode==Keys.Right)
            {
                right = false;
                playerOne.ChangeState(State.STAND);
            }
            else if (e.KeyCode==Keys.Down)
            {
                down = false;
                playerOne.ChangeState(State.STAND);
            }
            else if(e.KeyCode==Keys.F)
            {
                f = false;
                playerTwo.ChangeState(State.STAND);
            }
            else if(e.KeyCode==Keys.G)
            {
                g = false;
                playerTwo.ChangeState(State.STAND);
            }
            else if (e.KeyCode==Keys.H)
            {
                playerTwo.ChangeState(State.STAND);
            }
            else if (e.KeyCode==Keys.V)
            {
                playerTwo.ChangeState(State.STAND);
            }
            else if(e.KeyCode==Keys.Enter)
            {
                enter = false;
                playerOne.ChangeState(State.STAND);
            }
            else if(e.KeyCode==Keys.NumPad0)
            {
                playerOne.ChangeState(State.STAND);
            }
            else if(e.KeyCode==Keys.NumPad1)
            {
                playerOne.ChangeState(State.STAND);
            }
            else if(e.KeyCode==Keys.Add)
            {
                add = false;
                playerOne.ChangeState(State.STAND);
            }
        }

        

        public void Moving()
        {
            if (a)
            {
                playerTwo.Move(Direction.LEFT);
            }
            if (d)
            {
                playerTwo.Move(Direction.RIGHT);
            }
            if (left)
            {
                playerOne.Move(Direction.LEFT);
            }
            if(right)
            {
                playerOne.Move(Direction.RIGHT);
            }

            if(playerOneMagic!=null)
            {
                playerOneMagic.Move();
                if(playerOneMagic.DirOfMoving==Direction.LEFT)
                {
                    this.LeftMagicAttack(playerTwo, playerOneMagic);
                }
                else
                {
                    this.RightMagicAttack(playerTwo, playerOneMagic);
                }
            }

            if(playerTwoMagic!=null)
            {
                playerTwoMagic.Move();
                if(playerTwoMagic.DirOfMoving==Direction.LEFT)
                {
                    this.LeftMagicAttack(playerOne, playerTwoMagic);
                }
                else
                {
                    this.RightMagicAttack(playerOne, playerTwoMagic);
                }
            }
        }


        public void LeftMagicAttack (Player player, Magic magic)
        {
            if ((magic.PicBoxImage.Left < player.pbPlayer.Right - 50) && magic.PicBoxImage.Right >= player.pbPlayer.Right)
            {
                if (!player.AvoidMagicAttack())
                {
                    if (player.pbPlayer.Bottom >= magic.PicBoxImage.Top)
                    {
                        player.DecreaseHealth(magic.Power);
                        magic.HideMagic();
                        magic = null;
                    }
                }
            }
        }

        public void RightMagicAttack (Player player, Magic magic)
        {
            if (magic.PicBoxImage.Right > player.pbPlayer.Left + 50 && magic.PicBoxImage.Left <= player.pbPlayer.Left)
            {
                if (!player.AvoidMagicAttack())
                {
                    if (player.pbPlayer.Bottom >= magic.PicBoxImage.Top)
                    {
                        player.DecreaseHealth(magic.Power);
                        magic.HideMagic();
                        playerOneMagic = null;
                    }
                }
            }
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        public  Image cropImage(Image img, Rectangle cropArea)
        {

            Image newImg = resizeImage(img, pbPlayerOne.Size);
            
            
            Bitmap bmpImage = new Bitmap(newImg);

            

            
            Bitmap bmpCrop = bmpImage.Clone(cropArea, System.Drawing.Imaging.PixelFormat.DontCare);
            
           
            return (Image)bmpCrop;
        }
        
        private Rectangle intersection()
        {

            if (pbPlayerOne.Right < pbPlayerTwo.Left || pbPlayerOne.Left > pbPlayerTwo.Right)
            {
                return new Rectangle(-1,-1,-1,-1);
            }
            if(pbPlayerOne.Left < pbPlayerTwo.Right && pbPlayerOne.Right > pbPlayerTwo.Left) 
            {
                Rectangle interArea = new Rectangle(0, 0, pbPlayerTwo.Right - pbPlayerOne.Left, pbPlayerOne.Height);
                //Rectangle iA = new Rectangle(0, 0, pbPlayerOne.Width, pbPlayerOne.Height);
               // Rectangle interArea = new Rectangle(pbPlayerOne.Left, pbPlayerOne.Top, 1, 1);
                return interArea;
            }else if(pbPlayerOne.Right > pbPlayerTwo.Left && pbPlayerOne.Left < pbPlayerTwo.Right)
            {
                return new Rectangle(0, 0, pbPlayerOne.Right - pbPlayerTwo.Left, pbPlayerOne.Height);
            }
            else
            {
                return new Rectangle(-1, -1, -1, -1);
            }
        }
        
        void timer_Tick(object sender, EventArgs e)
        {
            playerOne.CheckAndActs();
            playerTwo.CheckAndActs();


            

            this.Moving();
            this.update();
            this.checkClashAndAct();

            
        }
        // proveruva dali dvata igrachi se sudrile i se spravuva so so sudarot
        public void checkClashAndAct()
        {
            Rectangle checkInter = intersection();

            if (checkInter.Height != -1)
            {

                pbIntersection.Width = checkInter.Width;
                pbIntersection.Height = checkInter.Height;

                Image partOfPlayerOne = cropImage(playerOne.pbPlayer.Image, checkInter);
                pbIntersection.Image = partOfPlayerOne;

                pbIntersection.SizeMode = PictureBoxSizeMode.StretchImage;
                //pbIntersection.Location = new Point(pbPlayerOne.Left, pbPlayerOne.Top);
                pbIntersection.Location = new Point(pbPlayerTwo.Width - pbIntersection.Width, 0);
            }
            else
            {
                pbIntersection.Image = null;
            }

        }


    }
}
