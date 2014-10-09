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
            StartGame();
        }

        private void StartGame()
        {
            Random random = new Random();
            int firstNum = random.Next(100);
            label1.Text = firstNum.ToString();
            int secondNum = random.Next(100);
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
            openToolStripMenuItem_Click(sender, e);
            label5.Text = "☺";
            _hasBeenInited = true;
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
            int answer = Int32.Parse(textBox1.Text);
            if (_answer != answer)
            {
                label5.Text = "☹";
            }
            else
            {
                label5.Text = "☻";
            }
            Application.DoEvents();
            System.Threading.Thread.Sleep(100);
            label5_Click(sender, e);
        }
    }
}
