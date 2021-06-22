using System;
using System.Drawing;
using System.Runtime.Serialization;
using OOP;

namespace Trapez
{
    [DataContract]
    public class Trapezz : Figures
    {
        [DataMember]
        private Brush brush { get; set; }

        [DataMember]
        private Point[] pointt; 

        public Trapezz(float PenWidth, Color PenColor, Color FillColor) : base(PenWidth, PenColor)
        {
            brush = new SolidBrush(FillColor);
        }

        public override void Drawing(Graphics graphics)
        {
            Penn();
            int width = Math.Abs(points[1].X - points[0].X) / 3;
            pointt = new Point[4] { new Point(points[0].X + width, points[0].Y), new Point(points[1].X - width, points[0].Y), points[1], new Point(points[0].X, points[1].Y) };

            graphics.FillPolygon(brush, pointt);
            graphics.DrawPolygon(pen, pointt);
        }
    }
}
