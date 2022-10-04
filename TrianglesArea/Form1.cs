namespace TrianglesArea
{
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();
        }

        public static double AreaOfTriangle (double triBase, double triHeight)
        {
            return triBase * triHeight / 2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            double triBase2, triHeight2, triArea;

            triBase2 = double.Parse(textBoxBase.Text);
            triHeight2 = double.Parse(textBoxHeight.Text);

            triArea = AreaOfTriangle(triBase2, triHeight2);
            textBox3.Text = triArea.ToString("0.00");
        }
    }
}