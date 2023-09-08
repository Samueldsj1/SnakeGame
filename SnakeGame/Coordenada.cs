using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Coordenada
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordenada(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
