using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;


namespace OOP

{
    public class LinePainting : Painting
    {
        public Figures GetFigure(float PenWidth, Color PenColor, Color FillColor)
        {
            return new Line(PenWidth, PenColor);
        }
        public bool angles { get { return false; } }
        public bool Click { get { return false; } }
        public string name { get { return "Line"; } }
    }
}
