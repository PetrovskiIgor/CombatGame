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
        public string Name { get; set; } // Name of the Magic
        public string Description { get; set; } // Magic Description
        public int Power { get; set; } //Power of the Magic
        public Image MagicImage; // Image of the Magic
        public PictureBox PicBoxImage; // Picture Box for the Image 

        public Magic (string Name, string Description, int Power, Image MagicImage, PictureBox picBoxImage) //constructor
        {
            this.Name = Name;
            this.Description = Description;
            this.Power = Power;
            this.MagicImage = MagicImage;
            this.PicBoxImage = picBoxImage;
        } 



    }
}
