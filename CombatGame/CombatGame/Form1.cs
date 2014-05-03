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
        public frmMenu()
        {
            InitializeComponent();
        }

        private void lblNewGame_Click(object sender, EventArgs e)
        {
            frmPickPlayer fPickPlayer = new frmPickPlayer(this);
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

        
    }
}
