using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace TicTacTOe
{
    public class GameRules
    {
        List<PictureBox> boxes;
        PlayingPanel pl;
        public bool playerTicTurn = true;
        public static int ticksore;
        public static int crossscore;
        Form1 mainForm;

        public GameRules(List<PictureBox> boxes, PlayingPanel pl, Form1 mainForm)
        {
            this.mainForm = mainForm;
            this.boxes = boxes;
            this.pl = pl;
        }

        public void selectBox(int index)
        {
            if (boxes[index].Image == null)
            {
                if (playerTicTurn == true)
                {
                    boxes[index].Image = pl.tic;
                    playerTicTurn = false;
                    mainForm.pictureBox1.BackColor = Color.Transparent;
                    mainForm.pictureBox2.BackColor = Color.DeepSkyBlue;
                }
                else if (playerTicTurn == false)
                {
                    boxes[index].Image = pl.cross;
                    playerTicTurn = true;
                    mainForm.pictureBox2.BackColor = Color.Transparent;
                    mainForm.pictureBox1.BackColor = Color.DeepSkyBlue;
                }
            }
        }

        public void checkWin(int index)
        {
            Console.WriteLine(index);
            if (index == 0)
            {
                Algorithm(0, 1, 2);
                Algorithm(0, 3, 6);
                Algorithm(0, 4, 8);
            }
            else if (index == 1)
            {
                Algorithm(0, 1, 2);
                Algorithm(1, 3, 6);
            }

            else if (index == 2)
            {
                Algorithm(0, 1, 2);
                Algorithm(2, 3, 6);
                Algorithm(2, 2, 4);
            }
            else if (index == 3)
            {
                Algorithm(3, 1, 2);
                Algorithm(0, 3, 6);
            }
            else if (index == 4)
            {
                Algorithm(3, 1, 2);
                Algorithm(1, 3, 6);
                Algorithm(0, 4, 8);
                Algorithm(2, 2, 4);
            }
            else if (index == 5)
            {
                Algorithm(3, 1, 2);
                Algorithm(2, 3, 6);
            }
            else if (index == 6)
            {
                Algorithm(6, 1, 2);
                Algorithm(0, 3, 6);
                Algorithm(2, 2, 4);
            }
            else if (index == 7)
            {
                Algorithm(6, 1, 2);
                Algorithm(1, 3, 6);
            }
            else if (index == 8)
            {
                Algorithm(6, 1, 2);
                Algorithm(2, 3, 6);
                Algorithm(0, 4, 8);
            }
            
            
        }

        void Algorithm(int index,int entry1, int entry2)
        {
            if (boxes[index].Image == pl.tic && boxes[index+entry1].Image == pl.tic && boxes[index+entry2].Image == pl.tic)
            {
                ticksore++;
                mainForm.label1.Text = ticksore.ToString();
                if (MessageBox.Show("round won by tick player") == DialogResult.OK)
                {
                    Restart();
                }
            }
            if (boxes[index].Image == pl.cross && boxes[index+entry1].Image == pl.cross && boxes[index+entry2].Image == pl.cross)
            {
                crossscore++;
                mainForm.label2.Text = crossscore.ToString();
                if (MessageBox.Show("round won by cross player") == DialogResult.OK)
                {
                    Restart();
                }
            }
        }

        public void Restart()
        {
            foreach (PictureBox box in boxes)
            {
                box.Image = null;
            }
        }
        public void ResetScore()
        {
            Restart();
            crossscore = 0;
            mainForm.label2.Text = crossscore.ToString();
            ticksore = 0;
            mainForm.label1.Text = ticksore.ToString();
        }
        public void CheckDraw()
        {
            int i = 0;
            foreach (PictureBox box in boxes)
            {
                if (box.Image != null)
                {
                    i++;
                }
            }

            if (i == 9)
            {
                if (MessageBox.Show("Draw") == DialogResult.OK)
                {
                    foreach (PictureBox box in boxes)
                    {
                        box.Image = null;

                    }
                }
                
            }
        }

        
    }
}
