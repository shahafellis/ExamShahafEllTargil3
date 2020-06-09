using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamShahafEllTargil3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void upPictureBx_Click(object sender, EventArgs e)
        {
            if (ballPictureBx.Location.Y > 3)
            {
                ballPictureBx.Location = new Point(ballPictureBx.Location.X, ballPictureBx.Location.Y - 10);
                Thread.Sleep(50);

            }
        }

        private void rightPicturebx_Click_1(object sender, EventArgs e)
        {
            if (ballPictureBx.Location.X < 420)
            {
                ballPictureBx.Location = new Point(ballPictureBx.Location.X + 10, ballPictureBx.Location.Y);
                Thread.Sleep(50);


            }
        }

        private void downPictureBx_Click_1(object sender, EventArgs e)
        {
            if (ballPictureBx.Location.Y < 350)
            {
                ballPictureBx.Location = new Point(ballPictureBx.Location.X, ballPictureBx.Location.Y + 10);
                Thread.Sleep(50);
            }
        }

        private void leftPicutreBx_Click(object sender, EventArgs e)
        {
            if (ballPictureBx.Location.X > 4)
            {
                ballPictureBx.Location = new Point(ballPictureBx.Location.X - 10, ballPictureBx.Location.Y);
                Thread.Sleep(50);


            }
        }
    }
}

