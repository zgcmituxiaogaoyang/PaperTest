namespace FrmPaperTestByTxt
{
    partial class FrmMain
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblContent = new System.Windows.Forms.Label();
            this.panelPaper = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblCompanyInfo = new System.Windows.Forms.Label();
            this.lblNowDate = new System.Windows.Forms.Label();
            this.ckbA = new System.Windows.Forms.CheckBox();
            this.ckbB = new System.Windows.Forms.CheckBox();
            this.ckbC = new System.Windows.Forms.CheckBox();
            this.ckbD = new System.Windows.Forms.CheckBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelTitle.SuspendLayout();
            this.panelPaper.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Blue;
            this.panelTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTitle.Controls.Add(this.btnQuit);
            this.panelTitle.Controls.Add(this.lblContent);
            this.panelTitle.Location = new System.Drawing.Point(0, -1);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(423, 43);
            this.panelTitle.TabIndex = 0;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Blue;
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuit.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnQuit.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Location = new System.Drawing.Point(377, -1);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(46, 44);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "×";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblContent.ForeColor = System.Drawing.Color.White;
            this.lblContent.Location = new System.Drawing.Point(3, 10);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(230, 21);
            this.lblContent.TabIndex = 0;
            this.lblContent.Text = "中国移动模拟考试系统";
            // 
            // panelPaper
            // 
            this.panelPaper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelPaper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPaper.Controls.Add(this.lblInfo);
            this.panelPaper.Controls.Add(this.btnStart);
            this.panelPaper.Location = new System.Drawing.Point(0, 42);
            this.panelPaper.Name = "panelPaper";
            this.panelPaper.Size = new System.Drawing.Size(423, 224);
            this.panelPaper.TabIndex = 1;
            this.panelPaper.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPaper_Paint);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInfo.Location = new System.Drawing.Point(122, 110);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(148, 21);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "试卷密封中...";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(315, 110);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "抽取试题";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblCompanyInfo
            // 
            this.lblCompanyInfo.AutoSize = true;
            this.lblCompanyInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCompanyInfo.ForeColor = System.Drawing.Color.White;
            this.lblCompanyInfo.Location = new System.Drawing.Point(3, 11);
            this.lblCompanyInfo.Name = "lblCompanyInfo";
            this.lblCompanyInfo.Size = new System.Drawing.Size(232, 16);
            this.lblCompanyInfo.TabIndex = 2;
            this.lblCompanyInfo.Text = "北京同友创业信息技术有限公司";
            // 
            // lblNowDate
            // 
            this.lblNowDate.AutoSize = true;
            this.lblNowDate.ForeColor = System.Drawing.Color.White;
            this.lblNowDate.Location = new System.Drawing.Point(295, 15);
            this.lblNowDate.Name = "lblNowDate";
            this.lblNowDate.Size = new System.Drawing.Size(41, 12);
            this.lblNowDate.TabIndex = 3;
            this.lblNowDate.Text = "label1";
            this.lblNowDate.Click += new System.EventHandler(this.lblNowDate_Click);
            // 
            // ckbA
            // 
            this.ckbA.AutoSize = true;
            this.ckbA.Location = new System.Drawing.Point(39, 92);
            this.ckbA.Name = "ckbA";
            this.ckbA.Size = new System.Drawing.Size(15, 14);
            this.ckbA.TabIndex = 4;
            this.ckbA.UseVisualStyleBackColor = true;
            // 
            // ckbB
            // 
            this.ckbB.AutoSize = true;
            this.ckbB.Location = new System.Drawing.Point(39, 128);
            this.ckbB.Name = "ckbB";
            this.ckbB.Size = new System.Drawing.Size(15, 14);
            this.ckbB.TabIndex = 5;
            this.ckbB.UseVisualStyleBackColor = true;
            // 
            // ckbC
            // 
            this.ckbC.AutoSize = true;
            this.ckbC.Location = new System.Drawing.Point(39, 163);
            this.ckbC.Name = "ckbC";
            this.ckbC.Size = new System.Drawing.Size(15, 14);
            this.ckbC.TabIndex = 6;
            this.ckbC.UseVisualStyleBackColor = true;
            // 
            // ckbD
            // 
            this.ckbD.AutoSize = true;
            this.ckbD.Location = new System.Drawing.Point(39, 200);
            this.ckbD.Name = "ckbD";
            this.ckbD.Size = new System.Drawing.Size(15, 14);
            this.ckbD.TabIndex = 7;
            this.ckbD.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 58);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(29, 12);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "题干";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(65, 93);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(41, 12);
            this.lblA.TabIndex = 9;
            this.lblA.Text = "label1";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(65, 129);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(41, 12);
            this.lblB.TabIndex = 10;
            this.lblB.Text = "label2";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(65, 164);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(41, 12);
            this.lblC.TabIndex = 11;
            this.lblC.Text = "label3";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(65, 201);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(41, 12);
            this.lblD.TabIndex = 12;
            this.lblD.Text = "label4";
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(39, 233);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(75, 23);
            this.btnPre.TabIndex = 13;
            this.btnPre.Text = "上一题";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(143, 233);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "下一题";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(297, 233);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "提交答卷";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.lblCompanyInfo);
            this.panel1.Controls.Add(this.lblNowDate);
            this.panel1.Location = new System.Drawing.Point(0, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 36);
            this.panel1.TabIndex = 16;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(423, 298);
            this.Controls.Add(this.panelPaper);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ckbD);
            this.Controls.Add(this.ckbC);
            this.Controls.Add(this.ckbB);
            this.Controls.Add(this.ckbA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelPaper.ResumeLayout(false);
            this.panelPaper.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Panel panelPaper;
        private System.Windows.Forms.Label lblCompanyInfo;
        private System.Windows.Forms.Label lblNowDate;
        private System.Windows.Forms.CheckBox ckbA;
        private System.Windows.Forms.CheckBox ckbB;
        private System.Windows.Forms.CheckBox ckbC;
        private System.Windows.Forms.CheckBox ckbD;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
    }
}

