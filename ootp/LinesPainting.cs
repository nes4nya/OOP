using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;


namespace OOP

{
    public class LinesPainting : Painting
    {
        public Figures GetFigure(float PenWidth, Color PenColor, Color FillColor)
        {
            return new Lines(PenWidth, PenColor);
        }
        public bool angles { get { return false; } }
        public bool Click { get { return true; } }
        public string name { get { return "Lines"; } }
    }
}