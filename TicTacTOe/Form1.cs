using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacTOe
{
    public partial class Form1 : Form
    {
        PlayingPanel pl;
        public Form1()
        {
            InitializeComponent();
            pl = new PlayingPanel(this);
            label1.Text = GameRules.ticksore.ToString();
            label2.Text = GameRules.crossscore.ToString();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            pl.gm.ResetScore();
        }

        private void x_Click(object sender, EventArgs e)
        {
            pl.gm.Restart();
        }
    }
}
