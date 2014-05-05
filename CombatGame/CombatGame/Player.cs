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
        MOVINGLEFT,
        MOVINGRIGHT,
        ATTACK,
        ATTACKLEG,
        ATTACKMAGIC,
        DEFENSE,
        KNEEL
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

        public Image imgStand;
        public Image imgAttack;
        public Image imgAttackLeg;
        public Image imgAttackMagic;
        public Image imgDefense;
        public Image imgJump;
        public Image imgKneel;
        public Image imgDead;


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
               
                pbPlayer.Image = imgStand;
            }
            else if (statePerson == State.ATTACK)
            {
                pbPlayer.BackColor = Color.Transparent;
                pbPlayer.Image = imgAttack;
            }
            else if (statePerson == State.ATTACKLEG)
            {
                pbPlayer.BackColor = Color.Transparent;
                pbPlayer.Image = imgAttackLeg;
                
            }
            else if (statePerson == State.ATTACKMAGIC)
            {
                pbPlayer.BackColor = Color.Transparent;
            }
            else if (statePerson == State.DEFENSE)
            {
                pbPlayer.BackColor = Color.Transparent;
                pbPlayer.Image = imgDefense;
            }
            else if (statePerson == State.KNEEL)
            {
                pbPlayer.BackColor = Color.Transparent;
                pbPlayer.Image = imgKneel;

            }
            else if (statePerson == State.MOVINGLEFT)
            {

            }
            else if (statePerson == State.MOVINGRIGHT)
            {

            }
        }

        //The player moves in the given direction
        public void Move(Direction dir)
        {
            this.DirectionPlayer = dir;
            if (this.DirectionPlayer == Direction.LEFT)
            {
                this.statePerson = State.MOVINGLEFT;
                this.pbPlayer.Left = this.pbPlayer.Left - Velocity;
            }
            else if (this.DirectionPlayer == Direction.RIGHT)
            {
                this.statePerson = State.MOVINGRIGHT;
                this.pbPlayer.Left = this.pbPlayer.Left + Velocity;
            }
        }

        //Simulates jumping
        public void Jump()
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

        //Shows the magic and returns its reference
        public Magic AttackMagic()
        {
            if (magicList.Count!=0)
            {
                Magic m = magicList.ElementAt(0);
                m.ShowMagic(this.pbPlayer, this.DirectionPlayer);
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
                if (this.pbPlayer.Left < opponent.pbPlayer.Left + opponent.pbPlayer.Width && this.pbPlayer.Left > opponent.pbPlayer.Left)
                {
                    if (opponent.statePerson != State.DEFENSE)
                    {
                        return true;
                    }
                }
            }
            else if (this.DirectionPlayer == Direction.RIGHT)
            {
                if (this.pbPlayer.Left + this.pbPlayer.Width > opponent.pbPlayer.Left && this.pbPlayer.Left + this.pbPlayer.Width < opponent.pbPlayer.Right)
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
                this.pbPlayer.Image = this.imgDead; // NE RABOTI
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
    }
}
