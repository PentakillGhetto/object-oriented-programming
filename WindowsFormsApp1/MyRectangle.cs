using System;
using System.Drawing;

namespace WindowsFormsApp1
{
    class MyRectangle : AObject2D
    {
        public MyRectangle() : base()
        {
        }

        public MyRectangle(Point point1, Point point2) : base(point1, point2)
        {
        }

        public override void FillSolid(Graphics graphics)
        {
            graphics.FillRectangle(new SolidBrush(InnerColor), Start.X, Start.Y, Width, Height);
            graphics.DrawRectangle(new Pen(OuterColor), Start.X, Start.Y, Width, Height);
        }

        public override void FillLinear(Graphics graphics)
        {
            int[] arrayRGB = new int[3] { 255, 0, 0 };
            int incORdec = -2;
            int currentIndex = 0;
            int currentColor = arrayRGB[currentIndex];

            for (int x = Start.X; x < Width + Start.X; x++, currentColor += incORdec)
            {
                arrayRGB[currentIndex] = currentColor;
                if (currentColor >= 254 && incORdec > 0)
                {
                    if (currentIndex == 0)
                    {
                        currentIndex = 2;
                        incORdec = -incORdec;
                        currentColor = arrayRGB[currentIndex];
                    }
                    else
                    {
                        incORdec = -incORdec;
                        currentIndex--;
                        currentColor = arrayRGB[currentIndex];
                    }
                }

                if (currentColor <= 2 && incORdec < 0)
                {
                    if (currentIndex == 0)
                    {
                        currentIndex = 2;
                        incORdec = -incORdec;
                        currentColor = arrayRGB[currentIndex];
                    }
                    else
                    {
                        incORdec = -incORdec;
                        currentIndex--;
                        currentColor = arrayRGB[currentIndex];
                    }
                }
                graphics.FillRectangle(
                new SolidBrush(Color.FromArgb(arrayRGB[0], arrayRGB[1], arrayRGB[2])),
                x, Start.Y,
                1, Height
                );
            }
        }

        public override void FillRandom(Graphics graphics)
        {
            Random random = new Random();
            Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

            for (int x = Start.X; x < Width + Start.X; x++)
            {
                int rStep = random.Next(-5, 6);
                int gStep = random.Next(-5, 6);
                int bStep = random.Next(-5, 6);

                if (rStep >= 0)
                {
                    if (color.R < 250)
                    {
                        color = Color.FromArgb(color.R + rStep, color.G, color.B);
                    }
                }
                else
                {
                    if (color.R > 5)
                    {
                        color = Color.FromArgb(color.R + rStep, color.G, color.B);
                    }
                }

                if (gStep >= 0)
                {
                    if (color.G < 250)
                    {
                        color = Color.FromArgb(color.R, color.G + gStep, color.B);
                    }
                }
                else
                {
                    if (color.G > 5)
                    {
                        color = Color.FromArgb(color.R, color.G + gStep, color.B);
                    }
                }

                if (bStep >= 0)
                {
                    if (color.B < 250)
                    {
                        color = Color.FromArgb(color.R, color.G, color.B + bStep);
                    }
                }
                else
                {
                    if (color.B > 5)
                    {
                        color = Color.FromArgb(color.R, color.G, color.B + bStep);
                    }
                }

                graphics.FillRectangle(
                    new SolidBrush(color),
                    x, Start.Y,
                    1, Height
                    );
            }
        }

        public override AObject2D Clone()
        {
            return (AObject2D)MemberwiseClone();
        }
    }
}
