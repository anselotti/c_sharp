using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string player1 = textBox1.Text;
            string player2 = textBox2.Text;

            Form1.player1name = textBox1.Text;
            Form1.player2name = textBox2.Text;

            this.Close();
        }
    }
}
