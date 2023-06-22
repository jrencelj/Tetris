using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Tocka
    {
        private int x;
        private int y;
        public Tocka(int x, int y )
        {
            X = x;
            Y = y;
        }
        public int X { 
            get { return x; } 
            set { x = value; } 
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public void premakniY(int n)
        {
            Y += n;
        }

        public void premakniX(int n)
        {
            X += n;
        }
    }
}
