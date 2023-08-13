using System;

namespace WindowsFormsApp4
{
    class Vector
    {
        public Point3D Start { get; set; }
        public Point3D End { get; set; }
        public Point3D Direction{ get => new Point3D(End.X - Start.X, End.Y - Start.Y, End.Z - Start.Z); }
        public double Length { get => Math.Round(Math.Sqrt(Math.Pow(Direction.X, 2) + Math.Pow(Direction.Y, 2) + Math.Pow(Direction.Z, 2)), 2); }


        public Vector() { }
        public Vector(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            Start = new Point3D(x1, y1, z1);
            End = new Point3D(x2, y2, z2);
        }

        public static Vector operator +(Vector vector1, Vector vector2)
        {
            // direction = new Point3D(vector2.End.X - vector1.Start.X, vector2.End.Y - vector1.Start.Y, vector2.End.Z - vector1.Start.Z)
            return new Vector(vector1.Start.X, vector1.Start.Y, vector1.Start.Z, vector2.End.X, vector2.End.Y, vector2.End.Z);
        }

        public static Vector operator -(Vector vector1, Vector vector2)
        {
            // direction = new Point3D(vector1.End.X - vector2.End.X, vector1.End.Y - vector2.End.Y, vector1.End.Z - vector2.End.Z)
            return new Vector(vector2.End.X, vector2.End.Y, vector2.End.Z, vector1.End.X, vector1.End.Y, vector1.End.Z);
        }

        public double MultiplyScalar(Vector vector1)
        {
            return (Direction.X * vector1.Direction.X) + (Direction.Y * vector1.Direction.Y) + (Direction.Z * vector1.Direction.Z);
        }

        public double Cos(Vector vector1)
        {
            return Math.Round(this.MultiplyScalar(vector1) / (this.Length * vector1.Length), 2);
        }

        public override string ToString()
        {
            return Direction.ToString();
        }
    }
}
