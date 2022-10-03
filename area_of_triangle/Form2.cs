using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double triangleBase = Convert.ToDouble(textBoxBase.Text);
            double triangleHeight = Convert.ToDouble(textBoxHeight.Text);
            double areaOfTriangle = triangleBase * triangleHeight / 2;
            textBoxResult.Text = areaOfTriangle.ToString();

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Form1.AreaOfTriangle = Convert.ToDouble(textBoxResult.Text);
        }
    }
}
