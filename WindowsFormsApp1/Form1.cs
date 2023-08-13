using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //Dictionary<string,Object2DFactory> factory;
        private MyCanvas canvas;

        public Form1()
        {
            InitializeComponent();
            //factory = new Dictionary<string, Object2DFactory>();
            //factory.Add("ellipse", new EllipseFactory());
            canvas = new MyCanvas
            {
                Graphics = panelDrawingArea.CreateGraphics()
            };
        }

        private void PanelDrawingArea_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    if (canvas.Current == null) return;
                    canvas.Current.End = e.Location;
                    canvas.Add(canvas.Current);
                    break;
                case MouseButtons.Right:
                    break;
            }
            canvas.Render();
        }

        private void PanelDrawingArea_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                canvas.Touch(e.Location);
                panelDrawingArea.Refresh();
                canvas.Render();
            }
        }

        private void PanelDrawingArea_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    if (canvas.Current == null) return;
                    canvas.Current.Start = e.Location;
                    break;
                case MouseButtons.Right:
                    canvas.Select(e.X, e.Y);
                    break;
            }
        }

        private void ToolStripButtonOuterColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                canvas.SetOuterColor(colorDialog.Color);
            }
            canvas.Render();
        }

        private void ToolStripButtonInnerColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                canvas.SetInnerColor(colorDialog.Color);
            }
            canvas.Render();
        }

        private void ToolStripButtonSave_Click(object sender, EventArgs e)
        {
            using (Bitmap bitmap = new Bitmap(panelDrawingArea.Width, panelDrawingArea.Height))
            {
                Rectangle rectangle = panelDrawingArea.RectangleToScreen(panelDrawingArea.ClientRectangle);
                Graphics.FromImage(bitmap).CopyFromScreen(rectangle.Location, Point.Empty, panelDrawingArea.Size);
                bitmap.Save(AppDomain.CurrentDomain.BaseDirectory + "image.png", System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void ToolStripButtonDrawLine_Click(object sender, EventArgs e)
        {
            canvas.Current = new MyLine();
        }

        private void ToolStripButtonDrawCircle_Click(object sender, EventArgs e)
        {
            //string s = ((ToolStripButton)sender).Text;
            //current = factory["ellipse"].GetObject2D();
            canvas.Current = new MyEllipse();
        }

        private void ToolStripButtonDrawRectangle_Click(object sender, EventArgs e)
        {
            canvas.Current = new MyRectangle();
        }

        private void ToolStripButtonDrawTriangle_Click(object sender, EventArgs e)
        {
            canvas.Current = new MyTriangle();
        }

        private void ToolStripButtonDrawPine_Click(object sender, EventArgs e)
        {
            canvas.Current = new Snowman();
        }
    }
}
