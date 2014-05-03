﻿using System;
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
        Player playerOne;
        Player playerTwo;
        Magic startedMagic;
        bool a, d, left, right;
        bool gameIsFinished;
        Timer timer;


        public frmFight()
        {
            InitializeComponent();


            // za da go prepoznae file-ot  EyeOfTheTiger.wav
            //
            // EyeOfTheTiger.wav vo properties Copy to Output directory: copy if newer!!!
            soundPlayer = new SoundPlayer("EyeOfTheTiger.wav");
            
            
            soundPlayer.Play();
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }



        private void frmFight_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Application.Exit();
        }

        private void frmFight_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.W)
            {
                playerOne.IsJumped = true;
            }
            else if(e.KeyCode==Keys.Up)
            {
                playerTwo.IsJumped = true;
            }
            else if (e.KeyCode==Keys.A)
            {
                a = true;
            }
            else if(e.KeyCode==Keys.D)
            {
                d = true;
            }
            else if(e.KeyCode==Keys.Left)
            {
                left = true;
            }
            else if (e.KeyCode==Keys.Right)
            {
                right = true;
            }
            
        }

        private void frmFight_KeyUp(object sender, KeyEventArgs e)
        {

        }

        void timer_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
