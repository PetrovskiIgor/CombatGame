using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatGame
{
    public partial class frmFight : Form
    {
        
        SoundPlayer soundPlayer;
        public frmFight()
        {
            InitializeComponent();


            // za da go prepoznae file-ot  EyeOfTheTiger.wav
            //
            // EyeOfTheTiger.wav vo properties Copy to Output directory: copy if newer!!!
            soundPlayer = new SoundPlayer("EyeOfTheTiger.wav");
            
            
            soundPlayer.Play();
        }



        private void frmFight_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Application.Exit();
        }
    }
}
