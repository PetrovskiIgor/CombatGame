﻿using System;
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
    public partial class frmPickPlayer : Form
    {
        frmMenu MainMenu { get; set; } // formata roditel (MENU)
        frmFight Game;
        public frmPickPlayer(frmMenu menu)
        {
            InitializeComponent();
            MainMenu = menu;
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu.Show();
        }

        private void lblStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game = new frmFight();

            Game.Show();

        }
    }
}
