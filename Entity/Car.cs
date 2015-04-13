using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Entity
{
    public class Car
    {
        public int speed;

        public void carRight(Graphics g)
        {
            g.Clear(Color.Gray);
            Pen p = new Pen(Color.Maroon, 3);
            Pen q = new Pen(Color.Maroon, 2);
            Pen r = new Pen(Color.Red, 2);
            Pen a = new Pen(Color.LightYellow, 2);
            /*g.FillRectangle(Brushes.Blue, 10, 12, 70, 30);
            //g.DrawRectangle(p, 10, 12, 70, 30);
            g.DrawRectangle(p, 25, 18, 40, 20);
            g.FillRectangle(Brushes.Yellow, 85, 15, 20, 27);
            //g.DrawRectangle(p, 85, 15, 20, 27);
            g.DrawLine(p, 80, 32, 85, 32);
            g.DrawLine(p, 80, 36, 85, 36);
            g.FillEllipse(Brushes.Black, 14, 42, 14, 14);
            //g.DrawEllipse(p, 14, 42, 14, 14);
            g.FillEllipse(Brushes.Black, 86, 42, 14, 14);
            //g.DrawEllipse(p, 86, 42, 14, 14);*/
            g.DrawLine(p, 25, 10, 100, 10);
            g.DrawLine(p, 12, 30, 25, 10);
            g.DrawLine(p, 12, 30, 2, 30);
            g.DrawLine(p, 2, 45, 2, 30);
            g.DrawLine(p, 115, 30, 100, 10);
            g.DrawLine(p, 115, 30, 138, 30);
            g.DrawLine(p, 138, 45, 138, 30);
            Point[] p1 = { new Point(139, 30), new Point(141, 32), new Point(139, 35) };
            g.DrawCurve(a, p1);

            g.DrawLine(p, 2, 45, 25, 45);
            g.DrawRectangle(q, 27, 15, 36, 13);
            g.FillRectangle(Brushes.LightGray, 27, 15, 36, 13);
            g.DrawRectangle(q, 66, 15, 36, 13);
            g.FillRectangle(Brushes.LightGray, 66, 15, 36, 13);
            g.DrawLine(q, 12, 30, 115, 30);
            //g.DrawEllipse(p, 23, 35, 20, 20);
            g.FillEllipse(Brushes.Black, 23, 35, 20, 20);
            g.DrawLine(p, 42, 45, 90, 45);
            //g.DrawEllipse(p, 88, 35, 20, 20);
            g.FillEllipse(Brushes.Black, 88, 35, 20, 20);
            g.DrawLine(p, 138, 45, 107, 45);
            g.DrawLine(p, 2, 30, 2, 25);
            g.DrawLine(r, 2, 25, 2, 22);


        }
        public void carLeft(Graphics g)
        {
            g.Clear(Color.Gray);
            Pen p = new Pen(Color.Maroon, 3);
            Pen q = new Pen(Color.Maroon, 2);
            Pen r = new Pen(Color.Red, 2);
            Pen a = new Pen(Color.LightYellow, 2);
            /*g.FillRectangle(Brushes.Blue, 35, 12, 70, 30);
            //g.DrawRectangle(p, 35, 12, 70, 30);
            g.DrawRectangle(p, 50, 18, 40, 20);
            g.FillRectangle(Brushes.Yellow, 10, 15, 20, 27);
            g.DrawRectangle(p, 10, 15, 20, 27);
            g.DrawLine(p, 35, 32, 30, 32);
            g.DrawLine(p, 35, 36, 30, 36);
            //g.DrawEllipse(p, 14, 42, 14, 14);
            //g.DrawEllipse(p, 86, 42, 14, 14);
            g.FillEllipse(Brushes.Black, 14, 42, 14, 14);
            g.FillEllipse(Brushes.Black, 86, 42, 14, 14);*/
            g.DrawLine(p, 2, 30, 2, 45);
            g.DrawLine(p, 2, 30, 22, 30);
            g.DrawLine(p, 37, 10, 22, 30);
            g.DrawLine(p, 37, 10, 112, 10);
            g.DrawLine(p, 125, 30, 112, 10);
            g.DrawLine(p, 125, 30, 138, 30);
            g.DrawLine(p, 138, 45, 138, 30);
            g.DrawLine(p, 138, 45, 112, 45);
            g.DrawLine(p, 95, 45, 47, 45);
            g.DrawLine(p, 2, 45, 30, 45);
            g.DrawRectangle(q, 38, 15, 36, 13);
            g.FillRectangle(Brushes.LightGray, 38, 15, 36, 13);
            g.DrawRectangle(q, 75, 15, 36, 13);
            g.FillRectangle(Brushes.LightGray, 75, 15, 36, 13);
            g.DrawLine(q, 12, 30, 138, 30);
            //g.DrawEllipse(p, 28, 35, 20, 20);
            //g.DrawEllipse(p, 93, 35, 20, 20);
            g.FillEllipse(Brushes.Black, 28, 35, 20, 20);
            g.FillEllipse(Brushes.Black, 93, 35, 20, 20);
            g.DrawLine(p, 138, 30, 138, 25);
            g.DrawLine(r, 138, 25, 138, 22);
            Point[] p1 = { new Point(3, 30), new Point(0, 32), new Point(3, 35) };
            g.DrawCurve(a, p1);
        }
        public void carUp(Graphics g)
        {
            g.Clear(Color.Gray);
            Pen p = new Pen(Color.Maroon, 3);
            Pen q = new Pen(Color.Maroon, 2);
            Pen r = new Pen(Color.Red, 1);
            Pen a = new Pen(Color.LightYellow, 3);
            /*//g.DrawRectangle(p, 40, 40, 30, 70);
            //g.DrawRectangle(p, 43, 15, 24, 20);
            g.FillRectangle(Brushes.Blue, 40, 40, 30, 70);
            g.FillRectangle(Brushes.Yellow, 43, 15, 24, 20);
            g.DrawLine(p, 53, 40, 53, 35);
            g.DrawLine(p, 57, 40, 57, 36);*/

            g.DrawLine(p, 20, 20, 20, 80);
            g.DrawLine(p, 60, 80, 20, 80);
            g.DrawLine(p, 60, 80, 60, 20);
            g.DrawLine(p, 15, 20, 65, 20);
            g.DrawLine(p, 25, 10, 20, 20);
            g.DrawLine(p, 55, 10, 60, 20);
            g.DrawLine(p, 25, 10, 55, 10);
            Point[] p1 = { new Point(27, 9), new Point(30, 8), new Point(33, 9) };
            Point[] p2 = { new Point(47, 9), new Point(50, 8), new Point(53, 9) };
            g.DrawCurve(a, p1);
            g.DrawCurve(a, p2);
            g.DrawLine(p, 25, 90, 20, 80);
            g.DrawLine(p, 55, 90, 60, 80);
            g.DrawLine(p, 25, 90, 55, 90);
            g.DrawLine(r, 20, 89, 60, 89);
            g.FillRectangle(Brushes.Maroon, 25, 25, 30, 50);
            
        }

        public void carDown(Graphics g)
        {
            g.Clear(Color.Gray);
            Pen p = new Pen(Color.Maroon, 3);
            Pen q = new Pen(Color.Maroon, 2);
            Pen r = new Pen(Color.Red, 1);
            Pen a = new Pen(Color.LightYellow, 2);
            /*//g.DrawRectangle(p, 40, 15, 30, 70);
            //g.DrawRectangle(p, 43, 90, 24, 20);
            g.FillRectangle(Brushes.Blue, 40, 15, 30, 70);
            g.FillRectangle(Brushes.Yellow, 43, 90, 24, 20);
            g.DrawLine(p, 53, 85, 53, 90);
            g.DrawLine(p, 57, 85, 57, 90);*/

            g.DrawLine(p, 20, 20, 20, 80);
            g.DrawLine(p, 65, 80, 15, 80);
            g.DrawLine(p, 60, 80, 60, 20);
            g.DrawLine(p, 20, 20, 60, 20);
            g.DrawLine(p, 25, 10, 20, 20);
            g.DrawLine(p, 55, 10, 60, 20);
            g.DrawLine(p, 25, 10, 55, 10);
            g.DrawLine(r, 20,11, 60,11);
            g.DrawLine(p, 25, 90, 20, 80);
            g.DrawLine(p, 55, 90, 60, 80);
            g.DrawLine(p, 25, 90, 55, 90);
            Point[] p1 = { new Point(27, 91), new Point(30, 92), new Point(33, 91) };
            Point[] p2 = { new Point(47, 91), new Point(50, 92), new Point(53, 91) };
            g.DrawCurve(a, p1);
            g.DrawCurve(a, p2);
            g.FillRectangle(Brushes.Maroon, 25, 25, 30, 50);
        }
    }
   
}
