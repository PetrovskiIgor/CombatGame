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

       
        PPPBitmap bmBackground;
        //SoundPlayer soundPlayer;
        Player playerOne;
        Player playerTwo;
        Magic playerOneMagic;
        Magic playerTwoMagic;

        PPPProgressBar prbarPlayerOne;
        PPPProgressBar prbarPlayerTwo;



        frmMenu MainForm;
        FrmPlayAgain playAgainForm;
        frmPickPlayer pickPlayerForm;

        

        bool playerOneIsRight;

        bool a, s, d, left, right, down;
        bool f, g, enter, add;
        bool gameIsFinished;
        Timer timer;
        public static int INTERVAL = 10;

        int collisionTolerance = 45; // kolku mozhe da vleguva eden vo drug


        SoundPlayer soundPunch;


        public frmFight(Player first, Player second, frmMenu mainForm)
        {
            InitializeComponent();

            MainForm = mainForm;

            prbarPlayerOne = new PPPProgressBar(755, 46, 461, 56);
            prbarPlayerTwo = new PPPProgressBar(49, 46, 461, 56);


            soundPunch = new SoundPlayer("punch.wav");

            playerOneIsRight = true;

            // za da go prepoznae file-ot  EyeOfTheTiger.wav
            //
            // EyeOfTheTiger.wav vo properties Copy to Output directory: copy if newer!!!
            //if(frmOptions.musicOn)
            //    soundPlayer = new SoundPlayer("EyeOfTheTiger.wav");

            bmBackground = new PPPBitmap(new Bitmap("backgroundMainMenu.jpg"), "backgroundMainMenu.jpg");

            playerOne = first;
           
            playerOne.DirectionPlayer = Direction.LEFT;
            
            
            playerTwo = second;
           
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


          
            Invalidate();
        }


        

        public Boolean playerOneDirection()
        {
            return playerOne.X > playerTwo.X;
        }

        


        public void update()
        {
            if(playerTwo.Health==0)
            {
                gameIsFinished = true;
                prbarPlayerTwo.Value = 0;
                prbarPlayerOne.Value = playerOne.Health;


                // TREBA DA SE DOPOLNI ( DA SE OZNACHI KRAJ NA IGRATA)

            }
            else if (playerOne.Health == 0)
            {
                gameIsFinished = true;
                prbarPlayerOne.Value = 0;
                prbarPlayerTwo.Value = playerTwo.Health;

                // TREBA DA SE DOPOLNI ( DA SE OZNACHI KRAJ NA IGRATA)
            }
            else { 
                this.prbarPlayerOne.Value = playerOne.Health;
                this.prbarPlayerTwo.Value = playerTwo.Health;
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
                
                a = true;
            }
            else if(e.KeyCode==Keys.D)
            {
                
                d = true;
            }
            else if (e.KeyCode==Keys.S)
            {
                playerTwo.ChangeState(State.KNEEL);
            }
            else if(e.KeyCode==Keys.Left)
            {
                
                left = true;
            }
            else if (e.KeyCode==Keys.Right)
            {
                
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
                    {
                        soundPunch.Play();
                        playerOne.DecreaseHealth(Player.HandPower);
                    }
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
                    {
                        soundPunch.Play();
                        playerTwo.DecreaseHealth(Player.HandPower);
                    }
                        
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
            Rectangle intersect = intersection();
            if (a)
            {
                if(intersect.Width  < collisionTolerance || playerOneIsRight) // ako e pomala kolizijata
                    playerTwo.Move(Direction.LEFT);                           // ili ako se dvizhi vo nasoka koja ja namaluva kolizijata
               
            }
            if (d)
            {
                if (intersect.Width < collisionTolerance || !playerOneIsRight)
                playerTwo.Move(Direction.RIGHT);
            }
            if (left)
            {
                if (intersect.Width < collisionTolerance || !playerOneIsRight)
                playerOne.Move(Direction.LEFT);
            }
            if(right)
            {
                if (intersect.Width < collisionTolerance || playerOneIsRight)
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


            if (((magic.X - magic.Width / 2) < (player.X + player.Width / 2)) && magic.X + Width / 2 >= player.X + player.Width / 2)
            {
                if (!player.AvoidMagicAttack())
                {

                    if (player.Y + player.Height / 2 >= (magic.Y - magic.Height / 2))
                    {
                        player.DecreaseHealth(magic.Power);
                        if (playerOneMagic == magic)
                        {
                            playerOneMagic = null;
                        }
                        else
                        {
                            playerTwoMagic = null;
                        }
                        
                    }
                }

               
            }
        }

        public void RightMagicAttack (Player player, Magic magic)
        {

            if (((magic.X + magic.Width / 2) > (player.X - player.Width/2 + 50)) && (magic.X - magic.Width/2 <= player.X - player.Width/2))
            {
                if (!player.AvoidMagicAttack())
                {

                    if ((player.Y + player.Height / 2) >= (magic.Y - magic.Height / 2))
                    {
                        player.DecreaseHealth(magic.Power);

                        if (playerOneMagic == magic)
                        {
                            playerOneMagic = null;
                        }
                        else
                        {
                            playerTwoMagic = null;
                        }
                       
                    }



                    
                }

               
            }
        }

     
        
        private Rectangle intersection()
        {


            if (playerOne.Right < playerTwo.Left || playerOne.Left > playerTwo.Right || playerOne.Top != playerTwo.Top)
            {
                return new Rectangle(-1,-1,-1,-1);
            }
            if(playerOne.Left < playerTwo.Right && playerOne.Left > playerTwo.Left) 
            {
                
                Rectangle interArea = new Rectangle(0, 0, playerTwo.Right - playerOne.Left, playerOne.Height);
                //Rectangle iA = new Rectangle(0, 0, pbPlayerOne.Width, pbPlayerOne.Height);
               // Rectangle interArea = new Rectangle(pbPlayerOne.Left, pbPlayerOne.Top, 1, 1);
                return interArea;
            }
            else if ((playerOne.Right) > playerTwo.Left && playerOne.Left < playerTwo.Right)
            {
                
                return new Rectangle(playerOne.Width-(playerOne.Right-playerTwo.Left), 0, playerOne.Right - playerTwo.Left, playerOne.Height);
            }
            else
            {
                return new Rectangle(-1, -1, -1, -1);
            }
        }
        
        void timer_Tick(object sender, EventArgs e)
        {

            if (gameIsFinished)
            {
                

                timer.Stop();

                playAgainForm = new FrmPlayAgain();

                
                

                if (playAgainForm.ShowDialog() == DialogResult.OK)
                {
                    pickPlayerForm = new frmPickPlayer(MainForm);

                    pickPlayerForm.Show();
                }

                this.Hide();
               
                
            }

            if (playerOneIsRight != this.playerOneDirection())
            {

                playerOneIsRight = this.playerOneDirection(); // ja azurira pozicijata ("SVRTENOSTA") na igracot
                // MessageBox.Show(playerOneIsRight + " ");
                if (playerOneIsRight)
                {
                    playerOne.changeDirection(Direction.LEFT);
                    playerTwo.changeDirection(Direction.RIGHT);
                }
                else
                {
                    playerOne.changeDirection(Direction.RIGHT);
                    playerTwo.changeDirection(Direction.LEFT);
                }
            }


            if (!playerOne.CheckAndActs())
            {
                gameIsFinished = true;
            }

            if(!playerTwo.CheckAndActs())
            {
                gameIsFinished = true;
            }
            

            this.Moving();
            this.update();

            
            
            
           // this.checkClashAndAct();

            Invalidate();

            
        }
       

        private void frmFight_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmBackground.Bitmap, 0, 0, this.Width, this.Height);
            this.playerOne.DrawPlayer(e.Graphics);
            this.playerTwo.DrawPlayer(e.Graphics);
            this.prbarPlayerOne.Draw(e.Graphics);
            this.prbarPlayerTwo.Draw(e.Graphics);

            if (playerOneMagic != null)
            {
                playerOneMagic.DrawMagic(e.Graphics);
            }

            if (playerTwoMagic != null)
            {
                playerTwoMagic.DrawMagic(e.Graphics);
            }
        }


    }
}
