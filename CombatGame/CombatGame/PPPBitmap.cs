using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatGame
{
    public class PPPBitmap // klasa koja sodrzhi Bitmap i + ime od file-ot na slikata
    {
        public Bitmap Bitmap { get; set; }
        public String FileName {get;set;}


        public PPPBitmap(Bitmap bitmap, String fileName) 
        {
               Bitmap = bitmap;
               FileName = fileName;
        }
            

    }
}
