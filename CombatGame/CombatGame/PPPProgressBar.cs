using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatGame
{
    class PPPProgressBar
    {
        int Value { get; set; }
        int X { get; set; }
        int Y { get; set; }
        int Width { get; set; }
        int Height { get; set; }
        
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
            g.FillRectangle(new SolidBrush(Color.White), this.X + this.Width * this.Value / 100, this.Y, this.Width - this.Width * this.Value / 100, this.Height);
        }
    }
}
