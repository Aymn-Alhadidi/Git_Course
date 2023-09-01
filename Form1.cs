using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remembering_Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double PlayerAnswer;

        public struct stGameInfo
        {
            public short NumberOfRightQuestions, NumberOfWrongQuestion, NumberOfQusetion;
            public double RandNumber;
            public DateTime GetTime;
            public TimeSpan TimeLeft;
        }
        public static stGameInfo GameInfo;

        private void Form1_Load(object sender, EventArgs e)
        {
            btnStats.FlatAppearance.BorderSize = 0;
            btnNew.FlatAppearance.BorderSize = 0;
        }

        void WriteTheAnswer(Button btn)
        {
            txtPlayerAnswer.Text += btn.Text;
        }
        double GetRandomNumber()
        {
            Random RandomNumber = new Random();

            switch (cbNumOfDigits.SelectedItem)
            {
                case "2":
                    return RandomNumber.Next(10, 99);
                    break;

                case "3":
                    return RandomNumber.Next(100, 999);
                    break;

                case "4":
                    return RandomNumber.Next(1000, 9999);
                    break;

                case "5":
                    return RandomNumber.Next(10000, 99999);
                    break;

                case "6":
                    return RandomNumber.Next(100000, 999999);
                    break;

                case "7":
                    return RandomNumber.Next(1000000, 9999999);
                    break;


                default:
                    return RandomNumber.Next(10000000, 99999999);
            }
        }
        short GetAppropriateTime()
        {
            switch (cbNumOfDigits.SelectedItem)
            {
                case "2":
                    return 2;
                    break;

                case "3":
                    return 2;
                    break;

                case "4":
                    return 3;
                    break;

                case "5":
                    return 3;
                    break;

                case "6":
                    return 4;
                    break;

                case "7":
                    return 5;
                    break;

                default:
                    return 6;

            }
        }

        void ResetStatsOfGame()
        {
            GameInfo.NumberOfQusetion = 0;
            GameInfo.NumberOfRightQuestions = 0;
            GameInfo.NumberOfWrongQuestion = 0;

        }

        void EndRound()
        {
            txtRandNumber.BackColor = Color.White;
            txtPlayerAnswer.BackColor = Color.White;

            txtPlayerAnswer.Text = string.Empty;
            txtRandNumber.Text = string.Empty;

            cbNumOfDigits.SelectedItem = "2";
            panelNumbers.Visible = false;

            timer1.Enabled = false;

            btnShow.Enabled = true;
            btnHide.Enabled = false;
            btnDone.Enabled = false;
        }
        void CheckAnswer(double PlayerAnswer)
        {
            if(PlayerAnswer == GameInfo.RandNumber)
            {
                GameInfo.NumberOfRightQuestions++;
                txtRandNumber.Text = GameInfo.RandNumber.ToString();
                txtRandNumber.BackColor = Color.Green;
                txtPlayerAnswer.BackColor = Color.Green;
                GameInfo.NumberOfQusetion++;

                MessageBox.Show("Right Answer :)", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            if(PlayerAnswer != GameInfo.RandNumber)
            {
                GameInfo.NumberOfWrongQuestion++;
                txtRandNumber.Text = GameInfo.RandNumber.ToString();
                txtRandNumber.BackColor = Color.Red;
                txtPlayerAnswer.BackColor = Color.Red;
                GameInfo.NumberOfQusetion++;

                MessageBox.Show("Wrong Answer :(", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            EndRound();
        }
        void SetTime()
        {
            //GameInfo.GetTime = DateTime.Today.AddSeconds(GetAppropriateTime());

            GameInfo.TimeLeft = TimeSpan.FromSeconds(GetAppropriateTime());
            lbTimeLeft.Text = GameInfo.TimeLeft.ToString("ss") + "S";
        }
        bool DigitValidation()
        {
            if (cbNumOfDigits.SelectedItem != null)
            {
                errorProvider1.Clear();
                return true;
            }

            else
            {
                errorProvider1.SetError(cbNumOfDigits, "You should Choice Digit");
                return false;
            }
        }
        bool PlayerAnswerValidation()
        {
            if (txtPlayerAnswer.Text == "")
            {
                errorProvider1.SetError(txtPlayerAnswer, "You Should Write Number First");
                return false;
            }

            else
            {
                errorProvider1.Clear();
                return true;
            }

        }
        bool GameValidation()
        {
            if (DigitValidation() && PlayerAnswerValidation())
                return true;

            return false;
        }
        void Show()
        {

            GameInfo.RandNumber = GetRandomNumber();
            txtRandNumber.Text = GameInfo.RandNumber.ToString();
            timer1.Enabled = true;

        }
        void Hide()
        {
            if(GameInfo.TimeLeft.ToString("ss") != "00")
                timer1.Enabled = false;

            txtRandNumber.Text = "?";
            panelNumbers.Visible = true;

        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (DigitValidation())
            {
                Show();


                btnHide.Enabled = true;
                btnDone.Enabled = true;
                btnShow.Enabled = false;
            }
        }
        private void btnHide_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private void cbNumOfDigits_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetTime();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            WriteTheAnswer(btn1);
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            WriteTheAnswer(btn2);
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            WriteTheAnswer(btn3);
        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            if (PlayerAnswerValidation())
            {
                PlayerAnswer = Convert.ToDouble(txtPlayerAnswer.Text);
                CheckAnswer(PlayerAnswer);

            }

        }
        private void btn4_Click(object sender, EventArgs e)
        {
            WriteTheAnswer(btn4);
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            WriteTheAnswer(btn5);
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            WriteTheAnswer(btn6);
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            WriteTheAnswer(btn7);
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            WriteTheAnswer(btn8);
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            WriteTheAnswer(btn9);
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            WriteTheAnswer(btn0);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPlayerAnswer.Text = string.Empty;
            PlayerAnswer = 0;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtPlayerAnswer.Text.Length == 1)
            {
                txtPlayerAnswer.Text = string.Empty;
                PlayerAnswer = 0;
            }

            if (txtPlayerAnswer.Text.Length == 0)
                return;

            txtPlayerAnswer.Text = txtPlayerAnswer.Text.Substring(0, txtPlayerAnswer.Text.Length - 1);
            PlayerAnswer = Convert.ToDouble(txtPlayerAnswer.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(GameInfo.TimeLeft.ToString("ss") == "00")
            {
                Hide();
            }

            else
            {
                GameInfo.TimeLeft = GameInfo.TimeLeft.Subtract(TimeSpan.FromSeconds(1));
                lbTimeLeft.Text = GameInfo.TimeLeft.ToString("ss") + "S";
            }
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            StatsForm frmStats = new StatsForm();
            frmStats.ShowDialog();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ResetStatsOfGame();
        }
    }
}
