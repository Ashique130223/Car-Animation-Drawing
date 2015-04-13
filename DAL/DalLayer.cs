﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entity;

namespace DAL
{
    public class DalLayer
    {
        public bool save(String speed)
        {
            try
            {
                StreamWriter w = new StreamWriter(@"E:\Programing\C Sharp  ( C#)\Visual Studio 2013\Projects\Car Animation Drawing\Speed.txt");
                w.WriteLine(speed);
                w.Close();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public Car getData()
        {
            Car c = new Car();
            try
            {
                StreamReader read = new StreamReader(@"E:\Programing\C Sharp  ( C#)\Visual Studio 2013\Projects\Car Animation Drawing\Speed.txt");
                c.speed = Convert.ToInt32(read.ReadLine());
                read.Close();
                return c;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
