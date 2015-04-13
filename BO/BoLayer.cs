using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Entity;

namespace BO
{
    public class BoLayer
    {
        DalLayer dl = new DalLayer();
        Car cd = new Car();
        public int x = 12;
        public int y = 126;
        public char key = 'o';
        public void set(Graphics g)
        {
            x = 12;
            y = 126;
            cd.carRight(g);
        }

        
        public bool saveSpeed(Car c)
        {
            return dl.save(Convert.ToString(c.speed));
        }
        public int speedCalculation()
        {
            Car c = dl.getData();
            if (c.speed == 10)
                return 1000;
            else if (c.speed == 20)
                return 650;
            else if (c.speed == 30)
                return 350;
            else if (c.speed == 40)
                return 250;
            else if (c.speed == 50)
                return 180;
            else if (c.speed == 60)
                return 100;
            else if (c.speed == 70)
                return 65;
            else if (c.speed == 80)
                return 40;
            else if (c.speed == 90)
                return 20;
            else if (c.speed == 100)
                return 1;
            else
                return 0;
        }

        public int getData()
        {
            Car c = dl.getData();
            int speed = c.speed;
            return speed;
        }
        public void changeAxes(char key)
        {
            
             if (key == 'u')
            {
               if(y>=125 || x>269 && x<350)
               {
                   if(y>=25)
                       y = y - 3;
               }
                
            }
            else if (key == 'd')
            {
                if (y <= 170 || x > 269 && x < 350)
                {
                    if(y<=300)
                        y = y + 3;
                }
                
            }
            else if (key == 'l')
            {
                if (x >= 10)
                x = x - 3;
            }
            else if (key == 'r')
            {
                if (x <= 550) 
                x = x + 3;
            }
            
        }
        
        public void setKey(char c)
        {
            key = 'c';
        }
        public char getKey()
        {
            return key;
        }
        int flag = 3;
        public char calc(Graphics g, char keyPress, int x, int y)
        {
            if (keyPress == 'u')
            {
                flag = 2;
                cd.carUp(g);
                return 'u';
            }
            else if (keyPress == 'd')
            {
                flag = 4;
                cd.carDown(g);
                return 'd';
            }
            else if (keyPress == 'l')
            {
                flag = 1;
                cd.carLeft(g);
                return 'l';
            }
            else if (keyPress == 'r')
            {
                flag = 3;
                cd.carRight(g);
                return 'r';
            }
            return 'o';
        }
    }
}
