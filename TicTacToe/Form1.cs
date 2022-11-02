using System.Text;
using System.Threading.Tasks.Dataflow;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace TicTacToe
{

    public partial class Form1 : Form
    {
        
        bool playerTurn = true;
        int turnCount = 0;
        public static string player1name = "";
        public static string player2name = "";
        int player1count = 0;
        int player2count = 0;
        
               
        Button[,] board;
         

        public Form1()
        {
            
            InitializeComponent();

            labelPlayer1.Text = player1name;
            labelPlayer2.Text = player2name;
            scoreboardPlayer1.Text = player1name;
            scoreBoardPlayer2.Text = player2name;

            player1icon.BackColor = Color.PaleGreen;
            player2icon.BackColor = Color.Transparent;

            board = new Button[3, 3] { { button1, button2, button3 },
                                       { button4, button5, button6 },
                                       { button7, button8, button9 } };

            
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            
                                    
            if (playerTurn == true)
            {
                player2icon.BackColor = Color.PaleGreen;
                player1icon.BackColor = Color.Transparent;
            }

            if (playerTurn == false)
            {
                player1icon.BackColor = Color.PaleGreen;
                player2icon.BackColor = Color.Transparent;
            }

            Button b = (Button)sender;
            if (playerTurn == true)
            {
                b.Text = "X";

            }
            else
            {
                b.Text = "O";
            }

            playerTurn = !playerTurn;
            turnCount++;
            b.Enabled = false;
            CheckWinner();
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            foreach (Button b in board)
                b.Enabled = true;

            foreach (Button b in board)
                b.Text = "";

            turnCount = 0;
            playerTurn = true;

            player1icon.BackColor = Color.PaleGreen;
            player2icon.BackColor = Color.Transparent;

            


        }

        
        private void CheckWinner()
        {
            bool winner = false;
            
            if ((button1.Text == button2.Text) && (button2.Text == button3.Text) && button1.Text != "")
            {
                winner = true;    
            }
            if ((button1.Text == button4.Text) && (button4.Text == button7.Text) && button1.Text != "")
            {
                winner = true;
            }
            if ((button1.Text == button5.Text) && (button5.Text == button9.Text) && button1.Text != "")
            {
                winner = true;
            }

            if ((button2.Text == button5.Text) && (button5.Text == button8.Text) && button2.Text != "")
            {
                winner = true;
            }
            if ((button3.Text == button6.Text) && (button6.Text == button9.Text) && button3.Text != "")
            {
                winner = true;
            }
            if ((button3.Text == button5.Text) && (button5.Text == button7.Text) && button3.Text != "")
            {
                winner = true;
            }
            if ((button4.Text == button5.Text) && (button5.Text == button6.Text) && button4.Text != "")
            {
                winner = true;
            }
            if ((button7.Text == button8.Text) && (button8.Text == button9.Text) && button7.Text != "")
            {
                winner = true;
            }
            if ((button7.Text == button5.Text) && (button5.Text == button3.Text) && button7.Text != "")
            {
                winner = true;
            }

            if (winner == true)
            {
                if (playerTurn == false)
                {
                    MessageBox.Show(labelPlayer1.Text + " won!");
                    player1count++;
                    labelPlayer1scores.Text = player1count.ToString();
                    
                }
                if (playerTurn == true)
                {
                    MessageBox.Show(labelPlayer2.Text + " won!");
                    player2count++;
                    labelPlayer2scores.Text = player2count.ToString();
                }

                                    
            }

            if (winner == false && turnCount == 9)
            {
                MessageBox.Show("Tie!");
            }

            if (winner == true && turnCount < 9)
            {

                button10.PerformClick();

            }

                        
            
            
                        
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}