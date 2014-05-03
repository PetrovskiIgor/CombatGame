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
        STAND,
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
        public int StandPosition { get; set; }
        public Direction DirectionPlayer { get; set; }
        State statePerson { get; set; }

        public Image stand;
        public Image attack;
        public Image attackLeg;
        public Image attackMagic;
        public Image defense;
        public Image jump;
        public Image kneel;

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
            pbPlayer = new PictureBox();
            IsJumped = false;
            StandPosition = pbPlayer.Bottom;
            DirectionPlayer = Direction.UNDEFINED;
        }

        public void check()
        {
            if (IsJumped)
            {
                Jump();
            }
            else
            {
                JumpForce = 30;
            }
            if (statePerson == State.STAND)
            {
                pbPlayer.BackColor = Color.Black;
            }
            else if (statePerson == State.ATTACK)
            {
                pbPlayer.BackColor = Color.Red;
            }
            else if (statePerson == State.ATTACKLEG)
            {
                pbPlayer.BackColor = Color.Purple;
            }
            else if (statePerson == State.ATTACKMAGIC)
            {
                pbPlayer.BackColor = Color.Yellow;
                AttackMagic();
            }
            else if (statePerson == State.DEFENSE)
            {
                pbPlayer.BackColor = Color.White;
            }
            else if (statePerson == State.KNEEL)
            {
                pbPlayer.BackColor = Color.Blue;
            }
        }

        public void Move(Direction dir)
        {
            this.DirectionPlayer = dir;
            this.statePerson = State.STAND;
            if (this.DirectionPlayer == Direction.LEFT)
            {
                this.pbPlayer.Left = this.pbPlayer.Left - Velocity;
            }
            else if (this.DirectionPlayer == Direction.RIGHT)
            {
                this.pbPlayer.Left = this.pbPlayer.Left + Velocity;
            }
        }

        public void Jump()
        {
            this.pbPlayer.Top -= JumpForce;
            JumpForce--;
            this.pbPlayer.Top += 5;
            if (pbPlayer.Bottom <= StandPosition)
            {
                pbPlayer.Top = StandPosition + pbPlayer.Height;
                IsJumped = false;
            }
        }

        public void AttackMagic()
        {
            if (magicList != null)
            {
                magicList.ElementAt(0).ShowMagic(this.pbPlayer, this.DirectionPlayer);
                statePerson = State.STAND;
            }
        }

        public void Attack(Player p)
        {

        }

        public void ChangeState(State state)
        {
            statePerson = state;
        }

        public void DecreaseHealth(int decrease)
        {
            Health -= decrease;
        }

    }
}
