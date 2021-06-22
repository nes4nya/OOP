using System.Drawing;
using System.Runtime.Serialization;

namespace OOP
{
    [DataContract]
    public abstract class Figures
    {
        [DataMember]
        public Point[] points;
        [DataMember]
        public Color PenColor;
        [DataMember]
        public float PenWidth;

        protected Pen pen { get; set; }

        protected void Penn ()
        {
            pen = new Pen(PenColor, PenWidth);
        }

        public Figures(float penwidth, Color pencolor)
        {
            pen = new Pen(PenColor, PenWidth);
            this.PenColor = pencolor;
            this.PenWidth = penwidth;
        }

        public abstract void Drawing(Graphics graphics);
    }
}


