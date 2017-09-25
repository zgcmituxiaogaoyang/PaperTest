using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmPaperTestByTxt
{
    [Serializable]
    public class Question
    {
        public Question()
        {
            this.QAnswer = new FrmPaperTestByTxt.Answer();
        }
        public int QuestionId { get; set; }
        public string Title { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public Answer QAnswer { get; set; }
    }
}
