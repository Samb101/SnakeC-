﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Wall
    {
        internal int x { get; set; }
        internal int y { get; set; }

        public Wall(int x, int y)
        {
            this.x = x;
            this.y = y;

        }
    }
}