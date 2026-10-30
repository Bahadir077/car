
using System;
using System.Drawing;
using System.Windows.Forms;

namespace car   
{
    public partial class Form1 : Form
    {
        int carX = 100;
        int carY = 380;
        int roadY = 0;
        int seconds = 0;

        bool play = false;

        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 100;
            timer2.Interval = 1000;

            timer1.Tick += timer1_Tick;
            timer2.Tick += timer2_Tick;

            panelRoad.Paint += panelRoad_Paint;

            pictureBoxStart.Click += pictureBoxStart_Click;
            pictureBoxBreak.Click += pictureBoxBreak_Click;

            pictureBoxUp.Click += (s, e) => MoveCar(0, -15);
            pictureBoxDown.Click += (s, e) => MoveCar(0, 15);
            pictureBoxLeft.Click += (s, e) => MoveCar(-15, 0);
            pictureBoxRight.Click += (s, e) => MoveCar(15, 0);

            cmbTime.Items.Add("Slow");
            cmbTime.Items.Add("Normal");
            cmbTime.Items.Add("Fast");
            cmbTime.SelectedIndex = 1;

            cmbTime.SelectedIndexChanged += cmbTime_SelectedIndexChanged;

            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

       
        private void pictureBoxStart_Click(object sender, EventArgs e)
        {
            play = true;
            timer1.Start();
            timer2.Start();
            this.ActiveControl = null;
        }

      
        private void pictureBoxBreak_Click(object sender, EventArgs e)
        {
            play = false;
            timer1.Stop();
            timer2.Stop();
        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            roadY += 10;

            if (roadY >= 100)
                roadY = 0;

            panelRoad.Invalidate();
        }

        
        private void timer2_Tick(object sender, EventArgs e)
        {
            seconds++;
            lblTime.Text = "Time: " + seconds;
        }

      
        private void MoveCar(int x, int y)
        {
            if (!play)
                return;

            carX += x;
            carY += y;

            if (carX < 5) carX = 5;
            if (carX > panelRoad.Width - pictureBoxCar.Width - 5)
                carX = panelRoad.Width - pictureBoxCar.Width - 5;

            if (carY < 5) carY = 5;
            if (carY > panelRoad.Height - pictureBoxCar.Height)
                carY = panelRoad.Height - pictureBoxCar.Height;

            pictureBoxCar.Location = new Point(carX, carY);
        }

    
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                MoveCar(-15, 0);

            if (e.KeyCode == Keys.Right)
                MoveCar(15, 0);

            if (e.KeyCode == Keys.Up)
                MoveCar(0, -15);

            if (e.KeyCode == Keys.Down)
                MoveCar(0, 15);
        }

    
        private void cmbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTime.SelectedIndex == 0)
                timer1.Interval = 200;

            else if (cmbTime.SelectedIndex == 1)
                timer1.Interval = 100;

            else if (cmbTime.SelectedIndex == 2)
                timer1.Interval = 40;
        }

    
        private void panelRoad_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.Clear(Color.Gray);

            for (int i = -100; i < 500; i += 105)
            {
                g.FillRectangle(
                    Brushes.White,
                    134,
                    i + roadY,
                    11,
                    70);
            }
        }

        private void pictureBoxCar_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.SmoothingMode =
                System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            g.FillRectangle(Brushes.Black, 0, 10, 8, 15);
            g.FillRectangle(Brushes.Black, 37, 10, 8, 15);
            g.FillRectangle(Brushes.Black, 0, 35, 8, 15);
            g.FillRectangle(Brushes.Black, 37, 35, 8, 15);

            g.FillEllipse(Brushes.DarkRed, 5, 0, 35, 55);
            g.FillRectangle(Brushes.Red, 5, 12, 35, 32);

            g.FillRectangle(Brushes.LightBlue, 12, 7, 21, 12);
        }

        private void pictureBoxBreak_Click_1(object sender, EventArgs e)
        {

        }
    }
}
