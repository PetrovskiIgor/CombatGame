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
        
        SoundPlayer soundPlayer;
        Player playerOne;
        Player playerTwo;
        Magic playerOneMagic;
        Magic playerTwoMagic;
        bool a, s, d, left, right, down;
        bool gameIsFinished;
        Timer timer;
        public static int INTERVAL = 10;


        public frmFight(Player first, Player second)
        {
            InitializeComponent();


            // za da go prepoznae file-ot  EyeOfTheTiger.wav
            //
            // EyeOfTheTiger.wav vo properties Copy to Output directory: copy if newer!!!
            soundPlayer = new SoundPlayer("EyeOfTheTiger.wav");

            playerOne = first;
            playerOne.pbPlayer = pbPlayerOne;
            playerTwo = second;
            playerTwo.pbPlayer = pbPlayerTwo;




            soundPlayer.Play();
            timer = new Timer();
            timer.Interval = INTERVAL;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
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
                playerTwo.ChangeState(State.ATTACK);
                if (playerTwo.Attack(playerOne))
                    playerOne.DecreaseHealth(Player.HandPower);
            }
            else if (e.KeyCode==Keys.G)
            {
                playerTwo.ChangeState(State.ATTACKLEG);
                if (playerTwo.AttackLeg(playerOne))
                    playerOne.DecreaseHealth(Player.LegPower);
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
                playerOne.ChangeState(State.ATTACK);
                if (playerOne.Attack(playerTwo))
                    playerTwo.DecreaseHealth(Player.HandPower);
            }
            else if(e.KeyCode==Keys.Add)
            {
                playerOne.ChangeState(State.ATTACKLEG);
                if (playerOne.AttackLeg(playerTwo))
                    playerTwo.DecreaseHealth(Player.LegPower);
            }
            else if(e.KeyCode==Keys.NumPad1)
            {

                playerOne.ChangeState(State.ATTACKMAGIC);
                playerOneMagic = playerOne.AttackMagic();
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
            
        }

        void timer_Tick(object sender, EventArgs e)
        {
            playerOne.CheckAndActs();
            playerTwo.CheckAndActs();

            this.Moving();
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
                    if(playerOneMagic.PicBoxImage.Left>pbPlayerTwo.Right && playerOneMagic.PicBoxImage.Right<=pbPlayerTwo.Right)
                    {
                        if(playerTwo.AvoidMagicAttack())
                        {
                            if(pbPlayerTwo.Bottom>=playerOneMagic.PicBoxImage.Top)
                            {
                                playerTwo.DecreaseHealth(playerOneMagic.Power);
                                playerOneMagic = null;
                            }
                        }
                    }
                }
                else
                {
                    if(playerOneMagic.PicBoxImage.Right>pbPlayerTwo.Left && playerOneMagic.PicBoxImage.Left>=pbPlayerTwo.Left)
                    {
                        if(playerTwo.AvoidMagicAttack())
                        {
                            if (pbPlayerTwo.Bottom >= playerOneMagic.PicBoxImage.Top)
                            {
                                playerTwo.DecreaseHealth(playerOneMagic.Power);
                                playerOneMagic = null;
                            }
                        }
                    }
                }
            }

            if(playerTwoMagic!=null)
            {
                playerTwoMagic.Move();
                if(playerTwoMagic.DirOfMoving==Direction.LEFT)
                {
                    if (playerTwoMagic.PicBoxImage.Left > pbPlayerOne.Right && playerTwoMagic.PicBoxImage.Right <= pbPlayerOne.Right)
                    {
                        if (playerOne.AvoidMagicAttack())
                        {
                            if (pbPlayerOne.Bottom >= playerTwoMagic.PicBoxImage.Top)
                            {
                                playerOne.DecreaseHealth(playerTwoMagic.Power);
                                playerTwoMagic = null;
                            }
                        }
                    }
                }
                else
                {
                    if (playerTwoMagic.PicBoxImage.Right > pbPlayerOne.Left && playerTwoMagic.PicBoxImage.Left >= pbPlayerOne.Left)
                    {
                        if (playerOne.AvoidMagicAttack())
                        {
                            if (pbPlayerOne.Bottom >= playerTwoMagic.PicBoxImage.Top)
                            {
                                playerOne.DecreaseHealth(playerTwoMagic.Power);
                                playerTwoMagic = null;
                            }
                        }
                    }
                }
            }
        }
    }
}
