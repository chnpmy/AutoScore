using System;
using System.Windows.Forms;

namespace AutoScore
{
    public partial class MyForm : Form
    {
        private static int _answer = -1;    //答案
        private static bool _hasBeenInited = false; //是否初始化的标志，没什么大用
        private static int _score = 0;  //玩家的分数

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

        //使用这种写法以达到在n个菜单项中选一个的效果
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
            if (sixtyToolStripMenuItem.Checked)
                mainProgressBar.Maximum = 60;
            else if (ThirtyToolStripMenuItem.Checked)
                mainProgressBar.Maximum = 30;
            else
                mainProgressBar.Maximum = 10;
            mainProgressBar.Value = mainProgressBar.Maximum;
            progressBarTimer.Enabled = true;
        }

        //生成下一题
        private void NextCal()
        {
            txtAnswer.Text = "";
            txtAnswer.Select();
            txtAnswer.Focus();
            lblEmotion.Text = "☺";
            
            Random random = new Random();
            int firstNum = random.Next(100);
            lblFirstNum.Text = firstNum.ToString();
            int secondNum = random.Next(99) + 1;//除法要注意除数不为0
            lblSecondNum.Text = secondNum.ToString();
            string strAdd = "＋";
            string strMin = "－";
            string strMul = "×";
            string strDvi = "÷";
            int operatorChoice = random.Next(4);
            int answer = -1;
            switch (operatorChoice)
            {
                case 0:
                    lblOperator.Text = strAdd;
                    answer = firstNum + secondNum;
                    break;
                case 1:
                    lblOperator.Text = strMin;
                    answer = firstNum - secondNum;
                    break;
                case 2:
                    lblOperator.Text = strMul;
                    answer = firstNum * secondNum;
                    break;
                case 3:
                    lblOperator.Text = strDvi;
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
            lblEmotion.Text = "☺";
        }

        private void label5_MouseDown(object sender, MouseEventArgs e)
        {
            lblEmotion.Text = "☻";
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //这个函数主要做的是验证答案的事情
        private void button1_Click(object sender, EventArgs e)
        {
            if (!_hasBeenInited)
                return;
            int answer = -1;
            try
            {
                answer = Int32.Parse(txtAnswer.Text);
            }
            catch (System.Exception exception)
            {
                
            }
            if (_answer != answer)
            {
                lblEmotion.Text = "☹";
            }
            else
            {
                //每答对一题加1分
                _score++;
                lblEmotion.Text = "☻";
                //Easy、Middle、hard区别在于每答对一题分别加时5s、3s、1s
                if (easyToolStripMenuItem.Checked)
                {
                    if (mainProgressBar.Value <= mainProgressBar.Maximum - 5)
                        mainProgressBar.Value += 5;
                    else
                        mainProgressBar.Value = mainProgressBar.Maximum;
                }
                else if (middleToolStripMenuItem.Checked)
                {
                    if (mainProgressBar.Value <= mainProgressBar.Maximum - 3)
                        mainProgressBar.Value += 3;
                    else
                        mainProgressBar.Value = mainProgressBar.Maximum;
                }
                else
                {
                    if (mainProgressBar.Value <= mainProgressBar.Maximum - 1)
                        mainProgressBar.Value += 1;
                    else
                        mainProgressBar.Value = mainProgressBar.Maximum;
                }
            }
            Application.DoEvents();                                 //这一句真的是非常的重要啊，否则后边的Sleep函数效果有问题
            System.Threading.Thread.Sleep(100);
            NextCal();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //设置答案框里的回车键功能
            if (e.KeyChar == '\r')
            {
                button1_Click(sender, e);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //计时函数，要注意判断是否越界
            if (mainProgressBar.Value == 0)
            {
                progressBarTimer.Enabled = false;
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
                mainProgressBar.Value--;
            }
    }

        private void MyForm_Load(object sender, EventArgs e)
        {
            easyToolStripMenuItem.Checked = true;
            sixtyToolStripMenuItem.Checked = true;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help_form f = new Help_form();
            f.Show();
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectTime(sender);
        }

        void SelectTime(object sender)
        {
            sixtyToolStripMenuItem.Checked = false;
            ThirtyToolStripMenuItem.Checked = false;
            tenToolStripMenuItem.Checked = false;
            ((ToolStripMenuItem) sender).Checked = true;
        }

        private void sToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SelectTime(sender);
        }

        private void sToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SelectTime(sender);
        }
    }
}
