using System;
using System.Drawing;
using System.Windows.Forms;

namespace Avaruus
{
    public partial class Form1 : Form
    {
        private PictureBox pictureBox1;
        private Simulation sim;
        private bool uiVisible = false;

        public Form1()
        {
            InitializeComponent();
            // Luodaan tausta
            pictureBox1 = new PictureBox();
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Size = new Size(20000, 20000);
            pictureBox1.Paint += new PaintEventHandler(this.pictureBox1_Paint);
            pictureBox1.Click += new EventHandler(this.pictureBox1_Click);
            panel1.Controls.Add(pictureBox1);

            // Asetetaan timerCorrection huomioimaan simulaation päivitysnopeus
            Modifiers.timerCorrection = 1000 / timer2.Interval;
            sim = new Simulation();

            Timer timerScroll = new Timer();
            timerScroll.Enabled = true;
            timerScroll.Tick += new EventHandler(this.timerScroll_Tick);            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Tyhjentää pictureboxin ja kutsuu paint-tapahtumaa
            pictureBox1.Invalidate();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // Tehdään painovoimasimulaatiot
            sim.Gravity();
        }

        private void timerScroll_Tick(object sender, EventArgs e)
        {
            Control c = new Control();
            c.Parent = panel1;
            c.Location = new Point(9200 + this.Width / 2, 9500 + this.Height / 2);
            panel1.ScrollControlIntoView(c);
            Timer thisTimer = (Timer)sender;
            thisTimer.Dispose();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Piirtää kaikki taivaankappaleet elliptiseen muotoon
            foreach (CelBody body in sim.Bodies)
            { 
                if (!body.Exists)
                {
                    continue;
                }

                if (body is BlackHole)
                {
                    BlackHole bh = (BlackHole)body;
                    Pen pen = new Pen(bh.Color);
                    e.Graphics.DrawEllipse(pen, (int)bh.XPos - (int)bh.SchwarzschildR, (int)bh.YPos - (int)bh.SchwarzschildR, (int)bh.SchwarzschildR * 2, (int)bh.SchwarzschildR * 2);
                    pen.Dispose();
                    continue;
                }

                Brush brush = new SolidBrush(body.Color);
                e.Graphics.FillEllipse(brush, (int)body.XPos - body.D / 2, (int)body.YPos - body.D / 2, body.D, body.D);
                brush.Dispose();
            }            
        }

