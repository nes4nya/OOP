using System;
using System.Drawing;
using System.Runtime.Serialization;

namespace OOP

{
    [DataContract]
    public class Polygon : Figures
    {
        [DataMember]
        private Brush brush { get; set; }

        public Polygon(float PenWidth, Color PenColor, Color FillColor) : base(PenWidth, PenColor)
        {
            brush = new SolidBrush(FillColor);
        }

        public override void Drawing(Graphics graphics)
        {
            Penn();
            graphics.FillPolygon(brush, points);
            graphics.DrawPolygon(pen, points);
        }
    }
}
