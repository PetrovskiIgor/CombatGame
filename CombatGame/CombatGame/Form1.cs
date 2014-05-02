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
        public frmMenu()
        {
            InitializeComponent();
        }

        private void lblNewGame_Click(object sender, EventArgs e)
        {
            frmPickPlayer fpp = new frmPickPlayer();
            this.Hide();
            fpp.Show();
           
        }

        private void lblOptions_Click(object sender, EventArgs e)
        {
            frmOptions fo = new frmOptions();
            this.Hide();
            fo.Show();
            
            
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
