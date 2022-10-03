using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace temperature_converter
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form1.Temperature.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                double temperature = Convert.ToDouble(textBox1.Text);
                double FtoC = 0;
                double CtoF = 0;

                if (radioButtonFtoC.Checked)
                {
                    FtoC = (temperature - 32) / 1.8;
                    Math.Round(FtoC, 2);

                    textBox1.Text = FtoC.ToString("0.00");


                }

                if (radioButtonCtoF.Checked)
                {
                    CtoF = temperature * 9 / 5 + 32;
                    Math.Round(CtoF, 2);

                    textBox1.Text = CtoF.ToString("0.00");


                }

            } catch { MessageBox.Show("Set valid numbers!"); }
            


        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Form1.Temperature = Convert.ToDouble(textBox1.Text);
        }
    }
}
