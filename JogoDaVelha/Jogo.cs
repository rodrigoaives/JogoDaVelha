using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class DarkMountain : Form
    {
        int totalWins1 = 0, totalWins2;
        int velha = 0;
        public DarkMountain()
        {
            InitializeComponent();           
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (lblVez.Text == "Jogador 1 é sua Vez!")
            {
                btn1.Text = "X";
                lblVez.Text = "Jogador 2 é sua Vez!";
            }
            else 
                {
                    btn1.Text = "O";
                    lblVez.Text = "Jogador 1 é sua Vez!";
                }
                timerGanhou.Start();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (lblVez.Text == "Jogador 1 é sua Vez!")
            {
                btn2.Text = "X";
                lblVez.Text = "Jogador 2 é sua Vez!";
            }
            else
            {
                btn2.Text = "O";
                lblVez.Text = "Jogador 1 é sua Vez!";
            }
            timerGanhou.Start();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (lblVez.Text == "Jogador 1 é sua Vez!")
            {
                btn3.Text = "X";
                lblVez.Text = "Jogador 2 é sua Vez!";
            }
            else
            {
                btn3.Text = "O";
                lblVez.Text = "Jogador 1 é sua Vez!";
            }
            timerGanhou.Start();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (lblVez.Text == "Jogador 1 é sua Vez!")
            {
                btn4.Text = "X";
                lblVez.Text = "Jogador 2 é sua Vez!";
            }
            else
            {
                btn4.Text = "O";
                lblVez.Text = "Jogador 1 é sua Vez!";
            }
            timerGanhou.Start();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (lblVez.Text == "Jogador 1 é sua Vez!")
            {
                btn5.Text = "X";
                lblVez.Text = "Jogador 2 é sua Vez!";
            }
            else
            {
                btn5.Text = "O";
                lblVez.Text = "Jogador 1 é sua Vez!";
            }
            timerGanhou.Start();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (lblVez.Text == "Jogador 1 é sua Vez!")
            {
                btn6.Text = "X";
                lblVez.Text = "Jogador 2 é sua Vez!";
            }
            else
            {
                btn6.Text = "O";
                lblVez.Text = "Jogador 1 é sua Vez!";
            }
            timerGanhou.Start();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (lblVez.Text == "Jogador 1 é sua Vez!")
            {
                btn7.Text = "X";
                lblVez.Text = "Jogador 2 é sua Vez!";
            }
            else
            {
                btn7.Text = "O";
                lblVez.Text = "Jogador 1 é sua Vez!";
            }
            timerGanhou.Start();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (lblVez.Text == "Jogador 1 é sua Vez!")
            {
                btn8.Text = "X";
                lblVez.Text = "Jogador 2 é sua Vez!";
            }
            else
            {
                btn8.Text = "O";
                lblVez.Text = "Jogador 1 é sua Vez!";
            }
            timerGanhou.Start();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (lblVez.Text == "Jogador 1 é sua Vez!")
            {
                btn9.Text = "X";
                lblVez.Text = "Jogador 2 é sua Vez!";
            }
            else
            {
                btn9.Text = "O";
                lblVez.Text = "Jogador 1 é sua Vez!";
            }
            timerGanhou.Start();
        }

        private void timerGanhou_Tick(object sender, EventArgs e)
        {

            timerGanhou.Stop();

            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X"
           || btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X"
           || btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X"
           || btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X"
           || btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X"
           || btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X"
           || btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X"
           || btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X"
           )
            {
                MessageBox.Show("Jogador 1 ganhou! Parabéns!");                
                lblWins1.Text = Convert.ToString(totalWins1 += 1);
            }

            else if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O"
               || btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O"
               || btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O"
               || btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O"
               || btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O"
               || btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O"
               || btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O"
               || btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O"
               )
            {
                MessageBox.Show("Jogador 2 ganhou! Parabéns!");                
                lblWins2.Text = Convert.ToString (totalWins2 += 1);
            }
            else if (btn1.Text !="" && btn2.Text !="" && btn3.Text !="" &&
                btn4.Text !="" && btn5.Text != "" && btn6.Text != "" &&
                btn7.Text != "" && btn8.Text != "" && btn9.Text !="" && totalWins1 == totalWins1 && totalWins2 == totalWins2) {
                MessageBox.Show("Deu velha!");
            }
            }

        private void btnJogarNovamente_Click(object sender, EventArgs e)
        {
            Limpar();
        }
                
        private void Limpar()
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
         }
    }
}
