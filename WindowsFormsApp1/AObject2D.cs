using System;
using System.Drawing;

namespace WindowsFormsApp1
{
    public abstract class AObject2D
    {
        protected Point start;
        protected Point end;
        public virtual Point Start { get { Relocate(ref start, ref end); return start; } set { start = value; } }
        public virtual Point End { get { Relocate(ref start, ref end); return end; } set { end = value; } }
        public int Width => Math.Abs(Start.X - End.X); 
        public int Height => Math.Abs(Start.Y - End.Y); 
        public Color OuterColor { get; set; }
        public Color InnerColor { get; set; }

        public AObject2D()
        {
            OuterColor = Color.Black;
            InnerColor = Color.Black;
        }

        public AObject2D(Point point1, Point point2)
        {
            Start = point1;
            End = point2;
            OuterColor = Color.Black;
            InnerColor = Color.Black;
        }

        public static void Relocate(ref Point point1, ref Point point2)
        {
            if (point1.X < point2.X & point1.Y > point2.Y)
            {
                int height = point1.Y - point2.Y;
                point1 = new Point(point1.X, point2.Y);
                point2 = new Point(point2.X, point2.Y + height);
                return;
            }
            if (point1.X > point2.X & point1.Y < point2.Y)
            {
                int width = point1.X - point2.X;
                point1 = new Point(point1.X - width, point1.Y);
                point2 = new Point(point2.X + width, point2.Y);
                return;
            }
            if (point1.X > point2.X & point1.Y > point2.Y)
            {
                int height = point1.Y - point2.Y;
                int width = point1.X - point2.X;
                point1 = new Point(point1.X - width, point2.Y);
                point2 = new Point(point2.X + width, point2.Y + height);
                return;
            }
        }

        public bool ContainsPoint(Point p)
        {
            return ContainsPoint(p.X, p.Y);
        }

        public bool ContainsPoint(int x, int y)
        {
            return (new Rectangle(Start.X, Start.Y, Width, Height).Contains(x, y));
        }

        public abstract void FillSolid(Graphics graphics);

        public virtual void FillLinear(Graphics graphics)
        {
            FillSolid(graphics);
        }

        public virtual void FillRandom(Graphics graphics)
        {
            FillSolid(graphics);
        }

        public abstract AObject2D Clone();
    }
}
