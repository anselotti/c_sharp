using System.Runtime.CompilerServices;

namespace lämpötila
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;

                for (i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    // creating variables of all times of a day
                    double zeroZero = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
                    double three = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
                    double six = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                    double nine = Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                    double twelve = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                    double fifteen = Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                    double eighteen = Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);
                    double twentyOne = Convert.ToDouble(dataGridView1.Rows[i].Cells[8].Value);

                    // creating array that can calculate min, avg and max of each day
                    double[] times = { zeroZero, three, six, nine, twelve, fifteen, eighteen, twentyOne };

                    double average = times.Average();

                    double min = times.Min();

                    double max = times.Max();


                    // printing avg, min and max of the day to the dgview
                    dataGridView1.Rows[i].Cells[9].Value = min.ToString();
                    dataGridView1.Rows[i].Cells[10].Value = max.ToString();
                    dataGridView1.Rows[i].Cells[11].Value = average.ToString();

                    // printing min, max and avg of the WEEK to textboxes (those are outside of the dgview) 
                    tbLowest.Text = (from DataGridViewRow row in dataGridView1.Rows
                                     where row.Cells[9].FormattedValue.ToString() != string.Empty
                                     select Convert.ToDouble(row.Cells[9].FormattedValue)).Min().ToString("0.0");
                    tbHighest.Text = (from DataGridViewRow row in dataGridView1.Rows
                                      where row.Cells[10].FormattedValue.ToString() != string.Empty
                                      select Convert.ToDouble(row.Cells[10].FormattedValue)).Max().ToString("0.0");

                    tbAverage.Text = (from DataGridViewRow row in dataGridView1.Rows
                                      where row.Cells[11].FormattedValue.ToString() != string.Empty
                                      select Convert.ToDouble(row.Cells[11].FormattedValue)).Average().ToString("0.0");


                }
            } catch { MessageBox.Show("Fill every days of the week and times of the week."); }
            

                
            
        }
    }
}