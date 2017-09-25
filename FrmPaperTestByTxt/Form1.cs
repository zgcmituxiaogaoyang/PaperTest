using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FrmPaperTestByTxt
{
    public partial class FrmMain : Form
    {
        private Paper paperObject = new Paper();
        public int questionIndex = 0;//记录当前试题序号
        public FrmMain()
        {
            InitializeComponent();
        }
        private void ShowQuestion(int index)
        {
            this.lblTitle.Text = this.paperObject.Questions[index].Title;
            this.lblA.Text = this.paperObject.Questions[index].OptionA;
            this.lblB.Text = this.paperObject.Questions[index].OptionB;
            this.lblC.Text = this.paperObject.Questions[index].OptionC;
            this.lblD.Text = this.paperObject.Questions[index].OptionD;
        }
        private void SaveAnswer()
        {
            string answer = string.Empty;
            if (this.ckbA.Checked)
                answer += "A";
            if (this.ckbB.Checked)
                answer += "B";
            if (this.ckbC.Checked)
                answer += "C";
            if (this.ckbD.Checked)
                answer += "D";
            this.paperObject.Questions[this.questionIndex].QAnswer.SelectAnswer = answer;
        }
        private void RestAnswer(int questionIndex)
        {
            this.ckbA.Checked = this.paperObject.Questions[questionIndex].QAnswer.SelectAnswer.Contains("A");
            this.ckbB.Checked = this.paperObject.Questions[questionIndex].QAnswer.SelectAnswer.Contains("B");
            this.ckbC.Checked = this.paperObject.Questions[questionIndex].QAnswer.SelectAnswer.Contains("C");
            this.ckbD.Checked = this.paperObject.Questions[questionIndex].QAnswer.SelectAnswer.Contains("D");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.lblNowDate.Text = DateTime.Now.ToString();
            timer1.Enabled = true;
           
        }

        private void panelPaper_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblNowDate_Click(object sender, EventArgs e)
        {

        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (questionIndex == 0) return;
            else
            {
                SaveAnswer();
                questionIndex--;
                ShowQuestion(questionIndex);
                RestAnswer(questionIndex);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (questionIndex == paperObject.Questions.Count - 1) return;
            else
            {
                SaveAnswer();
                questionIndex++;
                ShowQuestion(questionIndex);
                RestAnswer(questionIndex);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SaveAnswer();
            int score = this.paperObject.SubmitPaper();
            this.lblInfo.Text = string.Format($"您的成绩：{score}分！");
            this.panelPaper.Visible = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            paperObject.ExtractQuestions();
            this.panelPaper.Visible = false;
            ShowQuestion(0);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblNowDate.Text = DateTime.Now.ToString();
        }
    }
}
