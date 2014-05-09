using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatGame
{
    public class PPPProgressBar
    {
        public int Value { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        
        public PPPProgressBar(int x, int y,int width,int height)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
            this.Value = 100;
        }

        public void Draw(Graphics g)
        {
            //g.DrawRectangle(new Pen(Color.Black), this.X, this.Y, this.Width, this.Height);
            g.FillRectangle(new SolidBrush(Color.Green), this.X, this.Y, this.Width * this.Value / 100, this.Height);
            g.FillRectangle(new SolidBrush(Color.Red), this.X + this.Width * this.Value / 100, this.Y, this.Width - this.Width * this.Value / 100, this.Height);
        }
    }
}
