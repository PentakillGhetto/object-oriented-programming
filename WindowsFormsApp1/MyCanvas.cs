using System.Collections.Generic;
using System.Drawing;

namespace WindowsFormsApp1
{
    class MyCanvas
    {
        private List<AObject2D> drawablesList;
        private Manipulator manipulator;

        public Graphics Graphics { get; set; }
        public AObject2D Selected { get; set; }
        public AObject2D Current { get; set; }

        public MyCanvas()
        {
            drawablesList = new List<AObject2D>();
            manipulator = new Manipulator();
        }

        public void Render()
        {
            this.Render(Graphics);
        }

        public void Render(Graphics graphics)
        {
            foreach (AObject2D item in drawablesList)
                item.FillSolid(graphics);
            if (manipulator.IsAttached) manipulator.FillSolid(graphics);
        }

        public void Add(AObject2D item)
        {
            drawablesList.Add(item.Clone());
        }

        public void Select(int x, int y)
        {
            if (manipulator.IsAttached)
            {
                if (manipulator.ContainsPoint(x, y))
                {
                    manipulator.Touch(new Point(x, y));
                }
            }

            foreach (AObject2D item in drawablesList)
            {
                if (item.ContainsPoint(x, y))
                {
                    Selected = item;
                    manipulator.Attach(Selected);
                    return;
                }
            }

            Selected = null;
            manipulator.Detach();
        }

        public void SetOuterColor(Color color)
        {
            if (Selected != null) Selected.OuterColor = color;
        }

        public void SetInnerColor(Color color)
        {
            if (Selected != null) Selected.InnerColor = color;
        }

        public void Touch(Point location)
        {            
            this.Touch(Selected, location);
        }

        public void Touch(AObject2D item, Point location)
        {
            if (item != null && manipulator.IsAttached) manipulator.Touch(item, location);
        }
    }
}
