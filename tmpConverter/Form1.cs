namespace tmpConverter
{
    public partial class Form1 : Form
    {
        // Creating subprograms 
        public static double FahrenheitToCelsius (double Fahr)
        {
            return (Fahr-32) / 1.8;
        }

        public static double CelsiusToFahrenheit (double Cels)
        {
            return Cels * 9 / 5 + 32;
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConv_Click(object sender, EventArgs e)
        {

            try
            {

                double temp = double.Parse(textBoxTemp.Text);
                double tempResult = 0;

                // terms when user selects which way wants to convert

                if (radioButtonFtoC.Checked)
                {
                    tempResult = FahrenheitToCelsius(temp); // calling subprogram 
                }

                if (radioButtonCtoF.Checked)
                {
                    tempResult = CelsiusToFahrenheit(temp); // calling subprogram
                }

                textBoxResult.Text = tempResult.ToString();

            } catch { MessageBox.Show("Use valis numbers!"); }
            

        }
    }
}