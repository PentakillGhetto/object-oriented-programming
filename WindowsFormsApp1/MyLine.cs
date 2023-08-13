using System.Drawing;

namespace WindowsFormsApp1
{
    class MyLine : AObject2D
    {
        public override Point Start { get => start; set => start = value; }
        public override Point End { get => end; set => end = value; }

        public MyLine() : base()
        {
        }

        public MyLine(Point point1, Point point2) : base(point1, point2)
        {
        }

        public override void FillSolid(Graphics graphics)
        {
            graphics.DrawLine(new Pen(InnerColor), start, end);
        }

        public override AObject2D Clone()
        {
            return (AObject2D)MemberwiseClone();
        }
    }
}
