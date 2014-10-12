namespace AutoScore
{
    partial class MyForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difficultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.middleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sixtyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThirtyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.copyrightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainProgressBar = new System.Windows.Forms.ProgressBar();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblEmotion = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblEqual = new System.Windows.Forms.Label();
            this.lblSecondNum = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblFirstNum = new System.Windows.Forms.Label();
            this.progressBarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mainMenuStrip);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 24);
            this.panel1.TabIndex = 0;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(690, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.difficultyToolStripMenuItem,
            this.timeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // difficultyToolStripMenuItem
            // 
            this.difficultyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem,
            this.middleToolStripMenuItem,
            this.hardToolStripMenuItem});
            this.difficultyToolStripMenuItem.Name = "difficultyToolStripMenuItem";
            this.difficultyToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.difficultyToolStripMenuItem.Text = "Difficulty Level";
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.easyToolStripMenuItem.Text = "Easy";
            this.easyToolStripMenuItem.Click += new System.EventHandler(this.easyToolStripMenuItem_Click);
            // 
            // middleToolStripMenuItem
            // 
            this.middleToolStripMenuItem.Name = "middleToolStripMenuItem";
            this.middleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.middleToolStripMenuItem.Text = "Middle";
            this.middleToolStripMenuItem.Click += new System.EventHandler(this.middleToolStripMenuItem_Click);
            // 
            // hardToolStripMenuItem
            // 
            this.hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            this.hardToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hardToolStripMenuItem.Text = "Hard";
            this.hardToolStripMenuItem.Click += new System.EventHandler(this.hardToolStripMenuItem_Click);
            // 
            // timeToolStripMenuItem
            // 
            this.timeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sixtyToolStripMenuItem,
            this.ThirtyToolStripMenuItem,
            this.tenToolStripMenuItem});
            this.timeToolStripMenuItem.Name = "timeToolStripMenuItem";
            this.timeToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.timeToolStripMenuItem.Text = "Time";
            // 
            // sixtyToolStripMenuItem
            // 
            this.sixtyToolStripMenuItem.Name = "sixtyToolStripMenuItem";
            this.sixtyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sixtyToolStripMenuItem.Text = "60s";
            this.sixtyToolStripMenuItem.Click += new System.EventHandler(this.sToolStripMenuItem_Click);
            // 
            // ThirtyToolStripMenuItem
            // 
            this.ThirtyToolStripMenuItem.Name = "ThirtyToolStripMenuItem";
            this.ThirtyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ThirtyToolStripMenuItem.Text = "30s";
            this.ThirtyToolStripMenuItem.Click += new System.EventHandler(this.sToolStripMenuItem1_Click);
            // 
            // tenToolStripMenuItem
            // 
            this.tenToolStripMenuItem.Name = "tenToolStripMenuItem";
            this.tenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tenToolStripMenuItem.Text = "10s";
            this.tenToolStripMenuItem.Click += new System.EventHandler(this.sToolStripMenuItem2_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.toolStripSeparator2,
            this.copyrightToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // copyrightToolStripMenuItem
            // 
            this.copyrightToolStripMenuItem.Name = "copyrightToolStripMenuItem";
            this.copyrightToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyrightToolStripMenuItem.Text = "Copyright";
            this.copyrightToolStripMenuItem.Click += new System.EventHandler(this.copyrightToolStripMenuItem_Click);
            // 
            // mainProgressBar
            // 
            this.mainProgressBar.Location = new System.Drawing.Point(-1, 323);
            this.mainProgressBar.Maximum = 60;
            this.mainProgressBar.Name = "mainProgressBar";
            this.mainProgressBar.Size = new System.Drawing.Size(694, 21);
            this.mainProgressBar.TabIndex = 1;
            // 
            // pnlMain
            // 
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
            this.pnlMain.Controls.Add(this.lblEmotion);
            this.pnlMain.Controls.Add(this.btnGo);
            this.pnlMain.Controls.Add(this.txtAnswer);
            this.pnlMain.Controls.Add(this.lblEqual);
            this.pnlMain.Controls.Add(this.lblSecondNum);
            this.pnlMain.Controls.Add(this.lblOperator);
            this.pnlMain.Controls.Add(this.lblFirstNum);
            this.pnlMain.Location = new System.Drawing.Point(13, 30);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(665, 287);
            this.pnlMain.TabIndex = 2;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblEmotion
            // 
            this.lblEmotion.AutoSize = true;
            this.lblEmotion.Font = new System.Drawing.Font("幼圆", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEmotion.Image = ((System.Drawing.Image)(resources.GetObject("lblEmotion.Image")));
            this.lblEmotion.Location = new System.Drawing.Point(265, 0);
            this.lblEmotion.Name = "lblEmotion";
            this.lblEmotion.Size = new System.Drawing.Size(114, 97);
            this.lblEmotion.TabIndex = 6;
            this.lblEmotion.Text = "☺";
            this.lblEmotion.Click += new System.EventHandler(this.label5_Click);
            this.lblEmotion.DoubleClick += new System.EventHandler(this.label5_Click);
            this.lblEmotion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label5_MouseDown);
            this.lblEmotion.MouseLeave += new System.EventHandler(this.label5_MouseLeave);
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.SkyBlue;
            this.btnGo.Font = new System.Drawing.Font("幼圆", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGo.Location = new System.Drawing.Point(525, 123);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(118, 69);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "Go!";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.BackColor = System.Drawing.Color.LightGray;
            this.txtAnswer.Font = new System.Drawing.Font("幼圆", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAnswer.Location = new System.Drawing.Point(385, 123);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(118, 69);
            this.txtAnswer.TabIndex = 4;
            this.txtAnswer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lblEqual
            // 
            this.lblEqual.AutoSize = true;
            this.lblEqual.Font = new System.Drawing.Font("幼圆", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEqual.Image = ((System.Drawing.Image)(resources.GetObject("lblEqual.Image")));
            this.lblEqual.Location = new System.Drawing.Point(327, 126);
            this.lblEqual.Name = "lblEqual";
            this.lblEqual.Size = new System.Drawing.Size(52, 56);
            this.lblEqual.TabIndex = 3;
            this.lblEqual.Text = "=";
            // 
            // lblSecondNum
            // 
            this.lblSecondNum.AutoSize = true;
            this.lblSecondNum.Font = new System.Drawing.Font("幼圆", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSecondNum.Image = ((System.Drawing.Image)(resources.GetObject("lblSecondNum.Image")));
            this.lblSecondNum.Location = new System.Drawing.Point(241, 126);
            this.lblSecondNum.Name = "lblSecondNum";
            this.lblSecondNum.Size = new System.Drawing.Size(80, 56);
            this.lblSecondNum.TabIndex = 2;
            this.lblSecondNum.Text = "ha";
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Font = new System.Drawing.Font("幼圆", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOperator.Image = ((System.Drawing.Image)(resources.GetObject("lblOperator.Image")));
            this.lblOperator.Location = new System.Drawing.Point(155, 126);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(80, 56);
            this.lblOperator.TabIndex = 1;
            this.lblOperator.Text = "＋";
            // 
            // lblFirstNum
            // 
            this.lblFirstNum.AutoSize = true;
            this.lblFirstNum.Font = new System.Drawing.Font("幼圆", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFirstNum.Image = ((System.Drawing.Image)(resources.GetObject("lblFirstNum.Image")));
            this.lblFirstNum.Location = new System.Drawing.Point(69, 126);
            this.lblFirstNum.Name = "lblFirstNum";
            this.lblFirstNum.Size = new System.Drawing.Size(80, 56);
            this.lblFirstNum.TabIndex = 0;
            this.lblFirstNum.Text = "ha";
            this.lblFirstNum.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // progressBarTimer
            // 
            this.progressBarTimer.Interval = 1000;
            this.progressBarTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 343);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.mainProgressBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MyForm";
            this.Text = "AutoScore";
            this.Load += new System.EventHandler(this.MyForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem copyrightToolStripMenuItem;
        private System.Windows.Forms.ProgressBar mainProgressBar;
        private System.Windows.Forms.ToolStripMenuItem difficultyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem middleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblFirstNum;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblEqual;
        private System.Windows.Forms.Label lblSecondNum;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblEmotion;
        private System.Windows.Forms.Timer progressBarTimer;
        private System.Windows.Forms.ToolStripMenuItem timeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sixtyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThirtyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tenToolStripMenuItem;
    }
}

