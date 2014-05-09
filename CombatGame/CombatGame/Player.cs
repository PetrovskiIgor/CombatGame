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
        public List<Magic> magicList;
        public int Velocity { get; set; }
        public int JumpForce = 64;
        public bool IsJumped { get; set; }
        public static int StandPosition = 800; //treba da se smeni
        public Direction DirectionPlayer { get; set; }
        State statePerson { get; set; }
        public static int HandPower = 5 ;
        public static int LegPower = 7;
        public Image currentImage;
        public int X {get; set;}
        public int Y {get; set;}
        public int Height { get { return currentImage.Height*5/4; } }
        public int Width { get { return currentImage.Width*5/4; } }
        public int Left { get { return X - Width / 2; } }
        public int Right { get { return X + Width / 2; } }
        public int Top { get { return Y - Height / 2; } }
        public int Bottom { get { return Y + Height / 2; } }

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
            IsJumped = false;
            DirectionPlayer = Direction.UNDEFINED;
            this.Velocity = 10; // treba da se smeni!!!!!!!!!
            this.X = 50;
            this.Y = 50;
        }

        // Metod za setiranje na slikata pri startuvanje na borbata
        public void SetCurrentImage (bool FirstPlayer)
        {
            if(FirstPlayer)
            {
                this.currentImage = imgStandD;
            }
            else
            {
                this.currentImage = imgStand;
            }
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
            IsJumped = false;
            DirectionPlayer = Direction.UNDEFINED;
            this.Velocity = 10;
        }

        //Checks in which state the player is and acts if needed
        public bool CheckAndActs()
        {
            if (statePerson == State.DEAD)
            {
                if (DirectionPlayer == Direction.LEFT)
                    currentImage = imgDeadD;
                else
                    currentImage = imgDead;
                return false;
            }
            if (IsJumped)
            {
                Jump();
            }
            else
            {
                JumpForce = 64;

            }
            if (statePerson == State.STAND)
            {
                if (DirectionPlayer == Direction.LEFT)
                    currentImage = imgStandD;
                else
                    currentImage = imgStand;
            }
            else if (statePerson == State.ATTACK)
            {
                if (DirectionPlayer == Direction.LEFT)
                    currentImage = imgAttackD;
                else
                    currentImage = imgAttack;
            }
            else if (statePerson == State.ATTACKLEG)
            {
                if (DirectionPlayer == Direction.LEFT)
                    currentImage = imgAttackLegD;
                else
                    currentImage = imgAttackLeg;

            }
            else if (statePerson == State.ATTACKMAGIC)
            {
            }
            else if (statePerson == State.DEFENSE)
            {
                if (DirectionPlayer == Direction.LEFT)
                    currentImage = imgDefenseD;
                else
                    currentImage = imgDefense;
            }
            else if (statePerson == State.KNEEL)
            {
                if (DirectionPlayer == Direction.LEFT)
                    currentImage = imgKneelD;
                else
                    currentImage = imgKneel;
            }
            return true;

        }

        //The player moves in the given direction
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
        public void Jump ()
        {
            this.Y -= JumpForce;
            JumpForce -= 8;
            if (JumpForce == 0 && Y-this.Height/2 < StandPosition + currentImage.Height)
                this.Y += 5;
            if (Y + Height >= StandPosition)
            {
                Y = StandPosition - Height;
                IsJumped = false;
            }
        }

        public void DrawPlayer (Graphics g)
        {
            Rectangle r = new Rectangle(X - currentImage.Width / 2, Y - currentImage.Height / 2, this.Width, this.Height);
            g.DrawImage(currentImage,r);
        }

        //Shows the magic and returns its reference
         public Magic AttackMagic() // NE E NAPRAVENA
        {
            if (magicList.Count!=0)
            {
                Magic m = magicList.ElementAt(0);
                m.InitializeMagicCordinates(this.X, this.Y, this.currentImage, this.DirectionPlayer);
                statePerson = State.STAND;
                magicList.RemoveAt(0);
                return m;
            }
            return null;
        }



        //Checks if the opponent was hurt
        public bool IsSuccessfulAttack(Player opponent)
        {
            if (this.DirectionPlayer == Direction.LEFT)
            {
                if (this.X-Width/2 < opponent.X+Width/3 && this.X-Width/2 > opponent.X-Width/3 && Math.Abs(this.Y-opponent.Y)<Height/4)
                {
                    if (opponent.statePerson != State.DEFENSE)
                    {
                        return true;
                    }
                }
            }
            else if (this.DirectionPlayer == Direction.RIGHT)
            {
                if (this.X + Width / 2 > opponent.X - Width / 3 && this.X + Width / 2 < opponent.X+Width/3 && Math.Abs(this.Y - opponent.Y) < Height / 4) 
                {
                    if (opponent.statePerson != State.DEFENSE)
                    {
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
            if (Math.Abs(this.X - opponent.X) > 2*Width/3)
            {
                this.Move(this.DirectionPlayer);
            }
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
            if(Health<=0)
            { 

                this.statePerson = State.DEAD;
                this.Y += 100;
                if (DirectionPlayer == Direction.LEFT)
                {
                    this.X += 100;
                }
                else
                    this.X -= 100;
               
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

        public void changeDirection(Direction newDirection)
        {
            DirectionPlayer = newDirection;
        }
    }
}
