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
        JUMP,
        KNEEL
    }

    public enum Direction
    {
        LEFT,
        RIGHT,
        JUMP
    }

    public class Player
    {
        public String Name { get; set; }
        public int Health { get; set; }
        public String Description { get; set; }
        public PictureBox pbPlayer;
        public List<Magic> magicList;
        public Image stand;
        public Image attack;
        public Image attackLeg;
        public Image attackMagic;
        public Image defense;
        public Image jump;
        public Image kneel;


        State statePerson { get; set; }

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
            
        }

        public void check()
        {
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

            }
            else if (statePerson == State.DEFENSE)
            {
                pbPlayer.BackColor = Color.White;
            }
            else if (statePerson == State.JUMP)
            {
                pbPlayer.BackColor = Color.Pink;
            }
            else if (statePerson == State.KNEEL)
            {
                pbPlayer.BackColor = Color.Blue;
            }
        }

        public void Move(Direction dir)
        {
            if (dir == Direction.JUMP)
            {

            }
        }

    }
}
