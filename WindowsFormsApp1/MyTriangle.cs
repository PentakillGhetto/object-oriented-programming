using System;
using System.Drawing;

namespace WindowsFormsApp1
{
    class MyTriangle : AObject2D
    {
        public Point[] Points { get; set; }

        public MyTriangle() : base()
        {
            Points = new Point[3];
        }

        public MyTriangle(Point point1, Point point2) : base(point1, point2)
        {
            Points = new Point[3];
            Points[0] = new Point(point1.X, point2.Y);
            Points[1] = new Point(point1.X + Math.Abs(point2.X - point1.X) / 2, point1.Y);
            Points[2] = point2;
        }

        public override void FillSolid(Graphics graphics)
        {
            // TODO: перенести это в свойства
            Points[0] = new Point(Start.X, End.Y);
            Points[1] = new Point(Start.X + Math.Abs(End.X - Start.X) / 2, Start.Y);
            Points[2] = End;
            graphics.FillPolygon(new SolidBrush(InnerColor), Points);
        }

        public override AObject2D Clone()
        {
            return (AObject2D)MemberwiseClone();
        }
    }
}
