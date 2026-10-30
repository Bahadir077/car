
namespace car
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelRoad;

        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.PictureBox pictureBoxStart;
        private System.Windows.Forms.PictureBox pictureBoxBreak;
        private System.Windows.Forms.PictureBox pictureBoxUp;
        private System.Windows.Forms.PictureBox pictureBoxDown;
        private System.Windows.Forms.PictureBox pictureBoxLeft;
        private System.Windows.Forms.PictureBox pictureBoxRight;

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cmbTime;

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelRoad = new Panel();
            pictureBoxCar = new PictureBox();
            pictureBoxStart = new PictureBox();
            pictureBoxBreak = new PictureBox();
            pictureBoxUp = new PictureBox();
            pictureBoxDown = new PictureBox();
            pictureBoxLeft = new PictureBox();
            pictureBoxRight = new PictureBox();
            lblTime = new Label();
            cmbTime = new ComboBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            panelRoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBreak).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRight).BeginInit();
            SuspendLayout();
            
            panelRoad.BackColor = Color.Gray;
            panelRoad.Controls.Add(pictureBoxCar);
            panelRoad.Location = new Point(5, 5);
            panelRoad.Name = "panelRoad";
            panelRoad.Size = new Size(290, 455);
            panelRoad.TabIndex = 0;
         
            pictureBoxCar.Image = Properties.Resources.car;
            pictureBoxCar.Location = new Point(142, 318);
            pictureBoxCar.Name = "pictureBoxCar";
            pictureBoxCar.Size = new Size(100, 118);
            pictureBoxCar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCar.TabIndex = 0;
            pictureBoxCar.TabStop = false;
           
            pictureBoxStart.AccessibleName = "";
            pictureBoxStart.BackColor = Color.LightGreen;
            pictureBoxStart.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxStart.Cursor = Cursors.Hand;
            pictureBoxStart.Location = new Point(380, 59);
            pictureBoxStart.Name = "pictureBoxStart";
            pictureBoxStart.Size = new Size(85, 35);
            pictureBoxStart.TabIndex = 1;
            pictureBoxStart.TabStop = false;
            pictureBoxStart.Tag = "";
           
            pictureBoxBreak.BackColor = Color.LightCoral;
            pictureBoxBreak.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxBreak.Location = new Point(380, 109);
            pictureBoxBreak.Name = "pictureBoxBreak";
            pictureBoxBreak.Size = new Size(85, 35);
            pictureBoxBreak.TabIndex = 2;
            pictureBoxBreak.TabStop = false;
            pictureBoxBreak.Click += pictureBoxBreak_Click_1;
            
            pictureBoxUp.BackColor = Color.LightBlue;
            pictureBoxUp.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxUp.Image = Properties.Resources.top;
            pictureBoxUp.Location = new Point(400, 173);
            pictureBoxUp.Name = "pictureBoxUp";
            pictureBoxUp.Size = new Size(80, 70);
            pictureBoxUp.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxUp.TabIndex = 3;
            pictureBoxUp.TabStop = false;
           
            pictureBoxDown.BackColor = Color.LightBlue;
            pictureBoxDown.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxDown.Image = Properties.Resources.bottom;
            pictureBoxDown.Location = new Point(400, 353);
            pictureBoxDown.Name = "pictureBoxDown";
            pictureBoxDown.Size = new Size(80, 70);
            pictureBoxDown.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxDown.TabIndex = 4;
            pictureBoxDown.TabStop = false;
            
            pictureBoxLeft.BackColor = Color.LightBlue;
            pictureBoxLeft.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxLeft.Image = Properties.Resources.left;
            pictureBoxLeft.Location = new Point(320, 260);
            pictureBoxLeft.Name = "pictureBoxLeft";
            pictureBoxLeft.Size = new Size(80, 70);
            pictureBoxLeft.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLeft.TabIndex = 5;
            pictureBoxLeft.TabStop = false;
            
            pictureBoxRight.BackColor = Color.LightBlue;
            pictureBoxRight.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxRight.Image = Properties.Resources.right;
            pictureBoxRight.Location = new Point(485, 260);
            pictureBoxRight.Name = "pictureBoxRight";
            pictureBoxRight.Size = new Size(80, 70);
            pictureBoxRight.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxRight.TabIndex = 6;
            pictureBoxRight.TabStop = false;
            
            lblTime.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblTime.Location = new Point(488, 59);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(100, 25);
            lblTime.TabIndex = 7;
            lblTime.Text = "Time: 0";
           
            cmbTime.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTime.Location = new Point(380, 12);
            cmbTime.Name = "cmbTime";
            cmbTime.Size = new Size(100, 23);
            cmbTime.TabIndex = 8;
            
            timer2.Interval = 1000;
            
            BackColor = Color.White;
            ClientSize = new Size(600, 480);
            Controls.Add(panelRoad);
            Controls.Add(pictureBoxStart);
            Controls.Add(pictureBoxBreak);
            Controls.Add(pictureBoxUp);
            Controls.Add(pictureBoxDown);
            Controls.Add(pictureBoxLeft);
            Controls.Add(pictureBoxRight);
            Controls.Add(lblTime);
            Controls.Add(cmbTime);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Game";
            panelRoad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxCar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStart).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBreak).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUp).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRight).EndInit();
            ResumeLayout(false);
        }
    }
}