        private void buttonUI_Click(object sender, EventArgs e)
        {
            if (!uiVisible)
            {
                groupBox1.Visible = true;
                uiVisible = true;
            }
            else
            {
                groupBox1.Visible = false;
                uiVisible = false;
                labelError.Text = "";
            }

            groupBox2.Visible = false;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible == true)
            {
                MouseEventArgs me = (MouseEventArgs)e;
                Point coordinates = me.Location;

                textBoxXPos.Text = coordinates.X.ToString();
                textBoxYPos.Text = coordinates.Y.ToString();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {


                string name = textBoxName.Text;
                double mass = double.Parse(textBoxMass.Text);
                int d = int.Parse(textBoxD.Text);
                int xPos = int.Parse(textBoxXPos.Text);
                int yPos = int.Parse(textBoxYPos.Text); ;
                double xVel = double.Parse(textBoxXVel.Text);
                double yVel = double.Parse(textBoxYVel.Text);
                Color c = colorDialog1.Color;

                if (comboBox1.SelectedIndex == 8)
                {
                    sim.CreateSolarSystem(xPos, yPos, xVel, yVel);
                    return;
                }

                if (!checkBoxBH.Checked)
                {
                    sim.CreateNewBody(name, mass, d, xPos, yPos, xVel, yVel, c);
                }
                else
                {
                    sim.CreateNewBH(name, mass, xPos, yPos, xVel, yVel);
                }

                labelError.Text = "";
            }
            catch (Exception ex)
            {
                labelError.Text = "Virhe: " + ex.Message;
            }            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = "";
            double mass = 0;
            int d = 0;

            textBoxName.Enabled = true;
            textBoxMass.Enabled = true;
            textBoxD.Enabled = true;
            buttonColor.Enabled = true;
            checkBoxBH.Checked = false;
            checkBoxBH.Enabled = true;

            if (comboBox1.SelectedIndex == 0)
            {
                name = "Asteroidi";
                mass = 2.59076 * Math.Pow(10, 20);
                d = 3;
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                name = "Kuu";
                mass = 7.342 * Math.Pow(10, 22);
                d = 4;
            }

            else if (comboBox1.SelectedIndex == 2)
            {
                name = "Planeetta";
                mass = 5.9737 * Math.Pow(10, 24) * 2.25;
                d = 10;
            }

            else if (comboBox1.SelectedIndex == 3)
            {
                name = "Kaasuplaneetta";
                mass = 2.3154 * Math.Pow(10, 27);
                d = 16;
            }

            else if (comboBox1.SelectedIndex == 4)
            {
                name = "Alfa Kentauri A";
                mass = 1.9891 * Math.Pow(10, 30) * 1.1;
                d = 26;
            }

            else if (comboBox1.SelectedIndex == 5)
            {
                name = "R136c";
                mass = 1.9891 * Math.Pow(10, 30) * 230;
                d = 30;
            }

            else if (comboBox1.SelectedIndex == 6)
            {
                name = "Musta aukko";
                mass = 1.9891 * Math.Pow(10, 30) * Math.Pow(10, 4);
                d = 0;
                checkBoxBH.Checked = true;
            }

            else if (comboBox1.SelectedIndex == 7)
            {
                name = " M87*";
                mass = (1.9891 * Math.Pow(10, 30)) * (6.5 * Math.Pow(10, 9));
                d = 0;
                checkBoxBH.Checked = true;
            }
            else if (comboBox1.SelectedIndex == 8)
            {
                textBoxName.Enabled = false;
                textBoxMass.Enabled = false;
                textBoxD.Enabled = false;
                buttonColor.Enabled = false;
                checkBoxBH.Enabled = false;
            }

            textBoxName.Text = name;
            textBoxMass.Text = mass.ToString(); ;
            textBoxD.Text = d.ToString();
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            sim.Remove();
        }

        private void checkBoxBH_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBH.Checked)
            {
                textBoxD.Text = "0";
                textBoxD.Enabled = false;
                buttonColor.Enabled = false;
            }
            else
            {
                textBoxD.Enabled = true;
                buttonColor.Enabled = true;
            }
        }

        private void trackBarSpeed_Scroll(object sender, EventArgs e)
        {
            switch (trackBarSpeed.Value)
            {
                case 0:
                    Modifiers.timeMultiplier = 1;
                    labelSpeed.Text = "* 1";
                    break;
                case 1:
                    Modifiers.timeMultiplier = 1000;
                    labelSpeed.Text = "* 1000";
                    break;
                case 2:
                    Modifiers.timeMultiplier = 10000;
                    labelSpeed.Text = "* 10k";
                    break;
                case 3:
                    Modifiers.timeMultiplier = 100000;
                    labelSpeed.Text = "* 100k";
                    break;
                case 4:
                    Modifiers.timeMultiplier = 1000000;
                    labelSpeed.Text = "* 1 milj";
                    break;
                case 5:
                    Modifiers.timeMultiplier = 10000000;
                    labelSpeed.Text = "* 10 milj";
                    break;
                case 6:
                    Modifiers.timeMultiplier = 30000000;
                    labelSpeed.Text = "* 30 milj";
                    break;
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            if (groupBox2.Visible == false)
            {
                groupBox2.Visible = true;
            }
            else
            {
                groupBox2.Visible = false;
            }
        }

        private void trackBarAccyracy_Scroll(object sender, EventArgs e)
        {
            switch (trackBarAccuracy.Value)
            {
                case 0:
                    timer2.Interval = 50;
                    break;
                case 1:
                    timer2.Interval = 20;
                    break;
                case 2:
                    timer2.Interval = 10;
                    break;
                case 3:
                    timer2.Interval = 5;
                    break;
                case 4:
                    timer2.Interval = 1;                    
                    break;
            }

            Modifiers.timerCorrection = 1000 / timer2.Interval;
            labelAccuracy.Text = timer2.Interval.ToString() + " ms";
        }
    }
}
 