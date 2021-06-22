using System;
using System.Drawing;
using OOP;

namespace Trapez
{
    public class TrapezPainting : Painting
    {
        public Figures GetFigure(float PenWidth, Color PenColor, Color FillColor)
        {
          return new Trapezz(PenWidth, PenColor, FillColor);
        }
        public bool angles { get { return false; } }
        public bool Click { get { return false; } }
        public string name { get { return "Trapezz"; } }

    }
}
