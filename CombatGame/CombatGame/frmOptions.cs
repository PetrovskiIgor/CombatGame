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
    public partial class frmOptions : Form
    {
        public frmMenu MainMenu {get; set;} // ova e formata roditel (Menu)
        public frmOptions(frmMenu menu)
        {
            InitializeComponent();
            MainMenu  = menu;
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {
            
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu.Show();
        }
    }
}
