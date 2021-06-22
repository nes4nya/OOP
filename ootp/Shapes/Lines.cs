using System.Runtime.Serialization;
using System.Drawing;

namespace OOP

{
    [DataContract]
    public class Lines : Figures

    {
        public Lines(float PenWidth, Color PenColor) : base(PenWidth, PenColor) { }

        public override void Drawing(Graphics graphics)
        {
            Penn();
            graphics.DrawLines(pen, points);
        }
    }
}
