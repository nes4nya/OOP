using System;
using System.Drawing;

namespace OOP

{
    public class CirclePainting : Painting
    {
        public Figures GetFigure(float PenWidth, Color PenColor, Color FillColor)
        {
            return new Circle(PenWidth, PenColor, FillColor);
        }
        public bool angles { get { return false; } }
        public bool Click { get { return false; } }
        public string name { get { return "Ellipse"; } }
    }
}
