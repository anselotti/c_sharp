using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace makihyppy3
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

                int i = 0; // variable for for-loop

                for (i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    // creating variables and loading data of values inputted to datagridview by user 
                    double jumpLenght = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
                    int kPoint = Convert.ToInt16(dataGridView1.Rows[i].Cells[2].Value);
                    double windValue = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);

                    // creating variables to calculate points
                    double windCompensation = windValue * (kPoint - 36) / 20;
                    double windPoints = windCompensation * 1.8; // total of windpoints
                    double jumpPoints = 0;
                    double stylePoints = 0;
                    double totalPoints = 0;

                    // jump points are dependent of lenght of the jump so have to set terms before we continue

                    if (jumpLenght > kPoint)
                    {
                        jumpPoints = (jumpLenght - kPoint) * 1.8 + 60;

                    }
                    if (jumpLenght <= kPoint)
                    {
                        jumpPoints = (jumpLenght - kPoint) * 1.8;
                    }



                    // picks all the judges from the dgview and make an array of them.
                    // after that i sort the array and leave the worst and the best judges out of the total style points.
                    double jud1 = Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                    double jud2 = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                    double jud3 = Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                    double jud4 = Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);
                    double jud5 = Convert.ToDouble(dataGridView1.Rows[i].Cells[8].Value);

                    double[] stylePointsArray = new double[5] { jud1, jud2, jud3, jud4, jud5 };

                    Array.Sort(stylePointsArray);

                    stylePoints = stylePointsArray[1] + stylePointsArray[2] + stylePointsArray[3];

                    totalPoints = stylePoints + jumpPoints + windPoints; // calculates all the points 
                    totalPoints = Math.Round(totalPoints / 0.5) * 0.5;  // and rounding to closest .5.

                    // printing all the points to dgview
                    dataGridView1.Rows[i].Cells[9].Value = windPoints;
                    dataGridView1.Rows[i].Cells[10].Value = jumpPoints;
                    dataGridView1.Rows[i].Cells[11].Value = stylePoints;
                    dataGridView1.Rows[i].Cells[12].Value = totalPoints.ToString();  // printing the total points to result box of dgview

                }

            } catch { MessageBox.Show("Input valid numbers and characters."); }                          


        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Clears all the data from dgview
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    dataGridView1.Rows[j].Cells[i].Value = "";
                }
            }
        }
    }
}