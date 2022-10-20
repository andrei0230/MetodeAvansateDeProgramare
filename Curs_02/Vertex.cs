﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_02
{
    public class Vertex
    {
        public string Name;
        public PointF Location;
        public int Idx;
        public int color = 0;
        static int Size = 15;

        public Vertex(string name, PointF location)
        {
            Name = name;
            Location = location;
            Idx = -1;
        }

        public Vertex(string data)
        {
            string[] t = data.Split(' ');
            Name = t[0].Trim();
            Location = new PointF(float.Parse(t[1]), float.Parse(t[2]));
        }

        public void Draw(Graphics h)
        {
            h.FillEllipse(new SolidBrush(Engine.Pall[color]), Location.X - Size, Location.Y - Size, 2*Size+1, 2*Size+1);
            h.DrawEllipse(Pens.Black, Location.X - Size, Location.Y - Size, 2*Size+1, 2*Size+1);
            h.DrawString(Name, new Font("Arial", 12, FontStyle.Regular), new SolidBrush(Color.Blue), Location.X, Location.Y);
        }
    }
}
