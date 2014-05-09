using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatGame
{
    public enum State
    {
        STAND,          //player is steady
        
        
        ATTACK,
        ATTACKLEG,
        ATTACKMAGIC,
        DEFENSE,
        KNEEL,
        DEAD
    }

    public enum Direction
    {
        LEFT,
        RIGHT,
        UNDEFINED
    }

    public class Player
    {
        public String Name { get; set; }
        public int Health { get; set; }
        public String Description { get; set; }
        public PictureBox pbPlayer;
        public List<Magic> magicList;
        public int Velocity { get; set; }
        public int JumpForce = 30;
        public bool IsJumped { get; set; }
        public static int StandPosition = 700; //treba da se smeni
        public Direction DirectionPlayer { get; set; }
        State statePerson { get; set; }
        public static int HandPower = 8 ;
        public static int LegPower = 13;
        public Image currentImage;
        int X;
        int Y;

        public Image imgStand;
        public Image imgAttack;
        public Image imgAttackLeg;
        public Image imgAttackMagic;
        public Image imgDefense;
        public Image imgJump;
        public Image imgKneel;
        public Image imgDead;

        public Image imgKneelD;
        public Image imgAttackLegD;
        public Image imgDefenseD;
        public Image imgDeadD;
        public Image imgAttackD;
        public Image imgStandD;


        //Constructor
        public Player()
        {
            Name = "";
            Description = "";
            Health = 100;
            magicList = new List<Magic>();
            statePerson = State.STAND;
            pbPlayer = null;
            IsJumped = false;
            DirectionPlayer = Direction.UNDEFINED;
            this.Velocity = 10;
        }

        public Player(string name, string description, Magic mOne, Magic mTwo, Magic mThree)
        {
            Name = name;
            Description = description;
            Health = 100;
            magicList = new List<Magic>();
            magicList.Add(mOne);
            magicList.Add(mTwo);
            magicList.Add(mThree);
            statePerson = State.STAND;
            pbPlayer = null;
            IsJumped = false;
            DirectionPlayer = Direction.UNDEFINED;
            this.Velocity = 10; // treba da se smeni!!!!!!!!!
            this.X = 50;
            this.Y = 50;
            this.currentImage = Image.FromFile("igorStandResized.png");
        }

        public Player(int X, int Y,string name, string description, Magic mOne, Magic mTwo, Magic mThree)
        {
            this.X = X;
            this.Y = Y; 
            Name = name;
            Description = description;
            Health = 100;
            magicList = new List<Magic>();
            magicList.Add(mOne);
            magicList.Add(mTwo);
            magicList.Add(mThree);
            statePerson = State.STAND;
            pbPlayer = null;
            IsJumped = false;
            DirectionPlayer = Direction.UNDEFINED;
            this.Velocity = 10; // treba da se smeni!!!!!!!!!
           
        }

        public Player(string name, string description, PictureBox pb, Magic mOne, Magic mTwo, Magic mThree)
        {
            Name = name;
            Description = description;
            Health = 100;
            magicList = new List<Magic>();
            magicList.Add(mOne);
            magicList.Add(mTwo);
            magicList.Add(mThree);
            statePerson = State.STAND;
            pbPlayer = pb;
            IsJumped = false;
            DirectionPlayer = Direction.UNDEFINED;
            this.Velocity = 10; // treba da se smeni!!!!!!!!!
        }

        public Player(string name, string description)
        {
            this.Name = name;
            this.Description = description;
            Health = 100;
            magicList = new List<Magic>();
            statePerson = State.STAND;
            pbPlayer = null;
            IsJumped = false;
            DirectionPlayer = Direction.UNDEFINED;
            this.Velocity = 10;
        }

        //Checks in which state the player is and acts if needed
    /*    public void CheckAndActs()
        {
            if (IsJumped)
            {
                Jump();
            }
            else
            {
                JumpForce = 80;
                
            }
            if (statePerson == State.STAND)
            {
                pbPlayer.BackColor = Color.Transparent;
                if (DirectionPlayer == Direction.LEFT)
                    pbPlayer.Image = imgStandD;
                else
                    pbPlayer.Image = imgStand;
            }
            else if (statePerson == State.ATTACK)
            {
                pbPlayer.BackColor = Color.Transparent;
                if (DirectionPlayer == Direction.LEFT)
                    pbPlayer.Image = imgAttackD;
                else
                    pbPlayer.Image = imgAttack;
            }
            else if (statePerson == State.ATTACKLEG)
            {
                pbPlayer.BackColor = Color.Transparent;
                if (DirectionPlayer == Direction.LEFT)
                    pbPlayer.Image = imgAttackLegD;
                else
                    pbPlayer.Image = imgAttackLeg;
                
            }
            else if (statePerson == State.ATTACKMAGIC)
            {
                pbPlayer.BackColor = Color.Transparent;
            }
            else if (statePerson == State.DEFENSE)
            {
                pbPlayer.BackColor = Color.Transparent;
                if (DirectionPlayer == Direction.LEFT)
                    pbPlayer.Image = imgDefenseD;
                else
                    pbPlayer.Image = imgDefense;
            }
            else if (statePerson == State.KNEEL)
            {
                pbPlayer.BackColor = Color.Transparent;
                if (DirectionPlayer == Direction.LEFT)
                    pbPlayer.Image = imgKneelD;
                else
                    pbPlayer.Image = imgKneel;
            }
            else if (statePerson == State.DEAD)
            {
                pbPlayer.BackColor = Color.Transparent;
                if (DirectionPlayer == Direction.LEFT)
                    pbPlayer.Image = imgDeadD;
                else
                    pbPlayer.Image = imgDead;
            }
           
        }

     */

        public void CheckAndActs()
        {
            if (IsJumped)
            {
                Jump();
            }
            else
            {
                JumpForce = 80;

            }
            if (statePerson == State.STAND)
            {
                pbPlayer.BackColor = Color.Transparent;
                if (DirectionPlayer == Direction.LEFT)
                    currentImage = imgStandD;
                else
                    currentImage = imgStand;
            }
            else if (statePerson == State.ATTACK)
            {
                pbPlayer.BackColor = Color.Transparent;
                if (DirectionPlayer == Direction.LEFT)
                    currentImage = imgAttackD;
                else
                    currentImage = imgAttack;
            }
            else if (statePerson == State.ATTACKLEG)
            {
                pbPlayer.BackColor = Color.Transparent;
                if (DirectionPlayer == Direction.LEFT)
                    currentImage = imgAttackLegD;
                else
                    currentImage = imgAttackLeg;

            }
            else if (statePerson == State.ATTACKMAGIC)
            {
                pbPlayer.BackColor = Color.Transparent;
            }
            else if (statePerson == State.DEFENSE)
            {
                pbPlayer.BackColor = Color.Transparent;
                if (DirectionPlayer == Direction.LEFT)
                    currentImage = imgDefenseD;
                else
                    currentImage = imgDefense;
            }
            else if (statePerson == State.KNEEL)
            {
                pbPlayer.BackColor = Color.Transparent;
                if (DirectionPlayer == Direction.LEFT)
                    currentImage = imgKneelD;
                else
                    currentImage = imgKneel;
            }
            else if (statePerson == State.DEAD)
            {
                pbPlayer.BackColor = Color.Transparent;
                if (DirectionPlayer == Direction.LEFT)
                    currentImage = imgDeadD;
                else
                    currentImage = imgDead;
            }

        }

        //The player moves in the given direction
     /*   public void Move(Direction dir)
        {
            if(dir == Direction.LEFT)
            {
                this.pbPlayer.Left = this.pbPlayer.Left - Velocity;
            }
            else if (dir == Direction.RIGHT)
            {
               
                this.pbPlayer.Left = this.pbPlayer.Left + Velocity;
            }
        }
      */
 
        public void Move (Direction dir)
        {
            if(dir==Direction.LEFT)
            {
                this.X -= Velocity;
            }
            else
            {
                this.X += Velocity;
            }
        }

        //Simulates jumping
      /*  public void Jump()
        {
            this.pbPlayer.Top -= JumpForce;
            JumpForce-=10;
            if (JumpForce == 0 && pbPlayer.Top < StandPosition+pbPlayer.Height)
                this.pbPlayer.Top += 5;
            if (pbPlayer.Bottom >= StandPosition)
            {
                pbPlayer.Top = StandPosition - pbPlayer.Height;
                IsJumped = false;
            }
        }
       */ 

        public void Jump ()
        {
            this.Y -= JumpForce;
            JumpForce -= 10;
            if (JumpForce == 0 && Y < StandPosition + currentImage.Height)
                this.Y += 5;
            if (Y+currentImage.Height >= StandPosition)
            {
                Y = StandPosition - currentImage.Height;
                IsJumped = false;
            }
        }

        public void DrawPlayer (Graphics g)
        {
            g.DrawImage(currentImage,X,Y);
        }

        //Shows the magic and returns its reference
         public Magic AttackMagic() // NE E NAPRAVENA
        {
            if (magicList.Count!=0)
            {
                Magic m = magicList.ElementAt(0);
                m.InitializeMagicCordinates(this.X, this.Y, this.currentImage, this.DirectionPlayer);
                statePerson = State.STAND;
              //  magicList.RemoveAt(0);
                return m;
            }
            return null;
        }





        //Checks if the opponent was hurt
        public bool IsSuccessfulAttack(Player opponent)
        {
            if (this.DirectionPlayer == Direction.LEFT)
            {
                if (this.X < opponent.X + opponent.currentImage.Width && this.X > opponent.X)
                {
                    if (opponent.statePerson != State.DEFENSE)
                    {
                        return true;
                    }
                }
            }
            else if (this.DirectionPlayer == Direction.RIGHT)
            {
                if (this.X + this.currentImage.Width > opponent.X && this.X + this.currentImage.Width < opponent.X+opponent.currentImage.Width)
                {
                    if (opponent.statePerson != State.DEFENSE)
                    {
                       // MessageBox.Show("right");
                        return true;
                    }
                }
            }
            return false;
        }

        //Changes statePerson and attacks opponent
        public bool AttackLeg(Player opponent)
        {
            this.statePerson = State.ATTACKLEG;
            return IsSuccessfulAttack(opponent);
        }

        //Changes statePerson and attacks opponent
        public bool Attack(Player opponent)
        {
            this.statePerson = State.ATTACK;
            return IsSuccessfulAttack(opponent);
        }

        public void ChangeState(State state)
        {
            statePerson = state;
        }

        public void DecreaseHealth(int decrease)
        {
            Health -= decrease;
            if(Health<0)
            {

                // mozhebi ne treba ovde da se menuva slikata
                this.currentImage = this.imgDead; //  RABOTI
               
                Health = 0;
            }
        }

        //Checks if the player is in defense or kneel state
        public bool AvoidMagicAttack()
        {
            if (statePerson == State.DEFENSE || statePerson == State.KNEEL)
                return true;
            return false;
        }

        /*public void changeDirection(Direction newDireciton)
        {
            if (newDireciton==Direction.LEFT)
            {
                this.DirectionPlayer = Direction.LEFT;
                if (this.statePerson == State.KNEEL) pbPlayer.Image = this.imgKneelD;
                else if (statePerson == State.ATTACK) pbPlayer.Image = this.imgAttackD;
                else if (statePerson == State.ATTACKLEG) pbPlayer.Image = this.imgAttackLegD;
                else if (statePerson == State.STAND) pbPlayer.Image = this.imgStandD;
                else if (statePerson == State.DEFENSE) pbPlayer.Image = this.imgDefenseD;
                else if (statePerson == State.DEAD) pbPlayer.Image = this.imgDeadD;
                else MessageBox.Show("OVA NE TREBA DA SE JAVI");
            }
            else
            {
                this.DirectionPlayer = newDireciton;
                if (this.statePerson == State.KNEEL) pbPlayer.Image = this.imgKneel;
                else if (statePerson == State.ATTACK) pbPlayer.Image = this.imgAttack;
                else if (statePerson == State.ATTACKLEG) pbPlayer.Image = this.imgAttackLeg;
                else if (statePerson == State.STAND) pbPlayer.Image = this.imgStand;
                else if (statePerson == State.DEFENSE) pbPlayer.Image = this.imgDefense;
                else if (statePerson == State.DEAD) pbPlayer.Image = this.imgDead;
                else MessageBox.Show("OVA NE TREBA DA SE JAVI");
            }
        }*/

        public void changeDirection(Direction newDirection)
        {
            DirectionPlayer = newDirection;
        }
    }
}
