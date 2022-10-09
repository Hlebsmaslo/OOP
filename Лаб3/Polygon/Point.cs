using System;
using System.Collections.Generic;
using System.Text;

namespace Polygon
{
    internal class Point
    {
        private readonly int xx;
        private readonly int yy;
        private readonly string nam;
        public int X => xx;
        public int Y => yy;
        public string Name => nam;
        public Point(int x, int y, string name)
        {
            this.xx = x;
            this.yy = y;
            this.nam = name;
        }
    }
}
