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
        int pickAForm; // 0 znachi na enter da se selektira NewGame, 1 Options, 2 Exit

        Image imgNewGame = Image.FromFile("imgNewGame2.png");
        Image imgNewGameSelected = Image.FromFile("imgNewGameSelected.png");

        Image imgOptions = Image.FromFile("imgOptions2.png");
        Image imgOptionsSelected = Image.FromFile("imgOptionsSelected.png");

        Image imgExit = Image.FromFile("imgExit.png");
        Image imgExitSelected = Image.FromFile("imgExitSelected.png");

        
        public frmMenu()
        {
            InitializeComponent();
          
       
            bmBackground = new PPPBitmap(new Bitmap("backgroundMainMenu.jpg"), "backgroundMainMenu.jpg");
            
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
           // this.pbNewGame.Image = imgNewGameSelected;
            pickAForm = 0;
            Invalidate();
            
           
        }

        private void lblNewGame_Click(object sender, EventArgs e)
        {
            
           
        }

        private void lblOptions_Click(object sender, EventArgs e)
        {
            
            
            
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
            e.Graphics.Clear(Color.White);
            e.Graphics.DrawImage(bmBackground.Bitmap, 0, 0, this.Width, this.Height);
        }

        private void pbOptions_Click(object sender, EventArgs e)
        {
            fOptions = new frmOptions(this);
            this.Hide();
            fOptions.Show();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbNewGame_Click(object sender, EventArgs e)
        {
            fPickPlayer = new frmPickPlayer(this);
            this.Hide();
            fPickPlayer.Show();
        }

        private void frmMenu_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void pbExit_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();

            tt.SetToolTip(pbExit, "Don't exit, you will regret it..");

            pbNewGame.Image = imgNewGame;
            pbOptions.Image = imgOptions;
            pbExit.Image = imgExitSelected;
        }

       
        private void selectForm(Boolean up)
        {
            if (up)
            {
                if (pickAForm == 0)
                {
                    pickAForm = 2;
                }
                else
                {
                    pickAForm--;
                }
            }
            else
            {
                pickAForm = (pickAForm + 1) % 3;
            }
            
            pbNewGame.Image = imgNewGame;
            pbOptions.Image = imgOptions;
            pbExit.Image = imgExit;



            if (pickAForm == 0)
            {
                pbNewGame.Image = imgNewGameSelected;
            }
            else if (pickAForm == 1)
            {
                pbOptions.Image = imgOptionsSelected;
            }
            else if (pickAForm == 2)
            {
                pbExit.Image = imgExitSelected;
            }
            else
            {
                // ne smee da vleze ovde
                MessageBox.Show("IMA GRESHKAA!!!");
            }
        }

        private void selectFormOnDown()
        {

        }

        private void frmMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                actOnEnter();
                
            }
           if (e.KeyCode == Keys.Up)
            {
                selectForm(true); 

            }
            else if (e.KeyCode == Keys.Down)
            {
                selectForm(false); 
            }
            else if (e.KeyCode == Keys.Left)
            {
                selectForm(true);
            }
            else if (e.KeyCode == Keys.Right)
            {
                selectForm(false); 
            }
        }

        private void pbOptions_MouseHover(object sender, EventArgs e)
        {
            pbNewGame.Image = imgNewGame;
            pbOptions.Image = imgOptionsSelected;
            pbExit.Image = imgExit;
        }

        private void pbNewGame_MouseHover(object sender, EventArgs e)
        {
            pbNewGame.Image = imgNewGameSelected;
            pbOptions.Image = imgOptions;
            pbExit.Image = imgExit;
        }


        private void actOnEnter()
        {
            if (pickAForm == 0)
            {
                if (fPickPlayer == null)
                {
                    fPickPlayer = new frmPickPlayer(this);
                }
                this.Hide();
                fPickPlayer.Show();
            }
            else if (pickAForm == 1)
            {
                if (fOptions == null)
                {
                    fOptions = new frmOptions(this);
                }
                this.Hide();
                fOptions.Show();
            }
            else if (pickAForm == 2)
            {
                this.Close();
            }
        }
       

        

        
    }
}
