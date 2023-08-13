using System;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        Vector vector1;
        Vector vector2;

        public Form1()
        {
            InitializeComponent();
            vector1 = new Vector();
            vector2 = new Vector();
            foreach (Control control in Controls)
            {
                if (control.GetType() == typeof(TextBox)) control.TextChanged += new EventHandler(TextBox_TextChanged);
            }

            Reset();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            try
            {
                vector1.Start = new Point3D(
                    double.Parse(textBoxV1StartX.Text),
                    double.Parse(textBoxV1StartY.Text),
                    double.Parse(textBoxV1StartZ.Text)
                    );
                vector1.End = new Point3D(
                    double.Parse(textBoxV1EndX.Text),
                    double.Parse(textBoxV1EndY.Text),
                    double.Parse(textBoxV1EndZ.Text));

                vector2.Start = new Point3D(
                    double.Parse(textBoxV2StartX.Text),
                    double.Parse(textBoxV2StartY.Text),
                    double.Parse(textBoxV2StartZ.Text)
                    );
                vector2.End = new Point3D(
                    double.Parse(textBoxV2EndX.Text),
                    double.Parse(textBoxV2EndY.Text),
                    double.Parse(textBoxV2EndZ.Text)
                    );

                labelV2Direction.Text = vector2.ToString();
                labelV1Direction.Text = vector1.ToString();
                labelV1Length.Text = vector1.Length.ToString();
                labelV2Length.Text = vector2.Length.ToString();
                labelCosV1V2.Text = vector1.Cos(vector2).ToString();
                labelScalarMult.Text = vector1.MultiplyScalar(vector2).ToString();
            }
            catch (FormatException)
            {

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                labelV3Direction.Text = new Point3D(
                    vector1.Direction.X + vector2.Direction.X,
                    vector1.Direction.Y + vector2.Direction.Y,
                    vector1.Direction.Z + vector2.Direction.Z
                    ).ToString();
            }
            catch (NullReferenceException)
            {

            }
        }

        private void buttonSubstract_Click(object sender, EventArgs e)
        {
            try
            {
                labelV3Direction.Text = labelV3Direction.Text = new Point3D(
                    vector1.Direction.X - vector2.Direction.X,
                    vector1.Direction.Y - vector2.Direction.Y,
                    vector1.Direction.Z - vector2.Direction.Z
                    ).ToString();
            }
            catch (NullReferenceException)
            {

            }
        }
    }
}
