using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        MyDate date;
        public Form1()
        {
            InitializeComponent();
            labelCurrentDate.Text = DateTime.Today.ToShortDateString();
            date = new MyDate();
            date.SetDate(DateTime.Today.Day, DateTime.Today.Month, DateTime.Today.Year);
        }

        private void buttonNextDay_Click(object sender, EventArgs e)
        {
            date.NextDate();
            labelCurrentDate.Text = date.ToString();
        }

        private void buttonSetDate_Click(object sender, EventArgs e)
        {
            try
            {
                int d = int.Parse(textBoxDay.Text);
                int m = int.Parse(textBoxMonth.Text);
                int y = int.Parse(textBoxYear.Text);
                date.SetDate(d, m, y);
                labelCurrentDate.Text = date.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены некорректные данные.");
            }
        }
    }
}
