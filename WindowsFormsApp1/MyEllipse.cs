using System;
using System.Drawing;

namespace WindowsFormsApp1
{
    public class MyEllipse : AObject2D
    {
        public MyEllipse() : base()
        {
        }

        public MyEllipse(Point point1, Point point2) : base(point1, point2)
        {
        }

        public override void FillSolid(Graphics graphics)
        {
            graphics.FillEllipse(new SolidBrush(InnerColor), Start.X, Start.Y, Width, Height);
            graphics.DrawEllipse(new Pen(OuterColor), Start.X, Start.Y, Width, Height);
        }

        public override void FillLinear(Graphics graphics)
        {
            int[] arrayRGB = new int[3] { 255, 0, 0 };
            int incORdec = -20;
            int currentIndex = 0;
            int currentColor = arrayRGB[currentIndex];

            int x = Start.X;
            int y = Start.Y;
            int width = Width;
            int height = Height;

            for (; x < (width + Start.X) + 2; x++, y++, width -= 2, height -= 2, currentColor += incORdec)
            {
                arrayRGB[currentIndex] = currentColor;
                if (currentColor >= (256 - Math.Abs(incORdec)) && incORdec > 0)
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

                if (currentColor <= Math.Abs(incORdec) && incORdec < 0)
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
                graphics.FillEllipse(
                new SolidBrush(Color.FromArgb(arrayRGB[0], arrayRGB[1], arrayRGB[2])),
                x, y,
                width, height
                );
            }
        }

        public override void FillRandom(Graphics graphics)
        {
            Random random = new Random();
            Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

            int x = Start.X;
            int y = Start.Y;
            int width = Width;
            int height = Height;

            for (; x < width + Start.X; x++, y++, width -= 2, height -= 2)
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

                graphics.FillEllipse(
                new SolidBrush(color),
                x, y,
                width, height
                );
            }
        }

        public override AObject2D Clone()
        {
            return (AObject2D)MemberwiseClone();
        }
    }
}
