namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public static double AreaOfTriangle = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form lomake2 = new Form2();
            
            lomake2.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = AreaOfTriangle.ToString();
        }
    }
}