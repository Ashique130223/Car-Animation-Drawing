using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
//130223

namespace UI
{
    public partial class Form1 : Form
    {
        BoLayer bl = new BoLayer();
        Graphics g;
        Char keyPress;
        int x;
        int y;
        Car c = new Car();
        public Form1()
        {
            InitializeComponent();
            g = carPanel.CreateGraphics();
            int x = bl.x;
            int y = bl.y;
            keyPress = 'r';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentInfoLabel.Text = Convert.ToString(bl.getData());
        }

        #region Start Button
        private void startButton_Click(object sender, EventArgs e)
        {
            g.Clear(Color.Gray);
            info.Text = null;
            
            c.carRight(g);
            if (bl.speedCalculation() != 0 && !String.IsNullOrEmpty(currentInfoLabel.Text))
            {
                timer1.Interval = bl.speedCalculation();
                timer1.Start();
            }
        }
        #endregion

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        #region Set Speed
        private void speedButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(speedBox.Text))
                MessageBox.Show("Please, enter speed correctly.");
            else
            {
                Car c = new Car();
                c.speed = Convert.ToInt32(speedBox.Text);
                if (bl.saveSpeed(c))
                {
                    info.Text = "Now, Press 'Start'";
                    currentInfoLabel.Text = Convert.ToString(bl.getData());
                }
                else
                {
                    MessageBox.Show("error");
                    info.Text = null;
                }

            }
            
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            bl.changeAxes(keyPress);
           
            carPanel.Location = new Point(bl.x, bl.y);

            keyPress = bl.calc(g, keyPress, bl.x, bl.y);
        }

        #region Arrow Key Pressing 
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                keyPress = 'u';
               
            }
            else if (e.KeyCode == Keys.Down)
            {
                keyPress = 'd';
                
            }
            else if (e.KeyCode == Keys.Left)
            {
                keyPress = 'l';
                
            }
            else if (e.KeyCode == Keys.Right)
            {
                keyPress = 'r';
                
            }
        }
        #endregion

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.CadetBlue, 3);
            /*e.Graphics.DrawLine(p, 0, 122, 269, 122);
            e.Graphics.DrawLine(p, 0, 269, 269, 269);
            e.Graphics.DrawLine(p, 269, 269, 269, 400);
            e.Graphics.DrawLine(p, 269, 25, 269, 122);
            e.Graphics.DrawLine(p, 269, 25, 425, 25);
            e.Graphics.DrawLine(p, 425, 25, 425, 122);
            e.Graphics.DrawLine(p, 425, 269, 425, 400);
            e.Graphics.DrawLine(p, 425, 122, 700, 122);
            e.Graphics.DrawLine(p, 425, 269, 700, 269);*/
        }
    }
}
