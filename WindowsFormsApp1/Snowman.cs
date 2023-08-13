using System.Drawing;

namespace WindowsFormsApp1
{
    class Snowman : AObject2D
    {
        MyEllipse head, body, legs;


        public override Point Start
        {
            get
            {
                Relocate(ref start, ref end);
                head.Start = start;
                body.Start = new Point(start.X, start.Y + head.Height);
                legs.Start = new Point(start.X, start.Y + head.Height * 2);
                return start;
            }

            set
            {
                start = value;
            }
        }
        public override Point End
        {
            get
            {
                Relocate(ref start, ref end);
                head.End = new Point(end.X, end.Y - legs.Height * 2);
                body.End = new Point(end.X, end.Y - legs.Height);
                legs.End = end;
                return end;
            }

            set
            {
                end = value;   
            }
        }

        public Snowman()
        {
            head = new MyEllipse();
            body = new MyEllipse();
            legs = new MyEllipse();
        }
        public Snowman(Point point1, Point point2)
        {
            head = new MyEllipse(point1, new Point(point2.X, point1.Y + System.Math.Abs(point2.Y - point1.Y) / 3));
            body = new MyEllipse(new Point(point1.X, point1.Y + head.Height), new Point(point2.X, point1.Y + head.Height * 2));
            legs = new MyEllipse(new Point(point1.X, point1.Y + head.Height * 2), point2);
        }

        public override void FillSolid(Graphics graphics)
        {
            head.FillSolid(graphics);
            body.FillSolid(graphics);
            legs.FillSolid(graphics);
        }

        public override void FillLinear(Graphics graphics)
        {
            head.FillLinear(graphics);
            body.FillLinear(graphics);
            legs.FillLinear(graphics);
        }

        public override void FillRandom(Graphics graphics)
        {
            head.FillRandom(graphics);
            body.FillRandom(graphics);
            legs.FillRandom(graphics);
        }

        public override AObject2D Clone()
        {
            return new Snowman(Start, End);
        }
    }
}
