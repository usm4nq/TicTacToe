using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacTOe
{
    public class PlayingPanel
    {
        public GameRules gm;
        public Image tic = global::TicTacTOe.Properties.Resources.Tic;
        public Image cross = global::TicTacTOe.Properties.Resources.Cross;
        Form1 mainForm;

        public PlayingPanel(Form1 mainForm)
        {
            this.mainForm = mainForm;
            gm = new GameRules(this.boxes, this, mainForm);

            this.panel1 = new System.Windows.Forms.Panel();
            this.boxes.Add(new PictureBox());
            this.boxes.Add(new PictureBox());
            this.boxes.Add(new PictureBox());
            this.boxes.Add(new PictureBox());
            this.boxes.Add(new PictureBox());
            this.boxes.Add(new PictureBox());
            this.boxes.Add(new PictureBox());
            this.boxes.Add(new PictureBox());
            this.boxes.Add(new PictureBox());
            // 
            // boxes[0]
            // 
            this.boxes[0].Location = new System.Drawing.Point(29, 44);
            this.boxes[0].Name = "boxes[0]";
            this.boxes[0].Size = new System.Drawing.Size(100, 50);
            this.boxes[0].TabIndex = 0;
            this.boxes[0].TabStop = false;
            this.boxes[0].SizeMode = PictureBoxSizeMode.Zoom;
            this.boxes[0].BorderStyle = BorderStyle.FixedSingle;
            // 
            // boxes[1]
            // 
            this.boxes[1].Location = new System.Drawing.Point(151, 44);
            this.boxes[1].Name = "boxes[1]";
            this.boxes[1].Size = new System.Drawing.Size(100, 50);
            this.boxes[1].TabIndex = 1;
            this.boxes[1].TabStop = false; 
            this.boxes[1].SizeMode = PictureBoxSizeMode.Zoom;
            this.boxes[1].BorderStyle = BorderStyle.FixedSingle;
            // 
            // boxes[2]
            // 
            this.boxes[2].Location = new System.Drawing.Point(274, 44);
            this.boxes[2].Name = "boxes[2]";
            this.boxes[2].Size = new System.Drawing.Size(100, 50);
            this.boxes[2].TabIndex = 2;
            this.boxes[2].TabStop = false;
            this.boxes[2].SizeMode = PictureBoxSizeMode.Zoom;
            this.boxes[2].BorderStyle = BorderStyle.FixedSingle;
            // 
            // boxes[3]
            // 
            this.boxes[3].Location = new System.Drawing.Point(29, 116);
            this.boxes[3].Name = "boxes[3]";
            this.boxes[3].Size = new System.Drawing.Size(100, 50);
            this.boxes[3].TabIndex = 3;
            this.boxes[3].TabStop = false;
            this.boxes[3].SizeMode = PictureBoxSizeMode.Zoom;
            this.boxes[3].BorderStyle = BorderStyle.FixedSingle;
            // 
            // boxes[4]
            // 
            this.boxes[4].Location = new System.Drawing.Point(151, 116);
            this.boxes[4].Name = "boxes[4]";
            this.boxes[4].Size = new System.Drawing.Size(100, 50);
            this.boxes[4].TabIndex = 4;
            this.boxes[4].TabStop = false;
            this.boxes[4].SizeMode = PictureBoxSizeMode.Zoom;
            this.boxes[4].BorderStyle = BorderStyle.FixedSingle;
            // 
            // boxes[5]
            // 
            this.boxes[5].Location = new System.Drawing.Point(274, 116);
            this.boxes[5].Name = "boxes[5]";
            this.boxes[5].Size = new System.Drawing.Size(100, 50);
            this.boxes[5].TabIndex = 5;
            this.boxes[5].TabStop = false;
            this.boxes[5].SizeMode = PictureBoxSizeMode.Zoom;
            this.boxes[5].BorderStyle = BorderStyle.FixedSingle;
            // 
            // boxes[6]
            // 
            this.boxes[6].Location = new System.Drawing.Point(29, 190);
            this.boxes[6].Name = "boxes[6]";
            this.boxes[6].Size = new System.Drawing.Size(100, 50);
            this.boxes[6].TabIndex = 6;
            this.boxes[6].TabStop = false;
            this.boxes[6].SizeMode = PictureBoxSizeMode.Zoom;
            this.boxes[6].BorderStyle = BorderStyle.FixedSingle;
            // 
            // boxes[7]
            // 
            this.boxes[7].Location = new System.Drawing.Point(151, 190);
            this.boxes[7].Name = "boxes[7]";
            this.boxes[7].Size = new System.Drawing.Size(100, 50);
            this.boxes[7].TabIndex = 7;
            this.boxes[7].TabStop = false;
            this.boxes[7].SizeMode = PictureBoxSizeMode.Zoom;
            this.boxes[7].BorderStyle = BorderStyle.FixedSingle;
            // 
            // boxes[8]
            // 
            this.boxes[8].Location = new System.Drawing.Point(274, 190);
            this.boxes[8].Name = "boxes[8]";
            this.boxes[8].Size = new System.Drawing.Size(100, 50);
            this.boxes[8].TabIndex = 8;
            this.boxes[8].TabStop = false;
            this.boxes[8].SizeMode = PictureBoxSizeMode.Zoom;
            this.boxes[8].BorderStyle = BorderStyle.FixedSingle;
            //
            // panel1
            //
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.BackColor = Color.LightGray;
            this.panel1.Controls.Add(boxes[0]);
            this.panel1.Controls.Add(boxes[1]);
            this.panel1.Controls.Add(boxes[2]);
            this.panel1.Controls.Add(boxes[3]);
            this.panel1.Controls.Add(boxes[4]);
            this.panel1.Controls.Add(boxes[5]);
            this.panel1.Controls.Add(boxes[6]);
            this.panel1.Controls.Add(boxes[7]);
            this.panel1.Controls.Add(boxes[8]);

            this.panel1.Size = new Size(mainForm.ClientSize.Width-100, mainForm.ClientSize.Height);

            this.boxes[0].Click += new EventHandler(PlayingPanel_Click);
            this.boxes[1].Click += new EventHandler(boxes1click);
            this.boxes[2].Click += new EventHandler(boxes2click);
            this.boxes[3].Click += new EventHandler(boxes3click);
            this.boxes[4].Click += new EventHandler(boxes4click);
            this.boxes[5].Click += new EventHandler(boxes5click);
            this.boxes[6].Click += new EventHandler(boxes6click);
            this.boxes[7].Click += new EventHandler(boxes7click);
            this.boxes[8].Click += new EventHandler(boxes8click);

            
            this.mainForm.Controls.Add(panel1);

        }

        

        void PlayingPanel_Click(object sender, EventArgs e)
        {
            boxClick(0);
            
        }

        void boxes1click(object sender, EventArgs e)
        {
            boxClick(1);
        }

        void boxes2click(object sender, EventArgs e)
        {
            boxClick(2);
        }

        void boxes3click(object sender, EventArgs e)
        {
            boxClick(3);
        }

        void boxes4click(object sender, EventArgs e)
        {
            boxClick(4);
        }

        void boxes5click(object sender, EventArgs e)
        {
            boxClick(5);
        }

        void boxes6click(object sender, EventArgs e)
        {

            boxClick(6);
        }

        void boxes7click(object sender, EventArgs e)
        {
            boxClick(7);
        }

        void boxes8click(object sender, EventArgs e)
        {

            boxClick(8);
        }

        void boxClick(int index)
        {
            gm.selectBox(index);
            gm.checkWin(index);
            gm.CheckDraw();
        }


        private List<System.Windows.Forms.PictureBox> boxes = new List<System.Windows.Forms.PictureBox>();
        private System.Windows.Forms.Panel panel1;

    }
}
