using System.Globalization;

namespace painoindeksi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            try // aloitetaan virheen tarkistuksella

            {   // m‰‰ritell‰‰n muuttujat ja tehd‰‰n niist‰ reaaliluvut

                double weightKg = double.Parse(textBoxKg.Text);
                double lenghtM = double.Parse(textBoxM.Text);
               
                double sum = weightKg * 1.3;
                double sum2 = Math.Pow(lenghtM,2.5); // potenssiinlasku

                double weightIndex = sum / sum2;

                weightIndex = Math.Round(weightIndex * 2) / 2; // pyˆristet‰‰n tulos


                labelIndex.Text = "Sinun painoindeksi on: " + weightIndex.ToString(); // Tulostetaan painoindeksi
            }

            // kerrotaan k‰ytt‰j‰lle virheist‰

            catch
            {

                MessageBox.Show("Sallittuja vain numerot ja pilkut!");

            }
        }


    }
}