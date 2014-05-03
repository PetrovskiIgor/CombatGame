using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatGame
{
    public partial class frmMenu : Form
    {
        frmPickPlayer fPickPlayer;
        frmOptions fOptions;
        PPPBitmap bmBackground;
        public frmMenu()
        {
            InitializeComponent();
          
       
            bmBackground = new PPPBitmap(new Bitmap("backgroundMainMenu.jpg"), "backgroundMainMenu.jpg");
            Invalidate();
           
        }

        private void lblNewGame_Click(object sender, EventArgs e)
        {
            fPickPlayer = new frmPickPlayer(this);
            this.Hide();
            fPickPlayer.Show();
           
        }

        private void lblOptions_Click(object sender, EventArgs e)
        {
            fOptions = new frmOptions(this);
            this.Hide();
            fOptions.Show();
            
            
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void frmMenu_Paint(object sender, PaintEventArgs e)
        {
           // MessageBox.Show(this.Left + " " + this.Bottom + " " + this.Width + " " + this.Height);
           // e.Graphics.DrawImage(bitmapHorny.Bitmap, xHorny, yHorny, 100, 100);
            e.Graphics.DrawImage(bmBackground.Bitmap, 0, 0, this.Width, this.Height);
        }

        
    }
}
