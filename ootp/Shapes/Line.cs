using System.Drawing;
using System.Runtime.Serialization;

namespace OOP
{
    [DataContract]
    public class Line : Figures
    {

        public Line(float PenWidth, Color PenColor) : base(PenWidth, PenColor) { }

        public override void Drawing(Graphics graphics)
        {
            Penn();
            graphics.DrawLine(pen, points[0], points[1]);
        }
    }
}
