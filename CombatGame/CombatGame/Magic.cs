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
        public static int PictureBoxSize = 30;
        
        public string Name { get; set; }                // Name of the Magic
        public string Description { get; set; }         // Magic Description
        public int Power { get; set; }                  // Power of the Magic
        public Image MagicImage { get; set; }           // Image of the Magic
        public PictureBox PicBoxImage { get; set; }     // Picture Box for the Image 
        public int Velocity { get; set; }               // Velocity of magic moving
        Direction DirOfMoving;                          // Direcetion of Magic moving


        public Magic () // Default Constructor
        {
            this.Name = null;
            this.Description = null;
            this.MagicImage = null;
            this.PicBoxImage = null;
            DirOfMoving = Direction.UNDEFINED;
        }

        public Magic (string Name, string Description, int Power, Image MagicImage, int Velocity) //constructor
        {
            this.Name = Name;
            this.Description = Description;
            this.Power = Power;
            this.MagicImage = MagicImage;
            this.Velocity = Velocity;
            this.DirOfMoving = Direction.UNDEFINED;
            this.PicBoxImage = new PictureBox();
            this.PicBoxImage.Size = new Size(PictureBoxSize, PictureBoxSize);
            PicBoxImage.Image = MagicImage;
            PicBoxImage.Hide();
        } 

        public Magic (string Name, string Description, int Power) // Constructor
        {
            this.Name = Name;
            this.Description = Description;
            this.Power = Power;
            this.MagicImage = null;
            this.PicBoxImage = null;
            this.DirOfMoving = Direction.UNDEFINED;
        }

        public Magic(string Name, string Description, int Power, int Velocity) // Constructor
        {
            this.Name = Name;
            this.Description = Description;
            this.Power = Power;
            this.Velocity = Velocity;
            DirOfMoving = Direction.UNDEFINED;
            this.MagicImage = null;
            this.PicBoxImage = null;
        }

        public void Move (Direction dir) // Moving the Magic 
        {
            this.DirOfMoving = dir;
            if (DirOfMoving == Direction.LEFT)
            {
                this.PicBoxImage.Left -= Velocity;
            }
            else
            {
                this.PicBoxImage.Left += Velocity;
            }
        }

        public void ShowMagic (PictureBox playerPictureBox) // Displaing the Magic which the Player is using for attack
        {
            this.PicBoxImage.Left = playerPictureBox.Right;
            this.PicBoxImage.Top = (playerPictureBox.Bottom + playerPictureBox.Right) / 2;
            this.PicBoxImage.Show();
        }

        public void HideMagic ()
        {
            this.PicBoxImage.Hide();
        }

        

    }
}
