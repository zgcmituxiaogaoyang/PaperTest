using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FrmPaperTestByTxt
{
    [Serializable]
    public class Paper
    {
        public Paper()
        {
            this.questions = new List<Question>();
        }
        private List<Question> questions;
        public List<Question> Questions
        {
            get { return this.questions; }
        }
        //抽取试题
        public void ExtractQuestions()
        {
            FileStream fs = new FileStream("questions.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.Default);
            string content = sr.ReadToEnd();
            string[] questionArray = content.Split('&');
            string[] question = null;
            foreach (string item in questionArray)
            {
                question = item.Trim().Split(Convert.ToChar("\r"));
                this.questions.Add(new Question()
                {
                    Title = question[0].Trim(),
                    OptionA = question[1].Trim(),
                    OptionB = question[2].Trim(),
                    OptionC = question[3].Trim(),
                    OptionD = question[4].Trim(),
                    QAnswer = new Answer() { RightAnswer = question[5].Trim() }
                });
            }
            sr.Close();
            fs.Close();
        }
        //保存试卷
        public void SavePaper()
        {
            FileStream fs = new FileStream("questions.obj", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, this.questions);
            fs.Close();
        }
        public void GetPaper()
        {
            FileStream fs = new FileStream("questions.obj", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            this.questions = (List<Question>)bf.Deserialize(fs);
            fs.Close();
        }
        public int SubmitPaper()
        {
            int score = 0;
            foreach(Question item in this.questions)
            {
                if (item.QAnswer.SelectAnswer == string.Empty) continue;
                if (item.QAnswer.SelectAnswer.Equals(item.QAnswer.RightAnswer))
                {
                    score += 20;
                }
            }
            return score;
        }
    }
}
