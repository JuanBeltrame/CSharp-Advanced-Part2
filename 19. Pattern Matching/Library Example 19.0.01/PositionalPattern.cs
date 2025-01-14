using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Example_19._0._01
{
    // declares struct with a single variable named X
    public readonly struct Coordinates
    {
        public int X { get; }
        public int Y { get; }

        // Constructor para la estructura
        public Coordinates(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Método deconstrucción para asignar valores a variables separadas
        public void Deconstruct(out int x, out int y)
        {
            x = X;
            y = Y;
        }
    }
}
