using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoScore.Properties;

namespace AutoScore
{
    public partial class MyForm : Form
    {
        private static int _answer = -1;
        private static bool _hasBeenInited = false;
        private static int _score = 0;

        public MyForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void copyrightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Copyright_form().ShowDialog();
        }

        private void Hard_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Hard_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectDifficulyLevel(sender);
        }

        private void SelectDifficulyLevel(object sender)
        {
            easyToolStripMenuItem.Checked = false;
            middleToolStripMenuItem.Checked = false;
            hardToolStripMenuItem.Checked = false;
            ((ToolStripMenuItem)sender).Checked = true;
        }

        private void middleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectDifficulyLevel(sender);
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectDifficulyLevel(sender);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label5_Click(sender, e);
        }

        private void StartGame()
        {
            _score = 0;
            //进度条倒计时开始
            progressBar1.Value = 60;
            timer1.Enabled = true;
        }

        private void NextCal()
        {
            textBox1.Text = "";
            textBox1.Select();
            textBox1.Focus();
            label5.Text = "☺";
            
            Random random = new Random();
            int firstNum = random.Next(100);
            label1.Text = firstNum.ToString();
            int secondNum = random.Next(99) + 1;
            label3.Text = secondNum.ToString();
            string strAdd = "＋";
            string strMin = "－";
            string strMul = "×";
            string strDvi = "÷";
            int operatorChoice = random.Next(4);
            int answer = -1;
            switch (operatorChoice)
            {
                case 0:
                    label2.Text = strAdd;
                    answer = firstNum + secondNum;
                    break;
                case 1:
                    label2.Text = strMin;
                    answer = firstNum - secondNum;
                    break;
                case 2:
                    label2.Text = strMul;
                    answer = firstNum * secondNum;
                    break;
                case 3:
                    label2.Text = strDvi;
                    answer = firstNum / secondNum;
                    break;
            }
            _answer = answer;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            _hasBeenInited = true;
            StartGame();
            NextCal();
            label5.Text = "☺";
        }

        private void label5_MouseDown(object sender, MouseEventArgs e)
        {
            label5.Text = "☻";
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!_hasBeenInited)
                return;
            int answer = -1;
            try
            {
                answer = Int32.Parse(textBox1.Text);
            }
            catch (System.Exception exception)
            {
                
            }
            if (_answer != answer)
            {
                label5.Text = "☹";
            }
            else
            {
                _score++;
                label5.Text = "☻";
                if (easyToolStripMenuItem.Checked)
                {
                    if (progressBar1.Value <= progressBar1.Maximum - 5)
                        progressBar1.Value += 5;
                    else
                        progressBar1.Value = progressBar1.Maximum;
                }
                else if (middleToolStripMenuItem.Checked)
                {
                    if (progressBar1.Value <= progressBar1.Maximum - 3)
                        progressBar1.Value += 3;
                    else
                        progressBar1.Value = progressBar1.Maximum;
                }
                else
                {
                    if (progressBar1.Value <= progressBar1.Maximum - 1)
                        progressBar1.Value += 1;
                    else
                        progressBar1.Value = progressBar1.Maximum;
                }
            }
            Application.DoEvents();
            System.Threading.Thread.Sleep(100);
            NextCal();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                button1_Click(sender, e);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 0)
            {
                timer1.Enabled = false;
                if (MessageBox.Show("Your score is " + _score + "! Again?", "OK!",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    openToolStripMenuItem_Click(sender, e);
                }
                else
                {
                    System.Environment.Exit(0);
                }
            }
            else
            {
                progressBar1.Value--;
            }
    }

        private void MyForm_Load(object sender, EventArgs e)
        {
            easyToolStripMenuItem.Checked = true;
        }
    }
}
