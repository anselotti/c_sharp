namespace temperature_converter
{
    public partial class Form1 : Form
    {
        public static double Temperature = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Temperature = Convert.ToDouble(textBox1.Text);

                Form form2 = new Form2();
                form2.ShowDialog();

            } catch { MessageBox.Show("Set valid numbers!"); }
            

        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            textBox1.Text = Temperature.ToString();
        }
    }
}