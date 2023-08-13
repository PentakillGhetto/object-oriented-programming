using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxF3.Text =
                (new Fraction(int.Parse(textBoxF1Num.Text), int.Parse(textBoxF1Denum.Text))
                +
                new Fraction(int.Parse(textBoxF2Num.Text), int.Parse(textBoxF2Denum.Text)))
                .ToString()
                ;
            }
            catch (FormatException)
            {
                MessageBox.Show("Entered data is incomplete");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Entered data is inacceptable");
            }
        }

        private void buttonSubstract_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxF3.Text =
                (new Fraction(int.Parse(textBoxF1Num.Text), int.Parse(textBoxF1Denum.Text))
                -
                new Fraction(int.Parse(textBoxF2Num.Text), int.Parse(textBoxF2Denum.Text)))
                .ToString()
                ;
            }
            catch (FormatException)
            {
                MessageBox.Show("Entered data is incomplete");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Entered data is inacceptable");
            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxF3.Text =
                (new Fraction(int.Parse(textBoxF1Num.Text), int.Parse(textBoxF1Denum.Text))
                *
                new Fraction(int.Parse(textBoxF2Num.Text), int.Parse(textBoxF2Denum.Text)))
                .ToString()
                ;
            }
            catch (FormatException)
            {
                MessageBox.Show("Entered data is incomplete");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Entered data is inacceptable");
            }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxF3.Text =
                (new Fraction(int.Parse(textBoxF1Num.Text), int.Parse(textBoxF1Denum.Text))
                /
                new Fraction(int.Parse(textBoxF2Num.Text), int.Parse(textBoxF2Denum.Text)))
                .ToString()
                ;
            }
            catch (FormatException)
            {
                MessageBox.Show("Entered data is incomplete");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Entered data is inacceptable");
            }
        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxF3.Text =
                new Fraction(int.Parse(textBoxF1Num.Text), int.Parse(textBoxF1Denum.Text))
                >= new Fraction(int.Parse(textBoxF2Num.Text), int.Parse(textBoxF2Denum.Text))
                ? new Fraction(int.Parse(textBoxF1Num.Text), int.Parse(textBoxF1Denum.Text)).ToString()
                : new Fraction(int.Parse(textBoxF2Num.Text), int.Parse(textBoxF2Denum.Text)).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Entered data is incomplete");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Entered data is inacceptable");
            }
        }
    }
}
