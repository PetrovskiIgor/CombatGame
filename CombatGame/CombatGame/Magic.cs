using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatGame
{

    public class Magic
    {
        public string Name { get; set; }                // Name of the Magic
      
        public int Power { get; set; }                  // Power of the Magic
        public Image MagicImageLeft { get; set; }       // Image of the Magic (Left)
        public Image MagicImageRight { get; set; }      // Image of the Magic (Right)
        public int Velocity { get; set; }               // Velocity of magic moving
        public Direction DirOfMoving { get; set; }      // Direcetion of Magic moving
        public int X;
        public int Y;
        public int Height { get { return MagicImageLeft.Height; } }
        public int Width { get { return MagicImageLeft.Width; } }

        public Magic () // Default Constructor
        {
            this.Name = null;
           
            this.MagicImageLeft = null;
            this.MagicImageRight = null;
            DirOfMoving = Direction.UNDEFINED;
        }

        public Magic (string Name, int Power, Image MagicImageLeft, Image MagicImageRight, int Velocity) //constructor
        {
            this.Name = Name;
           
            this.Power = Power;
            this.MagicImageLeft = MagicImageLeft;
            this.MagicImageRight = MagicImageRight;
            this.Velocity = Velocity;
            this.DirOfMoving = Direction.UNDEFINED;

        }

        public Magic(int X, int Y, string Name, int Power, Image MagicImageLeft, Image MagicImageRight, int Velocity) //constructor
        {
            this.Name = Name;

            this.Power = Power;
            this.MagicImageLeft = MagicImageLeft;
            this.MagicImageRight = MagicImageRight;
            this.Velocity = Velocity;
            this.DirOfMoving = Direction.UNDEFINED;
        }


        public Magic (string Name,int Power) // Constructor
        {
            this.Name = Name;
           
            this.Power = Power;
            this.MagicImageLeft = null;
            this.MagicImageRight = null;
            this.DirOfMoving = Direction.UNDEFINED;
        }

        public Magic(string Name,int Power, int Velocity) // Constructor
        {
            this.Name = Name;
           
            this.Power = Power;
            this.Velocity = Velocity;
            DirOfMoving = Direction.UNDEFINED;
            this.MagicImageLeft = null;
            this.MagicImageRight = null;
        }

   /*     public void Move () // Moving the Magic 
        {
            if (DirOfMoving == Direction.LEFT)
            {
                this.PicBoxImage.Left -= Velocity;
            }
            else
            {
                this.PicBoxImage.Left += Velocity;
            }
        }

    */

        public void Move() // Moving the Magic 
        {
            if (DirOfMoving == Direction.LEFT)
            {
               this.X -= Velocity;
            }
            else
            {
                this.X += Velocity;
            }
        }


       public void DrawMagic (Graphics g)
       {
            if(this.DirOfMoving==Direction.LEFT)
            {
                g.DrawImage(MagicImageLeft, this.X-MagicImageLeft.Width/2, this.Y-MagicImageLeft.Height/2);
            }
            else
            {
                g.DrawImage(MagicImageRight, this.X - MagicImageLeft.Width / 2, this.Y - MagicImageLeft.Height / 2);
            }
       }

        public void InitializeMagicCordinates(int plX, int plY,Image player, Direction dir)
        {
            this.DirOfMoving = dir; ;
            if(dir==Direction.LEFT)
            {
                this.X = plX-player.Width/2;
                this.Y = plY;
            }
            else
            {
                this.X = plX + player.Width/2;
                this.Y = plY;
            }
        }
       
       

        public void HideMagic () // Hides the Picture Box of the magic from the display
        {

        }

        

    }
}
