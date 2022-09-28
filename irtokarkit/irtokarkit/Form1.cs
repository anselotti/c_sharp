namespace irtokarkit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
           try
            {

                double kgPrice = double.Parse(textBoxKg.Text);
                double money = double.Parse(textBoxMoney.Text);
                double sum = money / kgPrice;

                labelSum.Text = "Rahalla saa karkkia: " + sum + " kiloa.";
            }
            
            catch
            {

                MessageBox.Show("Vain luvut ovat sallittuja!");
            }


        }
    }
}