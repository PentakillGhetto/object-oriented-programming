using System.Drawing;

namespace WindowsFormsApp1
{
    public class Manipulator : AObject2D
    {
        public AObject2D Current { get; private set; }
        public bool IsAttached => Current != null;

        public void Attach(AObject2D object2D)
        {
            Current = object2D;
            Start = object2D.Start;
            End = object2D.End;
        }

        public void Detach()
        {
            Current = null;
            End = Start = Point.Empty;
        }

        public void Update()
        {
            Current.Start = Start;
            Current.End = End;
        }

        public void Touch(Point location)
        {
            this.Touch(Current, location);
        }

        public void Touch(AObject2D item, Point location)
        {
            if (new Rectangle(Start.X, Start.Y, Width / 15, Height / 15).Contains(location))
            {
                Start = new Point(location.X - 2, location.Y - 2);
                Update();
                return;
            }
            if (new Rectangle(Start.X + Width - Width / 15, Start.Y, Width / 15, Height / 15).Contains(location))
            {
                Start = new Point(Start.X, location.Y);
                End = new Point(location.X, End.Y);
                Update();
                return;
            }
            if (new Rectangle(Start.X, Start.Y + Height - Height / 15, Width / 15, Height / 15).Contains(location))
            {
                Start = new Point(location.X, Start.Y);
                End = new Point(End.X, location.Y);
                Update();
                return;
            }
            if (new Rectangle(Start.X + Width - Width / 15, Start.Y + Height - Height / 15, Width / 15, Height / 15).Contains(location))
            {
                End = new Point(location.X + 2, location.Y + 2);
                Update();
                return;
            }

            Drag(location);
            Update();
        }

        public void Drag(Point location)
        {
            int deltaX = Width;
            int deltaY = Height;
            Start = new Point(location.X, location.Y);
            End = new Point(Start.X + deltaX, Start.Y + deltaY);
        }

        public override AObject2D Clone()
        {
            return (AObject2D)MemberwiseClone();
        }

        public override void FillSolid(Graphics graphics)
        {
            Pen p = new Pen(Color.Red)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dash
            };
            graphics.DrawRectangle(p, Start.X, Start.Y, Width, Height);
            graphics.DrawRectangle(p, Start.X, Start.Y, Width / 15, Height / 15);
            graphics.DrawRectangle(p, Start.X + Width - Width / 15, Start.Y, Width / 15, Height / 15);
            graphics.DrawRectangle(p, Start.X, Start.Y + Height - Height / 15, Width / 15, Height / 15);
            graphics.DrawRectangle(p, Start.X + Width - Width / 15, Start.Y + Height - Height / 15, Width / 15, Height / 15);
        }
    }
}
