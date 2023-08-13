using System;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Pine : AObject2D
    {
        MyTriangle[] branches;
        MyRectangle stem;

        // TODO: доделать нормально
        public Point Start
        {
            get
            {
                for (int i = 0; i < branches.Length; i++)
                {
                    branches[i].Start = new Point(start.X, start.Y + i * branches[i].Height);
                    //branches[i].End = new Point(End.X, Start.Y + temp * (i + 1));
                }
                stem.Start = new Point(2 * (Math.Abs(Start.X - End.X) / 5), (Math.Abs(End.Y - Start.Y) / (branches.Length + 1)) * branches.Length);
                return start;
            }
            set
            {
                //int temp = Math.Abs(End.Y - Start.Y) / (branches.Length + 1);

                
                //stem.End = new Point(3 * (Math.Abs(Start.X - End.X) / 5), End.Y);
            }
        }
        public Point End
        {
            get => new Point(stem.End.Y, branches[0].End.X);
            set
            {
                //int temp = Math.Abs(End.Y - Start.Y) / (branches.Length + 1);

                for (int i = 0; i < branches.Length; i++)
                {
                    //branches[i].Start = new Point(Start.X, Start.Y + temp * i);
                    branches[i].End = new Point(value.X, value.Y + (i + 1) * branches[i].Height);
                }
                //stem.Start = new Point(2 * (Math.Abs(Start.X - End.X) / 5), temp * branches.Length);

                //доделать
                stem.End = new Point(3 * (Math.Abs(Start.X - End.X) / 5), End.Y);
            }
        }

        public int Width => Math.Abs(Start.X - End.X);
        public int Height => Math.Abs(Start.Y - End.Y);

        public Color OuterColor { set { foreach (MyTriangle branch in branches) branch.OuterColor = value; stem.OuterColor = value; } }
        public Color InnerColor { set { foreach (MyTriangle branch in branches) branch.InnerColor = value; stem.InnerColor = value; } }

        public Pine()
        {
            branches = new MyTriangle[3];
            for (int i = 0; i < branches.Length; i++)
            {
                branches[i] = new MyTriangle();
            }
            stem = new MyRectangle();
        }

        public Pine(Point point1, Point point2, int branchCount)
        {
            branches = new MyTriangle[branchCount];
            int temp = Math.Abs(End.Y - Start.Y) / (branches.Length + 1);
            for (int i = 0; i < branches.Length; i++)
            {
                branches[i] = new MyTriangle();
                branches[i].Start = new Point(Start.X, Start.Y + temp * i);
                branches[i].End = new Point(End.X, Start.Y + temp * (i + 1));
                branches[i].InnerColor = Color.DarkGreen;
            }
            stem = new MyRectangle(
                new Point(2 * (Math.Abs(Start.X - End.X) / 5), temp * branches.Length),
                new Point(3 * (Math.Abs(Start.X - End.X) / 5), End.Y)
                );
            stem.InnerColor = Color.Brown;
        }

        public override void FillSolid(Graphics graphics)
        {
            //Point p1 = Start;
            //Point p2 = End;
            //Relocate(ref p1, ref p2);
            //Start = p1;
            //End = p2;

            //int temp = Math.Abs(End.Y - Start.Y) / (branches.Length + 1);
            //for (int i = 0; i < branches.Length; i++)
            //{
            //    branches[i].Start = new Point(Start.X, Start.Y + temp * i);
            //    branches[i].End = new Point(End.X, Start.Y + temp * (i + 1));
            //    branches[i].FillSolid(graphics);
            //}
            //stem = new MyRectangle(
            //    new Point(Start.X + 2 * (Math.Abs(Start.X - End.X) / 5), Start.Y + temp * branches.Length),
            //    new Point(Start.X + 3 * (Math.Abs(Start.X - End.X) / 5), End.Y)
            //    );
            //stem.FillSolid(graphics);
            for (int i = 0; i < branches.Length; i++)
            {
                branches[i].FillSolid(graphics);
            }            
            stem.FillSolid(graphics);
        }

        public override AObject2D Clone()
        {
            return new Pine(Start, End, branches.Length);
        }
    }
}
