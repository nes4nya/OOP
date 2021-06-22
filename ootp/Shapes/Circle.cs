using System;
using System.Drawing;
using System.Runtime.Serialization;

namespace OOP

{
    [DataContract]
    public class Circle : Figures
    {
        [DataMember]
        private Brush brush { get; set; }

        public Circle(float PenWidth, Color PenColor, Color FillColor) : base(PenWidth, PenColor)
        {
            brush = new SolidBrush(FillColor);
        }

        public override void Drawing(Graphics graphics)
        {
            Penn();
            int width = points[1].X - points[0].X;
            int height = points[1].Y - points[0].Y;

            graphics.FillEllipse(brush, points[0].X, points[0].Y, width, height);
            graphics.DrawEllipse(pen, points[0].X, points[0].Y, width, height);
        }
    }
}


